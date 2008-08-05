using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public interface IProductDataProvider
    {
        bool ProductCreateDeleteUpdate(Product product, UserAction ua);
    }
}
