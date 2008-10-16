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
using HairNet.Business;

namespace HairNet.Components.BackendBusiness
{
    
    public class BBSPost
    {
        private string userid = "61195";
        private string username = "sgmf";
        private string connStr =  ConfigurationManager.AppSettings["Discuz_ConnectionString"].ToString();
        private int articleType = 0;
        public  enum Category { HairShop = 1, HairEngineer, HairStyle, PhotoGroup };
        
        
        /// <summary>
        /// 获取论坛id
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        private int GetForumId(Category category)
        {
            int forumId = -1;
             switch (category)
            {
                case Category.HairShop://美发厅72
                    
                    //GetHairShopContent(id, title, content);
                    forumId = 72;

                    break;
                case Category.HairEngineer: //美发师73
                    forumId = 73;
                    break;
                case Category.HairStyle: //发型69
                    forumId = 69;
                    break;
                case Category.PhotoGroup: //图组74
                    forumId = 74;
                    break;
                default:
                     forumId = -1;
                    break;
            }
            return forumId;
        }
        /// <summary>
        /// 发帖子
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="category"> 1：美发厅，2：美发师，3：发型，4：图组</param>
        /// <returns></returns>
        public bool AddPost(string title, string content, Category category, out int articleId)
        {
               /// <summary>
        /// 向论坛写帖子数据
        /// forumId：
        ///美发厅：72
        ///美发师：73
        ///图库（普通）：74
        ///图库（发型）：69
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
            int forumId = GetForumId(category);
               int aid = 0;
            try
            {
              
                ret = BusinessFacade.DataAccess.postArticle(forumId, articleType, title, content, userid, username, connStr, out aid);
               
            }
            catch
            {
                
                //...failed
            }
              articleId = aid;           
            return ret;
        }
        /// <summary>
        /// 回复帖子
        /// </summary>
        /// <param name="topicId">帖子主题ID</param>
        /// <param name="category">  1：美发厅，2：美发师，3：发型，4：图组</param>
        /// <param name="content">帖子内容</param>
        /// <param name="postUserId">发表用户ID</param>
        /// <param name="postUserName">发表用户名</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        public bool ReplyPost(int topicId, Category category, string content, string postUserId, string postUserName)
        {
          
            /// <param name="forumId">论坛版块ID</param>
            /// <param name="connStr">数据库连接串</param>
            /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
            int forumId = GetForumId(category );
            bool ret = false;
            try
            {

                ret = BusinessFacade.DataAccess.replyArticle(topicId,forumId,content, postUserId, postUserName, connStr);
            }
            catch
            {

                //...failed
            }
            return ret;

        }
        /// <summary>
        /// 根据帖子主题ID取所有帖子
        /// </summary>
        /// <param name="topicId">帖子主题ID</param>
        /// <param name="ds">输出数据集</param>
        /// <returns>布尔值，true表示该执行成功，false表示执行失败</returns>
        /// 
        public bool GetAllPostByTopicId(int topicId,out DataSet ds)
        {
            bool ret = false;
            DataSet data = new DataSet();
            try
            {
                ret = BusinessFacade.DataAccess.getBBSInfoByTopicId(topicId.ToString(), connStr, out data);
            }
             catch
             {

                 //...failed
             }
            ds = data;
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
        private bool GetHairShopContent(int hairShopId, out string title, out string content)
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
            cntBuilder.Append(" 风格："  +InfoAdmin.GetTypeNameById(hs.TypeID)+ "\n");
            cntBuilder.Append(" 主打产品：" + "\n");//InfoAdmin.GetProductByProductID+
            cntBuilder.Append(" 打印折扣券：" + "\n");
            cntBuilder.Append(" 折扣：" + "\n");
            cntBuilder.Append(" 预约电话：" + "\n");
            cntBuilder.Append(" 美发厅简介：" + "\n");
            cntBuilder.Append(" 查看详情" + "\n");
         
            content = cntBuilder.ToString();
            return true;

        }
        private List<string> GetHairShopOutPics(int hairShopId)
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
         private  List<string> GetHairShopInnerPics(int hairShopId)
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
 
    }
}
