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
        string UserID = "57907";
        string UserName = "LHL";   
        protected void Page_Load(object sender, EventArgs e)
        {
            StringHelper.AddStyleSheet(this.Page, "Theme/Style/meifating.css");
            HairShopID = Request.QueryString["id"];
            if (HairShopID == string.Empty)
            {
                Response.Write("id not exist");
                Response.End();
            }
            //int hairShopID = int.Parse(HairShopID.ToString());
            int hairShopID = 9;
            this.hairShopEntryControl.HairShopID = hairShopID;
            this.hairShopEntryDescription.HairShopID = hairShopID;
            this.hairShopEngineerList.HairShopID = hairShopID;
            this.hairShopWorkList.HairShopID = hairShopID;
            this.sameHairShopList.HairShopID = hairShopID;
            this.hairShopVoteControl.HairShopID = hairShopID;
            try
            {
                WriteHistoy(0);
                ShowBrowserHistory();
            }
            catch 
            {
            }
        }

        private System.Text.StringBuilder ReadComment(string BBSID)
        {
            System.Text.StringBuilder Txt = new System.Text.StringBuilder();
            Txt.Append("");
            DataSet ds = new DataSet();
            DataHelper _DataHelper = new DataHelper();
            if (_DataHelper.ReadBssComment(BBSID, "3", out ds))
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                  

                    int i = 0;
                    foreach (DataRow thisRow in ds.Tables[0].Rows)
                    {
                        i++;

                        Txt.AppendFormat("                            <div class=\"message-{0}\">", i % 2 == 1 ? 2 : 1);
                        Txt.AppendFormat("		");
                        Txt.AppendFormat("		  <div class=\"touxiang\"><div class=\"touxiang-2\"><img src=\"http://bbs.sg.com.cn/ucenter/avatar.php?uid={0}&size=small\" /></div></div>", thisRow["authorid"].ToString());
                        Txt.AppendFormat("		  <div class=\"mes-content\"><table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">");
                        Txt.AppendFormat("  <tr>");
                        Txt.AppendFormat("    <td width=\"9%\" align=\"left\" valign=\"top\" class=\"red12b\">{0}：</td>", thisRow["author"].ToString());
                        Txt.AppendFormat("<td width=\"69%\" align=\"left\" class=\"black12\">{0}</td>", thisRow["message"].ToString());
                        Txt.AppendFormat("<td width=\"22%\" align=\"right\" valign=\"top\" class=\"gray12\">{0}<br /></td>", HWCommon.Util.BBsDate(int.Parse(thisRow["lastpost"].ToString())));
                        Txt.AppendFormat("      <a href=\"#\" target=\"_blank\"><img src=\"Theme/images/fair-mft14.gif\" width=\"59\" height=\"19\" border=\"0\" /></a></td>");
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
                            string Sql = string.Format("insert dbo.History (UserID,HistoryUrl,Title,ProductID,UserName,type) values('{0}','{1}','','{2}','{3}',{4})", UserID, Request.Url.AbsoluteUri.ToString(), HairShopID, UserName, type);
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
        private void ShowInThisPage(int type)
        {
            System.Text.StringBuilder txt = new System.Text.StringBuilder();
            DataHelper _DataHelper = new DataHelper();
            string Sql = "";
            string SqlTop = "";
            Sql = string.Format("select * from dbo.History where ProductID={0} and type={1} order by id desc", HairShopID, type);
            SqlTop = string.Format("select top 3 * from dbo.History where ProductID={0} and type={1} order by id desc", HairShopID, type);

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
                    txt.AppendFormat("<td width=\"50%\" align=\"center\" valign=\"top\"><div class=\"pic-5\"><a href=\"http://u.sg.com.cn/space-{0}.html\"  target=\"_blank\"><img src=\"http://bbs.sg.com.cn/ucenter/avatar.php?uid={0}&size=small\" /></a></div><div class=\"pic-5-title\"><a href=\"#\" target=\"_blank\"><span class=\"gray\">{1}</span></a></div>", thisPicRow["UserID"].ToString(), thisPicRow["UserName"].ToString());
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
                    bbsid = 185513;
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
        }

        protected void CaiBottom_Click(object sender, ImageClickEventArgs e)
        {
            WriteHistoy(0);
        }

        private void ShowBrowserHistory()
        {
            DataHelper _DataHelper = new DataHelper();
            //浏览过这个的人还浏览过什么
            DataSet ds_Temp = new DataSet();
            StringBuilder Txt = new StringBuilder();
            if (UserID != "")
            {          
                ds_Temp = _DataHelper.ReadDb(string.Format("select top 6 HairShopID,HairShopName,Discount from HairShop where HairShopID in (select ProductID from History where UserID in (select UserID from History where UserID<>{0} and ProductID={1} ))", UserID, HairShopID));

            }
            else
            {
                     ds_Temp = _DataHelper.ReadDb(string.Format("select top 6 HairShopID,HairShopName,Discount from HairShop where HairShopID in (select ProductID from History where UserID in (select UserID from History where ProductID={1} ))", UserID, HairShopID));
            }
            Txt = new System.Text.StringBuilder();
            Txt.AppendFormat("<table width=\"92%\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\" style=\"margin-top:5px\">");
            
           
            foreach (DataRow thisPicRow in ds_Temp.Tables[0].Rows)
            {
                Txt.AppendFormat("<tr>");
                Txt.AppendFormat("  <td width=\"83%\" align=\"left\" class=\"gray14-e\">·&nbsp;<a href=\"#\" target=\"_blank\">{0}</a></td>", thisPicRow["HairShopName"].ToString());
                Txt.AppendFormat(" <td width=\"17%\" align=\"center\" class=\"red14\">{0}折</td>",thisPicRow["Discount"].ToString());
       
                Txt.AppendFormat("</tr>");
            }
            Txt.AppendFormat("</table>");
            this.HisBrow.Text = Txt.ToString();
        }
    }
}
