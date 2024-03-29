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
        /// 美发师 删除，添加，修改
        /// </summary>
        /// <param name="hairEngineer"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerCreateDeleteUpdate(HairEngineer hairEngineer, UserAction ua,out int hairEngineerID);

        /// <summary>
        /// 美发师推荐 删除，添加，修改
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
        /// 通过美发师ID来获取美发师实体
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <returns></returns>
        HairEngineer GetHairEngineerByHairEngineerID(int hairEngineerID);

        /// <summary>
        /// 获取美发师
        /// </summary>
        /// <param name="count">0 所有</param>
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
        /// 通过美发师推荐ID来获取美发师推荐实体
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <returns></returns>
        HairEngineerRecommand GetHairEngineerRecommandByHairEngineerRecommandID(int hairEngineerRecommandID);

        /// <summary>
        /// 获取美发师推荐
        /// </summary>
        /// <param name="count">0 所有</param>
        /// <returns></returns>
        List<HairEngineerRecommand> GetHairEngineerRecommands(int count);

        /// <summary>
        /// 获得美发师类别列表
        /// </summary>
        /// <returns></returns>
        List<HairEngineerClass> GetHairEngineerClasses();

        /// <summary>
        /// 美发师类别 添加，删除，修改
        /// </summary>
        /// <param name="hairEngineerClass"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerClassCreateDeleteUpdate(HairEngineerClass hairEngineerClass, UserAction ua);

        /// <summary>
        /// 获取美发师TAG列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairEngineerTag> GetHairEngineerTags(int count);

        /// <summary>
        /// 获得美发师TAG实体
        /// </summary>
        /// <param name="hairEngineerTagID"></param>
        /// <returns></returns>
        HairEngineerTag GetHairEngineerTagByHairEngineerTagID(int hairEngineerTagID);

        /// <summary>
        /// 美发师TAG 添加，删除，修改
        /// </summary>
        /// <param name="hairEngineerTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerTagCreateDeleteUpdate(HairEngineerTag hairEngineerTag, UserAction ua);

        /// <summary>
        /// 获取美发师评论列表
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">排序KEY 按照时间排序，按照好评排序，按照用户ID排序</param>
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
        /// 获取美发师评论列表
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">排序KEY 按照时间排序，按照好评排序，按照美发师排序</param>
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
        /// 获取美发师评论列表
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
