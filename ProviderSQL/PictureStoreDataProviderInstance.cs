using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;
using System.Data.SqlClient;
using System.Data;

namespace HairNet.Provider
{
    public class PictureStoreDataProviderInstance : IPictureStoreDataProvider
    {
        public bool PictureStoreCreateDeleteUpdate(PictureStore pictureStore, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into PictureStore(PictureStoreName,PictureStoreRawUrl,PictureStoreLittleUrl,PictureStoreTagIDs,PictureStoreDescription,HairEngineerIDs,HairShopIDs,PictureStoreCreateTime,PictureStoreGroupIDs) values('" + pictureStore.PictureStoreName + "','" + pictureStore.PictureStoreRawUrl + "','" + pictureStore.PictureStoreLittleUrl + "','" + pictureStore.PictureStoreTagIDs + "','" + pictureStore.PictureStoreDescription + "','" + pictureStore.PictureStoreHairEngineerIDs + "','" + pictureStore.PictureStoreHairShopIDs + "','" + pictureStore.PictureStoreCreateTime.ToString() + "','" + pictureStore.PictureStoreGroupIDs + "')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from PictureStore where PictureStoreID=" + pictureStore.PictureStoreID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update PictureStore set PictureStoreName = '" + pictureStore.PictureStoreName + "',PictureStoreRawUrl = '" + pictureStore.PictureStoreRawUrl + "',PictureStoreLittleUrl='" + pictureStore.PictureStoreLittleUrl + "',PictureStoreTagIDs='" + pictureStore.PictureStoreTagIDs + "',PictureStoreDescription='" + pictureStore.PictureStoreDescription + "',HairEngineerIDs='" + pictureStore.PictureStoreHairEngineerIDs + "',HairShopIDs='" + pictureStore.PictureStoreHairShopIDs + "',PictureStoreCreateTime='" + pictureStore.PictureStoreCreateTime.ToString() + "',PictureStoreGroupIDs='" + pictureStore.PictureStoreGroupIDs + "' where PictureStoreID=" + pictureStore.PictureStoreID.ToString();
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
        public bool PictureStoreRecommandCreateDeleteUpdate(PictureStoreRecommand pictureStoreRecommand, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into PictureStoreRecommand(PictureStoreRawID,PictureStoreName,PictureStoreRawUrl,PictureStoreLittleUrl,PictureStoreTagIDs,PictureStoreDescription,HairEngineerIDs,HairShopIDs,PictureStoreCreateTime,PictureStoreGroupIDs,PictureStoreRecommandEx,PictureStoreRecommandInfo) values(" + pictureStoreRecommand.PictureStoreRawID.ToString() + ",'" + pictureStoreRecommand.PictureStoreName + "','" + pictureStoreRecommand.PictureStoreRawUrl + "','" + pictureStoreRecommand.PictureStoreLittleUrl + "','" + pictureStoreRecommand.PictureStoreTagIDs + "','" + pictureStoreRecommand.PictureStoreDescription + "','" + pictureStoreRecommand.PictureStoreHairEngineerIDs + "','" + pictureStoreRecommand.PictureStoreHairShopIDs + "','" + pictureStoreRecommand.PictureStoreCreateTime.ToString() + "','" + pictureStoreRecommand.PictureStoreGroupIDs + "','" + pictureStoreRecommand.PictureStoreRecommandEx + "','" + pictureStoreRecommand.PictureStoreRecommandInfo + "')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from PictureStoreRecommand where PictureStoreRecommandID=" + pictureStoreRecommand.PictureStoreRecommandID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update PictureStoreRecommand set PictureStoreRawID=" + pictureStoreRecommand.PictureStoreRawID.ToString() + ",PictureStoreName = '" + pictureStoreRecommand.PictureStoreName + "',PictureStoreRawUrl = '" + pictureStoreRecommand.PictureStoreRawUrl + "',PictureStoreLittleUrl='" + pictureStoreRecommand.PictureStoreLittleUrl + "',PictureStoreTagIDs='" + pictureStoreRecommand.PictureStoreTagIDs + "',PictureStoreDescription='" + pictureStoreRecommand.PictureStoreDescription + "',HairEngineerIDs='" + pictureStoreRecommand.PictureStoreHairEngineerIDs + "',HairShopIDs='" + pictureStoreRecommand.PictureStoreHairShopIDs + "',PictureStoreCreateTime='" + pictureStoreRecommand.PictureStoreCreateTime.ToString() + "',PictureStoreGroupIDs='" + pictureStoreRecommand.PictureStoreGroupIDs + "',PictureStoreRecommandEx='" + pictureStoreRecommand.PictureStoreRecommandEx + "',PictureStoreRecommandInfo='" + pictureStoreRecommand.PictureStoreRecommandInfo + "' where PictureStoreRecommandID=" + pictureStoreRecommand.PictureStoreRecommandID.ToString();
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

        public PictureStore GetPictureStoreByPictureStoreID(int pictureStoreID)
        {
            PictureStore pictureStore = new PictureStore();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from PictureStore where PictureStoreID=" + pictureStoreID.ToString() + " order by PictureStoreID desc";

                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commText;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            pictureStore.PictureStoreID = int.Parse(sdr["PictureStoreID"].ToString());
                            pictureStore.PictureStoreName = sdr["PictureStoreName"].ToString();
                            pictureStore.PictureStoreRawUrl = sdr["PictureStoreRawUrl"].ToString();
                            pictureStore.PictureStoreLittleUrl = sdr["PictureStoreLittleUrl"].ToString();
                            pictureStore.PictureStoreTagIDs = sdr["PictureStoreTagIDs"].ToString();
                            pictureStore.PictureStoreHits = int.Parse(sdr["PictureStoreHits"].ToString());
                            pictureStore.PictureStoreDescription = sdr["PictureStoreDescription"].ToString();
                            pictureStore.PictureStoreHairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                            pictureStore.PictureStoreHairShopIDs = sdr["HairShopIDs"].ToString();
                            pictureStore.PictureStoreCreateTime = Convert.ToDateTime(sdr["PictureStoreCreateTime"].ToString());
                            pictureStore.PictureStoreGroupIDs = sdr["PictureStoreGroupIDs"].ToString();
                        }
                    }
                }
            }

