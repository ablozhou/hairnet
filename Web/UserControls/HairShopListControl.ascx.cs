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
using HairNet.Entry;
using System.Collections.Generic;
using HairNet.Provider;
using HairNet.Enumerations;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;

namespace Web.UserControls
{
    public partial class HairShopListControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.databind();
            }
        }

        public void databind()
        {
            List<HairShop> list = new List<HairShop>();
            if (SortItem == 1)
            {
                if (SortType == 1)
                {
                    //按时间 , 升序
                    list = ProviderFactory.GetHairShopDataProviderInstance().GetHairShops(0, this.SelectCondition, OrderKey.ID,Sort.ASC);
                }
                else
                {
                    //按时间 , 降序
                    list = ProviderFactory.GetHairShopDataProviderInstance().GetHairShops(0, this.SelectCondition, OrderKey.ID,Sort.DESC);
                }
            }
            else
            {
                if (SortType == 1)
                {
                    //按点击数, 升序
                    list = ProviderFactory.GetHairShopDataProviderInstance().GetHairShops(0, this.SelectCondition, OrderKey.HitNum,Sort.ASC);
                }
                else
                {
                    //按点击数 , 降序
                    list = ProviderFactory.GetHairShopDataProviderInstance().GetHairShops(0, this.SelectCondition, OrderKey.HitNum,Sort.DESC);
                }
            }

            if (this.ProductID != string.Empty)
            {
                //过滤产品
                List<HairShop> list2 = new List<HairShop>();
                for (int i = 0; i < list.Count; i++)
                {
                    HairShop hairShop2 = list[i];

                    string[] pCollection = hairShop2.ProductIDs.Split(",".ToCharArray());

                    foreach (string s in pCollection)
                    {
                        if (s == this.ProductID)
                        {
                            list2.Add(hairShop2);
                            break;
                        }
                    }
                }
                list = list2;
            }
            if (this.KeyWord != string.Empty)
            {
                //过滤关键字

                List<HairShop> list2 = new List<HairShop>();
                for (int i = 0; i < list.Count; i++)
                {
                    HairShop hairShop2 = list[i];

                    string[] tCollection = hairShop2.HairShopTagIDs.Split(",".ToCharArray());

                    foreach (string s in tCollection)
                    {
                        string tname = "";
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "select * from HairShopTag where HairShopTagID = " + s;
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = commString;
                                comm.Connection = conn;
                                conn.Open();

                                using (SqlDataReader sdr = comm.ExecuteReader())
                                {
                                    if (sdr.Read())
                                    {
                                        tname = sdr["HairShopTagName"].ToString();
                                    }
                                }
                            }
                        }
                        if (tname.Contains(this.KeyWord))
                        {
                            list2.Add(hairShop2);
                            break;
                        }
                    }
                }
                list = list2;
            }

            StringBuilder sb = new StringBuilder();

            //page
            int frontPage = 0;
            int backPage = 0;
            int currentPage = this.CurrentPage;

            int pageCount = list.Count / this.PageSize + 1;

            if (PageSize == list.Count)
            {
                pageCount = list.Count/this.PageSize;
            }
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
                this.lblDisplayText.Text = "当前没有美发厅！";
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

            for (int k = 0; k < leftCol; k++)
            {
                int listID = k + (currentPage - 1) * PageSize;
                if (k % 2 == 0)
                {
                    HairShop hairShop = list[listID];
                    string picSmallUrl = "";

                    int total = hairShop.HairShopGood + hairShop.HairShopBad + hairShop.HairShopNormal;
                    int goodRate = 0;
                    if (total == 0)
                    {
                        goodRate = 0;
                    }
                    else
                    {
                        goodRate = Convert.ToInt32(Convert.ToDouble(hairShop.HairShopGood) / Convert.ToDouble(total) * 100);
                    }

                    using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString1 = "select top 1 * from shoppics where classid=2 and hairshopid=" + hairShop.HairShopID.ToString();
                        using (SqlCommand comm1 = new SqlCommand())
                        {
                            comm1.CommandText = commString1;
                            comm1.Connection = conn1;
                            conn1.Open();

                            using (SqlDataReader sdr1 = comm1.ExecuteReader())
                            {
                                if (sdr1.Read())
                                {
                                    picSmallUrl = sdr1["picsmallurl"].ToString();
                                }
                            }
                        }
                    }

                    if (picSmallUrl.ToString() == string.Empty)
                    {
                        picSmallUrl = "Theme/Images/sg-meifa_ls02.gif";
                    }

                    string cutPriceString = string.Empty;
                    if (hairShop.HairCutDiscountMin == 0 && hairShop.HairCutPirce == 0)
                    {
                        cutPriceString = "-";
                    }
                    else
                    {
                        if (hairShop.HairCutDiscountMin == hairShop.HairCutPirce)
                        {
                            cutPriceString = hairShop.HairCutPirce.ToString()+"元";
                        }
                        else
                        {
                            cutPriceString = hairShop.HairCutDiscountMin.ToString() + "-" + hairShop.HairCutPirce.ToString() + "元";
                        }
                    }

                    string dyePriceString = string.Empty;

                    if (hairShop.HairDyeDiscountMin == 0 && hairShop.HairDyePrice == 0)
                    {
                        dyePriceString = "-";
                    }
                    else
                    {
                        if (hairShop.HairDyePrice == hairShop.HairDyeDiscountMin)
                        {
                            dyePriceString = hairShop.HairDyePrice.ToString() + "元";
                        }
                        else
                        {
                            dyePriceString = hairShop.HairDyeDiscountMin.ToString() + "-" + hairShop.HairDyePrice.ToString()+"元";
                        }
                    }

                    string marcelPriceString = string.Empty;

                    if (hairShop.HairMarcelPrice == 0 && hairShop.HairMarcelDiscountMin == 0)
                    {
                        marcelPriceString = "-";
                    }
                    else
                    {
                        if (hairShop.HairMarcelPrice == hairShop.HairMarcelDiscountMin)
                        {
                            marcelPriceString = hairShop.HairMarcelPrice.ToString() + "元";
                        }
                        else
                        {
                            marcelPriceString = hairShop.HairMarcelDiscountMin.ToString() + "-" + hairShop.HairMarcelPrice.ToString() + "元";
                        }
                    }

                    string conservationPriceString = string.Empty;

                    if (hairShop.HairConservationDiscountMin == 0 && hairShop.HairConservationPrice == 0)
                    {
                        conservationPriceString = "-";
                    }
                    else
                    {
                        if (hairShop.HairConservationPrice == hairShop.HairConservationDiscountMin)
                        {
                            conservationPriceString = hairShop.HairConservationPrice.ToString() + "元";
                        }
                        else
                        {
                            conservationPriceString = hairShop.HairConservationDiscountMin.ToString() + "-" + hairShop.HairConservationPrice.ToString() + "元";
                        }
                    }

                    string shapePriceString = string.Empty;

                    if (hairShop.HairShapeDiscountMin == 0 && hairShop.HairShapePrice == 0)
                    {
                        shapePriceString = "-";
                    }
                    else
                    {
                        if (hairShop.HairShapePrice == hairShop.HairShapeDiscountMin)
                        {
                            shapePriceString = hairShop.HairShapePrice.ToString() + "元";
                        }
                        else
                        {
                            shapePriceString = hairShop.HairShapeDiscountMin.ToString() + "" + hairShop.HairShapePrice.ToString() + "元";
                        }
                    }


                    sb.Append("<div class=\"message-2\">");
                    sb.Append("<div class=\"clear\">");
                    sb.Append("<table width=\"98%\" height=\"129\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
                    sb.Append("<tr><td>&nbsp;</td><td height=\"13\" valign=\"top\">&nbsp;</td><td valign=\"top\">&nbsp;</td></tr>");
                    sb.Append("<tr><td width=\"27\">&nbsp;</td>");
                    sb.Append("<td width=\"100\" height=\"104\" valign=\"top\"><a href=\"HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "\"><img src=\"" + picSmallUrl + "\" width=\"96\" height=\"96\" class=\"pic_padding_glay\" /></a></td>");
                    sb.Append("<td width=\"561\" valign=\"top\">");

                    sb.Append("<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"gray12-lp\">");
                    sb.Append("<tr>");
                    sb.Append("<td width=\"4%\" height=\"12\">&nbsp;</td>");
                    sb.Append("<td width=\"8%\">[店名]</td>");
                    sb.Append("<td width=\"41%\" class=\"red12\"><strong>"+hairShop.HairShopName+"</strong></td>");
                    sb.Append("<td width=\"19%\">[电话] "+hairShop.HairShopPhoneNum.ToString()+" </td>");
                    sb.Append("<td width=\"10%\" align=\"right\">[价格]</td>");
                    sb.Append("<td width=\"18%\" rowspan=\"4\" valign=\"top\">&nbsp;&nbsp;剪：" + cutPriceString + "<br />&nbsp;&nbsp;染：" + dyePriceString + "<br />&nbsp;&nbsp;烫：" + marcelPriceString +"<br /> &nbsp;&nbsp;护："+conservationPriceString+"<br /> &nbsp;造型："+shapePriceString+"</td>");
                    sb.Append("</tr>");
                    sb.Append("<tr>");
                    sb.Append("<td height=\"20\">&nbsp;</td>");
                    sb.Append("<td>[地址]</td>");
                    sb.Append("<td colspan=\"2\">"+hairShop.HairShopAddress.ToString()+"</td>");
                    sb.Append("<td>&nbsp;</td>");
                    sb.Append("</tr>");
                    sb.Append("<tr>");
                    sb.Append("<td height=\"21\">&nbsp;</td>");
                    sb.Append("<td valign=\"top\">[简介]</td>");
                    sb.Append("<td colspan=\"2\" valign=\"top\">"+hairShop.HairShopDescription+"</td>");
                    sb.Append("<td rowspan=\"2\" valign=\"top\">&nbsp;</td>");
                    sb.Append("</tr>");
                    sb.Append("<tr>");
                    sb.Append("<td height=\"21\">&nbsp;</td>");
                    sb.Append("<td valign=\"top\">&nbsp;</td>");
                    sb.Append("<td align=\"left\" valign=\"top\"><a href=\"HairShopContent.aspx?id="+hairShop.HairShopID.ToString()+"\"   style=\" text-decoration:underline\">连锁店</a>&nbsp;&nbsp;<span style=\"text-decoration:underline\">折扣：</span><span class=\"red12\">"+hairShop.HairShopDiscount.ToString()+"折&nbsp;</span>&nbsp;好评：<span class=\"red12\">"+goodRate.ToString()+"%</span></td>");
                    sb.Append("<td align=\"left\" valign=\"top\"><img src=\"Theme/images/mft_list_arrow.gif\" width=\"9\" height=\"13\" />&nbsp;<a href=\"HairShopContent.aspx?id="+hairShop.HairShopID.ToString()+"\" target=\"_blank\"><span class=\"red12\">详情</span></a></td>");
                    sb.Append("</tr>");
                    sb.Append("<tr>");
                    sb.Append("<td colspan=\"6\"><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">");
                    sb.Append("<tr>");
                    sb.Append("<td height=\"30\" align=\"right\" valign=\"bottom\"><a href=\"#\" target=\"_blank\"><img src=\"Theme/images/mfs_list_map.gif\" width=\"59\" height=\"19\" border=\"0\" /></a>&nbsp;<a href='http://bbs.sg.com.cn/thread-" + hairShop.Postid.ToString() + "-1-1.html'><img src=\"Theme/images/fair-mfd_06b.gif\" /></a>&nbsp;&nbsp;</td>");
                    sb.Append("</tr>");
                    sb.Append("</table></td> </tr></table>");

                    sb.Append("</td></tr><tr><td>&nbsp;</td><td colspan=\"2\">&nbsp;</td></tr></table></div></div>");
                }
                else
                {
                    HairShop hairShop = list[listID];
                    string picSmallUrl = "";

                    int total = hairShop.HairShopGood + hairShop.HairShopBad + hairShop.HairShopNormal;
                    int goodRate = 0;
                    if (total == 0)
                    {
                        goodRate = 0;
                    }
                    else
                    {
                        goodRate = Convert.ToInt32(Convert.ToDouble(hairShop.HairShopGood) / Convert.ToDouble(total) * 100);
                    }

                    using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString1 = "select top 1 * from shoppics where classid=2 and hairshopid=" + hairShop.HairShopID.ToString();
                        using (SqlCommand comm1 = new SqlCommand())
                        {
                            comm1.CommandText = commString1;
                            comm1.Connection = conn1;
                            conn1.Open();

                            using (SqlDataReader sdr1 = comm1.ExecuteReader())
                            {
                                if (sdr1.Read())
                                {
                                    picSmallUrl = sdr1["picsmallurl"].ToString();
                                }
                            }
                        }
                    }

                    if (picSmallUrl.ToString() == string.Empty)
                    {
                        picSmallUrl = "Theme/Images/sg-meifa_ls02.gif";
                    }

                    string cutPriceString = string.Empty;
                    if (hairShop.HairCutDiscountMin == 0 && hairShop.HairCutPirce == 0)
                    {
                        cutPriceString = "-";
                    }
                    else
                    {
                        if (hairShop.HairCutDiscountMin == hairShop.HairCutPirce)
                        {
                            cutPriceString = hairShop.HairCutPirce.ToString() + "元";
                        }
                        else
                        {
                            cutPriceString = hairShop.HairCutDiscountMin.ToString() + "-" + hairShop.HairCutPirce.ToString() + "元";
                        }
                    }

                    string dyePriceString = string.Empty;

                    if (hairShop.HairDyeDiscountMin == 0 && hairShop.HairDyePrice == 0)
                    {
                        dyePriceString = "-";
                    }
                    else
                    {
                        if (hairShop.HairDyePrice == hairShop.HairDyeDiscountMin)
                        {
                            dyePriceString = hairShop.HairDyePrice.ToString() + "元";
                        }
                        else
                        {
                            dyePriceString = hairShop.HairDyeDiscountMin.ToString() + "-" + hairShop.HairDyePrice.ToString() + "元";
                        }
                    }

                    string marcelPriceString = string.Empty;

                    if (hairShop.HairMarcelPrice == 0 && hairShop.HairMarcelDiscountMin == 0)
                    {
                        marcelPriceString = "-";
                    }
                    else
                    {
                        if (hairShop.HairMarcelPrice == hairShop.HairMarcelDiscountMin)
                        {
                            marcelPriceString = hairShop.HairMarcelPrice.ToString() + "元";
                        }
                        else
                        {
                            marcelPriceString = hairShop.HairMarcelDiscountMin.ToString() + "-" + hairShop.HairMarcelPrice.ToString() + "元";
                        }
                    }

                    string conservationPriceString = string.Empty;

                    if (hairShop.HairConservationDiscountMin == 0 && hairShop.HairConservationPrice == 0)
                    {
                        conservationPriceString = "-";
                    }
                    else
                    {
                        if (hairShop.HairConservationPrice == hairShop.HairConservationDiscountMin)
                        {
                            conservationPriceString = hairShop.HairConservationPrice.ToString() + "元";
                        }
                        else
                        {
                            conservationPriceString = hairShop.HairConservationDiscountMin.ToString() + "-" + hairShop.HairConservationPrice.ToString() + "元";
                        }
                    }

                    string shapePriceString = string.Empty;

                    if (hairShop.HairShapeDiscountMin == 0 && hairShop.HairShapePrice == 0)
                    {
                        shapePriceString = "-";
                    }
                    else
                    {
                        if (hairShop.HairShapePrice == hairShop.HairShapeDiscountMin)
                        {
                            shapePriceString = hairShop.HairShapePrice.ToString() + "元";
                        }
                        else
                        {
                            shapePriceString = hairShop.HairShapeDiscountMin.ToString() + "" + hairShop.HairShapePrice.ToString() + "元";
                        }
                    }

                    sb.Append("<div class=\"message-1\">");
                    sb.Append("<div class=\"clear\">");
                    sb.Append("<table width=\"98%\" height=\"129\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
                    sb.Append("<tr><td>&nbsp;</td><td height=\"13\" valign=\"top\">&nbsp;</td><td valign=\"top\">&nbsp;</td></tr>");
                    sb.Append("<tr><td width=\"27\">&nbsp;</td>");
                    sb.Append("<td width=\"100\" height=\"104\" valign=\"top\"><a href=\"HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "\"><img src=\"" + picSmallUrl + "\" width=\"96\" height=\"96\" class=\"pic_padding_glay\" /></a></td>");
                    sb.Append("<td width=\"561\" valign=\"top\">");

                    sb.Append("<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"gray12-lp\">");
                    sb.Append("<tr>");
                    sb.Append("<td width=\"4%\" height=\"12\">&nbsp;</td>");
                    sb.Append("<td width=\"8%\">[店名]</td>");
                    sb.Append("<td width=\"41%\" class=\"red12\"><strong>" + hairShop.HairShopName + "</strong></td>");
                    sb.Append("<td width=\"19%\">[电话] " + hairShop.HairShopPhoneNum.ToString() + " </td>");
                    sb.Append("<td width=\"10%\" align=\"right\">[价格]</td>");
                    sb.Append("<td width=\"18%\" rowspan=\"4\" valign=\"top\">&nbsp;&nbsp;剪：" + cutPriceString + "<br />&nbsp;&nbsp;染：" + dyePriceString + "<br />&nbsp;&nbsp;烫：" + marcelPriceString + "<br /> &nbsp;&nbsp;护：" + conservationPriceString + "<br /> &nbsp;造型：" + shapePriceString + "</td>");
                    sb.Append("</tr>");
                    sb.Append("<tr>");
                    sb.Append("<td height=\"20\">&nbsp;</td>");
                    sb.Append("<td>[地址]</td>");
                    sb.Append("<td colspan=\"2\">" + hairShop.HairShopAddress.ToString() + "</td>");
                    sb.Append("<td>&nbsp;</td>");
                    sb.Append("</tr>");
                    sb.Append("<tr>");
                    sb.Append("<td height=\"21\">&nbsp;</td>");
                    sb.Append("<td valign=\"top\">[简介]</td>");
                    sb.Append("<td colspan=\"2\" valign=\"top\">" + hairShop.HairShopDescription + "</td>");
                    sb.Append("<td rowspan=\"2\" valign=\"top\">&nbsp;</td>");
                    sb.Append("</tr>");
                    sb.Append("<tr>");
                    sb.Append("<td height=\"21\">&nbsp;</td>");
                    sb.Append("<td valign=\"top\">&nbsp;</td>");
                    sb.Append("<td align=\"left\" valign=\"top\"><a href=\"HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "\"   style=\" text-decoration:underline\">连锁店</a>&nbsp;&nbsp;<span style=\"text-decoration:underline\">折扣：</span><span class=\"red12\">" + hairShop.HairShopDiscount.ToString() + "折&nbsp;</span>&nbsp;好评：<span class=\"red12\">" + goodRate.ToString() + "%</span></td>");
                    sb.Append("<td align=\"left\" valign=\"top\"><img src=\"Theme/images/mft_list_arrow.gif\" width=\"9\" height=\"13\" />&nbsp;<a href=\"HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "\" target=\"_blank\"><span class=\"red12\">详情</span></a></td>");
                    sb.Append("</tr>");
                    sb.Append("<tr>");
                    sb.Append("<td colspan=\"6\"><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">");
                    sb.Append("<tr>");
                    sb.Append("<td height=\"30\" align=\"right\" valign=\"bottom\"><a href=\"#\" target=\"_blank\"><img src=\"Theme/images/mfs_list_map.gif\" width=\"59\" height=\"19\" border=\"0\" /></a>&nbsp;<a href='http://bbs.sg.com.cn/thread-" + hairShop.Postid.ToString() + "-1-1.html'><img src=\"Theme/images/fair-mfd_06b.gif\" /></a>&nbsp;&nbsp;</td>");
                    sb.Append("</tr>");
                    sb.Append("</table></td> </tr></table>");


                    sb.Append("</td></tr><tr><td>&nbsp;</td><td colspan=\"2\">&nbsp;</td></tr></table></div></div>");
                }
            }

            this.lblDisplayText.Text = sb.ToString();

            //this.lblCurrentPage.Text = currentPage.ToString();
            if (list.Count != 0)
            {
                this.lblHairShopCount.Text = list.Count.ToString();
            }
            else
            {
                this.lblHairShopCount.Text = "0";
            }
            if (currentPage == 1)
            {
                this.lblFrontPage.Text = "上一页";
                if (pageCount > 1)
                {
                    this.lblNextPage.Text = "<a class=\"gray12-d\" href=\"HairShopList.aspx?pageNum=" + backPage.ToString() + "\">下一页</a>";
                }
                else
                {
                    this.lblNextPage.Text = "下一页";
                }
            }
            else
            {
                if (currentPage == pageCount)
                {   
                    this.lblFrontPage.Text = "<a class=\"gray12-d\" href=\"HairShopList.aspx?pageNum=" + frontPage.ToString() + "\">上一页</a>";
                    this.lblNextPage.Text = "下一页";
                }
                else
                {
                    this.lblFrontPage.Text = "<a class=\"gray12-d\" href=\"HairShopList.aspx?pageNum=" + frontPage.ToString() + "\">上一页</a>";
                    this.lblNextPage.Text = "<a class=\"gray12-d\" href=\"HairShopList.aspx?pageNum=" + backPage.ToString() + "\">下一页</a>";
                }
            }
            

            this.lblPageCount.Text = pageCount.ToString();

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("<div class=\"page-all\">");
            if (this.CurrentPage > 1)
            {
                sb2.Append("<a href=\"HairShopList.aspx?pageNum=1\">第一页</a>");
                sb2.Append("&nbsp;<a href=\"HairShopList.aspx?pageNum=" + frontPage.ToString() + "\">上一页</a>&nbsp;");
            }
            else
            {
                sb2.Append("第一页");
                sb2.Append("&nbsp;上一页&nbsp;");
            }
            
            

            if (CurrentPage < 3)
            {
                for (int m = 1; m <= pageCount; m++)
                {
                    if (m == currentPage)
                    {
                        sb2.Append("&nbsp;<a class=\"red12\" href=\"HairShopList.aspx?pageNum=" + m.ToString() + "\">" + m.ToString() + "</a>&nbsp;");
                    }
                    else
                    {
                        sb2.Append("&nbsp;<a href=\"HairShopList.aspx?pageNum=" + m.ToString() + "\">" + m.ToString() + "</a>&nbsp;");
                    }
                    if (m == 5)
                    {
                        break;
                    }
                }
            }
            else
            {
                if ((pageCount - currentPage) > 3)
                {
                    for (int m = (currentPage - 2); m <= (CurrentPage + 2); m++)
                    {
                        if (m == currentPage)
                        {
                            sb2.Append("&nbsp;<a class=\"red12\" href=\"HairShopList.aspx?pageNum=" + m.ToString() + "\">" + m.ToString() + "</a>&nbsp;");
                        }
                        else
                        {
                            sb2.Append("&nbsp;<a href=\"HairShopList.aspx?pageNum=" + m.ToString() + "\">" + m.ToString() + "</a>&nbsp;");
                        }
                    }
                }
                else
                {
                    for (int m = (currentPage - 2); m <= pageCount; m++)
                    {
                        if (m == currentPage)
                        {
                            sb2.Append("&nbsp;<a class=\"red12\" href=\"HairShopList.aspx?pageNum=" + m.ToString() + "\">" + m.ToString() + "</a>&nbsp;");
                        }
                        else
                        {
                            sb2.Append("&nbsp;<a href=\"HairShopList.aspx?pageNum=" + m.ToString() + "\">" + m.ToString() + "</a>&nbsp;");
                        }
                    }
                }
            }
            if (this.CurrentPage < pageCount)
            {
                sb2.Append("&nbsp;<a href=\"HairShopList.aspx?pageNum=" + backPage.ToString() + "\">下一页</a>");
                sb2.Append("&nbsp;<a href=\"HairShopList.aspx?pageNum=" + pageCount.ToString() + "\">最后一页</a>");
            }
            else
            {
                sb2.Append("&nbsp;下一页");
                sb2.Append("&nbsp;最后一页");
            }
            sb2.Append("&nbsp;共" + pageCount.ToString() + "页</div>");

            this.lblPageText.Text = sb2.ToString();
        }
        public void setStatusValue()
        {
            int pageNum = 1;
            try
            {
                pageNum = int.Parse(this.Request.QueryString["pageNum"].ToString());
            }
            catch
            {
                pageNum = 1;
            }

            //城区(district)
            //商圈(buzizone)
            //品牌(product)
            //营业面积(square)
            //关键字(keyword)
            StringBuilder sb = new StringBuilder();
            string district = string.Empty;
            string buzizone = string.Empty;
            string product = string.Empty;
            string square = string.Empty;
            string keyword = string.Empty;

            try
            {
                district = this.Request.QueryString["district"].ToString();
                if (district != string.Empty)
                {
                    sb.Append(" where m.MapZoneID = " + district);
                }
            }
            catch
            { }

            try
            {
                buzizone = this.Request.QueryString["buzizone"].ToString();
                if (buzizone != string.Empty)
                {
                    if (sb.ToString() == string.Empty)
                    {
                        sb.Append(" where h.hotZoneID = " + buzizone);
                    }
                    else
                    {
                        sb.Append(" and h.hotZoneID = " + buzizone);
                    }
                }
            }
            catch
            { }

            try
            {
                square = this.Request.QueryString["square"].ToString();
                if (square != string.Empty)
                {
                    if (sb.ToString() == string.Empty)
                    {
                        sb.Append(" where hs.square = " + square);
                    }
                    else
                    {
                        sb.Append(" and hs.square = " + square);
                    }
                }
            }
            catch
            { }
            try
            {
                product = this.Request.QueryString["product"].ToString();
            }
            catch
            { }

            try
            {
                keyword = Server.UrlDecode(this.Request.QueryString["keyword"].ToString());
            }
            catch
            { }

            this.PageSize = 6;
            this.CurrentPage = pageNum;
            

            this.SelectCondition = sb.ToString();
            this.ProductID = product;
            this.KeyWord = keyword;
        }
        public void btnID0_OnClick(object sender, EventArgs e)
        {
            this.setStatusValue();
            this.SortType = 0;
            this.SortItem = 1;

            this.databind();
        }
        public void btnID1_OnClick(object sender, EventArgs e)
        {
            this.setStatusValue();
            this.SortType = 1;
            this.SortItem = 1;

            this.databind();
        }
        public void btnHitNum0_OnClick(object sender, EventArgs e)
        {
            this.setStatusValue();
            this.SortType = 0;
            this.SortItem = 0;

            this.databind();
        }
        public void btnHitNum1_OnClick(object sender, EventArgs e)
        {
            this.setStatusValue();
            this.SortType = 1;
            this.SortItem = 0;

            this.databind();
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
        private int _sortType = 0;
        public int SortType
        {
            set { this._sortType = value; }
            get { return this._sortType; }
        }
        private string _selectCondition = string.Empty;
        public string SelectCondition
        {
            set { this._selectCondition = value; }
            get { return this._selectCondition; }
        }

        private string _productID = string.Empty;
        public string ProductID
        {
            set { this._productID = value; }
            get { return this._productID; }
        }

        private string _keyword = string.Empty;
        public string KeyWord
        {
            set { this._keyword = value; }
            get { return this._keyword; }
        }
        private int _sortItem = 0;
        public int SortItem
        {
            set { this._sortItem = value; }
            get { return this._sortItem; }
        }
    }
}