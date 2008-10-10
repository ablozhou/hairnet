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


namespace Web.Admin
{
    public partial class PictureStoreGroupClassAdmin : System.Web.UI.Page
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

        public void btnDelete_OnClick(object sender, EventArgs e)
        {
            foreach (DataGridItem dgi in this.dg.Items)
            {
                CheckBox chkIsSend = dgi.FindControl("chkIsSend") as CheckBox;
                if (chkIsSend.Checked)
                {
                    string hstyleid = this.dg.DataKeys[dgi.ItemIndex].ToString();
                    PictureStoreGroup psg = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupByPictureStoreGroupID(int.Parse(this.Request.QueryString["id"].ToString()));

                    string ids = psg.PictureStoreIDs;
                    
                    string[] iids = ids.Split(",".ToCharArray());
                    ids = string.Empty;
                    for (int i = 1; i < iids.Length; i++)
                    {
                        if (iids[i] != hstyleid)
                        {
                            ids += "," + iids[i];
                        }
                    }
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "update picturestoregroup set picturestoreids = '" + ids + "' where picturestoregroupid=" + psg.ID.ToString();
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
            this.databind();
        }

        public void btnSelect_OnClick(object sender, EventArgs e)
        {
            foreach (DataGridItem dgi in this.dg.Items)
            {
                CheckBox IsSelect = dgi.FindControl("IsSelect") as CheckBox;
                if (this.btnSelect.Text == "ȫѡ")
                {
                    IsSelect.Checked = true;
                }
                else
                {
                    IsSelect.Checked = false;
                }
            }
            if (this.btnSelect.Text == "ȫѡ")
            {
                this.btnSelect.Text = "ȫ��ѡ";
            }
            else
            {
                this.btnSelect.Text = "ȫѡ";
            }
        }

        public void databind()
        {
            PictureStoreGroup psg = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupByPictureStoreGroupID(int.Parse(this.Request.QueryString["id"].ToString()));

            DataTable dt = new DataTable("dt");
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("hairname", typeof(string));
            dt.Columns.Add("picturestoreid", typeof(string));

            string[] psgc = psg.PictureStoreIDs.Split(",".ToCharArray());
            for(int i=1;i<psgc.Length;i++)
            {
                string id = psgc[i];
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "select * from hairstyle where id="+id;
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                DataRow dr = dt.NewRow();
                                dr["id"] = sdr["id"].ToString();
                                dr["hairname"] = sdr["hairname"].ToString();
                                dr["picturestoreid"] = sdr["picturestoreid"].ToString();

                                dt.Rows.Add(dr);
                            }
                        }
                    }
                }
            }

            this.dg.DataKeyField = "id";
            dg.DataSource = dt.DefaultView;
            this.dg.DataBind();
            //��ҳ��
            SetupPage();
            this.Page_nPage.Text = Convert.ToString(this.dg.CurrentPageIndex + 1);
            this.Page_nRecCount.Text = this.dg.PageCount.ToString();
            this.Page_nRecCount_1.Text = dt.Rows.Count.ToString();
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
                    string hstyleid = this.dg.DataKeys[e.Item.ItemIndex].ToString();
                    PictureStoreGroup psg = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupByPictureStoreGroupID(int.Parse(this.Request.QueryString["id"].ToString()));

                    string ids = psg.PictureStoreIDs;

                    string[] iids = ids.Split(",".ToCharArray());
                    ids = string.Empty;
                    for (int i = 1; i < iids.Length; i++)
                    {
                        if (iids[i] != hstyleid)
                        {
                            ids += "," + iids[i];
                        }
                    }
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "update picturestoregroup set picturestoreids = '" + ids + "' where picturestoregroupid=" + psg.ID.ToString();
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
                    this.databind();
                }
            }
        }
        public void dg_OnItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                e.Item.Attributes.Add("onmouseover", "c=this.style.backgroundColor;this.style.backgroundColor='#ffffff';");
                e.Item.Attributes.Add("onmouseout", "this.style.backgroundColor=c;");

                e.Item.Cells[4].Attributes.Add("onclick", "return confirm('ȷ��ɾ��ô?');");

                Label lblEdit = e.Item.FindControl("lblEdit") as Label;
                Label lblAdmin = e.Item.FindControl("lblAdmin") as Label;
                DataRowView drv = e.Item.DataItem as DataRowView;
                if (drv["picturestoreid"].ToString() == "0")
                {
                    lblAdmin.Text = "����";
                    lblEdit.Text = "<a href='HairStyleEdit.aspx?id=" +drv["id"].ToString() +"' target='_self'>�༭</a>";
                }
                else
                {
                    lblAdmin.Text = "ͼƬ";
                    lblEdit.Text = "<a href='PictureStoreEdit.aspx?id=" + drv["picturestoreid"].ToString() + "' target='_self'>�༭</a>";
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
                case "First": //�������ҳ
                    {
                        nPage = 0;
                        break;
                    }
                case "Prev": //��һҳ
                    {
                        nPage = nPage - 1;
                        break;
                    }
                case "Next":  //��һҳ
                    {
                        nPage = nPage + 1;
                        break;
                    }
                case "Last": //βҳ
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
        //���÷�ҳ�б��
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
