/*
 * Class	   : MsSqlParameter
 * Namespace   : Colren.Provider.ProviderSQL
 * Assembly    : Colren.Provider.ProviderSQL
 * Author	   : Hu Zhiming
 * Description : 问答数据库操作类
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HairNet.Entry;

namespace HairNet.Provider
{
    public partial class MsSqlParameter
    {
        //public void test()
        //{


        //}
        //DataProvider dp = new DataProvider();

        //public MsSqlParameter()
        //{ }

        //#region 问答
        ///// <summary>
        ///// 通过UserID获得我的问题列表(不用修改)
        ///// </summary>
        ///// <param name="userID">用户ＩＤ</param>
        ///// <returns>问题实体类</returns>
        //public List<QAQuestion> GetMyQuestionByUserID(int userID)
        //{
        //    List<QAQuestion> GetQuestion = new List<QAQuestion>();
        //    SqlParameter[] paras = 
        //        {
        //            dp.InParameter("@userID",SqlDbType.Int,userID)
        //        };

        //    using (SqlDataReader sdr = dp.RunReturnDataReader("dbo.CMS_QA_GetMyQuestionByUserID", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            QAQuestion objQuestion = new QAQuestion();
        //            objQuestion = PopulateQuestionFromDataReader(sdr);
        //            GetQuestion.Add(objQuestion);
        //        }
        //    }

        //    return GetQuestion;
        //}
        ///// <summary>
        ///// 通过用户获得用户参与的问题（回答的问题）（不用修改）
        ///// </summary>
        ///// <param name="userID">用户ＩＤ</param>
        ///// <returns>用户回答的问题</returns>
        //public List<QAQuestion> GetMyJoinQuestionByUserID(int userID)
        //{
        //    List<QAQuestion> liQuestion = new List<QAQuestion>();
        //    SqlParameter[] paras = 
        //        {
        //            dp.InParameter("@userID",SqlDbType.Int,userID)
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("dbo.CMS_QA_GetMyJoinQuestionByUserID", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            QAQuestion objQuestion = new QAQuestion();
        //            objQuestion = PopulateQuestionFromDataReader(sdr);
        //            liQuestion.Add(objQuestion);
        //        }
        //    }
        //    return liQuestion;
        //}

        ///// <summary>
        ///// 获得最新的悬赏问题列表（不用修改）
        ///// </summary>
        ///// <param name="count">获得的数量</param>
        ///// <returns>问题实体类</returns>
        //public List<QAQuestion> GetQuestionOrderByDate(int count,bool state)
        //{
        //    List<QAQuestion> liQuestion = new List<QAQuestion>();
        //    SqlParameter[] paras = 
        //        {
        //            dp.InParameter("@count",SqlDbType.Int,count),
        //            dp.InParameter("@state",SqlDbType.Bit,state)
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("dbo.CMS_QA_GetQuestionOrderByDate", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            QAQuestion objQuestion = new QAQuestion();
        //            objQuestion = PopulateQuestionFromDataReader(sdr);
        //            liQuestion.Add(objQuestion);
        //        }
        //    }
        //    return liQuestion;
        //}

        ///// <summary>
        ///// 获得已经回答的帖子（不用修改）
        ///// </summary>
        ///// <param name="count"></param>
        ///// <returns></returns>
        //public List<QAQuestion> GetQuestionByAnswered(int count)
        //{
        //    List<QAQuestion> liQuestion = new List<QAQuestion>();
        //    SqlParameter[] paras = 
        //        {
        //            dp.InParameter("@count",SqlDbType.Int,count),
        //            dp.InParameter("@state",SqlDbType.Bit,true)
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("dbo.CMS_QA_GetQuestionByAnswered", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            QAQuestion objQuestion = new QAQuestion();
        //            objQuestion = PopulateQuestionFromDataReader(sdr);
        //            liQuestion.Add(objQuestion);
        //        }
        //    }
        //    return liQuestion;
        //}

        ///// <summary>
        ///// 获得已经还未解决的帖子（不用修改）
        ///// </summary>
        ///// <returns></returns>
        //public List<QAQuestion> GetQuestionByUnAnswered()
        //{
        //    List<QAQuestion> liQuestion = new List<QAQuestion>();
        //    SqlParameter[] paras = 
        //        {
        //            dp.InParameter("@state",SqlDbType.Bit,false)
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("dbo.CMS_QA_GetQuestionByUnAnsweredAll", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            QAQuestion objQuestion = new QAQuestion();
        //            objQuestion = PopulateQuestionFromDataReader(sdr);
        //            liQuestion.Add(objQuestion);
        //        }
        //    }
        //    return liQuestion;
        //}



        ///// <summary>
        ///// 答案表（增删改）
        ///// </summary>
        ///// <param name="answer">答案实体类</param>
        ///// <param name="action">操作类型（Create,Delete,Update）</param>
        ///// <returns>操作是否成功</returns>
        //public bool AnswerCreateDeleteUpdate(QAAnswer answer, UserAction action)
        //{
        //    //try
        //    //{
        //        Guid aid = new Guid(answer.answerID);
        //        Guid qid = new Guid(answer.GetQuestion.questionID);
        //        SqlParameter[] paras = 
        //        {
        //            dp.InParameter("@answerID",SqlDbType.UniqueIdentifier,aid),
        //            dp.InParameter("@questionID",SqlDbType.UniqueIdentifier,qid),
        //            dp.InParameter("@userID",SqlDbType.Int ,answer.GetUser.UserID),
        //            dp.InParameter("@content",SqlDbType.Text ,answer.content),
        //            dp.InParameter("@pic",SqlDbType.NVarChar,answer.pic),
        //            dp.InParameter("@emotionIcon",SqlDbType.NVarChar,answer.emotionIcon),
        //            dp.InParameter("@bonusGet",SqlDbType.Int,answer.bonusGet),
        //            dp.InParameter("@publishDate",SqlDbType.DateTime,answer.publishDate),
        //            dp.InParameter("@ip",SqlDbType.VarChar,answer.ip),
        //            dp.InParameter("@action",SqlDbType.Char,action)
        //        };
        //        dp.RunReturnNothing("dbo.CMS_QA_AnswerCreateDeleteUpdate", paras);
        //        return true;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    return false;
        //    //}
        //}


        ///// <summary>
        ///// 获得最昂贵的问题列表（不用修改）
        ///// </summary>
        ///// <param name="count">获得的数量</param>
        ///// <returns>问题实体类</returns>
        //public List<QAQuestion> GetQuestionOrderByBouns(int count,bool state)
        //{
        //    List<QAQuestion> liQuestion = new List<QAQuestion>();
        //    SqlParameter[] paras = 
        //        {
        //            dp.InParameter("@count",SqlDbType.Int,count),
        //            dp.InParameter("@state",SqlDbType.Bit,state)
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("dbo.CMS_QA_GetQuestionOrderByBouns", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            QAQuestion objQuestion = new QAQuestion();
        //            objQuestion = PopulateQuestionFromDataReader(sdr);
        //            liQuestion.Add(objQuestion);
        //        }
        //    }
        //    return liQuestion;
        //}

        //public List<QAQuestion> GetQuestionByIsElite(int count,bool state)
        //{
        //    List<QAQuestion> liQuestion = new List<QAQuestion>();
        //    SqlParameter[] paras = 
        //        {   
        //            dp.InParameter("@count",SqlDbType.Int,count),
        //            dp.InParameter("@state",SqlDbType.Bit,state)
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("dbo.CMS_QA_GetQuestionByIsElite", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            QAQuestion objQuestion = new QAQuestion();
        //            objQuestion = PopulateQuestionFromDataReader(sdr);
        //            liQuestion.Add(objQuestion);
        //        }
        //    }
        //    return liQuestion;
        //}

        ////???????????????????????????????????????????????????
        //public List<QAQuestion> GetQuestionByTypeID(int count, int typeID)
        //{
        //    List<QAQuestion> liQuestion = new List<QAQuestion>();
        //    SqlParameter[] paras = 
        //        {   
        //            dp.InParameter("@count",SqlDbType.Int,count),
        //            dp.InParameter("@typeID",SqlDbType.Int,typeID)
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("dbo.CMS_QA_GetQuestionByTypeID", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            QAQuestion objQuestion = new QAQuestion();
        //            objQuestion = PopulateQuestionFromDataReader(sdr);
        //            liQuestion.Add(objQuestion);
        //        }
        //    }
        //    return liQuestion;
        //}

        //public List<QAQuestion> GetQuestionByQuestionID(string questionID)
        //{
        //    List<QAQuestion> liQuestion = new List<QAQuestion>();
        //    SqlParameter[] paras = 
        //        {   
        //            dp.InParameter("@questionID", SqlDbType.UniqueIdentifier, new Guid(questionID))
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("dbo.CMS_QA_GetQuestionByQuestionID", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            QAQuestion objQuestion = new QAQuestion();
        //            objQuestion = PopulateQuestionFromDataReader(sdr);
        //            //objQuestion.GetTypes = CommonParameter.PopulateTypeFromDataReader(sdr);
        //            liQuestion.Add(objQuestion);
        //        }
        //    }
        //    return liQuestion;
        //}



        ///// <summary>
        ///// 获得问题的答案
        ///// </summary>
        ///// <param name="questionID"></param>
        ///// <returns></returns>
        //public List<QAAnswer> GetAnswerByQuestionID(string questionID)
        //{
        //    List<QAAnswer> GetAnswer = new List<QAAnswer>();
        //    Guid id = new Guid(questionID);
        //    SqlParameter[] paras = 
        //        {
        //            dp.InParameter("@questionID",SqlDbType.UniqueIdentifier,id)
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("dbo.CMS_QA_GetAnswerByQuestionID", paras))
        //    {
        //       GetAnswer = PopulateAnswerFromDataReader(sdr);
        //    }
        //    return GetAnswer;
        //}

        //public List<QAQuestion> GetQuestionByType(int TypeID, bool IsManaged)
        //{
        //    List<QAQuestion> liQuestion = new List<QAQuestion>();
        //    SqlParameter[] paras = 
        //        {
        //            dp.InParameter("@TypeID", SqlDbType.Int, TypeID),
        //            dp.InParameter("@IsManaged", SqlDbType.Bit, IsManaged)
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("CMS_QA_GetQuestionByType", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            QAQuestion objQuestion = new QAQuestion();
        //            objQuestion = PopulateQuestionFromDataReader(sdr);
        //            liQuestion.Add(objQuestion);
        //        }
        //    }
        //    return liQuestion;
        //}

        //public List<WeeklyBonus_QA> GetBestUser(int count)
        //{
        //    List<WeeklyBonus_QA> list = new List<WeeklyBonus_QA>();
        //    SqlParameter[] paras = 
        //        {
        //            dp.InParameter("@count",SqlDbType.Int,count)
        //        };
        //    using (SqlDataReader sdr = dp.RunReturnDataReader("CMS_QA_GetBestUser", paras))
        //    {
        //        while (sdr.Read())
        //        {
        //            WeeklyBonus_QA weeklyBonus = new WeeklyBonus_QA();

        //            weeklyBonus = PopulateWeeklyBonusFromDataReader(sdr);
        //            list.Add(weeklyBonus);
        //        }
        //    }
        //    return list;
        //}

        //#region Populate
        //private QAQuestion PopulateQuestionFromDataReader(IDataReader reader)
        //{
        //        Colren.Components.Objects.QAQuestion question = new QAQuestion();
        //        question.questionID = reader["QuestionID"].ToString();
        //        question.title = reader["Title"].ToString();
        //        question.content = reader["Content"].ToString();
        //        question.pic = reader["Pic"].ToString();
        //        question.bonus = Convert.ToInt32(reader["Bonus"].ToString());
        //        question.emotionIcon = reader["EmotionIcon"].ToString();
        //        question.xmlPath = reader["XmlPath"].ToString();
        //        question.publishDate = Convert.ToDateTime(reader["PublishDate"].ToString());
        //        question.manageDate = Convert.ToDateTime(reader["ManageDate"].ToString());
        //        question.isManaged = Convert.ToBoolean(reader["IsManaged"].ToString());
        //        question.ip = reader["IP"].ToString();
        //        question.tagsID = reader["TagsID"].ToString();
        //        question.tags = reader["Tags"].ToString();
        //        question.isElite = Convert.ToBoolean(reader["IsElite"].ToString());
        //        question.MostRecentPostAuthor = reader["MostRecentPostAuthor"].ToString();
        //        question.MostRecentPostAuthorID = Convert.ToInt32(reader["MostRecentPostAuthorID"].ToString());
        //        question.MostRecentPostDate = DateTime.Parse(reader["MostRecentPostDate"].ToString());
        //        try
        //        {
        //            question.GetUser.UserID = Convert.ToInt32(reader["UserID"].ToString());
        //            question.GetUser.Nickname = reader["NickName"].ToString();
        //            question.GetUser.Score1 = Convert.ToInt32(reader["Score1"].ToString());
        //            question.GetUser.Score2 = Convert.ToInt32(reader["Score2"].ToString());
        //            question.GetUser.ScoreUsed1 = Convert.ToInt32(reader["ScoreUsed1"].ToString());
        //            question.GetUser.ScoreUsed2 = Convert.ToInt32(reader["ScoreUsed2"].ToString());
        //            question.GetUser.ScoreAvailable1 = Convert.ToInt32(reader["ScoreAvailable1"].ToString());
        //            question.GetUser.ScoreAvailable2 = Convert.ToInt32(reader["ScoreAvailable2"].ToString());
        //        }
        //        catch { }
        //        try
        //        {
        //            question.GetTypes = CommonParameter.PopulateTypeFromDataReader(reader);
        //        }
        //        catch { }

        //        return question;
        //}

        //private List<QAAnswer> PopulateAnswerFromDataReader(IDataReader reader) 
        //{
        //    List<QAAnswer> GetAnswer = new List<QAAnswer>();

        //    while (reader.Read())
        //    {
        //        QAAnswer Answer = new QAAnswer();
        //        Answer.answerID = reader["AnswerID"].ToString();
        //        Answer.content = System.Web.HttpContext.Current.Server.HtmlDecode(reader["Content"].ToString());
        //        Answer.pic = reader["Pic"].ToString();
        //        Answer.emotionIcon = reader["EmotionIcon"].ToString();
        //        Answer.bonusGet = Convert.ToInt32(reader["BonusGet"].ToString());
        //        Answer.publishDate = Convert.ToDateTime(reader["PublishDate"].ToString());
        //        Answer.title = reader["title"].ToString();
        //        Answer.ip = reader["IP"].ToString();
        //        Answer.GetQuestion.questionID = reader["QuestionID"].ToString();
        //        Answer.GetUser.AvatarUrl = reader["AvatarUrl"].ToString();
        //        Answer.GetUser.ScoreAvailable1 = Convert.ToInt32(reader["ScoreAvailable1"].ToString());
        //        Answer.GetUser.Nickname = reader["Nickname"].ToString();
        //        Answer.GetUser.UserID = Convert.ToInt32(reader["UserID"].ToString());

        //        GetAnswer.Add(Answer);
        //    }
        //    return GetAnswer;
        //}

        //public string QuestionCreateUpdateDelete(QAQuestion question, UserAction action, bool IsTagsEqual, int OldBonus)
        //{
        //    SqlParameter[] paras = 
        //    {
        //        dp.InParameter("@questionID",SqlDbType.UniqueIdentifier,new Guid(question.questionID)), 
        //        dp.InParameter ("@userID",SqlDbType.Int,question.GetUser.UserID),
        //        dp.InParameter ("@title",SqlDbType.NVarChar,question.title),
        //        dp.InParameter ("@content",SqlDbType.Text,question.content),
        //        dp.InParameter ("@pic",SqlDbType.NVarChar,question.pic),
        //        dp.InParameter ("@bonus",SqlDbType.Int,question.bonus),
        //        dp.InParameter ("@emotionIcon",SqlDbType.NVarChar,question.emotionIcon),
        //        dp.InParameter ("@xmlPath",SqlDbType.NVarChar,question.xmlPath),
        //        dp.InParameter ("@publishDate",SqlDbType.DateTime,question.publishDate),
        //        dp.InParameter ("@manageDate",SqlDbType.DateTime,question.manageDate),
        //        dp.InParameter ("@isElite",SqlDbType.Bit,question.isElite),
        //        dp.InParameter ("@isManaged",SqlDbType.Bit,question.isManaged),
        //        dp.InParameter ("@ip",SqlDbType.VarChar,question.ip),
        //        dp.InParameter ("@tagsID",SqlDbType.NVarChar,""),
        //        dp.InParameter ("@tags",SqlDbType.NVarChar,""),
        //        dp.InParameter ("@typeID",SqlDbType.Int ,question.GetTypes.typeID),
        //        dp.InParameter ("@MostRecentPostAuthor",SqlDbType.NVarChar ,question.MostRecentPostAuthor),
        //        dp.InParameter ("@MostRecentPostAuthorID",SqlDbType.Int ,question.MostRecentPostAuthorID),
        //        dp.InParameter ("@IsTagsEqual", SqlDbType.Int, IsTagsEqual),
        //        dp.InParameter ("@OldBonus", SqlDbType.Int, OldBonus),
        //        dp.InParameter ("@action",SqlDbType.Char,action),
        //        dp.OutParameter (SqlDbType.UniqueIdentifier)
        //    };
        //    try
        //    {
        //        question.questionID = dp.RunReturnCommandObject("dbo.CMS_QA_QuestionCreateDeleteUpdate", paras).Parameters["@OutputValue"].Value.ToString();
        //    }
        //    catch (System.Data.SqlClient.SqlException e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //    return question.questionID;
        //}

        //public bool QuestionUpdateIsManaged(QAQuestion question)
        //{
        //    try
        //    {
        //        SqlParameter[] paras = 
        //            {
        //                dp.InParameter("@questionID",SqlDbType.UniqueIdentifier,new Guid(question.questionID)), 
        //                dp.InParameter("@userID",SqlDbType.Int,question.GetUser.UserID),
        //                dp.InParameter("@title",SqlDbType.NVarChar,question.title),
        //                dp.InParameter("@content",SqlDbType.Text,question.content),
        //                dp.InParameter("@pic",SqlDbType.NVarChar,question.pic),
        //                dp.InParameter("@bonus",SqlDbType.Int,question.bonus),
        //                dp.InParameter("@emotionIcon",SqlDbType.NVarChar,question.emotionIcon),
        //                dp.InParameter("@xmlPath",SqlDbType.NVarChar,question.xmlPath),
        //                dp.InParameter("@publishDate",SqlDbType.DateTime,question.publishDate),
        //                dp.InParameter("@manageDate",SqlDbType.DateTime,question.manageDate),
        //                dp.InParameter("@isElite",SqlDbType.Bit,question.isElite),
        //                dp.InParameter("@isManaged",SqlDbType.Bit,question.isManaged),
        //                dp.InParameter("@ip",SqlDbType.VarChar,question.ip),
        //                dp.InParameter("@tagsID",SqlDbType.NVarChar,""),
        //                dp.InParameter("@tags",SqlDbType.NVarChar,""),
        //                dp.InParameter("@typeID",SqlDbType.Int ,question.GetTypes.typeID),
        //                dp.InParameter("@action",SqlDbType.Char,UserAction.Update),
        //                dp.InParameter("@manageUserID",SqlDbType.Int,question.ManageUserID),
        //                dp.InParameter("@unnormalManage",SqlDbType.Bit ,question.UnnormalManaged)
        //            };
        //        dp.RunReturnNothing("dbo.CMS_QA_QuestionUpdateIsManaged", paras);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        //public WeeklyBonus_QA PopulateWeeklyBonusFromDataReader(IDataReader sdr)
        //{
        //    WeeklyBonus_QA weeklyBonus = new WeeklyBonus_QA();
        //    weeklyBonus.nickName = sdr["NickName"].ToString();
        //    weeklyBonus.weeklyQuestionBonusID = Convert.ToInt32(sdr["WeeklyQuestionBonusID"].ToString());
        //    weeklyBonus.datetime = DateTime.Now;
        //    weeklyBonus.professinal = sdr["Professinal"].ToString();
        //    weeklyBonus.userID = Convert.ToInt32(sdr["UserID"].ToString());
        //    weeklyBonus.weeklyAnswered = Convert.ToInt32(sdr["WeeklyAnswered"].ToString());
        //    weeklyBonus.weeklyBonusGet = Convert.ToInt32(sdr["WeeklyBonusGet"].ToString());

        //    return weeklyBonus;
        //}
        //#endregion
        //#endregion
    }
}
