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
using HairNet.Utilities;
using System.Data.SqlClient;

namespace Web.UserControls
{
    public partial class HairShopEntryControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                HairShop hairShop = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(this.HairShopID);

                this.Page.Header.Title = "美发频道 - " + hairShop.HairShopName;
                this.lblHairShopName.Text = hairShop.HairShopName;
                this.lblHairShopAddress.Text = hairShop.HairShopAddress + "【<span class=\"red12-c\">地图</span>】";
                this.lblHairShopDiscount.Text = hairShop.HairShopDiscount + "折";
                this.lblHairShopDiscount2.Text = hairShop.HairShopDiscount + "折";
                this.lblHairShopOpenTime.Text = hairShop.HairShopOpenTime;

                this.lblHairShopPhoneNum2.Text = hairShop.HairShopPhoneNum;
                this.lblHairShopPhoneNum.Text = hairShop.HairShopPhoneNum;

                this.lblHairShopType.Text = hairShop.TypeName;

                StringBuilder picSB = new StringBuilder();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from shoppics where hairshopID=" + this.HairShopID;
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                picSB.Append("<a href=\"#\"><img src=\"" + sdr["picsmallurl"].ToString() + "\" /></a>");
                            }
                        }
                    }
                }
                this.lblHairShopPicList.Text = picSB.ToString();

                if (hairShop.IsPostMachine)
                {
                    this.lblIsPostMachine.Text = "有";
                }
                else
                {
                    this.lblIsPostMachine.Text = "无";
                }
                if (hairShop.IsPostStation)
                {
                    this.lblIsPostStation.Text = "有";
                }
                else
                {
                    this.lblIsPostStation.Text = "无";
                }
                this.lblLocationMapUrl.Text = hairShop.LocationMapURL.ToString();
                this.lblSquare.Text = hairShop.Square;

                string[] productIDs = hairShop.ProductIDs.Split(",".ToCharArray());
                string productString = "";
                for (int k = 0; k < productIDs.Length; k++)
                {
                    Product product = ProviderFactory.GetProductDataProviderInstance().GetProductByProductID(int.Parse(productIDs[k]));
                    if (k == 0)
                    {
                        productString += product.ProductName;
                    }
                    else
                    {
                        productString += "&nbsp;&nbsp;" + product.ProductName;
                    }
                }
                this.lblProduct.Text = productString;

                if (hairShop.CouponNum == 0)
                {
                    this.p1.Visible = false;
                    this.Panel1.Visible = false;
                    this.p2.Visible = true;
                    this.Panel2.Visible = true;
                }
                else
                {
                    this.p1.Visible = true;
                    this.Panel1.Visible = true;
                    this.p2.Visible = false;
                    this.Panel2.Visible = false;

                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "select top 1 * from Coupon where hairshopID=" + this.HairShopID;
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = commString;
                            comm.Connection = conn;
                            conn.Open();

                            using (SqlDataReader sdr = comm.ExecuteReader())
                            {
                                if (sdr.Read())
                                {
                                    this.lblCouponPic.Text = "<img src=\"" + sdr["ImageSmallUrl"].ToString() + "\" width=\"122\" height=\"73\" />";

                                    this.lblPrintNum.Text = sdr["HitNum"].ToString() + "&nbsp;次";
                                    this.lblPrintCoupon.Text = "<a href=\"#\">打印此优惠券</a>";

                                    this.lblCouponPic2.Text = "<img src=\"" + sdr["ImageSmallUrl"].ToString() + "\" width=\"122\" height=\"73\" />";

                                    this.lblPrintNum2.Text = sdr["HitNum"].ToString() + "&nbsp;次";
                                    this.lblPrintCoupon2.Text = "<a href=\"#\">打印此优惠券</a>";
                                }
                            }
                        }
                    }
                }

                this.lblComment.Text = "<a href=\"#\" target=\"_blank\">[评 论]</a>";
                this.lblStore.Text = "<a onClick='window.external.AddFavorite(location.href,document.title);' href='HairShopContent.aspx?id=" + this.HairShopID.ToString() + "' >[收 藏]</a>";
                this.lblComment2.Text = "<a href=\"#\" target=\"_blank\">[评 论]</a>";
                this.lblStore2.Text = "<a onClick='window.external.AddFavorite(location.href,document.title);' href='HairShopContent.aspx?id=" + this.HairShopID.ToString() + "' >[收 藏]</a>";
            }
        }
        private int _hairShopID = 0;
        public int HairShopID
        {
            set { this._hairShopID = value; }
            get { return this._hairShopID; }
        }
        public void imgBtnCouponSubmit2_OnClick(object sender, EventArgs e)
        {
            string email = this.txtCouponEmail2.Value.ToString().Trim();

            if (email == string.Empty)
            {
                StringHelper.AlertInfo("邮件地址不能为空", this.Page);
                this.Response.Redirect(this.Request.Url.ToString());
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "insert into subsemail(email,shopid,classid,descr) values('" + email + "'," + this.HairShopID.ToString() + ",1,'订阅')";
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
            StringHelper.AlertInfo("订购成功", this.Page);
        }
        public void imgBtnCouponSubmit_OnClick(object sender, EventArgs e)
        {
            string email = this.txtCouponEmail.Value.ToString().Trim();

            if (email == string.Empty)
            {
                StringHelper.AlertInfo("邮件地址不能为空", this.Page);
                this.Response.Redirect(this.Request.Url.ToString());
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "insert into subsemail(email,shopid,classid,descr) values('" + email + "'," + this.HairShopID.ToString() + ",1,'订阅')";
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
            StringHelper.AlertInfo("订购成功", this.Page);
        }
    }
}