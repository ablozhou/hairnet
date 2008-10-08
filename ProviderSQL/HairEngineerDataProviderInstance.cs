using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using HairNet.Entry;
using HairNet.Enumerations;

using HairNet.DBUtility;

namespace HairNet.Provider
{
    
    public class HairEngineerDataProviderInstance : IHairEngineerDataProvider
    {
        private const string SQL_ENGINEEROPUSPARMCACHE = "ENGINEEROPUSPARMCACHE";

        /// <summary>
        /// 美发师
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
                    commandText = "insert into HairEngineer(HairEngineerAge,HairEngineerName,HairEngineerSex,HairEngineerPhoto,HairShopID,HairEngineerYear,HairEngineerSkill,HairEngineerTagIDs,HairEngineerPictureStoreIDs,HairEngineerDescription,HairEngineerRawPrice,HairEngineerPrice,HairEngineerClassID,HairEngineerConstellation,isimportant,hairengineerphotoids) values('" + hairEngineer.HairEngineerAge + "','" + hairEngineer.HairEngineerName + "'," + hairEngineer.HairEngineerSex.ToString() + ",'" + hairEngineer.HairEngineerPhoto + "'," + hairEngineer.HairShopID.ToString() + ",'" + hairEngineer.HairEngineerYear + "','" + hairEngineer.HairEngineerSkill + "','" + hairEngineer.HairEngineerTagIDs + "','" + hairEngineer.HairEngineerPictureStoreIDs + "','" + hairEngineer.HairEngineerDescription + "','" + hairEngineer.HairEngineerRawPrice + "','" + hairEngineer.HairEngineerPrice + "'," + hairEngineer.HairEngineerClassID.ToString() + ",'" + hairEngineer.HairEngineerConstellation + "','"+hairEngineer.IsImportant.CompareTo(false).ToString()+"','"+hairEngineer.HairEngineerPhotoIDs+"')";
                    commandText += ";select @@identity;";
                    break;
                case UserAction.Delete:
                    commandText = "delete from HairEngineer where HairEngineerID="+hairEngineer.HairEngineerID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update HairEngineer set HairEngineerAge='" + hairEngineer.HairEngineerAge + "',HairEngineerName='" + hairEngineer.HairEngineerName + "',HairEngineerSex=" + hairEngineer.HairEngineerSex.ToString() + ",HairEngineerPhoto='" + hairEngineer.HairEngineerPhoto + "',HairShopID=" + hairEngineer.HairShopID.ToString() + ",HairEngineerYear='" + hairEngineer.HairEngineerYear + "',HairEngineerSkill='" + hairEngineer.HairEngineerSkill + "',HairEngineerTagIDs='" + hairEngineer.HairEngineerTagIDs + "',HairEngineerPictureStoreIDs='" + hairEngineer.HairEngineerPictureStoreIDs + "',HairEngineerDescription='" + hairEngineer.HairEngineerDescription + "',HairEngineerRawPrice='" + hairEngineer.HairEngineerRawPrice + "',HairEngineerPrice='" + hairEngineer.HairEngineerPrice + "',HairEngineerClassID=" + hairEngineer.HairEngineerClassID.ToString() + ",HairEngineerConstellation ='" + hairEngineer.HairEngineerConstellation + "',IsImportant='"+hairEngineer.IsImportant.CompareTo(false).ToString()+"',HairEngineerPhotoIDs='"+hairEngineer.HairEngineerPhotoIDs+"' where HairEngineerID = " + hairEngineer.HairEngineerID.ToString();
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
        /// 
        /// </summary>
        /// <param name="engineerOpusInfo"></param>
        /// <param name="action"></param>
        public void HairStyleCreateDeleteUpdate(HairStyleEntity hairStyle, UserAction action)
        {
            SqlParameter[] parameters = GetEngineerOpusParameters();

            parameters[0].Value = hairStyle.ID;
            parameters[1].Value = hairStyle.HairName;
            parameters[2].Value = hairStyle.HairStyle;
            parameters[3].Value = hairStyle.FaceStyle;
            parameters[4].Value = hairStyle.Temperament;
            parameters[5].Value = hairStyle.Occasion;
            parameters[6].Value = hairStyle.Sex;

            parameters[7].Value = hairStyle.BigPic;
            parameters[8].Value = hairStyle.SmallPic_F;
            parameters[9].Value = hairStyle.SmallPic_B;
            parameters[10].Value = hairStyle.SmallPic_S;
            parameters[11].Value = hairStyle.Pic1;
            parameters[12].Value = hairStyle.Pic2;
            parameters[13].Value = hairStyle.Pic3;

            parameters[14].Value = hairStyle.HairShopID;
            parameters[15].Value = hairStyle.HairEngineerID;
            parameters[16].Value = hairStyle.HairQuantity;
            parameters[17].Value = hairStyle.HairNature;
            parameters[18].Value = hairStyle.HairColor;

            parameters[19].Value = hairStyle.CreateTime;
            parameters[20].Value = hairStyle.BBSURL;
            parameters[21].Value = hairStyle.Good;
            parameters[22].Value = hairStyle.Normal;
            parameters[23].Value = hairStyle.Bad;
            parameters[24].Value = hairStyle.Tag;
            

            if (action == UserAction.Create)
                SqlHelper.ExecuteNonQuery(DataHelper2.SqlConnectionString, CommandType.StoredProcedure,
                    "InsertHairStyle", parameters);

            if (action == UserAction.Update)
                SqlHelper.ExecuteNonQuery(DataHelper2.SqlConnectionString, CommandType.StoredProcedure,
                    "UpdateHairStyle", parameters);

            if (action == UserAction.Delete)
                SqlHelper.ExecuteNonQuery(DataHelper2.SqlConnectionString, CommandType.StoredProcedure,
                    "DeleteHairStyle", parameters[0]);
        }
        /// <summary>
        /// 获取发型表
        /// </summary>
        /// <param name="hairStyleName"></param>
        /// <returns></returns>
        /// <author>zhh</author>
        /// <date>2008.10.5</date>
       public List<HairStyleEntity> GetHairStyleListByName(string hairStyleName)
        {
             SqlParameter parameter = new SqlParameter("@hairname", SqlDbType.Text);
             parameter.Value = hairStyleName;

             List<HairStyleEntity> valueList = new List<HairStyleEntity>();
             using (SqlDataReader Reader = SqlHelper.ExecuteReader(DataHelper2.SqlConnectionString, CommandType.StoredProcedure,
            "QueryHairStyleByName", parameter))
             {
                 while (Reader.Read())
                     valueList.Add(new HairStyleEntity(Reader.GetInt32(0), Reader.GetString(1), Reader.GetByte(2), Reader.GetByte(3),
                         Reader.GetByte(4), Reader.GetByte(5), Reader.GetByte(6), Reader.GetString(7), Reader.GetString(8), Reader.GetString(9),
                         Reader.GetString(10), Reader.GetString(11), Reader.GetString(12), Reader.GetString(13), Reader.GetInt32(14),
                         Reader.GetInt32(15), Reader.GetByte(16), Reader.GetByte(17), Reader.GetByte(18), Reader.GetDateTime(19),
                         Reader.GetString(20), Reader.GetInt32(21), Reader.GetInt32(22), Reader.GetInt32(23), Reader.GetString(24)));
             }

             return valueList;
        }

