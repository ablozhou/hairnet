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
using HairNet.Utilities;
using HairNet.Entry;
using System.Collections.Generic;
using HairNet.Business;
using System.IO;
using HairNet.Components.Utilities;
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class PictureStoreAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindPicGroup();
            }
        }

        private void bindPicGroup()
        {
            ddlPictureStoreGroup.DataSource = InfoAdmin.GetPictureStoreGroups(0);
            ddlPictureStoreGroup.DataTextField = "Name";
            ddlPictureStoreGroup.DataValueField = "ID";
            ddlPictureStoreGroup.DataBind();
        }

        protected void btnSubmit_OnClick(object sender,EventArgs e)
        {
            PictureStore ps = new PictureStore();
            ps.PictureStoreName = txtPictureStoreName.Text.Trim();
            ps.PictureStoreGroupIDs = ddlPictureStoreGroup.SelectedValue;
            ps.PictureStoreDescription = txtPictureStoreDescription.Text.Trim();
            ps.PictureStoreTagIDs = InfoAdmin.GetPictureStoreTagIDs(txtPictureStoreTag.Text.Trim());
            ps.PictureStoreHits = 0;
            ps.PictureStoreCreateTime = DateTime.Now;
            ps.PictureStoreRawUrl = "";
            ps.PictureStoreLittleUrl = "";
            //if (uploadpic.Value != "")
            //{
            //    UpLoadClass upload = new UpLoadClass();
            //    string filepath = upload.UpLoadImg(uploadpic, "/uploadfiles/pictures/");
            //    upload = null;
            //    //处理图片
            //    PicOperate po = new PicOperate();
            //    string newfilepath = filepath.Substring(0, filepath.LastIndexOf(".")) + "_new" + Path.GetExtension(filepath);
            //    po.AddWaterMarkOperate(Server.MapPath(filepath), Server.MapPath(WaterSettings.WaterMarkPath), Server.MapPath(newfilepath), WaterSettings.CopyrightText);
            //    ps.PictureStoreRawUrl = newfilepath;
            //    ps.PictureStoreLittleUrl = po.CreateMicroPic(newfilepath, "", WaterSettings.PictureScaleSize[0], WaterSettings.PictureScaleSize[1]);
            //    po = null;
            //}

            ps.PictureStoreID = InfoAdmin.AddPictureStore(ps);

            if (img1.Visible == true)
            {
                using(SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL) values("+ps.PictureStoreID.ToString()+",'"+this.img1.ImageUrl.ToString()+"')";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch(Exception ex)
                        { }
                    }
                    
                }
            }
            if (img2.Visible == true)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL) values(" + ps.PictureStoreID.ToString() + ",'" + this.img2.ImageUrl.ToString() + "')";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        { }
                    }

                }
            }
            if (img3.Visible == true)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL) values(" + ps.PictureStoreID.ToString() + ",'" + this.img3.ImageUrl.ToString() + "')";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        { }
                    }

                }
            }
            if (img4.Visible == true)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL) values(" + ps.PictureStoreID.ToString() + ",'" + this.img4.ImageUrl.ToString() + "')";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        { }
                    }

                }
            }
            if (img5.Visible == true)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL) values(" + ps.PictureStoreID.ToString() + ",'" + this.img5.ImageUrl.ToString() + "')";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        { }
                    }

                }
            }

            foreach (string tagid in ps.PictureStoreTagIDs.Split(','))
            {
                InfoAdmin.SetPictureStoreTag(ps.PictureStoreID, int.Parse(tagid));
            }
            this.Response.Redirect("PictureStoreAdmin.aspx");
        }
        protected void btnPicUpload1_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string filepath = upload.UpLoadImg(uploadpic1, "/uploadfiles/pictures/");

            this.img1.Visible = true;
            this.img1.ImageUrl = filepath;
        }
        protected void btnPicUpload2_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string filepath = upload.UpLoadImg(uploadpic2, "/uploadfiles/pictures/");

            this.img2.Visible = true;
            this.img2.ImageUrl = filepath;
        }
        protected void btnPicUpload3_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string filepath = upload.UpLoadImg(uploadpic3, "/uploadfiles/pictures/");

            this.img3.Visible = true;
            this.img3.ImageUrl = filepath;
        }
        protected void btnPicUpload4_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string filepath = upload.UpLoadImg(uploadpic4, "/uploadfiles/pictures/");

            this.img4.Visible = true;
            this.img4.ImageUrl = filepath;
        }
        protected void btnPicUpload5_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string filepath = upload.UpLoadImg(uploadpic5, "/uploadfiles/pictures/");

            this.img5.Visible = true;
            this.img5.ImageUrl = filepath;
        }
    }
}
