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
using System.Data.SqlClient;
using HairNet.Provider;

namespace Web.Admin
{
    public partial class HairStyleAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.databind();

                Session["query"] = null;
                //this.txtQueryName.Visible = true;
                
            }
        }
        //public void ddlQuery_OnSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (this.ddlQuery.SelectedValue != "3")
        //    {
        //        this.txtQueryName.Visible = true;
               
        //    }
        //    else
        //    {
        //        this.txtQueryName.Visible = false;
               
        //    }
        //}
        public void ddlOrderWay_OnSelectIndexChanged(object sender, EventArgs e)
        {
            this.databind();
        }
        //public void btnQuery_OnClick(object sender, EventArgs e)
        //{
        //    //目前只实现名称模糊查询，关键字和时间段具体实现需要确认
        //    Session["query"] = "HairName like '%" + txtQueryName.Text.Trim() + "%'";
        //    this.databind();
        //}
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
        //public void btnRecommand_OnClick(object sender, EventArgs e)
        //{
        //    int i = 0;
        //    foreach (DataGridItem dgi in this.dg.Items)
        //    {
        //        CheckBox IsSelect = dgi.FindControl("IsSelect") as CheckBox;
        //        if (IsSelect.Checked == true)
        //        {
        //            i++;

        //            int hairStyleID = int.Parse(this.dg.DataKeys[dgi.ItemIndex].ToString());
        //            string hairStyleRecommandInfo = ConfigurationManager.AppSettings["HairStyleRecommandInfo"].ToString();
        //            string hairStyleRecommandEx = string.Empty;
        //            if (!InfoAdmin.RecommandHairStyle(hairStyleID, 0, hairStyleRecommandInfo, hairStyleRecommandEx, UserAction.Create))
        //            {
        //                StringHelper.AlertInfo("推荐失败", this.Page);
        //            }
        //        }
        //    }
        //    if (i == 0)
        //    {
        //        StringHelper.AlertInfo("请选择要推荐的项", this.Page);
        //    }
        //    else
        //    {
        //        this.Response.Redirect("HairStyleAdmin.aspx");
        //    }
        //}
        public void btnAdd_OnClick(object sender, EventArgs e)
        {
            //添加操作，转向添加页面
            this.Response.Redirect("EngineerOpusInfo.aspx");
        }

        public void databind()
        {
            List<HairStyleEntity> list = new List<HairStyleEntity>();
            DataTable table = null;

            //if (Session["query"] == null || Session["query"].ToString() == string.Empty)
            //{
            //    //根据排序绑定,均是倒序
            //    switch (this.ddlOrderWay.SelectedValue)
            //    {
            //        case "1":
            //            //发布时间，即ID
            //            //list = InfoAdmin.GetHairStyles(0, OrderKey.ID);
            //            table = InfoAdmin.GetHairStyleList(0, OrderKey.ID);
            //            break;
            //        case "2":
            //            //点击数
            //            //list = InfoAdmin.GetHairStyles(0, OrderKey.HitNum);
            //            table = InfoAdmin.GetHairStyleList(0, OrderKey.HitNum);
            //            break;
 
            //    }
            //}
            //else
            //{

              //table = InfoAdmin.GetHairStyleList();
                       

                 
             //}
            List<HairStyleEntity> hl = InfoAdmin.GetHairStyleList();
            try
            {
                int hairEngineerID = int.Parse(this.Request.QueryString["eid"].ToString());
                hl = ProviderFactory.GetHairEngineerDataProviderInstance().GetHairStyleListByHairEngineerID(hairEngineerID);
                this.dg.PageSize = 1000;
            }
            catch
            {
                hl = InfoAdmin.GetHairStyleList();
                this.dg.PageSize = 30;
            }
            
            this.dg.DataKeyField = "ID";
            dg.DataSource = hl;
            //this.dg.DataSource = list;
            this.dg.DataBind();
            //绑定页码
            SetupPage();
            this.Page_nPage.Text = Convert.ToString(this.dg.CurrentPageIndex + 1);
            this.Page_nRecCount.Text = this.dg.PageCount.ToString();
            this.Page_nRecCount_1.Text = hl.Count.ToString();
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
                //if (e.CommandName == "recommand")
                //{
                //    int hairStyleID = int.Parse(this.dg.DataKeys[e.Item.ItemIndex].ToString());

                //    string redirectUrl = "HairStyleRecommandUpdate.aspx?hairStyleID=" + hairStyleID.ToString() + "&hairStyleRecommandID=0&operateType=" + Convert.ToInt32(UserAction.Create).ToString();

                //    this.Response.Redirect(redirectUrl);
                //}
                if (e.CommandName == "delete")
                {
                    int hairStyleID = int.Parse(this.dg.DataKeys[e.Item.ItemIndex].ToString());

                    this.deleteHairStyle(hairStyleID);
                    if (InfoAdmin.DeleteHairStyle(hairStyleID))
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "delete from picturestoreset where picturestoreid=" + hairStyleID.ToString();
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

                        StringHelper.AlertInfo("删除成功", this.Page);
                        this.Response.Redirect("HairStyleAdmin.aspx");
                    }
                    else
                    {
                        StringHelper.AlertInfo("删除失败", this.Page);
                    }
                }
            }
        }
        public void deleteHairStyle(int id)
        {
            //先删除PICTURESTORESET所对应的ID
            
            string idsString = "";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "select * from HairStyle where ID=" + id.ToString();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            idsString = sdr["PSGIDS"].ToString();
                        }
                    }
                }
            }
            string[] ids = idsString.Split(",".ToCharArray());

            for (int i = 0; i < ids.Length; i++)
            {
                string iids = "";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from picturestoregroup where picturestoregroupid=" + ids[i].ToString();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                iids = sdr["picturestoreids"].ToString();
                            }
                        }
                    }
                }
                string[] iiids = iids.Split(",".ToCharArray());
                string psids = "";
                for (int k = 1; k < iiids.Length; k++)
                {
                    if (iiids[k] != id.ToString())
                    {
                        psids += "," + iiids[k];
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "update picturestoregroup set picturestoreids = '" + psids + "' where picturestoregroupid=" + ids[i].ToString();
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
            }
        }
        public void dg_OnItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                e.Item.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#ffffff';");
                e.Item.Attributes.Add("onmouseout", "this.style.backgroundColor=c;");

                // Image pic = e.Item.FindControl("Image1") as Image;
                // DataRowView row = e.Item.DataItem as DataRowView;
                // pic.ImageUrl = @"D:\SourceCode\Web\uploadfiles\logo\2008\10\3\images\2008103353363175164.bmp";
            }
            //if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            //{
            //    e.Item.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#ffffff';");
            //    e.Item.Attributes.Add("onmouseout", "this.style.backgroundColor=c;");
            //    e.Item.Cells[11].Attributes.Add("onclick", "return confirm('确定推荐么?');");
            //    e.Item.Cells[12].Attributes.Add("onclick", "return confirm('确定删除么?');");

               // HairStyleEntity hairStyle = e.Item.DataItem as HairStyleEntity;
               //// Label lblRecommandRate = e.Item.FindControl("lblRecommandRate") as Label;
               // //Label lblCommentTotal = e.Item.FindControl("lblCommentTotal") as Label;
               // Label lblCommentRate = e.Item.FindControl("lblCommentRate") as Label;

               // //推荐指数（访问数+好评评论数+我要推荐数）
               //// int recommandRate = hairStyle.HairStyleVisitNum + hairStyle.HairStyleGood + hairStyle.HairStyleRecommandNum;

               //// lblRecommandRate.Text = recommandRate.ToString();
               // //评论数（好评+坏评数）
               // int commentTotal = 0;
               // if(hairStyle != null)
               //     commentTotal = hairStyle.Good + hairStyle.Bad + hairStyle.Normal;

                
               // //好评率（好评数/评论数）
               // double commentRate = 0.0;
               // if (commentTotal == 0)
               // {
               //     commentRate = 0;
               // }
               // else
               // {
               //     commentRate = Convert.ToDouble(hairStyle.Good) / Convert.ToDouble(commentTotal);
               // }
               // lblCommentRate.Text = commentRate.ToString();
           
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
