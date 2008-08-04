using System.Text;
using System.IO;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace HairNet.Utilities
{
    public class AutoCreateHtmlClass
    {
        public AutoCreateHtmlClass()
        {
            
        }
        ///// <summary>
        ///// 创建ＨＴＭＬ
        ///// </summary>
        ///// <param name="hc">ＨＴＭＬ模版实体类</param>
        ///// <returns>创建的ＨＴＭＬ文件名称</returns>
        //public string createHtml(htmlContent hc,string tempPath, string path)
        //{   
        //    //读取数据
        //    StringBuilder str = this.GetReaderString(tempPath); 
        //    //替换开始(这个开始的时候，现在还没定好，现在只是一个模版吧)
        //    str = str.Replace("showtitle1", hc.title);
        //    str = str.Replace("showtitle2", hc.title);
        //    str = str.Replace("content", hc.content);
        //    str = str.Replace("author", hc.author);
        //    //保存数据
        //    string fileName = this.WriteString(str, path);
        //    return fileName;
        //}
        /// <summary>
        /// 获得生成的文件名字
        /// </summary>
        /// <returns></returns>
        public StringBuilder GetFileName()
        {
            StringBuilder fileName = new StringBuilder("");
            fileName.Append(DateTime.Now.ToString("yyyymmddhhmmss"));
            fileName.Append(DateTime.Now.Millisecond.ToString());

            return fileName;
        }
        /// <summary>
        /// 读取数据流
        /// </summary>
        /// <param name="path">模版路径(eg:html/html.htm)</param>
        /// <param name="fileName">模版文件名</param>
        /// <returns></returns>
        public StringBuilder GetReaderString(string path)
        {
            Encoding code = Encoding.GetEncoding("gb2312");
            string temp = System.Web.HttpContext.Current.Server.MapPath(path);

            StreamReader sr = null;
            StringBuilder str = new StringBuilder();
            try
            {
                sr = new StreamReader(temp, code);
                str.Append(sr.ReadToEnd());
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write(ex.Message.ToString());
                HttpContext.Current.Response.End();
            }
            finally
            {
                sr.Close();
            }

            return str;
        }
        /// <summary>
        /// 读取数据文件（自动生成数据名保存的）
        /// </summary>
        /// <param name="str">写入的数据</param>
        /// <param name="path">保存的路径</param>
        /// <returns> 保存的文件名字</returns>
        public string WriteString(StringBuilder str, string path)
        {
            StreamWriter sw = null;
            Encoding code = Encoding.GetEncoding("gb2312");
            StringBuilder fileName = new StringBuilder();
            fileName = this.GetFileName(); 
           
            try
            {
                sw = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath(path.ToString()) + "/" + fileName.ToString() + ".htm", false, code);
                sw.Write(str.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message.ToString());
                HttpContext.Current.Response.End();
            }
            finally
            {
                sw.Close();
            }
            return path +"/"+ fileName.ToString() + ".htm";
        }
        /// <summary>
        /// 读取数据文件（自定义文件名）
        /// </summary>
        /// <param name="str">写入的数据</param>
        /// <param name="path">保存的路径</param>
        /// <returns> 保存的文件名字</returns>
        public string WriteString(StringBuilder str, string path,string fileName)
        {
            StreamWriter sw = null;
            Encoding code = Encoding.GetEncoding("gb2312");

            try
            {
                sw = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath(path.ToString()) + "/" + fileName.ToString() + ".html", false, code);
                sw.Write(str.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message.ToString());
                HttpContext.Current.Response.End();
            }
            finally
            {
                sw.Close();
            }
            return path + "/" + fileName.ToString() + ".html";
        }

        /// <summary>
        /// 读取数据文件（新闻内容页面）
        /// </summary>
        /// <param name="str">写入的数据</param>
        /// <param name="path">保存的路径</param>
        /// <returns> 保存的文件名字</returns>
        public string WriteNewsContentString(StringBuilder str, string path, string fileName)
        {
            StreamWriter sw = null;
            Encoding code = Encoding.GetEncoding("gb2312");

            try
            {
                sw = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath(path.ToString()) + "/" + fileName.ToString() + ".shtml", false, code);
                sw.Write(str.ToString());
                sw.Close();
            }
            catch (Exception ex)
            {
                HttpContext.Current.Response.Write(ex.Message.ToString());
                HttpContext.Current.Response.End();
            }
            finally
            {
                sw.Close();
            }
            return path + "/" + fileName.ToString() + ".shtml";
        }
    }
}
