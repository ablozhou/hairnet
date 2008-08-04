using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Provider
{
    public abstract class ArticleDataProvider
    {
        public ArticleDataProvider()
        { }
        public static ArticleDataProvider CreateInstance()
        {
            return (ArticleDataProvider)ProviderFactory.CreateInstance("ArticleDataProvider");
        }
    }
}
