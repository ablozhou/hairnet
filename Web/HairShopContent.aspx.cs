using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using HairNet.Utilities;
using System.Data.SqlClient;
using System.Text;
using HairNet.DBUtility;


namespace Web
{
    public partial class HairShopContent : System.Web.UI.Page
    {

        string HairShopID = "";


        string UserID ="0";
        string UserName = "";   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null || Session["userid"].ToString() == string.Empty)
            {
                
            }
            else
            {
                UserID = Session["userid"].ToString();
            }

            if (Session["username"] == null || Session["userid"].ToString() == string.Empty)
            {
                //UserName = Session["username"].ToString();
            }
            else
            {
                UserName = Session["username"].ToString();
            }
            
            
            StringHelper.AddStyleSheet(this.Page, "Theme/Style/meifating.css");
            HairShopID = Request.QueryString["id"];
            if (HairShopID == string.Empty)
            {
                Response.Write("id not exist");
                Response.End();
            }
            int hairShopID = 0;
            try
            {
                hairShopID = int.Parse(HairShopID.ToString());
            }
            catch
            {
                Response.Write("防止注入！");
                Response.End();
            }

            //给美发厅访问+1
            this.AddNumToHairShop(hairShopID.ToString());

            //int hairShopID = 9;
            this.hairShopEntryControl.HairShopID = hairShopID;
            this.hairShopEntryDescription.HairShopID = hairShopID;
            this.hairShopEngineerList.HairShopID = hairShopID;
            this.hairShopWorkList.HairShopID = hairShopID;
            this.sameHairShopList.HairShopID = hairShopID;
            this.hairShopVoteControl.HairShopID = hairShopID;
            this.hairShopMapInfo.HairShopID = hairShopID;
            try
            {
                WriteHistoy(0);
                ShowBrowserHistory();
                ShowComment();
            }
            catch 
            {
            }
        }
        public void AddNumToHairShop(string hairShopID)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "update HairShop set HairShopVisitNum = HairShopVisitNum+1 where HairShopID=" + hairShopID;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();

                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
        private System.Text.StringBuilder ReadComment(string BBSID)
        {
            System.Text.StringBuilder Txt = new System.Text.StringBuilder();
            Txt.Append("");
            DataSet ds = new DataSet();
            DataHelper _DataHelper = new DataHelper();
            if (_DataHelper.ReadBssComment(BBSID, "10", out ds))
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                  

                    int i = 0;
                    foreach (DataRow thisRow in ds.Tables[0].Rows)
                    {
                        i++;
                        string author = "";
                        if (thisRow["author"].ToString() != string.Empty)
                        {
                            author = "<a href='http://u.sg.com.cn/space-" + thisRow["authorid"].ToString() + ".html' target='_blank'>" + thisRow["author"].ToString() + "</a>";
                        }
                        else
                        {
                            author ="精品发丝";
                        }

                        Txt.AppendFormat("                            <div class=\"message-{0}\">", i % 2 == 1 ? 2 : 1);
                        Txt.AppendFormat("		");
                        Txt.AppendFormat("		  <div class=\"touxiang\"><div class=\"touxiang-2\"><a href='http://u.sg.com.cn/space-" + thisRow["authorid"].ToString() + ".html' target='_blank'><img src=\"http://bbs.sg.com.cn/ucenter/avatar.php?uid={0}&size=small\" /></a></div></div>", thisRow["authorid"].ToString());
                        Txt.AppendFormat("		  <div class=\"mes-content\"><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">");
                        Txt.AppendFormat("  <tr>");
                        Txt.AppendFormat("    <td width=\"18%\" align=\"left\" valign=\"top\" class=\"black12\">{0}：</td>", author);
                        Txt.AppendFormat("<td width=\"60%\" align=\"left\" class=\"black12\">{0}</td>", thisRow["message"].ToString());
                        Txt.AppendFormat("<td width=\"22%\" align=\"right\" valign=\"top\" class=\"gray12\">{0}<br /></td>", HWCommon.Util.BBsDate(int.Parse(thisRow["lastpost"].ToString())));
                        Txt.AppendFormat("      </td>");
                        Txt.AppendFormat("  </tr>");
                        Txt.AppendFormat("</table>");
                        Txt.AppendFormat("<div class=\"point\"></div>");
                        Txt.AppendFormat("        ");
                        Txt.AppendFormat("		  </div>");
                        Txt.AppendFormat("		  <div class=\"clear\"></div>");
                        Txt.AppendFormat("		</div>");


                    }
                }
            }
            return Txt;
        }
      
        private void ShowInThisPage(int type)
        {
            System.Text.StringBuilder txt = new System.Text.StringBuilder();
            DataHelper _DataHelper = new DataHelper();
            string Sql = "";
            string SqlTop = "";
            Sql = string.Format("select * from dbo.History where ProductID={0} and type={1} order by HistoryId desc", HairShopID, type);
            SqlTop = string.Format("select top 3 * from dbo.History where ProductID={0} and type={1} order by HistoryId desc", HairShopID, type);

            if (UserID != "")
            {
                //已经登陆。但未验证
                // Sql += string.Format(" and UserID<>{0}", UserID);
                //  SqlTop += string.Format(" and UserID<>{0}", UserID);
            }
            else
            {
                this.CaiBottom.Visible = false;
            }
            DataSet ds = _DataHelper.ReadDb(Sql);
            DataSet dsTop = _DataHelper.ReadDb(SqlTop);


            txt.AppendFormat("<table width=\"90%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" style=\"margin-top:15px\">");

            txt.AppendFormat("<tr>");

            lblCaiCount.Text = ds.Tables[0].Rows.Count.ToString();



            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow thisPicRow in dsTop.Tables[0].Rows)
                {
                    txt.AppendFormat("<td width=\"50%\" align=\"center\" valign=\"top\"><div class=\"pic-5\"><a href=\"http://u.sg.com.cn/space-{0}.html\"  target=\"_blank\"><img src=\"http://bbs.sg.com.cn/ucenter/avatar.php?uid={0}&size=small\" /></a></div><div class=\"pic-5-title\"><a href=\"http://u.sg.com.cn/space-{0}.html\" target=\"_blank\"><span class=\"gray\">{1}</span></a></div>", thisPicRow["UserID"].ToString(), thisPicRow["UserName"].ToString());
                    txt.AppendFormat("</td>");
                    //txt.AppendFormat("<span class=\"gray12-c\"><a href=\"http://u.sg.com.cn/space-{0}.html\" target=\"_blank\">{1}</a></span></td>", thisPicRow["UserID"].ToString(), thisPicRow["UserName"].ToString());
                }
            }
            txt.AppendFormat("</tr>");
            txt.AppendFormat("</table>");
           
            this.UserBrow.Text = txt.ToString();
              

            //是否现实踩按钮
            if (UserID != "")
            {

                Sql = string.Format("select * from History where ProductID={0} and UserID={1} and type={2}", HairShopID, UserID, type);
                ds = new DataSet();
                ds = _DataHelper.ReadDb(Sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.CaiBottom.Visible = false;
                }
                else
                {

                    this.CaiBottom.Visible = true;

                }
            }
        }

        private void ShowComment()
        {
            DataSet ds;
            DataHelper _DataHelper = new DataHelper();
            int bbsid = 0;
            
                
                ds = _DataHelper.ReadDb("select top 1 postid from HairShop where HairShopID=" + HairShopID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    bbsid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    
                    this.UserComment.Text = ReadComment(bbsid.ToString()).ToString();
                }
            this.lblMoreComment.Text = "<a href=\"http://bbs.sg.com.cn/thread-"+bbsid.ToString()+"-1-1.html\" target=\"_blank\">更多评论&gt;&gt;</a>";
            
        }

        protected void btnComment_Click(object sender, ImageClickEventArgs e)
        {
            DataSet ds;
            DataHelper _DataHelper = new DataHelper();
            int bbsid = 0;
            if (this.TextBox1.Text.Trim() != "")
            {
                
                ds = _DataHelper.ReadDb("select top 1 postid from HairShop where HairShopID=" + HairShopID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    bbsid = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                   
                    if (UserID == "")
                    {
                        _DataHelper.NoNameComment(bbsid, 72, this.TextBox1.Text.Trim());
                    }
                    else
                    {
                        _DataHelper.HaveNameComment(bbsid, 72, UserName, UserID, this.TextBox1.Text.Trim());
                    }
                    this.UserComment.Text = ReadComment(bbsid.ToString()).ToString();
                }

            }
            this.Response.Redirect(this.Request.Url.ToString());
           
        }

        protected void CaiBottom_Click(object sender, ImageClickEventArgs e)
        {
            WriteHistoy(0);
        }
        private void WriteHistoy(int type)
        {
            //记录历史
            if (UserID != "")
            {
                //已经登陆才记录
                DataHelper _DataHelper = new DataHelper();
                DataSet ds = _DataHelper.ReadDb(string.Format("select * from History where UserID={0} and ProductID={1} and type={2}", UserID, HairShopID, type));
                if (ds.Tables[0].Rows.Count == 0)
                {
                    using (SqlConnection conn = DataHelper.ConnString())
                    {
                        try
                        {
                            string Sql = string.Format("insert dbo.History (UserID,HistoryUrl,ProductID,UserName,type) values({0},'{1}',{2},'{3}',{4})", int.Parse(UserID), Request.Url.AbsoluteUri.ToString(), int.Parse(HairShopID), UserName, type);
                            SqlHelper.ExecuteNonQuery(conn, CommandType.Text, Sql);
                        }
                        catch
                        {

                        }
                        finally
                        {
                            if (conn.State != System.Data.ConnectionState.Closed)
                            {
                                conn.Close();
                                conn.Dispose();
                            }
                        }
                    }
                }

            }
            ShowInThisPage(type);
        }
        private void ShowBrowserHistory()
        {
            DataHelper _DataHelper = new DataHelper();
            //浏览过这个的人还浏览过什么
            DataSet ds_Temp = new DataSet();
            StringBuilder Txt = new StringBuilder();
            if (UserID != "")
            {
                ds_Temp = _DataHelper.ReadDb(string.Format("select top 6 HairShopID,HairShopName,HairShopDiscount from HairShop where HairShopID in (select ProductID from History where UserID in (select UserID from History where UserID<>{0} and ProductID={1} ) and ProductID <> {1}) ", UserID, HairShopID));

            }
            else
            {
                ds_Temp = _DataHelper.ReadDb(string.Format("select top 6 HairShopID,HairShopName,HairShopDiscount from HairShop where HairShopID in (select ProductID from History where UserID in (select UserID from History where ProductID={1} ))", UserID, HairShopID));
            }
            Txt = new System.Text.StringBuilder();
            Txt.AppendFormat("<table width=\"92%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" style=\"margin-top:5px\">");


            foreach (DataRow thisPicRow in ds_Temp.Tables[0].Rows)
            {
                Txt.AppendFormat("<tr>");
                Txt.AppendFormat("  <td width=\"83%\" align=\"left\" class=\"gray14-e\">·&nbsp;<a href=\"HairShopContent.aspx?id={0}\" target=\"_blank\">{1}</a></td>", thisPicRow["HairShopID"].ToString(), StringHelper.GetDescription(thisPicRow["HairShopName"].ToString(), 12));
                Txt.AppendFormat(" <td width=\"17%\" align=\"center\" class=\"red14\">{0}折</td>", thisPicRow["HairShopDiscount"].ToString());

                Txt.AppendFormat("</tr>");
            }
            Txt.AppendFormat("</table>");
            this.HisBrow.Text = Txt.ToString();
        }


    }
}
