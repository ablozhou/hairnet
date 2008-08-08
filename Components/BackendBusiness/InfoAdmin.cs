using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Provider;

namespace HairNet.Business
{
    public class InfoAdmin
    {
        /// <summary>
        /// 获得美发厅信息列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<HairShop> GetHairShops(int count)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShops(count);  
        }

        /// <summary>
        /// 获得美发师信息列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<HairEngineer> GetHairEngineers(int count)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineers(count);
        }

        /// <summary>
        /// 获得美发产品列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<Product> GetProducts(int count)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProducts(count);  
        }
    }
}
