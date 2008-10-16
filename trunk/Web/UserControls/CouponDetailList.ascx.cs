using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Collections.Generic;
using HairNet.Entry;
using HairNet.Provider;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;

namespace Web.UserControls
{
    public partial class CouponDetailList : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //DataTable dt = ProviderFactory.GetHairShopDataProviderInstance().GetCouponList();

               List<Coupon > list =  GetCouponList();
                //需要查询出coupon
                Coupon cp = null;

                StringBuilder sb = new StringBuilder();

                //page
                int frontPage = 0;
                int backPage = 0;
                int currentPage = this.CurrentPage;

                int pageCount = list.Count / this.PageSize + 1;

                if (pageCount > 1)
                {
                    if (currentPage == pageCount)
                    {
                        frontPage = currentPage - 1;
                        backPage = currentPage;
                    }
                    else
                    {
                        if (currentPage == 1)
                        {
                            frontPage = currentPage;
                            backPage = currentPage + 1;
                        }
                        else
                        {
                            frontPage = currentPage - 1;
                            backPage = currentPage + 1;
                        }
                    }
                }
                else
                {
                    frontPage = currentPage;
                    backPage = currentPage;
                }

                //display
                if (list.Count == 0)
                {
                    this.lblDisplayText.Text = "当前没有优惠券！";
                    this.lblDisplayText.ForeColor = Color.Red;
                    return;
                }


                int leftCount = list.Count - (currentPage - 1) * PageSize;
                int leftCol = 0;

                if (leftCount > PageSize)
                {
                    leftCol = PageSize;
                }
                else
                {
                    leftCol = leftCount;
                }

