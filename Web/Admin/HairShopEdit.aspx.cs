using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using HairNet.Provider;
using HairNet.Entry;
using HairNet.Business;
using HairNet.Utilities;
using System.Collections.Generic;

namespace Web.Admin
{
    public partial class HairShopEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindtype();
                this.bindworkranges();
                this.bindBaseInfo();
            }
        }

        private void bindBaseInfo()
        {
            string id = Request["id"];
            HairShop hs = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(int.Parse(id));
            txtDescription.Text = hs.HairShopDescription;
            txtHairShopAddress.Text = hs.HairShopAddress;
            txtHairShopCreateTime.Text = hs.HairShopCreateTime.ToString();
            txtHairShopDiscount.Text = hs.HairShopDiscount;
            txtHairShopEmail.Text = hs.HairShopEmail;
            txtHairShopName.Text = hs.HairShopName;
            txtHairShopOpenTime.Text = hs.HairShopOpenTime.ToString();
            txtHairShopPhoneNum.Text = hs.HairShopPhoneNum;
            txtHairShopShortName.Text = hs.HairShopShortName;
            txtHairShopWebSite.Text = hs.HairShopWebSite;
            txtHairShopTag.Text = InfoAdmin.GetHairShopTagNames(hs.HairShopTagIDs);

            imgLogo.ImageUrl = hs.HairShopLogo;

            ddlTypeTable.SelectedValue = hs.TypeID.ToString();

            this.bindcity();
            ddlCity.SelectedValue = hs.HairShopCityID.ToString();
            this.bindmapzone();
            ddlMapZone.SelectedValue = hs.HairShopMapZoneID.ToString();
            this.bindhotzone();
            ddlHotZone.SelectedValue = hs.HairShopHotZoneID.ToString();

            string[] works = hs.WorkRangeIDs.Split(',');
            foreach (string workid in works)
            {
                for (int i = 0; i < chkListWorkRange.Items.Count; i++)
                {
                    if (chkListWorkRange.Items[i].Value == workid)
                    {
                        chkListWorkRange.Items[i].Selected = true;
                        break;
                    }
                }
            }

            chkIsBest.Checked = hs.IsBest;
            chkIsJoin.Checked = hs.IsJoin;
            chkIsPostMachine.Checked = hs.IsPostMachine;
            chkIsPostStation.Checked = hs.IsPostStation;
            ViewState["HairShop"] = hs;
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

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            HairShop hs = (HairShop)ViewState["HairShop"];
            hs.HairShopName = txtHairShopName.Text.Trim();
            hs.HairShopShortName = txtHairShopShortName.Text.Trim();
            hs.TypeID = int.Parse(ddlTypeTable.SelectedValue);
            hs.HairShopWebSite = txtHairShopWebSite.Text.Trim();
            hs.HairShopEmail = txtHairShopEmail.Text.Trim();
            hs.HairShopDiscount = txtHairShopDiscount.Text.Trim();
            //获取上传图片后的路径
            if (fileLogo.Value!="")
            {
                UpLoadClass upload = new UpLoadClass();
                hs.HairShopLogo = upload.UpLoadImg(fileLogo, "/uploadfiles/logo/");
                upload = null;
            }
            else
            {
                hs.HairShopLogo = imgLogo.ImageUrl;
            }

            hs.HairShopCreateTime = txtHairShopCreateTime.Text.Trim();
            hs.HairShopCityID = int.Parse(ddlCity.SelectedValue);
            hs.HairShopMapZoneID = int.Parse(ddlMapZone.SelectedValue);
            hs.HairShopHotZoneID = int.Parse(ddlHotZone.SelectedValue);
            hs.HairShopAddress = txtHairShopAddress.Text.Trim();
            hs.HairShopPhoneNum = txtHairShopPhoneNum.Text.Trim();
            hs.HairShopOpenTime = txtHairShopOpenTime.Text.Trim();


            hs.HairShopTagIDs = InfoAdmin.GetHairShopTagIDs(txtHairShopTag.Text.Trim());


            List<string> IDs = new List<string>();
            int chkI = chkListWorkRange.Items.Count;
            for (int i = 0; i < chkI; i++)
            {
                if (chkListWorkRange.Items[i].Selected)
                {
                    IDs.Add(chkListWorkRange.Items[i].Value);
                }
            }
            IDs.Sort();
            hs.WorkRangeIDs = string.Join(",", IDs.ToArray());


            hs.IsBest = chkIsBest.Checked;
            hs.IsJoin = chkIsJoin.Checked;
            hs.IsPostMachine = chkIsPostStation.Checked;
            hs.IsPostStation = chkIsPostMachine.Checked;
            hs.HairShopDescription = txtDescription.Text.Trim();

            Session["HairShopInfo"] = hs;
            this.Response.Redirect("HairShopEdit2.aspx");
        }
    }
}
