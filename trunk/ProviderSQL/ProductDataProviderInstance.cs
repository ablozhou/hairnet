using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public class ProductDataProviderInstance: IProductDataProvider
    {
        /// <summary>
        /// 美发产品 添加，删除，修改
        /// </summary>
        /// <param name="product"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool ProductCreateDeleteUpdate(Product product, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into Product(ProductName,ProductCompany,ProductCompanyDescription,ProductPictureStoreIDs,ProductDescription,HairShopIDs,ProductRawPrice,ProductPrice,ProductDiscount,ProductTagIDs) values('"+product.ProductName+"','"+product.ProductCompany+"','"+product.ProductCompanyDescription+"','"+product.ProductPictureStoreIDs+"','"+product.ProductDescription+"','"+product.HairShopIDs+"','"+product.ProductRawPrice+"','"+product.ProductPrice+"','"+product.ProductDiscount+"','"+product.ProductTagIDs+"')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from Product where ProductID="+product.ProductID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update Product set ProductName='"+product.ProductName+"',ProductCompany='"+product.ProductCompany+"',ProductCompanyDescription='"+product.ProductCompanyDescription+"',ProductPictureStoreIDs='"+product.ProductPictureStoreIDs+"',ProductDescription='"+product.ProductDescription+"',HairShopIDs='"+product.HairShopIDs+"',ProductRawPrice='"+product.ProductRawPrice+"',ProductPrice='"+product.ProductPrice+"',ProductDiscount='"+product.ProductDiscount+"',ProductTagIDs='"+product.ProductTagIDs+"' where ProductID = "+product.ProductID.ToString();
                    break;
            }
            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commandText;
                    comm.Connection = conn;
                    conn.Open();
                    try
                    {
                        comm.ExecuteNonQuery();
                        result = true;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
            }
            if (ua == UserAction.Delete)
            {
                using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
                {
                    result = false;
                    commandText = "delete from ProductRecommand where ProductRawID=" + product.ProductID.ToString();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commandText;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            comm.ExecuteNonQuery();
                            result = true;
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }

                    }
                }
            }
            return result;
        }
        /// <summary>
        /// 美发产品推荐 添加，删除，修改
        /// </summary>
        /// <param name="productRecommand"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool ProductRecommandCreateDeleteUpdate(ProductRecommand productRecommand, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into ProductRecommand(ProductRawID,ProductName,ProductCompany,ProductCompanyDescription,ProductPictureStoreIDs,ProductDescription,HairShopIDs,ProductRawPrice,ProductPrice,ProductDiscount,ProductTagIDs,ProductRecommandEx,ProductRecommandInfo) values(" + productRecommand.ProductRawID.ToString() + ",'" + productRecommand.ProductName + "','" + productRecommand.ProductCompany + "','" + productRecommand.ProductCompanyDescription + "','" + productRecommand.ProductPictureStoreIDs + "','" + productRecommand.ProductDescription + "','" + productRecommand.HairShopIDs + "','" + productRecommand.ProductRawPrice + "','" + productRecommand.ProductPrice + "','" + productRecommand.ProductDiscount + "','" + productRecommand.ProductTagIDs + "','"+productRecommand.ProductRecommandEx+"','"+productRecommand.ProductRecommandInfo+"')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from ProductRecommand where ProductRecommandID=" + productRecommand.ProductRecommandID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update ProductRecommand set ProductRawID=" + productRecommand.ProductRawID.ToString() + ",ProductName='" + productRecommand.ProductName + "',ProductCompany='" + productRecommand.ProductCompany + "',ProductCompanyDescription='" + productRecommand.ProductCompanyDescription + "',ProductPictureStoreIDs='" + productRecommand.ProductPictureStoreIDs + "',ProductDescription='" + productRecommand.ProductDescription + "',HairShopIDs='" + productRecommand.HairShopIDs + "',ProductRawPrice='" + productRecommand.ProductRawPrice + "',ProductPrice='" + productRecommand.ProductPrice + "',ProductDiscount='" + productRecommand.ProductDiscount + "',ProductTagIDs='" + productRecommand.ProductTagIDs + "',ProductRecommandEx='"+productRecommand.ProductRecommandEx+"',ProductRecommandInfo='"+productRecommand.ProductRecommandInfo+"' where ProductRecommandID = " + productRecommand.ProductRecommandID.ToString();
                    break;
            }
            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commandText;
                    comm.Connection = conn;
                    conn.Open();
                    try
                    {
                        comm.ExecuteNonQuery();
                        result = true;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
            }
            return result;
        }
        /// <summary>
        /// 通过美发产品ID获得美发产品实体
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public Product GetProductByProductID(int productID)
        {
            Product product = new Product();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from Product where ProductID="+productID.ToString();

                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commText;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            product.ProductID = int.Parse(sdr["ProductID"].ToString());
                            product.ProductName = sdr["ProductName"].ToString();
                            product.ProductCompany = sdr["ProductCompany"].ToString();
                            product.ProductCompanyDescription = sdr["ProductCompanyDescription"].ToString();
                            product.ProductPictureStoreIDs = sdr["ProductPictureStoreIDs"].ToString();
                            product.ProductHits = int.Parse(sdr["ProductHits"].ToString());
                            product.ProductDescription = sdr["ProductDescription"].ToString();
                            product.HairShopIDs = sdr["HairShopIDs"].ToString();
                            product.ProductRawPrice = sdr["ProductRawPrice"].ToString();
                            product.ProductPrice = sdr["ProductPrice"].ToString();
                            product.ProductDiscount = sdr["ProductDiscount"].ToString();
                            product.ProductTagIDs = sdr["ProductTagIDs"].ToString();
                        }
                    }
                }
            }

            return product;
        }

        /// <summary>
        /// 获得美发产品
        /// </summary>
        /// <param name="count">0 全部</param>
        /// <returns></returns>
        public List<Product> GetProducts(int count)
        {
            List<Product> list = new List<Product>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from Product order by ProductID desc";
                    break;
                default:
                    commText = "select top "+count.ToString()+" * from Product order by ProductID desc";
                    break;
            }

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commText;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                Product product = new Product();

                                product.ProductID = int.Parse(sdr["ProductID"].ToString());
                                product.ProductName = sdr["ProductName"].ToString();
                                product.ProductCompany = sdr["ProductCompany"].ToString();
                                product.ProductCompanyDescription = sdr["ProductCompanyDescription"].ToString();
                                product.ProductPictureStoreIDs = sdr["ProductPictureStoreIDs"].ToString();
                                product.ProductHits = int.Parse(sdr["ProductHits"].ToString());
                                product.ProductDescription = sdr["ProductDescription"].ToString();
                                product.HairShopIDs = sdr["HairShopIDs"].ToString();
                                product.ProductRawPrice = sdr["ProductRawPrice"].ToString();
                                product.ProductPrice = sdr["ProductPrice"].ToString();
                                product.ProductDiscount = sdr["ProductDiscount"].ToString();
                                product.ProductTagIDs = sdr["ProductTagIDs"].ToString();

                                list.Add(product);
                            }
                        }
                    }
                }
            }

            return list;
        }
        /// <summary>
        /// 通过美发产品推荐ID获得美发产品推荐实体
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public ProductRecommand GetProductRecommandByProductRecommandID(int productRecommandID)
        {
            ProductRecommand productRecommand = new ProductRecommand();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from ProductRecommand pr inner join Product p on pr.ProductRawID = p.ProductID where pr.ProductRecommandID=" + productRecommandID.ToString();

                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commText;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            productRecommand.ProductRecommandID = int.Parse(sdr["ProductRecommandID"].ToString());
                            productRecommand.ProductRawID = int.Parse(sdr["ProductRawID"].ToString());
                            productRecommand.ProductName = sdr["ProductName"].ToString();
                            productRecommand.ProductCompany = sdr["ProductCompany"].ToString();
                            productRecommand.ProductCompanyDescription = sdr["ProductCompanyDescription"].ToString();
                            productRecommand.ProductPictureStoreIDs = sdr["ProductPictureStoreIDs"].ToString();
                            productRecommand.ProductHits = int.Parse(sdr["ProductHits"].ToString());
                            productRecommand.ProductDescription = sdr["ProductDescription"].ToString();
                            productRecommand.HairShopIDs = sdr["HairShopIDs"].ToString();
                            productRecommand.ProductRawPrice = sdr["ProductRawPrice"].ToString();
                            productRecommand.ProductPrice = sdr["ProductPrice"].ToString();
                            productRecommand.ProductDiscount = sdr["ProductDiscount"].ToString();
                            productRecommand.ProductTagIDs = sdr["ProductTagIDs"].ToString();
                            productRecommand.ProductRecommandEx = sdr["ProductRecommandEx"].ToString();
                            productRecommand.ProductRecommandInfo = sdr["ProductRecommandInfo"].ToString();
                        }
                    }
                }
            }

            return productRecommand;
        }

        /// <summary>
        /// 获得美发产品推荐
        /// </summary>
        /// <param name="count">0 全部</param>
        /// <returns></returns>
        public List<ProductRecommand> GetProductRecommands(int count)
        {
            List<ProductRecommand> list = new List<ProductRecommand>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from ProductRecommand pr inner join Product p on pr.ProductRawID = p.ProductID order by pr.ProductRecommandID desc";
                    break;
                default:
                    commText = "select top "+count.ToString()+" * from ProductRecommand pr inner join Product p on pr.ProductRawID = p.ProductID order by pr.ProductRecommandID desc";
                    break;
            }

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commText;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                ProductRecommand productRecommand = new ProductRecommand();

                                productRecommand.ProductRecommandID = int.Parse(sdr["ProductRecommandID"].ToString());
                                productRecommand.ProductRawID = int.Parse(sdr["ProductRawID"].ToString());
                                productRecommand.ProductName = sdr["ProductName"].ToString();
                                productRecommand.ProductCompany = sdr["ProductCompany"].ToString();
                                productRecommand.ProductCompanyDescription = sdr["ProductCompanyDescription"].ToString();
                                productRecommand.ProductPictureStoreIDs = sdr["ProductPictureStoreIDs"].ToString();
                                productRecommand.ProductHits = int.Parse(sdr["ProductHits"].ToString());
                                productRecommand.ProductDescription = sdr["ProductDescription"].ToString();
                                productRecommand.HairShopIDs = sdr["HairShopIDs"].ToString();
                                productRecommand.ProductRawPrice = sdr["ProductRawPrice"].ToString();
                                productRecommand.ProductPrice = sdr["ProductPrice"].ToString();
                                productRecommand.ProductDiscount = sdr["ProductDiscount"].ToString();
                                productRecommand.ProductTagIDs = sdr["ProductTagIDs"].ToString();
                                productRecommand.ProductRecommandEx = sdr["ProductRecommandEx"].ToString();
                                productRecommand.ProductRecommandInfo = sdr["ProductRecommandInfo"].ToString();

                                list.Add(productRecommand);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public bool ProductCommentCreateDeleteUpdate(ProductComment productComment, UserAction ua)
        {
            bool result = false;
            return result;
        }
        public List<ProductComment> GetProductCommentsByProductID(int productID, int count, string orderKey)
        {
            List<ProductComment> list = new List<ProductComment>();
            return list;
        }
        public List<ProductComment> GetProductCommentsByUserID(int userID, int count, string orderKey)
        {
            List<ProductComment> list = new List<ProductComment>();
            return list;
        }

        public bool ProductTagCreateDeleteUpdate(ProductTag productTag, UserAction ua)
        {
            bool result = false;
            return result;
        }
        public List<ProductTag> GetProductTags(int count)
        {
            List<ProductTag> list = new List<ProductTag>();
            return list;
        }
        public ProductTag GetProductTagByProductTagID(int productTagID)
        {
            ProductTag productTag = new ProductTag();
            return productTag;
        }
    }
}
