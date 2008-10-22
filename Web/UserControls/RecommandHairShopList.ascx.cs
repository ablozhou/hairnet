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
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using HairNet.Utilities;

namespace Web.UserControls
{
    public partial class RecommandHairShopList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                List<HairShopRecommand> list = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopRecommands(0);

                StringBuilder sb = new StringBuilder();
                
                sb.Append("<tr>");

                for(int i=0;i<list.Count;i++)
                {
                    HairShopRecommand hsr = list[i];

                    string hairShopName = string.Empty;
                    string picSmallUrl = string.Empty;
                    string description = string.Empty;

                    hairShopName = hsr.HairShopName;
                    description = hsr.HairShopDescription;

                    using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString1 = "select top 1 * from shoppics where hairShopID=" + hsr.HairShopRawID.ToString();
                        using (SqlCommand comm1 = new SqlCommand())
                        {
                            comm1.CommandText = commString1;
                            comm1.Connection = conn1;
                            conn1.Open();

                            using (SqlDataReader sdr1 = comm1.ExecuteReader())
                            {
                                if (sdr1.Read())
                                {
                                    if (sdr1["picsmallurl"].ToString() == string.Empty)
                                    {
                                        picSmallUrl = "Theme/Images/sg-meifa_ls02.gif";
                                    }
                                    else
                                    {
                                        picSmallUrl = sdr1["picsmallurl"].ToString();
                                    }
                                }
                            }
                        }
                    }


                    sb.Append("<td width=\"20%\" align=\"center\"><div class=\"pic-2\"><a href=\"HairShopContent.aspx?id=" + hsr.HairShopRawID.ToString() + "\" target=\"_blank\"><img src=\"" + picSmallUrl + "\" alt=\"" + description + "\" /></a><br /><a href=\"HairShopContent.aspx?id="+hsr.HairShopRawID.ToString()+"\" target=\"_blank\">" + StringHelper.GetDescription(hairShopName,8) + "</a></div></td>");

                }
     
                sb.Append("</tr>");
                    


                if (list.Count == 0)
                {
                    this.lblText.Text = "&nbsp;&nbsp;&nbsp;&nbsp;当前没有推荐美发厅";
                }
                else
                {
                    this.lblText.Text = sb.ToString();
                }
            }
        }
        private int _rowCount = 1;
        public int RowCount
        {
            set { this._rowCount = value; }
            get { return this._rowCount; }
        }
    }
}