            return pictureStore;
        }

        public List<PictureStore> GetPictureStores(int count, OrderKey ok)
        {
            List<PictureStore> list = new List<PictureStore>();

            string orderKey = " order by ";
            switch (ok)
            {
                case OrderKey.ID:
                    orderKey += "PictureStoreID desc";
                    break;
                //case OrderKey.CommentNum:
                //评论数未作预处理，暂不实现
                //    orderKey += "he.HairEngineerGood+he.HairEngineerBad desc";
                //    break;
                case OrderKey.HitNum:
                    orderKey += "PictureStoreHits desc";
                    break;
                default:
                    orderKey += "PictureStoreID desc";
                    break;

            }

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStore" + orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStore" + orderKey;
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStore pictureStore = new PictureStore();

                                pictureStore.PictureStoreID = int.Parse(sdr["PictureStoreID"].ToString());
                                pictureStore.PictureStoreName = sdr["PictureStoreName"].ToString();
                                pictureStore.PictureStoreRawUrl = sdr["PictureStoreRawUrl"].ToString();
                                pictureStore.PictureStoreLittleUrl = sdr["PictureStoreLittleUrl"].ToString();
                                pictureStore.PictureStoreTagIDs = sdr["PictureStoreTagIDs"].ToString();
                                pictureStore.PictureStoreHits = int.Parse(sdr["PictureStoreHits"].ToString());
                                pictureStore.PictureStoreDescription = sdr["PictureStoreDescription"].ToString();
                                pictureStore.PictureStoreHairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                                pictureStore.PictureStoreHairShopIDs = sdr["HairShopIDs"].ToString();
                                pictureStore.PictureStoreCreateTime = Convert.ToDateTime(sdr["PictureStoreCreateTime"].ToString());
                                pictureStore.PictureStoreGroupIDs = sdr["PictureStoreGroupIDs"].ToString();

                                list.Add(pictureStore);
                            }
                        }
                    }
                }
            }

            return list;
        }
        public List<PictureStore> GetPictureStores(int count, string pictureStoreGroupID)
        {
            List<PictureStore> list = new List<PictureStore>();


            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStore where PictureStoreGroupIDs ='"+pictureStoreGroupID+"' order by PictureStoreID Desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStore where PictureStoreGroupIDs ='" + pictureStoreGroupID + "' order by PictureStoreID desc";
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStore pictureStore = new PictureStore();

                                pictureStore.PictureStoreID = int.Parse(sdr["PictureStoreID"].ToString());
                                pictureStore.PictureStoreName = sdr["PictureStoreName"].ToString();
                                pictureStore.PictureStoreRawUrl = sdr["PictureStoreRawUrl"].ToString();
                                pictureStore.PictureStoreLittleUrl = sdr["PictureStoreLittleUrl"].ToString();
                                pictureStore.PictureStoreTagIDs = sdr["PictureStoreTagIDs"].ToString();
                                pictureStore.PictureStoreHits = int.Parse(sdr["PictureStoreHits"].ToString());
                                pictureStore.PictureStoreDescription = sdr["PictureStoreDescription"].ToString();
                                pictureStore.PictureStoreHairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                                pictureStore.PictureStoreHairShopIDs = sdr["HairShopIDs"].ToString();
                                pictureStore.PictureStoreCreateTime = Convert.ToDateTime(sdr["PictureStoreCreateTime"].ToString());
                                pictureStore.PictureStoreGroupIDs = sdr["PictureStoreGroupIDs"].ToString();

                                list.Add(pictureStore);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public List<PictureStore> GetPictureStores(int count, OrderKey ok, string pictureStoreName)
        {
            List<PictureStore> list = new List<PictureStore>();

            string orderKey = " order by ";
            switch (ok)
            {
                case OrderKey.ID:
                    orderKey += "PictureStoreID desc";
                    break;
                //case OrderKey.CommentNum:
                //评论数未作预处理，暂不实现
                //    orderKey += "he.HairEngineerGood+he.HairEngineerBad desc";
                //    break;
                case OrderKey.HitNum:
                    orderKey += "PictureStoreHits desc";
                    break;
                default:
                    orderKey += "PictureStoreID desc";
                    break;

            }

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStore where PictureStoreName like '%" + pictureStoreName + "%'" + orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStore where PictureStoreName like '%" + pictureStoreName + "%'" + orderKey;
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStore pictureStore = new PictureStore();

                                pictureStore.PictureStoreID = int.Parse(sdr["PictureStoreID"].ToString());
                                pictureStore.PictureStoreName = sdr["PictureStoreName"].ToString();
                                pictureStore.PictureStoreRawUrl = sdr["PictureStoreRawUrl"].ToString();
                                pictureStore.PictureStoreLittleUrl = sdr["PictureStoreLittleUrl"].ToString();
                                pictureStore.PictureStoreTagIDs = sdr["PictureStoreTagIDs"].ToString();
                                pictureStore.PictureStoreHits = int.Parse(sdr["PictureStoreHits"].ToString());
                                pictureStore.PictureStoreDescription = sdr["PictureStoreDescription"].ToString();
                                pictureStore.PictureStoreHairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                                pictureStore.PictureStoreHairShopIDs = sdr["HairShopIDs"].ToString();
                                pictureStore.PictureStoreCreateTime = Convert.ToDateTime(sdr["PictureStoreCreateTime"].ToString());
                                pictureStore.PictureStoreGroupIDs = sdr["PictureStoreGroupIDs"].ToString();

                                list.Add(pictureStore);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public PictureStoreRecommand GetPictureStoreRecommandByPictureStoreRecommandID(int pictureStoreRecommandID)
        {
            PictureStoreRecommand pictureStoreRecommand = new PictureStoreRecommand();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from PictureStoreRecommand psr inner join PictureStore ps on psr.PictureStoreRawID=ps.PictureStoreID where psr.PictureStoreRecommandID=" + pictureStoreRecommandID.ToString() + " order by psr.PictureStoreRecommandID desc";

                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commText;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            pictureStoreRecommand.PictureStoreRecommandID = int.Parse(sdr["PictureStoreRecommandID"].ToString());
                            pictureStoreRecommand.PictureStoreRawID = int.Parse(sdr["PictureStoreRawID"].ToString());
                            pictureStoreRecommand.PictureStoreName = sdr["PictureStoreName"].ToString();
                            pictureStoreRecommand.PictureStoreRawUrl = sdr["PictureStoreRawUrl"].ToString();
                            pictureStoreRecommand.PictureStoreLittleUrl = sdr["PictureStoreLittleUrl"].ToString();
                            pictureStoreRecommand.PictureStoreTagIDs = sdr["PictureStoreTagIDs"].ToString();
                            pictureStoreRecommand.PictureStoreHits = int.Parse(sdr["PictureStoreHits"].ToString());
                            pictureStoreRecommand.PictureStoreDescription = sdr["PictureStoreDescription"].ToString();
                            pictureStoreRecommand.PictureStoreHairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                            pictureStoreRecommand.PictureStoreHairShopIDs = sdr["HairShopIDs"].ToString();
                            pictureStoreRecommand.PictureStoreCreateTime = Convert.ToDateTime(sdr["PictureStoreCreateTime"].ToString());
                            pictureStoreRecommand.PictureStoreGroupIDs = sdr["PictureStoreGroupIDs"].ToString();
                            pictureStoreRecommand.PictureStoreRecommandEx = sdr["PictureStoreRecommandEx"].ToString();
                            pictureStoreRecommand.PictureStoreRecommandInfo = sdr["PictureStoreRecommandInfo"].ToString();
                        }
                    }
                }
            }

            return pictureStoreRecommand;
        }

        public List<PictureStoreRecommand> GetPictureStoreRecommands(int count)
        {
            List<PictureStoreRecommand> list = new List<PictureStoreRecommand>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStoreRecommand psr inner join PictureStore ps on psr.PictureStoreRawID=ps.PictureStoreID order by psr.PictureStoreRecommandID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStoreRecommand psr inner join PictureStore ps on psr.PictureStoreRawID=ps.PictureStoreID order by psr.PictureStoreRecommandID desc";
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStoreRecommand pictureStoreRecommand = new PictureStoreRecommand();

                                pictureStoreRecommand.PictureStoreRecommandID = int.Parse(sdr["PictureStoreRecommandID"].ToString());
                                pictureStoreRecommand.PictureStoreRawID = int.Parse(sdr["PictureStoreRawID"].ToString());
                                pictureStoreRecommand.PictureStoreName = sdr["PictureStoreName"].ToString();
                                pictureStoreRecommand.PictureStoreRawUrl = sdr["PictureStoreRawUrl"].ToString();
                                pictureStoreRecommand.PictureStoreLittleUrl = sdr["PictureStoreLittleUrl"].ToString();
                                pictureStoreRecommand.PictureStoreTagIDs = sdr["PictureStoreTagIDs"].ToString();
                                pictureStoreRecommand.PictureStoreHits = int.Parse(sdr["PictureStoreHits"].ToString());
                                pictureStoreRecommand.PictureStoreDescription = sdr["PictureStoreDescription"].ToString();
                                pictureStoreRecommand.PictureStoreHairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                                pictureStoreRecommand.PictureStoreHairShopIDs = sdr["HairShopIDs"].ToString();
                                pictureStoreRecommand.PictureStoreCreateTime = Convert.ToDateTime(sdr["PictureStoreCreateTime"].ToString());
                                pictureStoreRecommand.PictureStoreGroupIDs = sdr["PictureStoreGroupIDs"].ToString();
                                pictureStoreRecommand.PictureStoreRecommandEx = sdr["PictureStoreRecommandEx"].ToString();
                                pictureStoreRecommand.PictureStoreRecommandInfo = sdr["PictureStoreRecommandInfo"].ToString();

                                list.Add(pictureStoreRecommand);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public bool PictureStoreCommentCreateDeleteUpdate(PictureStoreComment pictureStoreComment, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into PictureStoreComment(PictureStoreCommentText,UserID,UserName,UserAddress,PictureStoreCommentCreateTime,PictureStoreID) values('" + pictureStoreComment.CommentText + "'," + pictureStoreComment.UserID.ToString() + ",'" + pictureStoreComment.UserName + "','" + pictureStoreComment.UserAddress + "','" + pictureStoreComment.CommentCreateTime.ToString() + "'," + pictureStoreComment.PictureStoreID.ToString() + ")";
                    break;
                case UserAction.Delete:
                    commandText = "delete from PictureStoreComment where PictureStoreCommentID = " + pictureStoreComment.CommentID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update PictureStoreComment set PictureStoreCommentText ='" + pictureStoreComment.CommentText + "',UserID=" + pictureStoreComment.UserID.ToString() + ",UserName='" + pictureStoreComment.UserName + "',UserAddress='" + pictureStoreComment.UserAddress + "',PictureStoreCommentCreateTime='" + pictureStoreComment.CommentCreateTime.ToString() + "',PictureStoreID=" + pictureStoreComment.PictureStoreID.ToString() + " where PictureStoreCommentID=" + pictureStoreComment.CommentID.ToString();
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

        public List<PictureStoreComment> GetPictureStoreCommentsByPictureStoreID(int pictureStoreID, int count, OrderKey ok)
        {
            List<PictureStoreComment> list = new List<PictureStoreComment>();

            string orderKey = " order by ";
            switch (ok)
            {
                //case OrderKey.Good:
                //    orderKey = "IsGood desc";
                //    break;
                case OrderKey.ID:
                    orderKey += "UserID desc";
                    break;
                case OrderKey.Time:
                    orderKey += "PictureStoreCommentCreateTime desc";
                    break;
                default:
                    orderKey += "PictureStoreCommentID desc";
                    break;
            }
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStoreComment where PictureStoreID=" + pictureStoreID.ToString() + orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStoreComment where PictureStoreID=" + pictureStoreID.ToString() + orderKey;
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStoreComment pictureStoreComment = new PictureStoreComment();

                                pictureStoreComment.CommentCreateTime = Convert.ToDateTime(sdr["PictureStoreCommentCreateTime"].ToString());
                                pictureStoreComment.CommentID = int.Parse(sdr["PictureStoreCommentID"].ToString());
                                pictureStoreComment.CommentText = sdr["PictureStoreCommentText"].ToString();
                                pictureStoreComment.PictureStoreID = int.Parse(sdr["PictureStoreID"].ToString());
                                pictureStoreComment.UserAddress = sdr["UserAddress"].ToString();
                                pictureStoreComment.UserID = int.Parse(sdr["UserID"].ToString());
                                pictureStoreComment.UserName = sdr["UserName"].ToString();

                                list.Add(pictureStoreComment);
                            }
                        }
                    }
                }
            }

            return list;
        }
        public List<PictureStoreComment> GetPictureStoreCommentsByUserID(int userID, int count, OrderKey ok)
        {
            List<PictureStoreComment> list = new List<PictureStoreComment>();

            string orderKey = " order by ";
            switch (ok)
            {
                //case OrderKey.Good:
                //    orderKey = "IsGood desc";
                //    break;
                case OrderKey.ID:
                    orderKey += "PictureStoreID desc";
                    break;
                case OrderKey.Time:
                    orderKey += "PictureStoreCommentCreateTime desc";
                    break;
                default:
                    orderKey += "PictureStoreCommentID desc";
                    break;
            }
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStoreComment where UserID=" + userID.ToString() + orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStoreComment where UserID=" + userID.ToString() + orderKey;
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStoreComment pictureStoreComment = new PictureStoreComment();

                                pictureStoreComment.CommentCreateTime = Convert.ToDateTime(sdr["PictureStoreCommentCreateTime"].ToString());
                                pictureStoreComment.CommentID = int.Parse(sdr["PictureStoreCommentID"].ToString());
                                pictureStoreComment.CommentText = sdr["PictureStoreCommentText"].ToString();
                                pictureStoreComment.PictureStoreID = int.Parse(sdr["PictureStoreID"].ToString());
                                pictureStoreComment.UserAddress = sdr["UserAddress"].ToString();
                                pictureStoreComment.UserID = int.Parse(sdr["UserID"].ToString());
                                pictureStoreComment.UserName = sdr["UserName"].ToString();

                                list.Add(pictureStoreComment);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public bool PictureStoreGroupCreateDeleteUpdate(PictureStoreGroup pictureStoreGroup, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into PictureStoreGroup(PictureStoreGroupName,PictureStoreGroupParentID,PictureStoreIDs) values('" + pictureStoreGroup.Name + "','" + pictureStoreGroup.PictureStoreGroupParentID + "','" + pictureStoreGroup.PictureStoreIDs + "')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from PictureStoreGroup where PictureStoreGroupID=" + pictureStoreGroup.ID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update PictureStoreGroup set PictureStoreGroupName='" + pictureStoreGroup.Name + "',PictureStoreGroupParentID='" + pictureStoreGroup.PictureStoreGroupParentID + "',PictureStoreIDs='" + pictureStoreGroup.PictureStoreIDs + "' where PictureStoreGroupID=" + pictureStoreGroup.ID.ToString();
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
        public List<PictureStoreGroup> GetPictureStoreGroups(int count)
        {
            List<PictureStoreGroup> list = new List<PictureStoreGroup>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStoreGroup order by PictureStoreGroupID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStoreGroup order by PictureStoreGroupID desc";
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStoreGroup pictureStoreGroup = new PictureStoreGroup();

                                pictureStoreGroup.ID = int.Parse(sdr["PictureStoreGroupID"].ToString());
                                pictureStoreGroup.Name = sdr["PictureStoreGroupName"].ToString();
                                pictureStoreGroup.PictureStoreGroupParentID = int.Parse(sdr["PictureStoreGroupParentID"].ToString());
                                pictureStoreGroup.PictureStoreIDs = sdr["PictureStoreIDs"].ToString();

                                list.Add(pictureStoreGroup);
                            }
                        }
                    }
                }
            }

            return list;
        }
        public PictureStoreGroup GetPictureStoreGroupByPictureStoreGroupID(int pictureStoreGroupID)
        {
            PictureStoreGroup pictureStoreGroup = new PictureStoreGroup();

            string commText = "select * from PictureStoreGroup where PictureStoreGroupID=" + pictureStoreGroupID.ToString();


            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commText;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                pictureStoreGroup.ID = int.Parse(sdr["PictureStoreGroupID"].ToString());
                                pictureStoreGroup.Name = sdr["PictureStoreGroupName"].ToString();
                                pictureStoreGroup.PictureStoreGroupParentID = int.Parse(sdr["PictureStoreGroupParentID"].ToString());
                                pictureStoreGroup.PictureStoreIDs = sdr["PictureStoreIDs"].ToString();
                            }
                        }
                    }
                }
            }

            return pictureStoreGroup;
        }
        public List<PictureStoreGroup> GetPictureStoreGroupsByParentID(int parentID, int count)
        {
            List<PictureStoreGroup> list = new List<PictureStoreGroup>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStoreGroup where PictureStoreGroupParentID=" + parentID.ToString() + " order by PictureStoreGroupID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStoreGroup where PictureStoreGroupParentID=" + parentID.ToString() + " order by PictureStoreGroupID desc";
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStoreGroup pictureStoreGroup = new PictureStoreGroup();

                                pictureStoreGroup.ID = int.Parse(sdr["PictureStoreGroupID"].ToString());
                                pictureStoreGroup.Name = sdr["PictureStoreGroupName"].ToString();
                                pictureStoreGroup.PictureStoreGroupParentID = int.Parse(sdr["PictureStoreGroupParentID"].ToString());
                                pictureStoreGroup.PictureStoreIDs = sdr["PictureStoreIDs"].ToString();

                                list.Add(pictureStoreGroup);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public bool PictureStoreTagCreateDeleteUpdate(PictureStoreTag pictureStoreTag, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into PictureStoreTag(PictureStoreTagName,PictureStoreIDs) values('" + pictureStoreTag.TagName + "','" + pictureStoreTag.PictureStoreIDs + "')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from PictureStoreTag where PictureStoreTagID=" + pictureStoreTag.TagID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update PictureStoreTag set PictureStoreTagName = '" + pictureStoreTag.TagName + "',PictureStoreIDs='" + pictureStoreTag.PictureStoreIDs + "' where PictureStoreTagID=" + pictureStoreTag.TagID.ToString();
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
        public List<PictureStoreTag> GetPictureStoreTags(int count)
        {
            List<PictureStoreTag> list = new List<PictureStoreTag>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStoreTag Order by PictureStoreTagID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStoreTag order by PictureStoreTagID desc";
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStoreTag pictureStoreTag = new PictureStoreTag();

                                pictureStoreTag.PictureStoreIDs = sdr["PictureStoreIDs"].ToString();
                                pictureStoreTag.TagID = int.Parse(sdr["PictureStoreTagID"].ToString());
                                pictureStoreTag.TagName = sdr["PictureStoreTagName"].ToString();

                                list.Add(pictureStoreTag);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public string GetPictureStoreTagIDs(string tagNames)
        {
            string[] tags = tagNames.Split(',');
            List<string> list = new List<string>();
            foreach (string tag in tags)
            {
                list.Add(this.AddPictureStoreTag(tag).ToString());
            }
            return string.Join(",", list.ToArray());
        }

        public string GetPictureStoreTagNames(string tagIDs)
        {
            string[] IDs = tagIDs.Split(',');
            List<string> list = new List<string>();
            foreach (string id in IDs)
            {
                list.Add(this.GetPictureStoreTagByPictureStoreTagID(int.Parse(id)).TagName);
            }
            return string.Join(",", list.ToArray());
        }

        private int AddPictureStoreTag(string name)
        {
            int TagID = 0;

            string strsql = "select PictureStoreTagID from PictureStoreTag where PictureStoreTagName='" + name + "'";
            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(strsql, conn))
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        TagID = dr.GetInt32(0);
                    }
                    else
                    {
                        dr.Close();
                        strsql = "insert into PictureStoreTag(PictureStoreTagName,PictureStoreIDs) values('" + name + "','');select @@identity as 'id';";
                        cmd.CommandText = strsql;
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            TagID = int.Parse(dr[0].ToString());
                        }
                        dr.Close();
                    }
                    dr.Dispose();
                    dr = null;
                    conn.Close();
                }
            }
            return TagID;
        }

        public int AddPictureStore(PictureStore ps)
        {
            int bReturn = 0;
            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                //using (SqlDataAdapter adapter = new SqlDataAdapter("select top 1 * from picturestore", conn))
                //{
                string strsql = "insert into picturestore(PictureStoreName,PictureStoreRawUrl,PictureStoreLittleUrl,PictureStoreTagIDs,PictureStoreHits,PictureStoreGroupIDs,PictureStoreDescription,PictureStoreCreateTime) values('" + ps.PictureStoreName + "','" + ps.PictureStoreRawUrl + "','" + ps.PictureStoreLittleUrl + "','" + ps.PictureStoreTagIDs + "'," + ps.PictureStoreHits + ",'" + ps.PictureStoreGroupIDs + "','" + ps.PictureStoreDescription + "','" + ps.PictureStoreCreateTime.ToString("G") + "');select @@identity;";
                SqlCommand cmd = new SqlCommand(strsql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    bReturn = int.Parse(dr[0].ToString());
                }
                dr.Close();
                conn.Close();
                cmd.Dispose();
                cmd = null;
            }

            return bReturn;
        }

        public PictureStoreTag GetPictureStoreTagByPictureStoreTagID(int pictureStoreTagID)
        {
            PictureStoreTag pictureStoreTag = new PictureStoreTag();

            string commText = "select * from PictureStoreTag where PictureStoreTagID=" + pictureStoreTagID.ToString();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commText;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                pictureStoreTag.PictureStoreIDs = sdr["PictureStoreIDs"].ToString();
                                pictureStoreTag.TagID = int.Parse(sdr["PictureStoreTagID"].ToString());
                                pictureStoreTag.TagName = sdr["PictureStoreTagName"].ToString();
                            }
                        }
                    }
                }
            }

            return pictureStoreTag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<PictureStoreComment> GetPictureStoreComments(int count)
        {
            List<PictureStoreComment> list = new List<PictureStoreComment>();

            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStoreComment order by PictureStoreCommentID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStoreComment order by PictureStoreCommentID desc";
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStoreComment pictureStoreComment = new PictureStoreComment();

                                pictureStoreComment.CommentCreateTime = Convert.ToDateTime(sdr["PictureStoreCommentCreateTime"].ToString());
                                pictureStoreComment.CommentID = int.Parse(sdr["PictureStoreCommentID"].ToString());
                                pictureStoreComment.CommentText = sdr["PictureStoreCommentText"].ToString();
                                pictureStoreComment.PictureStoreID = int.Parse(sdr["PictureStoreID"].ToString());
                                pictureStoreComment.UserAddress = sdr["UserAddress"].ToString();
                                pictureStoreComment.UserID = int.Parse(sdr["UserID"].ToString());
                                pictureStoreComment.UserName = sdr["UserName"].ToString();

                                list.Add(pictureStoreComment);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<PictureStoreComment> GetPictureStoreCommentsByKeyText(int count, string keyText)
        {
            List<PictureStoreComment> list = new List<PictureStoreComment>();

            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStoreComment where PictureStoreCommentText like '%" + keyText + "%' order by PictureStoreCommentID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStoreComment where PictureStoreCommentText like '%" + keyText + "%' order by PictureStoreCommentID desc";
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStoreComment pictureStoreComment = new PictureStoreComment();

                                pictureStoreComment.CommentCreateTime = Convert.ToDateTime(sdr["PictureStoreCommentCreateTime"].ToString());
                                pictureStoreComment.CommentID = int.Parse(sdr["PictureStoreCommentID"].ToString());
                                pictureStoreComment.CommentText = sdr["PictureStoreCommentText"].ToString();
                                pictureStoreComment.PictureStoreID = int.Parse(sdr["PictureStoreID"].ToString());
                                pictureStoreComment.UserAddress = sdr["UserAddress"].ToString();
                                pictureStoreComment.UserID = int.Parse(sdr["UserID"].ToString());
                                pictureStoreComment.UserName = sdr["UserName"].ToString();

                                list.Add(pictureStoreComment);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="sTime"></param>
        /// <param name="eTime"></param>
        /// <returns></returns>
        public List<PictureStoreComment> GetPictureStoreCommentsByTimeZone(int count, string sTime, string eTime)
        {
            List<PictureStoreComment> list = new List<PictureStoreComment>();

            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStoreComment where PictureStoreCommentCreateTime<'" + eTime + "' and PictureStoreCommentCreateTime >'" + sTime + "' order by PictureStoreCommentID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from PictureStoreComment where PictureStoreCommentCreateTime<'" + eTime + "' and PictureStoreCommentCreateTime >'" + sTime + "' order by PictureStoreCommentID desc";
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

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                PictureStoreComment pictureStoreComment = new PictureStoreComment();

                                pictureStoreComment.CommentCreateTime = Convert.ToDateTime(sdr["PictureStoreCommentCreateTime"].ToString());
                                pictureStoreComment.CommentID = int.Parse(sdr["PictureStoreCommentID"].ToString());
                                pictureStoreComment.CommentText = sdr["PictureStoreCommentText"].ToString();
                                pictureStoreComment.PictureStoreID = int.Parse(sdr["PictureStoreID"].ToString());
                                pictureStoreComment.UserAddress = sdr["UserAddress"].ToString();
                                pictureStoreComment.UserID = int.Parse(sdr["UserID"].ToString());
                                pictureStoreComment.UserName = sdr["UserName"].ToString();

                                list.Add(pictureStoreComment);
                            }
                        }
                    }
                }
            }

            return list;
        }
    }
}
