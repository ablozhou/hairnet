using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public abstract class ProductDataProvider
    {
        public ProductDataProvider()
        { }

        public static ProductDataProvider CreateInstance()
        {
            return (ProductDataProvider)ProviderFactory.CreateInstance("ProductDataProvider");
        }

        public abstract bool ProductCreateDeleteUpdate(Product product, UserAction ua);
    }
}
