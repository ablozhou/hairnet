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
using HairNet.Utilities;
using HairNet.Entry;
using System.Collections.Generic;
using HairNet.Business;
using System.IO;
using HairNet.Components.Utilities;
using System.Data.SqlClient;
using HairNet.Provider;

namespace Web.Admin
{
    public partial class PictureStoreAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["num"] = 0;
            }
        }
        public void ddlPictureStoreParentGroup_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlPictureStoreGroup.Items.Clear();
            List<PictureStoreGroup> list = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupsByParentID(int.Parse(this.ddlPictureStoreParentGroup.SelectedItem.Value), 0);
            ListItem li = new ListItem();
            li.Value = "0";
            li.Text = "请选择小类";
            this.ddlPictureStoreGroup.Items.Add(li);
            for (int i = 0; i < list.Count; i++)
            {
                ListItem lli = new ListItem();
                lli.Value = list[i].ID.ToString();
                lli.Text = list[i].Name.ToString();
                this.ddlPictureStoreGroup.Items.Add(lli);
            }
        }

        protected void btnSubmit_OnClick(object sender,EventArgs e)
        {
            PictureStore ps = new PictureStore();
            ps.PictureStoreName = txtPictureStoreName.Text.Trim();
            ps.PictureStoreGroupIDs = ddlPictureStoreGroup.SelectedItem.Value;
            ps.PictureStoreDescription = txtPictureStoreDescription.Text.Trim();
            ps.PictureStoreTagIDs = InfoAdmin.GetPictureStoreTagIDs(txtPictureStoreTag.Text.Trim());
            ps.PictureStoreHits = 0;
            ps.PictureStoreCreateTime = DateTime.Now;
            ps.PictureStoreRawUrl = "";
            ps.PictureStoreLittleUrl = "";

            ps.PictureStoreID = InfoAdmin.AddPictureStore(ps);

            string[] ppicString = this.pic.Text.Split(";".ToCharArray());
            if (ppicString[0] != string.Empty)
            {
                foreach (string pps in ppicString)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL,IsHairStyle,HairStylePos) values(" + ps.PictureStoreID.ToString() + ",'" + pps + "',0,0)";
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
                }
            }

            foreach (string tagid in ps.PictureStoreTagIDs.Split(','))
            {
                InfoAdmin.SetPictureStoreTag(ps.PictureStoreID, int.Parse(tagid));
            }
            this.Response.Redirect("PictureStoreAdmin.aspx");
        }
        protected void btnPicUpload1_OnClick(object sender, EventArgs e)
        {
            
            UpLoadClass upload = new UpLoadClass();
            string filepath = upload.UpLoadImg(uploadpic1, "/uploadfiles/pictures/");
            if (filepath != string.Empty)
            {
                int num = Convert.ToInt32(ViewState["num"].ToString());
                num++;
                ViewState["num"] = num;
                if (num == 1)
                {
                    this.picString.Text = "<img width=200 heigth=100 src='" + filepath + "' />";
                    this.pic.Text = filepath;
                }
                else
                {
                    this.picString.Text += "&nbsp;&nbsp;<img width=200 heigth=100 src='" + filepath + "' />";
                    this.pic.Text += ";" + filepath;
                }
            }
        }
    }
}
