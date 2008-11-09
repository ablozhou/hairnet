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
using HairNet.Entry;
using HairNet.Provider;
using System.Collections.Generic;
using HairNet.Enumerations;
using HairNet.Utilities;
using HairNet.DBUtility;

namespace Web.Admin
{
    public partial class PictureStoreGroupClassAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.databind();
            }
        }
        public void ddlQuery_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.databind();
        }
        public void btnAdd_OnClick(object sender, EventArgs e)
        {
            foreach (DataGridItem dgi in this.dg.Items)
            {
                CheckBox chkIsSend = dgi.FindControl("IsSelect") as CheckBox;
                if (chkIsSend.Checked)
                {
                    string hstyleid = this.dg.DataKeys[dgi.ItemIndex].ToString();
                    string id = this.Request.QueryString["id"].ToString();

                    if (this.isExistCurrentID(hstyleid, id))
                    {
                        //this.Response.Write("<script>alert('信息ID"+hstyleid.ToString()+"已经存在');</script>");
                        continue;
                    }

                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "update PictureStoreGroup set PictureStoreIDs = PictureStoreIDs+'," + hstyleid + "' where PictureStoreGroupID=" + id;
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
                            conn.Open();

                            try
                            {
                                comm.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            { }
                        }
                    }

                    string psgids = "";
                    bool isHairStyle = false;
                    string pictureStoreId = "";
                    //处理hairstyle逻辑
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "select * from HairStyle where id=" + hstyleid;
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
                            conn.Open();

                            using (SqlDataReader sdr = comm.ExecuteReader())
                            {
                                if (sdr.Read())
                                {
                                    psgids = sdr["psgids"].ToString();
                                    isHairStyle = Convert.ToBoolean(sdr["IsHairStyle"].ToString());
                                    pictureStoreId = sdr["pictureStoreID"].ToString();
                                }
                            }
                        }
                    }
                    string[] psgCollection = psgids.Split(",".ToCharArray());

                    if (psgCollection[0] == "")
                    {
                        psgids = id.ToString();
                    }
                    else {
                        psgids += "," + id.ToString();
                    }
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "update hairStyle set psgids = '" + psgids + "' where id=" + hstyleid;
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
                            conn.Open();

                            try
                            {
                                comm.ExecuteNonQuery();
                            }
                            catch
                            { }
                        }
                    }

                    if (isHairStyle == false)
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                        {
                            string commString = "update PictureStore set PictureStoreGroupIDs = '" + psgids + "' where PictureStoreID=" + pictureStoreId;
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.Connection = conn;
                                comm.CommandText = commString;
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
            this.Response.Write("<script>alert('信息添加操作完成！');</script><script>window.location.href='" + this.Request.Url.ToString() + "'</script>");
            //this.databind();
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

        public void databind()
        {
            List<HairStyleEntity> valueList = new List<HairStyleEntity>();
            using (SqlDataReader Reader = SqlHelper.ExecuteReader(DataHelper2.SqlConnectionString, CommandType.StoredProcedure,
           "QueryHairStyle1", null))
            {
                while (Reader.Read())
                    valueList.Add(new HairStyleEntity(Reader.GetInt32(0), Reader.GetString(1), Reader.GetByte(2), Reader.GetByte(3),
                        Reader.GetByte(4), Reader.GetByte(5), Reader.GetByte(6), /*Reader.GetString(7), Reader.GetString(8), Reader.GetString(9),
                        Reader.GetString(10), Reader.GetString(11), Reader.GetString(12), Reader.GetString(13),*/ Reader.GetInt32(7),
                        Reader.GetInt32(8), Reader.GetByte(9), Reader.GetByte(10), Reader.GetByte(11), Reader.GetDateTime(12),
                        Reader.GetString(13), Reader.GetInt32(14), Reader.GetInt32(15), Reader.GetInt32(16), Reader.GetString(17)));
            }

            this.dg.DataKeyField = "id";
            dg.DataSource = valueList;
            this.dg.DataBind();
            //绑定页码
            SetupPage();
            this.Page_nPage.Text = Convert.ToString(this.dg.CurrentPageIndex + 1);
            this.Page_nRecCount.Text = this.dg.PageCount.ToString();
            this.Page_nRecCount_1.Text = valueList.Count.ToString();
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

        public bool isExistCurrentID(string hstyleid, string id)
        {
            string psids = string.Empty;
            bool result = false;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select * from PictureStoreGroup where PictureStoreGroupID=" + id;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            psids = sdr["PictureStoreIDs"].ToString();
                        }
                    }
                }
            }

            string[] s = psids.Split(",".ToCharArray());
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == hstyleid)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void dg_OnItemCommand(object sender, DataGridCommandEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                if (e.CommandName == "add")
                {
                    string hstyleid = this.dg.DataKeys[e.Item.ItemIndex].ToString();
                    string id = this.Request.QueryString["id"].ToString();

                    if (this.isExistCurrentID(hstyleid, id))
                    {
                        this.Response.Write("<script>alert('当前信息已经添加');</script><script>window.location.href='"+this.Request.Url.ToString()+"'</script>");
                        return;
                    }

                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "update PictureStoreGroup set PictureStoreIDs = PictureStoreIDs+'," + hstyleid + "' where PictureStoreGroupID=" + id;
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
                            conn.Open();

                            try
                            {
                                comm.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            { }
                        }
                    }

                    string psgids = "";
                    bool isHairStyle = false;
                    string pictureStoreId = "";
                    //处理hairstyle逻辑
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "select * from HairStyle where id=" + hstyleid;
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
                            conn.Open();

                            using (SqlDataReader sdr = comm.ExecuteReader())
                            {
                                if (sdr.Read())
                                {
                                    psgids = sdr["psgids"].ToString();
                                    isHairStyle = Convert.ToBoolean(sdr["IsHairStyle"].ToString());
                                    pictureStoreId = sdr["pictureStoreID"].ToString();
                                }
                            }
                        }
                    }
                    string[] psgCollection = psgids.Split(",".ToCharArray());

                    if (psgCollection[0] == "")
                    {
                        psgids = id.ToString();
                    }
                    else
                    {
                        psgids += "," + id.ToString();
                    }
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "update hairStyle set psgids = '" + psgids + "' where id=" + hstyleid;
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
                            conn.Open();

                            try
                            {
                                comm.ExecuteNonQuery();
                            }
                            catch
                            { }
                        }
                    }

                    if (isHairStyle == false)
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                        {
                            string commString = "update PictureStore set PictureStoreGroupIDs = '" + psgids + "' where PictureStoreID=" + pictureStoreId;
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.Connection = conn;
                                comm.CommandText = commString;
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
                    this.Response.Write("<script>alert('信息添加操作完成！');</script><script>window.location.href='" + this.Request.Url.ToString() + "'</script>");
                    //this.databind();
                }
            }
        }
        public void dg_OnItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                e.Item.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#ffffff';");
                e.Item.Attributes.Add("onmouseout", "this.style.backgroundColor=c;");

                e.Item.Cells[5].Attributes.Add("onclick", "return confirm('确定添加么?');");

                Label lblEdit = e.Item.FindControl("lblEdit") as Label;
                Label lblAdmin = e.Item.FindControl("lblAdmin") as Label;
                HairStyleEntity hse = e.Item.DataItem as HairStyleEntity;

                if (hse.PictureStoreId.ToString() == "0")
                {
                    lblAdmin.Text = "发型";
                }
                else
                {
                    lblAdmin.Text = "图片";
                }
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
