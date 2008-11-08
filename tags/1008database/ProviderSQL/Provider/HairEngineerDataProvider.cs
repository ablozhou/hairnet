using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;
using System.Data;

namespace HairNet.Provider
{
    public interface IHairEngineerDataProvider
    {
        /// <summary>
        /// ����ʦ ɾ�������ӣ��޸�
        /// </summary>
        /// <param name="hairEngineer"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerCreateDeleteUpdate(HairEngineer hairEngineer, UserAction ua,out int hairEngineerID);

        /// <summary>
        /// ����ʦ�Ƽ� ɾ�������ӣ��޸�
        /// </summary>
        /// <param name="hairEngineerRecommand"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerRecommandCreateDeleteUpdate(HairEngineerRecommand hairEngineerRecommand, UserAction ua);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engineerOpusInfo">engineerOpusInfo</param>
        /// <param name="action">action</param>
        void HairStyleCreateDeleteUpdate(HairStyleEntity engineerOpusInfo, UserAction action,out int newid);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engineerID"></param>
        /// <returns></returns>
        List<HairStyleEntity> GetEngineerOpusByEngineerID(Int32 engineerID);

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

        List<HairStyleEntity> GetHairStyleListByHairEngineerID(Int32 ID);

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
        /// ����ʦ��� ���ӣ�ɾ�����޸�
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
        /// ����ʦTAG ���ӣ�ɾ�����޸�
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tagNames"></param>
        /// <returns></returns>
        string GetHairEngineerTagIDs(string tagNames);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tagIDs"></param>
        /// <returns></returns>
        string GetHairEngineerTagNames(string tagIDs);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="HairEngineerID"></param>
        /// <returns></returns>
        DataTable GetHairEngineerInfoByID(Int32 HairEngineerID);


        List<HairStyleEntity> GetHairStyleListByName(string hairStyleName);

        List<HairStyleEntity> GetHairStyleList();

        List<HairStyleEntity> GetHairStyleListByID(Int32 ID);
    }
}