﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using HairNet.Entry;
using HairNet.Business;
using HairNet.Utilities;
using HairNet.Enumerations;
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class UserInfoAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                List<UserEntry> list = new List<UserEntry>();//UserAdmin.GetUsers(0);

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commandText = "select * from UserBasicInfo ubi inner join UserRole ur on ubi.UserRoleID = ur.UserRoleID order by UserID desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commandText;
                        comm.Connection = conn;
                        conn.Open();

                        using (SqlDataReader reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UserEntry ue = new UserEntry();

                                ue.UserID = int.Parse(reader["UserID"].ToString());
                                ue.UserName = reader["UserName"].ToString();
                                ue.UserRoleID = int.Parse(reader["UserRoleID"].ToString());
                                ue.UserRoleName = reader["UserRoleName"].ToString();
                                ue.Password = reader["Password"].ToString();
                                ue.Email = reader["Email"].ToString();

                                list.Add(ue);
                            }
                        }
                    }
                }
                Session["list"] = list;
                this.databind();
            }
        }
        public void btnSelectAll_OnClick(object sender, EventArgs e)
        {
            foreach (DataGridItem dgi in this.dg.Items)
            {
                CheckBox chkIsSend = dgi.FindControl("chkIsSend") as CheckBox;
                if (this.btnSelectAll.Text == "全选")
                {
                    chkIsSend.Checked = true;
                }
                else
                {
                    chkIsSend.Checked = false;
                }
            }
            if (this.btnSelectAll.Text == "全选")
            {
                this.btnSelectAll.Text = "全不选";
            }
            else
            {
                this.btnSelectAll.Text = "全选";
            }
        }
        public void btnQuery_OnClick(object sender, EventArgs e)
        {
            string userName = this.txtQueryName.Text.Trim();
            List<UserEntry> list = UserAdmin.GetUsersByUserName(userName);
            Session["list"] = list;
            this.databind();
        }
        public void btnSend_OnClick(object sender, EventArgs e)
        {
            foreach (DataGridItem dgi in this.dg.Items)
            {
                CheckBox chkIsSend = dgi.FindControl("chkIsSend") as CheckBox;
                if (chkIsSend.Checked)
                {
                    TempEmail tempEmail = new TempEmail();
                    tempEmail.TempEmailName = dgi.Cells[3].Text;

                    if (!UserAdmin.TempEmailCreateDeleteUpdate(tempEmail, UserAction.Create))
                    {
                        StringHelper.AlertInfo("发送邮件插入失败", this.Page);
                    }
                }
            }
            this.Response.Redirect("UserInfoAdmin.aspx");
        }
        public void btnAdd_OnClick(object sender, EventArgs e)
        {
            this.Response.Redirect("UserCreate.aspx");
        }
        public void btnDelete_OnClick(object sender, EventArgs e)
        {
            foreach (DataGridItem dgi in this.dg.Items)
            {
                CheckBox chkIsSend = dgi.FindControl("chkIsSend") as CheckBox;
                if (chkIsSend.Checked)
                {
                    int userID = int.Parse(this.dg.DataKeys[dgi.ItemIndex].ToString());

                    if (UserAdmin.DeleteUserByUserID(userID))
                    {
                        //this.Response.Redirect("UserInfoAdmin.aspx");
                    }
                    else
                    {
                        StringHelper.AlertInfo("删除失败", this.Page);
                    }
                }
            }
            this.Response.Redirect("UserInfoAdmin.aspx");
        }
        protected void databind()
        {
            List<UserEntry> list = Session["list"] as List<UserEntry>;

            this.dg.DataKeyField = "UserID";
            this.dg.DataSource = list;
            this.dg.DataBind();
            
            //绑定页码
            SetupPage();
            this.Page_nPage.Text = Convert.ToString(this.dg.CurrentPageIndex + 1);
            this.Page_nRecCount.Text = this.dg.PageCount.ToString();
            this.Page_nRecCount_1.Text = list.Count.ToString();//this.dg.Items.Count.ToString();
            ispages.Text = this.Page_nPage.Text;
            IsFirstLastPage(this.dg.PageCount, this.dg.CurrentPageIndex);
            if (this.dg.PageCount == 1)
            {
                this.dg.PagerStyle.Visible = false;
            }
            else
            {
                this.dg.PagerStyle.Visible = false;
            }
        }
        protected void dg_OnItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                e.Item.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#ffffff';");
                e.Item.Attributes.Add("onmouseout", "this.style.backgroundColor=c;");
                e.Item.Cells[6].Attributes.Add("onclick", "return confirm('确定删除么?')");

                //UserEntry userEntry = e.Item.DataItem as UserEntry;
                //CheckBox chkIsSend = e.Item.FindControl("chkIsSend") as CheckBox;
            }
        }
        protected void dg_OnItemCommand(object sender, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                int userID = int.Parse(this.dg.DataKeys[e.Item.ItemIndex].ToString());

                //删除并不是真正删除，只是标记当前用户不可使用，及IsActive为false
                if (UserAdmin.DeleteUserByUserID(userID))
                {
                    this.Response.Redirect("UserInfoAdmin.aspx");
                }
                else
                {
                    StringHelper.AlertInfo("删除失败", this.Page);
                }
            }
        }
        protected void dg_OnPageIndexChanged(object sender, DataGridPageChangedEventArgs e)
        {
            this.dg.CurrentPageIndex = e.NewPageIndex;
            this.databind();
        }
        protected void Page_Click(Object sender, EventArgs e)
        {
            int nPage;
            string commangArg = ((LinkButton)sender).CommandArgument;

            nPage = this.dg.CurrentPageIndex;


            switch (commangArg)
            {
                case "First": //如果点首页
                    {
                        nPage = 0;
                        break;
                    }
                case "Prev": //上一页
                    {
                        nPage = nPage - 1;
                        break;
                    }
                case "Next":  //下一页
                    {
                        nPage = nPage + 1;
                        break;
                    }
                case "Last": //尾页
                    {
                        nPage = this.dg.PageCount - 1;
                        break;
                    }
                default: { break; };
            }

            //Response.Write(nPage);
            // Response.End();

            IsFirstLastPage(this.dg.PageCount, nPage);
            Page_nPage.Text = (nPage + 1).ToString();
            Page_nRecCount.Text = this.dg.PageCount.ToString();

            this.dg.CurrentPageIndex = Convert.ToInt32(nPage);
            this.databind();
        }
        protected void Page_DropDownList(Object sender, EventArgs e)
        {
            int nPage = Convert.ToInt32(thispages.SelectedItem.Value) - 1;
            IsFirstLastPage(this.dg.PageCount, nPage);
            Page_nPage.Text = (nPage + 1).ToString();
            Page_nRecCount.Text = this.dg.PageCount.ToString();

            this.dg.CurrentPageIndex = Convert.ToInt32(nPage);
            this.databind();

        }
        private void IsFirstLastPage(int nPagecount, int nPage)
        {
            if (nPagecount > 1)
            {
                if (nPage == 0) { PagePrev.Enabled = false; PageFirst.Enabled = false; }
                else { PagePrev.Enabled = true; PageFirst.Enabled = true; }
                if (nPage == nPagecount - 1) { PageNext.Enabled = false; PageLast.Enabled = false; }
                else { PageNext.Enabled = true; PageLast.Enabled = true; }
            }
            else
            {
                PageFirst.Enabled = false; PagePrev.Enabled = false; PageNext.Enabled = false; PageLast.Enabled = false;
            }
        }
        //设置分页列表框
        protected void SetupPage()
        {
            thispages.Items.Clear();
            int nPagecount = this.dg.PageCount;
            for (int i = 1; i <= nPagecount; i++)
            {
                thispages.Items.Add(i.ToString());
            }

            if (nPagecount > 0) { thispages.SelectedIndex = 0; }

        }
    }
}
