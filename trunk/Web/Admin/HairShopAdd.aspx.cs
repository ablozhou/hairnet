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
using System.Collections.Generic;
using HairNet.Entry;
using HairNet.Business;
using HairNet.Utilities;

namespace Web.Admin
{
    public partial class HairShopAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindcity();
                this.bindmapzone();
                this.bindhotzone();
                this.bindtype();
                this.bindworkranges();
            }
        }
        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            HairShop hs = new HairShop();
            hs.HairShopName = txtHairShopName.Text.Trim();
            hs.HairShopShortName = txtHairShopShortName.Text.Trim();
            hs.TypeID = int.Parse(ddlTypeTable.SelectedValue);
            hs.HairShopWebSite = txtHairShopWebSite.Text.Trim();
            hs.HairShopEmail = txtHairShopEmail.Text.Trim();
            hs.HairShopDiscount = txtHairShopDiscount.Text.Trim();
            //获取上传图片后的路径
            UpLoadClass upload = new UpLoadClass();
            hs.HairShopLogo = upload.UploadImageFile(fileLogo, "/uploadfiles/logo/");

            hs.HairShopCreateTime = txtHairShopCreateTime.Text.Trim();
            hs.HairShopCityID = int.Parse(ddlCity.SelectedValue);
            hs.HairShopMapZoneID = int.Parse(ddlMapZone.SelectedValue);
            hs.HairShopHotZoneID = int.Parse(ddlHotZone.SelectedValue);

            hs.HairShopAddress = txtHairShopAddress.Text.Trim();
            hs.HairShopPhoneNum = txtHairShopPhoneNum.Text.Trim();
            hs.HairShopOpenTime = txtHairShopOpenTime.Text.Trim();


            hs.HairShopTagIDs = InfoAdmin.GetHairShopTagIDs(txtHairShopTag.Text.Trim());


            //List<string> IDs = new List<string>();
            //int chkI = chkListWorkRange.Items.Count;
            //for (int i = 0; i < chkI; i++)
            //{
            //    if (chkListWorkRange.Items[i].Selected)
            //    {
            //        IDs.Add(chkListWorkRange.Items[i].Value);
            //    }
            //}
            //IDs.Sort();
            //hs.WorkRangeIDs = string.Join(",", IDs.ToArray());


            //hs.IsBest = chkIsBest.Checked;
            hs.IsJoin = chkIsJoin.Checked;
            hs.IsPostMachine = chkIsPostStation.Checked;
            hs.IsPostStation = chkIsPostMachine.Checked;
            hs.HairShopDescription = txtDescription.Text.Trim();

            //Session["HairShopInfo"] = hs;

            hs.HairCutDiscount = Decimal.Parse(tbHairCutDiscount.Text.Trim());
            hs.HairCutPirce = Decimal.Parse(tbHairCutPrice.Text.Trim());
            hs.HairMarcelDiscount = Decimal.Parse(tbMarclDiscount.Text.Trim());
            hs.HairMarcelPrice = Decimal.Parse(tbMarcelPrice.Text.Trim());
            hs.HairDyeDiscount = Decimal.Parse(tbHairDyeDiscount.Text.Trim());
            hs.HairDyePrice = Decimal.Parse(tbHairDyePrice.Text.Trim());

            hs.HairShapePrice = Decimal.Parse(tbShapePrice.Text.Trim());
            hs.HairShapeDiscount = Decimal.Parse(tbShapeDiscount.Text.Trim());
            hs.HairConservationPrice = Decimal.Parse(tbConservationPrice.Text.Trim());
            hs.HairConservationDiscount = Decimal.Parse(tbConservationDiscount.Text.Trim());

            hs.LocationMapURL = tbLocation.Text.Trim();
            hs.Square = TextBox4.Text.Trim();

            hs.IsServeHairCut = chkCut.Checked;
            hs.IsServeMarce = chkMarcel.Checked;
            hs.IsServeDye = chkCut.Checked;

            //InfoAdmin.AddHairShop(hs);
            InfoAdmin.AddHairShopInfo(hs);

            this.Response.Redirect("HairEngineerAdd.aspx");
        }

        private void bindtype()
        {
            ddlTypeTable.DataSource = InfoAdmin.GetTypeTable();
            ddlTypeTable.DataTextField = "Name";
            ddlTypeTable.DataValueField = "ID";
            ddlTypeTable.DataBind();
        }

        private void bindworkranges()
        {
            chkListWorkRange.DataSource = InfoAdmin.GetWorkRange();
            chkListWorkRange.DataTextField = "Name";
            chkListWorkRange.DataValueField = "ID";
            chkListWorkRange.DataBind();
        }

        private void bindcity()
        {
            ddlCity.DataSource = InfoAdmin.GetCityItems();
            ddlCity.DataTextField = "Name";
            ddlCity.DataValueField = "ID";
            ddlCity.DataBind();
        }

        private void bindmapzone()
        {
            if (ddlCity.Items.Count != 0)
            {
                ddlMapZone.DataSource = InfoAdmin.GetMapZoneByCityID(int.Parse(ddlCity.SelectedValue));
                ddlMapZone.DataTextField = "Name";
                ddlMapZone.DataValueField = "ID";
                ddlMapZone.DataBind();
            }
        }

        private void bindhotzone()
        {
            if (ddlMapZone.Items.Count != 0)
            {
                ddlHotZone.DataSource = InfoAdmin.GetHotZoneByMapZoneID(int.Parse(ddlMapZone.SelectedValue));
                ddlHotZone.DataTextField = "Name";
                ddlHotZone.DataValueField = "ID";
                ddlHotZone.DataBind();
            }
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bindmapzone();
            this.bindhotzone();
        }

        protected void ddlMapZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bindhotzone();
        }

        protected void btnAddCoupon_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCoupon.aspx");
        }
    }
}
