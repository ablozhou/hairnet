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
using HairNet.Entry;
using HairNet.Business;
using HairNet.Utilities;
using HairNet.Enumerations;

namespace Web.Admin
{
    public partial class HairShopRecommandUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                int hairShopRecommandID = int.Parse(this.Request.QueryString["hairShopRecommandID"].ToString());
                HairShopRecommand hsr = InfoAdmin.GetHairShopRecommand(hairShopRecommandID);

                this.content.Value = hsr.HairShopRecommandInfo;
            }
        }
        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            int hairShopID = int.Parse(this.Request.QueryString["hairShopID"].ToString());
            int hairShopRecommandID = int.Parse(this.Request.QueryString["hairShopRecommandID"].ToString());

            string hairShopRecommandInfo = this.content.Value;
            string hairShopRecommandEx = this.txtRecommandEx.Text.Trim();
            if (InfoAdmin.RecommandHairShop(hairShopID, hairShopRecommandID, hairShopRecommandInfo, hairShopRecommandEx, UserAction.Update))
            {
                StringHelper.AlertInfo("更新成功", this.Page);
                this.Response.Redirect("HairShopRecommandAdmin.aspx");
            }
            else
            {
                StringHelper.AlertInfo("更新失败", this.Page);
            }
        }
    }
}
