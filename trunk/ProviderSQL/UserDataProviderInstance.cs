using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Enumerations;
using HairNet.Entry;
using System.Data.SqlClient;

namespace HairNet.Provider
{
    public class UserDataProviderInstance : IUserDataProvider
    {
        //具体实现
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool UserCreate(UserEntry user)
        {
            bool result = false;
            string commandText = string.Empty;

            commandText = "INSERT INTO UserBasicInfo ( UserName, Password, FindPassQus, FindPassAsw, ActivatedIDS, Email,Integral, UserRoleID,IsActive) values ('" +
                user.UserName + "','" + user.Password + "','" + user.FindPassQus + "','" + user.FindPassAsw + "','" + user.ActivatedIDS + "','" + user.Email + "'," + user.Integral + "," + user.UserRoleID + ","+user.IsActive.CompareTo(false).ToString()+")";
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

            commandText = "SELECT UserID FROM UserBasicInfo WHERE UserName = '" + user.UserName + "'";
            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commandText;
                    comm.Connection = conn;
                    conn.Open();

                    try
                    {
                        user.UserID = int.Parse(comm.ExecuteScalar().ToString());

                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }

                }
            }

            commandText = "INSERT INTO UserPersonalInfo (UserID, Sex, Birthday, FirstName, LastName, Name, Country, City, PostalCode,Vocational, Location, Interest) values (" +
            user.UserID + "," + user.Sex + ",'" + user.Birthday + "','" + user.FirstName + "','" + user.LastName + "','" + user.Name + "','" + user.Country + "','" + user.City + "','" + user.PostalCode + "','" + user.Vocational + "','" + user.Location + "','" + user.Interest + "')";

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

            commandText = "INSERT INTO UserBusinessInfo (MonthlyIncome, BeginWork, WorkMessageAddr, WorkEmail, OfficeFax, OfficeTel2,OfficeTel1, OfficeAddr, OfficeCity, CompanyCity, CompanyCountry, Company, Duty, UserID) VALUES ('" +
                user.MonthlyIncome + "','" + user.BeginWork + "','" + user.WorkMessageAddr + "','" + user.WorkEmail + "','" + user.OfficeFax + "','" + user.OfficeTel2 + "','" + user.OfficeTel1 + "','" + user.OfficeAddr + "','" + user.OfficeCity
                + "','" + user.CompanyCity + "','" + user.CompanyCountry + "','" + user.Company + "','"
                + user.Duty + "'," + user.UserID + ")";

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

