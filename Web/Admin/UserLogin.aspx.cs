using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using HairNet.Provider;


namespace Web.Admin
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            TextBox GetCode = Login1.FindControl("GetCode") as TextBox;//获取登陆控件中验证码文本框值
            if (Request.Cookies["CheckCode"] == null)
            {
                Response.Write(@"<script language=JavaScript>{window.alert('您的浏览器设置已被禁用 Cookies，您必须设置浏览器允许使用 Cookies 选项后才能使用本系统！');}</script>");
                return;
            }
            else
            {
                if (String.Compare(Request.Cookies["CheckCode"].Value, GetCode.Text.ToString().Trim(), true) != 0)
                {
                    Response.Write(@"<script language=JavaScript>{window.alert('验证码输入不正确！');}</script>");
                    return;
                }
                string UserLoginID = Login1.UserName.ToString().Trim().Replace("'", "").Replace("=", "");//得到输入的用户名
                string UserLoginPwd = Login1.Password.ToString().Trim().Replace("'", "").Replace("=", "");//得到输入的密码
                //得到md5值
                //string md5Pwd = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(UserLoginPwd, "md5").ToLower();
                string mySql = "select * from [UserBasicInfo] where [UserName]='" + UserLoginID + "' and [Password]='" + UserLoginPwd + "'";
                //下面部署自己的逻辑处理
                try
                {
                    using (SqlConnection conn = new SqlConnection(DataHelper2.SqlConnectionString))
                    {

                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = mySql;
                            conn.Open();

                            using (SqlDataReader sdr = comm.ExecuteReader())
                            {
                                if (!sdr.Read())
                                {

                                    e.Authenticated = false;//登录不通过
                                }
                                else
                                {
                                    Session["UserLoginID"] = UserLoginID;
                                    Session["UserLoginPwd"] = UserLoginPwd;
                                    e.Authenticated = true;//登录通过
                                    System.Web.Security.FormsAuthentication.SetAuthCookie(UserLoginID, false);

                                    //Response.Redirect("~/admin/index.aspx");
                                }
                            }
                        }
                    }
                 
                }
                catch (Exception ex)
                {
                    Response.Write("数据库错误，错误原因：" + ex.Message);
                    Response.End();
                }

            }

        }
    }
}