        /// <summary>
        /// 获取发型表
        /// </summary>
        /// <param name="hairStyleName"></param>
        /// <returns></returns>
        /// <author>zhh</author>
        /// <date>2008.10.5</date>
        public List<HairStyleEntity> GetHairStyleList()
        {
           
            List<HairStyleEntity> valueList = new List<HairStyleEntity>();
            using (SqlDataReader Reader = SqlHelper.ExecuteReader(DataHelper2.SqlConnectionString, CommandType.StoredProcedure,
           "QueryHairStyle", null))
            {
                while (Reader.Read())
                    valueList.Add(new HairStyleEntity(Reader.GetInt32(0), Reader.GetString(1), Reader.GetByte(2), Reader.GetByte(3),
                        Reader.GetByte(4), Reader.GetByte(5), Reader.GetByte(6), Reader.GetString(7), Reader.GetString(8), Reader.GetString(9),
                        Reader.GetString(10), Reader.GetString(11), Reader.GetString(12), Reader.GetString(13), Reader.GetInt32(14),
                        Reader.GetInt32(15), Reader.GetByte(16), Reader.GetByte(17), Reader.GetByte(18), Reader.GetDateTime(19),
                        Reader.GetString(20), Reader.GetInt32(21), Reader.GetInt32(22), Reader.GetInt32(23), Reader.GetString(24)));
            }

            return valueList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="engineerID"></param>
        /// <returns></returns>
        public List<HairStyleEntity> GetEngineerOpusByEngineerID(Int32 engineerID)
        {
            SqlParameter parameter = new SqlParameter("@EngineerID", SqlDbType.Int);
            parameter.Value = engineerID;

            List<HairStyleEntity> valueList = new List<HairStyleEntity>();

            using (SqlDataReader Reader = SqlHelper.ExecuteReader(DataHelper2.SqlConnectionString, CommandType.StoredProcedure,
                "QueryHairStyleByEngineerID", parameter))
            {
                while (Reader.Read())
                    valueList.Add(new HairStyleEntity(Reader.GetInt32(0), Reader.GetString(1), Reader.GetByte(2), Reader.GetByte(3),
                        Reader.GetByte(4), Reader.GetByte(5), Reader.GetByte(6), Reader.GetString(7), Reader.GetString(8), Reader.GetString(9),
                        Reader.GetString(10), Reader.GetString(11), Reader.GetString(12), Reader.GetString(13), Reader.GetInt32(14),
                        Reader.GetInt32(15), Reader.GetByte(16), Reader.GetByte(17), Reader.GetByte(18), Reader.GetDateTime(19),
                        Reader.GetString(20), Reader.GetInt32(21), Reader.GetInt32(22), Reader.GetInt32(23), Reader.GetString(24)));
            }

            return valueList;

        } /// <summary>
        /// 
        /// </summary>
        /// <param name="engineerID"></param>
        /// <returns></returns>
        public List<HairStyleEntity> GetHairStyleListByID(Int32 ID)
        {
            SqlParameter parameter = new SqlParameter("@ID", SqlDbType.Int);
            parameter.Value = ID;

            List<HairStyleEntity> valueList = new List<HairStyleEntity>();

            using (SqlDataReader Reader = SqlHelper.ExecuteReader(DataHelper2.SqlConnectionString, CommandType.StoredProcedure,
                "QueryHairStyleByID", parameter))
            {
                while (Reader.Read())
                    valueList.Add(new HairStyleEntity(Reader.GetInt32(0), Reader.GetString(1), Reader.GetByte(2), Reader.GetByte(3),
                        Reader.GetByte(4), Reader.GetByte(5), Reader.GetByte(6), Reader.GetString(7), Reader.GetString(8), Reader.GetString(9),
                        Reader.GetString(10), Reader.GetString(11), Reader.GetString(12), Reader.GetString(13), Reader.GetInt32(14),
                        Reader.GetInt32(15), Reader.GetByte(16), Reader.GetByte(17), Reader.GetByte(18), Reader.GetDateTime(19),
                        Reader.GetString(20), Reader.GetInt32(21), Reader.GetInt32(22), Reader.GetInt32(23), Reader.GetString(24)));
            }

            return valueList;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual SqlParameter[] GetEngineerOpusParameters()
        {
            SqlParameter[] EngineerOpusParameters = SqlHelperParameterCache.GetCachedParameterSet(DataHelper2.SqlConnectionString, SQL_ENGINEEROPUSPARMCACHE);

            if (EngineerOpusParameters == null)
            {
                EngineerOpusParameters = new SqlParameter[]{

                    new SqlParameter("@ID",SqlDbType.Int),
                    new SqlParameter("@HairName",SqlDbType.VarChar,100),
                    new SqlParameter("@HairStyle",SqlDbType.SmallInt),
                    new SqlParameter("@FaceStyle",SqlDbType.SmallInt),
                    new SqlParameter("@Temperament",SqlDbType.SmallInt),
                    new SqlParameter("@Occasion",SqlDbType.SmallInt),
                    new SqlParameter("@Sex",SqlDbType.SmallInt),
                    new SqlParameter("@BigPic",SqlDbType.VarChar,1024),
                    new SqlParameter("@SmallPic_F",SqlDbType.VarChar,1024),
                    new SqlParameter("@SmallPic_B",SqlDbType.VarChar,1024),
                    new SqlParameter("@SmallPic_S",SqlDbType.VarChar,1024),

                    new SqlParameter("@Pic1",SqlDbType.Text),
                    new SqlParameter("@Pic2",SqlDbType.Text),
                    new SqlParameter("@Pic3",SqlDbType.Text),
                    new SqlParameter("@HairShopID",SqlDbType.Int),
                    new SqlParameter("@HairEngineerID",SqlDbType.Int),
                    new SqlParameter("@HairQuantity",SqlDbType.SmallInt),
                    new SqlParameter("@HairNature",SqlDbType.SmallInt),
                    new SqlParameter("@Color",SqlDbType.SmallInt),
                    new SqlParameter("@CreateTime",SqlDbType.DateTime),
                    new SqlParameter("@BBSURL",SqlDbType.VarChar,1024),

                    new SqlParameter("@Good",SqlDbType.Int),
                    new SqlParameter("@Normal",SqlDbType.Int),
                    new SqlParameter("@Bad",SqlDbType.Int),
                    new SqlParameter("@Tag",SqlDbType.VarChar,1024),
                };
            }

            SqlHelperParameterCache.CacheParameterSet(DataHelper2.SqlConnectionString, SQL_ENGINEEROPUSPARMCACHE, EngineerOpusParameters);

            return EngineerOpusParameters;
        } 

        /// <summary>
        /// 通过美发师ID来获取美发师实体
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <returns></returns>
        public HairEngineer GetHairEngineerByHairEngineerID(int hairEngineerID)
        {
            HairEngineer hairEngineer = new HairEngineer();

            using (SqlDataReader sdr = SqlHelper.ExecuteReader(DataHelper2.SqlConnectionString, CommandType.Text,
                "select * from HairEngineer he inner join HairEngineerClass hec on he.HairEngineerClassID = hec.HairEngineerClassID inner join HairShop hs on hs.HairShopID = he.HairShopID where he.HairEngineerID=" + hairEngineerID.ToString() + " order by he.HairEngineerID desc"))
            {
                while (sdr.Read())
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
                    hairEngineer.HairEngineerConstellation = sdr["HairEngineerConstellation"].ToString();
                    hairEngineer.IsImportant = bool.Parse(sdr["IsImportant"].ToString());
                    hairEngineer.HairEngineerPhotoIDs = sdr["HairEngineerPhotoIDs"].ToString();
                }
            }

            return hairEngineer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="HairEngineerID"></param>
        /// <returns></returns>
        public DataTable GetHairEngineerInfoByID(Int32 HairEngineerID)
        {
            return SqlHelper.ExecuteDataset(DataHelper2.SqlConnectionString, CommandType.Text,
                "select * from HairEngineer he inner join HairEngineerClass hec on he.HairEngineerClassID = hec.HairEngineerClassID inner join HairShop hs on hs.HairShopID = he.HairShopID where he.HairEngineerID=" + HairEngineerID.ToString() + " order by he.HairEngineerID desc").Tables[0];
        }

        /// <summary>
        /// 获取美发师
        /// </summary>
        /// <param name="count">0 所有</param>
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
                                hairEngineer.HairEngineerConstellation = sdr["HairEngineerConstellation"].ToString();

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
                                hairEngineer.HairEngineerConstellation = sdr["HairEngineerConstellation"].ToString();

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
        /// 获得美发师类别列表
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
        /// 美发师类别 添加，删除，修改
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
        /// 获取美发师TAG列表
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
        /// 获得美发师TAG实体
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
        /// 美发师TAG 添加，删除，修改
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
        /// 获取美发师评论列表
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">排序KEY 按照时间排序，按照好评排序，按照用户ID排序</param>
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
        /// 获取美发师评论列表
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="count"></param>
        /// <param name="orderKey">排序KEY 按照时间排序，按照好评排序，按照美发师排序</param>
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
        /// 获取美发师评论列表
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
