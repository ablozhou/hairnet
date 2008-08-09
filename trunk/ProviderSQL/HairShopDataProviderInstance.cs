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
        public List<HairShop> GetHairShops(int count)
        {
            List<HairShop> list = new List<HairShop>();

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairShop hs inner join City c on hs.HairShopCityID=c.cityID inner join MapZone m on hs.HairShopMapZoneID = m.MapZoneID inner join HotZone h on hs.HairShopHotZoneID = h.HotZoneID inner join TypeTable tt on hs.TypeID=tt.TypeID order by hs.HairShopID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShop hs inner join City c on hs.HairShopCityID=c.cityID inner join MapZone m on hs.HairShopMapZoneID = m.MapZoneID inner join HotZone h on hs.HairShopHotZoneID = h.HotZoneID inner join TypeTable tt on hs.TypeID=tt.TypeID order by hs.HairShopID desc";
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
    }
}
