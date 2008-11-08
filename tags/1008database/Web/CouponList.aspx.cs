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
                selectCondition = this.Request.QueryString["sc"].ToString();
            }
            catch
            { }

            this.CouponDetailList1.SelectCondition = selectCondition;
        }


        protected void btnBusiZoneSearch_Click(object sender, EventArgs e)
        {
            string selection = " where hz.HotZoneName like '%"+this.txtBuziZone.Text.Trim()+"%'";
            this.Response.Redirect("CouponList.aspx?sc="+Server.UrlEncode(selection));
        }

        protected void btnKeySearch_Click(object sender, EventArgs e)
        {
            string selection = " where hs.HairShopName like '%" + this.txtHairShopName.Text.Trim() + "%'";
            this.Response.Redirect("CouponList.aspx?sc=" + Server.UrlEncode(selection));
        }
    }
}
