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
        /// 美发师
        /// </summary>
        /// <param name="hairEngineer"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairEngineerCreateDeleteUpdate(HairEngineer hairEngineer, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairEngineer(HairEngineerAge,HairEngineerName,HairEngineerSex,HairEngineerPhoto,HairShopID,HairEngineerYear,HairEngineerSkill,HairEngineerTagIDs,HairEngineerPictureStoreIDs,HairEngineerDescription,HairEngineerRawPrice,HairEngineerPrice,HairEngineerClassID) values('"+hairEngineer.HairEngineerAge+"','"+hairEngineer.HairEngineerName+"',"+hairEngineer.HairEngineerSex.ToString()+",'"+hairEngineer.HairEngineerPhoto+"',"+hairEngineer.HairShopID.ToString()+",'"+hairEngineer.HairEngineerYear+"','"+hairEngineer.HairEngineerSkill+"','"+hairEngineer.HairEngineerTagIDs+"','"+hairEngineer.HairEngineerPictureStoreIDs+"','"+hairEngineer.HairEngineerDescription+"','"+hairEngineer.HairEngineerRawPrice+"','"+hairEngineer.HairEngineerPrice+"',"+hairEngineer.HairEngineerClassID.ToString()+")";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairEngineer where HairEngineerID="+hairEngineer.HairEngineerID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairEngineer set HairEngineerAge='"+hairEngineer.HairEngineerAge+"',HairEngineerName='"+hairEngineer.HairEngineerName+"',HairEngineerSex="+hairEngineer.HairEngineerSex.ToString()+",HairEngineerPhoto='"+hairEngineer.HairEngineerPhoto+"',HairShopID="+hairEngineer.HairEngineerID.ToString()+",HairEngineerYear='"+hairEngineer.HairEngineerYear+"',HairEngineerSkill='"+hairEngineer.HairEngineerSkill+"',HairEngineerTagIDs='"+hairEngineer.HairEngineerTagIDs+"',HairEngineerPictureStoreIDs='"+hairEngineer.HairEngineerPictureStoreIDs+"',HairEngineerDescription='"+hairEngineer.HairEngineerDescription+"',HairEngineerRawPrice='"+hairEngineer.HairEngineerRawPrice+"',HairEngineerPrice='"+hairEngineer.HairEngineerPrice+"',HairEngineerClassID="+hairEngineer.HairEngineerClassID.ToString()+" where HairEngineerID = "+hairEngineer.HairEngineerID.ToString();
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
        /// 美发师推荐
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
        /// 通过美发师ID来获取美发师实体
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <returns></returns>
        public HairEngineer GetHairEngineerByHairEngineerID(int hairEngineerID)
        {
            HairEngineer hairEngineer = new HairEngineer();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from HairEngineer he inner join HairEngineerClass hec on he.HairEngineerClassID = hec.HairEngineerClassID inner join HairShop hs on hs.HairShopID = he.HairShopID where he.HairEngineerID=" + hairEngineerID.ToString();
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
        /// 获取美发师
        /// </summary>
        /// <param name="count">0 所有</param>
        /// <returns></returns>
        public List<HairEngineer> GetHairEngineers(int count)
        {
            List<HairEngineer> list = new List<HairEngineer>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineer he inner join HairEngineerClass hec on he.HairEngineerClassID = hec.HairEngineerClassID inner join HairShop hs on hs.HairShopID = he.HairShopID";
                    break;
                default:
                    commText = "select top "+count.ToString()+" * from HairEngineer he inner join HairEngineerClass hec on he.HairEngineerClassID = hec.HairEngineerClassID inner join HairShop hs on hs.HairShopID = he.HairShopID";
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
        /// 通过美发师推荐ID来获取美发师推荐实体
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <returns></returns>
        public HairEngineerRecommand GetHairEngineerRecommandByHairEngineerRecommandID(int hairEngineerRecommandID)
        {
            HairEngineerRecommand hairEngineerRecommand = new HairEngineerRecommand();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from HairEngineerRecommand her inner join HairEngineer he on her.HairEngineerRawID = he.HairEngineerID inner join HairShop hs on her.HairShopID = hs.HairShopID inner join HairEngineerClass hec on her.HairEngineerClassID = hec.HairEngineerClassID where her.HairEngineerRecommandID =" + hairEngineerRecommandID.ToString();
                
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
        /// 获取美发师推荐
        /// </summary>
        /// <param name="count">0 所有</param>
        /// <returns></returns>
        public List<HairEngineerRecommand> GetHairEngineerRecommands(int count)
        {
            List<HairEngineerRecommand> list = new List<HairEngineerRecommand>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairEngineerRecommand her inner join HairEngineer he on her.HairEngineerRawID = he.HairEngineerID inner join HairShop hs on her.HairShopID = hs.HairShopID inner join HairEngineerClass hec on her.HairEngineerClassID = hec.HairEngineerClassID";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairEngineerRecommand her inner join HairEngineer he on her.HairEngineerRawID = he.HairEngineerID inner join HairShop hs on her.HairShopID = hs.HairShopID inner join HairEngineerClass hec on her.HairEngineerClassID = hec.HairEngineerClassID";
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
    }
}
