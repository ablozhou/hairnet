using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
