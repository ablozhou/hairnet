using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;
using System.Data.SqlClient;

namespace HairNet.Provider
{
    public class ArticleDataProviderInstance:IArticleDataProvider
    {
        //实现
        /// <summary>
        /// 文章 删除，添加，修改
        /// </summary>
        /// <param name="art"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool ArticleCreateDeleteUpdate(Article art, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "INSERT INTO Article (ArticleID, ArticleTitle, ArticleAuthor, ArticleContent, ArticleTagIDs, ArticleDigNum, "+
                            " ArticleOutLink, ArticleSource, ArticleGroupID, ArticlePublishDate) "+
                            " VALUES (" + art.ArticleID  + ",'" + art.ArticleTitle  + "','" + art.ArticleAuthor  + "','" +
                            art.ArticleContent  + "','" + art.ArticleTagIDs  + "'," + art.ArticleDigNum  + ",'" +
                            art.ArticleOutLink  + "','" + art.ArticleSource + "'," + art.ArticleGroupID + ",'" + art.ArticlePublishDate  + "')";
                    break;
                case UserAction.Delete:
                    commandText = "DELETE FROM Article FROM Article   where ArticleID=" + art.ArticleID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "UPDATE Article SET ArticleTitle = '" + art.ArticleTitle + "', ArticleAuthor = '" + art.ArticleAuthor + "', ArticleContent = '" + art.ArticleContent + "', ArticleTagIDs = '" + art.ArticleTagIDs + "'," +
                        "ArticleDigNum = " + art.ArticleDigNum + ", ArticleOutLink = '" + art.ArticleOutLink + "', ArticleSource = '" + art.ArticleSource + "', ArticleGroupID = " + art.ArticleGroupID + ",ArticlePublishDate = '" + art.ArticlePublishDate + "'";
                    break;
            }
            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commandText;
                    comm.Connection = conn;
                    conn.Open();
                    try
                    {
                        comm.ExecuteNonQuery();
                        result = true;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
            }
            if (ua == UserAction.Delete)
            {
                using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
                {
                    result = false;
                    commandText = "delete from ArticleComment where ArticleID=" + art.ArticleID.ToString();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commandText;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            comm.ExecuteNonQuery();
                            result = true;
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }

                    }
                }
            }
            return result;
            
        }

        /// <summary>
        /// 通过文章ID来获取文章实体
        /// </summary>
        /// <param name="ArticleID"></param>
        /// <returns></returns>
        public Article GetArticleByArticleID(int articleID)
        {
            Article art = new Article();
       
            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from Article art where art.ArticleID=" + articleID.ToString() + " order by art.ArticleID desc";
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commText;
                        conn.Open();

                        using (SqlDataReader reader = comm.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                art.ArticleAuthor = reader["ArticleAuthor"].ToString();
                                art.ArticleContent = reader["ArticleContent"].ToString();
                                art.ArticleDigNum = int.Parse(reader["ArticleDigNum"].ToString());
                                art.ArticleGroupID  = int.Parse ( reader["ArticleGroupID"].ToString());
                                art.ArticleID  = int.Parse(reader["ArticleID"].ToString());
                                art.ArticleOutLink  = reader["ArticleOutLink"].ToString();
                                art.ArticlePublishDate  = DateTime.Parse(reader["ArticlePublishDate"].ToString());
                                art.ArticleSource  = reader["ArticleSource"].ToString();
                                art.ArticleTagIDs  = reader["ArticleTagIDs"].ToString();
                                art.ArticleTitle  = reader["ArticleTitle"].ToString();
                                
                            }
                        }
                    }
                }
            }
            return art;
        }

        /// <summary>
        /// 获取文章
        /// </summary>
        /// <param name="count">0 所有</param>
        /// <param name="groupID">0  所有</param>
        /// <returns></returns>
        public List<Article> GetArticlesByGroupID(int count, int groupID)
        {
            List<Article> li = new List<Article>();
            string commText = "";
            if (groupID == 0)
            {
                switch (count)
                {
                    case 0:
                        commText = "select * from Article order by ArticleID desc";
                        break;
                    default:
                        commText = "select top " + count.ToString() + " * from Article order by ArticleID desc";
                        break;
                }
            }
            {
                switch (count)
                {
                    case 0:
                        commText = "select * from Article order by ArticleID desc where ArticleGroupID = " + groupID.ToString();
                        break;
                    default:
                        commText = "select top " + count.ToString() + " * from Article where ArticleGroupID = " + groupID.ToString() + " order by ArticleID desc";
                        break;
                }
            }

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commText;
                        conn.Open();

                        using (SqlDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Article art = new Article();

                                art.ArticleAuthor = reader["ArticleAuthor"].ToString();
                                art.ArticleContent = reader["ArticleContent"].ToString();
                                art.ArticleDigNum = int.Parse(reader["ArticleDigNum"].ToString());
                                art.ArticleGroupID = int.Parse(reader["ArticleGroupID"].ToString());
                                art.ArticleID = int.Parse(reader["ArticleID"].ToString());
                                art.ArticleOutLink = reader["ArticleOutLink"].ToString();
                                art.ArticlePublishDate = DateTime.Parse(reader["ArticlePublishDate"].ToString());
                                art.ArticleSource = reader["ArticleSource"].ToString();
                                art.ArticleTagIDs = reader["ArticleTagIDs"].ToString();
                                art.ArticleTitle = reader["ArticleTitle"].ToString();

                                li.Add(art);
                            }
                        }
                    }
                }
            }
            return li;
        }

        public bool ArticleTagCreateDeleteUpdate(ArticleTag articleTag, UserAction ua)
        {
            bool result = false;
            return result;
        }
        public List<ArticleTag> GetArticleTags(int count)
        {
            List<ArticleTag> list = new List<ArticleTag>();
            return list;
        }
        public ArticleTag GetArticleTagByArticleTagID(int articleTagID)
        {
            ArticleTag articleTag = new ArticleTag();
            return articleTag;
        }

        public bool ArticleCommentCreateDeleteUpdate(ArticleComment articleComment, UserAction ua)
        {
            bool result = false;
            return result;
        }
        public List<ArticleComment> GetArticleCommentsByArticleID(int articleID, int count, string orderKey)
        {
            List<ArticleComment> list = new List<ArticleComment>();
            return list;
        }
        public List<ArticleComment> GetArticleCommentsByUserID(int userID, int count, string orderKey)
        {
            List<ArticleComment> list = new List<ArticleComment>();
            return list;
        }

        public bool ArticleGroupCreateDeleteUpdate(ArticleGroup articleGroup, UserAction userAction)
        {
            bool result = false;
            return result;
        }
        public List<ArticleGroup> GetArticleGroups(int count)
        {
            List<ArticleGroup> list = new List<ArticleGroup>();
            return list;
        }
        public List<ArticleGroup> GetArticleGroupsByParentID(int parentID, int count)
        {
            List<ArticleGroup> list = new List<ArticleGroup>();
            return list; 
        }
        public ArticleGroup GetArticleGroupByArticleGroupID(int articleGroupID)
        {
            ArticleGroup articleGroup = new ArticleGroup();
            return articleGroup;
        }
    }
}
