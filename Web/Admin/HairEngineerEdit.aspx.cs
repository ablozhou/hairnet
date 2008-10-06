using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using HairNet.Entry;
using HairNet.Business;
using HairNet.Utilities;
using HairNet.Enumerations;

namespace Web.Admin
{
    public partial class HairEngineerEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindClass();
                this.bindShop();
                this.bindBaseInfo();
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

        void bindBaseInfo()
        {
            int hairEngineerID = int.Parse(Request["id"]);
            HairEngineer he = InfoAdmin.GetHairEngineerByHairEngineerID(hairEngineerID);
            txtHairEngineerAge.Text = he.HairEngineerAge;
            txtHairEngineerDescription.Text = he.HairEngineerDescription;
            txtHairEngineerName.Text = he.HairEngineerName;
            txtHairEngineerPrice.Text = he.HairEngineerPrice;
            txtHairEngineerRawPrice.Text = he.HairEngineerRawPrice;
            txtHairEngineerSkill.Text = he.HairEngineerSkill;
            txtHairEngineerYear.Text = he.HairEngineerYear;

            txtHairEngineerTag.Text = InfoAdmin.GetHairEngineerTagNames(he.HairEngineerTagIDs);

            ddlHairShop.SelectedValue = he.HairShopID.ToString();
            ddlHairShopClass.SelectedValue = he.HairEngineerClassID.ToString();
            rBtnListHairEngineerSex.SelectedValue = he.HairEngineerSex.ToString();

            imgPhoto.ImageUrl = he.HairEngineerPhoto;

            ViewState["HairEngineerInfo"] = he;
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            HairEngineer he = (HairEngineer)ViewState["HairEngineerInfo"];
            he.HairEngineerName = txtHairEngineerName.Text.Trim();
            he.HairEngineerAge = txtHairEngineerAge.Text.Trim();
            he.HairEngineerSex = int.Parse(rBtnListHairEngineerSex.SelectedValue);
            he.HairEngineerPrice = txtHairEngineerPrice.Text.Trim();
            he.HairEngineerRawPrice = txtHairEngineerRawPrice.Text.Trim();
            he.HairEngineerYear = txtHairEngineerYear.Text.Trim();
            he.HairEngineerSkill = txtHairEngineerSkill.Text.Trim();
            he.HairEngineerDescription = txtHairEngineerDescription.Text.Trim();

            he.HairEngineerClassID = int.Parse(ddlHairShopClass.SelectedValue);
            he.HairShopID = int.Parse(ddlHairShop.SelectedValue);

            if (fileLogo.Value != "")
            {
                UpLoadClass upload = new UpLoadClass();
                he.HairEngineerPhoto = upload.UpLoadImg(fileLogo, "/uploadfiles/pictures/");
                upload = null;
            }
            else
            {
                he.HairEngineerPhoto = imgPhoto.ImageUrl;
            }


            he.HairEngineerTagIDs = InfoAdmin.GetHairEngineerTagIDs(txtHairEngineerTag.Text.Trim());

            Session["HairEngineerInfo"] = he;
            this.Response.Redirect("HairEngineerEdit2.aspx");
        }
    }
}
