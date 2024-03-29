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
using HairNet.Enumerations;
using HairNet.Utilities;
using System.Data.SqlClient;
namespace Web.Admin
{
    public partial class ProductAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                

                Session["query"] = null;
                this.txtQueryName.Visible = true;
                this.txtStartTime.Visible = false;
                this.txtEndTime.Visible = false;
                this.lblEndTime.Visible = false;
                this.lblStartTime.Visible = false;
                this.lblTimeSpace.Visible = false;
                this.lblQueryNameSpace.Visible = true;
                this.databind();
            }
        }
        public void ddlQuery_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ddlQuery.SelectedValue != "3")
            {
                this.txtQueryName.Visible = true;
                this.lblQueryNameSpace.Visible = true;
                this.txtStartTime.Visible = false;
                this.txtEndTime.Visible = false;
                this.lblEndTime.Visible = false;
                this.lblStartTime.Visible = false;
                this.lblTimeSpace.Visible = false;
            }
            else
            {
                this.txtQueryName.Visible = false;
                this.lblQueryNameSpace.Visible = false;
                this.txtStartTime.Visible = true;
                this.txtEndTime.Visible = true;
                this.lblStartTime.Visible = true;
                this.lblEndTime.Visible = true;
                this.lblTimeSpace.Visible = true;
            }
        }
        public void ddlOrderWay_OnSelectIndexChanged(object sender, EventArgs e)
        {
            this.databind();
        }
        public void btnQuery_OnClick(object sender, EventArgs e)
        {
            //目前只实现名称模糊查询，关键字和时间段具体实现需要确认
            Session["query"] = this.txtQueryName.Text;
            this.databind();
        }
        public void btnSelect_OnClick(object sender, EventArgs e)
        {
            foreach (DataGridItem dgi in this.dg.Items)
            {
                CheckBox IsSelect = dgi.FindControl("IsSelect") as CheckBox;
                if (this.btnSelect.Text == "全选")
                {
                    IsSelect.Checked = true;
                }
                else
                {
                    IsSelect.Checked = false;
                }
            }
            if (this.btnSelect.Text == "全选")
            {
                this.btnSelect.Text = "全不选";
            }
            else
            {
                this.btnSelect.Text = "全选";
            }
        }
        public void btnAdd_OnClick(object sender, EventArgs e)
        {
            //添加操作，转向添加页面
            this.Response.Redirect("ProductAdd.aspx");
        }
        public void btnRecommand_OnClick(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridItem dgi in this.dg.Items)
            {
                CheckBox IsSelect = dgi.FindControl("IsSelect") as CheckBox;
                if (IsSelect.Checked == true)
                {
                    i++;
                    int productID = int.Parse(this.dg.DataKeys[dgi.ItemIndex].ToString());

                    string productRecommandInfo = ConfigurationManager.AppSettings["ProductRecommandInfo"].ToString();
                    string productRecommandEx = string.Empty;

                    if (!InfoAdmin.RecommandProduct(productID, 0, productRecommandInfo, productRecommandEx, UserAction.Create))
                    {
                        StringHelper.AlertInfo("推荐失败", this.Page);
                    }
                }
            }
            if (i == 0)
            {
                StringHelper.AlertInfo("请选择要推荐的项", this.Page);
            }
            else
            {
                this.Response.Redirect("ProductAdmin.aspx");
            }
        }
        public void databind()
        {
            List<Product> list = new List<Product>();

            if (Session["query"] == null || Session["query"].ToString() == string.Empty)
            {
                //根据排序绑定,均是倒序
                switch (this.ddlOrderWay.SelectedValue)
                {
                    case "1":
                        //发布时间，即ID
                        list = InfoAdmin.GetProducts(0, OrderKey.ID);
                        break;
                    case "2":
                        //点击数
                        list = InfoAdmin.GetProducts(0, OrderKey.HitNum);
                        break;
                    case "3":
                        //评论数
                        //目前未实现评论数排序，目前为对评论数进行预处理，故DESIGN改变后，再实现
                        //list = InfoAdmin.GetProducts(0, OrderKey.CommentNum);
                        break;
                }
            }
            else
            {
                switch (this.ddlQuery.SelectedValue)
                {
                    case "1":
                        //名称
                        //根据排序绑定,均是倒序
                        switch (this.ddlOrderWay.SelectedValue)
                        {
                            case "1":
                                //发布时间，即ID
                                list = InfoAdmin.GetProducts(0, OrderKey.ID, Session["query"].ToString());
                                break;
                            case "2":
                                //点击数
                                list = InfoAdmin.GetProducts(0, OrderKey.HitNum, Session["query"].ToString());
                                break;
                            case "3":
                                //评论数
                                //目前未实现评论数排序，目前为对评论数进行预处理，故DESIGN改变后，再实现
                                //list = InfoAdmin.GetProducts(0, OrderKey.CommentNum, Session["query"].ToString());
                                break;
                        }
                        break;
                    case "2":
                        //关键字
                        break;
                    case "3":
                        //时间段
                        break;

                }
            }

            this.dg.DataKeyField = "ProductID";
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
        public void dg_OnItemCommand(object sender, DataGridCommandEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                if (e.CommandName == "recommand")
                {
                    int productID = int.Parse(this.dg.DataKeys[e.Item.ItemIndex].ToString());

                    string redirectUrl = "ProductRecommandUpdate.aspx?productID=" + productID.ToString() + "&productRecommandID=0&operateType=" + Convert.ToInt32(UserAction.Create).ToString();

                    this.Response.Redirect(redirectUrl);
                }
                if (e.CommandName == "delete")
                {
                    int productID = int.Parse(this.dg.DataKeys[e.Item.ItemIndex].ToString());

                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "delete from ProductRecommand where ProductRawID=" + productID.ToString();
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = commString;
                            comm.Connection = conn;
                            conn.Open();

                            try
                            {
                                comm.ExecuteNonQuery();
                            }
                            catch
                            {

                            }
                        }
                    }

                    Product product = InfoAdmin.GetProductByProductID(productID.ToString());

                    //tag逻辑

                    if (product.ProductTagIDs != string.Empty)
                    {
                        string[] tempTagC = product.ProductTagIDs.Split(",".ToCharArray());
                        for (int k = 0; k < tempTagC.Length; k++)
                        {
                            ProductTag hst = new ProductTag();
                            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                            {
                                string commString = "select * from ProductTag where ProductTagID=" + tempTagC[k];
                                using (SqlCommand comm = new SqlCommand())
                                {
                                    comm.CommandText = commString;
                                    comm.Connection = conn;
                                    conn.Open();
                                    using (SqlDataReader sdr = comm.ExecuteReader())
                                    {
                                        if (sdr.Read())
                                        {
                                            try
                                            {
                                                hst.TagID = int.Parse(sdr["ProductTagID"].ToString());
                                                hst.TagName = sdr["ProductTagName"].ToString();
                                                hst.ProductIDs = sdr["ProductIDs"].ToString();
                                            }
                                            catch
                                            { }
                                        }
                                    }
                                }
                            }
                            string[] tempProductIDC = hst.ProductIDs.Split(",".ToCharArray());
                            string ProductIDs = "";

                            int tempNum = 0;
                            for (int i = 0; i < tempProductIDC.Length; i++)
                            {
                                if (tempProductIDC[i] != product.ProductID.ToString())
                                {
                                    tempNum++;
                                    if (tempNum == 1)
                                    {
                                        ProductIDs = tempProductIDC[i];
                                    }
                                    else
                                    {
                                        ProductIDs += "," + tempProductIDC[i];
                                    }
                                }
                            }
                            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                            {
                                string commString = "update ProductTag set ProductIDs='" + ProductIDs + "' where ProductTagID=" + hst.TagID.ToString();
                                using (SqlCommand comm = new SqlCommand())
                                {
                                    comm.CommandText = commString;
                                    comm.Connection = conn;
                                    conn.Open();
                                    try
                                    {
                                        comm.ExecuteNonQuery();
                                    }
                                    catch
                                    { }
                                }
                            }
                        }
                    }

                    //

                    if (InfoAdmin.DeleteProduct(productID))
                    {
                        StringHelper.AlertInfo("删除成功", this.Page);
                        this.Response.Redirect("ProductAdmin.aspx");
                    }
                    else
                    {
                        StringHelper.AlertInfo("删除失败", this.Page);
                    }
                }
            }
        }
        public void dg_OnItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                e.Item.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#ffffff';");
                e.Item.Attributes.Add("onmouseout", "this.style.backgroundColor=c;");
                //e.Item.Cells[7].Attributes.Add("onclick", "return confirm('确定推荐么?');");
                e.Item.Cells[5].Attributes.Add("onclick", "return confirm('确定删除么?');");
            }
        }
        public void dg_OnPageIndexChanged(object sender, DataGridPageChangedEventArgs e)
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
