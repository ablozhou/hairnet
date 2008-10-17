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

namespace Web
{
    public partial class PrintCoupon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] IDS = this.Request.QueryString["id"].ToString().Split(",".ToCharArray());

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < IDS.Length; i++)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from Coupon where ID="+IDS[i].ToString();
                    
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
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

                                sb.Append("<div>");
                                sb.Append("打折券名称;"+couponName+"<br/>");
                                sb.Append("图片:<img src='"+picUrl+"' />");
                                sb.Append("</div>");
                            }
                        }
                    }
                }

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "update coupon set HitNum = HitNum+1 where ID=" + IDS[i].ToString();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch(Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
            }
            this.lblText.Text = sb.ToString();
        }
    }
}
