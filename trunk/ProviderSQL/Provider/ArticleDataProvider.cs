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
        List<Article> GetArticlesByUserID(int count,int userID);

    
    }
}
