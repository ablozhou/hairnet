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

            this.hairShopEntryControl.HairShopID = 8;
            this.hairShopEntryDescription.HairShopID = 8;
            this.hairShopEngineerList.HairShopID = 8;
            this.hairShopWorkList.HairShopID = 8;
        }
        protected void btn_OnClick(object sender, EventArgs e)
        {
 
        }
    }
}
