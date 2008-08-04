using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
