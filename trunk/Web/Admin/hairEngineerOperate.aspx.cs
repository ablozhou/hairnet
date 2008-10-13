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
    public partial class hairEngineerOperate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = this.Request.QueryString["id"].ToString();
            string hid = this.Request.QueryString["hid"].ToString();

            string photoIDs = "";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "select HairEngineerPhotoIDs from HairEngineer where HairEngineerID=" + hid;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();
                    try
                    {
                        photoIDs = comm.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            string[] photoCollection = photoIDs.Split(",".ToCharArray());
            photoIDs = "";
            if (photoCollection.Length != 1)
            {
                for (int i = 1; i < photoCollection.Length; i++)
                {
                    if (photoCollection[i] != id)
                    {
                        photoIDs += "," + photoCollection[i];
                    }
                }
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "update HairEngineer set HairEngineerPhotoIDs = '" + photoIDs + "' where HairEngineerID=" + hid;
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
                string commString = "delete from enginpics where id="+id.ToString();
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

            this.Response.Redirect("HairEngineerEdit.aspx?id="+hid.ToString());
        }
    }
}
