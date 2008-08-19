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
        /// ���City�б�
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
        /// City ��ӣ�ɾ�����޸�
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
                    commandText = "UPDATE City SET CityID = " + city.ID  + ", CityName = '" + city.Name  + "', CityVisible = " + city.IsVisible +" where CityID = "+city.ID  ;
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
        /// ͨ��CityID��������б�
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
                                mapz.IsVisible = bool.Parse(reader["MapZoneVisible"].ToString());
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
        /// ���� ��ӣ�ɾ�����޸�
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
                    commandText = "UPDATE MapZone SET MapZoneID = " + mapZone.ID + ", mapZoneName = '" + mapZone.Name + "', mapZoneVisible = " + mapZone.IsVisible +",CityID="+mapZone.CityID +" where MapZoneID="+mapZone.ID ;
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
        /// ͨ������ID���ߵض�
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
                                hotz.IsVisible = bool.Parse(reader["HotZoneVisible"].ToString());
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
        /// �ض� ��ӣ�ɾ�����޸�
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
                    commandText = "UPDATE HotZone SET HotZoneID = " + hotZone.ID + ", HotZoneName = '" +hotZone.Name + "', HotZoneVisible = " + hotZone.IsVisible + ",MapZoneID=" + hotZone.MapZoneID +" where HotZoneID = "+hotZone.ID;
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

        //�۸�Χ���б����幦�ܻ�û����ӵ�����ʦ�������������У�������Ʒ�С��ȴ����������

        /// <summary>
        /// ��ü۸�Χ�б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<PriceRange> GetPriceRanges(int count)
        {
            List<PriceRange> list = new List<PriceRange>();
            string commText = string.Empty; 

            switch (count)
            {
                case 0:
                    commText = "SELECT PriceRange.* FROM PriceRange ORDER BY PriceRangeID DESC";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * FROM PriceRange ORDER BY PriceRangeID DESC";
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

                        using (SqlDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PriceRange price = new PriceRange();

                                price.ID = int.Parse(reader["PriceRangeID"].ToString());
                                
                                price.IsVisible = bool.Parse(reader["PriceRangeVisible"].ToString());
                                price.Name = reader["PriceRangeName"].ToString();

                                list.Add(price);
                            }
                        }
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// �۸�Χ ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="priceRange"></param>
        /// <returns></returns>
        public bool PriceRangeCreateDeleteUpdate(PriceRange priceRange, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "INSERT INTO PriceRange (PriceRangeID, PriceRangeName, PriceRangeVisible) VALUES (" +
                        priceRange.ID + ", '" + priceRange.Name + "'," + priceRange.IsVisible + ") ";
                    break;
                case UserAction.Delete:
                    commandText = "DELETE FROM PriceRange   where PriceRangeID=" + priceRange.ID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "UPDATE PriceRange SET PriceRangeID = " + priceRange.ID + ", PriceRangeName = '" + priceRange.Name + "', PriceRangeVisible = " + priceRange.IsVisible + " where PriceRangeID ="+priceRange.ID ;
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

        //����ʽ�������ݲ���д�����Ǹ��������ͼ��Ƶ����󣬵��ǣ��۲��ʺ�


        /// <summary>
        /// ͨ��GROUPID��ȡ����Ƶ���ؼ����б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairNetTag> GetHairNetTagsByHairNetTagGroupID(int hairNetTagGroupID)
        {
            List<HairNetTag> list = new List<HairNetTag>();

            string commText = "SELECT * FROM HairNetTag where HairNetTagGroupID=" + hairNetTagGroupID;
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
                                HairNetTag tag = new HairNetTag();
                                tag.TagID  = int.Parse(reader["HairNetTagID"].ToString());
                                tag.TagName = reader["HairNetTagName"].ToString();
                                tag.HairNetTagGroupID = int.Parse (reader["HairNetTagGroupID"].ToString());
                                // there is no ids?
                                list.Add(tag);

                            }
                        }
                    }
                }
            }
            return list;
        }


        /// <summary>
        /// ����Ƶ���ؼ��� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hairNetTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairNetTagCreateDeleteUpdate(HairNetTag hairNetTag, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "INSERT INTO HairNetTag  (HairNetTagID, HairNetTagName, HairNetTagGroupID) VALUES (" + hairNetTag.TagID + ", '" + hairNetTag.TagName + "', '" + hairNetTag.HairNetTagGroupID + "')";
                    break;
                case UserAction.Delete:
                    commandText = "DELETE FROM HairNetTag WHERE (HairNetTagID = " + hairNetTag.TagID + ")";
                    break;
                case UserAction.Update:
                    commandText = "UPDATE HairNetTag SET HairNetTagName ='" + hairNetTag.TagName + "', HairNetTagGroupID =" + hairNetTag.HairNetTagGroupID + " WHERE (HairNetTagID = " + hairNetTag.TagID + ")";
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
        /// �������Ƶ���ؼ��ַ����б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairNetTagGroup> GetHairNetTagGroups(int count)
        {
            List<HairNetTagGroup> list = new List<HairNetTagGroup>();
            string commText = string.Empty;

            switch (count)
            {
                case 0:
                    commText = "SELECT * FROM HairNetTagGroup ORDER BY HairNetTagGroupID DESC";
                    break;
                default:
                    commText = "select top " + count.ToString() + " * FROM HairNetTagGroup ORDER BY HairNetTagGroupID DESC";
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

                        using (SqlDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                HairNetTagGroup tag = new HairNetTagGroup();
                                tag.ID  = int.Parse(reader["HairNetTagGroupID"].ToString());
                                tag.Name = reader["HairNetTagGroupName"].ToString();
                                
                               
                                list.Add(tag);

                            }
                        }
                    }
                }
            }

            return list;
        }

        /// <summary>
        /// ����Ƶ���ؼ��ַ��� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hairNetTagGroup"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairNetTagGroupCreateDeleteUpdate(HairNetTagGroup hairNetTagGroup, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "INSERT INTO HairNetTagGroup  (HairNetTagGroupID, HairNetTagGroupName) VALUES (" + hairNetTagGroup.ID + ", '" + hairNetTagGroup.Name + "')";
                    break;
                case UserAction.Delete:
                    commandText = "DELETE FROM HairNetTagGroup WHERE (HairNetTagGroupID = " + hairNetTagGroup.ID + ")";
                    break;
                case UserAction.Update:
                    commandText = "UPDATE HairNetTagGroup SET HairNetTagGroupName ='" + hairNetTagGroup.Name + "' WHERE (HairNetTagGroupID = " + hairNetTagGroup.ID + ")";
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
