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
        /// ���� ɾ������ӣ��޸�
        /// </summary>
        /// <param name="art"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool ArticleCreateDeleteUpdate(Article art, UserAction ua);

        /// <summary>
        /// �����Ƽ� ɾ������ӣ��޸�
        /// </summary>
        /// <param name="ArticleRecommend"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        //bool ArticleRecommendCreateDeleteUpdate(ArticleRecommend artRecommend, UserAction ua);

        /// <summary>
        /// ͨ������ID����ȡ����ʵ��
        /// </summary>
        /// <param name="ArticleID"></param>
        /// <returns></returns>
        Article GetArticleByArticleID(int articleID);

        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <param name="count">0 ����</param>
        /// <returns></returns>
        List<Article> GetArticlesByGroupID(int count, int groupID);

        //int GetTag(string tagName);
        bool ArticleTagCreateDeleteUpdate(ArticleTag articleTag, UserAction ua);
        List<ArticleTag> GetArticleTags(int count);
        ArticleTag GetArticleTagByArticleTagID(int articleTagID);

        bool ArticleCommentCreateDeleteUpdate(ArticleComment articleComment, UserAction ua);
        List<ArticleComment> GetArticleCommentsByArticleID(int articleID, int count, string orderKey);
        List<ArticleComment> GetArticleCommentsByUserID(int userID, int count, string orderKey);

        bool ArticleGroupCreateDeleteUpdate(ArticleGroup articleGroup, UserAction userAction);
        List<ArticleGroup> GetArticleGroups(int count);
        List<ArticleGroup> GetArticleGroupsByParentID(int parentID, int count);
        ArticleGroup GetArticleGroupByArticleGroupID(int articleGroupID);
    
    }
}
