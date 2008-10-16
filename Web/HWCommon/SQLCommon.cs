using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace HWCommon
{

    /// <summary>
    /// 数据访问类——提供通用的数据访问方法
    /// </summary>
    public class SQLCommon
    {
        /// <summary>
        /// 执行标准SQL语句，不要求返回结果，适合（增、删、改）
        /// </summary>
        /// <param name="sql">标准SQL语句</param>
        /// <param name="connectionString">连库字符串</param>
        /// <param name="errorMessage">错误信息</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        public static bool ExecuteNonQuery(string sql, string connectionString, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }
        //对MYSQL执行标准SQL语句，不要求返回结果，适合（增、删、改）
        public static bool ExecuteNonQueryForMySql(string sql,string connStr, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            MySqlConnection conn = new MySqlConnection(connStr);//构造数据库连接
            try
            {
                conn.Open();
                MySqlCommand commn = new MySqlCommand(sql, conn);
                commn.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
            
        }
        //对MYSQL执行标准SQL语句，返回自增ID
        public static int ExecuteQueryReturnId(string sql, string connStr,out string errorMessage)
        {
            MySqlConnection conn = new MySqlConnection(connStr);//构造数据库连接
            errorMessage = "";
            int id = -1;
            try
            {
                conn.Open();
                MySqlCommand commn = new MySqlCommand(sql, conn);
                commn.ExecuteNonQuery();
                commn.CommandText = @"select @@identity";
                id = Int32.Parse(commn.ExecuteScalar().ToString());
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return id;

        }
        //返回数据集
        public static bool ExecuteDatasetForMySql(string sql, string connStr, out DataSet ds, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            ds = new DataSet();
            MySqlConnection conn = new MySqlConnection(connStr);//构造数据库连接
            try
            {
                conn.Open();
                MySqlDataAdapter mda = new MySqlDataAdapter(sql, conn); 
                ds = new DataSet(); 
                mda.Fill(ds); 
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;

        }
     


        /// <summary>
        /// 执行标准SQL查询语句，返回记录集
        /// </summary>
        /// <param name="sql">标准SQL查询语句</param>
        /// <param name="connectionString">连库字符串</param>
        /// <param name="ds">查询结果记录集</param>
        /// <param name="errorMessage">错误信息</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        public static bool ExecuteDataset(string sql, string connectionString, out DataSet ds, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            ds = new DataSet();
            try
            {
                SqlDataAdapter dsCommand = new SqlDataAdapter();
                SqlConnection conn = new SqlConnection(connectionString);
                dsCommand.SelectCommand = new SqlCommand(sql, conn);
                dsCommand.Fill(ds);
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
            }
            return result;
        }
        /// <summary>
        /// 提供通用的调用存储过程的方法（需要返回查询的记录集的调用）
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="connectionString">连库字符串</param>
        /// <param name="sqlParameters">存储过程参数数组</param>
        /// <param name="ds">存储过程里面返回的记录集</param>
        /// <param name="errorMessage">错误信息</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        public static bool ExecuteStoredProcedure(string procedureName, string connectionString, ref SqlParameter[] sqlParameters, out DataSet ds, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            ds = new DataSet();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                SqlDataAdapter dsCommand = new SqlDataAdapter();
                dsCommand.SelectCommand = new SqlCommand(procedureName, conn);
                dsCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < sqlParameters.Length; i++)
                {
                    dsCommand.SelectCommand.Parameters.Add(sqlParameters[i]);
                }
                dsCommand.Fill(ds);
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
            }
            return result;
        }

        public static bool ExecuteStoredProcedure(string procedureName, string connectionString, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }

        /// <summary>
        ///  提供通用的调用存储过程的方法（需要返回查询的记录集的调用）
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="connectionString">连库字符串</param>
        /// <param name="ds">存储过程里面返回的记录集</param>
        /// <param name="errorMessage">错误信息</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        /// 编写:孙爱华
        /// 时间:2005-10-26
        public static bool ExecuteStoredProcedure(string procedureName, string connectionString, out DataSet ds, out string errorMessage)
        {

            bool result = false;
            errorMessage = "";
            ds = new DataSet();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                SqlDataAdapter dsCommand = new SqlDataAdapter();
                dsCommand.SelectCommand = new SqlCommand(procedureName, conn);
                dsCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
                dsCommand.Fill(ds);
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
            }
            return result;

        }

        /// <summary>
        /// 提供通用的调用存储过程的方法（需要返回查询的记录集的调用）
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="connectionString">连库字符串</param>
        /// <param name="startRecord">从其开始的从零开始的记录号</param>
        /// <param name="maxRecords">要检索的最大记录数</param>
        /// <param name="sqlParameters">存储过程参数数组</param>
        /// <param name="ds">存储过程里面返回的记录集</param>
        /// <param name="errorMessage">错误信息</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        public static bool ExecuteStoredProcedure(string procedureName, string connectionString, int startRecord, int maxRecords, ref SqlParameter[] sqlParameters, out DataSet ds, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            ds = new DataSet();
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                SqlDataAdapter dsCommand = new SqlDataAdapter();
                dsCommand.SelectCommand = new SqlCommand(procedureName, conn);
                dsCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < sqlParameters.Length; i++)
                {
                    dsCommand.SelectCommand.Parameters.Add(sqlParameters[i]);
                }
                dsCommand.Fill(ds, startRecord, maxRecords, "srcTable");
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();
            }
            return result;
        }
        /// <summary>
        /// 提供通用的调用存储过程的方法（不需要返回查询的记录集的调用）
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="connectionString">连库字符串</param>
        /// <param name="sqlParameters">存储过程参数数组</param>
        /// <param name="errorMessage">错误信息</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        public static bool ExecuteStoredProcedure(string procedureName, string connectionString, ref SqlParameter[] sqlParameters, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < sqlParameters.Length; i++)
                {
                    cmd.Parameters.Add(sqlParameters[i]);
                }
                conn.Open();
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception e)
            {
                errorMessage = e.ToString();

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return result;
        }

    }

}
