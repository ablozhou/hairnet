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
    public partial class HairShopList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StringHelper.AddStyleSheet(this.Page, "Theme/Style/meifating_list.css");

            int pageNum = 1;
            try
            {
                pageNum = int.Parse(this.Request.QueryString["pageNum"].ToString());
            }
            catch
            {
                pageNum = 1;
            }
            int sortType = 1;
            try
            {
                sortType = int.Parse(this.Request.QueryString["sortID"].ToString());
            }
            catch
            { }
            this.hairShopListControl.PageSize = 6;
            this.hairShopListControl.CurrentPage = pageNum;
            this.hairShopListControl.SortType = sortType;
        }
    }
}
