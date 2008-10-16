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
using HairNet.Entry;
using HairNet.Provider;

namespace Web.UserControls
{
    public partial class HairShopVoteControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HairShop hairShop = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(this.HairShopID);

            double total = Convert.ToDouble(hairShop.HairShopGood + hairShop.HairShopBad + hairShop.HairShopNormal);

            int goodRate = 0;
            int badRate = 0;
            int normalRate = 0;

            if (total != 0)
            {
                goodRate = Convert.ToInt32(Convert.ToDouble(hairShop.HairShopGood) / total * 100);
                badRate = Convert.ToInt32(Convert.ToDouble(hairShop.HairShopBad) / total * 100);
                normalRate = 100 - goodRate - badRate;
            }

            this.lblBadNum.Text = badRate.ToString()+"%";
            this.lblGoodNum.Text = goodRate.ToString() + "%";
            this.lblNormalNum.Text = normalRate.ToString() + "%";

            this.lblBad.Text = "<table border=1 cellpadding='0' width='129' cellspacing='0'><tr><td width=" + 129/100 * badRate + " bgcolor='gray' height='11'></td><td bgcolor=white height='11'></td></table>";
            this.lblGood.Text = "<table border=1 cellpadding='0' width='129' cellspacing='0'><tr><td width=" + 129 / 100 * goodRate + " bgcolor='red' height='11'></td><td bgcolor=white height='11'></td></table>";
            this.lblNormal.Text = "<table border=1 cellpadding='0' width='129' cellspacing='0'><tr><td width=" + 129 / 100 * normalRate + " bgcolor='yellow' height='11'></td><td bgcolor=white height='11'></td></table>";

        }
        private int _hairShopID = 0;
        public int HairShopID
        {
            set { this._hairShopID = value; }
            get { return this._hairShopID; }
        }
        public void linkBtnGood_OnClick(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "update HairShop set HairShopGood = HairShopGood+1 where HairShopID="+this.HairShopID;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
        public void linkBtnNormal_OnClick(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "update HairShop set HairShopNormal = HairShopNormal+1 where HairShopID=" + this.HairShopID;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
        public void linkBtnBad_OnClick(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "update HairShop set HairShopBad = HairShopBad+1 where HairShopID=" + this.HairShopID;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
    }
}