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
        /// ������Ʒ ���ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="product"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool ProductCreateDeleteUpdate(Product product, UserAction ua);

        /// <summary>
        /// ������Ʒ�Ƽ� ���ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="productRecommand"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool ProductRecommandCreateDeleteUpdate(ProductRecommand productRecommand, UserAction ua);

        /// <summary>
        /// ͨ��������ƷID���������Ʒʵ��
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        Product GetProductByProductID(int productID);

        /// <summary>
        /// ���������Ʒ
        /// </summary>
        /// <param name="count">0 ȫ��</param>
        /// <returns></returns>
        List<Product> GetProducts(int count);

        /// <summary>
        /// ͨ��������Ʒ�Ƽ�ID���������Ʒ�Ƽ�ʵ��
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        ProductRecommand GetProductRecommandByProductRecommandID(int productRecommandID);

        /// <summary>
        /// ���������Ʒ�Ƽ�
        /// </summary>
        /// <param name="count">0 ȫ��</param>
        /// <returns></returns>
        List<ProductRecommand> GetProductRecommands(int count);

        bool ProductCommentCreateDeleteUpdate(ProductComment productComment, UserAction ua);
        List<ProductComment> GetProductCommentsByProductID(int productID, int count, string orderKey);
        List<ProductComment> GetProductCommentsByUserID(int userID, int count, string orderKey);

        bool ProductTagCreateDeleteUpdate(ProductTag productTag, UserAction ua);
        List<ProductTag> GetProductTags(int count);
        ProductTag GetProductTagByProductTagID(int productTagID);
    }
}