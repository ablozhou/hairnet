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
using HairNet.Business;

namespace Web
{
    public partial class CouponList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringHelper.AddStyleSheet(this.Page, "Theme/Style/youhuiquan.css");


            string buziZone = Request.QueryString["buzizone"].ToString();
            string shopName = Request.QueryString["shopname"].ToString();

            if (buziZone != string.Empty)
            {
            }
            else if (shopName != string.Empty)
            {
            }
            else
            {
                InfoAdmin.GetCouponList();
            }
            
        }


        protected void btnBusiZoneSearch_Click(object sender, EventArgs e)
        {

        }

        protected void btnKeySearch_Click(object sender, EventArgs e)
        {

        }
    }
}
