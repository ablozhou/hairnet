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
using HairNet.Utilities;

namespace Web.UserControls
{
    public partial class HotHairEngineerList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                StringBuilder sb = new StringBuilder();

                int num = 0;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select top 8 * from HairEngineer order by HairEngineerHits desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                string hairEngineerName = string.Empty;
                                string hitNum = string.Empty;
                                string photoIDs = string.Empty;
                                string picUrl = string.Empty;
                                string picSmallUrl = string.Empty;
                                string description = string.Empty;
                                string hairEngineerID = string.Empty;

                                hairEngineerID = sdr["HairEngineerID"].ToString();
                                hairEngineerName = sdr["HairEngineerName"].ToString();
                                hitNum = sdr["HairEngineerHits"].ToString();
                                photoIDs = sdr["HairEngineerPhotoIDs"].ToString();
                                description = sdr["HairEngineerDescription"].ToString();

                                string[] photoID = photoIDs.Split(",".ToCharArray());
                                if (photoID.Length == 1)
                                {
                                    picUrl = "Theme/Images/sg-meifa_ls02.gif";
                                }
                                else
                                {
                                    using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                                    {
                                        string commString1 = "select top 1 * from enginpics where id=" + photoID[1];
                                        using (SqlCommand comm1 = new SqlCommand())
                                        {
                                            comm1.CommandText = commString1;
                                            comm1.Connection = conn1;
                                            conn1.Open();

                                            using (SqlDataReader sdr1 = comm1.ExecuteReader())
                                            {
                                                if (sdr1.Read())
                                                {
                                                    picUrl = sdr1["picurl"].ToString();
                                                    picSmallUrl = sdr1["picsmallurl"].ToString();
                                                }
                                            }
                                        }
                                    }
                                }

                                num++;

                                switch (num)
                                {
                                    case 1:
                                        sb.Append("<tr>");
                                        sb.Append("<td width=\"15%\" height=\"80\" align=\"center\"><img src=\"Theme/images/sg-08bbs_1.gif\" /></td>");
                                        sb.Append("<td width=\"85%\" align=\"left\"><table width=\"100%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">");
                                        sb.Append("<tr>");
                                        sb.Append("<td width=\"29%\"><div class=\"pic-5\"><a href=\"HairdresserLastPage.aspx?ID=" + hairEngineerID + "\" target=\"_blank\"><img src=\"" + picSmallUrl + "\" alt=\"" + description + "\" /></a></div></td>");
                                        sb.Append("<td width=\"6%\" align=\"left\"><span class=\"gray12-b\"><a href=\"#\" target=\"_blank\"></a></span><br />");
                                        sb.Append("<span class=\"red12\"><a href=\"#\" target=\"_blank\"></a></span></td>");
                                        sb.Append("<td width=\"65%\" align=\"left\"><span class=\"gray14-b\"><a href=\"HairdresserLastPage.aspx?ID=" + hairEngineerID + "\" target=\"_blank\">" + StringHelper.GetDescription2(hairEngineerName,4) + "</a></span><br />");
                                        sb.Append("<span class=\"red12\">推荐指数：" + hitNum + "</span></td>");
                                        sb.Append("</tr>");
                                        sb.Append("</table></td>");
                                        sb.Append("</tr>");
                                        break;
                                    case 2:
                                        sb.Append("<tr>");
                                        sb.Append("<td align=\"center\"><img src=\"Theme/images/sg-08bbs_2.gif\" /></td>");
                                        sb.Append("<td align=\"left\" class=\"gray14-e\"><a href=\"HairdresserLastPage.aspx?ID=" + hairEngineerID + "\" target=\"_blank\">" + StringHelper.GetDescription(hairEngineerName,10) + "</a>&nbsp;&nbsp;推荐指数:" + hitNum + "</td>");
                                        sb.Append("</tr>");
                                        break;
                                    case 3:
                                        sb.Append("<tr>");
                                        sb.Append("<td align=\"center\"><img src=\"Theme/images/sg-08bbs_3.gif\" /></td>");
                                        sb.Append("<td align=\"left\" class=\"gray14-e\"><a href=\"HairdresserLastPage.aspx?ID=" + hairEngineerID + "\" target=\"_blank\">" + StringHelper.GetDescription(hairEngineerName,10) + "</a>&nbsp;&nbsp;推荐指数:" + hitNum + "</td>");
                                        sb.Append("</tr>");
                                        break;
                                    default:
                                        sb.Append("<tr>");
                                        sb.Append("<td align=\"center\"><img src=\"Theme/images/sg-08bbs_"+num.ToString()+".gif\" /></td>");
                                        sb.Append("<td align=\"left\" class=\"gray14-e\"><a href=\"HairdresserLastPage.aspx?ID=" + hairEngineerID + "\" target=\"_blank\">" + StringHelper.GetDescription(hairEngineerName,10) + "</a>&nbsp;&nbsp;推荐指数:" + hitNum + "</td>");
                                        sb.Append("</tr>");
                                        break;
                                }
                            }
                        }
                    }
                }
                if (num == 0)
                {
                    this.lblText.Text = "当前无美发师";
                }
                else
                {
                    this.lblText.Text = sb.ToString();
                }
            }
        }
    }
}