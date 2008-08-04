using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;

namespace HairNet.Provider
{
	/// <summary>
	/// DataProvider ��ժҪ˵����
	/// </summary>
	public class DataHelper
	{
		public DataHelper()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		
		private SqlConnection objConn ;

		//|------------------------------------------------------------------------------------------------------------|
		//|---------------------------------------------------�޷���---------------------------------------------------|
		//|------------------------------------------------------------------------------------------------------------|

		public void RunReturnNothing (string Procedure)
		{
			SqlCommand objCommand = CreateCommand (Procedure) ;
			objCommand.ExecuteNonQuery () ;
			this.Close () ;
		}
		public void RunReturnNothing (string Procedure, SqlParameter[] paras)
		{
			SqlCommand objCommand = CreateCommand (Procedure, paras) ;
			objCommand.ExecuteNonQuery () ;
			this.Close () ;
		}

        /// <summary>
        /// ִ��CUD������ʱ��RETURN������ֵ
        /// </summary>
        /// <param name="Procedure">�洢��������</param>
        /// <param name="paras">SQL��������</param>
        /// <returns>SQL�洢����ֻ�ܷ���bigint, int, smallint���߿���ת��Ϊ�����������͵�ֵ</returns>
        public string RunReturnString(string Procedure, SqlParameter[] paras)
        {

            SqlCommand objCommand = CreateCommand(Procedure, paras);
            objCommand.ExecuteNonQuery().ToString();
            this.Close();
            return objCommand.Parameters["@ReturnValue"].Value.ToString();
            
        }

        /// <summary>
        /// ִ��CUD������ʱ��OUTPUT������ֵ
        /// </summary>
        /// <param name="Procedure">�洢��������</param>
        /// <param name="paras">SQL��������</param>
        /// <returns>������������ֵ</returns>
        public SqlCommand RunReturnCommandObject(string Procedure, SqlParameter[] paras)
        {

            SqlCommand objCommand = CreateCommand(Procedure, paras);
            objCommand.ExecuteNonQuery().ToString();
            this.Close();
            return objCommand;
        }

        /// <summary>
        /// ִ��SELECT����ʱ�򷵻ؽ����
        /// </summary>
        /// <param name="Procedure">�洢��������</param>
        /// <param name="TableName">���ݿ������</param>
        /// <returns>���ؽ����DATASET</returns>
		public DataSet RunReturnDataSet (string Procedure, string TableName)
		{
			SqlDataAdapter objAdapter = new SqlDataAdapter () ;
			objAdapter.SelectCommand = CreateCommand (Procedure) ;
			DataSet objSet = new DataSet () ;
			this.Close () ;
			objAdapter.Fill (objSet, TableName) ;
			return objSet ;
		}

        /// <summary>
        /// ִ��SELECT����ʱ�򷵻ؽ����
        /// </summary>
        /// <param name="Procedure">�洢��������</param>
        /// <param name="paras">SQL��������</param>
        /// <param name="TableName">���ݿ������</param>
        /// <returns>���ؽ����DATASET</returns>
		public DataSet RunReturnDataSet (string Procedure, SqlParameter[] paras, string TableName)
		{
			SqlDataAdapter objAdapter = new SqlDataAdapter () ;
			objAdapter.SelectCommand = CreateCommand (Procedure, paras) ;
			DataSet objSet = new DataSet () ;
			this.Close () ;
			objAdapter.Fill (objSet, TableName) ;
			return objSet ;
		}

        /// <summary>
        /// ִ��SQL����ʱ�򷵻�DATAREADER
        /// </summary>
        /// <param name="Procedure">�洢��������</param>
        /// <param name="paras">SQL��������</param>
        /// <returns>����DATAREADER</returns>
        public SqlDataReader RunReturnDataReader(string Procedure, SqlParameter[] paras)
        {
            SqlCommand comm = CreateCommand(Procedure,paras);
            SqlDataReader sdr = comm.ExecuteReader();
            return sdr;
        }

        /// <summary>
        /// ִ��SQL����ʱ�򷵻�DATAREADER
        /// </summary>
        /// <param name="Procedure">�洢��������</param>
        /// <returns>����DATAREADER</returns>
        public SqlDataReader RunReturnDataReader(string Procedure)
        {
            SqlCommand comm = CreateCommand(Procedure);
            comm.CommandType = CommandType.StoredProcedure;
            SqlDataReader sdr = comm.ExecuteReader();
            return sdr;
        }

