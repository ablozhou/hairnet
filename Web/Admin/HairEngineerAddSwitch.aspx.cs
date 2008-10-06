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

namespace Web.Admin55
{
    public partial class HairEngineerAddSwitch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnHairEngineerContinue_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("HairEngineerAdd.aspx");
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("HairEngineerAdmin.aspx");
        }
    }
}
