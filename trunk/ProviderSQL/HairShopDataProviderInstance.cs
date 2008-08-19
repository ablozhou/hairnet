using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;
using System.Data.SqlClient;

namespace HairNet.Provider
{
    public class HairShopDataProviderInstance : IHairShopDataProvider
    {
        /// <summary>
        /// 美发厅
        /// </summary>
        /// <param name="hairShop"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairShopDataPrividerCreateDeleteUpdate(HairShop hairShop, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairShop(HairShopName,HairShopCityID,HairShopMapZoneID,HairShopHotZoneID,HairShopAddress,HairShopPhoneNum,HairShopPictureStoreIDs,HairShopMainIDs,HairShopPartialIDs,HairShopEngineerNum,HairShopOpenTime,WorkRangeIDs,HairShopWebSite,HairShopEmail,HairShopDiscount,HairShopLogo,HairShopCreateTime,HairShopDescription,ProductIDs,HairShopTagIDs,HairShopShortName,IsBest,IsJoin,TypeID,IsPostStation,IsPostMachine) values('" + hairShop.HairShopName + "'," + hairShop.HairShopCityID.ToString() + "," + hairShop.HairShopMapZoneID.ToString() + "," + hairShop.HairShopHotZoneID.ToString() + ",'" + hairShop.HairShopAddress + "','" + hairShop.HairShopPhoneNum + "','" + hairShop.HairShopPictureStoreIDs + "','" + hairShop.HairShopMainIDs + "','" + hairShop.HairShopPartialIDs + "'," + hairShop.HairShopEngineerNum.ToString() + ",'" + hairShop.HairShopOpenTime + "','" + hairShop.WorkRangeIDs + "','" + hairShop.HairShopWebSite + "','" + hairShop.HairShopEmail + "','" + hairShop.HairShopDiscount + "','" + hairShop.HairShopLogo + "','" + hairShop.HairShopCreateTime + "','" + hairShop.HairShopDescription + "','" + hairShop.ProductIDs + "','" + hairShop.HairShopTagIDs + "','" + hairShop.HairShopShortName + "'," + hairShop.IsBest.CompareTo(false).ToString() + "," + hairShop.IsJoin.CompareTo(false).ToString() + "," + hairShop.TypeID.ToString() + "," + hairShop.IsPostStation.CompareTo(false).ToString() + "," + hairShop.IsPostMachine.CompareTo(false).ToString() + ")";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairShop where HairShopID="+hairShop.HairShopID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairShop set HairShopName='" + hairShop.HairShopName + "',HairShopCityID=" + hairShop.HairShopCityID.ToString() + ",HairShopMapZoneID=" + hairShop.HairShopMapZoneID.ToString() + ",HairShopHotZoneID=" + hairShop.HairShopHotZoneID.ToString() + ",HairShopAddress='" + hairShop.HairShopAddress + "',HairShopPhoneNum='" + hairShop.HairShopPhoneNum + "',HairShopPictureStoreIDs='" + hairShop.HairShopPictureStoreIDs + "',HairShopMainIDs='" + hairShop.HairShopMainIDs + "',HairShopPartialIDs='" + hairShop.HairShopPartialIDs + "',HairShopEngineerNum=" + hairShop.HairShopEngineerNum.ToString() + ",HairShopOpenTime='" + hairShop.HairShopOpenTime + "',WorkRangeIDs='" + hairShop.WorkRangeIDs + "',HairShopWebSite='" + hairShop.HairShopWebSite + "',HairShopEmail='" + hairShop.HairShopEmail + "',HairShopDiscount='" + hairShop.HairShopDiscount + "',HairShopLogo='" + hairShop.HairShopLogo + "',HairShopCreateTime='" + hairShop.HairShopCreateTime + "',HairShopDescription='" + hairShop.HairShopDescription + "',ProductIDs='" + hairShop.ProductIDs + "',HairShopTagIDs='" + hairShop.HairShopTagIDs + "',HairShopShortName='" + hairShop.HairShopShortName + "',IsBest=" + hairShop.IsBest.CompareTo(false).ToString() + ",IsJoin=" + hairShop.IsJoin.CompareTo(false).ToString() + ",TypeID=" + hairShop.TypeID.ToString() + ",IsPostStation=" + hairShop.IsPostStation.CompareTo(false).ToString() + ",IsPostMachine=" + hairShop.IsPostMachine.CompareTo(false).ToString() + " where HairShopID = " + hairShop.HairShopID.ToString();
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
                    catch(Exception ex)
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
                    commandText = "delete from HairShopRecommand where HairShopRawID=" + hairShop.HairShopID.ToString();
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
        /// 美发厅推荐
        /// </summary>
        /// <param name="hairShopRecommand"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairShopRecommandCreateDeleteUpdate(HairShopRecommand hairShopRecommand, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairShopRecommand(HairShopRawID,HairShopName,HairShopCityID,HairShopMapZoneID,HairShopHotZoneID,HairShopAddress,HairShopPhoneNum,HairShopPictureStoreIDs,HairShopMainIDs,HairShopPartialIDs,HairShopEngineerNum,HairShopOpenTime,WorkRangeIDs,HairShopWebSite,HairShopEmail,HairShopDiscount,HairShopLogo,HairShopCreateTime,HairShopDescription,ProductIDs,HairShopTagIDs,HairShopShortName,IsBest,IsJoin,TypeID,IsPostStation,IsPostMachine,HairShopRecommandEx,HairShopRecommandInfo) values(" + hairShopRecommand.HairShopRawID.ToString() + ",'" + hairShopRecommand.HairShopName + "'," + hairShopRecommand.HairShopCityID.ToString() + "," + hairShopRecommand.HairShopMapZoneID.ToString() + "," + hairShopRecommand.HairShopHotZoneID.ToString() + ",'" + hairShopRecommand.HairShopAddress + "','" + hairShopRecommand.HairShopPhoneNum + "','" + hairShopRecommand.HairShopPictureStoreIDs + "','" + hairShopRecommand.HairShopMainIDs + "','" + hairShopRecommand.HairShopPartialIDs + "'," + hairShopRecommand.HairShopEngineerNum.ToString() + ",'" + hairShopRecommand.HairShopOpenTime + "','" + hairShopRecommand.WorkRangeIDs + "','" + hairShopRecommand.HairShopWebSite + "','" + hairShopRecommand.HairShopEmail + "','" + hairShopRecommand.HairShopDiscount + "','" + hairShopRecommand.HairShopLogo + "','" + hairShopRecommand.HairShopCreateTime + "','" + hairShopRecommand.HairShopDescription + "','" + hairShopRecommand.ProductIDs + "','" + hairShopRecommand.HairShopTagIDs + "','" + hairShopRecommand.HairShopShortName + "'," + hairShopRecommand.IsBest.CompareTo(false).ToString() + "," + hairShopRecommand.IsJoin.CompareTo(false).ToString() + "," + hairShopRecommand.TypeID.ToString() + "," + hairShopRecommand.IsPostStation.CompareTo(false).ToString() + "," + hairShopRecommand.IsPostMachine.CompareTo(false).ToString() + ",'" + hairShopRecommand.HairShopRecommandEx + "','" + hairShopRecommand.HairShopRecommandInfo + "')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairShopRecommand where HairShopRecommandID=" + hairShopRecommand.HairShopRecommandID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairShopRecommand set HairShopRawID="+hairShopRecommand.HairShopRawID.ToString()+",HairShopName='" + hairShopRecommand.HairShopName + "',HairShopCityID=" + hairShopRecommand.HairShopCityID.ToString() + ",HairShopMapZoneID=" + hairShopRecommand.HairShopMapZoneID.ToString() + ",HairShopHotZoneID=" + hairShopRecommand.HairShopHotZoneID.ToString() + ",HairShopAddress='" + hairShopRecommand.HairShopAddress + "',HairShopPhoneNum='" + hairShopRecommand.HairShopPhoneNum + "',HairShopPictureStoreIDs='" + hairShopRecommand.HairShopPictureStoreIDs + "',HairShopMainIDs='" + hairShopRecommand.HairShopMainIDs + "',HairShopPartialIDs='" + hairShopRecommand.HairShopPartialIDs + "',HairShopEngineerNum=" + hairShopRecommand.HairShopEngineerNum.ToString() + ",HairShopOpenTime='" + hairShopRecommand.HairShopOpenTime + "',WorkRangeIDs='" + hairShopRecommand.WorkRangeIDs + "',HairShopWebSite='" + hairShopRecommand.HairShopWebSite + "',HairShopEmail='" + hairShopRecommand.HairShopEmail + "',HairShopDiscount='" + hairShopRecommand.HairShopDiscount + "',HairShopLogo='" + hairShopRecommand.HairShopLogo + "',HairShopCreateTime='" + hairShopRecommand.HairShopCreateTime + "',HairShopDescription='" + hairShopRecommand.HairShopDescription + "',ProductIDs='" + hairShopRecommand.ProductIDs + "',HairShopTagIDs='" + hairShopRecommand.HairShopTagIDs + "',HairShopShortName='" + hairShopRecommand.HairShopShortName + "',IsBest=" + hairShopRecommand.IsBest.CompareTo(false).ToString() + ",IsJoin=" + hairShopRecommand.IsJoin.CompareTo(false).ToString() + ",TypeID=" + hairShopRecommand.TypeID.ToString() + ",IsPostStation=" + hairShopRecommand.IsPostStation.CompareTo(false).ToString() + ",IsPostMachine=" + hairShopRecommand.IsPostMachine.CompareTo(false).ToString() + ",HairShopRecommandEx='"+hairShopRecommand.HairShopRecommandEx+"',HairShopRecommandInfo='"+hairShopRecommand.HairShopRecommandInfo+"' where HairShopRecommandID = " + hairShopRecommand.HairShopRecommandID.ToString();
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
        /// 通过美发厅ID获得美发厅实体
        /// </summary>
        /// <param name="hairShopID"></param>
        /// <returns></returns>
        public HairShop GetHairShopByHairShopID(int hairShopID)
        {
            HairShop hairShop = new HairShop();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from HairShop hs inner join City c on hs.HairShopCityID=c.cityID inner join MapZone m on hs.HairShopMapZoneID = m.MapZoneID inner join HotZone h on hs.HairShopHotZoneID = h.HotZoneID inner join TypeTable tt on hs.TypeID=tt.TypeID where hs.HairShopID = " + hairShopID.ToString();

                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commText;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            hairShop.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                            hairShop.HairShopName = sdr["HairShopName"].ToString();
                            hairShop.HairShopCityID = int.Parse(sdr["HairShopCityID"].ToString());
                            hairShop.HairShopCityName = sdr["CityName"].ToString();
                            hairShop.HairShopMapZoneID = int.Parse(sdr["HairShopMapZoneID"].ToString());
                            hairShop.HairShopMapZoneName = sdr["MapZoneName"].ToString();
                            hairShop.HairShopHotZoneID = int.Parse(sdr["HairShopHotZoneID"].ToString());
                            hairShop.HairShopHotZoneName = sdr["HotZoneName"].ToString();
                            hairShop.HairShopAddress = sdr["HairShopAddress"].ToString();
                            hairShop.HairShopPhoneNum = sdr["HairShopPhoneNum"].ToString();
                            hairShop.HairShopPictureStoreIDs = sdr["HairShopPictureStoreIDs"].ToString();
                            hairShop.HairShopMainIDs = sdr["HairShopMainIDs"].ToString();
                            hairShop.HairShopPartialIDs = sdr["HairShopPartialIDs"].ToString();
                            hairShop.HairShopEngineerNum = int.Parse(sdr["HairShopEngineerNum"].ToString());
                            hairShop.HairShopOpenTime = sdr["HairShopOpenTime"].ToString();
                            hairShop.HairShopOrderNum = int.Parse(sdr["HairShopOrderNum"].ToString());
                            hairShop.HairShopVisitNum = int.Parse(sdr["HairShopVisitNum"].ToString());
                            hairShop.WorkRangeIDs = sdr["WorkRangeIDs"].ToString();
                            hairShop.HairShopWebSite = sdr["HairShopWebSite"].ToString();
                            hairShop.HairShopEmail = sdr["HairShopEmail"].ToString();
                            hairShop.HairShopDiscount = sdr["HairShopDiscount"].ToString();
                            hairShop.HairShopLogo = sdr["HairShopLogo"].ToString();
                            hairShop.HairShopRecommandNum = int.Parse(sdr["HairShopRecommandNum"].ToString());
                            hairShop.HairShopCreateTime = sdr["HairShopCreateTime"].ToString();
                            hairShop.HairShopDescription = sdr["HairShopDescription"].ToString();
                            hairShop.ProductIDs = sdr["ProductIDs"].ToString();
                            hairShop.HairShopTagIDs = sdr["HairShopTagIDs"].ToString();
                            hairShop.HairShopShortName = sdr["HairShopShortName"].ToString();
                            hairShop.IsBest = bool.Parse(sdr["IsBest"].ToString());
                            hairShop.IsJoin = bool.Parse(sdr["IsJoin"].ToString());
                            hairShop.TypeID = int.Parse(sdr["TypeID"].ToString());
                            hairShop.TypeName = sdr["TypeName"].ToString();
                            hairShop.IsPostStation = bool.Parse(sdr["IsPostStation"].ToString());
                            hairShop.IsPostMachine = bool.Parse(sdr["IsPostMachine"].ToString());
                            hairShop.HairShopGood = int.Parse(sdr["HairShopGood"].ToString());
                            hairShop.HairShopBad = int.Parse(sdr["HairShopBad"].ToString());
                        }
                    }
                }
            }

            return hairShop;
        }

        /// <summary>
        /// 获得美发厅
        /// </summary>
        /// <param name="count">0 全部</param>
        /// <returns></returns>
        public List<HairShop> GetHairShops(int count,OrderKey ok)
        {
            List<HairShop> list = new List<HairShop>();

            string orderKey = " order by ";
            switch (ok)
            {
                case OrderKey.ID:
                    orderKey += "hs.HairShopID desc";
                    break;
                case OrderKey.CommentNum:
                    orderKey += "hs.HairShopGood+hs.HairShopBad desc";
                    break;
                case OrderKey.RecommandNum:
                    orderKey += "hs.HairShopRecommandNum desc";
                    break;
                case OrderKey.HitNum:
                    orderKey += "hs.HairShopVisitNum desc";
                    break;
                case OrderKey.OrderNum:
                    orderKey += "hs.HairShopOrderNum desc";
                    break;
                default:
                    orderKey += "hs.HairShopID desc";
                    break;

            }

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairShop hs inner join City c on hs.HairShopCityID=c.cityID inner join MapZone m on hs.HairShopMapZoneID = m.MapZoneID inner join HotZone h on hs.HairShopHotZoneID = h.HotZoneID inner join TypeTable tt on hs.TypeID=tt.TypeID"+orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShop hs inner join City c on hs.HairShopCityID=c.cityID inner join MapZone m on hs.HairShopMapZoneID = m.MapZoneID inner join HotZone h on hs.HairShopHotZoneID = h.HotZoneID inner join TypeTable tt on hs.TypeID=tt.TypeID" + orderKey;
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
                                HairShop hairShop = new HairShop();

                                hairShop.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairShop.HairShopName = sdr["HairShopName"].ToString();
                                hairShop.HairShopCityID = int.Parse(sdr["HairShopCityID"].ToString());
                                hairShop.HairShopCityName = sdr["CityName"].ToString();
                                hairShop.HairShopMapZoneID = int.Parse(sdr["HairShopMapZoneID"].ToString());
                                hairShop.HairShopMapZoneName = sdr["MapZoneName"].ToString();
                                hairShop.HairShopHotZoneID = int.Parse(sdr["HairShopHotZoneID"].ToString());
                                hairShop.HairShopHotZoneName = sdr["HotZoneName"].ToString();
                                hairShop.HairShopAddress = sdr["HairShopAddress"].ToString();
                                hairShop.HairShopPhoneNum = sdr["HairShopPhoneNum"].ToString();
                                hairShop.HairShopPictureStoreIDs = sdr["HairShopPictureStoreIDs"].ToString();
                                hairShop.HairShopMainIDs = sdr["HairShopMainIDs"].ToString();
                                hairShop.HairShopPartialIDs = sdr["HairShopPartialIDs"].ToString();
                                hairShop.HairShopEngineerNum = int.Parse(sdr["HairShopEngineerNum"].ToString());
                                hairShop.HairShopOpenTime = sdr["HairShopOpenTime"].ToString();
                                hairShop.HairShopOrderNum = int.Parse(sdr["HairShopOrderNum"].ToString());
                                hairShop.HairShopVisitNum = int.Parse(sdr["HairShopVisitNum"].ToString());
                                hairShop.WorkRangeIDs = sdr["WorkRangeIDs"].ToString();
                                hairShop.HairShopWebSite = sdr["HairShopWebSite"].ToString();
                                hairShop.HairShopEmail = sdr["HairShopEmail"].ToString();
                                hairShop.HairShopDiscount = sdr["HairShopDiscount"].ToString();
                                hairShop.HairShopLogo = sdr["HairShopLogo"].ToString();
                                hairShop.HairShopRecommandNum = int.Parse(sdr["HairShopRecommandNum"].ToString());
                                hairShop.HairShopCreateTime = sdr["HairShopCreateTime"].ToString();
                                hairShop.HairShopDescription = sdr["HairShopDescription"].ToString();
                                hairShop.ProductIDs = sdr["ProductIDs"].ToString();
                                hairShop.HairShopTagIDs = sdr["HairShopTagIDs"].ToString();
                                hairShop.HairShopShortName = sdr["HairShopShortName"].ToString();
                                hairShop.IsBest = bool.Parse(sdr["IsBest"].ToString());
                                hairShop.IsJoin = bool.Parse(sdr["IsJoin"].ToString());
                                hairShop.TypeID = int.Parse(sdr["TypeID"].ToString());
                                hairShop.TypeName = sdr["TypeName"].ToString();
                                hairShop.IsPostStation = bool.Parse(sdr["IsPostStation"].ToString());
                                hairShop.IsPostMachine = bool.Parse(sdr["IsPostMachine"].ToString());
                                hairShop.HairShopGood = int.Parse(sdr["HairShopGood"].ToString());
                                hairShop.HairShopBad = int.Parse(sdr["HairShopBad"].ToString());

                                list.Add(hairShop);
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
        /// <returns></returns>
        public List<HairShop> GetHairShops(int count, OrderKey ok,string hairShopName)
        {
            List<HairShop> list = new List<HairShop>();

            string orderKey = " order by ";
            switch (ok)
            {
                case OrderKey.ID:
                    orderKey += "hs.HairShopID desc";
                    break;
                case OrderKey.CommentNum:
                    orderKey += "hs.HairShopGood+hs.HairShopBad desc";
                    break;
                case OrderKey.RecommandNum:
                    orderKey += "hs.HairShopRecommandNum desc";
                    break;
                case OrderKey.HitNum:
                    orderKey += "hs.HairShopVisitNum desc";
                    break;
                case OrderKey.OrderNum:
                    orderKey += "hs.HairShopOrderNum desc";
                    break;
                default:
                    orderKey += "hs.HairShopID desc";
                    break;

            }

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairShop hs inner join City c on hs.HairShopCityID=c.cityID inner join MapZone m on hs.HairShopMapZoneID = m.MapZoneID inner join HotZone h on hs.HairShopHotZoneID = h.HotZoneID inner join TypeTable tt on hs.TypeID=tt.TypeID where hs.HairShopName like '%"+hairShopName+"%'" + orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShop hs inner join City c on hs.HairShopCityID=c.cityID inner join MapZone m on hs.HairShopMapZoneID = m.MapZoneID inner join HotZone h on hs.HairShopHotZoneID = h.HotZoneID inner join TypeTable tt on hs.TypeID=tt.TypeID where hs.HairShopName like '%" + hairShopName + "%'" + orderKey;
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
                                HairShop hairShop = new HairShop();

                                hairShop.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairShop.HairShopName = sdr["HairShopName"].ToString();
                                hairShop.HairShopCityID = int.Parse(sdr["HairShopCityID"].ToString());
                                hairShop.HairShopCityName = sdr["CityName"].ToString();
                                hairShop.HairShopMapZoneID = int.Parse(sdr["HairShopMapZoneID"].ToString());
                                hairShop.HairShopMapZoneName = sdr["MapZoneName"].ToString();
                                hairShop.HairShopHotZoneID = int.Parse(sdr["HairShopHotZoneID"].ToString());
                                hairShop.HairShopHotZoneName = sdr["HotZoneName"].ToString();
                                hairShop.HairShopAddress = sdr["HairShopAddress"].ToString();
                                hairShop.HairShopPhoneNum = sdr["HairShopPhoneNum"].ToString();
                                hairShop.HairShopPictureStoreIDs = sdr["HairShopPictureStoreIDs"].ToString();
                                hairShop.HairShopMainIDs = sdr["HairShopMainIDs"].ToString();
                                hairShop.HairShopPartialIDs = sdr["HairShopPartialIDs"].ToString();
                                hairShop.HairShopEngineerNum = int.Parse(sdr["HairShopEngineerNum"].ToString());
                                hairShop.HairShopOpenTime = sdr["HairShopOpenTime"].ToString();
                                hairShop.HairShopOrderNum = int.Parse(sdr["HairShopOrderNum"].ToString());
                                hairShop.HairShopVisitNum = int.Parse(sdr["HairShopVisitNum"].ToString());
                                hairShop.WorkRangeIDs = sdr["WorkRangeIDs"].ToString();
                                hairShop.HairShopWebSite = sdr["HairShopWebSite"].ToString();
                                hairShop.HairShopEmail = sdr["HairShopEmail"].ToString();
                                hairShop.HairShopDiscount = sdr["HairShopDiscount"].ToString();
                                hairShop.HairShopLogo = sdr["HairShopLogo"].ToString();
                                hairShop.HairShopRecommandNum = int.Parse(sdr["HairShopRecommandNum"].ToString());
                                hairShop.HairShopCreateTime = sdr["HairShopCreateTime"].ToString();
                                hairShop.HairShopDescription = sdr["HairShopDescription"].ToString();
                                hairShop.ProductIDs = sdr["ProductIDs"].ToString();
                                hairShop.HairShopTagIDs = sdr["HairShopTagIDs"].ToString();
                                hairShop.HairShopShortName = sdr["HairShopShortName"].ToString();
                                hairShop.IsBest = bool.Parse(sdr["IsBest"].ToString());
                                hairShop.IsJoin = bool.Parse(sdr["IsJoin"].ToString());
                                hairShop.TypeID = int.Parse(sdr["TypeID"].ToString());
                                hairShop.TypeName = sdr["TypeName"].ToString();
                                hairShop.IsPostStation = bool.Parse(sdr["IsPostStation"].ToString());
                                hairShop.IsPostMachine = bool.Parse(sdr["IsPostMachine"].ToString());
                                hairShop.HairShopGood = int.Parse(sdr["HairShopGood"].ToString());
                                hairShop.HairShopBad = int.Parse(sdr["HairShopBad"].ToString());

                                list.Add(hairShop);
                            }
                        }
                    }
                }
            }

            return list;
        }
        /// <summary>
        /// 通过美发厅推荐ID获得美发厅推荐实体
        /// </summary>
        /// <param name="hairShopRecommandID"></param>
        /// <returns></returns>
        public HairShopRecommand GetHairShopRecommandByHairShopRecommandID(int hairShopRecommandID)
        {
            HairShopRecommand hairShopRecommand = new HairShopRecommand();

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string commText = "select * from HairShopRecommand hsr inner join HairShop hs on hsr.HairShopRawID = hs.HairShopID inner join City c on hs.HairShopCityID=c.cityID inner join MapZone m on hs.HairShopMapZoneID = m.MapZoneID inner join HotZone h on hs.HairShopHotZoneID = h.HotZoneID inner join TypeTable tt on hs.TypeID=tt.TypeID where hsr.HairShopRecommandID = " + hairShopRecommandID.ToString();

                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commText;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            hairShopRecommand.HairShopRecommandID = int.Parse(sdr["HairShopRecommandID"].ToString());
                            hairShopRecommand.HairShopRawID = int.Parse(sdr["HairShopRawID"].ToString());
                            hairShopRecommand.HairShopName = sdr["HairShopName"].ToString();
                            hairShopRecommand.HairShopCityID = int.Parse(sdr["HairShopCityID"].ToString());
                            hairShopRecommand.HairShopCityName = sdr["CityName"].ToString();
                            hairShopRecommand.HairShopMapZoneID = int.Parse(sdr["HairShopMapZoneID"].ToString());
                            hairShopRecommand.HairShopMapZoneName = sdr["MapZoneName"].ToString();
                            hairShopRecommand.HairShopHotZoneID = int.Parse(sdr["HairShopHotZoneID"].ToString());
                            hairShopRecommand.HairShopHotZoneName = sdr["HotZoneName"].ToString();
                            hairShopRecommand.HairShopAddress = sdr["HairShopAddress"].ToString();
                            hairShopRecommand.HairShopPhoneNum = sdr["HairShopPhoneNum"].ToString();
                            hairShopRecommand.HairShopPictureStoreIDs = sdr["HairShopPictureStoreIDs"].ToString();
                            hairShopRecommand.HairShopMainIDs = sdr["HairShopMainIDs"].ToString();
                            hairShopRecommand.HairShopPartialIDs = sdr["HairShopPartialIDs"].ToString();
                            hairShopRecommand.HairShopEngineerNum = int.Parse(sdr["HairShopEngineerNum"].ToString());
                            hairShopRecommand.HairShopOpenTime = sdr["HairShopOpenTime"].ToString();
                            hairShopRecommand.HairShopOrderNum = int.Parse(sdr["HairShopOrderNum"].ToString());
                            hairShopRecommand.HairShopVisitNum = int.Parse(sdr["HairShopVisitNum"].ToString());
                            hairShopRecommand.WorkRangeIDs = sdr["WorkRangeIDs"].ToString();
                            hairShopRecommand.HairShopWebSite = sdr["HairShopWebSite"].ToString();
                            hairShopRecommand.HairShopEmail = sdr["HairShopEmail"].ToString();
                            hairShopRecommand.HairShopDiscount = sdr["HairShopDiscount"].ToString();
                            hairShopRecommand.HairShopLogo = sdr["HairShopLogo"].ToString();
                            hairShopRecommand.HairShopRecommandNum = int.Parse(sdr["HairShopRecommandNum"].ToString());
                            hairShopRecommand.HairShopCreateTime = sdr["HairShopCreateTime"].ToString();
                            hairShopRecommand.HairShopDescription = sdr["HairShopDescription"].ToString();
                            hairShopRecommand.ProductIDs = sdr["ProductIDs"].ToString();
                            hairShopRecommand.HairShopTagIDs = sdr["HairShopTagIDs"].ToString();
                            hairShopRecommand.HairShopShortName = sdr["HairShopShortName"].ToString();
                            hairShopRecommand.IsBest = bool.Parse(sdr["IsBest"].ToString());
                            hairShopRecommand.IsJoin = bool.Parse(sdr["IsJoin"].ToString());
                            hairShopRecommand.TypeID = int.Parse(sdr["TypeID"].ToString());
                            hairShopRecommand.TypeName = sdr["TypeName"].ToString();
                            hairShopRecommand.IsPostStation = bool.Parse(sdr["IsPostStation"].ToString());
                            hairShopRecommand.IsPostMachine = bool.Parse(sdr["IsPostMachine"].ToString());
                            hairShopRecommand.HairShopGood = int.Parse(sdr["HairShopGood"].ToString());
                            hairShopRecommand.HairShopBad = int.Parse(sdr["HairShopBad"].ToString());
                            hairShopRecommand.HairShopRecommandEx = sdr["HairShopRecommandEx"].ToString();
                            hairShopRecommand.HairShopRecommandInfo = sdr["HairShopRecommandInfo"].ToString();
                        }
                    }
                }
            }

            return hairShopRecommand;
        }

        /// <summary>
        /// 获得美发厅推荐
        /// </summary>
        /// <param name="count">0 全部</param>
        /// <returns></returns>
        public List<HairShopRecommand> GetHairShopRecommands(int count)
        {
            List<HairShopRecommand> list = new List<HairShopRecommand>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairShopRecommand hsr inner join HairShop hs on hsr.HairShopRawID = hs.HairShopID inner join City c on hs.HairShopCityID=c.cityID inner join MapZone m on hs.HairShopMapZoneID = m.MapZoneID inner join HotZone h on hs.HairShopHotZoneID = h.HotZoneID inner join TypeTable tt on hs.TypeID=tt.TypeID order by hsr.HairShopRecommandID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShopRecommand hsr inner join HairShop hs on hsr.HairShopRawID = hs.HairShopID inner join City c on hs.HairShopCityID=c.cityID inner join MapZone m on hs.HairShopMapZoneID = m.MapZoneID inner join HotZone h on hs.HairShopHotZoneID = h.HotZoneID inner join TypeTable tt on hs.TypeID=tt.TypeID order by hsr.HairShopRecommandID desc";
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
                                HairShopRecommand hairShopRecommand = new HairShopRecommand();

                                hairShopRecommand.HairShopRecommandID = int.Parse(sdr["HairShopRecommandID"].ToString());
                                hairShopRecommand.HairShopRawID = int.Parse(sdr["HairShopRawID"].ToString());
                                hairShopRecommand.HairShopName = sdr["HairShopName"].ToString();
                                hairShopRecommand.HairShopCityID = int.Parse(sdr["HairShopCityID"].ToString());
                                hairShopRecommand.HairShopCityName = sdr["CityName"].ToString();
                                hairShopRecommand.HairShopMapZoneID = int.Parse(sdr["HairShopMapZoneID"].ToString());
                                hairShopRecommand.HairShopMapZoneName = sdr["MapZoneName"].ToString();
                                hairShopRecommand.HairShopHotZoneID = int.Parse(sdr["HairShopHotZoneID"].ToString());
                                hairShopRecommand.HairShopHotZoneName = sdr["HotZoneName"].ToString();
                                hairShopRecommand.HairShopAddress = sdr["HairShopAddress"].ToString();
                                hairShopRecommand.HairShopPhoneNum = sdr["HairShopPhoneNum"].ToString();
                                hairShopRecommand.HairShopPictureStoreIDs = sdr["HairShopPictureStoreIDs"].ToString();
                                hairShopRecommand.HairShopMainIDs = sdr["HairShopMainIDs"].ToString();
                                hairShopRecommand.HairShopPartialIDs = sdr["HairShopPartialIDs"].ToString();
                                hairShopRecommand.HairShopEngineerNum = int.Parse(sdr["HairShopEngineerNum"].ToString());
                                hairShopRecommand.HairShopOpenTime = sdr["HairShopOpenTime"].ToString();
                                hairShopRecommand.HairShopOrderNum = int.Parse(sdr["HairShopOrderNum"].ToString());
                                hairShopRecommand.HairShopVisitNum = int.Parse(sdr["HairShopVisitNum"].ToString());
                                hairShopRecommand.WorkRangeIDs = sdr["WorkRangeIDs"].ToString();
                                hairShopRecommand.HairShopWebSite = sdr["HairShopWebSite"].ToString();
                                hairShopRecommand.HairShopEmail = sdr["HairShopEmail"].ToString();
                                hairShopRecommand.HairShopDiscount = sdr["HairShopDiscount"].ToString();
                                hairShopRecommand.HairShopLogo = sdr["HairShopLogo"].ToString();
                                hairShopRecommand.HairShopRecommandNum = int.Parse(sdr["HairShopRecommandNum"].ToString());
                                hairShopRecommand.HairShopCreateTime = sdr["HairShopCreateTime"].ToString();
                                hairShopRecommand.HairShopDescription = sdr["HairShopDescription"].ToString();
                                hairShopRecommand.ProductIDs = sdr["ProductIDs"].ToString();
                                hairShopRecommand.HairShopTagIDs = sdr["HairShopTagIDs"].ToString();
                                hairShopRecommand.HairShopShortName = sdr["HairShopShortName"].ToString();
                                hairShopRecommand.IsBest = bool.Parse(sdr["IsBest"].ToString());
                                hairShopRecommand.IsJoin = bool.Parse(sdr["IsJoin"].ToString());
                                hairShopRecommand.TypeID = int.Parse(sdr["TypeID"].ToString());
                                hairShopRecommand.TypeName = sdr["TypeName"].ToString();
                                hairShopRecommand.IsPostStation = bool.Parse(sdr["IsPostStation"].ToString());
                                hairShopRecommand.IsPostMachine = bool.Parse(sdr["IsPostMachine"].ToString());
                                hairShopRecommand.HairShopGood = int.Parse(sdr["HairShopGood"].ToString());
                                hairShopRecommand.HairShopBad = int.Parse(sdr["HairShopBad"].ToString());
                                hairShopRecommand.HairShopRecommandEx = sdr["HairShopRecommandEx"].ToString();
                                hairShopRecommand.HairShopRecommandInfo = sdr["HairShopRecommandInfo"].ToString();

                                list.Add(hairShopRecommand);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 获得美发店风格列表
        /// </summary>
        /// <returns></returns>
        public List<TypeTable> GetTypeTables()
        {
            List<TypeTable> list = new List<TypeTable>();

            string commText = "select * from TypeTable order by TypeID desc";

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
                                TypeTable typeTable = new TypeTable();

                                typeTable.ID = int.Parse(sdr["TypeID"].ToString());
                                typeTable.IsVisible = Convert.ToBoolean(sdr["TypeVisible"].ToString());
                                typeTable.Name = sdr["TypeName"].ToString();

                                list.Add(typeTable);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 美发店风格 添加，删除，修改
        /// </summary>
        /// <param name="typeTable"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool TypeTableCreateDeleteUpdate(TypeTable typeTable, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into TypeTable(TypeName,TypeVisible) values('" + typeTable.Name + "'," + typeTable.IsVisible.CompareTo(false).ToString() +")";
                    break;
                case UserAction.Delete:
                    commandText = "delete from TypeTable where TypeID="+typeTable.ID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update TypeTable set TypeName='"+typeTable.Name+"',TypeVisible="+typeTable.IsVisible.CompareTo(false).ToString()+" where TypeID="+typeTable.ID.ToString();
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
        /// 获得美发厅营业范围列表
        /// </summary>
        /// <returns></returns>
        public List<WorkRange> GetWorkRanges()
        {
            List<WorkRange> list = new List<WorkRange>();

            string commText = "select * from WorkRange order by WorkRangeID desc";

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
                                WorkRange workRange = new WorkRange();

                                workRange.ID = int.Parse(sdr["WorkRangeID"].ToString());
                                workRange.IsVisible = Convert.ToBoolean(sdr["WorkRangeVisible"].ToString());
                                workRange.Name = sdr["WorkRangeName"].ToString();

                                list.Add(workRange);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 美发厅营业范围 添加，删除，修改
        /// </summary>
        /// <param name="workRange"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool WorkRangeCreateDeleteUpdate(WorkRange workRange, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into WorkRange(WorkRangeName,WorkRangeVisible) values('" + workRange.Name + "'," + workRange.IsVisible.CompareTo(false).ToString() + ")";
                    break;
                case UserAction.Delete:
                    commandText = "delete from WorkRange where WorkRangeID=" + workRange.ID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update WorkRange set WorkRangeName='" + workRange.Name + "',WorkRangeVisible=" + workRange.IsVisible.CompareTo(false).ToString() + " where WorkRangeID=" + workRange.ID.ToString();
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
        /// 获取美发厅TAG列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairShopTag> GetHairShopTags(int count)
        {
            List<HairShopTag> list = new List<HairShopTag>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairShopTag order by HairShopTagID desc";
                    break;
                default:
                    commText = "select top "+count.ToString()+" * from HairShopTag order by HairShopTagID desc";
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
                                HairShopTag hairShopTag = new HairShopTag();

                                hairShopTag.HairShopIDs = sdr["HairShopIDs"].ToString();
                                hairShopTag.TagID = int.Parse(sdr["HairShopTagID"].ToString());
                                hairShopTag.TagName = sdr["HairShopTagName"].ToString();

                                list.Add(hairShopTag);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 美发厅TAG列表 添加，删除，修改
        /// </summary>
        /// <param name="hairShopTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairShopTagCreateDeleteUpdate(HairShopTag hairShopTag, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairShopTag(HairShopTagName,HairShopIDs) values('"+hairShopTag.TagName+"','"+hairShopTag.HairShopIDs+"')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairShopTag where HairShopTagID="+hairShopTag.TagID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairShopTag set HairShopTagName='"+hairShopTag.TagName+"', HairShopIDs='"+hairShopTag.HairShopIDs+"' where HairShopTagID="+hairShopTag.TagID.ToString();
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
        /// 通过TAGID获取美发厅TAG实体
        /// </summary>
        /// <param name="hairShopTagID"></param>
        /// <returns></returns>
        public HairShopTag GetHairShopTagByHairShopTagID(int hairShopTagID)
        {
            HairShopTag hairShopTag = new HairShopTag();

            string commText = "select * from HairShopTag where HairShopTagID="+hairShopTagID.ToString();

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
                                hairShopTag.HairShopIDs = sdr["HairShopIDs"].ToString();
                                hairShopTag.TagID = int.Parse(sdr["HairShopTagID"].ToString());
                                hairShopTag.TagName = sdr["HairShopTagName"].ToString();
                            }
                        }
                    }
                }
            }

            return hairShopTag;
        }

        /// <summary>
        /// 通过美发厅ID获取美发厅评论列表
        /// </summary>
        /// <param name="hairShopID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">用户排序KEY 例如：时间排序，好评排序，按照用户排序</param>
        /// <returns></returns>
        public List<HairShopComment> GetHairShopCommentsByHairShopID(int hairShopID, int count, OrderKey ok)
        {
            List<HairShopComment> list = new List<HairShopComment>();

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
                    orderKey += "HairShopCommentCreateTime desc";
                    break;
                default:
                    orderKey += "HairShopCommentID desc";
                    break;
            }
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from HairShopComment where HairShopID=" + hairShopID.ToString() + orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShopComment where HairShopID=" + hairShopID.ToString() + orderKey;
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
                                HairShopComment hairShopComment = new HairShopComment();

                                hairShopComment.CommentCreateTime = Convert.ToDateTime(sdr["HairShopCommentCreateTime"].ToString());
                                hairShopComment.CommentID = int.Parse(sdr["HairShopCommentID"].ToString());
                                hairShopComment.CommentText = sdr["HairShopCommentText"].ToString();
                                hairShopComment.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairShopComment.UserAddress = sdr["UserAddress"].ToString();
                                hairShopComment.UserID = int.Parse(sdr["UserID"].ToString());
                                hairShopComment.UserName = sdr["UserName"].ToString();
                                hairShopComment.IsGood = Convert.ToBoolean(sdr["IsGood"].ToString());

                                list.Add(hairShopComment);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 通过USERID获取美发厅的评论列表
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">用户排序KEY 时间排序，好评排序，美发厅排序</param>
        /// <returns></returns>
        public List<HairShopComment> GetHairShopCommentsByUserID(int userID, int count, OrderKey ok)
        {
            List<HairShopComment> list = new List<HairShopComment>();

            string orderKey = " order by ";
            switch (ok)
            {
                case OrderKey.Good:
                    orderKey += "IsGood desc";
                    break;
                case OrderKey.ID:
                    orderKey += "HairShopID desc";
                    break;
                case OrderKey.Time:
                    orderKey += "HairShopCommentCreateTime desc";
                    break;
                default:
                    orderKey += "HairShopCommentID desc";
                    break;
            }
            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from HairShopComment where UserID=" + userID.ToString() + orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShopComment where UserID=" + userID.ToString() + orderKey;
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
                                HairShopComment hairShopComment = new HairShopComment();

                                hairShopComment.CommentCreateTime = Convert.ToDateTime(sdr["HairShopCommentCreateTime"].ToString());
                                hairShopComment.CommentID = int.Parse(sdr["HairShopCommentID"].ToString());
                                hairShopComment.CommentText = sdr["HairShopCommentText"].ToString();
                                hairShopComment.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairShopComment.UserAddress = sdr["UserAddress"].ToString();
                                hairShopComment.UserID = int.Parse(sdr["UserID"].ToString());
                                hairShopComment.UserName = sdr["UserName"].ToString();
                                hairShopComment.IsGood = Convert.ToBoolean(sdr["IsGood"].ToString());

                                list.Add(hairShopComment);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 美发厅评论 添加，删除，修改
        /// </summary>
        /// <param name="hairShopComment"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairShopCommentCreateDeleteUpdate(HairShopComment hairShopComment, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairShopComment(HairShopCommentText,UserID,UserName,UserAddress,IsGood,HairShopCommentCreateTime,HairShopID) values('" + hairShopComment.CommentText + "'," + hairShopComment.UserID.ToString() + ",'" + hairShopComment.UserName + "','" + hairShopComment.UserAddress + "'," + hairShopComment.IsGood.CompareTo(false).ToString() + ",'" + hairShopComment.CommentCreateTime.ToString() + "'," + hairShopComment.HairShopID.ToString() + ")";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairShopComment where HairShopCommentID = " + hairShopComment.CommentID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairShopComment set HairShopCommentText ='" + hairShopComment.CommentText + "',UserID=" + hairShopComment.UserID.ToString() + ",UserName='" + hairShopComment.UserName + "',UserAddress='" + hairShopComment.UserAddress + "',IsGood=" + hairShopComment.IsGood.CompareTo(false).ToString() + ",HairShopCommentCreateTime='" + hairShopComment.CommentCreateTime.ToString() + "',HairShopID=" + hairShopComment.HairShopID.ToString() + " where HairShopCommentID=" + hairShopComment.CommentID.ToString();
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
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairShopComment> GetHairShopComments(int count)
        {
            List<HairShopComment> list = new List<HairShopComment>();

            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from HairShopComment order by HairShopCommentID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShopComment order by HairShopCommentID desc";
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
                                HairShopComment hairShopComment = new HairShopComment();

                                hairShopComment.CommentCreateTime = Convert.ToDateTime(sdr["HairShopCommentCreateTime"].ToString());
                                hairShopComment.CommentID = int.Parse(sdr["HairShopCommentID"].ToString());
                                hairShopComment.CommentText = sdr["HairShopCommentText"].ToString();
                                hairShopComment.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairShopComment.UserAddress = sdr["UserAddress"].ToString();
                                hairShopComment.UserID = int.Parse(sdr["UserID"].ToString());
                                hairShopComment.UserName = sdr["UserName"].ToString();
                                hairShopComment.IsGood = Convert.ToBoolean(sdr["IsGood"].ToString());

                                list.Add(hairShopComment);
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
        public List<HairShopComment> GetHairShopCommentsByKeyText(int count, string keyText)
        {
            List<HairShopComment> list = new List<HairShopComment>();

            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from HairShopComment where HairShopCommentText like '%"+keyText+"%' order by HairShopCommentID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShopComment where HairShopCommentText like '%" + keyText + "%' order by HairShopCommentID desc";
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
                                HairShopComment hairShopComment = new HairShopComment();

                                hairShopComment.CommentCreateTime = Convert.ToDateTime(sdr["HairShopCommentCreateTime"].ToString());
                                hairShopComment.CommentID = int.Parse(sdr["HairShopCommentID"].ToString());
                                hairShopComment.CommentText = sdr["HairShopCommentText"].ToString();
                                hairShopComment.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairShopComment.UserAddress = sdr["UserAddress"].ToString();
                                hairShopComment.UserID = int.Parse(sdr["UserID"].ToString());
                                hairShopComment.UserName = sdr["UserName"].ToString();
                                hairShopComment.IsGood = Convert.ToBoolean(sdr["IsGood"].ToString());

                                list.Add(hairShopComment);
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
        public List<HairShopComment> GetHairShopCommentsByTimeZone(int count, string sTime, string eTime)
        {
            List<HairShopComment> list = new List<HairShopComment>();

            string commText = string.Empty;
            switch (count)
            {
                case 0:
                    commText = "select * from HairShopComment where HairShopCommentCreateTime<'"+eTime+"' and HairShopCommentCreateTime>'"+sTime+"' order by HairShopCommentID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShopComment where HairShopCommentCreateTime<'" + eTime + "' and HairShopCommentCreateTime>'" + sTime + "' order by HairShopCommentID desc";
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
                                HairShopComment hairShopComment = new HairShopComment();

                                hairShopComment.CommentCreateTime = Convert.ToDateTime(sdr["HairShopCommentCreateTime"].ToString());
                                hairShopComment.CommentID = int.Parse(sdr["HairShopCommentID"].ToString());
                                hairShopComment.CommentText = sdr["HairShopCommentText"].ToString();
                                hairShopComment.HairShopID = int.Parse(sdr["HairShopID"].ToString());
                                hairShopComment.UserAddress = sdr["UserAddress"].ToString();
                                hairShopComment.UserID = int.Parse(sdr["UserID"].ToString());
                                hairShopComment.UserName = sdr["UserName"].ToString();
                                hairShopComment.IsGood = Convert.ToBoolean(sdr["IsGood"].ToString());

                                list.Add(hairShopComment);
                            }
                        }
                    }
                }
            }

            return list;
        }


        public bool AddHairShop(HairShop hairShop)
        {
            bool bReturn = false;
            string sSql = "insert into HairShop([HairShopName],[HairShopCityID],[HairShopMapZoneID],[HairShopHotZoneID],[HairShopAddress],[HairShopPhoneNum],[HairShopPictureStoreIDs],[HairShopMainIDs],[HairShopPartialIDs],[HairShopEngineerNum],[HairShopOpenTime],[HairShopOrderNum],[HairShopVisitNum],[WorkRangeIDs],[HairShopWebSite],[HairShopEmail],[HairshopDiscount],[HairShopLogo],[HairShopRecommandNum],[HairShopCreateTime],[HairShopDescription],[ProductIDs],[HairShopTagIDs],[HairShopShortName],[IsBest],[IsJoin],[TypeID],[IsPostStation],[IsPostMachine],[HairShopGood],[HairShopBad])"
                + " values('" + hairShop.HairShopName + "'," + hairShop.HairShopCityID + "," + hairShop.HairShopMapZoneID + "," + hairShop.HairShopHotZoneID + ",'" + hairShop.HairShopAddress + "','" + hairShop.HairShopPhoneNum + "','" + hairShop.HairShopPictureStoreIDs + "','" + hairShop.HairShopMainIDs + "','" + hairShop.HairShopPartialIDs + "'," + hairShop.HairShopEngineerNum + ",'" + hairShop.HairShopOpenTime + "'," + hairShop.HairShopOrderNum + "," + hairShop.HairShopVisitNum + ",'" + hairShop.WorkRangeIDs + "','" + hairShop.HairShopWebSite + "','" + hairShop.HairShopEmail + "','" + hairShop.HairShopDiscount + "','" + hairShop.HairShopLogo + "'"
                + "," + hairShop.HairShopRecommandNum + ",'" + hairShop.HairShopCreateTime + "','" + hairShop.HairShopDescription + "','" + hairShop.ProductIDs + "','" + hairShop.HairShopTagIDs + "','" + hairShop.HairShopShortName + "','" + hairShop.IsBest + "','" + hairShop.IsJoin + "'," + hairShop.TypeID + ",'" + hairShop.IsPostStation + "','" + hairShop.IsPostMachine + "'," + hairShop.HairShopGood + "," + hairShop.HairShopBad + ")";

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = sSql;
                    conn.Open();

                    if (comm.ExecuteNonQuery()==1)
                    {
                        bReturn = true;
                    }
                    conn.Close();
                }
            }
            sSql = null;
            return bReturn;
        }
    }
}
