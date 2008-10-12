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
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class HairShopAddNext1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {   
                string id = this.Request.QueryString["id"].ToString();
                Session["oo"] = string.Empty;

                try
                {
                    string oo = this.Request.QueryString["update"].ToString();
                    Session["oo"] = oo;
                }
                catch (Exception ex)
                {
                    //throw new Exception(ex.Message);
                }
                if (Session["oo"] != null && Session["oo"].ToString() != string.Empty)
                {
                    this.btnSubmit.Text = "返回美发厅管理";
                }
                string outString = string.Empty;
                string innerString = string.Empty;
                string outSmallString = string.Empty;
                string innerSmallString = string.Empty;

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from shoppics where hairshopID=" + id + " and classid=2 order by id desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        int num = 0;

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                num++;
                                if (num == 1)
                                {   
                                    outString = "<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>删除</a>";
                                }
                                else
                                {
                                    outString += "&nbsp;&nbsp;<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>删除</a>";
                                }
                            }
                        }
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from shoppics where hairshopID=" + id + " and classid=1 order by id desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        int num = 0;

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                num++;
                                if (num == 1)
                                {
                                    innerString = "<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>删除</a>";
                                }
                                else
                                {
                                    innerString += "&nbsp;&nbsp;<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>删除</a>";
                                }
                            }
                        }
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from shoppics where hairshopID=" + id + " and classid=3 order by id desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        int num = 0;

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                num++;
                                if (num == 1)
                                {
                                    innerSmallString = "<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>删除</a>";
                                }
                                else
                                {
                                    innerSmallString += "&nbsp;&nbsp;<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>删除</a>";
                                }
                            }
                        }
                    }
                }

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from shoppics where hairshopID=" + id + " and classid=4 order by id desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        int num = 0;

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                num++;
                                if (num == 1)
                                {
                                    outSmallString = "<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>删除</a>";
                                }
                                else
                                {
                                    outSmallString += "&nbsp;&nbsp;<img width=200 heigth=100 src='" + sdr["picurl"].ToString() + "' />&nbsp;&nbsp;<a href='hairshoppicoperate.aspx?id=" + sdr["id"].ToString() + "&hid=" + id.ToString() + "'>删除</a>";
                                }
                            }
                        }
                    }
                }

                this.lblInnerString.Text = innerString;
                this.lblOutString.Text = outString;
                this.lblOutSmallString.Text = outSmallString;
                this.lblInnerSmallString.Text = innerSmallString;

            }
        }
        public void btnSubmitOutSmall_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string id = this.Request.QueryString["id"].ToString();
            this.lblInfo.Visible = false;

            if (!PicOperate.isPermission(StringHelper.GetExtraType(outSmall.Value)))
            {
                this.lblInfo.Text = "上传图片格式不对";
                this.lblInfo.Visible = true;
                return;
            }

            string outSmall1 = upload.UpLoadImg(outSmall, "/uploadfiles/pictures/");
            if (outSmall1 != string.Empty)
            {
                //厅外是2,厅内是1,厅外小4，厅内小3
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "insert into shoppics(picurl,hairshopID,classid) values('" + outSmall1 + "'," + id.ToString() + ",4)";
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

                this.Response.Redirect("HairShopAddNext1.aspx?id=" + id.ToString());
            }
        }
        public void btnSubmitOut_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string id = this.Request.QueryString["id"].ToString();
            this.lblInfo.Visible = false;

            if (!PicOperate.isPermission(StringHelper.GetExtraType(out1c.Value)))
            {
                this.lblInfo.Text = "上传图片格式不对";
                this.lblInfo.Visible = true;
                return;
            }   

            string out1 = upload.UpLoadImg(out1c, "/uploadfiles/pictures/");
            if (out1 != string.Empty)
            {
                //厅外是2,厅内是1
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "insert into shoppics(picurl,hairshopID,classid) values('" + out1 + "'," + id.ToString() + ",2)";
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

                this.Response.Redirect("HairShopAddNext1.aspx?id=" + id.ToString());
            }
        }
        public void btnSubmitInner_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string id = this.Request.QueryString["id"].ToString();
            this.lblInfo.Visible = false;

            if (!PicOperate.isPermission(StringHelper.GetExtraType(inner1c.Value)))
            {
                this.lblInfo.Text = "上传图片格式不对";
                this.lblInfo.Visible = true;
                return;
            } 

            string inner1 = upload.UpLoadImg(inner1c, "/uploadfiles/pictures/");

            if (inner1 != string.Empty)
            {
                //厅外是2,厅内是1
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "insert into shoppics(picurl,hairshopID,classid) values('" + inner1 + "'," + id.ToString() + ",1)";
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

                this.Response.Redirect("HairShopAddNext1.aspx?id=" + id.ToString());
            }
        }
        public void btnSubmitInnerSmall_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string id = this.Request.QueryString["id"].ToString();
            this.lblInfo.Visible = false;

            if (!PicOperate.isPermission(StringHelper.GetExtraType(innerSmall.Value)))
            {
                this.lblInfo.Text = "上传图片格式不对";
                this.lblInfo.Visible = true;
                return;
            }

            string innerSmall1 = upload.UpLoadImg(innerSmall, "/uploadfiles/pictures/");

            if (innerSmall1 != string.Empty)
            {
                //厅外是2,厅内是1
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "insert into shoppics(picurl,hairshopID,classid) values('" + innerSmall1 + "'," + id.ToString() + ",3)";
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

                this.Response.Redirect("HairShopAddNext1.aspx?id=" + id.ToString());
            }
        }
        public void btnSubmit_OnClick(object sender,EventArgs e)
        {
            if (Session["oo"] == null || Session["oo"].ToString() == string.Empty)
            {
                this.Response.Redirect("HairEngineerAdd.aspx");
            }
            else
            {
                Session["oo"] = string.Empty;
                this.Response.Redirect("HairShopAdmin.aspx");
            }
        }
    }
}
