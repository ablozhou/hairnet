/*	
	++=============================================================++
	||  Class:UserInfo  
	||  Purpose:�û���
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
    /// UserInfo ��ժҪ˵����
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
