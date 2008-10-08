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

            this.Response.Redirect("HairShopAddNext1.aspx?id=" + hid.ToString());
        }
    }
}
