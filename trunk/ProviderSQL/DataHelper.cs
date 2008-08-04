using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;

namespace HairNet.Provider
{
	/// <summary>
	/// DataProvider 的摘要说明。
	/// </summary>
	public class DataHelper
	{
		public DataHelper()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		
		private SqlConnection objConn ;

		//|------------------------------------------------------------------------------------------------------------|
		//|---------------------------------------------------无返回---------------------------------------------------|
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
        /// 执行CUD操作的时候“RETURN”返回值
        /// </summary>
        /// <param name="Procedure">存储过程名称</param>
        /// <param name="paras">SQL参数数组</param>
        /// <returns>SQL存储过程只能返回bigint, int, smallint或者可以转换为以上三种类型的值</returns>
        public string RunReturnString(string Procedure, SqlParameter[] paras)
        {

            SqlCommand objCommand = CreateCommand(Procedure, paras);
            objCommand.ExecuteNonQuery().ToString();
            this.Close();
            return objCommand.Parameters["@ReturnValue"].Value.ToString();
            
        }

        /// <summary>
        /// 执行CUD操作的时候“OUTPUT”返回值
        /// </summary>
        /// <param name="Procedure">存储过程名称</param>
        /// <param name="paras">SQL参数数组</param>
        /// <returns>返回所有类型值</returns>
        public SqlCommand RunReturnCommandObject(string Procedure, SqlParameter[] paras)
        {

            SqlCommand objCommand = CreateCommand(Procedure, paras);
            objCommand.ExecuteNonQuery().ToString();
            this.Close();
            return objCommand;
        }

        /// <summary>
        /// 执行SELECT操作时候返回结果集
        /// </summary>
        /// <param name="Procedure">存储过程名称</param>
        /// <param name="TableName">数据库表名称</param>
        /// <returns>返回结果集DATASET</returns>
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
        /// 执行SELECT操作时候返回结果集
        /// </summary>
        /// <param name="Procedure">存储过程名称</param>
        /// <param name="paras">SQL参数数组</param>
        /// <param name="TableName">数据库表名称</param>
        /// <returns>返回结果集DATASET</returns>
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
        /// 执行SQL操作时候返回DATAREADER
        /// </summary>
        /// <param name="Procedure">存储过程名称</param>
        /// <param name="paras">SQL参数数组</param>
        /// <returns>返回DATAREADER</returns>
        public SqlDataReader RunReturnDataReader(string Procedure, SqlParameter[] paras)
        {
            SqlCommand comm = CreateCommand(Procedure,paras);
            SqlDataReader sdr = comm.ExecuteReader();
            return sdr;
        }

        /// <summary>
        /// 执行SQL操作时候返回DATAREADER
        /// </summary>
        /// <param name="Procedure">存储过程名称</param>
        /// <returns>返回DATAREADER</returns>
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
        /// 添加参数
        /// </summary>
        /// <param name="ParameterName">参数名称</param>
        /// <param name="DataType">参数类型,同存储过程中定义的参数类型保持一致</param>
        /// <param name="Value">参数值</param>
        /// <returns>返回SqlParameter对象</returns>
		public SqlParameter InParameter (string ParameterName, SqlDbType DataType, object Value)
		{
			return MakeParameter (ParameterName, DataType, Value, ParameterDirection.Input) ;
		}

        /// <summary>
        /// 返回OUTPUT参数(默认参数名@OutputValue)
        /// </summary>
        /// <param name="DataType">参数类型,视SQL存储过程中实际返回数据类型而定</param>
        /// <returns>返回SqlParameter对象</returns>
        public SqlParameter OutParameter(SqlDbType DataType)
		{
            return MakeParameter("@OutputValue", DataType, null, ParameterDirection.Output);
        }

        /// <summary>
        /// 返回OUTPUT参数
        /// </summary>
        /// <param name="DataType"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public SqlParameter OutParameter(SqlDbType DataType,int size)
        {
            return MakeParameter("@OutputValue", DataType, null, ParameterDirection.Output,size);
        }

        /// <summary>
        /// 添加RETURN参数(默认参数名@ReturnValue)
        /// </summary>
        /// <param name="DataType">参数类型,视SQL存储过程中实际返回数据类型而定</param>
        /// <returns>返回SqlParameter对象</returns>
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
        /// 添加Parameter时增加SIZE参数
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
		//|---------------------------------------------数据库连接状态-------------------------------------------------|
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