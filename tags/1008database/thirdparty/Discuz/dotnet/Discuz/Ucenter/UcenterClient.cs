using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Discuz.Utility;
using Discuz.Crypt;

namespace Discuz.Ucenter
{

    public class UcenterClient
    {
        #region properties

        private string m_appid;
        private string m_appKey;
        private string m_serverUrl;
        private string m_serverCharset;
        private string m_userAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1)";

        public string UserAgent
        {
            get { return m_userAgent; }
            set { m_userAgent = value; }
        }

        public string Appid
        {
            get { return m_appid; }
            set { m_appid = value; }
        }

        public string AppKey
        {
            get { return m_appKey; }
            set { m_appKey = value; }
        }

        public string ServerUrl
        {
            get { return m_serverUrl; }
            set { m_serverUrl = value; }
        }


        public string ServerCharset
        {
            get { return m_serverCharset; }
            set { m_serverCharset = value; }
        }

        #endregion

        #region init

        public UcenterClient(string appid, string appkey, string serverurl, string serverkey, string servercharset)
        {
            m_appid = appid;
            m_appKey = appkey;
            m_serverUrl = serverurl;
            m_serverCharset = servercharset;
        }

        public UcenterClient()
        {
            m_appid = m_appKey = m_serverUrl = "";
            m_serverCharset = "gbk";
        }

        #endregion

        #region private method

        /// <summary>
        /// ������������
        /// </summary>
        /// <param name="module">Ucenter ģ��</param>
        /// <param name="actioin">����</param>
        /// <param name="parms">���ݲ���</param>
        /// <returns></returns>
        private string DoRequest(string module, string actioin, UCRequestParms parms)
        {
            string backstr = "";
            HttpWebRequest hwr;

            try
            {
                if (this.ServerUrl.Contains("index.php"))
                {
                    hwr = (HttpWebRequest)WebRequest.Create(this.ServerUrl);
                }
                else
                {
                    hwr = (HttpWebRequest)WebRequest.Create(this.ServerUrl + "/index.php");
                }

                byte[] requestBytes = BuildRequest(module, actioin, parms);

                hwr.Method = "POST";
                hwr.ContentType = "application/x-www-form-urlencoded";
                hwr.UserAgent = this.UserAgent;
                hwr.ContentLength = requestBytes.Length;
                Stream requestStream = hwr.GetRequestStream();
                requestStream.Write(requestBytes, 0, requestBytes.Length);
                requestStream.Close();

                HttpWebResponse res = (HttpWebResponse)hwr.GetResponse();

                StreamReader sr = new StreamReader(res.GetResponseStream(), CharEncoding(this.ServerCharset));
                backstr = sr.ReadToEnd(); sr.Close(); res.Close();
            }
            catch
            { }

            return backstr;

        }

        private Encoding CharEncoding(string StrEncode)
        {
            try
            {
                return Encoding.GetEncoding(StrEncode);
            }
            catch (ArgumentException)
            {
                return Encoding.Default;
            }
        }

        /// <summary>
        /// ucenter ���ݲ�������
        /// </summary>
        /// <param name="module"></param>
        /// <param name="action"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        private byte[] BuildRequest(string module, string action, UCRequestParms parms)
        {
            StringBuilder arg = new StringBuilder();
            if (parms != null)
            {
                foreach (KeyValuePair<string, string> parm in parms)
                {
                    arg.Append(parm.Key);
                    arg.Append("=");
                    arg.Append(Utils.UrlEncode(parm.Value));
                    arg.Append("&");
                }
                arg.Remove(arg.Length - 1, 1);
            }

            string request = string.Format(
                "m={0}&a={1}&&inajax=2&input={2}&&appid={3}",
                module,
                action,
                EncodeString(arg.ToString()),
                this.Appid);

            return System.Text.Encoding.ASCII.GetBytes(request);
        }

        /// <summary>
        /// ucenter ���ݼ��ܴ���
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string EncodeString(string str)
        {
            return Utils.UrlEncode(
                    DiscuzAuthCode.Encode(
                        str + "&agent=" + Utils.MD5(this.UserAgent) + "&time=" + Utils.UnixTimestamp(), this.AppKey)
                    );
        }

        #endregion

        /**
         * ��������Ϊ�� Ucenter Server ����ͨ�ŵ�����
         * 
         * ��������ģ��ɲ��� php ���� uc_client ���з��͵��������
         * 
         */
        
        #region public method (demo test)

        /// <summary>
        /// ������ȡ ucenter ���е�Ӧ���б�ӿ�
        /// </summary>
        /// <returns>xml string</returns>
        public string AppList()
        {
            return DoRequest("app", "ls", null);
        }

        /// <summary>
        /// ������ ȡ�ػ�Ա�Ķ���Ϣ�б�ӿ�
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="curpage"></param>
        /// <param name="pagesize"></param>
        /// <param name="folder"></param>
        /// <param name="filter"></param>
        /// <param name="msglen"></param>
        /// <returns></returns>
        public string UcenterPmList(int uid, int curpage, int pagesize, PMFolder folder, PMFilter filter, int msglen)
        {
            UCRequestParms parms = new UCRequestParms();

            parms["uid"] = uid.ToString();
            parms["page"] = curpage.ToString();
            parms["pagesize"] = pagesize.ToString();
            parms["folder"] = folder.ToString();
            parms["filter"] = filter.ToString();
            parms["mesglen"] = msglen.ToString();
            return DoRequest("pm", "ls", parms);
        }

        /// <summary>
        /// ���������� feed �ӿ�
        /// </summary>
        /// <param name="feed"></param>
        /// <returns></returns>
        public string UcenterAddFeed(UCFeed feed)
        {
            UCRequestParms parms = new UCRequestParms();

            parms["appid"] = this.Appid;
            parms["icon"] = feed.Icon;
            parms["uid"] = feed.Uid.ToString();
            parms["username"] = feed.Username;
            parms["title_template"] = feed.TitleTemplate;
            parms["title_data"] = feed.TitleData;
            parms["body_template"] = feed.BodyData;
            parms["body_data"] = feed.BodyData;
            parms["body_general"] = feed.BodyGeneral;
            parms["target_ids"] = feed.TargetIDs;

            int j;
            for( int i = 0; i < 4; i++)
            {
                j = i + 1;
                parms[string.Format("images_{0}_url", j.ToString())] = feed.Images[i].Url;
                parms[string.Format("images_{0}_link", j.ToString())] = feed.Images[i].Link;
            }

            return DoRequest("feed", "add", parms);
        }

        #endregion()
    }

}
