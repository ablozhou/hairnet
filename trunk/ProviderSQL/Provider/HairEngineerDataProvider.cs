using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

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

        /// <summary>
        /// 美发师 删除，添加，修改
        /// </summary>
        /// <param name="hairEngineer"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public abstract bool HairEngineerCreateDeleteUpdate(HairEngineer hairEngineer, UserAction ua);
    }
}
