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
using HairNet.Utilities;

namespace Web
{
    public partial class HairShopContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringHelper.AddStyleSheet(this.Page, "Theme/Style/meifating.css");

            int hairShopID = int.Parse(this.Request.QueryString["id"].ToString());
            //int hairShopID = 8;
            this.hairShopEntryControl.HairShopID = hairShopID;
            this.hairShopEntryDescription.HairShopID = hairShopID;
            this.hairShopEngineerList.HairShopID = hairShopID;
            this.hairShopWorkList.HairShopID = hairShopID;
            this.sameHairShopList.HairShopID = hairShopID;
        }
    }
}
