using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Utilities
{
    public class StringHelper
    {
        /// <summary>
        /// 获得节略的介绍
        /// </summary>
        /// <param name="content">全体内容</param>
        /// <param name="num">显示的数量</param>
        /// <returns></returns>
        public static string GetDescription(string content, int num)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(<)[^>]*(>)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            content = regex.Replace(content, "");
            if (content.Length > num)
            {
                return content.Substring(0, num) + "....";
            }
            else
            {
                return content;
            }
        }
         
        public static string UrlRedirect(string url)
        {
            string urlRedirect = "/SiteFiles/User/Login.aspx?returnurl=" + url;
            return urlRedirect; 
        }
        public static string GetReturnUrl(string url)
        {
            string returnUrl = "";
            if (url.IndexOf("returnurl=") > 0)
            {
                returnUrl = url.Substring(url.IndexOf("returnurl=") + 10).ToString();
            }
            else
            {
                returnUrl = url;
            }
            
            return returnUrl;
        }
        public static void AlertInfo(string info,System.Web.UI.Page page)
        {
            page.Response.Write("<script>alert('"+info+"')</script>");
        }
    }
}
