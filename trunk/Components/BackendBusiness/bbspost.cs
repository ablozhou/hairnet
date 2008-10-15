using System;
using System.Collections.Generic;

using System.Configuration;
using System.Collections;
using System.Text;
using BusinessFacade;
using System.Data;
using HairNet.Entry;
using HairNet.Provider;
using HairNet.Components;
using System.Data.SqlClient;

namespace HairNet.Components.BackendBusiness
{
    class bbspost
    {
        public bool AddPost(int id, int category)
        {
               /// <summary>
        /// 向论坛写帖子数据
        /// </summary>
        /// <param name="forumId">论坛版块ID</param>
        /// <param name="articleType">帖子类型0-普通帖，1-投票帖，3-悬赏帖</param>
        /// <param name="title">帖子标题</param>
        /// <param name="content">帖子内容</param>
        /// <param name="postUserId">发表用户ID</param>
        /// <param name="postUserName">发表用户名</param>
        /// <param name="connStr">数据库连接串</param>
        /// <param name="ariticleId">输出帖子ID</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
            bool ret = false;
            int forumId = 0;
            int articleType = 0;
            string title = string.Empty;
            string content = string.Empty;
            string uid = string.Empty;
            string uname = "";
            string connStr = "";
            int articleid = 0;

            switch (category)
            {
                case 1://美发厅
                    //GetHairShopContent(id, title, content);
                    break;
                case 2: //美发师
                    break;
                case 3: //发型
                    break;
                case 4: //图组
                    break;
                default:
                    break;
            }



            ret = BusinessFacade.DataAccess.postArticle(forumId, articleType, title, content, uid, uname, connStr, out articleid);

                        
            return ret;
        }

        /// <summary>
        /// 查询数据库，获取美发厅信息，组装BBS内容
        /// </summary>
        /// <param name="hairShopId"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        /// 内容：

        /*
            图片列表

            地址：
            交通：
            面积：
            停车位：
            是否刷卡：
            营业时间：
            风格：
            主打产品：
            打印折扣券（点此链接弹出优惠券打印页面）
            折扣：
            预约电话：
            美发厅简介：
            美发厅领军人物缩略图，美发师名称，美发师简介。
            查看详情（点击能到美发厅末级页）
        */
        public bool GetHairShopContent(int hairShopId, out string title, out string content)
        {
            HairShop hs = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(hairShopId);
            List<string>  outpics = GetHairShopOutPics(hairShopId);
            List<string>  inpics =GetHairShopInnerPics(hairShopId);
            StringBuilder cntBuilder = new StringBuilder();
            title = hs.HairShopName;

            foreach (string i in outpics)
            {
                cntBuilder.Append(i+",");
            }
            foreach (string i in inpics)
            {
                cntBuilder.Append(i + ",");
            }

            cntBuilder.Append("地址：" + hs.HairShopAddress + "\n");
            cntBuilder.Append("交通：" + hs.LocationMapURL + "\n");
            cntBuilder.Append("面积：" + hs.Square.ToString() + "\n");
            cntBuilder.Append("是否有停车位：" + hs.IsPostStation.Equals(false).ToString() + "\n");
            cntBuilder.Append("是否刷卡：" + hs.IsPostMachine.Equals(false).ToString() + "\n");
            cntBuilder.Append("营业时间：" + hs.HairShopOpenTime.ToString() + "\n");
            cntBuilder.Append(" 风格："  + "\n");

            content = cntBuilder.ToString();
            return true;

        }
        public List<string> GetHairShopOutPics(int hairShopId)
        {

            List<string> outpics = new List<string>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "select * from shoppics where hairshopID=" + hairShopId + " and classid=2 order by id desc";//out pic
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();

                    int num = 0;

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            outpics.Add(sdr["picsmallurl"].ToString());
                        }
                    }
                }
            }
            return outpics;
        }
         public List<string> GetHairShopInnerPics(int hairShopId)
        {

            List<string> inpics = new List<string>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "select * from shoppics where hairshopID=" + hairShopId + " and classid=1 order by id desc";//inner pic
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();

                    int num = 0;

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            inpics.Add(sdr["picsmallurl"].ToString());
                        }
                    }
                }
            }
            return inpics;
        }
        public bool ReplyPost(int topicId)
        {
            /// <summary>
            /// 回复帖子
            /// </summary>
            /// <param name="forumId">论坛版块ID</param>
            /// <param name="topicId">帖子主题ID</param>
            /// <param name="content">帖子内容</param>
            /// <param name="postUserId">发表用户ID</param>
            /// <param name="postUserName">发表用户名</param>
            /// <param name="connStr">数据库连接串</param>
            /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
            int forumId = 0;
            
            string content = "";
            string postUserId = string.Empty;
            string postUserName = string.Empty;
            string connStr = string.Empty;
            bool ret = BusinessFacade.DataAccess.replyArticle(topicId,forumId,content, postUserId, postUserName, connStr);

            return ret;

        }

        public bool GetAllPost(int topicId, DataSet ds)
        {
            /// <summary>
            /// 根据帖子主题ID取所有帖子
            /// </summary>
            /// <param name="topicId">帖子主题ID</param>
            /// <param name="ds">输出数据集</param>
            /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
            /// 
            string connStr = string.Empty;
            bool ret = BusinessFacade.DataAccess.getBBSInfoByTopicId(topicId.ToString (), connStr,out ds);
            return ret;
        }
    }
}
