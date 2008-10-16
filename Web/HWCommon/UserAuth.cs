/*	
	++=============================================================++
	||  Class:UserAuth  
	||  Purpose:用户认证类——提供用户认证、登录验证方法
	||
	++=============================================================++
*/
using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Net;
using System.IO;

namespace HWCommon
{
    /// <summary>
    /// UserAuth 的摘要说明。
    /// </summary>
    public class UserAuth
    {
            public static bool CheckAuthorization()
        {
            return CheckAuthorization(true);
        }

        public static bool CheckAuthorization(bool redirectLogin)
        {
                string host = HttpContext.Current.Request.Url.Host.ToLower();
                bool result = false;
                try
                {
                    if (HttpContext.Current.Request.Cookies["userToken"] == null || HttpContext.Current.Request.Cookies["userToken"].Value == "")
                    {
                        result = false;
                    }
                    else if (HttpContext.Current.Session["id"] != null)
                    {
                        string strUserToken = HttpContext.Current.Request.Cookies["userToken"].Value;
                        strUserToken = System.Web.HttpUtility.UrlDecode(strUserToken, System.Text.Encoding.GetEncoding("gb2312"));
                        int pos = strUserToken.IndexOf(",");
                        if (pos > 0)
                        {
                            string s = strUserToken.Substring(0, pos);
                            string[] sarr = s.Split('|');
                            if (sarr.Length == 2 && sarr[0] == HttpContext.Current.Session["id"].ToString() && sarr[1] == HttpContext.Current.Session["username"].ToString())
                                result = true;
                            else
                            {
                                HttpContext.Current.Session.Clear();
                                SetSession(ref result);
                            }
                        }
                        else
                        {
                            HttpContext.Current.Session.Clear();
                            SetSession(ref result);
                        }
                    }
                    else
                    {
                        SetSession(ref result);
                    }
                }
                catch
                {
                    LogOff();
                }
                if (redirectLogin && !result)
                    RedirectLogin();
                return result;
            
        }
        private static void SetSession(ref bool result)
        {
            UserInfo user;
            string userToken = HttpContext.Current.Request.Cookies["userToken"].Value;
            userToken = System.Web.HttpUtility.UrlDecode(userToken, System.Text.Encoding.GetEncoding("gb2312"));
            if (TokenManager.ValidateUserToken(ref userToken, out user))
            {
                HttpContext.Current.Session["id"] = user.ID;
                HttpContext.Current.Session["username"] = user.UserName;

                ResetCookie(userToken);
                result = true;
            }
            else
                result = false;
        }

        public static void ResetCookie(string userToken)
        {
            string host = HttpContext.Current.Request.Url.Host.ToLower();
            string domain = "sg.com.cn";
            HttpContext.Current.Response.Cookies.Remove("userToken");
            HttpContext.Current.Response.Cookies["userToken"].Domain = domain;
            HttpContext.Current.Response.Cookies["userToken"].Value = System.Web.HttpUtility.UrlEncode(userToken, System.Text.Encoding.GetEncoding("gb2312"));
        }
   
        private static void RedirectLogin()
        {
            string host = HttpContext.Current.Request.Url.Host.ToLower();

            string reghost = "hair.sg.com.cn";
            HttpContext.Current.Response.Redirect("http://" + reghost + ":8080/login.aspx?gourl=" + HttpUtility.UrlEncode(HttpContext.Current.Request.Url.ToString(), Encoding.GetEncoding("gb2312")), true);
        }


        public static void LogOff()
        {
            string host = HttpContext.Current.Request.Url.Host.ToLower();
            string domain = "sg.com.cn";
            HttpContext.Current.Session.Clear();
            HttpContext.Current.Response.Cookies.Remove("userToken");
            HttpContext.Current.Response.Cookies["userToken"].Domain = domain;
            HttpContext.Current.Response.Cookies["userToken"].Value = null;
        }       
    }
}