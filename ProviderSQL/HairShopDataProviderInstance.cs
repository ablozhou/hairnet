using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;
using System.Data.SqlClient;
using System.Data;

using HairNet.DBUtility;
using System.Configuration;

namespace HairNet.Provider
{
    public class HairShopDataProviderInstance : IHairShopDataProvider
    {
        private const string SQL_HAIRSHOPPARMCACHE = "HAIRSHOPPARMCACHE";
        private const string SQL_COUPONPARMCACHE = "COUPONPARMCACHE";

        /// <summary>
        /// 美发厅,老的，废弃了
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
                    commandText = "insert into HairShop(HairShopName,HairShopCityID,HairShopMapZoneID,HairShopHotZoneID,HairShopAddress,HairShopPhoneNum,"+
                        "HairShopEngineerNum,HairShopOpenTime,HairShopWebSite,HairShopEmail,"+
                        "HairShopDiscount,HairShopLogo,HairShopCreateTime,HairShopDescription,ProductIDs,HairShopTagIDs,HairShopShortName,"+
                        "IsJoin,TypeID,IsPostStation,IsPostMachine) values('" 
                        + hairShop.HairShopName + 
                        "'," + hairShop.HairShopCityID.ToString() + 
                        "," + hairShop.HairShopMapZoneID.ToString() + 
                        "," + hairShop.HairShopHotZoneID.ToString() + 
                        ",'" + hairShop.HairShopAddress + 
                        "','" + hairShop.HairShopPhoneNum + 



                        "'," + hairShop.HairShopEngineerNum.ToString() + 
                        ",'" + hairShop.HairShopOpenTime + 

                        "','" + hairShop.HairShopWebSite + 
                        "','" + hairShop.HairShopEmail + 
                        "','" + hairShop.HairShopDiscount + 
                        "','" + hairShop.HairShopLogo + 
                        "','" + hairShop.HairShopCreateTime + 
                        "','" + hairShop.HairShopDescription + 
                        "','" + hairShop.ProductIDs + 
                        "','" + hairShop.HairShopTagIDs + 
                        "','" + hairShop.HairShopShortName + 

                        "," + hairShop.IsJoin.CompareTo(false).ToString() + 
                        "," + hairShop.TypeID.ToString() + 
                        "," + hairShop.IsPostStation.CompareTo(false).ToString() + 
                        "," + hairShop.IsPostMachine.CompareTo(false).ToString() + ")";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairShop where HairShopID="+hairShop.HairShopID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairShop set HairShopName='" + hairShop.HairShopName + "',HairShopCityID=" + hairShop.HairShopCityID.ToString() +
                        ",HairShopMapZoneID=" + hairShop.HairShopMapZoneID.ToString() + ",HairShopHotZoneID=" + hairShop.HairShopHotZoneID.ToString() + 
                        ",HairShopAddress='" + hairShop.HairShopAddress + "',HairShopPhoneNum='" + hairShop.HairShopPhoneNum +  
                        
