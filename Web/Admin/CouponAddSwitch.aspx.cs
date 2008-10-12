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

namespace Web.Admin
{
    public partial class CouponAddSwitch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnContinue_OnClick(object sender, EventArgs e)
        {
            this.Response.Redirect("AddCoupon.aspx?id="+this.Request.QueryString["id"].ToString());
        }
        protected void btnBack_OnClick(object sender, EventArgs e)
        {
            this.Response.Redirect("CouponManagement.aspx");
        }
    }
}
