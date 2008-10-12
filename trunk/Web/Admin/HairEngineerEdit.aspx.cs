using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using HairNet.Entry;
using HairNet.Business;
using HairNet.Utilities;
using HairNet.Enumerations;
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class HairEngineerEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindClass();
                this.bindShop();
                this.bindBaseInfo();
            }
        }

        private void bindClass()
        {
            ddlHairShopClass.DataSource = InfoAdmin.GetHairEngineerClasses();
            ddlHairShopClass.DataTextField = "Name";
            ddlHairShopClass.DataValueField = "ID";
            ddlHairShopClass.DataBind();
        }

        private void bindShop()
        {
            ddlHairShop.DataSource = InfoAdmin.GetHairShops(0, OrderKey.ID);
            ddlHairShop.DataTextField = "HairShopName";
            ddlHairShop.DataValueField = "HairShopID";
            ddlHairShop.DataBind();
        }

        void bindBaseInfo()
        {
            int hairEngineerID = int.Parse(Request["id"]);
            HairEngineer he = InfoAdmin.GetHairEngineerByHairEngineerID(hairEngineerID);
            //txtHairEngineerAge.Text = he.HairEngineerAge;
            txtHairEngineerDescription.Text = he.HairEngineerDescription;
            txtHairEngineerName.Text = he.HairEngineerName;
            txtHairEngineerTel.Text = he.HairEngineerTel;
            txtHairEngineerRawPrice.Text = he.HairEngineerRawPrice;
            txtHairEngineerSkill.Text = he.HairEngineerSkill;
            txtHairEngineerYear.Text = he.HairEngineerYear;

            txtHairEngineerTag.Text = InfoAdmin.GetHairEngineerTagNames(he.HairEngineerTagIDs);

            ddlHairShop.SelectedValue = he.HairShopID.ToString();
            ddlHairShopClass.SelectedValue = he.HairEngineerClassID.ToString();
            rBtnListHairEngineerSex.SelectedValue = he.HairEngineerSex.ToString();
            
            this.chkIsImportant.Checked = he.IsImportant;

            foreach (ListItem lli in this.ddlConstellation.Items)
            {
                if (lli.Text == he.HairEngineerConstellation)
                {
                    lli.Selected = true;
                    break;
                }
            }

            //imgPhoto.ImageUrl = he.HairEngineerPhoto;
            int num = 0;
            string picString = string.Empty;
            string pic = string.Empty;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "select * from enginpics where classid=1 and ownerid="+hairEngineerID.ToString();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            num++;

                            if (num == 1)
                            {
                                pic = "<img width=100 heigth=50 src='" + sdr["picsmallUrl"].ToString() + "' /><img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairengineeroperate.aspx?id=" + sdr["id"].ToString() + "&hid=" + hairEngineerID.ToString() + "'>删除</a>";
                            }
                            else
                            {
                                pic += "&nbsp;&nbsp;<img width=100 heigth=50 src='" + sdr["picsmallUrl"].ToString() + "' /><img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairengineeroperate.aspx?id=" + sdr["id"].ToString() + "&hid=" + hairEngineerID.ToString() + "'>删除</a>";
                            }
                           
                        }
                    }
                }
            }

            this.lblpicSring.Text = picString;
            this.lblPic.Text = pic;

            ViewState["HairEngineerInfo"] = he;
        }
        public void btnAddWork_OnClick(object sender, EventArgs e)
        {
            HairEngineer he = (HairEngineer)ViewState["HairEngineerInfo"];
            this.Response.Redirect("EngineerOpusInfo.aspx?ENGINEERID=" + he.HairEngineerID.ToString());
        }
        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            HairEngineer he = (HairEngineer)ViewState["HairEngineerInfo"];
            he.HairEngineerName = txtHairEngineerName.Text.Trim();
            //he.HairEngineerAge = txtHairEngineerAge.Text.Trim();
            he.HairEngineerSex = int.Parse(rBtnListHairEngineerSex.SelectedValue);
            he.HairEngineerTel = txtHairEngineerTel.Text.Trim();
            he.HairEngineerRawPrice = txtHairEngineerRawPrice.Text.Trim();
            he.HairEngineerYear = txtHairEngineerYear.Text.Trim();
            he.HairEngineerSkill = txtHairEngineerSkill.Text.Trim();
            he.HairEngineerDescription = txtHairEngineerDescription.Text.Trim();

            he.HairEngineerClassID = int.Parse(ddlHairShopClass.SelectedValue);
            he.HairShopID = int.Parse(ddlHairShop.SelectedValue);
            he.HairEngineerConstellation = this.ddlConstellation.SelectedItem.Text;

            //if (fileLogo.Value != "")
            //{
            //    UpLoadClass upload = new UpLoadClass();
            //    he.HairEngineerPhoto = upload.UpLoadImg(fileLogo, "/uploadfiles/pictures/");
            //    upload = null;
            //}
            //else
            //{
            //    he.HairEngineerPhoto = imgPhoto.ImageUrl;
            //}

            he.IsImportant = this.chkIsImportant.Checked;

            he.HairEngineerTagIDs = InfoAdmin.GetHairEngineerTagIDs(txtHairEngineerTag.Text.Trim());

            if (InfoAdmin.UpdateHairEngineer(he))
            {
                Session["HairEngineerInfo"] = he;

                this.Response.Redirect("HairEngineerAdmin.aspx");
            }
            else
            {
                this.Response.Write("更新失败！");
            }
        }

        public void btnPicSubmit_OnClick(object sender, EventArgs e)
        {
            string hairEngineerID = this.Request.QueryString["id"].ToString();
            UpLoadClass upload = new UpLoadClass();
            string picPath = upload.UpLoadImg(fileLogo, "/uploadfiles/pictures/");
            string picSmallPath = upload.UpLoadImg(smallLogo, "/uploadfiles/pictures/");

            if (picPath != string.Empty)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "insert into enginpics(picurl,picsmallurl,ownerid,classid) values('" + picPath + "','"+picSmallPath+"'," + hairEngineerID + ",1)";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
                this.Response.Redirect("HairEngineerEdit.aspx?id=" + hairEngineerID);
            }
        }
    }
}
