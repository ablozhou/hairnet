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
using HairNet.Provider;
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class HairEngineerAdmin : System.Web.UI.Page
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
        public void btnRecommand_OnClick(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridItem dgi in this.dg.Items)
            {
                CheckBox IsSelect = dgi.FindControl("IsSelect") as CheckBox;
                if (IsSelect.Checked == true)
                {
                    i++;

                    int hairEngineerID = int.Parse(this.dg.DataKeys[dgi.ItemIndex].ToString());

                    string hairEngineerRecommandInfo = ConfigurationManager.AppSettings["HairEngineerRecommandInfo"].ToString();
                    string hairEngineerRecommandEx = string.Empty;
                    if (!InfoAdmin.RecommandHairEngineer(hairEngineerID, 0, hairEngineerRecommandInfo, hairEngineerRecommandEx, UserAction.Create))
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
                this.Response.Redirect("HairEngineerAdmin.aspx");
            }
        }
        public void btnAdd_OnClick(object sender, EventArgs e)
        {
            //添加操作，转向添加页面
            this.Response.Redirect("HairEngineerAdd.aspx");
        }
        public void databind()
        {
            List<HairEngineer> list = new List<HairEngineer>();

            if (Session["query"] == null || Session["query"].ToString() == string.Empty)
            {
                //根据排序绑定,均是倒序
                switch (this.ddlOrderWay.SelectedValue)
                {
                    case "1":
                        //发布时间，即ID
                        list = InfoAdmin.GetHairEngineers(0, OrderKey.ID);
                        break;
                    case "2":
                        //点击数
                        list = InfoAdmin.GetHairEngineers(0, OrderKey.HitNum);
                        break;
                    case "3":
                        //评论数
                        list = InfoAdmin.GetHairEngineers(0, OrderKey.CommentNum);
                        break;
                    case "4":
                        //推荐数
                        list = InfoAdmin.GetHairEngineers(0, OrderKey.RecommandNum);
                        break;
                    case "5":
                        //预约数
                        list = InfoAdmin.GetHairEngineers(0, OrderKey.OrderNum);
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
                                list = InfoAdmin.GetHairEngineers(0, OrderKey.ID, Session["query"].ToString());
                                break;
                            case "2":
                                //点击数
                                list = InfoAdmin.GetHairEngineers(0, OrderKey.HitNum, Session["query"].ToString());
                                break;
                            case "3":
                                //评论数
                                list = InfoAdmin.GetHairEngineers(0, OrderKey.CommentNum, Session["query"].ToString());
                                break;
                            //case "4":
                            //    //推荐数
                            //    list = InfoAdmin.GetHairEngineers(0, OrderKey.RecommandNum, Session["query"].ToString());
                            //    break;
                            //case "5":
                            //    //预约数
                            //    list = InfoAdmin.GetHairEngineers(0, OrderKey.OrderNum, Session["query"].ToString());
                            //    break;
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

            this.dg.DataKeyField = "HairEngineerID";
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
                    int hairEngineerID = int.Parse(this.dg.DataKeys[e.Item.ItemIndex].ToString());

                    string redirectUrl = "HairEngineerRecommandUpdate.aspx?hairEngineerID="+hairEngineerID.ToString()+"&hairEngineerRecommandID=0&operateType="+Convert.ToInt32(UserAction.Create).ToString();

                    this.Response.Redirect(redirectUrl);
                }
                if (e.CommandName == "delete")
                {
                    int hairEngineerID = int.Parse(this.dg.DataKeys[e.Item.ItemIndex].ToString());

                    HairEngineer he = ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerByHairEngineerID(hairEngineerID);

                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "delete from HairEngineerRecommand where HairEngineerRawID=" + hairEngineerID.ToString();
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

                    //tag逻辑
                    //先处理TAG逻辑，先删除HS所对应的所有TAG
                    if (he.HairEngineerTagIDs != string.Empty)
                    {
                        string[] tempTagC = he.HairEngineerTagIDs.Split(",".ToCharArray());
                        if (tempTagC[0] != string.Empty)
                        {
                            for (int k = 0; k < tempTagC.Length; k++)
                            {
                                HairEngineerTag hst = new HairEngineerTag();
                                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                                {
                                    string commString = "select * from HairEngineerTag where HairEngineerTagID=" + tempTagC[k];
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
                                                    hst.TagID = int.Parse(sdr["HairEngineerTagID"].ToString());
                                                    hst.TagName = sdr["HairEngineerTagName"].ToString();
                                                    hst.HairEngineerIDs = sdr["HairEngineerIDs"].ToString();
                                                }
                                                catch
                                                { }
                                            }
                                        }
                                    }
                                }
                                string[] tempHairEngineerIDC = hst.HairEngineerIDs.Split(",".ToCharArray());
                                string hairEngineerIDs = "";

                                int tempNum = 0;
                                for (int i = 0; i < tempHairEngineerIDC.Length; i++)
                                {
                                    if (tempHairEngineerIDC[i] != he.HairEngineerID.ToString())
                                    {
                                        tempNum++;
                                        if (tempNum == 1)
                                        {
                                            hairEngineerIDs = tempHairEngineerIDC[i];
                                        }
                                        else
                                        {
                                            hairEngineerIDs += "," + tempHairEngineerIDC[i];
                                        }
                                    }
                                }
                                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                                {
                                    string commString = "update HairEngineerTag set HairEngineerIDs='" + hairEngineerIDs + "' where HairEngineerTagID=" + hst.TagID.ToString();
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
                    }
                    //


                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "update HairShop set HairShopEngineerNum = HairShopEngineerNum-1 where HairShopID=" + he.HairShopID.ToString();
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

                    if (InfoAdmin.DeleteHairEngineer(hairEngineerID))
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "select * from HairStyle where hairEngineerID=" + hairEngineerID.ToString();
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = commString;
                                comm.Connection = conn;
                                conn.Open();

                                using (SqlDataReader sdr = comm.ExecuteReader())
                                {
                                    while (sdr.Read())
                                    {
                                        string hid = sdr["ID"].ToString();

                                        this.deleteHairStyle(int.Parse(hid));

                                        using (SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                                        {
                                            string commString2 = "delete from picturestoreset where picturestoreid=" + hid;
                                            using (SqlCommand comm2 = new SqlCommand())
                                            {
                                                comm2.CommandText = commString2;
                                                comm2.Connection = conn2;
                                                conn2.Open();

                                                try
                                                {
                                                    comm2.ExecuteNonQuery();
                                                }
                                                catch
                                                {

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "delete from enginpics where ownerid=" + hairEngineerID.ToString();
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

                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "delete from HairEngineerRecommand where HairEngineerRawID=" + hairEngineerID.ToString();
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

                        StringHelper.AlertInfo("删除成功",this.Page);
                        this.Response.Redirect("HairEngineerAdmin.aspx");
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

            if (ids[0] != string.Empty)
            {
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
            using (SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString2 = "delete from hairstyle where id=" + id;
                using (SqlCommand comm2 = new SqlCommand())
                {
                    comm2.CommandText = commString2;
                    comm2.Connection = conn2;
                    conn2.Open();

                    try
                    {
                        comm2.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        throw new Exception(ex.Message);
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
                //e.Item.Cells[12].Attributes.Add("onclick", "return confirm('确定推荐么?');");
                e.Item.Cells[10].Attributes.Add("onclick", "return confirm('确定删除么?');");

                HairEngineer hairEngineer = e.Item.DataItem as HairEngineer;
                Label lblRecommandRate = e.Item.FindControl("lblRecommandRate") as Label;
                //Label lblCommentTotal = e.Item.FindControl("lblCommentTotal") as Label;
                Label lblCommentRate = e.Item.FindControl("lblCommentRate") as Label;
                Label lblAddOupsInfo = e.Item.FindControl("lblAddOupsInfo") as Label;
                Label lblWorks = e.Item.FindControl("lblWorks") as Label;
                lblAddOupsInfo.Text = "<a href='EngineerOpusInfo.aspx?ENGINEERID="+hairEngineer.HairEngineerID.ToString()+"&shopid="+hairEngineer.HairShopID.ToString()+"' target='_self'>添加作品</a>";

                lblWorks.Text = "<a href='HairStyleAdmin.aspx?eid="+hairEngineer.HairEngineerID.ToString()+"&sid="+hairEngineer.HairShopID.ToString()+"' target='_self'>编辑作品</a>";
                ////推荐指数（点击数+好评评论数+我要推荐数）?美发师的预约数不应该计算在内么?
                int recommandRate = hairEngineer.HairEngineerHits + hairEngineer.HairEngineerGood;
                lblRecommandRate.Text = recommandRate.ToString();

                ////好评率（好评数/评论数）
                double commentRate = 0.0;
                if (recommandRate == 0)
                {
                    commentRate = 0;
                }
                else
                {
                    commentRate = Convert.ToDouble(hairEngineer.HairEngineerGood) / Convert.ToDouble(recommandRate);
                }
                lblCommentRate.Text = commentRate.ToString();
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
