using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;
using System.Data.SqlClient;

namespace HairNet.Provider
{
    public class CommonDataProviderInstance :ICommonDataProvider
    {   
        /// <summary>
        /// 获得City列表
        /// </summary>
        /// <returns></returns>
        public List<City> GetCitys() 
        {
            List<City> list = new List<City>();
            string commText = "Select * from City order by CityName";
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
                                City  city = new City();

                                city.ID  = int.Parse(reader["CityID"].ToString());
                                city.IsVisible  = bool.Parse(reader["CityVisible"].ToString());
                                city.Name  = reader["CityName"].ToString();

                                list.Add(city);
                            }
                        }
                    }
                }
            } 
            return list;
        }

        /// <summary>
        /// City 添加，删除，修改
        /// </summary>
        /// <param name="city"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool CityCreateDeleteUpdate(City city, UserAction ua)
        {
            bool result = false;
          
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "INSERT INTO City (CityID, CityName, CityVisible) " +
                            " VALUES (" + city.ID + ",'" + city.Name + "'," + city.IsVisible + ")";
                            break;
                case UserAction.Delete:
                    commandText = "DELETE FROM City   where CityID=" + city.ID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "UPDATE City SET CityID = " + city.ID  + ", CityName = '" + city.Name  + "', CityVisible = " + city.IsVisible  ;
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
                    commandText = "delete from MapZone where CityID=" + city.ID.ToString();
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
        /// 通过CityID获得区域列表
        /// </summary>
        /// <param name="cityID"></param>
        /// <returns></returns>
        public List<MapZone> GetMapZonesByCityID(int cityID)
        {
            List<MapZone> list = new List<MapZone>();

            string commText = "select * from MapZone where CityID = "+cityID ;
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
                                MapZone mapz = new MapZone();

                                mapz.CityID = int.Parse(reader["CityID"].ToString());
                                mapz.ID = int.Parse(reader["MapZoneID"].ToString());
                                mapz.IsVisible = bool.Parse(reader["MapZoneID"].ToString());
                                mapz.Name = reader["MapZoneName"].ToString();

                                list.Add(mapz);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 区域 添加，删除，修改
        /// </summary>
        /// <param name="mapZone"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool MapZoneCreateDeleteUpdate(MapZone mapZone, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "INSERT INTO MapZone (MapZoneID, MapZoneName, MapZoneVisible,CityID) " +
                            " VALUES (" + mapZone.ID + ",'" + mapZone.Name + "'," + mapZone.IsVisible + ","+mapZone.CityID +")";
                    break;
                case UserAction.Delete:
                    commandText = "DELETE FROM MapZone   where MapZoneID=" + mapZone.ID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "UPDATE MapZone SET MapZoneID = " + mapZone.ID + ", mapZoneName = '" + mapZone.Name + "', mapZoneVisible = " + mapZone.IsVisible +",CityID="+mapZone.CityID ;
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
        /// 通过区域ID或者地段
        /// </summary>
        /// <param name="MapZoneID"></param>
        /// <returns></returns>
        public List<HotZone> GetHotZonesByMapZoneID(int MapZoneID)
        {
            List<HotZone> list = new List<HotZone>();
            string commText = "select * from HotZone where MapZoneID = " + MapZoneID;
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
                                HotZone hotz = new HotZone();

                                hotz.MapZoneID = int.Parse(reader["MapZoneID"].ToString());
                                hotz.ID = int.Parse(reader["HotZoneID"].ToString());
                                hotz.IsVisible = bool.Parse(reader["HotZoneID"].ToString());
                                hotz.Name = reader["HotZoneName"].ToString();

                                list.Add(hotz);
                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// 地段 添加，删除，修改
        /// </summary>
        /// <param name="hotZone"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HotZoneCreateDeleteUpdate(HotZone hotZone, UserAction ua)
        {
            bool result = false;

            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "INSERT INTO HotZone (HotZoneID, HotZoneName, HotZoneVisible,CityID) " +
                            " VALUES (" + hotZone.ID + ",'" + hotZone.Name + "'," + hotZone.IsVisible + "," + hotZone.ID + ")";
                    break;
                case UserAction.Delete:
                    commandText = "DELETE FROM HotZone   where HotZoneID=" + hotZone.ID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "UPDATE HotZone SET HotZoneID = " + hotZone.ID + ", HotZoneName = '" +hotZone.Name + "', HotZoneVisible = " + hotZone.IsVisible + ",MapZoneID=" + hotZone.MapZoneID;
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

        //价格范围，列表，具体功能还没有添加到美发师，美发厅，还有，美发产品中。等待天天的需求

        /// <summary>
        /// 获得价格范围列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<PriceRange> GetPriceRanges(int count)
        {
            List<PriceRange> list = new List<PriceRange>();


            return list;
        }

        /// <summary>
        /// 价格范围 添加，删除，修改
        /// </summary>
        /// <param name="priceRange"></param>
        /// <returns></returns>
        public bool PriceRangeCreateDeleteUpdate(PriceRange priceRange)
        {
            bool result = false;
            return result;
        }

        //排序方式，现在暂不书写，这是根据天天的图设计的需求，但是，咱不适合


        /// <summary>
        /// 通过GROUPID获取美发频道关键字列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairNetTag> GetHairNetTagsByHairNetTagGroupID(int hairNetTagGroupID)
        {
            List<HairNetTag> list = new List<HairNetTag>();
            return list;
        }


        /// <summary>
        /// 美发频道关键字 添加，删除，修改
        /// </summary>
        /// <param name="hairNetTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairNetTagCreateDeleteUpdate(HairNetTag hairNetTag, UserAction ua)
        {
            bool result = false;

            return result;
        }

        /// <summary>
        /// 获得美发频道关键字分类列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairNetTagGroup> GetHairNetTagGroups(int count)
        {
            List<HairNetTagGroup> list = new List<HairNetTagGroup>();
            return list;
        }

        /// <summary>
        /// 美发频道关键字分类 添加，删除，修改
        /// </summary>
        /// <param name="hairNetTagGroup"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairNetTagGroupCreateDeleteUpdate(HairNetTagGroup hairNetTagGroup, UserAction ua)
        {
            bool result = false;

            return result;
        }
    }
}
