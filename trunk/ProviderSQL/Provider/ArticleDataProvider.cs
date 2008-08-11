using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public interface IArticleDataProvider
    {
        /// <summary>
        /// 文章 删除，添加，修改
        /// </summary>
        /// <param name="art"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool ArticleCreateDeleteUpdate(Article art, UserAction ua);

        /// <summary>
        /// 文章推荐 删除，添加，修改
        /// </summary>
        /// <param name="ArticleRecommend"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        //bool ArticleRecommendCreateDeleteUpdate(ArticleRecommend artRecommend, UserAction ua);

        /// <summary>
        /// 通过文章ID来获取文章实体
        /// </summary>
        /// <param name="ArticleID"></param>
        /// <returns></returns>
        Article GetArticleByArticleID(int articleID);

        /// <summary>
        /// 获取文章
        /// </summary>
        /// <param name="count">0 所有</param>
        /// <returns></returns>
        List<Article> GetArticlesByUserID(int count,int userID);

    
    }
}