                //
               

               
                 for (int k = 0; k < leftCol; k++)
                {
                    int listID = k + (currentPage - 1) * PageSize;
                    //string picSmallUrl = Convert.ToString(dt["ImageSmallUrl"]);

                    sb.Append("<table width=\"99%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">");
                    sb.Append("<tr>");
                    sb.Append("        <td width=\"6%\" align=\"right\" valign=\"middle\"><input type=\"checkbox\" name=\"checkbox\" value=\"checkbox\" /></td>");

                    sb.Append("   <td width=\"30%\" align=\"center\" valign=\"middle\"><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"margin-top:25px;\">");
                    sb.Append("     <tr>");
                    sb.Append("       <td align=\"center\" class=\"yhq-pic\"><img src=\"Theme/images/fair-yhq-temp1.gif\" width=\"160\" height=\"95\" /></td>");
                    sb.Append("     </tr>");
                    sb.Append("     <tr>");
                    sb.Append("       <td height=\"50\" align=\"center\" valign=\"middle\"><a href=\"#\"><img src=\"Theme/images/fair-yhq-07.gif\" width=\"59\" height=\"19\" border=\"0\" /></a>&nbsp;&nbsp;<a href=\"#\"><img src=\"Theme/images/fair-yhq-08.gif\" width=\"59\" height=\"19\" border=\"0\" /></a></td>");
                    sb.Append("     </tr>");
                    sb.Append("   </table></td>");
                    sb.Append("   <td width=\"64%\" align=\"left\" valign=\"top\"><table width=\"95%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" style=\"margin-top:20px;\">");
                    sb.Append("     <tr>");
                    sb.Append("       <td height=\"35\" colspan=\"3\" align=\"left\" valign=\"middle\" class=\"red14b\" style=\"border-bottom:#e8e8e8 1px solid\">");
                    sb.Append("           &nbsp;审美总店8.5折优惠券</td>");
                    sb.Append("       </tr>");
                    sb.Append("		<tr>");
                    sb.Append("       <td height=\"8\" colspan=\"3\" align=\"left\"></td>");
                    sb.Append("       </tr>");
                    sb.Append("     <tr>");
                    sb.Append("       <td width=\"46%\" height=\"65\" valign=\"top\" class=\"gray12-d\"> ");
                    sb.Append("           &nbsp;&nbsp;&nbsp;&nbsp;" + cp.Description + " </td>");
                    sb.Append("       <td width=\"22%\" align=\"center\" valign=\"top\" class=\"gray14\">国贸</td>");
                    sb.Append("       <td width=\"32%\" valign=\"top\" class=\"gray12-d\">有 效 期&nbsp;&nbsp;至2009年<br />");
                    sb.Append("           联系方式 &nbsp;&nbsp;5999999999</td>");
                    sb.Append("     </tr>");
                    sb.Append("     <tr>");
                    sb.Append("      <td align=\"center\" class=\"gray12-bg\"><a href=\"#\" target=\"_blank\">发表评论</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href=\"#\" target=\"_blank\">更多评论&gt;&gt;</a></td>");
                    sb.Append("      <td>&nbsp;</td>");
                    sb.Append("      <td>&nbsp;</td>");
                    sb.Append("    </tr>");
                    sb.Append("  </table></td>");
                    sb.Append("</tr>");
                    sb.Append(" </table>	");
                    sb.Append(" <div class=\"point\">&nbsp;</div>");
                }

                StringBuilder sb2 = new StringBuilder();
                sb2.Append("<div class=\"page-all\">");
                sb2.Append("<a href=\"couponList.aspx?pageNum=1\">第一页</a>");
                sb2.Append("&nbsp;<a href=\"couponList.aspx?pageNum="+frontPage.ToString()+"\">上一页</a>&nbsp;");
                
                if(CurrentPage<3)
                {
                    for(int m=1;m<=pageCount;m++)
                    {
                        if(m==currentPage)
                        {
                            sb2.Append("<span class=\"red12\"><a href=\"couponList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a></span>");
                        }
                        else
                        {
                            sb2.Append("<a href=\"couponList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a>");
                        }
                        if(m==5)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    if((pageCount -currentPage)>3)
                    {
                        for(int m=(currentPage-2);m<=(CurrentPage+2);m++)
                        {
                            if(m==currentPage)
                            {
                                sb2.Append("<span class=\"red12\"><a href=\"couponList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a></span>");
                            }
                            else
                            {
                                sb2.Append("<a href=\"couponList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a>");
                            }
                        }
                    }
                    else
                    {
                        for(int m=(currentPage-2);m<=pageCount;m++)
                        {
                            if(m==currentPage)
                            {
                                sb2.Append("<span class=\"red12\"><a href=\"couponList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a></span>");
                            }
                            else
                            {
                                sb2.Append("<a href=\"couponList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a>");
                            }
                        }
                    }
                }

                sb2.Append("&nbsp;<a href=\"couponList.aspx?pageNum="+backPage.ToString()+"\">下一页</a>");
                sb2.Append("&nbsp;<a href=\"couponList.aspx?pageNum="+pageCount.ToString()+"\">最后一页</a>");
                sb2.Append("&nbsp;共"+pageCount.ToString()+"页</div>");

                this.lblPageText.Text = sb2.ToString();

            }
        }

        private int _pageSize = 0;
        public int PageSize
        {
            set { this._pageSize = value; }
            get { return this._pageSize; }
        }

        private int _currentPage = 0;
        public int CurrentPage
        {
            set { this._currentPage = value; }
            get { return this._currentPage; }
     
    
    }
      public List<Coupon> GetCouponList()
    {
        List<Coupon> list = new List<Coupon>();
        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
        {
            string commString = "select  * from Coupon order by id desc";
            using (SqlCommand comm = new SqlCommand())
            {
                comm.CommandText = commString;
                comm.Connection = conn;
                conn.Open();

                using (SqlDataReader sdr = comm.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        string couponName = string.Empty;
                        string hitNum = string.Empty;
                        string picSmallUrl = string.Empty;
                        string picUrl = string.Empty;
                        string description = string.Empty;

                        couponName = sdr["Name"].ToString();
                        hitNum = sdr["HitNum"].ToString();
                        picSmallUrl = sdr["ImageSmallUrl"].ToString();
                        picUrl = sdr["ImageUrl"].ToString();
                        description = sdr["Description"].ToString();
                        int id = int.Parse(sdr["id"].ToString());
                        int ShopId = int.Parse(sdr["HairShopID"].ToString());
                        string expire = sdr["ExpiredDate"].ToString();
                        string discount = sdr["Discount"].ToString();
                        string phonenum = sdr["PhoneNumber"].ToString();
                        Coupon cp = new Coupon(id, couponName, ShopId, discount, expire,phonenum,null, description);

                        list.Add(cp);

                    }
                }
            }
        }
        return list;
    }    
    }

 
}