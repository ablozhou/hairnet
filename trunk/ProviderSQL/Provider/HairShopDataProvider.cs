using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using System.Data.SqlClient;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public abstract class HairShopDataProvider
    {
        public HairShopDataProvider()
        {}
        public static HairShopDataProvider CreateInstance()
        {
            return (HairShopDataProvider)ProviderFactory.CreateInstance("HairShopDataProvider");
        }

        /// <summary>
        /// 美发厅 删除，添加，修改
        /// </summary>
        /// <param name="hairShop"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public abstract bool HairShopDataPrividerCreateDeleteUpdate(HairShop hairShop, UserAction ua);
        
    }
}
