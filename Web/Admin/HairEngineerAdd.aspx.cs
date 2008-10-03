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
using HairNet.Business;
using HairNet.Enumerations;
using HairNet.Entry;
using HairNet.Utilities;

namespace Web.Admin
{
    public partial class HairEngineerAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindClass();
                this.bindShop();
            }

            if (!String.IsNullOrEmpty(Request.Params["id"]))
            {
                ddlHairShop.SelectedIndex = -1;

                foreach (ListItem item in ddlHairShop.Items)
                {
                    if (item.Value == Request.Params["id"])
                    {
                        item.Selected = true;
                        break;
                    }
                }

                ddlHairShop.Enabled = false;
            }
        }

        private void bindClass()
        {
            ddlHairShopClass.DataSource = InfoAdmin.GetHairEngineerClasses();
            ddlHairShopClass.DataTextField = "Name";
            ddlHairShopClass.DataValueField = "ID";
            ddlHairShopClass.DataBind();
        }

        private void bindShop()
        {
            ddlHairShop.DataSource = InfoAdmin.GetHairShops(0, OrderKey.ID);
            ddlHairShop.DataTextField = "HairShopName";
            ddlHairShop.DataValueField = "HairShopID";
            ddlHairShop.DataBind();
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            HairEngineer he = new HairEngineer();
            he.HairEngineerName = txtHairEngineerName.Text.Trim();
            he.HairEngineerAge = txtHairEngineerAge.Text.Trim();
            he.HairEngineerSex = int.Parse(rBtnListHairEngineerSex.SelectedValue);
            he.HairEngineerPrice = txtHairEngineerPrice.Text.Trim();
            he.HairEngineerRawPrice = txtHairEngineerRawPrice.Text.Trim();
            he.HairEngineerYear = txtHairEngineerYear.Text.Trim();
            he.HairEngineerSkill = txtHairEngineerSkill.Text.Trim();
            he.HairEngineerDescription = txtHairEngineerDescription.Text.Trim();
            he.HairEngineerConstellation = tbConstellation.Text.Trim();
            he.HairEngineerClassID = int.Parse(ddlHairShopClass.SelectedValue);
            he.HairShopID = int.Parse(ddlHairShop.SelectedValue);
            
            UpLoadClass upload = new UpLoadClass();
            he.HairEngineerPhoto = upload.UpLoadImg(fileLogo, "/uploadfiles/pictures/");

            he.HairEngineerTagIDs = InfoAdmin.GetHairEngineerTagIDs(txtHairEngineerTag.Text.Trim());
            
            Session["HairEngineerInfo"] = he;
            InfoAdmin.AddHairEngineer(he);
            ResetControlState();

            this.Response.Redirect("EngineerOpusInfo.aspx");
        }

        protected void rBtnListHairEngineerSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ResetControlState()
        {
            txtHairEngineerName.Text = String.Empty;
            txtHairEngineerAge.Text = String.Empty;
            rBtnListHairEngineerSex.SelectedIndex = 0;
            txtHairEngineerPrice.Text = String.Empty;
            txtHairEngineerRawPrice.Text = String.Empty;
            txtHairEngineerYear.Text = String.Empty;
            txtHairEngineerSkill.Text = String.Empty;
            txtHairEngineerDescription.Text = String.Empty;
            tbConstellation.Text = String.Empty;
            ddlHairShopClass.SelectedIndex = 0;
            ddlHairShop.SelectedIndex = 0;
            txtHairEngineerTag.Text = String.Empty;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("EngineerOpusInfo.aspx");
        }
    }
}
