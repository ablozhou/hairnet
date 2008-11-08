using System;
using System.Collections.Generic;
using System.Text;

namespace HWCommon
{
	public class Util
	{
        public static void AlertMessage(string mesg)
        {
            System.Web.HttpContext web = System.Web.HttpContext.Current;
            web.Response.Write("<Script Language='JavaScript'>alert('" + mesg + "');</Script>");
            web.Response.End();
        }
        public static void AlertMessage_Back(string mesg)
        {
            System.Web.HttpContext web = System.Web.HttpContext.Current;
            web.Response.Write("<Script Language='JavaScript'>alert('" + mesg + "');history.go(-1);</Script>");
            web.Response.End();
        }
        public static void AlertMessage_Close(string mesg)
        {
            System.Web.HttpContext web = System.Web.HttpContext.Current;
            web.Response.Write("<Script Language='JavaScript'>alert('" + mesg + "');window.close();</Script>");
            web.Response.End();
        }
        public static void AlertMessage_Goto(string mesg, string url)
        {
            System.Web.HttpContext web = System.Web.HttpContext.Current;
            web.Response.Write("<Script Language='JavaScript'>alert('" + mesg + "');location.href='" + url + "';</Script>");
            web.Response.End();
        }
        public static void AlertMessage_ParentGoto(string mesg, string url)
        {
            System.Web.HttpContext web = System.Web.HttpContext.Current;
            web.Response.Write("<Script Language='JavaScript'>alert('" + mesg + "');parent.location.replace('" + url + "');</Script>");
            web.Response.End();
        }
        public static void AlertMessage_TopReload_Close(string mesg)
        {
            System.Web.HttpContext web = System.Web.HttpContext.Current;
            web.Response.Write("<Script Language='JavaScript'>alert('" + mesg + "');window.close();top.opener.location.reload();</Script>");
            web.Response.End();
        }

        public static long ConvetTimeToInt()
        {
            long time=0;
            try
            {
                DateTime oldDate = Convert.ToDateTime("1970-01-01 08:00");
                System.TimeSpan ts = DateTime.Now - oldDate;
                time = Convert.ToInt64(ts.TotalSeconds);
            }
            catch { }
            return time;
        }
        public static DateTime BBsDate(int seconds)
        {
            DateTime d1 = new DateTime(1970, 1, 1, 8, 0, 0);
            return d1.AddSeconds(seconds);
        }
	}
}
