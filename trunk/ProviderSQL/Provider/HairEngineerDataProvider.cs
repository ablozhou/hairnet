using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public interface IHairEngineerDataProvider
    {
        /// <summary>
        /// ����ʦ ɾ������ӣ��޸�
        /// </summary>
        /// <param name="hairEngineer"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerCreateDeleteUpdate(HairEngineer hairEngineer, UserAction ua);
    }
}
