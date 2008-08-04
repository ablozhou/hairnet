using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Provider
{
    public abstract class HairEngineerDataProvider
    {
        public HairEngineerDataProvider()
        { }
        public static HairEngineerDataProvider CreateInstance()
        {
            return (HairEngineerDataProvider)ProviderFactory.CreateInstance("HairEngineerDataProvider");
        }
    }
}
