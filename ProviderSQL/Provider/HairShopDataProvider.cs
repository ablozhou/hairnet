using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using System.Data.SqlClient;
using HairNet.Enumerations;
using System.Data;

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
        /// 
        /// </summary>
        /// <param name="Top"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        DataTable GetHairShopList(int Top, OrderKey Key);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Top"></param>
        /// <param name="WhereCaused"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        DataTable GetHairShopList(int Top, String WhereCaused, OrderKey Key);

        /// <summary>
        /// 美发厅 删除，添加，修改(新版本)
        /// </summary>
        /// <param name="hairShop"></param>
        /// <param name="action"></param>
        void HairShopCreateDeleteUpdate(HairShop hairShop, UserAction action);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="coupon"></param>
        /// <param name="action"></param>
        void CouponCreateDeleteUpdate(Coupon coupon, UserAction action);

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
        List<HairShop> GetHairShops(int count, OrderKey ok);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="ok"></param>
        /// <returns></returns>
        List<HairShop> GetHairShops(int count, OrderKey ok, string hairShopName);

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

        /// <summary>
        /// 获得美发店风格列表
        /// </summary>
        /// <returns></returns>
        List<TypeTable> GetTypeTables();

        /// <summary>
        /// 美发店风格 添加，删除，修改
        /// </summary>
        /// <param name="typeTable"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool TypeTableCreateDeleteUpdate(TypeTable typeTable, UserAction ua);

        /// <summary>
        /// 获得美发厅营业范围列表
        /// </summary>
        /// <returns></returns>
        List<WorkRange> GetWorkRanges();

        /// <summary>
        /// 美发厅营业范围 添加，删除，修改
        /// </summary>
        /// <param name="workRange"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool WorkRangeCreateDeleteUpdate(WorkRange workRange, UserAction ua);

        /// <summary>
        /// 获取美发厅TAG列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairShopTag> GetHairShopTags(int count);

        /// <summary>
        /// 美发厅TAG列表 添加，删除，修改
        /// </summary>
        /// <param name="hairShopTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairShopTagCreateDeleteUpdate(HairShopTag hairShopTag, UserAction ua);

        /// <summary>
        /// 通过TAGID获取美发厅TAG实体
        /// </summary>
        /// <param name="hairShopTagID"></param>
        /// <returns></returns>
        HairShopTag GetHairShopTagByHairShopTagID(int hairShopTagID);

        /// <summary>
        /// 通过美发厅ID获取美发厅评论列表
        /// </summary>
        /// <param name="hairShopID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">用户排序KEY 例如：时间排序，好评排序，按照用户排序</param>
        /// <returns></returns>
        List<HairShopComment> GetHairShopCommentsByHairShopID(int hairShopID, int count, OrderKey ok);

        /// <summary>
        /// 通过USERID获取美发厅的评论列表
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">用户排序KEY 时间排序，好评排序，美发厅排序</param>
        /// <returns></returns>
        List<HairShopComment> GetHairShopCommentsByUserID(int userID, int count, OrderKey ok);

        /// <summary>
        /// 美发厅评论 添加，删除，修改
        /// </summary>
        /// <param name="hairShopComment"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairShopCommentCreateDeleteUpdate(HairShopComment hairShopComment, UserAction ua);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairShopComment> GetHairShopComments(int count);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairShopComment> GetHairShopCommentsByKeyText(int count, string keyText);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="sTime"></param>
        /// <param name="eTime"></param>
        /// <returns></returns>
        List<HairShopComment> GetHairShopCommentsByTimeZone(int count, string sTime, string eTime);

        int AddHairShop(HairShop hairShop);

        /// <summary>
        /// 获取标签对应的ID的集合
        /// </summary>
        /// <param name="tagNames">标签名称的集合</param>
        /// <returns></returns>
        string GetHairShopTagIDs(string tagNames);

        string GetHairShopTagNames(string ids);


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        DataTable GetCouponList();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="couponID"></param>
        void DeleteCoupon(String couponID);

        /// <summary>
        /// 获取美发店风格字符串
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetTypeNameById(int id);
    }
}
