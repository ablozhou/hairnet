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

        }
        public void btnSubmit_OnClick(object sender,EventArgs e)
        {
            string id = this.Request.QueryString["id"].ToString();
            UpLoadClass upload = new UpLoadClass();
            string out1 = upload.UpLoadImg(out1c, "/uploadfiles/pictures/");
            string out2 = upload.UpLoadImg(out2c, "/uploadfiles/pictures/");
            string out3 = upload.UpLoadImg(out3c, "/uploadfiles/pictures/");
            string inner1 = upload.UpLoadImg(inner1c, "/uploadfiles/pictures/");
            string inner2 = upload.UpLoadImg(inner2c, "/uploadfiles/pictures/");
            string inner3 = upload.UpLoadImg(inner3c, "/uploadfiles/pictures/");

            //厅外是2,厅内是1
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "insert into shoppics(picurl,hairshopID,classid) values('"+out1+"',"+id.ToString()+",2)";
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
                string commString = "insert into shoppics(picurl,hairshopID,classid) values('" + out2 + "'," + id.ToString() + ",2)";
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
                string commString = "insert into shoppics(picurl,hairshopID,classid) values('" + out3 + "'," + id.ToString() + ",2)";
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
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "insert into shoppics(picurl,hairshopID,classid) values('" + inner2 + "'," + id.ToString() + ",1)";
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
                string commString = "insert into shoppics(picurl,hairshopID,classid) values('" + inner3 + "'," + id.ToString() + ",1)";
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
            this.Response.Redirect("HairEngineerAdd.aspx");
        }
    }
}
