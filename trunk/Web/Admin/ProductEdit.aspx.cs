using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using HairNet.Entry;
using HairNet.Business;

namespace Web.Admin
{
    public partial class ProductEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindBaseInfo();
            }
        }

        private void bindBaseInfo()
        {
            string id = Request["id"];
            Product product = InfoAdmin.GetProductByProductID(id);
            txtCompany.Text = product.ProductCompany;
            txtCompanyDescription.Text = product.ProductCompanyDescription;
            txtProductDescription.Text = product.ProductDescription;
            txtProductDiscount.Text = product.ProductDiscount;
            txtProductName.Text = product.ProductName;
            txtProductPrice.Text = product.ProductPrice;
            txtProductRawPrice.Text = product.ProductRawPrice;
            txtProductTag.Text = InfoAdmin.GetProductTagNames(product.ProductTagIDs);
            ViewState["ProductInfo"] = product;
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            Product product = (Product)ViewState["ProductInfo"];
            product.ProductName = txtProductName.Text.Trim();
            product.ProductPrice = txtProductPrice.Text.Trim();
            product.ProductRawPrice = txtProductRawPrice.Text.Trim();
            product.ProductDiscount = txtProductDiscount.Text.Trim();
            product.ProductDescription = txtProductDescription.Text.Trim();
            product.ProductCompanyDescription = txtCompanyDescription.Text.Trim();
            product.ProductCompany = txtCompany.Text.Trim();

            product.ProductTagIDs = InfoAdmin.GetProductTagIDs(txtProductTag.Text.Trim());

            Session["ProductInfo"] = product;

            this.Response.Redirect("ProductEdit2.aspx");
        }
    }
}
