using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public class ProductDataProviderInstance: ProductDataProvider
    {
        public override bool ProductCreateDeleteUpdate(Product product, UserAction ua)
        {
            bool result = false;
            string commandText = string.Empty;
            switch (ua)
            {
                case UserAction.Create:
                    commandText = "";
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
