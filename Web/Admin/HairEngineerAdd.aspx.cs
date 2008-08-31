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

            he.HairEngineerClassID = int.Parse(ddlHairShopClass.SelectedValue);
            he.HairShopID = int.Parse(ddlHairShop.SelectedValue);
            
            UpLoadClass upload = new UpLoadClass();
            he.HairEngineerPhoto = upload.UpLoadImg(fileLogo, "/uploadfiles/pictures/");
            upload = null;


            he.HairEngineerTagIDs = InfoAdmin.GetHairEngineerTagIDs(txtHairEngineerTag.Text.Trim());

            Session["HairEngineerInfo"] = he;
            this.Response.Redirect("HairEngineerAdd2.aspx");
        }
    }
}
