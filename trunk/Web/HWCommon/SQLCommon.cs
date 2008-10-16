using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace HWCommon
{

    /// <summary>
    /// ���ݷ����ࡪ���ṩͨ�õ����ݷ��ʷ���
    /// </summary>
    public class SQLCommon
    {
        /// <summary>
        /// ִ�б�׼SQL��䣬��Ҫ�󷵻ؽ�����ʺϣ�����ɾ���ģ�
        /// </summary>
        /// <param name="sql">��׼SQL���</param>
        /// <param name="connectionString">�����ַ���</param>
        /// <param name="errorMessage">������Ϣ</param>
        /// <returns>����ֵ��true��ʾ��ִ�гɹ���false��ʾִ��ʧ��</returns>
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
        //��MYSQLִ�б�׼SQL��䣬��Ҫ�󷵻ؽ�����ʺϣ�����ɾ���ģ�
        public static bool ExecuteNonQueryForMySql(string sql,string connStr, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            MySqlConnection conn = new MySqlConnection(connStr);//�������ݿ�����
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
        //��MYSQLִ�б�׼SQL��䣬��������ID
        public static int ExecuteQueryReturnId(string sql, string connStr,out string errorMessage)
        {
            MySqlConnection conn = new MySqlConnection(connStr);//�������ݿ�����
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
        //�������ݼ�
        public static bool ExecuteDatasetForMySql(string sql, string connStr, out DataSet ds, out string errorMessage)
        {
            bool result = false;
            errorMessage = "";
            ds = new DataSet();
            MySqlConnection conn = new MySqlConnection(connStr);//�������ݿ�����
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
        /// ִ�б�׼SQL��ѯ��䣬���ؼ�¼��
        /// </summary>
        /// <param name="sql">��׼SQL��ѯ���</param>
        /// <param name="connectionString">�����ַ���</param>
        /// <param name="ds">��ѯ�����¼��</param>
        /// <param name="errorMessage">������Ϣ</param>
        /// <returns>����ֵ��true��ʾ��ִ�гɹ���false��ʾִ��ʧ��</returns>
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
        /// �ṩͨ�õĵ��ô洢���̵ķ�������Ҫ���ز�ѯ�ļ�¼���ĵ��ã�
        /// </summary>
        /// <param name="procedureName">�洢��������</param>
        /// <param name="connectionString">�����ַ���</param>
        /// <param name="sqlParameters">�洢���̲�������</param>
        /// <param name="ds">�洢�������淵�صļ�¼��</param>
        /// <param name="errorMessage">������Ϣ</param>
        /// <returns>����ֵ��true��ʾ��ִ�гɹ���false��ʾִ��ʧ��</returns>
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
        ///  �ṩͨ�õĵ��ô洢���̵ķ�������Ҫ���ز�ѯ�ļ�¼���ĵ��ã�
        /// </summary>
        /// <param name="procedureName">�洢��������</param>
        /// <param name="connectionString">�����ַ���</param>
        /// <param name="ds">�洢�������淵�صļ�¼��</param>
        /// <param name="errorMessage">������Ϣ</param>
        /// <returns>����ֵ��true��ʾ��ִ�гɹ���false��ʾִ��ʧ��</returns>
        /// ��д:�ﰮ��
        /// ʱ��:2005-10-26
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
        /// �ṩͨ�õĵ��ô洢���̵ķ�������Ҫ���ز�ѯ�ļ�¼���ĵ��ã�
        /// </summary>
        /// <param name="procedureName">�洢��������</param>
        /// <param name="connectionString">�����ַ���</param>
        /// <param name="startRecord">���俪ʼ�Ĵ��㿪ʼ�ļ�¼��</param>
        /// <param name="maxRecords">Ҫ����������¼��</param>
        /// <param name="sqlParameters">�洢���̲�������</param>
        /// <param name="ds">�洢�������淵�صļ�¼��</param>
        /// <param name="errorMessage">������Ϣ</param>
        /// <returns>����ֵ��true��ʾ��ִ�гɹ���false��ʾִ��ʧ��</returns>
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
        /// �ṩͨ�õĵ��ô洢���̵ķ���������Ҫ���ز�ѯ�ļ�¼���ĵ��ã�
        /// </summary>
        /// <param name="procedureName">�洢��������</param>
        /// <param name="connectionString">�����ַ���</param>
        /// <param name="sqlParameters">�洢���̲�������</param>
        /// <param name="errorMessage">������Ϣ</param>
        /// <returns>����ֵ��true��ʾ��ִ�гɹ���false��ʾִ��ʧ��</returns>
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