            commandText = "INSERT INTO UserContactInfo (UserID, LiveCity, HomeAddr, HomeTel1, HomeTel2, Mobile, LiveFax, PersonalEmail, " +
            " PersonalMessgeAddr, MSN, QQ) VALUES ( " + user.UserID + ",'" + user.LiveCity + "','" + user.HomeAddr + "','" + user.HomeTel1 + "','" + user.HomeTel2 + "','" + user.Mobile + "','" + user.LiveFax + "','" + user.PersonalEmail + "','" +
            user.PersonalMessageAddr + "','" + user.MSN + "','" + user.QQ + "')";

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
        /// 删除
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public bool UserDelete(int userID)
        {
            bool result = false;
            string commandText = "delete from UserBasicInfo where UserID=" + userID.ToString();

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
            commandText = "delete from UserBusinessInfo where UserID=" + userID.ToString();

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
            commandText = "delete from UserContactInfo where UserID=" + userID.ToString();

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
            commandText = "delete from UserPersonalInfo where UserID=" + userID.ToString();

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
        /// 修改
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool UserUpdate(UserEntry user)
        {
            bool result = false;
            //string commandText = "UPDATE UserBasicInfo SET UserID = " + user.UserID + ", UserName = '" + user.UserName + "', Password = '" + user.Password + "', FindPassQus = '" + user.FindPassQus + "', FindPassAsw = '" + user.FindPassAsw + "', ActivatedIDS = '" + user.ActivatedIDS + "', Email = '" + user.Email + "', Integral = " + user.Integral + ", UserRoleID = " + user.UserRoleID +
            //    " FROM UserBasicInfo INNER JOIN  UserBusinessInfo ON UserBasicInfo.UserID = UserBusinessInfo.UserID INNER JOIN UserContactInfo ON UserBasicInfo.UserID = UserContactInfo.UserID INNER JOIN " +
            //    "  UserPersonalInfo ON UserBasicInfo.UserID = UserPersonalInfo.UserID ";
            //using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            //{
            //    using (SqlCommand comm = new SqlCommand())
            //    {
            //        comm.CommandText = commandText;
            //        comm.Connection = conn;
            //        conn.Open();
            //        try
            //        {
            //            comm.ExecuteNonQuery();
            //            result = true;
            //        }
            //        catch (Exception ex)
            //        {
            //            throw new Exception(ex.Message);
            //        }

            //    }
            //}
            //实现的不对，需要重新写，SQL语句错了，需要更新四个表的数据
            return result;
        }

        /// <summary>
        /// 通过ID得到用户实体
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserEntry GetUserByID(int userID)
        {
            UserEntry ue = new UserEntry();

            string commandText = "SELECT * FROM UserBasicInfo Inner join UserRole ur on UserBasicInfo.UserRoleID = ur.UserRoleID INNER JOIN UserBusinessInfo ON UserBasicInfo.UserID = UserBusinessInfo.UserID INNER JOIN UserContactInfo ON UserBasicInfo.UserID = UserContactInfo.UserID INNER JOIN UserPersonalInfo ON UserBasicInfo.UserID = UserPersonalInfo.UserID WHERE (UserBusinessInfo.UserID = " + userID + " )";
            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commandText;
                    comm.Connection = conn;
                    conn.Open();

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ue.UserID = int.Parse(reader["UserID"].ToString());
                            ue.UserName = reader["UserName"].ToString();
                            ue.Password = reader["Password"].ToString();
                            ue.FindPassQus = reader["FindPassQus"].ToString();
                            ue.FindPassAsw = reader["FindPassAsw"].ToString();
                            ue.ActivatedIDS = reader["ActivatedIDS"].ToString();
                            ue.Email = reader["Email"].ToString();
                            ue.Integral = int.Parse(reader["Integral"].ToString());
                            ue.UserRoleID = int.Parse(reader["UserRoleID"].ToString());
                            ue.UserRoleName = reader["UserRoleName"].ToString();
                            ue.IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                            ue.Duty = reader["Duty"].ToString();
                            ue.Company = reader["Company"].ToString();
                            ue.CompanyCountry = reader["CompanyCountry"].ToString();
                            ue.CompanyCity = reader["CompanyCity"].ToString();
                            ue.OfficeCity = reader["OfficeCity"].ToString();
                            ue.OfficeAddr = reader["OfficeAddr"].ToString();
                            ue.OfficeTel1 = reader["OfficeTel1"].ToString();
                            ue.OfficeTel2 = reader["OfficeTel2"].ToString();
                            ue.OfficeFax = reader["OfficeFax"].ToString();
                            ue.WorkEmail = reader["WorkEmail"].ToString();
                            ue.WorkMessageAddr = reader["WorkMessageAddr"].ToString();
                            ue.BeginWork = reader["BeginWork"].ToString();
                            ue.MonthlyIncome = reader["MonthlyIncome"].ToString();
                            ue.LiveCity = reader["LiveCity"].ToString();
                            ue.HomeAddr = reader["HomeAddr"].ToString();
                            ue.HomeTel1 = reader["HomeTel1"].ToString();
                            ue.HomeTel2 = reader["HomeTel2"].ToString();
                            ue.Mobile = reader["Mobile"].ToString();
                            ue.LiveFax = reader["LiveFax"].ToString();
                            ue.PersonalEmail = reader["PersonalEmail"].ToString();
                            ue.PersonalMessageAddr = reader["PersonalMessgeAddr"].ToString();
                            ue.MSN = reader["MSN"].ToString();
                            ue.QQ = reader["QQ"].ToString();
                            ue.Sex = int.Parse(reader["Sex"].ToString());
                            ue.Birthday = reader["Birthday"].ToString();
                            ue.FirstName = reader["FirstName"].ToString();
                            ue.LastName = reader["LastName"].ToString();
                            ue.Name = reader["Name"].ToString();
                            ue.Country = reader["Country"].ToString();
                            ue.City = reader["City"].ToString();
                            ue.PostalCode = reader["PostalCode"].ToString();
                            ue.Vocational = reader["Vocational"].ToString();
                            ue.Location = reader["Location"].ToString();
                            ue.Interest = reader["Interest"].ToString();
                        }
                    }
                }
            }

            return ue;
        }

        /// <summary>
        /// 通过用户名得到用户实体
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public UserEntry GetUserByName(string userName)
        {
            UserEntry ue = new UserEntry();
            string commandText = "SELECT UserBasicInfo.UserName,UserBasicInfo.IsActive,ur.UserRoleName, UserBasicInfo.Password, UserBasicInfo.FindPassQus, " +
                  " UserBasicInfo.FindPassAsw, UserBasicInfo.ActivatedIDS, UserBasicInfo.Email, " +
                  " UserBasicInfo.Integral, UserBasicInfo.UserRoleID, " +
                  " UserBusinessInfo.UserID AS Expr1, UserBusinessInfo.Duty, " +
                  " UserBusinessInfo.Company, UserBusinessInfo.CompanyCountry, " +
                  " UserBusinessInfo.CompanyCity, UserBusinessInfo.OfficeCity, " +
                  " UserBusinessInfo.OfficeAddr, UserBusinessInfo.OfficeTel1, " +
                  " UserBusinessInfo.OfficeTel2, UserBusinessInfo.OfficeFax, " +
                  " UserBusinessInfo.WorkEmail, UserBusinessInfo.WorkMessageAddr, " +
                  " UserBusinessInfo.BeginWork, UserBusinessInfo.MonthlyIncome," +
                  " UserContactInfo.UserID AS Expr2, UserContactInfo.LiveCity, " +
                  " UserContactInfo.HomeAddr, UserContactInfo.HomeTel1, UserContactInfo.HomeTel2, " +
                  " UserContactInfo.Mobile, UserContactInfo.LiveFax, UserContactInfo.PersonalEmail, " +
                  " UserContactInfo.PersonalMessgeAddr, UserContactInfo.MSN, UserContactInfo.QQ, " +
                  " UserPersonalInfo.UserID AS Expr3, UserPersonalInfo.Sex, " +
                  " UserPersonalInfo.Birthday, UserPersonalInfo.FirstName, " +
                  " UserPersonalInfo.LastName, UserPersonalInfo.Name, UserPersonalInfo.Country, " +
                  " UserPersonalInfo.City, UserPersonalInfo.PostalCode, UserPersonalInfo.Vocational, " +
                  " UserPersonalInfo.Location, UserPersonalInfo.Interest, UserBasicInfo.UserID" +
            " FROM UserBasicInfo Inner join UserRole ur on UserBasicInfo.UserRoleID = ur.UserRoleID INNER JOIN " +
                  " UserBusinessInfo ON UserBasicInfo.UserID = UserBusinessInfo.UserID INNER JOIN " +
                 " UserContactInfo ON UserBasicInfo.UserID = UserContactInfo.UserID INNER JOIN " +
                 " UserPersonalInfo ON UserBasicInfo.UserID = UserPersonalInfo.UserID " +
            " WHERE (UserBasicInfo.UserName = '" + userName + "')";

            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commandText;
                    comm.Connection = conn;
                    conn.Open();

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ue.UserID = int.Parse(reader["UserID"].ToString());
                            ue.UserName = reader["UserName"].ToString();
                            ue.Password = reader["Password"].ToString();
                            ue.FindPassQus = reader["FindPassQus"].ToString();
                            ue.FindPassAsw = reader["FindPassAsw"].ToString();
                            ue.ActivatedIDS = reader["ActivatedIDS"].ToString();
                            ue.Email = reader["Email"].ToString();
                            ue.Integral = int.Parse(reader["Integral"].ToString());
                            ue.UserRoleID = int.Parse(reader["UserRoleID"].ToString());
                            ue.UserRoleName = reader["UserRoleName"].ToString();
                            ue.IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                            ue.Duty = reader["Duty"].ToString();
                            ue.Company = reader["Company"].ToString();
                            ue.CompanyCountry = reader["CompanyCountry"].ToString();
                            ue.CompanyCity = reader["CompanyCity"].ToString();
                            ue.OfficeCity = reader["OfficeCity"].ToString();
                            ue.OfficeAddr = reader["OfficeAddr"].ToString();
                            ue.OfficeTel1 = reader["OfficeTel1"].ToString();
                            ue.OfficeTel2 = reader["OfficeTel2"].ToString();
                            ue.OfficeFax = reader["OfficeFax"].ToString();
                            ue.WorkEmail = reader["WorkEmail"].ToString();
                            ue.WorkMessageAddr = reader["WorkMessageAddr"].ToString();
                            ue.BeginWork = reader["BeginWork"].ToString();
                            ue.MonthlyIncome = reader["MonthlyIncome"].ToString();
                            ue.LiveCity = reader["LiveCity"].ToString();
                            ue.HomeAddr = reader["HomeAddr"].ToString();
                            ue.HomeTel1 = reader["HomeTel1"].ToString();
                            ue.HomeTel2 = reader["HomeTel2"].ToString();
                            ue.Mobile = reader["Mobile"].ToString();
                            ue.LiveFax = reader["LiveFax"].ToString();
                            ue.PersonalEmail = reader["PersonalEmail"].ToString();
                            ue.PersonalMessageAddr = reader["PersonalMessgeAddr"].ToString();
                            ue.MSN = reader["MSN"].ToString();
                            ue.QQ = reader["QQ"].ToString();
                            ue.Sex = int.Parse(reader["Sex"].ToString());
                            ue.Birthday = reader["Birthday"].ToString();
                            ue.FirstName = reader["FirstName"].ToString();
                            ue.LastName = reader["LastName"].ToString();
                            ue.Name = reader["Name"].ToString();
                            ue.Country = reader["Country"].ToString();
                            ue.City = reader["City"].ToString();
                            ue.PostalCode = reader["PostalCode"].ToString();
                            ue.Vocational = reader["Vocational"].ToString();
                            ue.Location = reader["Location"].ToString();
                            ue.Interest = reader["Interest"].ToString();
                        }
                    }   
                }
            }
            return ue;
        }

        /// <summary>
        /// 获取指定数量的用户
        /// </summary>
        /// <param name="count">0,all users</param>
        /// <returns></returns>
        public List<UserEntry> GetUsers(int count)
        {
            List<UserEntry> li = new List<UserEntry>();
            string obj = " * ";
            if (count > 0)
            {
                obj = " top " + count + " * ";
            }
            else if (count < 0)
            {
                return li;
            }

            //降序
            string commandText = "select " + obj + " FROM UserBasicInfo Inner join UserRole ur on UserBasicInfo.UserRoleID = ur.UserRoleID INNER JOIN " +
                " UserBusinessInfo ON UserBasicInfo.UserID = UserBusinessInfo.UserID INNER JOIN " +
                " UserContactInfo ON UserBasicInfo.UserID = UserContactInfo.UserID INNER JOIN " +
                " UserPersonalInfo ON UserBasicInfo.UserID = UserPersonalInfo.UserID ORDER BY UserBasicInfo.UserID DESC";
                        using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commandText;
                    comm.Connection = conn;
                    conn.Open();
                    
                    using(SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserEntry ue = new UserEntry();
                            ue.UserID = int.Parse(reader["UserID"].ToString());
                            ue.UserName = reader["UserName"].ToString();
                            ue.Password = reader["Password"].ToString();
                            ue.FindPassQus = reader["FindPassQus"].ToString();
                            ue.FindPassAsw = reader["FindPassAsw"].ToString();
                            ue.ActivatedIDS = reader["ActivatedIDS"].ToString();
                            ue.Email = reader["Email"].ToString();
                            ue.Integral = int.Parse(reader["Integral"].ToString());
                            ue.UserRoleID = int.Parse(reader["UserRoleID"].ToString());
                            ue.UserRoleName = reader["UserRoleName"].ToString();
                            ue.IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                            ue.Duty = reader["Duty"].ToString();
                            ue.Company = reader["Company"].ToString();
                            ue.CompanyCountry = reader["CompanyCountry"].ToString();
                            ue.CompanyCity = reader["CompanyCity"].ToString();
                            ue.OfficeCity = reader["OfficeCity"].ToString();
                            ue.OfficeAddr = reader["OfficeAddr"].ToString();
                            ue.OfficeTel1 = reader["OfficeTel1"].ToString();
                            ue.OfficeTel2 = reader["OfficeTel2"].ToString();
                            ue.OfficeFax = reader["OfficeFax"].ToString();
                            ue.WorkEmail = reader["WorkEmail"].ToString();
                            ue.WorkMessageAddr = reader["WorkMessageAddr"].ToString();
                            ue.BeginWork = reader["BeginWork"].ToString();
                            ue.MonthlyIncome = reader["MonthlyIncome"].ToString();
                            ue.LiveCity = reader["LiveCity"].ToString();
                            ue.HomeAddr = reader["HomeAddr"].ToString();
                            ue.HomeTel1 = reader["HomeTel1"].ToString();
                            ue.HomeTel2 = reader["HomeTel2"].ToString();
                            ue.Mobile = reader["Mobile"].ToString();
                            ue.LiveFax = reader["LiveFax"].ToString();
                            ue.PersonalEmail = reader["PersonalEmail"].ToString();
                            ue.PersonalMessageAddr = reader["PersonalMessgeAddr"].ToString();
                            ue.MSN = reader["MSN"].ToString();
                            ue.QQ = reader["QQ"].ToString();
                            ue.Sex = int.Parse(reader["Sex"].ToString());
                            ue.Birthday = reader["Birthday"].ToString();
                            ue.FirstName = reader["FirstName"].ToString();
                            ue.LastName = reader["LastName"].ToString();
                            ue.Name = reader["Name"].ToString();
                            ue.Country = reader["Country"].ToString();
                            ue.City = reader["City"].ToString();
                            ue.PostalCode = reader["PostalCode"].ToString();
                            ue.Vocational = reader["Vocational"].ToString();
                            ue.Location = reader["Location"].ToString();
                            ue.Interest = reader["Interest"].ToString();

                            li.Add(ue);
                        }
                    }   
                }
            }

            return li;
        }

        /// <summary>
        /// 用户查询
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public List<UserEntry> GetUsersByName(string strUserName)
        {
            List<UserEntry> li = new List<UserEntry>();
            string commandText = "select * FROM UserBasicInfo Inner join UserRole ur on UserBasicInfo.UserRoleID = ur.UserRoleID INNER JOIN " +
                " UserBusinessInfo ON UserBasicInfo.UserID = UserBusinessInfo.UserID INNER JOIN " +
                " UserContactInfo ON UserBasicInfo.UserID = UserContactInfo.UserID INNER JOIN " +
                " UserPersonalInfo ON UserBasicInfo.UserID = UserPersonalInfo.UserID WHERE (UserBasicInfo.UserName LIKE '%"+strUserName+"%') ";
            using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commandText;
                    comm.Connection = conn;
                    conn.Open();

                    using(SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserEntry ue = new UserEntry();
                            ue.UserID = int.Parse(reader["UserID"].ToString());
                            ue.UserName = reader["UserName"].ToString();
                            ue.Password = reader["Password"].ToString();
                            ue.FindPassQus = reader["FindPassQus"].ToString();
                            ue.FindPassAsw = reader["FindPassAsw"].ToString();
                            ue.ActivatedIDS = reader["ActivatedIDS"].ToString();
                            ue.Email = reader["Email"].ToString();
                            ue.Integral = int.Parse(reader["Integral"].ToString());
                            ue.UserRoleID = int.Parse(reader["UserRoleID"].ToString());
                            ue.UserRoleName = reader["UserRoleName"].ToString();
                            ue.IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                            ue.Duty = reader["Duty"].ToString();
                            ue.Company = reader["Company"].ToString();
                            ue.CompanyCountry = reader["CompanyCountry"].ToString();
                            ue.CompanyCity = reader["CompanyCity"].ToString();
                            ue.OfficeCity = reader["OfficeCity"].ToString();
                            ue.OfficeAddr = reader["OfficeAddr"].ToString();
                            ue.OfficeTel1 = reader["OfficeTel1"].ToString();
                            ue.OfficeTel2 = reader["OfficeTel2"].ToString();
                            ue.OfficeFax = reader["OfficeFax"].ToString();
                            ue.WorkEmail = reader["WorkEmail"].ToString();
                            ue.WorkMessageAddr = reader["WorkMessageAddr"].ToString();
                            ue.BeginWork = reader["BeginWork"].ToString();
                            ue.MonthlyIncome = reader["MonthlyIncome"].ToString();
                            ue.LiveCity = reader["LiveCity"].ToString();
                            ue.HomeAddr = reader["HomeAddr"].ToString();
                            ue.HomeTel1 = reader["HomeTel1"].ToString();
                            ue.HomeTel2 = reader["HomeTel2"].ToString();
                            ue.Mobile = reader["Mobile"].ToString();
                            ue.LiveFax = reader["LiveFax"].ToString();
                            ue.PersonalEmail = reader["PersonalEmail"].ToString();
                            ue.PersonalMessageAddr = reader["PersonalMessgeAddr"].ToString();
                            ue.MSN = reader["MSN"].ToString();
                            ue.QQ = reader["QQ"].ToString();
                            ue.Sex = int.Parse(reader["Sex"].ToString());
                            ue.Birthday = reader["Birthday"].ToString();
                            ue.FirstName = reader["FirstName"].ToString();
                            ue.LastName = reader["LastName"].ToString();
                            ue.Name = reader["Name"].ToString();
                            ue.Country = reader["Country"].ToString();
                            ue.City = reader["City"].ToString();
                            ue.PostalCode = reader["PostalCode"].ToString();
                            ue.Vocational = reader["Vocational"].ToString();
                            ue.Location = reader["Location"].ToString();
                            ue.Interest = reader["Interest"].ToString();

                            li.Add(ue);
                        }
                    }
                }
            }

            return li;
        }
        public bool UserUpdateStatus(int userID, bool isActive)
        {
            bool result = false;
            string commandText = "update UserBasicInfo set IsActive="+isActive.CompareTo(false).ToString()+" where UserID="+userID.ToString();
            
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
        /// EMAIL临时发送表 添加，删除，更新
        /// </summary>
        /// <param name="tempEmail"></param>
        /// <returns></returns>
        public bool TempEmailCreateDeleteUpdate(TempEmail tempEmail,UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "insert into TempEmail(TempEmailName,TempEmailIsSend,TempEmailCreateTime) values('"+tempEmail.TempEmailName+"',"+tempEmail.TempEmailIsSend.CompareTo(false).ToString()+",'"+tempEmail.TempEmailCreateTime.ToString()+"')";
                    break;
                case UserAction.Delete:
                    commandText = "delete from TempEmail where TempEmailID ="+tempEmail.TempEmailID.ToString();
                    break;
                case UserAction.Update:
                    commandText = "update TempEmail set TempEmailName='"+tempEmail.TempEmailName+"',TempEmailIsSend='"+tempEmail.TempEmailIsSend.CompareTo(false).ToString()+"',TempEmailCreateTime'"+tempEmail.TempEmailCreateTime.ToString()+"' where TempEmailID="+tempEmail.TempEmailID.ToString();
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
