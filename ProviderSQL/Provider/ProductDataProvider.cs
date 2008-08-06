using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public interface IProductDataProvider
    {
        /// <summary>
        /// 美发产品 添加，删除，修改
        /// </summary>
        /// <param name="product"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool ProductCreateDeleteUpdate(Product product, UserAction ua);

        /// <summary>
        /// 美发产品推荐 添加，删除，修改
        /// </summary>
        /// <param name="productRecommand"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool ProductRecommandCreateDeleteUpdate(ProductRecommand productRecommand, UserAction ua);

        /// <summary>
        /// 通过美发产品ID获得美发产品实体
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        Product GetProductByProductID(int productID);

        /// <summary>
        /// 获得美发产品
        /// </summary>
        /// <param name="count">0 全部</param>
        /// <returns></returns>
        List<Product> GetProducts(int count);

        /// <summary>
        /// 通过美发产品推荐ID获得美发产品推荐实体
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        ProductRecommand GetProductRecommandByProductRecommandID(int productRecommandID);

        /// <summary>
        /// 获得美发产品推荐
        /// </summary>
        /// <param name="count">0 全部</param>
        /// <returns></returns>
        List<ProductRecommand> GetProductRecommands(int count);
    }
}
