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
    public partial class CouponListControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            if (!this.IsPostBack)
            {
                StringBuilder sb = new StringBuilder();

                int num = 0;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select top 7 * from Coupon order by HitNum desc";

                    if (CouponType == 1)
                    {
                        commString = "select top 7 * from Coupon order by ID desc";
                    }
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
                                string discount = string.Empty;

                                couponID = sdr["ID"].ToString();
                                couponName = sdr["Name"].ToString();
                                hitNum = sdr["HitNum"].ToString();
                                picSmallUrl = sdr["ImageSmallUrl"].ToString();
                                picUrl = sdr["ImageUrl"].ToString();
                                description = sdr["Description"].ToString();
                                discount = sdr["Discount"].ToString();

                                num++;

                                sb.Append("<tr>");
                                sb.Append("<td width=\"83%\" align=\"left\" class=\"gray14-line\">·&nbsp;<a href=\"PrintCoupon.aspx?id="+couponID+"\" target=\"_blank\">"+StringHelper.GetDescription2(couponName,12)+"</a></td>");
                                sb.Append("<td width=\"17%\" align=\"left\" class=\"gray14-line\"><span class=\"red14\">"+discount+"折</span></td>");
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
        private int _couponType = 0;
        public int CouponType
        {
            set { this._couponType = value; }
            get { return this._couponType; }
        }
    }
}