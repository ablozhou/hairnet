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

namespace Web.UserControls
{
    public partial class HairShopDescription : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HairShop hairShop = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(this.HairShopID);

            this.lblHairShopName.Text = hairShop.HairShopName;
            this.lblHairShopDescription.Text = hairShop.HairShopDescription;
            this.lblMemberInfo.Text = hairShop.MemberInfo.ToString();

            string[] hairShopPhotoID = hairShop.OutLogs.Split(",".ToCharArray());
            if (hairShopPhotoID.Length ==1)
            {

                this.lbllHairShopPic.Text = "<a href=\"#\"><img width=98 height=98 src=\"Theme/Images/sg-meifa_ls02.gif\" /></a>";
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select top 1 * from shoppics where id=" + hairShopPhotoID[1];
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                this.lbllHairShopPic.Text = "<a href=\"#\"><img width=98 height=98 src=\""+sdr["picsmallurl"].ToString()+"\" /></a>";
                            }
                        }
                    }
                }
                
            }

            if (hairShop.HairShopEngineerNum == 0)
            {
                this.lblHairEngineerDescription.Text = "当前此美发厅没有领军人物";
            }
            else
            {
                string hairEngineerPhotoIDs = string.Empty;
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
                                hairEngineerPhotoIDs = sdr["HairEngineerPhotoIDs"].ToString();
                            }
                        }
                    }
                }
                string[] photoID = hairEngineerPhotoIDs.Split(",".ToCharArray());
                if (photoID.Length == 1)
                {
                    this.lblHairEngineerPic.Text = "<a href=\"#\"><img width=98 height=98 src=\"Theme/Images/sg-meifa_ls02.gif\" /></a>";
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "select top 1 * from enginpics where id=" + photoID[1];
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = commString;
                            comm.Connection = conn;
                            conn.Open();

                            using (SqlDataReader sdr = comm.ExecuteReader())
                            {
                                if (sdr.Read())
                                {
                                    this.lblHairEngineerPic.Text = "<a href=\"#\"><img width=98 height=98 src=\"" + sdr["picsmallurl"].ToString() + "\" /></a>";
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