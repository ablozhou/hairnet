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
using HairNet.Utilities;

namespace Web.Admin
{
    public partial class ModelAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "select * from facestyle";
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
                                li.Value = sdr["id"].ToString();
                                li.Text = sdr["facestylename"].ToString();

                                this.ddlFaceStyle.Items.Add(li);
                            }
                        }
                    }
                }
            }
        }
        public void btnUpload_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            this.lblInfo.Visible = false;

            if (!PicOperate.isPermission(StringHelper.GetExtraType(big.Value)))
            {
                this.lblInfo.Text = "大图片格式不对";
                this.lblInfo.Visible = true;
                return;
            }
            //if (!PicOperate.isPermission(StringHelper.GetExtraType(small.Value)))
            //{
            //    this.lblInfo.Text = "小图片格式不对";
            //    this.lblInfo.Visible = true;
            //    return;
            //}

            string big1 = upload.UpLoadImg(big, "/uploadfiles/pictures/");
            System.Threading.Thread.Sleep(1000);
            string small1 = string.Empty;
            if (small.Value != string.Empty)
            {
                small1 = upload.UpLoadImg(small, "/uploadfiles/pictures/");
            }
            this.lblBig.Text = big1;
            this.lblSmall.Text = small1;

            this.lblInfo.Visible = true;
            this.lblInfo.Text = "<img width=100 height=50 src='"+small1+"'></img>&nbsp;&nbsp;<img src='"+big1+"' width=200 height=100></img>";
        }
        public void btnSubmit_OnClick(object sender, EventArgs e)
        {
            string sex = this.ddlSex.SelectedItem.Value;
            string facestyle = this.ddlFaceStyle.SelectedItem.Value;
            string bigurl = this.lblBig.Text;
            string thumburl = this.lblSmall.Text;
            string modelname = this.txtModelName.Text.Trim();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "insert into ModelList(ModelName,sex,facestyle,bigurl,thumburl) values('"+modelname+"','"+sex+"',"+facestyle+",'"+bigurl+"','"+thumburl+"')";
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

            this.Response.Redirect("ModelAdmin.aspx");
        }
    }
}