                        "',HairShopEngineerNum=" + hairShop.HairShopEngineerNum.ToString() + ",HairShopOpenTime='" + hairShop.HairShopOpenTime + 
                        "',HairShopWebSite='" + hairShop.HairShopWebSite + "',HairShopEmail='" + 
                        hairShop.HairShopEmail + "',HairShopDiscount='" + hairShop.HairShopDiscount + "',HairShopLogo='" + hairShop.HairShopLogo + 
                        "',HairShopCreateTime='" + hairShop.HairShopCreateTime + "',HairShopDescription='" + hairShop.HairShopDescription +
                        "',ProductIDs='" + hairShop.ProductIDs + "',HairShopTagIDs='" + hairShop.HairShopTagIDs + "',HairShopShortName='" +
                        hairShop.HairShopShortName + ",IsJoin=" + hairShop.IsJoin.CompareTo(false).ToString() + ",TypeID=" + hairShop.TypeID.ToString() + ",IsPostStation=" + hairShop.IsPostStation.CompareTo(false).ToString() + ",IsPostMachine=" + hairShop.IsPostMachine.CompareTo(false).ToString() + " where HairShopID = " + hairShop.HairShopID.ToString();
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
        /// 
        /// </summary>
        /// <param name="hairShop"></param>
        /// <param name="acion"></param>
        public void HairShopCreateDeleteUpdate(HairShop hairShop, UserAction action, out int newid)
        {
            newid = 0;
            if (action == UserAction.Create)
            {
                StringBuilder cmdBuilder = new StringBuilder();
                cmdBuilder.Append("insert into HairShop(HairShopName,HairShopCityID,HairShopMapZoneID,HairShopHotZoneID,HairShopAddress,HairShopPhoneNum,HairShopEngineerNum,HairShopOpenTime,HairShopWebSite,HairShopEmail,HairShopDiscount,HairShopLogo,HairShopCreateTime,HairShopDescription,ProductIDs,HairShopTagIDs,HairShopShortName,IsJoin,TypeID,IsPostStation,IsPostMachine,");
                cmdBuilder.Append("HairCutPrice, HairMarcelPrice, HairDyePrice, HairCutDiscount, HairMarcelDiscount, HairDyeDiscount,");
                cmdBuilder.Append("HairShapePrice, HairShapeDiscount, HairConservationPrice, HairConservationDiscount,");
                cmdBuilder.Append("LocationMapURL, IsServeMarcel, IsServeDye, IsServeHairCut, [Square],MemberInfo,travelInfo) ");
                cmdBuilder.Append(" VALUES(' ");

                #region
                cmdBuilder.Append(hairShop.HairShopName + "','");
                cmdBuilder.Append(hairShop.HairShopCityID.ToString() + "','");
                cmdBuilder.Append(hairShop.HairShopMapZoneID.ToString() + "','");
                cmdBuilder.Append(hairShop.HairShopHotZoneID.ToString() + "','");
                cmdBuilder.Append(hairShop.HairShopAddress + "','");
                cmdBuilder.Append(hairShop.HairShopPhoneNum + "','");
                //cmdBuilder.Append(hairShop.HairShopPictureStoreIDs + "','");
                //cmdBuilder.Append(hairShop.HairShopMainIDs + "','");
                //cmdBuilder.Append(hairShop.HairShopPartialIDs + "','");
                cmdBuilder.Append(hairShop.HairShopEngineerNum.ToString() + "','");
                cmdBuilder.Append(hairShop.HairShopOpenTime + "','");
                //cmdBuilder.Append(hairShop.WorkRangeIDs + "','");
                cmdBuilder.Append(hairShop.HairShopWebSite + "','");
                cmdBuilder.Append(hairShop.HairShopEmail + "','");
                cmdBuilder.Append(hairShop.HairShopDiscount + "','");
                cmdBuilder.Append(hairShop.HairShopLogo + "','");
                cmdBuilder.Append(hairShop.HairShopCreateTime + "','");
                cmdBuilder.Append(hairShop.HairShopDescription + "','");
                cmdBuilder.Append(hairShop.ProductIDs + "','");
                cmdBuilder.Append(hairShop.HairShopTagIDs + "','");
                cmdBuilder.Append(hairShop.HairShopShortName + "','");
                //cmdBuilder.Append(hairShop.IsBest.CompareTo(false).ToString() + "','");
                cmdBuilder.Append(hairShop.IsJoin.CompareTo(false).ToString() + "','");
                cmdBuilder.Append(hairShop.TypeID.ToString() + "','");
                cmdBuilder.Append(hairShop.IsPostStation.CompareTo(false).ToString() + "','");
                cmdBuilder.Append(hairShop.IsPostMachine.CompareTo(false).ToString() + "','");
                #endregion
                cmdBuilder.Append(hairShop.HairCutPirce.ToString() + "','");
                cmdBuilder.Append(hairShop.HairMarcelPrice.ToString() + "','");
                cmdBuilder.Append(hairShop.HairDyePrice.ToString() + "','");
                cmdBuilder.Append(hairShop.HairCutDiscount.ToString() + "','");
                cmdBuilder.Append(hairShop.HairMarcelDiscount.ToString() + "','");
                cmdBuilder.Append(hairShop.HairDyeDiscount.ToString() + "','");

                cmdBuilder.Append(hairShop.HairShapePrice.ToString() + "','");
                cmdBuilder.Append(hairShop.HairShapeDiscount.ToString() + "','");
                cmdBuilder.Append(hairShop.HairConservationPrice.ToString() + "','");
                cmdBuilder.Append(hairShop.HairConservationDiscount.ToString() + "','");

                cmdBuilder.Append(hairShop.LocationMapURL + "','");
                cmdBuilder.Append(hairShop.IsServeMarce.CompareTo(false).ToString() + "','");
                cmdBuilder.Append(hairShop.IsServeDye.CompareTo(false).ToString() + "','");
                cmdBuilder.Append(hairShop.IsServeHairCut.CompareTo(false).ToString() + " ',");
                cmdBuilder.Append(hairShop.Square.ToString() + ",'"+hairShop.MemberInfo+"' ,'"+hairShop.TravelInfo+"');select @@identity;");

                using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = cmdBuilder.ToString();
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            try
                            {
                                newid = Convert.ToInt32(comm.ExecuteScalar());
                            }
                            catch (InvalidCastException)
                            {
                                newid = 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }

                //newid = int.Parse(SqlHelper.ExecuteScalar(DataHelper2.SqlConnectionString, CommandType.Text, cmdBuilder.ToString()).ToString());
            }

            if (action == UserAction.Update)
            {
                string commandText = "update HairShop set HairShopName='" + hairShop.HairShopName + "',HairShopCityID=" + hairShop.HairShopCityID.ToString() + ",HairShopMapZoneID=" + hairShop.HairShopMapZoneID.ToString() + ",HairShopHotZoneID=" + hairShop.HairShopHotZoneID.ToString() + ",HairShopAddress='" + hairShop.HairShopAddress + "',HairShopPhoneNum='" + hairShop.HairShopPhoneNum + "',HairShopEngineerNum=" + hairShop.HairShopEngineerNum.ToString() + ",HairShopOpenTime='" + hairShop.HairShopOpenTime +  "',HairShopWebSite='" + hairShop.HairShopWebSite + "',HairShopEmail='" + hairShop.HairShopEmail + "',HairShopDiscount='" + hairShop.HairShopDiscount + "',HairShopLogo='" + hairShop.HairShopLogo + "',HairShopCreateTime='" + hairShop.HairShopCreateTime + "',HairShopDescription='" + hairShop.HairShopDescription + "',ProductIDs='" + hairShop.ProductIDs + "',HairShopTagIDs='" + hairShop.HairShopTagIDs + "',HairShopShortName='" + hairShop.HairShopShortName + "',IsJoin=" + hairShop.IsJoin.CompareTo(false).ToString() + ",TypeID=" + hairShop.TypeID.ToString() + ",IsPostStation=" + hairShop.IsPostStation.CompareTo(false).ToString() + ",IsPostMachine=" + hairShop.IsPostMachine.CompareTo(false).ToString();
                StringBuilder cmdBuilder = new StringBuilder();

                cmdBuilder.Append(commandText);
                
                cmdBuilder.Append(",HaircutPrice = " + hairShop.HairCutPirce.ToString());
                cmdBuilder.Append(",HairMarcelPrice = " + hairShop.HairMarcelPrice.ToString());
                cmdBuilder.Append(",HairDyePrice = " + hairShop.HairDyePrice.ToString());
                cmdBuilder.Append(",HairShapePrice = " + hairShop.HairShapePrice.ToString());
                cmdBuilder.Append(",HairConservationPrice = " + hairShop.HairConservationPrice.ToString());
                cmdBuilder.Append(",HairCutDiscount = " + hairShop.HairCutDiscount.ToString());
                cmdBuilder.Append(",HairMarcelDiscount = " + hairShop.HairMarcelDiscount.ToString());
                cmdBuilder.Append(",HairDyeDiscount = " + hairShop.HairDyeDiscount.ToString());
                cmdBuilder.Append(",HairShapeDiscount = " + hairShop.HairShapeDiscount.ToString());
                cmdBuilder.Append(",HairConservationDiscount = " + hairShop.HairConservationDiscount.ToString());
                cmdBuilder.Append(",LocationMapURL = '" + hairShop.LocationMapURL.ToString()); 
                cmdBuilder.Append("',IsServeMarcel = " + hairShop.IsServeMarce.CompareTo(false).ToString());
                cmdBuilder.Append(",IsServeDye = " + hairShop.IsServeDye.CompareTo(false).ToString());
                cmdBuilder.Append(",IsServeHairCut = " + hairShop.IsServeHairCut.CompareTo(false).ToString());
                cmdBuilder.Append(",Square = " + hairShop.Square.ToString());

                cmdBuilder.Append(",HairCutPriceMin = " + Convert.ToDecimal(hairShop.HairCutDiscountMin.ToString()));
                cmdBuilder.Append(",HairMarcelPriceMin = " + Convert.ToDecimal(hairShop.HairMarcelDiscountMin.ToString()));
                cmdBuilder.Append(",HairDyePriceMin = " + Convert.ToDecimal(hairShop.HairDyeDiscountMin.ToString()));
                cmdBuilder.Append(",HairShapePriceMin = " + Convert.ToDecimal(hairShop.HairShapeDiscountMin.ToString()));
                cmdBuilder.Append(",HairConservationPriceMin = " + Convert.ToDecimal(hairShop.HairConservationDiscountMin.ToString()));

                cmdBuilder.Append(",MemberInfo='"+hairShop.MemberInfo+"',TravelInfo='"+hairShop.TravelInfo+"'");

                cmdBuilder.Append(" where HairShopID = " + hairShop.HairShopID.ToString());

                SqlHelper.ExecuteNonQuery(DataHelper2.SqlConnectionString, CommandType.Text, cmdBuilder.ToString());
            }

            if (action == UserAction.Delete)
            {
                HairShopDataPrividerCreateDeleteUpdate(hairShop, UserAction.Delete);
            }
            if (newid == 0)
            {
                newid = 0;
            }
            else
            {
                newid = newid;
            }
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
                string commText = "select * from HairShop hs left join City c on hs.HairShopCityID=c.cityID left join MapZone m on hs.HairShopMapZoneID = m.MapZoneID left join HotZone h on hs.HairShopHotZoneID = h.HotZoneID left join TypeTable tt on hs.TypeID=tt.TypeID where hs.HairShopID = " + hairShopID.ToString();

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
                            //hairShop.HairShopPictureStoreIDs = sdr["HairShopPictureStoreIDs"].ToString();
                            //hairShop.HairShopMainIDs = sdr["HairShopMainIDs"].ToString();
                            //hairShop.HairShopPartialIDs = sdr["HairShopPartialIDs"].ToString();
                            hairShop.HairShopEngineerNum = int.Parse(sdr["HairShopEngineerNum"].ToString());
                            hairShop.HairShopOpenTime = sdr["HairShopOpenTime"].ToString();
                            //hairShop.HairShopOrderNum = int.Parse(sdr["HairShopOrderNum"].ToString());
                            hairShop.HairShopVisitNum = int.Parse(sdr["HairShopVisitNum"].ToString());
                            //hairShop.WorkRangeIDs = sdr["WorkRangeIDs"].ToString();
                            hairShop.HairShopWebSite = sdr["HairShopWebSite"].ToString();
                            hairShop.HairShopEmail = sdr["HairShopEmail"].ToString();
                            hairShop.HairShopDiscount = sdr["HairShopDiscount"].ToString();
                            hairShop.HairShopLogo = sdr["HairShopLogo"].ToString();
                            //hairShop.HairShopRecommandNum = int.Parse(sdr["HairShopRecommandNum"].ToString());
                            hairShop.HairShopCreateTime = sdr["HairShopCreateTime"].ToString();
                            hairShop.HairShopDescription = sdr["HairShopDescription"].ToString();
                            hairShop.ProductIDs = sdr["ProductIDs"].ToString();
                            hairShop.HairShopTagIDs = sdr["HairShopTagIDs"].ToString();
                            hairShop.HairShopShortName = sdr["HairShopShortName"].ToString();
                            //hairShop.IsBest = bool.Parse(sdr["IsBest"].ToString());
                            hairShop.IsJoin = bool.Parse(sdr["IsJoin"].ToString());
                            hairShop.TypeID = int.Parse(sdr["TypeID"].ToString());
                            hairShop.TypeName = sdr["TypeName"].ToString();
                            hairShop.IsPostStation = bool.Parse(sdr["IsPostStation"].ToString());
                            hairShop.IsPostMachine = bool.Parse(sdr["IsPostMachine"].ToString());
                            hairShop.HairShopGood = int.Parse(sdr["HairShopGood"].ToString());
                            hairShop.HairShopBad = int.Parse(sdr["HairShopBad"].ToString());
                            hairShop.MemberInfo = sdr["MemberInfo"].ToString();
                            hairShop.CouponNum = int.Parse(sdr["CouponNum"].ToString());
                            hairShop.OutLogs = sdr["outLogs"].ToString();
                            hairShop.InnerLogs = sdr["InnerLogs"].ToString();
                            hairShop.TravelInfo = sdr["TravelInfo"].ToString();
                            try
                            {
                                hairShop.HairCutDiscountMin = Convert.ToDecimal(sdr["HairCutPriceMin"].ToString());
                            }
                            catch
                            {
                                hairShop.HairCutDiscountMin = 0;
                            }
                            try
                            {
                                hairShop.HairMarcelDiscountMin = Convert.ToDecimal(sdr["HairMarcelPriceMin"].ToString());
                            }
                            catch
                            {
                                hairShop.HairMarcelDiscountMin = 0;
                            }
                            try
                            {
                                hairShop.HairDyeDiscountMin = Convert.ToDecimal(sdr["HairDyePriceMin"].ToString());
                            }
                            catch
                            {
                                hairShop.HairDyeDiscountMin = 0;
                            }
                            try
                            {
                                hairShop.HairShapeDiscountMin = Convert.ToDecimal(sdr["HairShapePriceMin"].ToString());
                            }
                            catch
                            {
                                hairShop.HairShapeDiscountMin = 0;
                            }
                            try
                            {
                                hairShop.HairConservationDiscountMin = Convert.ToDecimal(sdr["HairConservationPriceMin"].ToString());
                            }
                            catch
                            {
                                hairShop.HairConservationDiscountMin = 0;
                            }
                            try
                            {
                                hairShop.HairShopNormal = int.Parse(sdr["HairShopNormal"].ToString());
                            }
                            catch
                            {
                                hairShop.HairShopNormal = 0;
                            }
                            Decimal parseValue;

                            Decimal.TryParse(sdr["HairCutPrice"].ToString(), out parseValue);
                            hairShop.HairCutPirce = parseValue;
                            Decimal.TryParse(sdr["HairCutDiscount"].ToString(), out parseValue);
                            hairShop.HairCutDiscount = parseValue;
                            Decimal.TryParse(sdr["HairMarcelPrice"].ToString(), out parseValue);
                            hairShop.HairMarcelPrice = parseValue;
                            Decimal.TryParse(sdr["HairMarcelDiscount"].ToString(), out parseValue);
                            hairShop.HairMarcelDiscount = parseValue;

                            Decimal.TryParse(sdr["HairDyePrice"].ToString(), out parseValue);
                            hairShop.HairDyePrice = parseValue;
                            Decimal.TryParse(sdr["HairDyeDiscount"].ToString(), out parseValue);
                            hairShop.HairDyeDiscount = parseValue;

                            Decimal.TryParse(sdr["HairShapePrice"].ToString(), out parseValue);
                            hairShop.HairShapePrice = parseValue;
                            Decimal.TryParse(sdr["HairShapeDiscount"].ToString(), out parseValue);
                            hairShop.HairShapeDiscount = parseValue;
                            Decimal.TryParse(sdr["HairConservationPrice"].ToString(), out parseValue);
                            hairShop.HairConservationPrice = parseValue;
                            Decimal.TryParse(sdr["HairConservationDiscount"].ToString(), out parseValue);
                            hairShop.HairConservationDiscount = parseValue;

                            hairShop.LocationMapURL = sdr["LocationMapURL"].ToString();

                            if (sdr["IsServeMarcel"] == null || sdr["IsServeMarcel"].ToString() == "0")
                                hairShop.IsServeMarce = false;
                            else
                                hairShop.IsServeMarce = true;

                            if (sdr["IsServeDye"] == null || sdr["IsServeDye"].ToString() == "0")
                                hairShop.IsServeDye = false;
                            else
                                hairShop.IsServeDye = true;

                            if (sdr["IsServeHairCut"] == null || sdr["IsServeHairCut"].ToString() == "0")
                                hairShop.IsServeHairCut = false;
                            else
                                hairShop.IsServeHairCut = true;

                            hairShop.Square = sdr["Square"].ToString();
                            hairShop.Postid = int.Parse(sdr["postid"].ToString());
                        }
                    }
                }
            }

            return hairShop;
        }

        //public HairShop GetHairShopByEntityID(Int32 HairShopID)
        //{ }

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
                    commText = "select * from HairShop hs left join City c on hs.HairShopCityID=c.cityID left join MapZone m on hs.HairShopMapZoneID = m.MapZoneID left join HotZone h on hs.HairShopHotZoneID = h.HotZoneID left join TypeTable tt on hs.TypeID=tt.TypeID"+orderKey;
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShop hs left join City c on hs.HairShopCityID=c.cityID left join MapZone m on hs.HairShopMapZoneID = m.MapZoneID left join HotZone h on hs.HairShopHotZoneID = h.HotZoneID left join TypeTable tt on hs.TypeID=tt.TypeID" + orderKey;
                    break;
            }

            using (SqlDataReader sdr = SqlHelper.ExecuteReader(DataHelper2.SqlConnectionString, CommandType.Text, commText))
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
                    ///hairShop.HairShopPictureStoreIDs = sdr["HairShopPictureStoreIDs"].ToString();
                    //hairShop.HairShopMainIDs = sdr["HairShopMainIDs"].ToString();
                    //hairShop.HairShopPartialIDs = sdr["HairShopPartialIDs"].ToString();
                    hairShop.HairShopEngineerNum = int.Parse(sdr["HairShopEngineerNum"].ToString());
                    hairShop.HairShopOpenTime = sdr["HairShopOpenTime"].ToString();
                    //hairShop.HairShopOrderNum = int.Parse(sdr["HairShopOrderNum"].ToString());
                    hairShop.HairShopVisitNum = int.Parse(sdr["HairShopVisitNum"].ToString());
                    //hairShop.WorkRangeIDs = sdr["WorkRangeIDs"].ToString();
                    hairShop.HairShopWebSite = sdr["HairShopWebSite"].ToString();
                    hairShop.HairShopEmail = sdr["HairShopEmail"].ToString();
                    hairShop.HairShopDiscount = sdr["HairShopDiscount"].ToString();
                    hairShop.HairShopLogo = sdr["HairShopLogo"].ToString();
                    hairShop.TravelInfo = sdr["TravelInfo"].ToString();
                    
                    //    try
                    //    {
                    //        hairShop.HairShopRecommandNum = int.Parse(sdr["HairShopRecommandNum"].ToString());
                    //    }
                    //catch
                    //    {
                    //    hairShop.HairShopRecommandNum = 0;

                    //}
                    hairShop.HairShopCreateTime = sdr["HairShopCreateTime"].ToString();
                    hairShop.HairShopDescription = sdr["HairShopDescription"].ToString();
                    hairShop.ProductIDs = sdr["ProductIDs"].ToString();
                    hairShop.HairShopTagIDs = sdr["HairShopTagIDs"].ToString();
                    hairShop.HairShopShortName = sdr["HairShopShortName"].ToString();
                    //hairShop.IsBest = bool.Parse(sdr["IsBest"].ToString());
                    hairShop.IsJoin = bool.Parse(sdr["IsJoin"].ToString());
                    hairShop.TypeID = int.Parse(sdr["TypeID"].ToString());
                    hairShop.TypeName = sdr["TypeName"].ToString();
                    hairShop.IsPostStation = bool.Parse(sdr["IsPostStation"].ToString());
                    hairShop.IsPostMachine = bool.Parse(sdr["IsPostMachine"].ToString());
                    hairShop.HairShopGood = int.Parse(sdr["HairShopGood"].ToString());
                    hairShop.HairShopBad = int.Parse(sdr["HairShopBad"].ToString());
                    hairShop.OutLogs = sdr["outLogs"].ToString();
                    hairShop.InnerLogs = sdr["innerLogs"].ToString();
                    Decimal parseValue;

                    Decimal.TryParse(sdr["HairCutPrice"].ToString(), out parseValue);
                    hairShop.HairCutPirce = parseValue;
                    Decimal.TryParse(sdr["HairCutDiscount"].ToString(), out parseValue);
                    hairShop.HairCutDiscount = parseValue;
                    Decimal.TryParse(sdr["HairMarcelPrice"].ToString(), out parseValue);
                    hairShop.HairMarcelPrice = parseValue;
                    Decimal.TryParse(sdr["HairMarcelDiscount"].ToString(), out parseValue);
                    hairShop.HairMarcelDiscount = parseValue;

                    Decimal.TryParse(sdr["HairDyePrice"].ToString(), out parseValue);
                    hairShop.HairDyePrice = parseValue;
                    Decimal.TryParse(sdr["HairDyeDiscount"].ToString(), out parseValue);
                    hairShop.HairDyeDiscount = parseValue;

                    Decimal.TryParse(sdr["HairShapePrice"].ToString(), out parseValue);
                    hairShop.HairShapePrice = parseValue;
                    Decimal.TryParse(sdr["HairShapeDiscount"].ToString(), out parseValue);
                    hairShop.HairShapeDiscount = parseValue;
                    Decimal.TryParse(sdr["HairConservationPrice"].ToString(), out parseValue);
                    hairShop.HairConservationPrice = parseValue;
                    Decimal.TryParse(sdr["HairConservationDiscount"].ToString(), out parseValue);
                    hairShop.HairConservationDiscount = parseValue;

                    hairShop.LocationMapURL = sdr["LocationMapURL"].ToString();

                    if (sdr["IsServeMarcel"] == null || sdr["IsServeMarcel"].ToString() == "0")
                        hairShop.IsServeMarce = false;
                    else
                        hairShop.IsServeMarce = true;

                    if (sdr["IsServeDye"] == null || sdr["IsServeDye"].ToString() == "0")
                        hairShop.IsServeDye = false;
                    else
                        hairShop.IsServeDye = true;

                    if (sdr["IsServeHairCut"] == null || sdr["IsServeHairCut"].ToString() == "0")
                        hairShop.IsServeHairCut = false;
                    else
                        hairShop.IsServeHairCut = true;

                    hairShop.Square = sdr["Square"].ToString();
                    hairShop.HairShopNormal = int.Parse(sdr["HairShopNormal"].ToString());
                    hairShop.Postid = int.Parse(sdr["postid"].ToString());

                    list.Add(hairShop);
                }
            }

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Top">Top</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        public DataTable GetHairShopList(int Top, OrderKey key)
        {
            StringBuilder orderKey = new StringBuilder();
            orderKey.Append(" order by ");

            switch (key)
            {
                case OrderKey.ID:
                    orderKey.Append("HairShopID desc");
                    break;
                case OrderKey.CommentNum:
                    orderKey.Append("HairShopGood+hs.HairShopBad desc");
                    break;
                //case OrderKey.RecommandNum:
                //    orderKey.Append("HairShopRecommandNum desc");
                //    break;
                case OrderKey.HitNum:
                    orderKey.Append("HairShopVisitNum desc");
                    break;
                case OrderKey.OrderNum:
                    orderKey.Append("HairShopOrderNum desc");
                    break;
                default:
                    orderKey.Append("HairShopID desc");
                    break;

            }

            String cmdText = String.Empty;

            switch (Top)
            {
                case 0:
                    cmdText = @"SELECT HairShopID, HairShopName, HairShopVisitNum, 
                                CASE WHEN HairShopGood = 0 OR HairShopBad = 0 THEN 0 WHEN HairShopGood != 0 AND HairShopBad != 0
                                THEN HairShopGood/(HairShopGood + HairShopBad) END AS 'HairGoodPraisedRate',HairShopLogo
                                FROM HairShop " + orderKey.ToString();
                    break;
                default:
                    cmdText = "SELECT Top " + Top.ToString() + @" HairShopID, HairShopName, HairShopVisitNum,  
                                CASE WHEN HairShopGood = 0 OR HairShopBad = 0 THEN 0 WHEN HairShopGood != 0 AND HairShopBad != 0
                                THEN HairShopGood/(HairShopGood + HairShopBad) END AS 'HairGoodPraisedRate',HairShopLogo
                                FROM HairShop " + orderKey.ToString();
                    break;
            }

            DataTable table = new DataTable("HairShopInfo");
            DataColumnCollection columnList = table.Columns;

            foreach (string str in new String[] { "HairShopID", "HairShopName", "HairShopVisitNum",  "HairGoodPraisedRate", "HairShopLogo", })
            {
                columnList.Add(str);
            }

            table = SqlHelper.ExecuteDataset(DataHelper2.SqlConnectionString, CommandType.Text, cmdText).Tables[0];

            return table;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Top"></param>
        /// <param name="WhereCaused"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public DataTable GetHairShopList(int Top, String WhereCaused, OrderKey Key)
        {
            StringBuilder orderKey = new StringBuilder();
            orderKey.Append(" order by ");

            switch (Key)
            {
                case OrderKey.ID:
                    orderKey.Append("HairShopID desc");
                    break;
                case OrderKey.CommentNum:
                    orderKey.Append("HairShopGood+HairShopBad desc");
                    break;
                case OrderKey.RecommandNum:
                    orderKey.Append("HairShopRecommandNum desc");
                    break;
                case OrderKey.HitNum:
                    orderKey.Append("HairShopVisitNum desc");
                    break;
                case OrderKey.OrderNum:
                    orderKey.Append("HairShopOrderNum desc");
                    break;
                default:
                    orderKey.Append("HairShopID desc");
                    break;

            }

            String cmdText = String.Empty;

            switch (Top)
            {
                case 0:
                    cmdText = @"SELECT HairShopID, HairShopName, HairShopVisitNum, 
                                CASE WHEN HairShopGood = 0 OR HairShopBad = 0 THEN 0 WHEN HairShopGood != 0 AND HairShopBad != 0
                                THEN HairShopGood/(HairShopGood + HairShopBad) END AS 'HairGoodPraisedRate',HairShopLogo
                                FROM HairShop WHERE " + WhereCaused + orderKey.ToString();
                    break;
                default:
                    cmdText = "SELECT Top " + Top.ToString() + @" HairShopID, HairShopName, HairShopVisitNum, 
                                CASE WHEN HairShopGood = 0 OR HairShopBad = 0 THEN 0 WHEN HairShopGood != 0 AND HairShopBad != 0
                                THEN HairShopGood/(HairShopGood + HairShopBad) END AS 'HairGoodPraisedRate',HairShopLogo
                                FROM HairShop WHERE " + WhereCaused + orderKey.ToString();
                    break;
            }

            DataTable table = new DataTable("HairShopInfo");
            DataColumnCollection columnList = table.Columns;

            foreach (string str in new String[] { "HairShopID", "HairShopName", "HairShopVisitNum", "HairGoodPraisedRate", "HairShopLogo", })
            {
                columnList.Add(str);
            }

            table = SqlHelper.ExecuteDataset(DataHelper2.SqlConnectionString, CommandType.Text, cmdText).Tables[0];

            return table;
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
                    commText = "select * from HairShop hs left join City c on hs.HairShopCityID=c.cityID left join MapZone m on hs.HairShopMapZoneID = m.MapZoneID left join HotZone h on hs.HairShopHotZoneID = h.HotZoneID left join TypeTable tt on hs.TypeID=tt.TypeID where hs.HairShopName like '%" + hairShopName + "%'" + orderKey;
                    break;
                default:
                    commText = "select top "+count.ToString()+" * from HairShop hs left join City c on hs.HairShopCityID=c.cityID left join MapZone m on hs.HairShopMapZoneID = m.MapZoneID left join HotZone h on hs.HairShopHotZoneID = h.HotZoneID left join TypeTable tt on hs.TypeID=tt.TypeID where hs.HairShopName like '%" + hairShopName + "%'" + orderKey;
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
                                //hairShop.HairShopPictureStoreIDs = sdr["HairShopPictureStoreIDs"].ToString();
                                //HairShopMainIDs = sdr["HairShopMainIDs"].ToString();
                                //hairShop.HairShopPartialIDs = sdr["HairShopPartialIDs"].ToString();
                                hairShop.HairShopEngineerNum = int.Parse(sdr["HairShopEngineerNum"].ToString());
                                hairShop.HairShopOpenTime = sdr["HairShopOpenTime"].ToString();
                                //hairShop.HairShopOrderNum = int.Parse(sdr["HairShopOrderNum"].ToString());
                                hairShop.HairShopVisitNum = int.Parse(sdr["HairShopVisitNum"].ToString());
                                //hairShop.WorkRangeIDs = sdr["WorkRangeIDs"].ToString();
                                hairShop.HairShopWebSite = sdr["HairShopWebSite"].ToString();
                                hairShop.HairShopEmail = sdr["HairShopEmail"].ToString();
                                hairShop.HairShopDiscount = sdr["HairShopDiscount"].ToString();
                                hairShop.HairShopLogo = sdr["HairShopLogo"].ToString();
                                //hairShop.HairShopRecommandNum = int.Parse(sdr["HairShopRecommandNum"].ToString());
                                hairShop.HairShopCreateTime = sdr["HairShopCreateTime"].ToString();
                                hairShop.HairShopDescription = sdr["HairShopDescription"].ToString();
                                hairShop.ProductIDs = sdr["ProductIDs"].ToString();
                                hairShop.HairShopTagIDs = sdr["HairShopTagIDs"].ToString();
                                hairShop.HairShopShortName = sdr["HairShopShortName"].ToString();
                                //hairShop.IsBest = bool.Parse(sdr["IsBest"].ToString());
                                hairShop.IsJoin = bool.Parse(sdr["IsJoin"].ToString());
                                hairShop.TypeID = int.Parse(sdr["TypeID"].ToString());
                                hairShop.TypeName = sdr["TypeName"].ToString();
                                hairShop.IsPostStation = bool.Parse(sdr["IsPostStation"].ToString());
                                hairShop.IsPostMachine = bool.Parse(sdr["IsPostMachine"].ToString());
                                hairShop.HairShopGood = int.Parse(sdr["HairShopGood"].ToString());
                                hairShop.HairShopBad = int.Parse(sdr["HairShopBad"].ToString());
                                hairShop.OutLogs = sdr["outLogs"].ToString();
                                hairShop.InnerLogs = sdr["innerLogs"].ToString();
                                hairShop.HairShopNormal = int.Parse(sdr["HairShopNormal"].ToString());

                                hairShop.HairConservationDiscountMin = decimal.Parse(sdr["HairConservationPriceMin"].ToString());
                                hairShop.HairConservationPrice = decimal.Parse(sdr["HairConservationPrice"].ToString());
                                hairShop.HairCutDiscountMin = decimal.Parse(sdr["HairCutPriceMin"].ToString());
                                hairShop.HairCutPirce = decimal.Parse(sdr["HairCutPrice"].ToString());
                                hairShop.HairDyeDiscountMin = decimal.Parse(sdr["HairDyePriceMin"].ToString());
                                hairShop.HairDyePrice = decimal.Parse(sdr["HairDyePrice"].ToString());
                                hairShop.HairMarcelDiscountMin = decimal.Parse(sdr["HairMarcelPriceMin"].ToString());
                                hairShop.HairMarcelPrice = decimal.Parse(sdr["HairMarcelPrice"].ToString());
                                hairShop.HairShapeDiscountMin = decimal.Parse(sdr["HairShapePriceMin"].ToString());
                                hairShop.HairShapePrice = decimal.Parse(sdr["HairShapePrice"].ToString());
                                

                                list.Add(hairShop);
                            }
                        }
                    }
                }
            }

            return list;
        }
        public List<HairShop> GetHairShops(int count, string selectCondition, OrderKey ok,Sort sort)
        {
            List<HairShop> list = new List<HairShop>();

            string orderKey = " order by ";
            switch (ok)
            {
                case OrderKey.ID:
                    orderKey += "hs.HairShopID";
                    break;
                case OrderKey.CommentNum:
                    orderKey += "hs.HairShopGood+hs.HairShopBad";
                    break;
                case OrderKey.RecommandNum:
                    orderKey += "hs.HairShopRecommandNum";
                    break;
                case OrderKey.HitNum:
                    orderKey += "hs.HairShopVisitNum";
                    break;
                case OrderKey.OrderNum:
                    orderKey += "hs.HairShopOrderNum";
                    break;
                default:
                    orderKey += "hs.HairShopID";
                    break;

            }

            string commText = "";
            switch (count)
            {
                case 0:
                    commText = "select * from HairShop hs left join City c on hs.HairShopCityID=c.cityID left join MapZone m on hs.HairShopMapZoneID = m.MapZoneID left join HotZone h on hs.HairShopHotZoneID = h.HotZoneID left join TypeTable tt on hs.TypeID=tt.TypeID " + selectCondition + orderKey + " " + sort.ToString();
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShop hs left join City c on hs.HairShopCityID=c.cityID left join MapZone m on hs.HairShopMapZoneID = m.MapZoneID left join HotZone h on hs.HairShopHotZoneID = h.HotZoneID left join TypeTable tt on hs.TypeID=tt.TypeID " + selectCondition + orderKey + " " + sort.ToString();
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
                                //hairShop.HairShopPictureStoreIDs = sdr["HairShopPictureStoreIDs"].ToString();
                                //hairShop.HairShopMainIDs = sdr["HairShopMainIDs"].ToString();
                                //hairShop.HairShopPartialIDs = sdr["HairShopPartialIDs"].ToString();
                                hairShop.HairShopEngineerNum = int.Parse(sdr["HairShopEngineerNum"].ToString());
                                hairShop.HairShopOpenTime = sdr["HairShopOpenTime"].ToString();
                                //hairShop.HairShopOrderNum = int.Parse(sdr["HairShopOrderNum"].ToString());
                                hairShop.HairShopVisitNum = int.Parse(sdr["HairShopVisitNum"].ToString());
                                //hairShop.WorkRangeIDs = sdr["WorkRangeIDs"].ToString();
                                hairShop.HairShopWebSite = sdr["HairShopWebSite"].ToString();
                                hairShop.HairShopEmail = sdr["HairShopEmail"].ToString();
                                hairShop.HairShopDiscount = sdr["HairShopDiscount"].ToString();
                                hairShop.HairShopLogo = sdr["HairShopLogo"].ToString();
                                hairShop.TravelInfo = sdr["TravelInfo"].ToString();
                                //try
                                //{
                                //    hairShop.HairShopRecommandNum = int.Parse(sdr["HairShopRecommandNum"].ToString());
                                //}
                                //catch
                                //{
                                //    hairShop.HairShopRecommandNum = 0;
                                //}
                                hairShop.HairShopCreateTime = sdr["HairShopCreateTime"].ToString();
                                hairShop.HairShopDescription = sdr["HairShopDescription"].ToString();
                                hairShop.ProductIDs = sdr["ProductIDs"].ToString();
                                hairShop.HairShopTagIDs = sdr["HairShopTagIDs"].ToString();
                                hairShop.HairShopShortName = sdr["HairShopShortName"].ToString();
                                //hairShop.IsBest = bool.Parse(sdr["IsBest"].ToString());
                                hairShop.IsJoin = bool.Parse(sdr["IsJoin"].ToString());
                                hairShop.TypeID = int.Parse(sdr["TypeID"].ToString());
                                hairShop.TypeName = sdr["TypeName"].ToString();
                                hairShop.IsPostStation = bool.Parse(sdr["IsPostStation"].ToString());
                                hairShop.IsPostMachine = bool.Parse(sdr["IsPostMachine"].ToString());
                                hairShop.HairShopGood = int.Parse(sdr["HairShopGood"].ToString());
                                hairShop.HairShopBad = int.Parse(sdr["HairShopBad"].ToString());
                                try
                                {
                                    hairShop.Postid = int.Parse(sdr["postid"].ToString());
                                }
                                catch
                                {
                                    hairShop.Postid = 0;
                                }
                                hairShop.OutLogs = sdr["outLogs"].ToString();
                                hairShop.InnerLogs = sdr["innerLogs"].ToString();
                                hairShop.HairShopNormal = int.Parse(sdr["HairShopNormal"].ToString());
                                try
                                {
                                    hairShop.HairConservationDiscountMin = decimal.Parse(sdr["HairConservationPriceMin"].ToString());
                                }
                                catch
                                {
                                    hairShop.HairConservationDiscountMin = 0;
                                }
                                try
                                {
                                    hairShop.HairConservationPrice = decimal.Parse(sdr["HairConservationPrice"].ToString());
                                }
                                catch
                                {
                                    hairShop.HairConservationPrice = 0;
                                }
                                try
                                {
                                    hairShop.HairCutDiscountMin = decimal.Parse(sdr["HairCutPriceMin"].ToString());
                                }
                                catch
                                {
                                    hairShop.HairCutDiscountMin = 0;
                                }
                                try
                                {
                                    hairShop.HairCutPirce = decimal.Parse(sdr["HairCutPrice"].ToString());
                                }
                                catch
                                {
                                    hairShop.HairCutPirce = 0;
                                }
                                try
                                {
                                    hairShop.HairDyeDiscountMin = decimal.Parse(sdr["HairDyePriceMin"].ToString());
                                }
                                catch
                                {
                                    hairShop.HairDyeDiscountMin = 0;
                                }
                                try
                                {
                                    hairShop.HairDyePrice = decimal.Parse(sdr["HairDyePrice"].ToString());
                                }
                                catch
                                {
                                    hairShop.HairDyePrice = 0;
                                }
                                try
                                {
                                    hairShop.HairMarcelDiscountMin = decimal.Parse(sdr["HairMarcelPriceMin"].ToString());
                                }
                                catch
                                {
                                    hairShop.HairMarcelDiscountMin = 0;
                                }
                                try
                                {
                                    hairShop.HairMarcelPrice = decimal.Parse(sdr["HairMarcelPrice"].ToString());
                                }
                                catch
                                {
                                    hairShop.HairMarcelPrice = 0;
                                }
                                try
                                {
                                    hairShop.HairShapeDiscountMin = decimal.Parse(sdr["HairShapePriceMin"].ToString());
                                }
                                catch
                                {
                                    hairShop.HairShapeDiscountMin = 0;
                                }
                                try
                                {
                                    hairShop.HairShapePrice = decimal.Parse(sdr["HairShapePrice"].ToString());
                                }
                                catch
                                {
                                    hairShop.HairShapePrice = 0;
                                }

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
                string commText = "select * from HairShopRecommand hsr left join HairShop hs on hsr.HairShopRawID = hs.HairShopID left join City c on hs.HairShopCityID=c.cityID left join MapZone m on hs.HairShopMapZoneID = m.MapZoneID left join HotZone h on hs.HairShopHotZoneID = h.HotZoneID left join TypeTable tt on hs.TypeID=tt.TypeID where hsr.HairShopRecommandID = " + hairShopRecommandID.ToString();

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
                    commText = "select * from HairShopRecommand hsr left join HairShop hs on hsr.HairShopRawID = hs.HairShopID left join City c on hs.HairShopCityID=c.cityID left join MapZone m on hs.HairShopMapZoneID = m.MapZoneID left join HotZone h on hs.HairShopHotZoneID = h.HotZoneID left join TypeTable tt on hs.TypeID=tt.TypeID order by hsr.HairShopRecommandID desc";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * from HairShopRecommand hsr left join HairShop hs on hsr.HairShopRawID = hs.HairShopID left join City c on hs.HairShopCityID=c.cityID left join MapZone m on hs.HairShopMapZoneID = m.MapZoneID left join HotZone h on hs.HairShopHotZoneID = h.HotZoneID left join TypeTable tt on hs.TypeID=tt.TypeID order by hsr.HairShopRecommandID desc";
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
                                try
                                {
                                    hairShopRecommand.HairShopOrderNum = int.Parse(sdr["HairShopOrderNum"].ToString());
                                }
                                catch
                                {
                                    hairShopRecommand.HairShopOrderNum = 0;
                                }
                                try
                                {
                                    hairShopRecommand.HairShopVisitNum = int.Parse(sdr["HairShopVisitNum"].ToString());
                                }
                                catch
                                {
                                    hairShopRecommand.HairShopVisitNum = 0;
                                }
                                hairShopRecommand.WorkRangeIDs = sdr["WorkRangeIDs"].ToString();
                                hairShopRecommand.HairShopWebSite = sdr["HairShopWebSite"].ToString();
                                hairShopRecommand.HairShopEmail = sdr["HairShopEmail"].ToString();
                                hairShopRecommand.HairShopDiscount = sdr["HairShopDiscount"].ToString();
                                hairShopRecommand.HairShopLogo = sdr["HairShopLogo"].ToString();
                                try
                                {
                                    hairShopRecommand.HairShopRecommandNum = int.Parse(sdr["HairShopRecommandNum"].ToString());
                                }
                                catch
                                {
                                    hairShopRecommand.HairShopRecommandNum = 0;
                                }
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
                                try
                                {
                                    hairShopRecommand.HairShopGood = int.Parse(sdr["HairShopGood"].ToString());
                                }
                                catch
                                {
                                    hairShopRecommand.HairShopGood = 0;
                                }

                                try
                                {
                                    hairShopRecommand.HairShopBad = int.Parse(sdr["HairShopBad"].ToString());
                                }
                                catch
                                {
                                    hairShopRecommand.HairShopBad = 0;
                                }

                             
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
        public string GetTypeNameById(int id)
        {
           TypeTable typeTable = new TypeTable();

            string commText = "select * from TypeTable where id="+id.ToString ();

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
                            if (sdr.Read())
                            {
                               

                                typeTable.ID = int.Parse(sdr["TypeID"].ToString());
                                typeTable.IsVisible = Convert.ToBoolean(sdr["TypeVisible"].ToString());
                                typeTable.Name = sdr["TypeName"].ToString();

                                
                            }
                        }
                    }
                }
            }

            return typeTable.Name;
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


        public int AddHairShop(HairShop hairShop)
        {
            int newID = 0;
            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                string insertSQL = "INSERT INTO [hairshop] ([HairShopName], [HairShopCityID], [HairShopMapZoneID], [HairShopHotZoneID], [HairShopAddress], [HairShopPhoneNum], [HairShopEngineerNum], [HairShopOpenTime], [HairShopVisitNum], [HairShopWebSite], [HairShopEmail], [HairshopDiscount], [HairShopLogo], [HairShopCreateTime], [HairShopDescription], [ProductIDs], [HairShopTagIDs], [HairShopShortName], [IsJoin], [TypeID], [IsPostStation], [IsPostMachine], [HairShopGood], [HairShopBad],[HairCutPriceMin],[HairMarcelPriceMin],[HairDyePriceMin],[HairShapePriceMin],[HairConservationPriceMin]) VALUES ('" + hairShop.HairShopName + "', " + hairShop.HairShopCityID + ", " + hairShop.HairShopMapZoneID + ", " + hairShop.HairShopHotZoneID + ", '" + hairShop.HairShopAddress + "', '" + hairShop.HairShopPhoneNum +  "', " + hairShop.HairShopEngineerNum + ", '" + hairShop.HairShopOpenTime  + ", " + hairShop.HairShopVisitNum +  "', '" + hairShop.HairShopWebSite + "', '" + hairShop.HairShopEmail + "', '" + hairShop.HairShopDiscount + "', '" + hairShop.HairShopLogo +  ", '" + hairShop.HairShopCreateTime + "', '" + hairShop.HairShopDescription + "', '" + hairShop.ProductIDs + "', '" + hairShop.HairShopTagIDs + "', '" + hairShop.HairShopShortName  + "', '" + hairShop.IsJoin + "', " + hairShop.TypeID + ", '" + hairShop.IsPostStation + "', '" + hairShop.IsPostMachine + "', " + hairShop.HairShopGood + ", " + hairShop.HairShopBad + ","+hairShop.HairCutDiscountMin.ToString()+","+hairShop.HairMarcelDiscountMin.ToString()+","+hairShop.HairDyeDiscountMin.ToString()+","+hairShop.HairShapeDiscountMin.ToString()+","+hairShop.HairConservationDiscountMin.ToString()+");select @@identity;";

                SqlCommand cmd = new SqlCommand(insertSQL, conn);
                conn.Open();
                newID = int.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
                //显示调用Dispose方法会导致此方法不能在第一时间被GC回收,况且已经使用using,此处为何用Dispose()??!!
                cmd.Dispose();
                cmd = null;
            }

            return newID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="haiShop">haiShop</param>
        /// <returns></returns>
        public Int32 AddHairShopByUsingSP(HairShop hairShop)
        {
            SqlParameter[] Parameters = GetHairShopParameters();

            Parameters[0].Value = hairShop.HairShopID;
            Parameters[1].Value = hairShop.HairShopName;
            Parameters[2].Value = hairShop.HairShopCityID;
            Parameters[3].Value = hairShop.HairShopMapZoneID;
            Parameters[4].Value = hairShop.HairShopHotZoneID;
            Parameters[5].Value = hairShop.HairShopAddress;
            Parameters[6].Value = hairShop.HairShopPhoneNum;
            Parameters[7].Value = "";// hairShop.HairShopPictureStoreIDs;
            Parameters[8].Value = "";// hairShop.HairShopMainIDs;
            Parameters[9].Value = "";// hairShop.HairShopPartialIDs;
            Parameters[10].Value = hairShop.HairShopEngineerNum;
            Parameters[11].Value = hairShop.HairShopOpenTime;
            Parameters[12].Value = "";// hairShop.HairShopOrderNum;
            Parameters[13].Value = hairShop.HairShopVisitNum;
            Parameters[14].Value = "";// hairShop.WorkRangeIDs;
            Parameters[15].Value = hairShop.HairShopWebSite;
            Parameters[16].Value = hairShop.HairShopEmail;
            Parameters[17].Value = hairShop.HairShopDiscount;
            Parameters[18].Value = hairShop.HairShopLogo;
            Parameters[19].Value = "";// hairShop.HairShopRecommandNum;
            Parameters[20].Value = hairShop.HairShopCreateTime;
            Parameters[21].Value = hairShop.HairShopDescription;
            Parameters[22].Value = hairShop.ProductIDs;
            Parameters[23].Value = hairShop.HairShopTagIDs;
            Parameters[24].Value = hairShop.HairShopShortName;
            Parameters[25].Value = hairShop.HairShopShortName;
            Parameters[26].Value = "";// hairShop.IsBest;
            Parameters[27].Value = hairShop.IsJoin;
            Parameters[28].Value = hairShop.IsPostStation;
            Parameters[29].Value = hairShop.IsPostMachine;
            Parameters[30].Value = hairShop.HairShopGood;
            Parameters[31].Value = hairShop.HairShopBad;

            SqlHelper.ExecuteNonQuery(DataHelper2.SqlConnectionString, CommandType.StoredProcedure, "InsertHairShop", Parameters);

            return Int32.Parse(Parameters[32].Value.ToString());
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual SqlParameter[] GetHairShopParameters()
        {
            SqlParameter[] HairShopParameters = SqlHelperParameterCache.GetCachedParameterSet(DataHelper2.SqlConnectionString, SQL_HAIRSHOPPARMCACHE);

            if (HairShopParameters == null)
            {
                HairShopParameters = new SqlParameter[]{

                new SqlParameter("@HairShopID", SqlDbType.Int),
                new SqlParameter("@HairShopName", SqlDbType.VarChar,100),
                new SqlParameter("@HairShopCityID", SqlDbType.Int),
                new SqlParameter("@HairShopMapZoneID", SqlDbType.Int),
                new SqlParameter("@HairShopHotZoneID", SqlDbType.Int),
                new SqlParameter("@HairShopAddress", SqlDbType.VarChar, 100),
                new SqlParameter("@HairShopPhoneNum", SqlDbType.VarChar, 100),
                new SqlParameter("@HairShopPictureStoreIDs", SqlDbType.VarChar, 1024),
                new SqlParameter("@HairShopMainIDs", SqlDbType.VarChar, 1024),
                new SqlParameter("@HairShopPartialIDs", SqlDbType.VarChar, 1024),
                new SqlParameter("@HairShopEngineerNum", SqlDbType.Int),
                new SqlParameter("@HairShopOpenTime", SqlDbType.VarChar, 1024),
                new SqlParameter("@HairShopOrderNum", SqlDbType.Int),
                new SqlParameter("@HairShopVisitNum", SqlDbType.Int),
                new SqlParameter("@WorkRangeIDs", SqlDbType.VarChar, 1024),
                new SqlParameter("@HairShopWebSite", SqlDbType.VarChar, 1024),
                new SqlParameter("@HairShopEmail", SqlDbType.VarChar, 1024),
                new SqlParameter("@HairshopDiscount", SqlDbType.VarChar, 100),
                new SqlParameter("@HairShopLogo", SqlDbType.VarChar, 1024),
                new SqlParameter("@HairShopRecommandNum", SqlDbType.Int),
                new SqlParameter("@HairShopCreateTime", SqlDbType.VarChar, 100),
                new SqlParameter("@HairShopDescription", SqlDbType.Text),
                new SqlParameter("@ProductIDs", SqlDbType.VarChar, 1024),
                new SqlParameter("@HairShopTagIDs", SqlDbType.VarChar, 1024),
                new SqlParameter("@HairShopShortName", SqlDbType.VarChar, 100),
                new SqlParameter("@IsBest", SqlDbType.Bit),
                new SqlParameter("@IsJoin", SqlDbType.Bit),
                new SqlParameter("@TypeID", SqlDbType.Int),
                new SqlParameter("@IsPostStation", SqlDbType.Bit),
                new SqlParameter("@IsPostMachine", SqlDbType.Bit),
                new SqlParameter("@HairShopGood", SqlDbType.Int),
                new SqlParameter("@HairShopBad", SqlDbType.Int),
                new SqlParameter("@ReturnValue", SqlDbType.Int, 4,ParameterDirection.Output,
                    false, byte.MinValue, byte.MinValue, String.Empty, DataRowVersion.Default, null)
                };
            }

            SqlHelperParameterCache.CacheParameterSet(DataHelper2.SqlConnectionString, SQL_HAIRSHOPPARMCACHE, HairShopParameters);

            return HairShopParameters;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="coupon"></param>
        /// <param name="action"></param>
        public void CouponCreateDeleteUpdate(Coupon coupon, UserAction action)
        {
            SqlParameter[] Parameters = GetCouponParameters();

            Parameters[0].Value = coupon.ID;
            Parameters[1].Value = coupon.Name;
            Parameters[2].Value = coupon.HairShopID;
            Parameters[3].Value = coupon.Discount;
            Parameters[4].Value = coupon.ExpiredDate;
            Parameters[5].Value = coupon.PhoneNumber;
            Parameters[6].Value = coupon.CouponTag;
            Parameters[7].Value = coupon.Description;
            Parameters[8].Value = coupon.ImageUrl;
            Parameters[9].Value = coupon.PostID;
            Parameters[10].Value = coupon.ImageSmallUrl;

            if (action == UserAction.Create)
                SqlHelper.ExecuteNonQuery(DataHelper2.SqlConnectionString, CommandType.StoredProcedure, "InsertCoupon", Parameters);

            if (action == UserAction.Update)
                SqlHelper.ExecuteNonQuery(DataHelper2.SqlConnectionString, CommandType.StoredProcedure, "UpdateCoupon", Parameters);

            if (action == UserAction.Delete)
                SqlHelper.ExecuteNonQuery(DataHelper2.SqlConnectionString, CommandType.StoredProcedure, "DeleteCoupon", Parameters[0]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual SqlParameter[] GetCouponParameters()
        {
            SqlParameter[] CouponParameters = SqlHelperParameterCache.GetCachedParameterSet(DataHelper2.SqlConnectionString, SQL_COUPONPARMCACHE);

            if (CouponParameters == null)
            {
                CouponParameters = new SqlParameter[]{

                new SqlParameter("@ID", SqlDbType.Int),
                new SqlParameter("@Name",SqlDbType.NVarChar,256),
                new SqlParameter("@HairShopID",SqlDbType.Int),
                new SqlParameter("@Discount",SqlDbType.NVarChar, 256),
                new SqlParameter("@ExpiredDate",SqlDbType.NVarChar,64),
                new SqlParameter("@PhoneNumber",SqlDbType.NVarChar,32),
                new SqlParameter("@CouponTag",SqlDbType.NVarChar,1024),
                new SqlParameter("@Description",SqlDbType.NVarChar,1024),
                new SqlParameter("@ImageUrl",SqlDbType.VarChar,1024),
                new SqlParameter("@PostID",SqlDbType.Int,4),
                new SqlParameter("@ImageSmallUrl",SqlDbType.VarChar,1024),
                };
            }

            SqlHelperParameterCache.CacheParameterSet(DataHelper2.SqlConnectionString, SQL_COUPONPARMCACHE, CouponParameters);

            return CouponParameters;
        }

        public string GetHairShopTagIDs(string tagNames)
        {
            string[] tags = tagNames.Split(',');
            List<string> list = new List<string>();
            foreach (string tag in tags)
            {
                list.Add(this.AddHairShopTag(tag).ToString());
            }
            return string.Join(",", list.ToArray());
        }

        public string GetHairShopTagNames(string tagIDs)
        {
            string[] ids = tagIDs.Split(',');
            List<string> list = new List<string>();
            foreach (string id in ids)
            {
                list.Add(this.GetHairShopTagByHairShopTagID(int.Parse(id)).TagName);
            }
            return string.Join(",", list.ToArray());
        }

        private int AddHairShopTag(string name)
        {
            int TagID = 0;

            string strsql = "select HairShopTagID from HairShopTag where HairShopTagName='" + name + "'";
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
                        strsql = "insert into HairShopTag(HairShopTagName,HairShopIDs) values('" + name + "','');select @@identity as 'id';";
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
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable GetCouponList()
        {
            return SqlHelper.ExecuteDataset(DataHelper2.SqlConnectionString, CommandType.Text, 
                "select * from Coupon left join HairShop ON Coupon.HairShopID = HairShop.HairShopID").Tables[0];
        }

        //public List<Coupon> GetCouponListByShopId(int shopId)
        //{

        //}
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="couponID"></param>
        public void DeleteCoupon(String couponID)
        {
            SqlHelper.ExecuteNonQuery(DataHelper2.SqlConnectionString, CommandType.Text,
                "DELETE FROM Coupon WHERE ID = " + couponID);
        }
    }
}
