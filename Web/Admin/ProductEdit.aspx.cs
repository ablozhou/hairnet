using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using HairNet.Entry;
using HairNet.Business;
using System.Data.SqlClient;

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
            //TAG逻辑
            if (product.ProductTagIDs != string.Empty)
            {
                string[] tempTagC = product.ProductTagIDs.Split(",".ToCharArray());
                for (int k = 0; k < tempTagC.Length; k++)
                {
                    ProductTag hst = new ProductTag();
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "select * from ProductTag where ProductTagID=" + tempTagC[k];
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

                    if (k == 0)
                    {
                        this.txtProductTag.Text = hst.TagName;
                    }
                    else
                    {
                        this.txtProductTag.Text += ";" + hst.TagName;
                    }
                }
            }
            //
            txtCompany.Text = product.ProductCompany;
            txtCompanyDescription.Text = product.ProductCompanyDescription;
            txtProductDescription.Text = product.ProductDescription;
            txtProductDiscount.Text = product.ProductDiscount;
            txtProductName.Text = product.ProductName;
            txtProductPrice.Text = product.ProductPrice;
            txtProductRawPrice.Text = product.ProductRawPrice;
            ViewState["ProductInfo"] = product;
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            Product product = (Product)ViewState["ProductInfo"];
            //tag逻辑

            if (product.ProductTagIDs != string.Empty)
            {
                string[] tempTagC = product.ProductTagIDs.Split(",".ToCharArray());
                for (int k = 0; k < tempTagC.Length; k++)
                {
                    ProductTag hst = new ProductTag();
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "select * from ProductTag where ProductTagID=" + tempTagC[k];
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
                    string[] tempProductIDC = hst.ProductIDs.Split(",".ToCharArray());
                    string ProductIDs = "";

                    int tempNum = 0;
                    for (int i = 0; i < tempProductIDC.Length; i++)
                    {
                        if (tempProductIDC[i] != product.ProductID.ToString())
                        {
                            tempNum++;
                            if (tempNum == 1)
                            {
                                ProductIDs = tempProductIDC[i];
                            }
                            else
                            {
                                ProductIDs += "," + tempProductIDC[i];
                            }
                        }
                    }
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "update ProductTag set ProductIDs='" + ProductIDs + "' where ProductTagID=" + hst.TagID.ToString();
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

            //
            product.ProductName = txtProductName.Text.Trim();
            product.ProductPrice = txtProductPrice.Text.Trim();
            product.ProductRawPrice = txtProductRawPrice.Text.Trim();
            product.ProductDiscount = txtProductDiscount.Text.Trim();
            product.ProductDescription = txtProductDescription.Text.Trim();
            product.ProductCompanyDescription = txtCompanyDescription.Text.Trim();
            product.ProductCompany = txtCompany.Text.Trim();
            
            //tag逻辑
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
            //

            Session["ProductInfo"] = product;
            //更新美发产品
            InfoAdmin.UpdateProduct(product);
            this.Response.Redirect("ProductAdmin.aspx");
        }
    }
}
