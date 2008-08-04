using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Provider
{
    public abstract class PictureStoreDataProvider
    {
        public PictureStoreDataProvider()
        { }
        public static PictureStoreDataProvider CreateInstance()
        {
            return (PictureStoreDataProvider)ProviderFactory.CreateInstance("PictureStoreDataProvider");
        }
    }
}
