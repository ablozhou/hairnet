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
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class UserCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ListItem li1 = new ListItem();
                li1.Value = "0";
                li1.Text = "请选择";

                this.ddlUserRole.Items.Add(li1);

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "select * from UserRole";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                ListItem li = new ListItem();
                                li.Value = sdr["UserRoleID"].ToString();
                                li.Text = sdr["UserRoleName"].ToString();

                                this.ddlUserRole.Items.Add(li);
                            }
                        }
                    }
                }
            }
        }
        public void btnSubmit_OnClick(object sender, EventArgs e)
        {
            string username = this.txtUserName.Text.Trim();
            string password = this.txtPwd.Text.Trim();
            string passwordagain = this.txtPwdAgain.Text.Trim();
            string email = this.txtEmail.Text.Trim();

            if (username==string.Empty)
            {
                this.lblInfo.Text = "请输入用户名";
                return;
            }
            if (email == string.Empty)
            {
                this.lblInfo.Text = "请输入邮箱";
                return;
            }
            if (password != passwordagain)
            {
                this.lblInfo.Text = "两次输入密码不一致";
                return;
            }
            if (this.ddlUserRole.SelectedItem.Value == "0")
            {
                this.lblInfo.Text = "请选择用户角色";
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select count(*) from UserBasicInfo where UserName = '"+username+"'";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    int count = Convert.ToInt32(comm.ExecuteScalar());

                    if (count > 0)
                    {
                        this.lblInfo.Text = "当前用户系统已经存在！";
                        return;
                    }
                }
            }
            int r = 0;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "insert into UserBasicInfo(UserName,Password,UserRoleID,Email) values('"+username+"','"+password+"',"+this.ddlUserRole.SelectedItem.Value+",'"+email+"')";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    try
                    {
                        r = comm.ExecuteNonQuery();
                        
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
            if (r > 0)
            {
                this.Response.Redirect("UserInfoAdmin.aspx");
            }
            else
            {
                this.lblInfo.Text = "添加失败！";
                return;
            }
            
        }
    }
}
