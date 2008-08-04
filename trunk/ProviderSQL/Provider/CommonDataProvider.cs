using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Provider
{
    public abstract class CommonDataProvider
    {
        public CommonDataProvider()
        { }
        public static CommonDataProvider CreateInstance()
        {
            return (CommonDataProvider)ProviderFactory.CreateInstance("CommonDataProvider");
        }
        public virtual int GetInt()
        {
            throw new Exception("√ª µœ÷");
        }
    }
}
