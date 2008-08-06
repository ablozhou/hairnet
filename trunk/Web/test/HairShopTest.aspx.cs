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
using System.Collections.Generic;

namespace Web.test
{
    public partial class HairShopTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnTest1_OnClick(object sender, EventArgs e)
        {
            HairEngineerRecommand he = ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerRecommandByHairEngineerRecommandID(1);
            Response.Write(he.HairShopID.ToString());
        }
        protected void btnTest2_OnClick(object sender, EventArgs e)
        {
            HairShopRecommand hr = new HairShopRecommand();
            hr.HairShopRecommandEx = "oo";
            hr.HairShopRecommandID = 1;


            if (ProviderFactory.GetHairShopDataProviderInstance().HairShopRecommandCreateDeleteUpdate(hr, UserAction.Update))
            {
                Response.Write("success");
            }
            else
            {
                Response.Write("fail");
            }
        }
        protected void btnTest3_OnClick(object sender, EventArgs e)
        {
            HairShopRecommand hr = new HairShopRecommand();
            hr.HairShopRecommandEx = "haha";
            hr.HairShopRecommandID = 1;


            if (ProviderFactory.GetHairShopDataProviderInstance().HairShopRecommandCreateDeleteUpdate(hr, UserAction.Delete))
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
