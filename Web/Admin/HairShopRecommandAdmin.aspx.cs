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

namespace Web.Admin
{
    public partial class HairShopRecommandAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.databind();
            }
        }
        public void databind()
        {
            List<HairShopRecommand> list = InfoAdmin.GetHairShopRecommands(0);

            Session["num"] = 0;
            this.dg.DataKeyField = "HairShopRecommandID";
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
                if (e.CommandName == "delete")
                {
                    int hairShopRecommandID = int.Parse(this.dg.DataKeys[e.Item.ItemIndex].ToString());

                    if (InfoAdmin.RecommandHairShop(0, hairShopRecommandID, string.Empty, string.Empty, UserAction.Delete))
                    {
                        StringHelper.AlertInfo("删除成功", this.Page);
                        this.Response.Redirect("HairShopRecommandAdmin.aspx");
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
                e.Item.Cells[8].Attributes.Add("onclick", "return confirm('确定删除么?')");

                HairShopRecommand hairShopRecommand = e.Item.DataItem as HairShopRecommand;
                Label lblID = e.Item.FindControl("lblID") as Label;
                Label lblRecommandRate = e.Item.FindControl("lblRecommandRate") as Label;
                Label lblCommentTotal = e.Item.FindControl("lblCommentTotal") as Label;
                Label lblCommentRate = e.Item.FindControl("lblCommentRate") as Label;
                //Label lblEdit = e.Item.FindControl("lblEdit") as Label;

                //序号
                int num = int.Parse(Session["num"].ToString());
                num++;
                lblID.Text = num.ToString();
                Session["num"] = num;
                //推荐指数（访问数+好评评论数+我要推荐数）
                int recommandRate = hairShopRecommand.HairShopVisitNum + hairShopRecommand.HairShopGood + hairShopRecommand.HairShopRecommandNum;

                lblRecommandRate.Text = recommandRate.ToString();
                //评论数（好评+坏评数）
                int commentTotal = hairShopRecommand.HairShopGood + hairShopRecommand.HairShopBad;

                lblCommentTotal.Text = commentTotal.ToString();
                //好评率（好评数/评论数）
                double commentRate = 0.0;
                if (commentTotal == 0)
                {
                    commentRate = 0;
                }
                else
                {
                    commentRate = Convert.ToDouble(hairShopRecommand.HairShopGood) / Convert.ToDouble(commentTotal);
                }
                lblCommentRate.Text = commentRate.ToString();

                //lblEdit.Text = "<a href='HairShopRecommandUpdate.aspx?HairShopRecommandID=" + hairShopRecommand.HairShopRecommandID.ToString() + "&HairShopID=" + hairShopRecommand.HairShopRawID.ToString() + "&operateType=2'>编辑</a>";
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
