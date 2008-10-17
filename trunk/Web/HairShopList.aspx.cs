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
using System.Text;

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
//            城区(district)
//商圈(buzizone)
//品牌(product)
//营业面积(square)
//关键字(keyword)
            StringBuilder sb = new StringBuilder();
            string district = string.Empty;
            string buzizone = string.Empty;
            string product = string.Empty;
            string square = string.Empty;
            string keyword = string.Empty;

            try
            {
                district = this.Request.QueryString["district"].ToString();
                if (district != string.Empty)
                {
                    sb.Append(" where m.MapZoneID = "+district);
                }
            }
            catch
            {}

            try
            {
                buzizone = this.Request.QueryString["buzizone"].ToString();
                if (buzizone != string.Empty)
                {
                    if (sb.ToString() == string.Empty)
                    {
                        sb.Append(" where h.hotZoneID = " + buzizone);
                    }
                    else
                    {
                        sb.Append(" and h.hotZoneID = " + buzizone);
                    }
                }
            }
            catch
            { }

            try
            {
                square = this.Request.QueryString["square"].ToString();
                if (square != string.Empty)
                {
                    if (sb.ToString() == string.Empty)
                    {
                        sb.Append(" where hs.square = " + square);
                    }
                    else
                    {
                        sb.Append(" and hs.square = " + square);
                    }
                }
            }
            catch
            { }
            try
            {
                product = this.Request.QueryString["product"].ToString();
            }
            catch
            { }

            try
            {
                keyword = this.Request.QueryString["keyword"].ToString();
            }
            catch
            { }

            this.hairShopListControl.PageSize = 6;
            this.hairShopListControl.CurrentPage = pageNum;
            this.hairShopListControl.SortType = sortType;
            this.hairShopListControl.SelectCondition = sb.ToString();
            this.hairShopListControl.ProductID = product;
            this.hairShopListControl.KeyWord = keyword;
        }
    }
}