		#region Create fulll commmand with 1 paramter and returns
		public SqlCommand CreateCommand (string Procedure)
		{
			this.Open () ;
			SqlCommand objCommand = new SqlCommand (Procedure, objConn) ;
			objCommand.CommandType = CommandType.StoredProcedure ;
			return objCommand ;
		}
		#endregion

		#region Create full command with 2 paramters and returns
		public SqlCommand CreateCommand (string Procedure, SqlParameter[] paras)
		{
			this.Open () ;
			SqlCommand objCommand = new SqlCommand (Procedure, objConn) ;
			objCommand.CommandType = CommandType.StoredProcedure ;

			if (paras != null)
			{
				foreach (SqlParameter para in paras)
				{
					objCommand.Parameters.Add (para) ;
				}
			}

			return objCommand ;
		}
		#endregion

		#region Create full command with 2 paramters and no returns
		public SqlCommand CreateCommandNoReturns (string Procedure, SqlParameter[] paras)
		{
			this.Open () ;
			SqlCommand objCommand = new SqlCommand (Procedure, objConn) ;
			objCommand.CommandType = CommandType.StoredProcedure ;

			if (paras != null)
			{
				foreach (SqlParameter para in paras)
				{
					objCommand.Parameters.Add (para) ;
				}
			}
			return objCommand ;
		}
		#endregion

        /// <summary>
        /// ��Ӳ���
        /// </summary>
        /// <param name="ParameterName">��������</param>
        /// <param name="DataType">��������,ͬ�洢�����ж���Ĳ������ͱ���һ��</param>
        /// <param name="Value">����ֵ</param>
        /// <returns>����SqlParameter����</returns>
		public SqlParameter InParameter (string ParameterName, SqlDbType DataType, object Value)
		{
			return MakeParameter (ParameterName, DataType, Value, ParameterDirection.Input) ;
		}

        /// <summary>
        /// ����OUTPUT����(Ĭ�ϲ�����@OutputValue)
        /// </summary>
        /// <param name="DataType">��������,��SQL�洢������ʵ�ʷ����������Ͷ���</param>
        /// <returns>����SqlParameter����</returns>
        public SqlParameter OutParameter(SqlDbType DataType)
		{
            return MakeParameter("@OutputValue", DataType, null, ParameterDirection.Output);
        }

        /// <summary>
        /// ����OUTPUT����
        /// </summary>
        /// <param name="DataType"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public SqlParameter OutParameter(SqlDbType DataType,int size)
        {
            return MakeParameter("@OutputValue", DataType, null, ParameterDirection.Output,size);
        }

        /// <summary>
        /// ���RETURN����(Ĭ�ϲ�����@ReturnValue)
        /// </summary>
        /// <param name="DataType">��������,��SQL�洢������ʵ�ʷ����������Ͷ���</param>
        /// <returns>����SqlParameter����</returns>
        public SqlParameter ReturnParameter(SqlDbType DataType)
        {
            return MakeParameter("@ReturnValue", DataType, null, ParameterDirection.ReturnValue);
        }

        public SqlParameter MakeParameter(string ParameterName, SqlDbType DataType, object Value, ParameterDirection Direction)
		{
			SqlParameter para ;
            para = new SqlParameter(ParameterName, DataType);
			para.Direction = Direction ;
			if (!((Direction == ParameterDirection.Output || Direction == ParameterDirection.ReturnValue) && Value == null))
			{
				para.Value = Value ;
			}
			return para ;
		}
        /// <summary>
        /// ���Parameterʱ����SIZE����
        /// </summary>
        /// <param name="ParameterName"></param>
        /// <param name="DataType"></param>
        /// <param name="Value"></param>
        /// <param name="Direction"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public SqlParameter MakeParameter(string ParameterName, SqlDbType DataType, object Value, ParameterDirection Direction,int size)
        {
            SqlParameter para;
            para = new SqlParameter(ParameterName, DataType,size);
            para.Direction = Direction;
            if (!((Direction == ParameterDirection.Output || Direction == ParameterDirection.ReturnValue) && Value == null))
            {
                para.Value = Value;
            }
            return para;
        }

		//|------------------------------------------------------------------------------------------------------------|
		//|---------------------------------------------���ݿ�����״̬-------------------------------------------------|
		//|------------------------------------------------------------------------------------------------------------|
        public void Open()
        {
            if (objConn == null || objConn.State.ToString().Trim() == "Closed")
            {
                objConn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString);
                objConn.Open();
            }
        }
		public void Close ()
		{
			if (objConn != null)
			{
				objConn.Close () ;
			}
		}

		public void Dispost ()
		{
			if (objConn != null)
			{
				objConn.Dispose () ;
				objConn = null ;
			}
		}
	}
}