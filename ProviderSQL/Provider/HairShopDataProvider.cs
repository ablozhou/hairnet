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
        
    }
}
