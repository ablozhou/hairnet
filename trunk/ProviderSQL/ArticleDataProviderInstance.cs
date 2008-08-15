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
                    commandText = "DELETE FROM Article   where ArticleID=" + art.ArticleID.ToString();
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
            string commText = string.Empty ;
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
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "INSERT INTO ArticleTag  (ArticleTagID, ArticleTagName, ArticleIDs) VALUES ("+articleTag.TagID +", '"+articleTag.TagName +"', '"+articleTag.ArticleIDs +"')";
                    break;
                case UserAction.Delete:
                    commandText = "DELETE FROM ArticleTag WHERE (ArticleTagID = "+articleTag.TagID +")";
                    break;
                case UserAction.Update:
                    commandText = "UPDATE ArticleTag SET ArticleTagName ='"+articleTag.TagName +"', ArticleIDs ='"+articleTag.ArticleIDs +"' WHERE (ArticleTagID = "+articleTag.TagID +")";
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
          
            return result;
        }
        public List<ArticleTag> GetArticleTags(int count)
        {
            List<ArticleTag> list = new List<ArticleTag>();
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "SELECT articletagID,ArticleTagName, ArticleIDs FROM ArticleTag order by articletagID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * ArticleTag order by articletagID   desc";
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
                                ArticleTag tag = new ArticleTag();

                                tag.TagID = int.Parse(reader["ArticletagID"].ToString());
                                tag.TagName = reader["ArticleTagName"].ToString();
                                tag.ArticleIDs  = reader["ArticleIDs"].ToString();

                                list.Add(tag);
                            }
                        }
                    }
                }
            }
            return list;
        }
        public ArticleTag GetArticleTagByArticleTagID(int articleTagID)
        {
            ArticleTag tag = new ArticleTag();

            string commText = "SELECT * FROM ArticleTag where ArticleTagID="+articleTagID ;
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
  
                                tag.TagID = int.Parse(reader["TagID"].ToString());
                                tag.TagName = reader["TagName"].ToString();
                                tag.ArticleIDs = reader["ArticleIDs"].ToString();

                               
                            }
                        }
                    }
                }
            }
            return tag;
        }

        public bool ArticleCommentCreateDeleteUpdate(ArticleComment articleComment, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "INSERT INTO ArticleComment  (ArticleCommentID, ArticleCommentText, UserID, UserName, UserAddress,  ArticleCommentCreateTime, ArticleID) VALUES ("+
                        articleComment.CommentID +", '"+articleComment.CommentText +"',"+articleComment.UserID +", '"+articleComment.UserName +"', '"+articleComment.UserAddress +"','"+articleComment.CommentCreateTime +"',"+articleComment.ArticleID +")";
                        break;
                case UserAction.Delete:
                    commandText = "DELETE FROM ArticleComment WHERE (ArticleCommentID = "+articleComment.CommentID +")";
                    break;
                case UserAction.Update:
                    commandText = "UPDATE ArticleComment SET ArticleCommentText = '"+articleComment.CommentText +"', UserID = "+articleComment.UserID +", UserName = '"+articleComment.UserName +"', UserAddress = '"+articleComment.UserAddress +
                        "',ArticleCommentCreateTime = '"+articleComment.CommentCreateTime +"', ArticleID = "+articleComment.ArticleID +" WHERE (ArticleCommentID = "+articleComment.CommentID +")";
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
          
            return result;
        }
        public List<ArticleComment> GetArticleCommentsByArticleID(int articleID, int count, string orderKey)
        {
            List<ArticleComment> list = new List<ArticleComment>();
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "SELECT ArticleCommentText, UserID, UserName, UserAddress, ArticleCommentCreateTime, ArticleID, ArticleCommentID "+
                        " FROM ArticleComment "+
                        " WHERE (ArticleID = "+articleID +")";
                        
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from ArticleComment WHERE (ArticleID = "+articleID +")";
                    break;
            }
            
           if (orderKey == "DESC")
           {
               commText += "ORDER BY ArticleCommentID DESC";
           }
           else
           {
               commText += "ORDER BY ArticleCommentID ";
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
                               ArticleComment comment = new ArticleComment();

                               comment.CommentID = int.Parse(reader["ArticleCommentID"].ToString());
                               comment.ArticleID = int.Parse(reader["ArticleID"].ToString());
                               comment.CommentCreateTime = DateTime.Parse(reader["ArticleCommentCreateTime"].ToString());
                               comment.CommentText = reader["ArticleCommentText"].ToString();
                               comment.UserAddress = reader["UserAddress"].ToString();
                               comment.UserID = int.Parse(reader["UserID"].ToString());
                               comment.UserName = reader["UserName"].ToString();


                               list.Add(comment);
                           }
                       }
                   }
               }
           }
           return list;
        }
        public List<ArticleComment> GetArticleCommentsByUserID(int userID, int count, string orderKey)
        {
            List<ArticleComment> list = new List<ArticleComment>();
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "SELECT ArticleCommentText, UserID, UserName, UserAddress, ArticleCommentCreateTime, ArticleID, ArticleCommentID " +
                        " FROM ArticleComment " +
                        " WHERE (UserID = " + userID  + ")";

                    break;
                default:
                    commText = "select top " + count.ToString() + " * from ArticleComment WHERE (UserID = " + userID + ")";
                    break;
            }

            if (orderKey == "DESC")
            {
                commText += "ORDER BY ArticleCommentID DESC";
            }
            else
            {
                commText += "ORDER BY ArticleCommentID ";
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
                                ArticleComment comment = new ArticleComment();

                                comment.CommentID = int.Parse(reader["ArticleCommentID"].ToString());
                                comment.ArticleID = int.Parse(reader["ArticleID"].ToString());
                                comment.CommentCreateTime = DateTime.Parse(reader["ArticleCommentCreateTime"].ToString());
                                comment.CommentText = reader["ArticleCommentText"].ToString();
                                comment.UserAddress = reader["UserAddress"].ToString();
                                comment.UserID = int.Parse(reader["UserID"].ToString());
                                comment.UserName = reader["UserName"].ToString();


                                list.Add(comment);
                            }
                        }
                    }
                }
            } 
            
            return list;
        }

        public bool ArticleGroupCreateDeleteUpdate(ArticleGroup articleGroup, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "INSERT INTO ArticleGroup (ArticleGroupID, ArticleGroupName, ArticleGroupParentID, ArticleIDs) VALUES (" + articleGroup.ID + ", '" + articleGroup.Name + "', " + articleGroup.ArticleGroupParentID + ", '" + articleGroup.ArticleIDs + "')";
                        break;
                case UserAction.Delete:
                    commandText = "DELETE FROM ArticleGroup WHERE (ArticleGroupID = "+articleGroup.ID +")";
                    break;
                case UserAction.Update:
                    commandText = "UPDATE ArticleGroup SET ArticleGroupName = '" + articleGroup.Name + "', ArticleGroupParentID = " + articleGroup.ArticleGroupParentID + ", ArticleIDs = '" + articleGroup.ArticleIDs + "'";
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
          
            
            return result;
        }
        public List<ArticleGroup> GetArticleGroups(int count)
        {
            List<ArticleGroup> list = new List<ArticleGroup>();
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "SELECT ArticleGroup.* FROM ArticleGroup " ;

                    break;
                default:
                    commText = "select top " + count.ToString() + " * from FROM ArticleGroup";
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
                                ArticleGroup group = new ArticleGroup();
                               

                                group.ID  = int.Parse(reader["ArticleGroupID"].ToString());
                               group.ArticleIDs  = reader["ArticleIDs"].ToString();
                                group.ArticleGroupParentID = int.Parse(reader["ArticleGroupParentID"].ToString());
                                group.Name  = reader["ArticleGroupName"].ToString();


                                list.Add(group);
                            }
                        }
                    }
                }
            } 
            return list;
        }
        public List<ArticleGroup> GetArticleGroupsByParentID(int parentID, int count)
        {
            List<ArticleGroup> list = new List<ArticleGroup>();
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "SELECT ArticleGroup.* FROM ArticleGroup WHERE (ArticleGroupParentID = "+parentID+") ";

                    break;
                default:
                    commText = "select top " + count.ToString() + " * from FROM ArticleGroup WHERE (ArticleGroupParentID = " + parentID + ") ";
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
                                ArticleGroup group = new ArticleGroup();


                                group.ID = int.Parse(reader["ArticleGroupID"].ToString());
                                group.ArticleIDs = reader["ArticleIDs"].ToString();
                                group.ArticleGroupParentID = int.Parse(reader["ArticleGroupParentID"].ToString());
                                group.Name = reader["ArticleGroupName"].ToString();


                                list.Add(group);
                            }
                        }
                    }
                }
            } 
            return list; 
        }
        public ArticleGroup GetArticleGroupByArticleGroupID(int articleGroupID)
        {
            ArticleGroup group = new ArticleGroup();

            string commText = "SELECT ArticleGroup.* FROM ArticleGroup WHERE (ArticleGroupID =  " + articleGroupID + ") ";


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

                                group.ID = int.Parse(reader["ArticleGroupID"].ToString());
                                group.ArticleIDs = reader["ArticleIDs"].ToString();
                                group.ArticleGroupParentID = int.Parse(reader["ArticleGroupParentID"].ToString());
                                group.Name = reader["ArticleGroupName"].ToString();


                               
                            }
                        }
                    }
                }
            } 
    
            return group;
        }
    }
}
