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
using HairNet.Business;
using HairNet.Entry;
using System.Collections.Generic;
using HairNet.Utilities;
using HairNet.Components.Utilities;
using System.IO;

namespace Web.Admin
{
    public partial class HairShopAdd3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindPicGroup();
                this.bindPicList();
            }
        }

        private void bindPicList()
        {
            if (ViewState["PicList"] == null)
            {
                List<PictureStore> list = new List<PictureStore>();
                ViewState["PicList"] = list;
            }
        }

        private void bindPicGroup()
        {
            ddlPicGroup.DataSource = InfoAdmin.GetPictureStoreGroups(0);
            ddlPicGroup.DataTextField = "Name";
            ddlPicGroup.DataValueField = "ID";
            ddlPicGroup.DataBind();
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            this.Response.Redirect("HairShopAdmin.aspx");
        }

        protected void btnAddPic_Click(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            string filepath = upload.UpLoadImg(uploadpic, "/uploadfiles/pictures/");
            upload = null;

            List<PictureStore> list = (List<PictureStore>)ViewState["PicList"];
            PictureStore ps = new PictureStore();
            ps.PictureStoreName = txtPictureStoreName.Text.Trim();
            ps.PictureStoreGroupIDs = ddlPicGroup.SelectedValue;
            ps.PictureStoreDescription = txtPictureStoreDescriptioin.Text.Trim();
            ps.PictureStoreTagIDs = InfoAdmin.GetPictureStoreTagIDs(txtPictureStoreTag.Text.Trim());
            ps.PictureStoreHits = 0;
            ps.PictureStoreCreateTime = DateTime.Now;

            //处理图片
            PicOperate po = new PicOperate();
            string newfilepath = filepath.Substring(0, filepath.LastIndexOf(".")) + "_new" + Path.GetExtension(filepath);
            po.AddWaterMarkOperate(Server.MapPath(filepath), Server.MapPath(WaterSettings.WaterMarkPath), Server.MapPath(newfilepath), WaterSettings.CopyrightText);
            ps.PictureStoreRawUrl = newfilepath;
            ps.PictureStoreLittleUrl = po.CreateMicroPic(filepath, "", WaterSettings.PictureScaleSize[0], WaterSettings.PictureScaleSize[1]);
            po = null;

            ps.PictureStoreID = InfoAdmin.AddPictureStore(ps);

            list.Add(ps);
            ViewState["PicList"] = list;

            this.bindPicList();
            this.clearText();
        }

        void clearText()
        {
            txtPictureStoreDescriptioin.Text = "";
            txtPictureStoreName.Text = "";
            txtPictureStoreTag.Text = "";
            uploadpic.Value = "";
        }

        protected void gvPicList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            PictureStore ps = ((List<PictureStore>)ViewState["PicList"])[e.RowIndex];
            InfoAdmin.DeletePictureStore(ps.PictureStoreID);
            ((List<PictureStore>)ViewState["PicList"]).RemoveAt(e.RowIndex);
            this.bindPicList();
        }
    }
}
