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

using HairNet.Business;
using HairNet.Entry;
using System.Collections.Generic;
using System.IO;
using HairNet.Components.Utilities;
using HairNet.Utilities;
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class PictureStoreEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindPicGroup();
                this.SetInfo();
                ViewState["num"] = 0;
            }
        }

        private void bindPicGroup()
        {
            ddlPictureStoreGroup.DataSource = InfoAdmin.GetPictureStoreGroups(0);
            ddlPictureStoreGroup.DataTextField = "Name";
            ddlPictureStoreGroup.DataValueField = "ID";
            ddlPictureStoreGroup.DataBind();
        }

        private void SetInfo()
        {
            string id = Request["id"];
            PictureStore ps = InfoAdmin.GetPictureStoreByPictureStoreID(int.Parse(id));

            txtPictureStoreName.Text = ps.PictureStoreName;
            txtPictureStoreDescription.Text = ps.PictureStoreDescription;
            txtPictureStoreTag.Text = InfoAdmin.GetPictureStoreTagNames(ps.PictureStoreTagIDs);

            ddlPictureStoreGroup.SelectedValue = ps.PictureStoreGroupIDs;

            int i = 0;
            string imgString = string.Empty;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select * from PictureStoreSet where PictureStoreId=" + ps.PictureStoreID.ToString();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            i++;
                            if (i == 1)
                            {
                                imgString = "<a href='"+sdr["PictureStoreURL"].ToString()+"' target='_blank'><img src='"+sdr["PictureStoreURL"].ToString()+"' width=200 height=100 /></a>&nbsp;&nbsp;<a href='PictureStoreOperate.aspx?id="+sdr["id"].ToString()+"&pid="+sdr["PictureStoreID"].ToString()+"'>删除</a>";
                            }
                            else
                            {
                                imgString += "<a href='" + sdr["PictureStoreURL"].ToString() + "' target='_blank'><img src='" + sdr["PictureStoreURL"].ToString() + "' width=200 height=100 /></a>&nbsp;&nbsp;<a href='PictureStoreOperate.aspx?id=" + sdr["id"].ToString() + "&pid=" + sdr["PictureStoreID"].ToString() + "'>删除</a>";
                            }
                        }
                    }
                }

            }
            this.lblImg.Text = imgString;
            ViewState["PictureStoreInfo"] = ps;
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            PictureStore ps = (PictureStore)ViewState["PictureStoreInfo"];
            ps.PictureStoreName = txtPictureStoreName.Text.Trim();
            ps.PictureStoreGroupIDs = ddlPictureStoreGroup.SelectedValue;
            ps.PictureStoreDescription = txtPictureStoreDescription.Text.Trim();
            ps.PictureStoreTagIDs = InfoAdmin.GetPictureStoreTagIDs(txtPictureStoreTag.Text.Trim());
            ps.PictureStoreHits = 0;
            ps.PictureStoreCreateTime = DateTime.Now;
            ps.PictureStoreRawUrl = string.Empty;
            ps.PictureStoreLittleUrl = string.Empty;

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
            
            string[] ppicString = this.pic.Text.Split(";".ToCharArray());
            if (ppicString[0] != string.Empty)
            {
                foreach (string pps in ppicString)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL) values(" + ps.PictureStoreID.ToString() + ",'" + pps + "')";
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
            }

            InfoAdmin.UpdatePictureStore(ps);

            foreach (string tagid in ps.PictureStoreTagIDs.Split(','))
            {
                InfoAdmin.SetPictureStoreTag(ps.PictureStoreID, int.Parse(tagid));
            }
            this.Response.Redirect("PictureStoreAdmin.aspx");
        }
        protected void btnPicUpload1_OnClick(object sender, EventArgs e)
        {
            PictureStore ps = (PictureStore)ViewState["PictureStoreInfo"];

            UpLoadClass upload = new UpLoadClass();
            string filepath = upload.UpLoadImg(uploadpic1, "/uploadfiles/pictures/");
            if (filepath != string.Empty)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL) values(" + ps.PictureStoreID.ToString() + ",'" + filepath + "')";
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
                int pssid = 0;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "select top 1 * from PictureStoreSet order by id desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                pssid = Convert.ToInt32(sdr["ID"].ToString());
                            }
                        }
                    }
                }

                this.lblImg.Text = "<a href='" + filepath + "' target='_blank'><img src='" + filepath + "' width=200 height=100 /></a>&nbsp;&nbsp;<a href='PictureStoreOperate.aspx?id=" + pssid + "&pid=" + ps.PictureStoreID.ToString() + "'>删除</a>" + "&nbsp;&nbsp;" + this.lblImg.Text;
            }
        }
    }
}
