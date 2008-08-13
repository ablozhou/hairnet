using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;
using System.Data.SqlClient;

namespace HairNet.Provider
{
    public class PictureStoreDataProviderInstance:IPictureStoreDataProvider
    {
        public bool PictureStoreCreateDeleteUpdate(PictureStore pictureStore, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into PictureStore(PictureStoreName,PictureStoreRawUrl,PictureStoreLittleUrl,PictureStoreTagIDs,PictureStoreDescription,HairEngineerIDs,HairShopIDs,PictureStoreCreateTime,PictureStoreGroupIDs) values('"+pictureStore.PictureStoreName+"','"+pictureStore.PictureStoreRawUrl+"','"+pictureStore.PictureStoreLittleUrl+"','"+pictureStore.PictureStoreTagIDs+"','"+pictureStore.PictureStoreDescription+"','"+pictureStore.PictureStoreHairEngineerIDs+"','"+pictureStore.PictureStoreHairShopIDs+"','"+pictureStore.PictureStoreCreateTime.ToString()+"','"+pictureStore.PictureStoreGroupIDs+"')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from PictureStore where PictureStoreID="+pictureStore.PictureStoreID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update PictureStore set PictureStoreName = '"+pictureStore.PictureStoreName+"',PictureStoreRawUrl = '"+pictureStore.PictureStoreRawUrl+"',PictureStoreLittleUrl='"+pictureStore.PictureStoreLittleUrl+"',PictureStoreTagIDs='"+pictureStore.PictureStoreTagIDs+"',PictureStoreDescription='"+pictureStore.PictureStoreDescription+"',HairEngineerIDs='"+pictureStore.PictureStoreHairEngineerIDs+"',HairShopIDs='"+pictureStore.PictureStoreHairShopIDs+"',PictureStoreCreateTime='"+pictureStore.PictureStoreCreateTime.ToString()+"',PictureStoreGroupIDs='"+pictureStore.PictureStoreGroupIDs+"' where PictureStoreID="+pictureStore.PictureStoreID.ToString();
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
                    commandText = "insert into PictureStoreRecommand(PictureStoreRawID,PictureStoreName,PictureStoreRawUrl,PictureStoreLittleUrl,PictureStoreTagIDs,PictureStoreDescription,HairEngineerIDs,HairShopIDs,PictureStoreCreateTime,PictureStoreGroupIDs,PictureStoreRecommandEx,PictureStoreRecommandInfo) values("+pictureStoreRecommand.PictureStoreRawID.ToString()+",'"+pictureStoreRecommand.PictureStoreName+"','"+pictureStoreRecommand.PictureStoreRawUrl+"','"+pictureStoreRecommand.PictureStoreLittleUrl+"','"+pictureStoreRecommand.PictureStoreTagIDs+"','"+pictureStoreRecommand.PictureStoreDescription+"','"+pictureStoreRecommand.PictureStoreHairEngineerIDs+"','"+pictureStoreRecommand.PictureStoreHairShopIDs+"','"+pictureStoreRecommand.PictureStoreCreateTime.ToString()+"','"+pictureStoreRecommand.PictureStoreGroupIDs+"','"+pictureStoreRecommand.PictureStoreRecommandEx+"','"+pictureStoreRecommand.PictureStoreRecommandInfo+"')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from PictureStoreRecommand from PictureStoreRecommandID="+pictureStoreRecommand.PictureStoreRecommandID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update PictureStoreRecommand set PictureStoreRawID="+pictureStoreRecommand.PictureStoreRawID.ToString()+",PictureStoreName = '"+pictureStoreRecommand.PictureStoreName+"',PictureStoreRawUrl = '"+pictureStoreRecommand.PictureStoreRawUrl+"',PictureStoreLittleUrl='"+pictureStoreRecommand.PictureStoreLittleUrl+"',PictureStoreTagIDs='"+pictureStoreRecommand.PictureStoreTagIDs+"',PictureStoreDescription='"+pictureStoreRecommand.PictureStoreDescription+"',HairEngineerIDs='"+pictureStoreRecommand.PictureStoreHairEngineerIDs+"',HairShopIDs='"+pictureStoreRecommand.PictureStoreHairShopIDs+"',PictureStoreCreateTime='"+pictureStoreRecommand.PictureStoreCreateTime.ToString()+"',PictureStoreGroupIDs='"+pictureStoreRecommand.PictureStoreGroupIDs+"',PictureStoreRecommandEx='"+pictureStoreRecommand.PictureStoreRecommandEx+"',PictureStoreRecommandInfo='"+pictureStoreRecommand.PictureStoreRecommandInfo+"' where PictureStoreRecommandID="+pictureStoreRecommand.PictureStoreRecommandID.ToString();
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
                string commText = "select * from PictureStore where PictureStoreID="+pictureStoreID.ToString()+" order by PictureStoreID desc";

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

        public List<PictureStore> GetPictureStores(int count)
        {
            List<PictureStore> list = new List<PictureStore>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from PictureStore order by PictureStoreID desc";
                    break;
                default:
                    commText = "select top "+count.ToString()+" * from PictureStore order by PictureStoreID desc";
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
                string commText = "select * from PictureStoreRecommand psr inner join PictureStore ps on psr.PictureStoreRawID=ps.PictureStoreID where psr.PictureStoreRecommandID=" + pictureStoreRecommandID.ToString()+ " order by psr.PictureStoreRecommandID desc";

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
                    commText = "select top "+count.ToString()+" * from PictureStoreRecommand psr inner join PictureStore ps on psr.PictureStoreRawID=ps.PictureStoreID order by psr.PictureStoreRecommandID desc";
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
            return result;
        }

        public List<PictureStoreComment> GetPictureStoreCommentsByPictureStoreID(int pictureStoreID, int count, string orderKey)
        {
            List<PictureStoreComment> list = new List<PictureStoreComment>();
            return list;
        }
        public List<PictureStoreComment> GetPictureStoreCommentsByUserID(int userID, int count, string orderKey)
        {
            List<PictureStoreComment> list = new List<PictureStoreComment>();
            return list;
        }

        public bool PictureStoreGroupCreateDeleteUpdate(PictureStoreGroup pictureStoreGroup, UserAction ua)
        {
            bool result = false;
            return result;
        }
        public List<PictureStoreGroup> GetPictureStoreGroups(int count)
        {
            List<PictureStoreGroup> list = new List<PictureStoreGroup>();
            return list;
        }
        public PictureStoreGroup GetPictureStoreGroupByPictureStoreGroupID(int pictureStoreGroupID)
        {
            PictureStoreGroup pictureStoreGroup = new PictureStoreGroup();
            return pictureStoreGroup;
        }
        public List<PictureStoreGroup> GetPictureStoreGroupsByParentID(int parentID, int count)
        {
            List<PictureStoreGroup> list = new List<PictureStoreGroup>();
            return list;
        }

        public bool PictureStoreTagCreateDeleteUpdate(PictureStoreTag pictureStoreTag, UserAction ua)
        {
            bool result = false;
            return result;
        }
        public List<PictureStoreTag> GetPictureStoreTags(int count)
        {
            List<PictureStoreTag> pictureStoreTag = new List<PictureStoreTag>();
            return pictureStoreTag;
        }
        public PictureStoreTag GetPictureStoreTagByPictureStoreTagID(int pictureStoreTagID)
        {
            PictureStoreTag pictureStoreTag = new PictureStoreTag();
            return pictureStoreTag;
        }
    }
}
