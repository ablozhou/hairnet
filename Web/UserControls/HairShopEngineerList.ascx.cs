﻿using System;
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
    public partial class HairShopEngineerList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                StringBuilder sb = new StringBuilder();
                
                int num = 0;
                int jinum = 0;
                using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString1 = "select * from HairEngineer where hairshopID=" + this.HairShopID;
                    using (SqlCommand comm1 = new SqlCommand())
                    {
                        comm1.CommandText = commString1;
                        comm1.Connection = conn1;
                        conn1.Open();

                        using (SqlDataReader sdr1 = comm1.ExecuteReader())
                        {
                            while (sdr1.Read())
                            {   
                                string hairEngineerName = string.Empty;
                                string hairEngineerPosition = string.Empty;
                                string hairEngineerRawPrice = string.Empty;
                                string hairEngineerPic = string.Empty;
                                string hairEngineerDescription = string.Empty;
                                string hairEngineerID = string.Empty;
                                
                                hairEngineerID = sdr1["HairEngineerID"].ToString();
                                hairEngineerName = sdr1["HairEngineerName"].ToString();
                                hairEngineerPosition = sdr1["HairEngineerClassID"].ToString();
                                hairEngineerRawPrice = sdr1["HairEngineerRawPrice"].ToString();
                                hairEngineerDescription = sdr1["HairEngineerDescription"].ToString();

                                //string[] photoID = sdr1["HairEngineerPhotoIDs"].ToString().Split(",".ToCharArray());

                                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                                {
                                    string commString = "select top 1 * from enginpics where ownerid=" + hairEngineerID.ToString();
                                    using (SqlCommand comm = new SqlCommand())
                                    {
                                        comm.CommandText = commString;
                                        comm.Connection = conn;
                                        conn.Open();

                                        using (SqlDataReader sdr = comm.ExecuteReader())
                                        {
                                            if (sdr.Read())
                                            {
                                                hairEngineerPic = sdr["picsmallurl"].ToString();
                                            }
                                        }
                                    }
                                }

                                if (hairEngineerPic == string.Empty)
                                {
                                    hairEngineerPic = "Theme/Images/sg-meifa_ls02.gif";
                                }

                                if (num % 5 == 0 && num >1)
                                {
                                    sb.Append("</tr>");
                                }
                                
                                if (num % 5 == 0)
                                {
                                    sb.Append("<tr>");
                                }

                                sb.Append("<td width=\"20%\" align=\"center\"><div class=\"pic-2\"><a href=\"HairdresserLastPage.aspx?ID=" + hairEngineerID + "\" target=\"_blank\"><img src=\"" + hairEngineerPic + "\" alt=\"" + hairEngineerDescription + "\" /></a><br /><a href=\"HairdresserLastPage.aspx?ID=" + hairEngineerID + "\" target=\"_blank\">" + hairEngineerName + "&nbsp;&nbsp;" + hairEngineerPosition + "<br />剪发价格&nbsp;&nbsp;&nbsp;&nbsp;" + hairEngineerRawPrice + "</a></div></td>");

                                num++;
                                jinum++;
                                
                            }
                        }
                    }
                }
                if (jinum < 5)
                {
                    for (int i = jinum; i < 5; i++)
                    {
                        sb.Append("<td width=\"20%\" align=\"center\"></td>");
                    }
                }
                if (num % 5 != 0 && num>0)
                {
                    sb.Append("</tr>");
                }
                if (num == 0)
                {
                    this.lblEngineerList.Text = "&nbsp;&nbsp;&nbsp;&nbsp;当前美发厅没有美发师";
                }
                else
                {
                    this.lblEngineerList.Text = sb.ToString();
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