using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public class HairEngineerDataProviderInstance : IHairEngineerDataProvider
    {
        /// <summary>
        /// ����ʦ
        /// </summary>
        /// <param name="hairEngineer"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairEngineerCreateDeleteUpdate(HairEngineer hairEngineer, UserAction ua,out int hairEngineerID)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairEngineer(HairEngineerAge,HairEngineerName,HairEngineerSex,HairEngineerPhoto,HairShopID,HairEngineerYear,HairEngineerSkill,HairEngineerTagIDs,HairEngineerPictureStoreIDs,HairEngineerDescription,HairEngineerRawPrice,HairEngineerPrice,HairEngineerClassID) values('"+hairEngineer.HairEngineerAge+"','"+hairEngineer.HairEngineerName+"',"+hairEngineer.HairEngineerSex.ToString()+",'"+hairEngineer.HairEngineerPhoto+"',"+hairEngineer.HairShopID.ToString()+",'"+hairEngineer.HairEngineerYear+"','"+hairEngineer.HairEngineerSkill+"','"+hairEngineer.HairEngineerTagIDs+"','"+hairEngineer.HairEngineerPictureStoreIDs+"','"+hairEngineer.HairEngineerDescription+"','"+hairEngineer.HairEngineerRawPrice+"','"+hairEngineer.HairEngineerPrice+"',"+hairEngineer.HairEngineerClassID.ToString()+")";
                    commandText += ";select @@identity;";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairEngineer where HairEngineerID="+hairEngineer.HairEngineerID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairEngineer set HairEngineerAge='"+hairEngineer.HairEngineerAge+"',HairEngineerName='"+hairEngineer.HairEngineerName+"',HairEngineerSex="+hairEngineer.HairEngineerSex.ToString()+",HairEngineerPhoto='"+hairEngineer.HairEngineerPhoto+"',HairShopID="+hairEngineer.HairShopID.ToString()+",HairEngineerYear='"+hairEngineer.HairEngineerYear+"',HairEngineerSkill='"+hairEngineer.HairEngineerSkill+"',HairEngineerTagIDs='"+hairEngineer.HairEngineerTagIDs+"',HairEngineerPictureStoreIDs='"+hairEngineer.HairEngineerPictureStoreIDs+"',HairEngineerDescription='"+hairEngineer.HairEngineerDescription+"',HairEngineerRawPrice='"+hairEngineer.HairEngineerRawPrice+"',HairEngineerPrice='"+hairEngineer.HairEngineerPrice+"',HairEngineerClassID="+hairEngineer.HairEngineerClassID.ToString()+" where HairEngineerID = "+hairEngineer.HairEngineerID.ToString();
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
                        try
                        {
                            hairEngineerID = Convert.ToInt32(comm.ExecuteScalar());
                        }
                        catch (InvalidCastException)
                        {
                            hairEngineerID = 0;
                        }
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
                    commandText = "delete from HairEngineerRecommand where HairEngineerRawID=" + hairEngineer.HairEngineerID.ToString();
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
        /// ����ʦ�Ƽ�
        /// </summary>
        /// <param name="hairEngineerRecommand"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairEngineerRecommandCreateDeleteUpdate(HairEngineerRecommand hairEngineerRecommand, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairEngineerRecommand(HairEngineerRawID,HairEngineerAge,HairEngineerName,HairEngineerSex,HairEngineerPhoto,HairShopID,HairEngineerYear,HairEngineerSkill,HairEngineerTagIDs,HairEngineerPictureStoreIDs,HairEngineerDescription,HairEngineerRawPrice,HairEngineerPrice,HairEngineerClassID,HairEngineerRecommandEx,HairEngineerRecommandInfo) values(" + hairEngineerRecommand.HairEngineerRawID.ToString() + ",'" + hairEngineerRecommand.HairEngineerAge + "','" + hairEngineerRecommand.HairEngineerName + "'," + hairEngineerRecommand.HairEngineerSex.ToString() + ",'" + hairEngineerRecommand.HairEngineerPhoto + "'," + hairEngineerRecommand.HairShopID.ToString() + ",'" + hairEngineerRecommand.HairEngineerYear + "','" + hairEngineerRecommand.HairEngineerSkill + "','" + hairEngineerRecommand.HairEngineerTagIDs + "','" + hairEngineerRecommand.HairEngineerPictureStoreIDs + "','" + hairEngineerRecommand.HairEngineerDescription + "','" + hairEngineerRecommand.HairEngineerRawPrice + "','" + hairEngineerRecommand.HairEngineerPrice + "'," + hairEngineerRecommand.HairEngineerClassID.ToString() + ",'"+hairEngineerRecommand.HairEngineerRecommandEx+"','"+hairEngineerRecommand.HairEngineerRecommandInfo+"')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairEngineerRecommand where HairEngineerRecommandID=" + hairEngineerRecommand.HairEngineerRecommandID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairEngineerRecommand set HairEngineerRawID=" + hairEngineerRecommand.HairEngineerRawID.ToString() + ",HairEngineerAge='" + hairEngineerRecommand.HairEngineerAge + "',HairEngineerName='" + hairEngineerRecommand.HairEngineerName + "',HairEngineerSex=" + hairEngineerRecommand.HairEngineerSex.ToString() + ",HairEngineerPhoto='" + hairEngineerRecommand.HairEngineerPhoto + "',HairShopID=" + hairEngineerRecommand.HairShopID.ToString() + ",HairEngineerYear='" + hairEngineerRecommand.HairEngineerYear + "',HairEngineerSkill='" + hairEngineerRecommand.HairEngineerSkill + "',HairEngineerTagIDs='" + hairEngineerRecommand.HairEngineerTagIDs + "',HairEngineerPictureStoreIDs='" + hairEngineerRecommand.HairEngineerPictureStoreIDs + "',HairEngineerDescription='" + hairEngineerRecommand.HairEngineerDescription + "',HairEngineerRawPrice='" + hairEngineerRecommand.HairEngineerRawPrice + "',HairEngineerPrice='" + hairEngineerRecommand.HairEngineerPrice + "',HairEngineerClassID=" + hairEngineerRecommand.HairEngineerClassID.ToString() + ",HairEngineerRecommandEx='"+hairEngineerRecommand.HairEngineerRecommandEx+"',HairEngineerRecommandInfo='"+hairEngineerRecommand.HairEngineerRecommandInfo+"' where HairEngineerRecommandID = " + hairEngineerRecommand.HairEngineerRecommandID.ToString();
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
        /// <summary>
        /// ͨ������ʦID����ȡ����ʦʵ��
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <returns></returns>
        public HairEngineer GetHairEngineerByHairEngineerID(int hairEngineerID)
        {
            HairEngineer hairEngineer = new HairEngineer();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from HairEngineer he inner join HairEngineerClass hec on he.HairEngineerClassID = hec.HairEngineerClassID inner join HairShop hs on hs.HairShopID = he.HairShopID where he.HairEngineerID=" + hairEngineerID.ToString()+" order by he.HairEngineerID desc";
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commText;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                hairEngineer.HairEngineerID = int.Parse(sdr["HairEngineerID"].ToString());
                                hairEngineer.HairEngineerAge = sdr["HairEngineerAge"].ToString();
                                hairEngineer.HairEngineerName = sdr["HairEngineerName"].ToString();
                                hairEngineer.HairEngineerSex = int.Parse(sdr["HairEngineerSex"].ToString());
                                hairEngineer.HairEngineerPhoto = sdr["HairEngineerPhoto"].ToString();
                                hairEngineer.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairEngineer.HairShopName = sdr["HairShopName"].ToString();
                                hairEngineer.HairEngineerYear = sdr["HairEngineerYear"].ToString();
                                hairEngineer.HairEngineerSkill = sdr["HairEngineerSkill"].ToString();
                                hairEngineer.HairEngineerTagIDs = sdr["HairEngineerTagIDs"].ToString();
                                hairEngineer.HairEngineerPictureStoreIDs = sdr["HairEngineerPictureStoreIDs"].ToString();
                                hairEngineer.HairEngineerHits = int.Parse(sdr["HairEngineerHits"].ToString());
                                hairEngineer.HairEngineerDescription = sdr["HairEngineerDescription"].ToString();
                                hairEngineer.HairEngineerOrderNum = int.Parse(sdr["HairEngineerOrderNum"].ToString());
                                hairEngineer.HairEngineerRecommandNum = int.Parse(sdr["HairEngineerRecommandNum"].ToString());
                                hairEngineer.HairEngineerRawPrice = sdr["HairEngineerRawPrice"].ToString();
                                hairEngineer.HairEngineerPrice = sdr["HairEngineerPrice"].ToString();
                                hairEngineer.HairEngineerGood = int.Parse(sdr["HairEngineerGood"].ToString());
                                hairEngineer.HairEngineerBad = int.Parse(sdr["HairEngineerBad"].ToString());
                                hairEngineer.HairEngineerClassID = int.Parse(sdr["HairEngineerClassID"].ToString());
                                hairEngineer.HairEngineerClassName = sdr["HairEngineerClassName"].ToString();
                            }
                        }
                    }
                }

            }
            return hairEngineer;
        }

        /// <summary>
        /// ��ȡ����ʦ
        /// </summary>
        /// <param name="count">0 ����</param>
        /// <returns></returns>
        public List<HairEngineer> GetHairEngineers(int count,OrderKey ok)
        {
            List<HairEngineer> list = new List<HairEngineer>();

            string orderKey = " order by ";
            switch (ok)
            {
                case OrderKey.ID:
                    orderKey += "he.HairEngineerID desc";
                    break;
                case OrderKey.CommentNum:
                    orderKey += "he.HairEngineerGood+he.HairEngineerBad desc";
                    break;
                case OrderKey.RecommandNum:
                    orderKey += "he.HairEngineerRecommandNum desc";
                    break;
                case OrderKey.HitNum:
                    orderKey += "he.HairEngineerHits desc";
                    break;
                case OrderKey.OrderNum:
                    orderKey += "he.HairEngineerOrderNum desc";
                    break;
                default:
                    orderKey += "he.HairEngineerID desc";
                    break;

            }

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineer he inner join HairEngineerClass hec on he.HairEngineerClassID = hec.HairEngineerClassID inner join HairShop hs on hs.HairShopID = he.HairShopID"+orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairEngineer he inner join HairEngineerClass hec on he.HairEngineerClassID = hec.HairEngineerClassID inner join HairShop hs on hs.HairShopID = he.HairShopID" + orderKey;
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
                                HairEngineer hairEngineer = new HairEngineer();

                                hairEngineer.HairEngineerID = int.Parse(sdr["HairEngineerID"].ToString());
                                hairEngineer.HairEngineerAge = sdr["HairEngineerAge"].ToString();
                                hairEngineer.HairEngineerName = sdr["HairEngineerName"].ToString();
                                hairEngineer.HairEngineerSex = int.Parse(sdr["HairEngineerSex"].ToString());
                                hairEngineer.HairEngineerPhoto = sdr["HairEngineerPhoto"].ToString();
                                hairEngineer.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairEngineer.HairShopName = sdr["HairShopName"].ToString();
                                hairEngineer.HairEngineerYear = sdr["HairEngineerYear"].ToString();
                                hairEngineer.HairEngineerSkill = sdr["HairEngineerSkill"].ToString();
                                hairEngineer.HairEngineerTagIDs = sdr["HairEngineerTagIDs"].ToString();
                                hairEngineer.HairEngineerPictureStoreIDs = sdr["HairEngineerPictureStoreIDs"].ToString();
                                hairEngineer.HairEngineerHits = int.Parse(sdr["HairEngineerHits"].ToString());
                                hairEngineer.HairEngineerDescription = sdr["HairEngineerDescription"].ToString();
                                hairEngineer.HairEngineerOrderNum = int.Parse(sdr["HairEngineerOrderNum"].ToString());
                                hairEngineer.HairEngineerRecommandNum = int.Parse(sdr["HairEngineerRecommandNum"].ToString());
                                hairEngineer.HairEngineerRawPrice = sdr["HairEngineerRawPrice"].ToString();
                                hairEngineer.HairEngineerPrice = sdr["HairEngineerPrice"].ToString();
                                hairEngineer.HairEngineerGood = int.Parse(sdr["HairEngineerGood"].ToString());
                                hairEngineer.HairEngineerBad = int.Parse(sdr["HairEngineerBad"].ToString());
                                hairEngineer.HairEngineerClassID = int.Parse(sdr["HairEngineerClassID"].ToString());
                                hairEngineer.HairEngineerClassName = sdr["HairEngineerClassName"].ToString();

                                list.Add(hairEngineer);
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
        /// <param name="ok"></param>
        /// <param name="hairEngineerName"></param>
        /// <returns></returns>
        public List<HairEngineer> GetHairEngineers(int count, OrderKey ok,string hairEngineerName)
        {
            List<HairEngineer> list = new List<HairEngineer>();

            string orderKey = " order by ";
            switch (ok)
            {
                case OrderKey.ID:
                    orderKey += "he.HairEngineerID desc";
                    break;
                case OrderKey.CommentNum:
                    orderKey += "he.HairEngineerGood+he.HairEngineerBad desc";
                    break;
                case OrderKey.RecommandNum:
                    orderKey += "he.HairEngineerRecommandNum desc";
                    break;
                case OrderKey.HitNum:
                    orderKey += "he.HairEngineerHits desc";
                    break;
                case OrderKey.OrderNum:
                    orderKey += "he.HairEngineerOrderNum desc";
                    break;
                default:
                    orderKey += "he.HairEngineerID desc";
                    break;

            }

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineer he inner join HairEngineerClass hec on he.HairEngineerClassID = hec.HairEngineerClassID inner join HairShop hs on hs.HairShopID = he.HairShopID where he.HairEngineerName like '%"+hairEngineerName.ToString()+"%'" + orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairEngineer he inner join HairEngineerClass hec on he.HairEngineerClassID = hec.HairEngineerClassID inner join HairShop hs on hs.HairShopID = he.HairShopID where he.HairEngineerName like '%" + hairEngineerName.ToString() + "%'" + orderKey;
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
                                HairEngineer hairEngineer = new HairEngineer();

                                hairEngineer.HairEngineerID = int.Parse(sdr["HairEngineerID"].ToString());
                                hairEngineer.HairEngineerAge = sdr["HairEngineerAge"].ToString();
                                hairEngineer.HairEngineerName = sdr["HairEngineerName"].ToString();
                                hairEngineer.HairEngineerSex = int.Parse(sdr["HairEngineerSex"].ToString());
                                hairEngineer.HairEngineerPhoto = sdr["HairEngineerPhoto"].ToString();
                                hairEngineer.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairEngineer.HairShopName = sdr["HairShopName"].ToString();
                                hairEngineer.HairEngineerYear = sdr["HairEngineerYear"].ToString();
                                hairEngineer.HairEngineerSkill = sdr["HairEngineerSkill"].ToString();
                                hairEngineer.HairEngineerTagIDs = sdr["HairEngineerTagIDs"].ToString();
                                hairEngineer.HairEngineerPictureStoreIDs = sdr["HairEngineerPictureStoreIDs"].ToString();
                                hairEngineer.HairEngineerHits = int.Parse(sdr["HairEngineerHits"].ToString());
                                hairEngineer.HairEngineerDescription = sdr["HairEngineerDescription"].ToString();
                                hairEngineer.HairEngineerOrderNum = int.Parse(sdr["HairEngineerOrderNum"].ToString());
                                hairEngineer.HairEngineerRecommandNum = int.Parse(sdr["HairEngineerRecommandNum"].ToString());
                                hairEngineer.HairEngineerRawPrice = sdr["HairEngineerRawPrice"].ToString();
                                hairEngineer.HairEngineerPrice = sdr["HairEngineerPrice"].ToString();
                                hairEngineer.HairEngineerGood = int.Parse(sdr["HairEngineerGood"].ToString());
                                hairEngineer.HairEngineerBad = int.Parse(sdr["HairEngineerBad"].ToString());
                                hairEngineer.HairEngineerClassID = int.Parse(sdr["HairEngineerClassID"].ToString());
                                hairEngineer.HairEngineerClassName = sdr["HairEngineerClassName"].ToString();

                                list.Add(hairEngineer);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// ͨ������ʦ�Ƽ�ID����ȡ����ʦ�Ƽ�ʵ��
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <returns></returns>
        public HairEngineerRecommand GetHairEngineerRecommandByHairEngineerRecommandID(int hairEngineerRecommandID)
        {
            HairEngineerRecommand hairEngineerRecommand = new HairEngineerRecommand();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from HairEngineerRecommand her inner join HairEngineer he on her.HairEngineerRawID = he.HairEngineerID inner join HairShop hs on her.HairShopID = hs.HairShopID inner join HairEngineerClass hec on her.HairEngineerClassID = hec.HairEngineerClassID where her.HairEngineerRecommandID =" + hairEngineerRecommandID.ToString() + " order by her.HairEngineerRecommandID desc";
                
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commText;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            hairEngineerRecommand.HairEngineerRecommandID = int.Parse(sdr["HairEngineerRecommandID"].ToString());
                            hairEngineerRecommand.HairEngineerRawID = int.Parse(sdr["HairEngineerRawID"].ToString());
                            hairEngineerRecommand.HairEngineerAge = sdr["HairEngineerAge"].ToString();
                            hairEngineerRecommand.HairEngineerName = sdr["HairEngineerName"].ToString();
                            hairEngineerRecommand.HairEngineerSex = int.Parse(sdr["HairEngineerSex"].ToString());
                            hairEngineerRecommand.HairEngineerPhoto = sdr["HairEngineerPhoto"].ToString();
                            hairEngineerRecommand.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                            hairEngineerRecommand.HairShopName = sdr["HairShopName"].ToString();
                            hairEngineerRecommand.HairEngineerYear = sdr["HairEngineerYear"].ToString();
                            hairEngineerRecommand.HairEngineerSkill = sdr["HairEngineerSkill"].ToString();
                            hairEngineerRecommand.HairEngineerTagIDs = sdr["HairEngineerTagIDs"].ToString();
                            hairEngineerRecommand.HairEngineerPictureStoreIDs = sdr["HairEngineerPictureStoreIDs"].ToString();
                            hairEngineerRecommand.HairEngineerHits = int.Parse(sdr["HairEngineerHits"].ToString());
                            hairEngineerRecommand.HairEngineerDescription = sdr["HairEngineerDescription"].ToString();
                            hairEngineerRecommand.HairEngineerOrderNum = int.Parse(sdr["HairEngineerOrderNum"].ToString());
                            hairEngineerRecommand.HairEngineerRecommandNum = int.Parse(sdr["HairEngineerRecommandNum"].ToString());
                            hairEngineerRecommand.HairEngineerRawPrice = sdr["HairEngineerRawPrice"].ToString();
                            hairEngineerRecommand.HairEngineerPrice = sdr["HairEngineerPrice"].ToString();
                            hairEngineerRecommand.HairEngineerGood = int.Parse(sdr["HairEngineerGood"].ToString());
                            hairEngineerRecommand.HairEngineerBad = int.Parse(sdr["HairEngineerBad"].ToString());
                            hairEngineerRecommand.HairEngineerClassID = int.Parse(sdr["HairEngineerClassID"].ToString());
                            hairEngineerRecommand.HairEngineerClassName = sdr["HairEngineerClassName"].ToString();
                            hairEngineerRecommand.HairEngineerRecommandEx = sdr["HairEngineerRecommandEx"].ToString();
                            hairEngineerRecommand.HairEngineerRecommandInfo = sdr["HairEngineerRecommandInfo"].ToString();
                        }
                    }
                }
            }

            return hairEngineerRecommand;
        }

        /// <summary>
        /// ��ȡ����ʦ�Ƽ�
        /// </summary>
        /// <param name="count">0 ����</param>
        /// <returns></returns>
        public List<HairEngineerRecommand> GetHairEngineerRecommands(int count)
        {
            List<HairEngineerRecommand> list = new List<HairEngineerRecommand>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineerRecommand her inner join HairEngineer he on her.HairEngineerRawID = he.HairEngineerID inner join HairShop hs on her.HairShopID = hs.HairShopID inner join HairEngineerClass hec on her.HairEngineerClassID = hec.HairEngineerClassID order by her.HairEngineerRecommandID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairEngineerRecommand her inner join HairEngineer he on her.HairEngineerRawID = he.HairEngineerID inner join HairShop hs on her.HairShopID = hs.HairShopID inner join HairEngineerClass hec on her.HairEngineerClassID = hec.HairEngineerClassID order by her.HairEngineerRecommandID desc";
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
                                HairEngineerRecommand hairEngineerRecommand = new HairEngineerRecommand();

                                hairEngineerRecommand.HairEngineerRecommandID = int.Parse(sdr["HairEngineerRecommandID"].ToString());
                                hairEngineerRecommand.HairEngineerRawID = int.Parse(sdr["HairEngineerRawID"].ToString());
                                hairEngineerRecommand.HairEngineerAge = sdr["HairEngineerAge"].ToString();
                                hairEngineerRecommand.HairEngineerName = sdr["HairEngineerName"].ToString();
                                hairEngineerRecommand.HairEngineerSex = int.Parse(sdr["HairEngineerSex"].ToString());
                                hairEngineerRecommand.HairEngineerPhoto = sdr["HairEngineerPhoto"].ToString();
                                hairEngineerRecommand.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairEngineerRecommand.HairShopName = sdr["HairShopName"].ToString();
                                hairEngineerRecommand.HairEngineerYear = sdr["HairEngineerYear"].ToString();
                                hairEngineerRecommand.HairEngineerSkill = sdr["HairEngineerSkill"].ToString();
                                hairEngineerRecommand.HairEngineerTagIDs = sdr["HairEngineerTagIDs"].ToString();
                                hairEngineerRecommand.HairEngineerPictureStoreIDs = sdr["HairEngineerPictureStoreIDs"].ToString();
                                hairEngineerRecommand.HairEngineerHits = int.Parse(sdr["HairEngineerHits"].ToString());
                                hairEngineerRecommand.HairEngineerDescription = sdr["HairEngineerDescription"].ToString();
                                hairEngineerRecommand.HairEngineerOrderNum = int.Parse(sdr["HairEngineerOrderNum"].ToString());
                                hairEngineerRecommand.HairEngineerRecommandNum = int.Parse(sdr["HairEngineerRecommandNum"].ToString());
                                hairEngineerRecommand.HairEngineerRawPrice = sdr["HairEngineerRawPrice"].ToString();
                                hairEngineerRecommand.HairEngineerPrice = sdr["HairEngineerPrice"].ToString();
                                hairEngineerRecommand.HairEngineerGood = int.Parse(sdr["HairEngineerGood"].ToString());
                                hairEngineerRecommand.HairEngineerBad = int.Parse(sdr["HairEngineerBad"].ToString());
                                hairEngineerRecommand.HairEngineerClassID = int.Parse(sdr["HairEngineerClassID"].ToString());
                                hairEngineerRecommand.HairEngineerClassName = sdr["HairEngineerClassName"].ToString();
                                hairEngineerRecommand.HairEngineerRecommandEx = sdr["HairEngineerRecommandEx"].ToString();
                                hairEngineerRecommand.HairEngineerRecommandInfo = sdr["HairEngineerRecommandInfo"].ToString();

                                list.Add(hairEngineerRecommand);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// �������ʦ����б�
        /// </summary>
        /// <returns></returns>
        public List<HairEngineerClass> GetHairEngineerClasses()
        {
            List<HairEngineerClass> list = new List<HairEngineerClass>();

            string commText = "select * from HairEngineerClass order by HairEngineerClassID ASC";

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
                                HairEngineerClass hairEngineerClass = new HairEngineerClass();

                                hairEngineerClass.ID = int.Parse(sdr["HairEngineerClassID"].ToString());
                                hairEngineerClass.IsVisible = Convert.ToBoolean(sdr["HairEngineerClassVisible"].ToString());
                                hairEngineerClass.Name = sdr["HairEngineerClassName"].ToString();

                                list.Add(hairEngineerClass);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// ����ʦ��� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hairEngineerClass"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairEngineerClassCreateDeleteUpdate(HairEngineerClass hairEngineerClass, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairEngineerClass(HairEngineerClassName,HairEngineerClassVisible) values('"+hairEngineerClass.Name+"','"+hairEngineerClass.IsVisible.CompareTo(false).ToString()+"')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairEngineerClass where HairEngineerClassID="+hairEngineerClass.ID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairEngineerClass set HairEngineerClassName='"+hairEngineerClass.Name+"',HairEngineerClassVisible='"+hairEngineerClass.IsVisible.CompareTo(false).ToString()+"' where HairEngineerClassID="+hairEngineerClass.ID.ToString();
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

        /// <summary>
        /// ��ȡ����ʦTAG�б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairEngineerTag> GetHairEngineerTags(int count)
        {
            List<HairEngineerTag> list = new List<HairEngineerTag>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineerTag Order by HairEngineerTagID desc";
                    break;
                default:
                    commText = "select top "+count.ToString()+" * from HairEngineerTag order by HairEngineerTagID desc";
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
                                HairEngineerTag hairEngineerTag = new HairEngineerTag();

                                hairEngineerTag.HairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                                hairEngineerTag.TagID = int.Parse(sdr["HairEngineerTagID"].ToString());
                                hairEngineerTag.TagName = sdr["HairEngineerTagName"].ToString();

                                list.Add(hairEngineerTag);
                            }
                        }
                    }
                }
            }

            return list;
        }

        public string GetHairEngineerTagIDs(string tagNames)
        {
            string[] tags = tagNames.Split(',');
            List<string> list = new List<string>();
            foreach (string tag in tags)
            {
                list.Add(this.AddHairEngineerTag(tag).ToString());
            }
            return string.Join(",", list.ToArray());
        }

        private int AddHairEngineerTag(string name)
        {
            int TagID = 0;

            string strsql = "select HairEngineerTagID from HairEngineerTag where HairEngineerTagName='" + name + "'";
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
                        strsql = "insert into HairEngineerTag(HairEngineerTagName,HairEngineerIDs) values('" + name + "','');select @@identity as 'id';";
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

        /// <summary>
        /// �������ʦTAGʵ��
        /// </summary>
        /// <param name="hairEngineerTagID"></param>
        /// <returns></returns>
        public HairEngineerTag GetHairEngineerTagByHairEngineerTagID(int hairEngineerTagID)
        {
            HairEngineerTag hairEngineerTag = new HairEngineerTag();

            string commText = "select * from HairEngineerTag where HairEngineerTagID = " + hairEngineerTagID.ToString();

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
                                hairEngineerTag.HairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                                hairEngineerTag.TagID = int.Parse(sdr["HairEngineerTagID"].ToString());
                                hairEngineerTag.TagName = sdr["HairEngineerTagName"].ToString();
                            }
                        }
                    }
                }
            }

            return hairEngineerTag;
        }

        public string GetHairEngineerTagNames(string tagIDs)
        {
            string[] ids = tagIDs.Split(',');
            List<string> list = new List<string>();
            foreach (string id in ids)
            {
                list.Add(this.GetHairEngineerTagByHairEngineerTagID(int.Parse(id)).TagName);
            }
            return string.Join(",", list.ToArray());
        }

        /// <summary>
        /// ����ʦTAG ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hairEngineerTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairEngineerTagCreateDeleteUpdate(HairEngineerTag hairEngineerTag, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairEngineerTag(HairEngineerTagName,HairEngineerIDs) values('"+hairEngineerTag.TagName+"','"+hairEngineerTag.HairEngineerIDs+"')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairEngineerTag where HairEngineerTagID="+hairEngineerTag.TagID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairEngineerTag set HairEngineerTagName = '"+hairEngineerTag.TagName+"',HairEngineerIDs='"+hairEngineerTag.HairEngineerIDs+"' where HairEngineerTagID="+hairEngineerTag.TagID.ToString();
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

        /// <summary>
        /// ��ȡ����ʦ�����б�
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">����KEY ����ʱ�����򣬰��պ������򣬰����û�ID����</param>
        /// <returns></returns>
        public List<HairEngineerComment> GetHairEngineerCommentsByHairEngineerID(int hairEngineerID, int count, OrderKey ok)
        {
            List<HairEngineerComment> list = new List<HairEngineerComment>();

            string orderKey = " order by ";
            switch (ok)
            {
                case OrderKey.Good:
                    orderKey += "IsGood desc";
                    break;
                case OrderKey.ID:
                    orderKey += "UserID desc";
                    break;
                case OrderKey.Time:
                    orderKey += "HairEngineerCommentCreateTime desc";
                    break;
                default:
                    orderKey += "HairEngineerCommentID desc";
                    break;
            }
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineerComment where HairEngineerID="+hairEngineerID.ToString()+orderKey;
                    break;
                default:
                    commText = "select top "+count.ToString()+" * from HairEngineerComment where HairEngineerID=" + hairEngineerID.ToString() + orderKey;
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
                                HairEngineerComment hairEngineerComment = new HairEngineerComment();

                                hairEngineerComment.CommentCreateTime = Convert.ToDateTime(sdr["HairEngineerCommentCreateTime"].ToString());
                                hairEngineerComment.CommentID = int.Parse(sdr["HairEngineerCommentID"].ToString());
                                hairEngineerComment.CommentText = sdr["HairEngineerCommentText"].ToString();
                                hairEngineerComment.HairEngineerID = int.Parse(sdr["HairEngineerID"].ToString());
                                hairEngineerComment.UserAddress = sdr["UserAddress"].ToString();
                                hairEngineerComment.UserID = int.Parse(sdr["UserID"].ToString());
                                hairEngineerComment.UserName = sdr["UserName"].ToString();
                                hairEngineerComment.IsGood = Convert.ToBoolean(sdr["IsGood"].ToString());

                                list.Add(hairEngineerComment);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// ��ȡ����ʦ�����б�
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">����KEY ����ʱ�����򣬰��պ������򣬰�������ʦ����</param>
        /// <returns></returns>
        public List<HairEngineerComment> GetHairEngineerCommentsByUserID(int userID, int count, OrderKey ok)
        {
            List<HairEngineerComment> list = new List<HairEngineerComment>();

            string orderKey = " order by ";
            switch (ok)
            {
                case OrderKey.Good:
                    orderKey += "IsGood desc";
                    break;
                case OrderKey.ID:
                    orderKey += "HairEngineerID desc";
                    break;
                case OrderKey.Time:
                    orderKey += "HairEngineerCommentCreateTime desc";
                    break;
                default:
                    orderKey += "HairEngineerCommentID desc";
                    break;
            }
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineerComment where UserID=" + userID.ToString() + orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairEngineerComment where UserID=" + userID.ToString() + orderKey;
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
                                HairEngineerComment hairEngineerComment = new HairEngineerComment();

                                hairEngineerComment.CommentCreateTime = Convert.ToDateTime(sdr["HairEngineerCommentCreateTime"].ToString());
                                hairEngineerComment.CommentID = int.Parse(sdr["HairEngineerCommentID"].ToString());
                                hairEngineerComment.CommentText = sdr["HairEngineerCommentText"].ToString();
                                hairEngineerComment.HairEngineerID = int.Parse(sdr["HairEngineerID"].ToString());
                                hairEngineerComment.UserAddress = sdr["UserAddress"].ToString();
                                hairEngineerComment.UserID = int.Parse(sdr["UserID"].ToString());
                                hairEngineerComment.UserName = sdr["UserName"].ToString();
                                hairEngineerComment.IsGood = Convert.ToBoolean(sdr["IsGood"].ToString());

                                list.Add(hairEngineerComment);
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
        public List<HairEngineerComment> GetHairEngineerComments(int count)
        {
            List<HairEngineerComment> list = new List<HairEngineerComment>();

                        
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineerComment order by HairEngineerCommentID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairEngineerComment order by HairEngineerCommentID desc";
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
                                HairEngineerComment hairEngineerComment = new HairEngineerComment();

                                hairEngineerComment.CommentCreateTime = Convert.ToDateTime(sdr["HairEngineerCommentCreateTime"].ToString());
                                hairEngineerComment.CommentID = int.Parse(sdr["HairEngineerCommentID"].ToString());
                                hairEngineerComment.CommentText = sdr["HairEngineerCommentText"].ToString();
                                hairEngineerComment.HairEngineerID = int.Parse(sdr["HairEngineerID"].ToString());
                                hairEngineerComment.UserAddress = sdr["UserAddress"].ToString();
                                hairEngineerComment.UserID = int.Parse(sdr["UserID"].ToString());
                                hairEngineerComment.UserName = sdr["UserName"].ToString();
                                hairEngineerComment.IsGood = Convert.ToBoolean(sdr["IsGood"].ToString());

                                list.Add(hairEngineerComment);
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
        /// <param name="keyText"></param>
        /// <returns></returns>
        public List<HairEngineerComment> GetHairEngineerCommentsByKeyText(int count,string keyText)
        {
            List<HairEngineerComment> list = new List<HairEngineerComment>();


            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineerComment where HairEngineerCommentText like '%"+keyText+"%' order by HairEngineerCommentID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairEngineerComment where HairEngineerCommentText like '%" + keyText + "%' order by HairEngineerCommentID desc";
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
                                HairEngineerComment hairEngineerComment = new HairEngineerComment();

                                hairEngineerComment.CommentCreateTime = Convert.ToDateTime(sdr["HairEngineerCommentCreateTime"].ToString());
                                hairEngineerComment.CommentID = int.Parse(sdr["HairEngineerCommentID"].ToString());
                                hairEngineerComment.CommentText = sdr["HairEngineerCommentText"].ToString();
                                hairEngineerComment.HairEngineerID = int.Parse(sdr["HairEngineerID"].ToString());
                                hairEngineerComment.UserAddress = sdr["UserAddress"].ToString();
                                hairEngineerComment.UserID = int.Parse(sdr["UserID"].ToString());
                                hairEngineerComment.UserName = sdr["UserName"].ToString();
                                hairEngineerComment.IsGood = Convert.ToBoolean(sdr["IsGood"].ToString());

                                list.Add(hairEngineerComment);
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
        public List<HairEngineerComment> GetHairEngineerCommentsByTimeZone(int count, string sTime, string eTime)
        {
            List<HairEngineerComment> list = new List<HairEngineerComment>();


            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineerComment where HairEngineerCommentCreateTime > '"+sTime+"' and HairEngineerCommentCreateTime<'"+eTime+"' order by HairEngineerCommentID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairEngineerComment where HairEngineerCommentCreateTime > '" + sTime + "' and HairEngineerCommentCreateTime<'" + eTime + "' order by HairEngineerCommentID desc";
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
                                HairEngineerComment hairEngineerComment = new HairEngineerComment();

                                hairEngineerComment.CommentCreateTime = Convert.ToDateTime(sdr["HairEngineerCommentCreateTime"].ToString());
                                hairEngineerComment.CommentID = int.Parse(sdr["HairEngineerCommentID"].ToString());
                                hairEngineerComment.CommentText = sdr["HairEngineerCommentText"].ToString();
                                hairEngineerComment.HairEngineerID = int.Parse(sdr["HairEngineerID"].ToString());
                                hairEngineerComment.UserAddress = sdr["UserAddress"].ToString();
                                hairEngineerComment.UserID = int.Parse(sdr["UserID"].ToString());
                                hairEngineerComment.UserName = sdr["UserName"].ToString();
                                hairEngineerComment.IsGood = Convert.ToBoolean(sdr["IsGood"].ToString());

                                list.Add(hairEngineerComment);
                            }
                        }
                    }
                }
            }

            return list;
        }
        /// <summary>
        /// ��ȡ����ʦ�����б�
        /// </summary>
        /// <param name="hairEngineerComment"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairEngineerCommentCreateDeleteUpdate(HairEngineerComment hairEngineerComment, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairEngineerComment(HairEngineerCommentText,UserID,UserName,UserAddress,IsGood,HairEngineerCommentCreateTime,HairEngineerID) values('"+hairEngineerComment.CommentText+"',"+hairEngineerComment.UserID.ToString()+",'"+hairEngineerComment.UserName+"','"+hairEngineerComment.UserAddress+"',"+hairEngineerComment.IsGood.CompareTo(false).ToString()+",'"+hairEngineerComment.CommentCreateTime.ToString()+"',"+hairEngineerComment.HairEngineerID.ToString()+")";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairEngineerComment where HairEngineerCommentID = "+hairEngineerComment.CommentID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairEngineerComment set HairEngineerCommentText ='"+hairEngineerComment.CommentText+"',UserID="+hairEngineerComment.UserID.ToString()+",UserName='"+hairEngineerComment.UserName+"',UserAddress='"+hairEngineerComment.UserAddress+"',IsGood="+hairEngineerComment.IsGood.CompareTo(false).ToString()+",HairEngineerCommentCreateTime='"+hairEngineerComment.CommentCreateTime.ToString()+"',HairEngineerID="+hairEngineerComment.HairEngineerID.ToString()+" where HairEngineerCommentID="+hairEngineerComment.CommentID.ToString();
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
    }
}
