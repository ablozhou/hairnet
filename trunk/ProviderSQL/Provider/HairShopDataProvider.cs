using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using System.Data.SqlClient;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public interface IHairShopDataProvider
    {   
        /// <summary>
        /// ������ ɾ������ӣ��޸�
        /// </summary>
        /// <param name="hairShop"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairShopDataPrividerCreateDeleteUpdate(HairShop hairShop, UserAction ua);

        /// <summary>
        /// �������Ƽ� ɾ������ӣ��޸�
        /// </summary>
        /// <param name="hairShop"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairShopRecommandCreateDeleteUpdate(HairShopRecommand hairShopRecommand, UserAction ua);

        /// <summary>
        /// ͨ��������ID���������ʵ��
        /// </summary>
        /// <param name="hairShopID"></param>
        /// <returns></returns>
        HairShop GetHairShopByHairShopID(int hairShopID);

        /// <summary>
        /// ���������
        /// </summary>
        /// <param name="count">0 ȫ��</param>
        /// <returns></returns>
        List<HairShop> GetHairShops(int count);

        /// <summary>
        /// ͨ���������Ƽ�ID����������Ƽ�ʵ��
        /// </summary>
        /// <param name="hairShopRecommandID"></param>
        /// <returns></returns>
        HairShopRecommand GetHairShopRecommandByHairShopRecommandID(int hairShopRecommandID);

        /// <summary>
        /// ����������Ƽ�
        /// </summary>
        /// <param name="count">0 ȫ��</param>
        /// <returns></returns>
        List<HairShopRecommand> GetHairShopRecommands(int count);

        /// <summary>
        /// ������������б�
        /// </summary>
        /// <returns></returns>
        List<TypeTable> GetTypeTables();

        /// <summary>
        /// �������� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="typeTable"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool TypeTableCreateDeleteUpdate(TypeTable typeTable, UserAction ua);

        /// <summary>
        /// ���������Ӫҵ��Χ�б�
        /// </summary>
        /// <returns></returns>
        List<WorkRange> GetWorkRanges();

        /// <summary>
        /// ������Ӫҵ��Χ ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="workRange"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool WorkRangeCreateDeleteUpdate(WorkRange workRange, UserAction ua);

        /// <summary>
        /// ��ȡ������TAG�б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairShopTag> GetHairShopTags(int count);

        /// <summary>
        /// ������TAG�б� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hairShopTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairShopTagCreateDeleteUpdate(HairShopTag hairShopTag, UserAction ua);

        /// <summary>
        /// ͨ��TAGID��ȡ������TAGʵ��
        /// </summary>
        /// <param name="hairShopTagID"></param>
        /// <returns></returns>
        HairShopTag GetHairShopTagByHairShopTagID(int hairShopTagID);

        /// <summary>
        /// ͨ��������ID��ȡ�����������б�
        /// </summary>
        /// <param name="hairShopID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">�û�����KEY ���磺ʱ�����򣬺������򣬰����û�����</param>
        /// <returns></returns>
        List<HairShopComment> GetHairShopCommentsByHairShopID(int hairShopID,int count,string orderKey);

        /// <summary>
        /// ͨ��USERID��ȡ�������������б�
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">�û�����KEY ʱ�����򣬺�����������������</param>
        /// <returns></returns>
        List<HairShopComment> GetHairShopCommentsByUserID(int userID, int count,string orderKey);

        /// <summary>
        /// ���������� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hairShopComment"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairShopCommentCreateDeleteUpdate(HairShopComment hairShopComment, UserAction ua);
    }
}
