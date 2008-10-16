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
    public partial class HotCouponList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                StringBuilder sb = new StringBuilder();

                int num = 0;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select top 8 * from Coupon order by HitNum desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                string couponID = string.Empty;
                                string couponName = string.Empty;
                                string hitNum = string.Empty;
                                string picSmallUrl = string.Empty;
                                string picUrl = string.Empty;
                                string description = string.Empty;

                                couponID = sdr["ID"].ToString();
                                couponName = sdr["Name"].ToString();
                                hitNum = sdr["HitNum"].ToString();
                                picSmallUrl = sdr["ImageSmallUrl"].ToString();
                                picUrl = sdr["ImageUrl"].ToString();
                                description = sdr["Description"].ToString();
                                
                                num++;

                                switch(num)
                                {
                                    case 1:
                                        sb.Append("<tr>");
                                        sb.Append("<td width=\"15%\" height=\"80\" align=\"center\"><img src=\"Theme/images/sg-08bbs_1.gif\" /></td>");
                                        sb.Append("<td width=\"85%\" align=\"left\"><table width=\"100%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">");
                                        sb.Append("<tr>");
                                        sb.Append("<td width=\"29%\"><div class=\"pic-5\"><a href=\"PrintCoupon.aspx?id="+couponID+"\" target=\"_blank\"><img src=\""+picSmallUrl+"\" alt=\""+description+"\" /></a></div></td>");
                                        sb.Append("<td width=\"6%\" align=\"left\"><span class=\"gray12-b\"><a href=\"#\" target=\"_blank\"></a></span><br />");
                                        sb.Append("<span class=\"red12\"><a href=\"#\" target=\"_blank\"></a></span></td>");
                                        sb.Append("<td width=\"65%\" align=\"left\"><span class=\"gray14-b\"><a href=\"PrintCoupon.aspx?id=" + couponID + "\" target=\"_blank\">" + couponName + "</a></span><br />");
                                        sb.Append("<span class=\"red12\">推荐指数："+hitNum+"</span></td>");
                                        sb.Append("</tr>");
                                        sb.Append("</table></td>");
                                        sb.Append("</tr>");
                                        break;
                                    case 2:
                                        sb.Append("<tr>");
                                        sb.Append("<td align=\"center\"><img src=\"Theme/images/sg-08bbs_2.gif\" /></td>");
                                        sb.Append("<td align=\"left\" class=\"gray14-e\"><a href=\"PrintCoupon.aspx?id=" + couponID + "\" target=\"_blank\">" + couponName + "&nbsp;&nbsp;推荐指数:" + hitNum + "</a></td>");
                                        sb.Append("</tr>");
                                        break;
                                    case 3:
                                        sb.Append("<tr>");
                                        sb.Append("<td align=\"center\"><img src=\"Theme/images/sg-08bbs_3.gif\" /></td>");
                                        sb.Append("<td align=\"left\" class=\"gray14-e\"><a href=\"PrintCoupon.aspx?id=" + couponID + "\" target=\"_blank\">" + couponName + "&nbsp;&nbsp;推荐指数:" + hitNum + "</a></td>");
                                        sb.Append("</tr>");
                                        break;
                                    default:
                                        sb.Append("<tr>");
                                        sb.Append("<td align=\"center\"><img src=\"Theme/images/sg-08bbs_"+num.ToString()+".gif\" /></td>");
                                        sb.Append("<td align=\"left\" class=\"gray14-e\"><a href=\"PrintCoupon.aspx?id=" + couponID + "\" target=\"_blank\">" + couponName + "&nbsp;&nbsp;推荐指数:" + hitNum + "</a></td>");
                                        sb.Append("</tr>");
                                        break;
                                }
                            }
                        }
                    }
                }
                if (num == 0)
                {
                    this.lblText.Text = "当前无优惠券";
                }
                else
                {
                    this.lblText.Text = sb.ToString();
                }
            }
        }
    }
}