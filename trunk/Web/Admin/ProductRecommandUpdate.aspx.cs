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
using HairNet.Enumerations;
using HairNet.Utilities;

namespace Web.Admin
{
    public partial class ProductRecommandUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string operateType = this.Request.QueryString["operateType"].ToString();

                if (operateType == "1")
                {
                    string productRecommandInfo = ConfigurationManager.AppSettings["ProductRecommandInfo"].ToString();

                    this.content.Value = productRecommandInfo;
                }
                else
                {
                    int productRecommandID = int.Parse(this.Request.QueryString["productRecommandID"].ToString());
                    ProductRecommand p = InfoAdmin.GetProductRecommand(productRecommandID);

                    this.content.Value = p.ProductRecommandInfo;
                }
            }
        }
        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            string operateType = this.Request.QueryString["operateType"].ToString();
            if (operateType == "1")
            {
                int productID = int.Parse(this.Request.QueryString["productID"].ToString());
                string productRecommandInfo = this.content.Value;
                string productRecommandEx = this.txtRecommandEx.Text.Trim();

                if (InfoAdmin.RecommandProduct(productID, 0, productRecommandInfo, productRecommandEx, UserAction.Create))
                {
                    StringHelper.AlertInfo("推荐成功", this.Page);
                    this.Response.Redirect("ProductAdmin.aspx");
                }
                else
                {
                    StringHelper.AlertInfo("推荐失败", this.Page);
                }
            }
            else
            {
                int productID = int.Parse(this.Request.QueryString["productID"].ToString());
                int productRecommandID = int.Parse(this.Request.QueryString["productRecommandID"].ToString());

                string productRecommandInfo = this.content.Value;
                string productRecommandEx = this.txtRecommandEx.Text.Trim();
                if (InfoAdmin.RecommandProduct(productID, productRecommandID, productRecommandInfo, productRecommandEx, UserAction.Update))
                {
                    StringHelper.AlertInfo("更新成功", this.Page);
                    this.Response.Redirect("ProductRecommandAdmin.aspx");
                }
                else
                {
                    StringHelper.AlertInfo("更新失败", this.Page);
                }
            }
        }
    }
}
