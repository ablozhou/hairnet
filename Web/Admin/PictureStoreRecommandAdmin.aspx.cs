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
using System.Collections.Generic;
using HairNet.Entry;
using HairNet.Business;
using HairNet.Enumerations;
using HairNet.Utilities;

namespace Web.Admin
{
    public partial class PictureStoreRecommandAdmin : System.Web.UI.Page
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
            List<PictureStoreRecommand> list = InfoAdmin.GetPictureStoreRecommands(0);
            
            Session["num"] = 0;
            this.dg.DataKeyField = "PictureStoreRecommandID";
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
                    int pictureStoreRecommandID = int.Parse(this.dg.DataKeys[e.Item.ItemIndex].ToString());

                    if (InfoAdmin.RecommandPictureStore(0, pictureStoreRecommandID, string.Empty, string.Empty, UserAction.Delete))
                    {
                        StringHelper.AlertInfo("删除成功", this.Page);
                        this.Response.Redirect("PictureStoreRecommandAdmin.aspx");
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
                e.Item.Cells[7].Attributes.Add("onclick", "return confirm('确定删除么?')");

                PictureStoreRecommand pictureStoreRecommand = e.Item.DataItem as PictureStoreRecommand;
                Label lblID = e.Item.FindControl("lblID") as Label;
                Label lblPictureUrl = e.Item.FindControl("lblPictureUrl") as Label;
                Label lblEdit = e.Item.FindControl("lblEdit") as Label;

                //序号
                int num = int.Parse(Session["num"].ToString());
                num++;
                lblID.Text = num.ToString();
                Session["num"] = num;
                //预览图片
                lblPictureUrl.Text = "<a href='" + DataBinder.Eval(e.Item.DataItem, "PictureStoreRawUrl").ToString() + "'target='_blank'><img src='" + DataBinder.Eval(e.Item.DataItem, "PictureStoreLittleUrl").ToString() + "' width='40' height='20' alt='点击查看大图' /></a>";

                lblEdit.Text = "<a href='PictureStoreUpdate.aspx?PictureStoreRecommandID=" + pictureStoreRecommand.PictureStoreRecommandID.ToString() + "&PictureStoreID=" + pictureStoreRecommand.PictureStoreRawID.ToString() + "&operateType=2'>编辑</a>";
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
