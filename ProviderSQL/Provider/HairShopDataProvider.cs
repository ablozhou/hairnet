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
        /// 美发厅 删除，添加，修改
        /// </summary>
        /// <param name="hairShop"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairShopDataPrividerCreateDeleteUpdate(HairShop hairShop, UserAction ua);

        /// <summary>
        /// 美发厅推荐 删除，添加，修改
        /// </summary>
        /// <param name="hairShop"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairShopRecommandCreateDeleteUpdate(HairShopRecommand hairShopRecommand, UserAction ua);

        /// <summary>
        /// 通过美发厅ID获得美发厅实体
        /// </summary>
        /// <param name="hairShopID"></param>
        /// <returns></returns>
        HairShop GetHairShopByHairShopID(int hairShopID);

        /// <summary>
        /// 获得美发厅
        /// </summary>
        /// <param name="count">0 全部</param>
        /// <returns></returns>
        List<HairShop> GetHairShops(int count);

        /// <summary>
        /// 通过美发厅推荐ID获得美发厅推荐实体
        /// </summary>
        /// <param name="hairShopRecommandID"></param>
        /// <returns></returns>
        HairShopRecommand GetHairShopRecommandByHairShopRecommandID(int hairShopRecommandID);

        /// <summary>
        /// 获得美发厅推荐
        /// </summary>
        /// <param name="count">0 全部</param>
        /// <returns></returns>
        List<HairShopRecommand> GetHairShopRecommands(int count);
        
    }
}
