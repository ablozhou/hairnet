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

        /// <summary>
        /// ����ʦ�Ƽ� ɾ������ӣ��޸�
        /// </summary>
        /// <param name="hairEngineerRecommand"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerRecommandCreateDeleteUpdate(HairEngineerRecommand hairEngineerRecommand, UserAction ua);

        /// <summary>
        /// ͨ������ʦID����ȡ����ʦʵ��
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <returns></returns>
        HairEngineer GetHairEngineerByHairEngineerID(int hairEngineerID);

        /// <summary>
        /// ��ȡ����ʦ
        /// </summary>
        /// <param name="count">0 ����</param>
        /// <returns></returns>
        List<HairEngineer> GetHairEngineers(int count);

        /// <summary>
        /// ͨ������ʦ�Ƽ�ID����ȡ����ʦ�Ƽ�ʵ��
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <returns></returns>
        HairEngineerRecommand GetHairEngineerRecommandByHairEngineerRecommandID(int hairEngineerRecommandID);

        /// <summary>
        /// ��ȡ����ʦ�Ƽ�
        /// </summary>
        /// <param name="count">0 ����</param>
        /// <returns></returns>
        List<HairEngineerRecommand> GetHairEngineerRecommands(int count);
    }
}
