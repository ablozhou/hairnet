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
        /// <param name="userID">user ID</param>
        /// <returns></returns>
        public List<Article> GetArticlesByUserID(int count, int userID)
        {
            List<Article > li = new List<Article> ();
            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from Article order by ArticleID desc where userID = "+userID ;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from Article where userID = "+userID +" order by ArticleID desc";
                    break;
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
                                art.ArticleGroupID = int.Parse ( reader["ArticleGroupID"].ToString());
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
    }
}
