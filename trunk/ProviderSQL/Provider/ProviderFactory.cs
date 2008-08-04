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
    }
}
