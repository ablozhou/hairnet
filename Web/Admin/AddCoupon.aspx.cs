﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


using HairNet.Business;
using HairNet.Entry;
using HairNet.Utilities;
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class AddCoupon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindControlData();

            if (!String.IsNullOrEmpty(Request.Params["id"]))
            {
                ddlShopList.SelectedIndex = -1;

                foreach (ListItem Item in ddlShopList.Items)
                {
                    if (Item.Value == Request.Params["id"])
                    {
                        Item.Selected = true;
                        break;
                    }
                }
            }
        }
        public void btnSubmitPicSmall_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();

            string pName = upload.UpLoadImg(picSmall, "/uploadfiles/pictures/");
            if (pName != string.Empty)
            {
                this.imgSmall.Visible = true;
                this.imgSmall.ImageUrl = pName;
            }
        }
        public void btnSubmitPic_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();

            string pName = upload.UpLoadImg(pic, "/uploadfiles/pictures/");
            if (pName != string.Empty)
            {
                this.img.Visible = true;
                this.img.ImageUrl = pName;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddCoupon_Click(object sender, EventArgs e)
        {
            try
            {
                Coupon CouponEntity = new Coupon(0, tbCouponName.Text.Trim(), Int32.Parse(ddlShopList.SelectedItem.Value), tbDiscount.Text.Trim(),
                    tbExpired.Text.Trim(), tbPhone.Text.Trim(), tbTag.Text.Trim(), tbDesc.Text.Trim(),this.img.ImageUrl.ToString(),0,this.imgSmall.ImageUrl.ToString());

                InfoAdmin.AddCoupon(CouponEntity);

                string couponID = "";

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "update HairShop set couponNum = couponNum +1 where HairShopID=" + this.ddlShopList.SelectedItem.Value;
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

                MessageObject.Show("数据添加成功!");
                ResetControlState();
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                throw new ArgumentException("位置错误", sqlEx.Message);
            }
            this.Response.Redirect("CouponAddSwitch.aspx?id="+this.Request.QueryString["id"].ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        protected void BindControlData()
        {
            foreach (HairShop Item in InfoAdmin.GetHairShops(0, HairNet.Enumerations.OrderKey.ID))
            {
                ddlShopList.Items.Add(new ListItem(Item.HairShopName, Item.HairShopID.ToString()));
            }
        }

        protected void ResetControlState()
        {
            tbCouponName.Text = String.Empty;
            ddlShopList.SelectedIndex = -1;
            tbDiscount.Text = String.Empty;
            tbExpired.Text = String.Empty;
            tbPhone.Text = String.Empty;
            tbTag.Text = String.Empty;
            tbDesc.Text = String.Empty;
        }

        protected void btnViewAll_Click(object sender, EventArgs e)
        {
            this.tbCouponName.Text = "Redirect";
            Response.Redirect("CouponManagement.aspx");
        }
    }
}
