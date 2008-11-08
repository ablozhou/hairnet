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
using System.Text;
using System.Data.SqlClient;
using HairNet.Utilities;

namespace Web.UserControls
{
    public partial class HotHairShopList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                StringBuilder sb = new StringBuilder();

                int num = 0;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select top 8 * from HairShop order by HairShopVisitNum desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                string hairShopName = string.Empty;
                                string hairShopVisitNum = string.Empty;
                                string picUrl = string.Empty;
                                string picSmallUrl = string.Empty;
                                string description = string.Empty;
                                string photoIDs = string.Empty;
                                string hairShopID = string.Empty;
                                string hairShopShortName=string.Empty;

                                hairShopID = sdr["HairShopID"].ToString();
                                hairShopName = sdr["HairShopName"].ToString();
                                hairShopVisitNum = sdr["HairShopVisitNum"].ToString();
                                photoIDs = sdr["outLogs"].ToString();
                                description = sdr["HairShopDescription"].ToString();
                                hairShopShortName = sdr["HairShopShortName"].ToString();


                                using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                                {
                                    string commString1 = "select top 1 * from shoppics where classid=2 and hairshopid=" + hairShopID;
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

                                if (picSmallUrl.ToString() == string.Empty)
                                {
                                    picSmallUrl = "Theme/Images/sg-meifa_ls02.gif";
                                }

                                num++;

                                switch (num)
                                {
                                    case 1:
                                        sb.Append("<tr>");
                                        sb.Append("<td width=\"15%\" height=\"68\" align=\"center\"><img src=\"Theme/images/sg-08bbs_1.gif\" /></td>");
                                        sb.Append("<td colspan=\"2\" align=\"left\"><table width=\"100%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">");
                                        sb.Append("<tr>");
                                        sb.Append("<td width=\"29%\"><div class=\"pic-5\"><a href=\"HairShopContent.aspx?id="+hairShopID+"\" target=\"_blank\"><img src=\""+picSmallUrl+"\" alt=\""+description+"\" /></a></div></td>");
                                        sb.Append("<td width=\"6%\" align=\"left\"><span class=\"gray12-b\"><a href=\"#\" target=\"_blank\"></a></span><br /><span class=\"red12\"><a href=\"#\" target=\"_blank\"></a></span></td>");
                                        sb.Append("<td width=\"65%\" align=\"left\"><span class=\"gray14-b\"><a href=\"HairShopContent.aspx?id=" + hairShopID + "\" target=\"_blank\">" + StringHelper.GetDescription2(hairShopShortName,6) + "</a></span><br />");
                                        sb.Append("<span class=\"red12\">推荐指数："+hairShopVisitNum+"</span></td>");
                                        sb.Append("</tr>");
                                        sb.Append("</table></td></tr>");
                                        break;
                                    case 2:
                                        sb.Append("<tr>");
                                        sb.Append("<td width=\"15%\" height=\"68\" align=\"center\"><img src=\"Theme/images/sg-08bbs_2.gif\" /></td>");
                                        sb.Append("<td colspan=\"2\" align=\"left\"><table width=\"100%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">");
                                        sb.Append("<tr>");
                                        sb.Append("<td width=\"29%\"><div class=\"pic-5\"><a href=\"HairShopContent.aspx?id=" + hairShopID + "\" target=\"_blank\"><img src=\"" + picSmallUrl + "\" alt=\"" + description + "\" /></a></div></td>");
                                        sb.Append("<td width=\"6%\" align=\"left\"><span class=\"gray12-b\"><a href=\"#\" target=\"_blank\"></a></span><br /><span class=\"red12\"><a href=\"#\" target=\"_blank\"></a></span></td>");
                                        sb.Append("<td width=\"65%\" align=\"left\"><span class=\"gray14-b\"><a href=\"HairShopContent.aspx?id=" + hairShopID + "\" target=\"_blank\">" + StringHelper.GetDescription2(hairShopShortName,6) + "</a></span><br />");
                                        sb.Append("<span class=\"red12\">推荐指数：" + hairShopVisitNum + "</span></td>");
                                        sb.Append("</tr>");
                                        sb.Append("</table></td></tr>");
                                        break;
                                    case 3:
                                        sb.Append("<tr>");
                                        sb.Append("<td width=\"15%\" height=\"68\" align=\"center\"><img src=\"Theme/images/sg-08bbs_3.gif\" /></td>");
                                        sb.Append("<td colspan=\"2\" align=\"left\"><table width=\"100%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">");
                                        sb.Append("<tr>");
                                        sb.Append("<td width=\"29%\"><div class=\"pic-5\"><a href=\"HairShopContent.aspx?id=" + hairShopID + "\" target=\"_blank\"><img src=\"" + picSmallUrl + "\" alt=\"" + description + "\" /></a></div></td>");
                                        sb.Append("<td width=\"6%\" align=\"left\"><span class=\"gray12-b\"><a href=\"#\" target=\"_blank\"></a></span><br /><span class=\"red12\"><a href=\"#\" target=\"_blank\"></a></span></td>");
                                        sb.Append("<td width=\"65%\" align=\"left\"><span class=\"gray14-b\"><a href=\"HairShopContent.aspx?id=" + hairShopID + "\" target=\"_blank\">" + StringHelper.GetDescription2(hairShopShortName,6) + "</a></span><br />");
                                        sb.Append("<span class=\"red12\">推荐指数：" + hairShopVisitNum + "</span></td>");
                                        sb.Append("</tr>");
                                        sb.Append("</table></td></tr>");
                                        break;
                                    default:
                                        sb.Append("<tr>");
                                        sb.Append("<td align=\"center\"><img src=\"Theme/images/sg-08bbs_"+num.ToString()+".gif\" /></td>");
                                        sb.Append("<td align=\"left\" class=\"gray14-e\"  width=\"50%\"><a href=\"HairShopContent.aspx?id=" + hairShopID + "\" target=\"_blank\">" + StringHelper.GetDescription2(hairShopShortName, 8) + "</a></td>");
                                        sb.Append("<td align=\"right\" class=\"gray12\" width=\"35%\">推荐指数:" + hairShopVisitNum + "&nbsp;&nbsp;</td>");
                                        sb.Append("</tr>");
                                        break;
                                }
                            }
                        }
                    }
                }
                if (num == 0)
                {
                    this.lblText.Text = "&nbsp;&nbsp;当前无美发师";
                }
                else
                {
                    this.lblText.Text = sb.ToString();
                }
            }
        }
    }
}