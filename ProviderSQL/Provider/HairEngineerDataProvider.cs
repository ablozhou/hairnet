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
        List<HairEngineer> GetHairEngineers(int count,OrderKey ok);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="ok"></param>
        /// <param name="hairEngineerName"></param>
        /// <returns></returns>
        List<HairEngineer> GetHairEngineers(int count, OrderKey ok,string hairEngineerName);

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

        /// <summary>
        /// �������ʦ����б�
        /// </summary>
        /// <returns></returns>
        List<HairEngineerClass> GetHairEngineerClasses();

        /// <summary>
        /// ����ʦ��� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hairEngineerClass"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerClassCreateDeleteUpdate(HairEngineerClass hairEngineerClass, UserAction ua);

        /// <summary>
        /// ��ȡ����ʦTAG�б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairEngineerTag> GetHairEngineerTags(int count);

        /// <summary>
        /// �������ʦTAGʵ��
        /// </summary>
        /// <param name="hairEngineerTagID"></param>
        /// <returns></returns>
        HairEngineerTag GetHairEngineerTagByHairEngineerTagID(int hairEngineerTagID);

        /// <summary>
        /// ����ʦTAG ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hairEngineerTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerTagCreateDeleteUpdate(HairEngineerTag hairEngineerTag, UserAction ua);

        /// <summary>
        /// ��ȡ����ʦ�����б�
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">����KEY ����ʱ�����򣬰��պ������򣬰����û�ID����</param>
        /// <returns></returns>
        List<HairEngineerComment> GetHairEngineerCommentsByHairEngineerID(int hairEngineerID,int count,OrderKey ok);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairEngineerComment> GetHairEngineerComments(int count);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairEngineerComment> GetHairEngineerCommentsByKeyText(int count,string keyText);

        /// <summary>
        /// ��ȡ����ʦ�����б�
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">����KEY ����ʱ�����򣬰��պ������򣬰�������ʦ����</param>
        /// <returns></returns>
        List<HairEngineerComment> GetHairEngineerCommentsByUserID(int userID, int count, OrderKey ok);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="sTime"></param>
        /// <param name="eTime"></param>
        /// <returns></returns>
        List<HairEngineerComment> GetHairEngineerCommentsByTimeZone(int count, string sTime,string eTime);

        /// <summary>
        /// ��ȡ����ʦ�����б�
        /// </summary>
        /// <param name="hairEngineerComment"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerCommentCreateDeleteUpdate(HairEngineerComment hairEngineerComment, UserAction ua);
    }
}
