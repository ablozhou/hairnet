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
using System.Data.SqlClient;
using System.Text;

namespace Web.UserControls
{
    public partial class HairShopDescription : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HairShop hairShop = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(this.HairShopID);

            this.lblHairShopName.Text = hairShop.HairShopName;
            this.lblHairShopDescription.Text = hairShop.HairShopDescription;


            //绑定美发厅加盟信息
            StringBuilder memberSB = new StringBuilder();
            int memberNum = 0;
            if (hairShop.MemberInfo != string.Empty)
            {
                using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString1 = "select * from hairshop where MemberInfo like '%" + hairShop.MemberInfo.ToString() + "%'";
                    using (SqlCommand comm1 = new SqlCommand())
                    {
                        comm1.CommandText = commString1;
                        comm1.Connection = conn1;
                        conn1.Open();

                        using (SqlDataReader sdr1 = comm1.ExecuteReader())
                        {
                            while (sdr1.Read())
                            {
                                memberNum++;
                                if (memberNum == 1)
                                {
                                    memberSB.Append("&nbsp;&nbsp;&nbsp;&nbsp;" + memberNum.ToString() + "、&nbsp;&nbsp;<a target='_blank' href='HairShopContent.aspx?id=" + sdr1["HairShopID"].ToString() + "'>" + sdr1["HairShopShortName"].ToString() + "&nbsp;&nbsp;&nbsp;—&nbsp;&nbsp;&nbsp;" + sdr1["HairShopAddress"].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + sdr1["HairShopPhoneNum"].ToString() + "</a>");
                                }
                                else
                                {
                                    memberSB.Append("<br/>&nbsp;&nbsp;&nbsp;&nbsp;" + memberNum.ToString() + "、&nbsp;&nbsp;<a target='_blank' href='HairShopContent.aspx?id=" + sdr1["HairShopID"].ToString() + "'>" + sdr1["HairShopShortName"].ToString() + "&nbsp;&nbsp;&nbsp;—&nbsp;&nbsp;&nbsp;" + sdr1["HairShopAddress"].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + sdr1["HairShopPhoneNum"].ToString() + "</a>");
                                }
                            }
                        }
                    }
                }
            }

            if (memberSB.ToString() == string.Empty)
            {
                this.lblMemberInfo.Text = "当前没有连锁店信息";
            }
            else
            {
                this.lblMemberInfo.Text = memberSB.ToString();
            }
            
                
                
            string picUrl = string.Empty;
            string picSmallUrl = string.Empty;


            using (SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString1 = "select top 1 * from shoppics where hairshopid=" + this.HairShopID.ToString();
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
            }

            this.lbllHairShopPic.Text = "<a href=\"#\"><img width=98 height=98 src=\"" + picSmallUrl + "\" /></a>";

            this.lblMapText1.Text = "<a href='MapInfo.aspx?id="+hairShop.HairShopID.ToString()+"' target='_blank'><img src='Theme/images/fair-mft25.gif' /></a>";
            this.lblMapText2.Text = "<a href='MapInfo.aspx?id=" + hairShop.HairShopID.ToString() + "' target='_blank'><img src='Theme/images/fair-mft25.gif' /></a>";
            this.lblMapText3.Text = "<a href='MapInfo.aspx?id=" + hairShop.HairShopID.ToString() + "' target='_blank'><img src='Theme/images/fair-mft25.gif' /></a>";

            if (hairShop.HairShopEngineerNum == 0)
            {
                this.lblHairEngineerDescription.Text = "当前此美发厅没有领军人物";
            }
            else
            {
                string hairEngineerPhotoIDs = string.Empty;
                string hairEngineerID = "0";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select top 1 * from HairEngineer where IsImportant=1 and hairshopID=" + this.HairShopID;
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {   
                                this.lblHairEngineerDescription.Text = sdr["HairEngineerDescription"].ToString();
                                
                                hairEngineerID = sdr["HairEngineerID"].ToString();
                            }
                        }
                    }
                }
                if (hairEngineerID == string.Empty)
                {
                    this.lblHairEngineerPic.Text = "<img width=98 height=98 src=\"Theme/Images/sg-meifa_ls02.gif\" />";
                    this.lblHairEngineerDescription.Text = "&nbsp;&nbsp;当前美发厅没有领军美发师！";
                }
                else
                {
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
                                    this.lblHairEngineerPic.Text = "<a href=\"HairdresserLastPage.aspx?ID=" + hairEngineerID + "\"><img width=98 height=98 src=\"" + sdr["picsmallurl"].ToString() + "\" /></a>";

                                }
                            }
                        }
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