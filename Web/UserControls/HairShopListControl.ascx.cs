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
                List<HairShop> list = new List<HairShop>();
                if (SortType == 1)
                {
                    //按时间
                    list = ProviderFactory.GetHairShopDataProviderInstance().GetHairShops(0,this.SelectCondition, OrderKey.ID);
                }
                else
                {
                    //按点击数
                    list = ProviderFactory.GetHairShopDataProviderInstance().GetHairShops(0,this.SelectCondition, OrderKey.HitNum);
                }

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
                    this.lblDisplayText.Text = "当前没有美发厅！";
                    this.lblDisplayText.ForeColor = Color.Red;
                    return;
                }


                    int leftCount = list.Count  - (currentPage - 1) * PageSize;
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

                            int total = hairShop.HairShopGood+hairShop.HairShopBad+hairShop.HairShopNormal;
                            int goodRate =0;
                            if(total ==0)
                            {
                                goodRate =0;
                            }
                            else
                            {
                                goodRate = Convert.ToInt32(Convert.ToDouble(hairShop.HairShopGood)/Convert.ToDouble(total)*100);
                            }

                            string[] photoID = hairShop.OutLogs.Split(",".ToCharArray());
                            if (photoID.Length == 1)
                            {
                                picSmallUrl = "Theme/Images/sg-meifa_ls02.gif";
                            }
                            else
                            {
                                using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                                {
                                    string commString1 = "select top 1 * from shoppics where id=" + photoID[1];
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
                            }

                            sb.Append("<div class=\"message-2\">");
		                    sb.Append("<div class=\"clear\">");
		                    sb.Append("<table width=\"98%\" height=\"129\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
                            sb.Append("<tr><td>&nbsp;</td><td height=\"13\" valign=\"top\">&nbsp;</td><td valign=\"top\">&nbsp;</td></tr>");
                            sb.Append("<tr><td width=\"27\">&nbsp;</td>");
                            sb.Append("<td width=\"100\" height=\"104\" valign=\"top\"><a href=\"HairShopContent.aspx?id="+hairShop.HairShopID.ToString()+"\"><img src=\""+picSmallUrl+"\" width=\"96\" height=\"96\" class=\"pic_padding_glay\" /></a></td>");
                            sb.Append("<td width=\"561\" valign=\"top\"><table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"gray12-lp\">");
                            sb.Append("<tr>");
                            sb.Append("<td width=\"4%\" height=\"12\">&nbsp;</td>");
                            sb.Append("<td width=\"12%\">[名称]</td>");
                            sb.Append("<td width=\"27%\" class=\"red12\"><strong>"+hairShop.HairShopName+"</strong></td>");
                            sb.Append("<td width=\"8%\">[价格]</td>");
                            sb.Append("<td width=\"21%\">"+hairShop.HairShapePrice.ToString()+"元</td>");
                            sb.Append("<td width=\"4%\"><img src=\"Theme/images/mft_list_arrow.gif\" width=\"9\" height=\"13\" /></td>");
                            sb.Append("<td width=\"10%\"><a href=\"HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "\"   style=\" text-decoration:underline\">连锁店</a></td>");
                            sb.Append("<td width=\"14%\">折扣：<span class=\"red12\">"+hairShop.HairShopDiscount.ToString()+"折</span></td></tr>");
                            sb.Append("<tr>");
                            sb.Append("<td height=\"20\">&nbsp;</td>");
                            sb.Append("<td>[地址]</td>");
                            sb.Append("<td>"+hairShop.HairShopAddress+"</td>");
                            sb.Append("<td>[电话]</td>");
                            sb.Append("<td>"+hairShop.HairShopPhoneNum+"</td>");
                            sb.Append("<td colspan=\"3\" valign=\"top\">&nbsp;</td>");
                            sb.Append("</tr>");
                            sb.Append("<tr>");
                            sb.Append("<td height=\"42\">&nbsp;</td>");
                            sb.Append("<td valign=\"top\">[简介]</td>");
                            sb.Append("<td colspan=\"6\" valign=\"top\">"+hairShop.HairShopDescription+"</td>");
                            sb.Append("</tr>");
                            sb.Append("<tr>");
                            sb.Append("<td>&nbsp;</td>");
                            sb.Append("<td colspan=\"7\"><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">");
                            sb.Append("<tr>");
                            sb.Append("<td width=\"13%\" height=\"27\"><a href=\"#\" target=\"_blank\"><img src=\"Theme/images/mfs_list_map.gif\" width=\"59\" height=\"19\" border=\"0\" /></a></td>");
                            sb.Append("<td width=\"28%\"><a onClick=\"window.external.AddFavorite('HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "','" + hairShop.HairShopName + "');\" href=\"" + this.Request.Url.ToString() + "\"><img src=\"Theme/images/mft_list_collection.gif\" width=\"59\" height=\"19\" border=\"0\" /></a></td>");
                            sb.Append("<td width=\"8%\">[好评]</td>");
                            sb.Append("<td width=\"16%\"><span class=\"red12\">"+goodRate+"%</span></td>");
                            sb.Append("<td width=\"35%\"><a href=\"HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "\" class=\"red12\" style=\" text-decoration:underline\">查 看</a> | <a href=\"http://bbs.sg.com.cn/xxx_xxx.htm\" style=\" text-decoration:underline\">我要评论</a></td>");
                            sb.Append("</tr></table></td></tr></table></td></tr><tr><td>&nbsp;</td><td colspan=\"2\">&nbsp;</td></tr></table></div></div>");
                        }
                        else
                        {
                            HairShop hairShop = list[listID];
                            string picSmallUrl = "";

                            int total = hairShop.HairShopGood+hairShop.HairShopBad+hairShop.HairShopNormal;
                            int goodRate =0;
                            if(total ==0)
                            {
                                goodRate =0;
                            }
                            else
                            {
                                goodRate = Convert.ToInt32(Convert.ToDouble(hairShop.HairShopGood)/Convert.ToDouble(total)*100);
                            }

                            string[] photoID = hairShop.OutLogs.Split(",".ToCharArray());
                            if (photoID.Length == 1)
                            {
                                picSmallUrl = "Theme/Images/sg-meifa_ls02.gif";
                            }
                            else
                            {
                                using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                                {
                                    string commString1 = "select top 1 * from shoppics where id=" + photoID[1];
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
                            }

                            sb.Append("<div class=\"message-1\">");
                            sb.Append("<div class=\"clear\">");
                            sb.Append("<table width=\"98%\" height=\"129\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
                            sb.Append("<tr><td>&nbsp;</td><td height=\"13\" valign=\"top\">&nbsp;</td><td valign=\"top\">&nbsp;</td></tr>");
                            sb.Append("<tr><td width=\"27\">&nbsp;</td>");
                            sb.Append("<td width=\"100\" height=\"104\" valign=\"top\"><a href=\"HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "\"><img src=\"" + picSmallUrl + "\" width=\"96\" height=\"96\" class=\"pic_padding_glay\" /></a></td>");
                            sb.Append("<td width=\"561\" valign=\"top\"><table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"gray12-lp\">");
                            sb.Append("<tr>");
                            sb.Append("<td width=\"4%\" height=\"12\">&nbsp;</td>");
                            sb.Append("<td width=\"12%\">[名称]</td>");
                            sb.Append("<td width=\"27%\" class=\"red12\"><strong>" + hairShop.HairShopName + "</strong></td>");
                            sb.Append("<td width=\"8%\">[价格]</td>");
                            sb.Append("<td width=\"21%\">" + hairShop.HairShapePrice.ToString() + "元</td>");
                            sb.Append("<td width=\"4%\"><img src=\"Theme/images/mft_list_arrow.gif\" width=\"9\" height=\"13\" /></td>");
                            sb.Append("<td width=\"10%\"><a href=\"HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "\"   style=\" text-decoration:underline\">连锁店</a></td>");
                            sb.Append("<td width=\"14%\">折扣：<span class=\"red12\">" + hairShop.HairShopDiscount.ToString() + "折</span></td></tr>");
                            sb.Append("<tr>");
                            sb.Append("<td height=\"20\">&nbsp;</td>");
                            sb.Append("<td>[地址]</td>");
                            sb.Append("<td>" + hairShop.HairShopAddress + "</td>");
                            sb.Append("<td>[电话]</td>");
                            sb.Append("<td>" + hairShop.HairShopPhoneNum + "</td>");
                            sb.Append("<td colspan=\"3\" valign=\"top\">&nbsp;</td>");
                            sb.Append("</tr>");
                            sb.Append("<tr>");
                            sb.Append("<td height=\"42\">&nbsp;</td>");
                            sb.Append("<td valign=\"top\">[简介]</td>");
                            sb.Append("<td colspan=\"6\" valign=\"top\">" + hairShop.HairShopDescription + "</td>");
                            sb.Append("</tr>");
                            sb.Append("<tr>");
                            sb.Append("<td>&nbsp;</td>");
                            sb.Append("<td colspan=\"7\"><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">");
                            sb.Append("<tr>");
                            sb.Append("<td width=\"13%\" height=\"27\"><a href=\"#\" target=\"_blank\"><img src=\"Theme/images/mfs_list_map.gif\" width=\"59\" height=\"19\" border=\"0\" /></a></td>");
                            sb.Append("<td width=\"28%\"><a onClick=\"window.external.AddFavorite('HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "','" + hairShop.HairShopName + "');\" href=\"" + this.Request.Url.ToString() + "\"><img src=\"Theme/images/mft_list_collection.gif\" width=\"59\" height=\"19\" border=\"0\" /></a></td>");
                            sb.Append("<td width=\"16%\"><span class=\"red12\">" + goodRate + "%</span></td>");
                            sb.Append("<td width=\"35%\"><a href=\"HairShopContent.aspx?id=" + hairShop.HairShopID.ToString() + "\" class=\"red12\" style=\" text-decoration:underline\">查 看</a> | <a href=\"http://bbs.sg.com.cn/xxx_xxx.htm\" style=\" text-decoration:underline\">我要评论</a></td>");
                            sb.Append("</tr></table></td></tr></table></td></tr><tr><td>&nbsp;</td><td colspan=\"2\">&nbsp;</td></tr></table></div></div>");
                        }
                    }

                this.lblDisplayText.Text = sb.ToString();

                //this.lblCurrentPage.Text = currentPage.ToString();
                this.lblHairShopCount.Text = list.Count.ToString();
                this.lblFrontPage.Text = "<a href=\"HairShopList.aspx?pageNum=" + frontPage.ToString() + "\">上一页</a>";
                this.lblNextPage.Text = "<a href=\"HairShopList.aspx?pageNum=" + backPage.ToString() + "\">下一页</a>";
                this.lblPageCount.Text = pageCount.ToString();

                StringBuilder sb2 = new StringBuilder();
                sb2.Append("<div class=\"page-all\">");
                sb2.Append("<a href=\"HairShopList.aspx?pageNum=1\">第一页</a>");
                sb2.Append("&nbsp;<a href=\"HairShopList.aspx?pageNum="+frontPage.ToString()+"\">上一页</a>&nbsp;");
                
                if(CurrentPage<3)
                {
                    for(int m=1;m<=pageCount;m++)
                    {
                        if(m==currentPage)
                        {
                            sb2.Append("<span class=\"red12\"><a href=\"HairShopList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a></span>");
                        }
                        else
                        {
                            sb2.Append("<a href=\"HairShopList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a>");
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
                                sb2.Append("<span class=\"red12\"><a href=\"HairShopList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a></span>");
                            }
                            else
                            {
                                sb2.Append("<a href=\"HairShopList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a>");
                            }
                        }
                    }
                    else
                    {
                        for(int m=(currentPage-2);m<=pageCount;m++)
                        {
                            if(m==currentPage)
                            {
                                sb2.Append("<span class=\"red12\"><a href=\"HairShopList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a></span>");
                            }
                            else
                            {
                                sb2.Append("<a href=\"HairShopList.aspx?pageNum="+m.ToString()+"\">"+m.ToString()+"</a>");
                            }
                        }
                    }
                }

                sb2.Append("&nbsp;<a href=\"HairShopList.aspx?pageNum="+backPage.ToString()+"\">下一页</a>");
                sb2.Append("&nbsp;<a href=\"HairShopList.aspx?pageNum="+pageCount.ToString()+"\">最后一页</a>");
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
    }
}