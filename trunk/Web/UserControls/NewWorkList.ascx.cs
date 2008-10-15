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
using System.Text;

namespace Web.UserControls
{
    public partial class NewWorkList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                StringBuilder sb = new StringBuilder();

                int num = 0;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select top 4 * from HairStyle where picturestoreid=0 order by id desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                string hairStyleID = string.Empty;
                                string picSmallUrl = string.Empty;
                                string description = string.Empty;

                                hairStyleID = sdr["id"].ToString();
                                description = sdr["descr"].ToString();

                                using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                                {
                                    string commString1 = "select top 1 * from PictureStoreSet where hairStylePos=1 and pictureStoreID=" + hairStyleID;
                                    using (SqlCommand comm1 = new SqlCommand())
                                    {
                                        comm1.CommandText = commString1;
                                        comm1.Connection = conn1;
                                        conn1.Open();

                                        using (SqlDataReader sdr1 = comm1.ExecuteReader())
                                        {
                                            if (sdr1.Read())
                                            {
                                                picSmallUrl = sdr1["SmallPictureUrl"].ToString();
                                            }
                                        }
                                    }
                                }

                                num++;

                                if (num == 1 || num==3)
                                {
                                    sb.Append("<tr>");
                                }
                                
                                sb.Append("<td width=\"50%\" align=\"center\"><div class=\"pic-4\"><a href=\"#\"><img src=\""+picSmallUrl+"\" width=\"94\" height=\"94\" alt='"+description+"' /></a></div></td>");

                                if (num == 2)
                                {
                                    sb.Append("</tr>");
                                }
                                
                            }
                        }
                    }
                }
                if (num == 0)
                {
                    this.lblText.Text = "当前无作品";
                }
                else
                {
                    sb.Append("</tr>");
                    this.lblText.Text = sb.ToString();
                }
            }
        }
    }
}