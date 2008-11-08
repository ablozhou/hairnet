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
    public partial class HotCouponList2 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                StringBuilder sb = new StringBuilder();

                int num = 0;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select top 10 * from Coupon order by HitNum desc";

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
          
                                sb.Append("<tr>");
                                sb.Append("<td align=\"left\" class=\"gray14-e\"><a href=\"PrintCoupon.aspx?id=" + couponID + "\" target=\"_blank\">·" + StringHelper.GetDescription2(couponName,15) + "</a></td>");
                                sb.Append("</tr>");
                            }
                        }
                    }
                }
                if (num == 0)
                {
                    this.lblText.Text = "&nbsp;&nbsp;当前无优惠券";
                }
                else
                {
                    this.lblText.Text = sb.ToString();
                }
            }
        }
    }
}