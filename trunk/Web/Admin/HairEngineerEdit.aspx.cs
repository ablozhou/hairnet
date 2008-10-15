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
                this.bindShop();
                this.bindBaseInfo();
            }
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

            //TAG逻辑

            if (he.HairEngineerTagIDs != string.Empty)
            {
                string[] tempTagC = he.HairEngineerTagIDs.Split(",".ToCharArray());
                for (int k = 0; k < tempTagC.Length; k++)
                {
                    HairEngineerTag hst = new HairEngineerTag();
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "select * from HairEngineerTag where HairEngineerTagID=" + tempTagC[k];
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = commString;
                            comm.Connection = conn;
                            conn.Open();
                            using (SqlDataReader sdr = comm.ExecuteReader())
                            {
                                if (sdr.Read())
                                {
                                    try
                                    {
                                        hst.TagID = int.Parse(sdr["HairEngineerTagID"].ToString());
                                        hst.TagName = sdr["HairEngineerTagName"].ToString();
                                        hst.HairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                                    }
                                    catch
                                    { }
                                }
                            }
                        }
                    }

                    if (k == 0)
                    {
                        this.txtHairEngineerTag.Text = hst.TagName;
                    }
                    else
                    {
                        this.txtHairEngineerTag.Text += "," + hst.TagName;
                    }
                }
            }

            //tag逻辑结束
            //txtHairEngineerAge.Text = he.HairEngineerAge;
            txtHairEngineerDescription.Text = he.HairEngineerDescription;
            txtHairEngineerName.Text = he.HairEngineerName;
            txtHairEngineerTel.Text = he.HairEngineerTel;
            txtHairEngineerRawPrice.Text = he.HairEngineerRawPrice;
            txtHairEngineerSkill.Text = he.HairEngineerSkill;
            txtHairEngineerYear.Text = he.HairEngineerYear;

            ddlHairShop.SelectedValue = he.HairShopID.ToString();
            txtHairEngineerClass.Text = he.HairEngineerClassID.ToString();
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

            //tag逻辑
            //先处理TAG逻辑，先删除HS所对应的所有TAG
            if (he.HairEngineerTagIDs != string.Empty)
            {
                string[] tempTagC = he.HairEngineerTagIDs.Split(",".ToCharArray());
                for (int k = 0; k < tempTagC.Length; k++)
                {
                    HairEngineerTag hst = new HairEngineerTag();
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "select * from HairEngineerTag where HairEngineerTagID=" + tempTagC[k];
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = commString;
                            comm.Connection = conn;
                            conn.Open();
                            using (SqlDataReader sdr = comm.ExecuteReader())
                            {
                                if (sdr.Read())
                                {
                                    try
                                    {
                                        hst.TagID = int.Parse(sdr["HairEngineerTagID"].ToString());
                                        hst.TagName = sdr["HairEngineerTagName"].ToString();
                                        hst.HairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                                    }
                                    catch
                                    { }
                                }
                            }
                        }
                    }
                    string[] tempHairEngineerIDC = hst.HairEngineerIDs.Split(",".ToCharArray());
                    string hairEngineerIDs = "";

                    int tempNum = 0;
                    for (int i = 0; i < tempHairEngineerIDC.Length; i++)
                    {
                        if (tempHairEngineerIDC[i] != he.HairEngineerID.ToString())
                        {
                            tempNum++;
                            if (tempNum == 1)
                            {
                                hairEngineerIDs = tempHairEngineerIDC[i];
                            }
                            else
                            {
                                hairEngineerIDs += "," + tempHairEngineerIDC[i];
                            }
                        }
                    }
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "update HairEngineerTag set HairEngineerIDs='" + hairEngineerIDs + "' where HairEngineerTagID=" + hst.TagID.ToString();
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = commString;
                            comm.Connection = conn;
                            conn.Open();
                            try
                            {
                                comm.ExecuteNonQuery();
                            }
                            catch
                            { }
                        }
                    }
                }
            }
            //

            he.HairEngineerName = txtHairEngineerName.Text.Trim();
            //he.HairEngineerAge = txtHairEngineerAge.Text.Trim();
            he.HairEngineerSex = int.Parse(rBtnListHairEngineerSex.SelectedValue);
            he.HairEngineerTel = txtHairEngineerTel.Text.Trim();
            he.HairEngineerRawPrice = txtHairEngineerRawPrice.Text.Trim();
            he.HairEngineerYear = txtHairEngineerYear.Text.Trim();
            he.HairEngineerSkill = txtHairEngineerSkill.Text.Trim();
            he.HairEngineerDescription = txtHairEngineerDescription.Text.Trim();

            he.HairEngineerClassID = txtHairEngineerClass.Text.Trim();
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

            //tag逻辑
            string id = he.HairEngineerID.ToString();
            string tagIDs = "";
            string[] tagCollection = txtHairEngineerTag.Text.Split(",".ToCharArray());
            for (int k = 0; k < tagCollection.Length; k++)
            {
                string tagID = "";
                bool isExist = false;
                HairEngineerTag hst = new HairEngineerTag();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from HairEngineerTag where HairEngineerTagName='" + tagCollection[k] + "'";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                try
                                {
                                    hst.TagID = int.Parse(sdr["HairEngineerTagID"].ToString());
                                    hst.TagName = sdr["HairEngineerTagName"].ToString();
                                    hst.HairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                                }
                                catch
                                { }
                            }
                        }
                    }
                }
                if (hst.TagID == 0)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "insert HairEngineerTag(HairEngineerTagName,HairEngineerIDs) values('" + tagCollection[k] + "','" + id.ToString() + "');select @@identity;";
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = commString;
                            comm.Connection = conn;
                            conn.Open();

                            tagID = comm.ExecuteScalar().ToString();
                        }
                    }
                }
                else
                {
                    tagID = hst.TagID.ToString();
                    if (hst.HairEngineerIDs == string.Empty)
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "update HairEngineerTag set HairEngineerIDs='" + id.ToString() + "' where HairEngineerTagID=" + hst.TagID.ToString();
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = commString;
                                comm.Connection = conn;
                                conn.Open();
                                try
                                {
                                    comm.ExecuteNonQuery();
                                }
                                catch
                                { }
                            }
                        }
                    }
                    else
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "update HairEngineerTag set HairEngineerIDs=HairEngineerIDs+'," + id.ToString() + "' where HairEngineerTagID=" + hst.TagID.ToString();
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = commString;
                                comm.Connection = conn;
                                conn.Open();
                                try
                                {
                                    comm.ExecuteNonQuery();
                                }
                                catch
                                { }
                            }
                        }
                    }
                }
                if (k == 0)
                {
                    tagIDs = tagID;
                }
                else
                {
                    tagIDs += "," + tagID;
                }
            }
            he.HairEngineerTagIDs = tagIDs;

            //tag结束

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
            System.Threading.Thread.Sleep(1000);
            string picSmallPath = upload.UpLoadImg(smallLogo, "/uploadfiles/pictures/");

            if (picPath != string.Empty)
            {
                string photoIDs = "";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select HairEngineerPhotoIDs from HairEngineer where HairEngineerID="+hairEngineerID;
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            photoIDs =comm.ExecuteScalar().ToString();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "insert into enginpics(picurl,picsmallurl,ownerid,classid) values('" + picPath + "','"+picSmallPath+"'," + hairEngineerID + ",1);select @@identity;";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            photoIDs += "," + comm.ExecuteScalar().ToString();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "update HairEngineer set HairEngineerPhotoIDs = '" + photoIDs + "' where HairEngineerID=" + hairEngineerID;
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
