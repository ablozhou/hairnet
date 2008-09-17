using System;
using System.Collections.Generic;
using System.Text;

namespace Discuz.Ucenter
{
    public class UCFeedImage
    {
        private string m_url;
        private string m_link;

        public string Url
        {
            get { return m_url; }
            set { m_url = value; }
        }

        public string Link
        {
            get { return m_link; }
            set { m_link = value; }
        }

        public UCFeedImage(string url, string link)
        {
            m_url = url;
            m_link = link;
        }
    }
}
