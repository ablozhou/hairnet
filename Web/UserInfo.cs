/*	
	++=============================================================++
	||  Class:UserInfo  
	||  Purpose:用户类
	++=============================================================++
*/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Web;
using System.Net;
using System.Text;
using System.Collections;

namespace HWCommon
{
    /// <summary>
    /// UserInfo 的摘要说明。
    /// </summary>
    public class UserInfo
    {
        public string ID;
        public string UserName;
     
        public UserInfo(string id, string username)
        {
            this.ID = id;
            this.UserName = username;
         
        }
      
    }



}
