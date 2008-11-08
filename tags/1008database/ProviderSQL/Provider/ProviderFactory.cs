using System;
using System.Reflection;
using System.Configuration;


namespace HairNet.Provider
{
    /// <summary>
    /// CreateInstence 的摘要说明。
    /// </summary>
    public class ProviderFactory
    {
        public ProviderFactory()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /// <summary>
        /// 创建数据库实例
        /// </summary>
        /// <returns>数据库操作方法实例</returns>
        public static object CreateInstance(string configKey)
        {
            string[] sList = System.Configuration.ConfigurationManager.AppSettings[configKey].Split(",".ToCharArray());
            /// 获取实例的程序集和命名空间
            string strAssembly = sList[0].ToString();
            string strNamespace = sList[1].ToString();

            ///反射创建实例
            return (object)Assembly.Load(strAssembly).CreateInstance(strNamespace);
        }

        /// <summary>
        /// 获得图片库provider实例
        /// </summary>
        /// <returns></returns>
        public static IPictureStoreDataProvider GetPictureStoreDataProviderInstance()
        {
            return ProviderFactory.CreateInstance("PictureStoreDataProvider") as IPictureStoreDataProvider;
        }
        /// <summary>
        /// 获得文章provider实例
        /// </summary>
        /// <returns></returns>
        public static IArticleDataProvider GetArticleDataProviderInstance()
        {
            return ProviderFactory.CreateInstance("ArticleDataProvider") as IArticleDataProvider;
        }
        /// <summary>
        /// 获得通用provider实例
        /// </summary>
        /// <returns></returns>
        public static ICommonDataProvider GetCommonDataProviderInstance()
        {
            return ProviderFactory.CreateInstance("CommonDataProvider") as ICommonDataProvider;
        }
        /// <summary>
        /// 获得美发师provider实例
        /// </summary>
        /// <returns></returns>
        public static IHairEngineerDataProvider GetHairEngineerDataProviderInstance()
        {
            return ProviderFactory.CreateInstance("HairEngineerDataProvider") as IHairEngineerDataProvider;
        }
        /// <summary>
        /// 获得美发店provider实例
        /// </summary>
        /// <returns></returns>
        public static IHairShopDataProvider GetHairShopDataProviderInstance()
        {
            return ProviderFactory.CreateInstance("HairShopDataProvider") as IHairShopDataProvider;
        }
        /// <summary>
        /// 获得美发产品provider实例
        /// </summary>
        /// <returns></returns>
        public static IProductDataProvider GetProductDataProviderInstance()
        {
            return ProviderFactory.CreateInstance("ProductDataProvider") as IProductDataProvider;
        }
        /// <summary>
        /// 获得用户provider实例
        /// </summary>
        /// <returns></returns>
        public static IUserDataProvider GetUserDataProviderInstance()
        {
            return ProviderFactory.CreateInstance("UserDataProvider") as IUserDataProvider;
        }
    }
}
