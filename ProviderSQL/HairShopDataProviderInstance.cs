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
        public bool HairShopDataPrividerCreateDeleteUpdate(HairShop hairShop, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairShop(HairShopName,HairShopCityID,HairShopMapZoneID,HairShopHotZoneID,HairShopAddress,HairShopPhoneNum,HairShopPictureStoreIDs,HairShopMainIDs,HairShopPartialIDs,HairShopEngineerNum,HairShopOpenTime,WorkRangeIDs,HairShopWebSite,HairShopEmail,HairShopDiscount,HairShopLogo,HairShopCreateTime,HairShopDescription,ProductIDs,HairShopTagIDs,HairShopShortName,IsBest,IsJoin,TypeID,IsPostStation,IsPostMachine) values('"+hairShop.HairShopName+"',"+hairShop.HairShopCityID.ToString()+","+hairShop.HairShopMapZoneID.ToString()+","+hairShop.HairShopHotZoneID.ToString()+",'"+hairShop.HairShopAddress+"','"+hairShop.HairShopPhoneNum+"','"+hairShop.HairShopPictureStoreIDs+"','"+hairShop.HairShopMainIDs+"','"+hairShop.HairShopPartialIDs+"',"+hairShop.HairShopEngineerNum.ToString()+",'"+hairShop.HairShopOpenTime+"','"+hairShop.WorkRangeIDs+"','"+hairShop.HairShopWebSite+"','"+hairShop.HairShopEmail+"','"+hairShop.HairShopDiscount+"','"+hairShop.HairShopLogo+"','"+hairShop.HairShopCreateTime+"','"+hairShop.HairShopDescription+"','"+hairShop.ProductIDs+"','"+hairShop.HairShopTagIDs+"','"+hairShop.HairShopShortName+"',"+hairShop.IsBest.CompareTo(true).ToString()+","+hairShop.IsJoin.CompareTo(true).ToString()+","+hairShop.TypeID.ToString()+","+hairShop.IsPostStation.CompareTo(true).ToString()+","+hairShop.IsPostMachine.CompareTo(true).ToString()+")";
                    break;
                case UserAction.Delete:
                    commandText = "";
                    break;
                case UserAction.Update:
                    commandText = "";
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
            return result;
        }
    }
}
