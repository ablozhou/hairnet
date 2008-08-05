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
using HairNet.Provider;
using HairNet.Entry;
using HairNet.Enumerations;

namespace Web.test
{
    public partial class HairShopTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnTest_OnClick(object sender, EventArgs e)
        {
            HairShop hairshop = new HairShop();
            hairshop.HairShopName = "testHairShop";
            hairshop.IsBest = true;
            hairshop.IsJoin = false;

            if (ProviderFactory.GetHairShopDataProviderInstance().HairShopDataPrividerCreateDeleteUpdate(hairshop, UserAction.Create))
            {
                Response.Write("success");
            }
            else
            {
                Response.Write("fail");
            }
            
            
        }
    }
}
