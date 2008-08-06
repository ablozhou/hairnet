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
        /// 美发师 删除，添加，修改
        /// </summary>
        /// <param name="hairEngineer"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerCreateDeleteUpdate(HairEngineer hairEngineer, UserAction ua);

        /// <summary>
        /// 美发师推荐 删除，添加，修改
        /// </summary>
        /// <param name="hairEngineerRecommand"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairEngineerRecommandCreateDeleteUpdate(HairEngineerRecommand hairEngineerRecommand, UserAction ua);

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
        List<HairEngineer> GetHairEngineers(int count);

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
    }
}
