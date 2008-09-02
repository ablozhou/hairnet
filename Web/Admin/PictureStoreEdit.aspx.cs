using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using HairNet.Business;
using HairNet.Entry;
using System.Collections.Generic;
using System.IO;
using HairNet.Components.Utilities;
using HairNet.Utilities;

namespace Web.Admin
{
    public partial class PictureStoreEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindPicGroup();
                this.SetInfo();
            }
        }

        private void bindPicGroup()
        {
            ddlPictureStoreGroup.DataSource = InfoAdmin.GetPictureStoreGroups(0);
            ddlPictureStoreGroup.DataTextField = "Name";
            ddlPictureStoreGroup.DataValueField = "ID";
            ddlPictureStoreGroup.DataBind();
        }

        private void SetInfo()
        {
            string id = Request["id"];
            PictureStore ps = InfoAdmin.GetPictureStoreByPictureStoreID(int.Parse(id));

            txtPictureStoreName.Text = ps.PictureStoreName;
            txtPictureStoreDescription.Text = ps.PictureStoreDescription;
            txtPictureStoreTag.Text = InfoAdmin.GetPictureStoreTagNames(ps.PictureStoreTagIDs);

            ddlPictureStoreGroup.SelectedValue = ps.PictureStoreGroupIDs;
            ViewState["PictureStoreInfo"] = ps;
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            PictureStore ps = (PictureStore)ViewState["PictureStoreInfo"];
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
            InfoAdmin.UpdatePictureStore(ps);

            foreach (string tagid in ps.PictureStoreTagIDs.Split(','))
            {
                InfoAdmin.SetPictureStoreTag(ps.PictureStoreID, int.Parse(tagid));
            }
            this.Response.Redirect("PictureStoreAdmin.aspx");
        }
    }
}
