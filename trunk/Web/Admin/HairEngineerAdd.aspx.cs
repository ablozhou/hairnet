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
using HairNet.Provider;
using HairNet.Components.BackendBusiness;
using System.Text;


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

        public string buildBBSContent(HairEngineer he)
        {

            StringBuilder content=new StringBuilder();
            string[] pics = lblpicSring.Text.Split(";".ToCharArray());
            foreach (string pic in pics)
            {
                content.AppendLine("[img=300,400]" + pic + "[/img]");

            }
            content.AppendLine("美发师名称:" + he.HairEngineerName);
            content.AppendLine("所属美发店名称: " + he.HairShopName);
            content.AppendLine("简介: " + he.HairEngineerDescription);
            content.AppendLine("职位: " + he.HairEngineerClassID);
            content.AppendLine("剪发价格: " + he.HairEngineerRawPrice.ToString());
            content.AppendLine("技术擅长: " + he.HairEngineerSkill);
            content.AppendLine("工作年限: " + he.HairEngineerYear.ToString());
            content.AppendLine("星座: " + he.HairEngineerConstellation);
            content.AppendLine("预约电话: " + he.HairEngineerTel);
            content.AppendLine("[url=/HairdresserLastPage.aspx?id=" + he.HairEngineerID.ToString() + "]查看详情[/url]");

            return content.ToString();
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
            he.HairEngineerClassName = txtHairEngineerClass.Text.Trim();
            he.HairShopID = int.Parse(ddlHairShop.SelectedValue);
            he.HairShopName = ddlHairShop.SelectedItem.Text;
            he.IsImportant = this.chkIsImportant.Checked;

            UpLoadClass upload = new UpLoadClass();
            he.HairEngineerPhoto = upload.UpLoadImg(fileLogo, "/uploadfiles/pictures/");

            he.HairEngineerTagIDs = "";

                
            int id = InfoAdmin.AddHairEngineer(he);
            he.HairEngineerID = id;
           string content=buildBBSContent(he);
            int postId = 0;
            BBSPost post = new BBSPost();
            bool bSuc = post.AddPost(he.HairEngineerName, content, BBSPost.Category.HairEngineer, out postId);
            if (bSuc)
            {
                //update postid
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "update HairEngineer set postid=" + he.PostId.ToString() + " where HairEngineerID=" + he.HairEngineerID.ToString();
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

            Session["HairEngineerInfo"] = he;
            //TAG逻辑
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
            he.HairEngineerID = id;
            ProviderFactory.GetHairEngineerDataProviderInstance().HairEngineerCreateDeleteUpdate(he, UserAction.Update,out id);
            id = he.HairEngineerID;

            //个人图片逻辑
            string photoIDs = "";
            string[] photoSmallString = lblpicsmallString.Text.Split(";".ToCharArray());
            string[] photoString = lblpicSring.Text.Split(";".ToCharArray());
            for(int k=0;k<photoString.Length;k++)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "insert into enginpics(picurl,picsmallurl,ownerid,classid) values('" + photoString[k] + "','"+photoSmallString[k]+"'," + id.ToString() + ",1);select @@identity;";
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
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "update HairEngineer set HairEngineerPhotoIDs = '"+photoIDs+"' where HairEngineerID=" + id.ToString();
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
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "update HairShop set HairShopEngineerNum = HairShopEngineerNum+1 where HairShopID="+he.HairShopID.ToString();
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
            ResetControlState();

            this.Response.Redirect("HairEngineerAddSwitch.aspx?id="+id.ToString()+"&shopid="+this.ddlHairShop.SelectedItem.Value);
        }
        public void btnPicSubmit_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string picPath = upload.UpLoadImg(fileLogo, "/uploadfiles/pictures/");
            System.Threading.Thread.Sleep(1000);
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
