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
using HairNet.Provider;
using System.Data.SqlClient;
using System.Text;

namespace Web.UserControls
{
    public partial class SameHotZoneHairShopList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                HairShop hairShop = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(this.HairShopID);
                StringBuilder sb = new StringBuilder();
                sb.Append("<table width=\"88%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">");
                sb.Append("<tr>");
                
                StringBuilder sb2 = new StringBuilder();
                sb2.Append("<table width=\"92%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" style=\"margin-top:5px;margin-bottom:12px\">");
                
                int num = 0;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select top 9 * from HairShop where HairShopHotZoneID = "+hairShop.HairShopHotZoneID.ToString()+" order by HairShopID desc";
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
                                string hairShopDiscount = string.Empty;
                                string picUrl = string.Empty;
                                string picSmallUrl = string.Empty;
                                string description = string.Empty;

                                hairShopName = sdr["HairShopName"].ToString();
                                hairShopDiscount = sdr["HairShopDiscount"].ToString();
                                description = sdr["HairShopDescription"].ToString();

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
                                                picUrl = sdr1["picurl"].ToString();
                                                picSmallUrl = sdr1["picsmallurl"].ToString();
                                            }
                                        }
                                    }
                                }

                                if (picSmallUrl.ToString() == string.Empty)
                                {
                                    picSmallUrl = "Theme/Images/sg-meifa_ls02.gif";
                                    picUrl = "#";
                                }

                                num++;

                                switch (num)
                                {
                                    case 1:
                                        sb.Append("<td width=\"50%\" align=\"center\" valign=\"top\"><div class=\"pic-3\"><a href=\""+picUrl+"\"><img src=\""+picSmallUrl+"\" alt=\""+description+"\" /></a><br />");
                                        sb.Append("<a href=\"#\" target=\"_blank\">"+hairShopName+"&nbsp;"+hairShopDiscount+"折</a></div></td>");
                                        break;
                                    case 2:
                                        sb.Append("<td width=\"50%\" align=\"center\" valign=\"top\"><div class=\"pic-3\"><a href=\""+picUrl+"\"><img src=\""+picSmallUrl+"\" alt=\""+description+"\" /></a><br />");
                                        sb.Append("<a href=\"#\" target=\"_blank\">"+hairShopName+"&nbsp;"+hairShopDiscount+"折</a></div></td>");
                                        break;
                                    default:
                                        sb2.Append("<tr>");
                                        sb2.Append("<td width=\"83%\" align=\"left\" class=\"gray14-e\">·&nbsp;<a href=\"#\" target=\"_blank\">"+hairShopName+"</a></td>");
                                        sb2.Append("<td width=\"17%\" align=\"center\" class=\"red14\">"+hairShopDiscount+"折</td>");
                                        sb2.Append("</tr>");
                                        break;
                                }
                            }
                        }
                    }
                }
                sb.Append("</tr>");
                sb.Append("</table>");

                if(num>2)
                {
                    sb2.Append("</table>");

                    this.lbl1.Text = sb.ToString();
                    this.lbl2.Text = sb2.ToString(); 
                }
                else
                {
                    if(num!=0)
                    {
                        this.lbl1.Text = sb.ToString();
                        this.lbl2.Text = ""; 
                    }
                    else
                    {
                        this.lbl1.Text = "周边没有美发厅";
                        this.lbl2.Text = ""; 
                    }
                }
                
            }
        }
        private int _hairShopID = 0;
        public int HairShopID
        {
            set { this._hairShopID = value; }
            get { return this._hairShopID; }
        }
    }
}