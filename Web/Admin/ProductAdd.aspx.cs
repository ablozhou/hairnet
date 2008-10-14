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
using HairNet.Provider;
using HairNet.Enumerations;
using System.Data.SqlClient;

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

            Session["ProductInfo"] = product;
            //添加美发产品并返回新的ID
            product.ProductID = InfoAdmin.AddProduct(product);

            //TAG逻辑
            int id = product.ProductID;
            string tagIDs = "";
            string[] tagCollection = txtProductTag.Text.Split(";".ToCharArray());
            for (int k = 0; k < tagCollection.Length; k++)
            {
                string tagID = "";
                bool isExist = false;
                ProductTag hst = new ProductTag();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from ProductTag where ProductTagName='" + tagCollection[k] + "'";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                try
                                {
                                    hst.TagID = int.Parse(sdr["ProductTagID"].ToString());
                                    hst.TagName = sdr["ProductTagName"].ToString();
                                    hst.ProductIDs = sdr["ProductIDs"].ToString();
                                }
                                catch
                                { }
                            }
                        }
                    }
                }
                if (hst.TagID == 0)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "insert ProductTag(ProductTagName,ProductIDs) values('" + tagCollection[k] + "','" + id.ToString() + "');select @@identity;";
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = commString;
                            comm.Connection = conn;
                            conn.Open();

                            tagID = comm.ExecuteScalar().ToString();
                        }
                    }
                }
                else
                {
                    tagID = hst.TagID.ToString();
                    if (hst.ProductIDs == string.Empty)
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "update ProductTag set ProductIDs='" + id.ToString() + "' where ProductTagID=" + hst.TagID.ToString();
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = commString;
                                comm.Connection = conn;
                                conn.Open();
                                try
                                {
                                    comm.ExecuteNonQuery();
                                }
                                catch
                                { }
                            }
                        }
                    }
                    else
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "update ProductTag set ProductIDs=ProductIDs+'," + id.ToString() + "' where ProductTagID=" + hst.TagID.ToString();
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = commString;
                                comm.Connection = conn;
                                conn.Open();
                                try
                                {
                                    comm.ExecuteNonQuery();
                                }
                                catch
                                { }
                            }
                        }
                    }
                }
                if (k == 0)
                {
                    tagIDs = tagID;
                }
                else
                {
                    tagIDs += "," + tagID;
                }
            }
            product.ProductTagIDs = tagIDs;
            
            ProviderFactory.GetProductDataProviderInstance().ProductCreateDeleteUpdate(product, UserAction.Update, out id);

            //TAG逻辑结束

            this.Response.Redirect("ProductAdmin.aspx");
        }
    }
}
