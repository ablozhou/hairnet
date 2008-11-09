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
            StringHelper.AddStyleSheet(this.Page, "css/youhuiquan.css");

            this.CouponDetailList1.PageSize = 6;

            int pageNum = 1;

            try
            {
                pageNum = int.Parse(this.Request.QueryString["pageNum"].ToString());
            }
            catch
            { }

            this.CouponDetailList1.CurrentPage = pageNum;

            string selectCondition = "";

            try
            {
                string tt = this.Request.QueryString["tt"].ToString();
                if (Session["selection"] == null || Session["selection"].ToString() == string.Empty)
                {

                }
                else
                {
                    selectCondition = Session["selection"].ToString();//this.Request.QueryString["sc"].ToString();
                }
            }
            catch
            { }

            this.CouponDetailList1.SelectCondition = selectCondition;
        }


        protected void btnBusiZoneSearch_Click(object sender, EventArgs e)
        {
            if (StringHelper.StringFilter(this.txtBuziZone.Text.Trim()))
            {
                Session["selection"] = Server.UrlEncode(" where hz.HotZoneName like '%" + this.txtBuziZone.Text.Trim() + "%'");
                this.Response.Redirect("CouponList.aspx?tt=1");
            }
        }

        protected void btnKeySearch_Click(object sender, EventArgs e)
        {
            if (StringHelper.StringFilter(this.txtHairShopName.Text.Trim()))
            {
                Session["selection"] = Server.UrlEncode(" where hs.HairShopName like '%" + this.txtHairShopName.Text.Trim() + "%'");
                this.Response.Redirect("CouponList.aspx?tt=1");
            }
        }
    }
}
