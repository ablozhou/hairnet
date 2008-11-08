using System;
using System.Collections.Generic;
using System.Text;

namespace Discuz.Ucenter
{
    public class UCFeed
    {

        private string m_icon;
        private int m_uid;
        private string m_username;
        private string m_titleTemplate;
        private string m_titleData;
        private string m_bodyTemplate;
        private string m_bodyData;
        private string m_bodyGeneral;
        private List<UCFeedImage> m_ucFeedImages = new List<UCFeedImage>(4);
        private string m_targetIDs;

        #region properties

        /// <summary>
        /// feed ���ܻ�Ա�������ֶ�
        /// </summary>
        public string TargetIDs
        {
          get { return m_targetIDs; }
          set { m_targetIDs = value; }
        }

        /// <summary>
        /// ͼ��
        /// </summary>
        public string Icon
        {
            get { return m_icon; }
            set { m_icon = value; }
        }

        /// <summary>
        /// �û�id
        /// </summary>
        public int Uid
        {
            get { return m_uid; }
            set { m_uid = value; }
        }

        /// <summary>
        /// �û���
        /// </summary>
        public string Username
        {
            get { return m_username; }
            set { m_username = value; }
        }

        /// <summary>
        /// feed ����ģ��
        /// </summary>
        public string TitleTemplate
        {
            get { return m_titleTemplate; }
            set { m_titleTemplate = value; }
        }

        /// <summary>
        /// feed ����
        /// </summary>
        public string TitleData
        {
            get { return m_titleData; }
            set { m_titleData = value; }
        }

        /// <summary>
        /// feed ����ģ��
        /// </summary>
        public string BodyTemplate
        {
            get { return m_bodyTemplate; }
            set { m_bodyTemplate = value; }
        }

        /// <summary>
        /// feed ����
        /// </summary>
        public string BodyData
        {
            get { return m_bodyData; }
            set { m_bodyData = value; }
        }

        /// <summary>
        /// �����ֶ�
        /// </summary>
        public string BodyGeneral
        {
            get { return m_bodyGeneral; }
            set { m_bodyGeneral = value; }
        }

        /// <summary>
        /// feed ���ͼƬ�����Ϊ 4 ��
        /// </summary>
        public List<UCFeedImage> Images
        {
            get { return m_ucFeedImages; }
            set { m_ucFeedImages = value; }
        }

        #endregion

        public UCFeed()
        {
            for (int i = 0; i < 4; i++)
            {
                this.m_ucFeedImages.Add(new UCFeedImage("", ""));
            }
        }
    }
}
