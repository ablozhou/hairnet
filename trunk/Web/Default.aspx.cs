using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using HairNet.Provider;

namespace Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //HairNet.Provider.PictureStoreDataProvider sample = HairNet.Provider.PictureStoreDataProviderInstance.CreateInstance();
                
                //DataHelper dp = new DataProvider();

                ////SqlParameter returnValue = dp.ReturnParameter(SqlDbType.VarChar,100);
                //SqlParameter[] paras = 
                //    {
                //        dp.InParameter("@userID",SqlDbType.Int,0)
                //    };
                //string i;
                //DataSet ds = new DataSet();
                //try
                //{
                //    ds = dp.RunReturnDataSet("testProc", paras, "table1");
                //    //i = dp.RunReturnString("testProc", paras);
                //}
                //catch (Exception ex)
                //{
                //    throw new Exception(ex.Message); 
                //}
                ////int count = 0;
                ////using (SqlDataReader sdr = dp.RunReturnDataReader("testProc",paras))
                ////{   
                ////    while (sdr.Read())
                ////    {
                ////        count++;
                ////    }

                ////    sdr.Close();
                ////    sdr.Dispose();
                ////}
                //Response.Write(ds.Tables["table1"].Rows.Count);
                ////Response.Write(outputValue.Value.ToString());
                //
            }
        }
    }
}
