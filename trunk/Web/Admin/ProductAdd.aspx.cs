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

namespace Web.Admin
{
    public partial class ProductAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = txtProductName.Text.Trim();
            product.ProductPrice = txtProductPrice.Text.Trim();
            product.ProductRawPrice = txtProductRawPrice.Text.Trim();
            product.ProductDiscount = txtProductDiscount.Text.Trim();
            product.ProductDescription = txtProductDescription.Text.Trim();
            product.ProductCompanyDescription = txtCompanyDescription.Text.Trim();
            product.ProductCompany = txtCompany.Text.Trim();

            product.ProductTagIDs = InfoAdmin.GetProductTagIDs(txtProductTag.Text.Trim());

            Session["ProductInfo"] = product;

            this.Response.Redirect("ProductAdd2.aspx");
        }
    }
}
