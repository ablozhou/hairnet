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
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class HairShopPicOperate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = this.Request.QueryString["id"].ToString();
            string hid = this.Request.QueryString["hid"].ToString();
            string type = this.Request.QueryString["type"].ToString();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "delete from shoppics where id=" + id.ToString();
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
            if (type == "out")
            {
                string outLogs = "";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select outLogs from HairShop where HairShopID=" + hid;
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            outLogs = comm.ExecuteScalar().ToString();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
                string[] outCollection = outLogs.Split(",".ToCharArray());
                outLogs = "";
                if (outCollection.Length != 1)
                {
                    for (int i = 1; i < outCollection.Length; i++)
                    {
                        if (outCollection[i] != id)
                        {
                            outLogs += "," + outCollection[i];
                        }
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "update HairShop set outLogs = '"+outLogs+"' where HairShopID=" + hid;
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
            else
            {
                string innerLogs = "";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select innerLogs from HairShop where HairShopID=" + hid;
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            innerLogs = comm.ExecuteScalar().ToString();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
                string[] innerCollection = innerLogs.Split(",".ToCharArray());
                innerLogs = "";
                if (innerCollection.Length != 1)
                {
                    for (int i = 1; i < innerCollection.Length; i++)
                    {
                        if (innerCollection[i] != id)
                        {
                            innerLogs += "," + innerCollection[i];
                        }
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "update HairShop set innerLogs = '" + innerLogs + "' where HairShopID=" + hid;
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
            if (Session["oo"] != null && Session["oo"].ToString() != string.Empty)
            {
                this.Response.Redirect("HairShopAddNext1.aspx?id=" + hid.ToString()+"&update=update");
            }
            else
            {
                this.Response.Redirect("HairShopAddNext1.aspx?id=" + hid.ToString());
            }
        }
    }
}
