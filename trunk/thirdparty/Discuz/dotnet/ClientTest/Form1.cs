using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Discuz.Ucenter;

namespace ClientTest
{
    public partial class Form1 : Form
    {
        UcenterClient m_client;

        public Form1()
        {
            InitializeComponent();
            m_client = new UcenterClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setupClient();
            textBoxResponse.Text = m_client.AppList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setupClient();
            textBoxResponse.Text = m_client.UcenterPmList(1, 1, 1, PMFolder.inbox, PMFilter.all, 255);
        }

        private void setupClient()
        {
            m_client.Appid = textBoxAppid.Text;
            m_client.AppKey = textBoxAppKey.Text;
            m_client.ServerUrl = textBoxUrl.Text;
            m_client.ServerCharset = textBoxCharset.Text;
        }

        private void textBoxResponse_TextChanged(object sender, EventArgs e)
        {
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            setupClient();
            UCFeed feed = new UCFeed();
            feed.Uid = 1;
            feed.Icon = "1";
            feed.Username = "admin";
            feed.TitleData = "ads";
            feed.TitleTemplate = "a{a}a";
            feed.BodyData = "aaaaaaa";
            feed.BodyGeneral = "";
            feed.BodyTemplate = "dd";
            feed.TargetIDs = "1,2";
            feed.Images[0] = new UCFeedImage("http://ddd", "link1");
            feed.Images[1] = new UCFeedImage("http://ddd", "link2");
            textBoxResponse.Text = m_client.UcenterAddFeed(feed);
        }
    }
}