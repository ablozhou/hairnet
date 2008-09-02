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
using HairNet.Utilities;
using HairNet.Entry;
using System.Collections.Generic;
using HairNet.Business;
using System.IO;
using HairNet.Components.Utilities;

namespace Web.Admin
{
    public partial class PictureStoreAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindPicGroup();
            }
        }

        private void bindPicGroup()
        {
            ddlPictureStoreGroup.DataSource = InfoAdmin.GetPictureStoreGroups(0);
            ddlPictureStoreGroup.DataTextField = "Name";
            ddlPictureStoreGroup.DataValueField = "ID";
            ddlPictureStoreGroup.DataBind();
        }

        protected void btnSubmit_OnClick(object sender,EventArgs e)
        {
            PictureStore ps = new PictureStore();
            ps.PictureStoreName = txtPictureStoreName.Text.Trim();
            ps.PictureStoreGroupIDs = ddlPictureStoreGroup.SelectedValue;
            ps.PictureStoreDescription = txtPictureStoreDescription.Text.Trim();
            ps.PictureStoreTagIDs = InfoAdmin.GetPictureStoreTagIDs(txtPictureStoreTag.Text.Trim());
            ps.PictureStoreHits = 0;
            ps.PictureStoreCreateTime = DateTime.Now;

            if (uploadpic.Value != "")
            {
                UpLoadClass upload = new UpLoadClass();
                string filepath = upload.UpLoadImg(uploadpic, "/uploadfiles/pictures/");
                upload = null;
                //处理图片
                PicOperate po = new PicOperate();
                string newfilepath = filepath.Substring(0, filepath.LastIndexOf(".")) + "_new" + Path.GetExtension(filepath);
                po.AddWaterMarkOperate(Server.MapPath(filepath), Server.MapPath(WaterSettings.WaterMarkPath), Server.MapPath(newfilepath), WaterSettings.CopyrightText);
                ps.PictureStoreRawUrl = newfilepath;
                ps.PictureStoreLittleUrl = po.CreateMicroPic(newfilepath, "", WaterSettings.PictureScaleSize[0], WaterSettings.PictureScaleSize[1]);
                po = null;
            }
            ps.PictureStoreID = InfoAdmin.AddPictureStore(ps);
            foreach (string tagid in ps.PictureStoreTagIDs.Split(','))
            {
                InfoAdmin.SetPictureStoreTag(ps.PictureStoreID, int.Parse(tagid));
            }
            this.Response.Redirect("PictureStoreAdmin.aspx");
        }
    }
}
