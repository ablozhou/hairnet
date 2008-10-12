using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using HairNet.Business;
using HairNet.Enumerations;
using HairNet.Entry;
using HairNet.Utilities;
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class HairEngineerAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindShop();
            }

            if (!String.IsNullOrEmpty(Request.Params["id"]))
            {
                ddlHairShop.SelectedIndex = -1;

                foreach (ListItem item in ddlHairShop.Items)
                {
                    if (item.Value == Request.Params["id"])
                    {
                        item.Selected = true;
                        break;
                    }
                }

                ddlHairShop.Enabled = false;
            }
        }

        private void bindShop()
        {
            ddlHairShop.DataSource = InfoAdmin.GetHairShops(0, OrderKey.ID);
            ddlHairShop.DataTextField = "HairShopName";
            ddlHairShop.DataValueField = "HairShopID";
            ddlHairShop.DataBind();
        }

        //protected void btnSubmit_OnClick(object sender, EventArgs e)
        //{
        //    HairEngineer he = new HairEngineer();
        //    he.HairEngineerName = txtHairEngineerName.Text.Trim();
        //    //he.HairEngineerAge = txtHairEngineerAge.Text.Trim();
        //    he.HairEngineerSex = int.Parse(rBtnListHairEngineerSex.SelectedValue);
        //    he.HairEngineerTel = txtHairEngineerTel.Text.Trim();
        //    he.HairEngineerRawPrice = txtHairEngineerRawPrice.Text.Trim();
        //    he.HairEngineerYear = txtHairEngineerYear.Text.Trim();
        //    he.HairEngineerSkill = txtHairEngineerSkill.Text.Trim();
        //    he.HairEngineerDescription = txtHairEngineerDescription.Text.Trim();
        //    he.HairEngineerConstellation = this.ddlConstellation.SelectedItem.Text;
        //    he.HairEngineerClassID = this.txtHairEngineerClass.Text.Trim();
        //    he.HairShopID = int.Parse(ddlHairShop.SelectedValue);
            
        //    //UpLoadClass upload = new UpLoadClass();
        //    //he.HairEngineerPhoto = upload.UpLoadImg(fileLogo, "/uploadfiles/pictures/");

        //    he.HairEngineerTagIDs = InfoAdmin.GetHairEngineerTagIDs(txtHairEngineerTag.Text.Trim());

        //    Session["HairEngineerInfo"] = he;
        //    int id = InfoAdmin.AddHairEngineer(he);

        //    string[] photoSmallString = lblpicsmallString.Text.Split(";".ToCharArray());
        //    string[] photoString = lblpicSring.Text.Split(";".ToCharArray());
        //    for (int k = 0; k < photoString.Length; k++)
        //    {
        //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
        //        {
        //            string commString = "insert into enginpics(picurl,picsmallurl,ownerid,classid) values('" + photoString[k] + "','" + photoSmallString[k] + "'," + id.ToString() + ",1)";
        //            using (SqlCommand comm = new SqlCommand())
        //            {
        //                comm.CommandText = commString;
        //                comm.Connection = conn;
        //                conn.Open();
        //                try
        //                {
        //                    comm.ExecuteNonQuery();
        //                }
        //                catch (Exception ex)
        //                {
        //                    throw new Exception(ex.Message);
        //                }
        //            }
        //        }
        //    }
        //    ResetControlState();

        //    this.Response.Redirect("EngineerOpusInfo.aspx");
        //}

        protected void rBtnListHairEngineerSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ResetControlState()
        {
            txtHairEngineerName.Text = String.Empty;
            //txtHairEngineerAge.Text = String.Empty;
            rBtnListHairEngineerSex.SelectedIndex = 0;
            txtHairEngineerTel.Text = String.Empty;
            txtHairEngineerRawPrice.Text = String.Empty;
            txtHairEngineerYear.Text = String.Empty;
            txtHairEngineerSkill.Text = String.Empty;
            txtHairEngineerDescription.Text = String.Empty;
            //tbConstellation.Text = String.Empty;
            txtHairEngineerClass.Text = string.Empty;
            ddlHairShop.SelectedIndex = 0;
            txtHairEngineerTag.Text = String.Empty;
        }

        protected void btnHairEngineerAdd_Click(object sender, EventArgs e)
        {
            HairEngineer he = new HairEngineer();
            he.HairEngineerName = txtHairEngineerName.Text.Trim();
            //he.HairEngineerAge = txtHairEngineerAge.Text.Trim();
            he.HairEngineerSex = int.Parse(rBtnListHairEngineerSex.SelectedValue);
            he.HairEngineerTel = txtHairEngineerTel.Text.Trim();
            he.HairEngineerRawPrice = txtHairEngineerRawPrice.Text.Trim();
            he.HairEngineerYear = txtHairEngineerYear.Text.Trim();
            he.HairEngineerSkill = txtHairEngineerSkill.Text.Trim();
            he.HairEngineerDescription = txtHairEngineerDescription.Text.Trim();
            he.HairEngineerConstellation = this.ddlConstellation.SelectedItem.Text;
            he.HairEngineerClassID = txtHairEngineerClass.Text.Trim();
            he.HairShopID = int.Parse(ddlHairShop.SelectedValue);
            he.IsImportant = this.chkIsImportant.Checked;

            UpLoadClass upload = new UpLoadClass();
            he.HairEngineerPhoto = upload.UpLoadImg(fileLogo, "/uploadfiles/pictures/");

            he.HairEngineerTagIDs = InfoAdmin.GetHairEngineerTagIDs(txtHairEngineerTag.Text.Trim());

            Session["HairEngineerInfo"] = he;
            int id = InfoAdmin.AddHairEngineer(he);
            string[] photoSmallString = lblpicsmallString.Text.Split(";".ToCharArray());
            string[] photoString = lblpicSring.Text.Split(";".ToCharArray());
            for(int k=0;k<photoString.Length;k++)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "insert into enginpics(picurl,picsmallurl,ownerid,classid) values('" + photoString[k] + "','"+photoSmallString[k]+"'," + id.ToString() + ",1)";
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
            }

            ResetControlState();

            this.Response.Redirect("HairEngineerAddSwitch.aspx?id="+id.ToString()+"&shopid="+this.ddlHairShop.SelectedItem.Value);
        }
        public void btnPicSubmit_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string picPath = upload.UpLoadImg(fileLogo, "/uploadfiles/pictures/");
            string picSmallPath = upload.UpLoadImg(smallLogo, "/uploadfiles/pictures/");

            if (picPath != string.Empty)
            {
                if (this.lblpicSring.Text == string.Empty)
                {
                    lblpicSring.Text = picPath;
                    lblpicsmallString.Text = picSmallPath;
                    lblPic.Text = "<img width=100 height=50 src="+picSmallPath+"></img>&nbsp;&nbsp;<img width=200 heigth=100 src=" + picPath + "></img>";
                }
                else
                {
                    lblpicSring.Text = lblpicSring.Text + ";" + picPath;
                    lblpicsmallString.Text = lblpicsmallString.Text + ";" + picSmallPath;
                    lblPic.Text += "&nbsp;&nbsp;<img width=100 height=50 src=" + picSmallPath + "></img>&nbsp;&nbsp;<img width=200 heigth=100 src=" + picPath + "></img>";
                }
            }
        }
    }
}
