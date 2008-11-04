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
using HairNet.Provider;

namespace Web
{
    public partial class MapInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.HairShopID = int.Parse(this.Request.QueryString["id"].ToString());
                HairShop hairShop = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(this.HairShopID);

                if (hairShop.LocationMapURL != string.Empty)
                {
                    this.lblText.Text = "<div class=\"sitemap\"><iframe id='mapbarframe' border='0' vspace='0' hspace='0' marginwidth='0' marginheight='0' framespacing='0' frameborder='0'scrolling='no' width='600' height='450' src='http://searchbox.mapbar.com/publish/template/template1010/index.jsp?" + hairShop.LocationMapURL.ToString() + "'></iframe></div>";
                }
                else
                {
                    this.lblText.Text = "<div class=\"sitemap\"><img src=\"Theme/images/fair-mft19.gif\" /></div>";
                }
            }
        }
        private int _hairShopID = 0;
        public int HairShopID
        {
            set { this._hairShopID = value; }
            get { return this._hairShopID; }
        }
    }
}
