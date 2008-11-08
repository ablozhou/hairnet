using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using HairNet.DBUtility;

namespace web
{
/// <summary>
/// DataHelper 的摘要说明
/// </summary>
public class DataHelper
{
    public DataHelper()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    //匿名回复

    /// <summary>
    /// 匿名回复
    /// </summary>
    /// <param name="SubjectID">帖子ID</param>
    /// <param name="Pid">频道ID</param>
    /// <param name="Content">回复内容</param>
    /// <returns>true:成功  false:失败</returns>
    public bool NoNameComment(int SubjectID,int Pid,string Content)
    {
        if (BusinessFacade.DataAccess.replyArticle(SubjectID, Pid, Content, "0", "", DataHelper.BBsConnString().ToString()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// 通过用户名密码回复（需要自己判断登陆）
    /// </summary>
    /// <param name="SubjectID">帖子ID</param>
    /// <param name="Pid">频道ID</param>
    /// <param name="username">用户名</param>
    /// <param name="userid">用户ID</param>
    /// <param name="Content">内容</param>
    /// <returns>true:成功 false:失败</returns>
    public bool HaveNameComment(int SubjectID, int Pid, string username, string userid,  string Content)
    {
        if (BusinessFacade.DataAccess.replyArticle(SubjectID, Pid, Content, userid, username, DataHelper.BBsConnString().ToString()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //读取社区回复
    /// <summary>
    /// 读取社区回复
    /// </summary>
    /// <param name="SubjectID">频道id</param>
    /// <param name="SubjectID">频道id</param>
    /// <param name="ShowNum">显示数目</param>
    /// <returns>true:成功 false:失败</returns>
    public bool ReadBssComment(string SubjectID,string ShowNum,out DataSet ds)
    {
        //DataSet ds;
        string msg;
        if (HWCommon.SQLCommon.ExecuteDatasetForMySql(string.Format(@"SELECT  b.subject,b.tid,b.pid, a.lastposter,a.lastpost,b.author,b.authorid,b.message
FROM 
  cdb_threads a left join cdb_posts b on a.tid=b.tid 
  where a.tid={0} and b.subject=''
  order by  b.pid desc limit {1}", SubjectID,ShowNum), DataHelper.BBsConnString().ToString(), out ds, out msg))
        {

            return true;
        }
        else
        {
            return false;
        }
      
    }

    public string DelTxtLastStr(string Str, string Txt)
    {
        if (Txt.IndexOf(Str) > -1)
        {
            if (Txt.Substring(Txt.LastIndexOf(Str)) == Str)
            {
                Txt= Txt.Substring(0, Txt.LastIndexOf(Str));
            }
            if (Txt.Substring(0, 1) == ",")
            {
                Txt = Txt.Substring(1, Txt.Length-1);
            }
        }
        return Txt;
    }

    public string ReturnGroupPicPreviousUrl(string GroupID, string ThisID, int thisNum, string[] sArray, DataSet ds)
    {
        string FileName = "HairGroupLastPage.aspx";
        string Sql = "";
        Sql = "select top 1 PictureStoreGroupID,PictureStoreIDs,PictureStoreGroupName from PictureStoreGroup where PictureStoreGroupParentID=3 and datalength(pictureStoreIds)>0 ";
        string Previous = "";
        // DataSet ds = new DataSet();
        // ds = ReadDb(Sql+"and PictureStoreGroupID=" + GroupID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string PictureIDs = "";
            //PictureIDs = ds.Tables[0].Rows[0]["PictureStoreIDs"].ToString();
            // PictureIDs = DelTxtLastStr(",", PictureIDs);
            // string[] sArray = PictureIDs.Split(',');
            if (ThisID == "")
            {
                ThisID = sArray[0];
            }
            //判断当前页在ids的下标

            if (thisNum == 0)
            {
                ds = new DataSet();
                ds = ReadDb(Sql + "and PictureStoreGroupID<" + GroupID + "order by picturestoregroupid desc");
                if (ds.Tables[0].Rows.Count <= 0)//如果还没有 就取第一个专题的图片
                {
                    ds = new DataSet();
                    ds = ReadDb(Sql + " and  PictureStoreGroupID <> " + GroupID + " order by PictureStoreGroupID desc");
                }
                PictureIDs = ds.Tables[0].Rows[0]["PictureStoreIDs"].ToString();
                string[] sArray1 = PictureIDs.Split(',');
                Previous = sArray1[sArray1.Length - 1].ToString();//
                GroupID = ds.Tables[0].Rows[0]["PictureStoreGroupID"].ToString();
            }
            else
            {
                Previous = sArray[thisNum - 1];
            }

        }
        Previous = FileName + "?GroupID=" + GroupID + "&ThisID=" + Previous;
        return Previous;
    }

    public string ReturnGroupPicNextUrl(string GroupID, string ThisID, int thisNum, string[] sArray, DataSet ds)
    {
        string FileName = "HairGroupLastPage.aspx";
        string Sql = "";
        Sql = "select top 1 PictureStoreGroupID,PictureStoreIDs,PictureStoreGroupName from PictureStoreGroup where PictureStoreGroupParentID=3 and datalength(pictureStoreIds)>0 ";

        string NextPage = "";
        //  DataSet ds = new DataSet();
        // ds = ReadDb(Sql+" and PictureStoreGroupID=" + GroupID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string PictureIDs = "";
            //PictureIDs = ds.Tables[0].Rows[0]["PictureStoreIDs"].ToString();
            //PictureIDs = DelTxtLastStr(",", PictureIDs);
            //string[] sArray = PictureIDs.Split(',');
            if (ThisID == "")
            {
                ThisID = sArray[0];
            }

            //判断当前页在ids的下标



            if (thisNum == sArray.Length - 1)
            {
                //说明本页结束 获取下一个专题的第一个ID
                ds = new DataSet();
                ds = ReadDb(Sql + "and PictureStoreGroupID>" + GroupID + "order by picturestoregroupid desc");
                if (ds.Tables[0].Rows.Count <= 0)//如果还没有 就取第一个专题的图片
                {
                    ds = new DataSet();
                    ds = ReadDb(Sql + " and  PictureStoreGroupID <> " + GroupID + " order by PictureStoreGroupID asc");
                }

                PictureIDs = ds.Tables[0].Rows[0]["PictureStoreIDs"].ToString();
                string[] sArray1 = PictureIDs.Split(',');
                NextPage = sArray1[0].ToString();
                GroupID = ds.Tables[0].Rows[0]["PictureStoreGroupID"].ToString();
            }
            else
            {
                NextPage = sArray[thisNum + 1];
            }
        }
        NextPage = FileName + "?GroupID=" + GroupID + "&ThisID=" + NextPage;
        return NextPage;
    }
    public string NextGroupID(string GroupID)
    {
        string Sql = "select top 1 PictureStoreGroupID,PictureStoreIDs,PictureStoreGroupName from PictureStoreGroup where PictureStoreGroupParentID=3 and datalength(pictureStoreIds)>0 ";
        DataSet ds = new DataSet();
        ds = ReadDb(Sql + "and PictureStoreGroupID>" + GroupID + "order by picturestoregroupid desc");
        if (ds.Tables[0].Rows.Count <= 0)//如果还没有 就取第一个专题的图片
        {
            ds = new DataSet();
            ds = ReadDb(Sql + " and  PictureStoreGroupID <> " + GroupID + " order by PictureStoreGroupID asc");
        }

        GroupID = ds.Tables[0].Rows[0]["PictureStoreGroupID"].ToString();
        return GroupID;
    }

    public string PreviousGroupID(string GroupID)
    {
        string Sql = "select top 1 PictureStoreGroupID,PictureStoreIDs,PictureStoreGroupName from PictureStoreGroup where PictureStoreGroupParentID=3 and datalength(pictureStoreIds)>0 ";
        DataSet ds = new DataSet();
        ds = ReadDb(Sql + "and PictureStoreGroupID<" + GroupID + "order by picturestoregroupid desc");
        if (ds.Tables[0].Rows.Count <= 0)//如果还没有 就取第一个专题的图片
        {
            ds = new DataSet();
            ds = ReadDb(Sql + " and  PictureStoreGroupID <> " + GroupID + " order by PictureStoreGroupID desc");
        }

        GroupID = ds.Tables[0].Rows[0]["PictureStoreGroupID"].ToString();
        return GroupID;
    }

    /// <summary>
    /// 读取数据库，返回DataSet
    /// </summary>
    /// <param name="Sql">Select语句</param>
    /// <returns>返回数据DataSet</returns>
    public DataSet ReadDb(string Sql)
    {
        System.Data.DataSet ds = null;
        using (SqlConnection conn = ConnString())
        {
            ds = new DataSet();
            ds = SqlHelper.ExecuteDataset(conn, CommandType.Text, Sql);
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }
        return ds;
    }

    #region public static ConfigurationSettings ConnString() 返回链接字符串

    /// <summary>
    /// 返回链接SqlConnection
    /// </summary>
    /// <returns>链接SqlConnection</returns>
    public static SqlConnection ConnString()
    {
        SqlConnection connectionString = new SqlConnection();
        connectionString.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString();
        return connectionString;

    }
    #endregion


    #region public static ConfigurationSettings BBsConnString() 返回链接字符串

    /// <summary>
    /// 返回链接SqlConnection
    /// </summary>
    /// <returns>链接SqlConnection</returns>
    public static string BBsConnString()
    {
        string connectionString = "";
        try
        {
            connectionString = System.Configuration.ConfigurationManager.AppSettings["Discuz_ConnectionString"].ToString();
        }
        catch
        {
            connectionString= "";
        }
        return connectionString;

    }
    #endregion


    public DataSet RequestSmallPicList(string GroupID, string TopNum)
    {

        DataSet ds = new DataSet();
        string sql = "select PictureStoreIDs from PictureStoreGroup where datalength(pictureStoreIds)>0 and PictureStoreGroupID=" + GroupID;
        ds = ReadDb(sql);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string SmallListIds = ds.Tables[0].Rows[0][0].ToString();
            SmallListIds = DelTxtLastStr(",", SmallListIds);
            sql = "select top " + TopNum + " ID,PictureStoreId,SmallPictureUrl,'HairLastPage.aspx?id='+convert(varchar(50),PictureStoreId) as url,(select hairname from hairstyle where hairstyle.id=PictureStoreSet.PictureStoreid) as Title from PictureStoreSet where PictureStoreId in(" + SmallListIds + ") and NOT EXISTS (select * from PictureStoreSet as temp where temp.PictureStoreId=PictureStoreSet.PictureStoreID AND PictureStoreSet.ID>temp.ID) order by ID desc";
            ds = ReadDb(sql);
            //  return ds;
        }
        return ds;
    }

    public System.Text.StringBuilder RequestHtmlSmallPicList(string GroupID)
    {
        DataHelper NewHelper = new DataHelper();
        System.Text.StringBuilder Txt = new System.Text.StringBuilder();
        DataSet ds = RequestSmallPicList(GroupID, "10");
        if (ds.Tables[0].Rows.Count > 0)
        {
            
            Txt.AppendFormat("<table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">");
            Txt.AppendFormat("<tr>");
            Txt.AppendFormat(" <td width=\"592\" height=\"317\" valign=\"top\">");
            foreach (DataRow thisRow in ds.Tables[0].Rows)
            {
                Txt.AppendFormat("<table width=\"154\" height=\"176\" border=\"0\" align=\"left\" cellpadding=\"0\" cellspacing=\"0\">");
                Txt.AppendFormat("<tr>");
                Txt.AppendFormat("<td width=\"123\" height=\"154\" align=\"center\" valign=\"top\"><a title=\"" + thisRow["Title"] + "\" href=\"" + thisRow["Url"] + "\"><img src=\"" + thisRow["SmallPictureUrl"] + "\" class=\"pic_padding_glay\" /></a></td>");
                Txt.AppendFormat("<td width=\"31\" align=\"center\" valign=\"top\">&nbsp;</td>");
                Txt.AppendFormat("</tr>");
                Txt.AppendFormat("<tr>");
                Txt.AppendFormat("<td height=\"22\" align=\"center\" valign=\"middle\" class=\"gray12-d\"><a href=\"#\" class=\"gray12-c\">" + thisRow["Title"] + "</a></td>");
                Txt.AppendFormat("<td align=\"center\" valign=\"middle\" class=\"gray12-d\">&nbsp;</td>");
                Txt.AppendFormat("</tr>");
                Txt.AppendFormat("</table>");
            }
            Txt.AppendFormat("</td>");
            Txt.AppendFormat("</tr>");
            Txt.AppendFormat("</table>");
        }
        return Txt;
    }
    public System.Text.StringBuilder RequestPicTxtNewList(string PictureStoreGroupParentID)
    {
        DataHelper NewHelper = new DataHelper();
        System.Text.StringBuilder Txt = new System.Text.StringBuilder();
        DataSet ds = ReadDb("select PictureStoreIDs from PictureStoreGroup where datalength(pictureStoreIds)>0 and PictureStoreGroupParentID=" + PictureStoreGroupParentID);
        if (ds.Tables[0].Rows.Count > 0)
        {
            string IDS = "";
            foreach (DataRow thisRow in ds.Tables[0].Rows)
            {
                if (IDS == "")
                {
                    IDS = DelTxtLastStr(",", thisRow[0].ToString());
                }
                else
                {
                    IDS += "," + DelTxtLastStr(",", thisRow[0].ToString());
                }
            }

            ds = ReadDb("select top 10 ID,PictureStoreId,'HairLastPage.aspx?id='+convert(varchar(50),PictureStoreId) as url,(select hairname from hairstyle where hairstyle.id=PictureStoreSet.PictureStoreid) as Title,(select HitNum from HairStyle where HairStyle.id=PictureStoreSet.PictureStoreID) as HitNum from PictureStoreSet where PictureStoreId in(" + IDS + ") and NOT EXISTS (select * from PictureStoreSet as temp where temp.PictureStoreId=PictureStoreSet.PictureStoreID AND PictureStoreSet.ID>temp.ID) order by hitnum desc");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Txt.AppendFormat("<table width=\"86%\" border=\"0\" align=\"left\" cellpadding=\"0\" cellspacing=\"0\">");
                foreach (DataRow thisRow in ds.Tables[0].Rows)
                {
                    Txt.AppendFormat(" <tr>");
                         Txt.AppendFormat("  <td width=\"6%\">&nbsp;</td>");
                         Txt.AppendFormat(" <td width=\"94%\" class=\"gray14-line\">· <a title=\"" + thisRow["title"].ToString() + "\" href=\"" + thisRow["url"].ToString() + "\" target=\"_blank\">" + thisRow["title"].ToString() + "</a></td>");
                        Txt.AppendFormat(" </tr>");
                }
                Txt.AppendFormat("</table>");
            }
        }
        return Txt;
    }
}
}
