﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;

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
        public static string GetDescription2(string content, int num)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(<)[^>]*(>)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            content = regex.Replace(content, "");
            if (content.Length > num)
            {
                return content.Substring(0, num);
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
            page.Response.Write("<script>alert('"+info+"');</script><script>window.location.href='"+page.Request.Url.ToString()+"';</script>");
        }
        public static void AddStyleSheet(Page page, string cssPath)
        {
            HtmlLink link = new HtmlLink();
            link.Href = cssPath;
            link.Attributes["rel"] = "stylesheet";
            link.Attributes["type"] = "text/css";
            page.Header.Controls.Add(link);
        }
        public static string GetExtraType(string path)
        {
            int start = path.LastIndexOf(".")+1;
            return path.Substring(start);
        }
        /// <summary>
        /// 过滤字符
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool StringFilter(string s)
        {
            string[] sList = new string[]{"net user",
                                    "xp_cmdshell",
                                    "/add",
                                    "exec master.dbo.xp_cmdshell",
                                    "net localgroup administrators",
                                    "select",
                                    "count",
                                    "Asc",
                                    "char",
                                    "mid",
                                    "'",
                                    "\"",
                                    ":",
                                    "insert",
                                    "delete from",
                                    "drop table",
                                    "update",
                                    "truncate",
                                    "from",
                                    "%",
                                    "<",
                                    ">"};

            foreach (string ss in sList)
            {
                if (s.Contains(ss))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
