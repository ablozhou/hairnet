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
        public abstract bool HairShopDataPrividerCreateDeleteUpdate(HairShop hairShop, UserAction ua);
    }
}
