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
    public partial class HairShopWorkList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                StringBuilder sb = new StringBuilder();

                int num = 0;
                using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString1 = "select hst.descr,hst.hairname,hs.HairShopName,hst.id from HairStyle hst inner join HairShop hs on hst.hairshopid = hs.HairShopID where hst.hairshopid=" + this.HairShopID.ToString();
                    using (SqlCommand comm1 = new SqlCommand())
                    {
                        comm1.CommandText = commString1;
                        comm1.Connection = conn1;
                        conn1.Open();

                        using (SqlDataReader sdr1 = comm1.ExecuteReader())
                        {
                            while (sdr1.Read())
                            {
                                string hairStyleName = string.Empty;
                                string hairShopName = string.Empty;
                                string hairStyleID = string.Empty;
                                string smallPicUrl = string.Empty;
                                string hairStyleDescription = string.Empty;

                                hairStyleName = sdr1["HairName"].ToString();
                                hairShopName = sdr1["HairShopName"].ToString();
                                hairStyleID = sdr1["ID"].ToString();
                                hairStyleDescription = sdr1["descr"].ToString();


                                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                                {
                                    string commString = "select top 1 smallpicurl from PictureStoreSet where hairstylepos=1 amd picturestoreid=" + hairStyleID;
                                    using (SqlCommand comm = new SqlCommand())
                                    {
                                        comm.CommandText = commString;
                                        comm.Connection = conn;
                                        conn.Open();

                                        using (SqlDataReader sdr = comm.ExecuteReader())
                                        {
                                            if (sdr.Read())
                                            {
                                                smallPicUrl = sdr["smallpicurl"].ToString();
                                            }
                                        }
                                    }
                                }

                                if (smallPicUrl == string.Empty)
                                {
                                    smallPicUrl = "Theme/Images/sg-meifa_ls01.gif";
                                }

                                num++;
                                if (num % 6 == 0)
                                {
                                    sb.Append("<tr>");
                                }

                                sb.Append("<td width=\"20%\" align=\"center\"><div class=\"pic-1\"><a href=\"#\" target=\"_blank\"><img src=\""+smallPicUrl+"\" alt=\""+hairStyleDescription+"\" /></a><br /><a href=\"#\" target=\"_blank\">"+hairStyleName+"<br />"+hairShopName+"</a></div></td>");
                                
                                if (num % 6 == 0)
                                {
                                    sb.Append("</tr>");
                                }
                            }
                        }
                    }
                }
                if (num == 0)
                {
                    this.lblWorkList.Text = "当前美发厅没有作品";
                }
                else
                {
                    this.lblWorkList.Text = sb.ToString();
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