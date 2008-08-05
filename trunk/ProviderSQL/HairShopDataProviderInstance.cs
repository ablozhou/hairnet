using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;
using System.Data.SqlClient;

namespace HairNet.Provider
{
    public class HairShopDataProviderInstance : HairShopDataProvider
    {
        public override bool HairShopDataPrividerCreateDeleteUpdate(HairShop hairShop, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into HairShop(HairShopName,HairShopCityID,HairShopMapZoneID,HairShopHotZoneID,HairShopAddress,HairShopPhoneNum,HairShopPictureStoreIDs,HairShopMainIDs,HairShopPartialIDs,HairShopEngineerNum,HairShopOpenTime,WorkRangeIDs,HairShopWebSite,HairShopEmail,HairShopDiscount,HairShopLogo,HairShopCreateTime,HairShopDescription,ProductIDs,HairShopTagIDs,HairShopShortName,IsBest,IsJoin,TypeID,IsPostStation,IsPostMachine) values('name',0,0,0,'address','phonenum','picturestoreids','mainids','partialIDs',0,'opentime','workids','website','email','discount','logo','createtime','description','productids','tagsids','shortname',0,0,0,0,0)";
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
