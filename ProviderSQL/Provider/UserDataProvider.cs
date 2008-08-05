using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Provider
{
    public abstract class UserDataProvider
    {
        public UserDataProvider()
        { }
        public static UserDataProvider CreateInstance()
        {
            return (UserDataProvider)ProviderFactory.CreateInstance("UserDataProvider");
        }
    }
}
