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
using System.Collections.Generic;
using HairNet.Entry;
using HairNet.Business;
using HairNet.Utilities;
using HairNet.Components.Utilities;
using System.IO;

namespace Web.Admin
{
    public partial class HairShopEdit3 : System.Web.UI.Page
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
                HairShop hs = (HairShop)Session["HairShopInfo"];
                string[] ids = hs.HairShopPictureStoreIDs.Split(',');
                foreach (string pid in ids)
                {
                    list.Add(InfoAdmin.GetPictureStoreByPictureStoreID(int.Parse(pid)));
                }
                ViewState["PicList"] = list;
                gvPicList.DataSource = list;
                gvPicList.DataBind();
            }
            else
            {
                List<PictureStore> list = (List<PictureStore>)ViewState["PicList"];
                gvPicList.DataSource = list;
                gvPicList.DataBind();
            }
        }

        private void bindPicGroup()
        {
            ddlPicGroup.DataSource = InfoAdmin.GetPictureStoreGroups(0);
            ddlPicGroup.DataTextField = "Name";
            ddlPicGroup.DataValueField = "ID";
            ddlPicGroup.DataBind();
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
            ps.PictureStoreLittleUrl = po.CreateMicroPic(newfilepath, "", WaterSettings.PictureScaleSize[0], WaterSettings.PictureScaleSize[1]);
            po = null;

            //更新图片标签
            ps.PictureStoreID = InfoAdmin.AddPictureStore(ps);
            foreach (string tagid in ps.PictureStoreTagIDs.Split(','))
            {
                InfoAdmin.SetPictureStoreTag(ps.PictureStoreID, int.Parse(tagid));
            }


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
        }

        protected void gvPicList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            PictureStore ps = ((List<PictureStore>)ViewState["PicList"])[e.RowIndex];
            InfoAdmin.DeletePictureStore(ps.PictureStoreID);
            ((List<PictureStore>)ViewState["PicList"]).RemoveAt(e.RowIndex);
            this.bindPicList();
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            HairShop hs = (HairShop)Session["HairShopInfo"];
            //获取图片ID集合
            List<string> tmpid1 = new List<string>();
            List<PictureStore> list = (List<PictureStore>)ViewState["PicList"];
            foreach (PictureStore ps in list)
            {
                tmpid1.Add(ps.PictureStoreID.ToString());
            }
            hs.HairShopPictureStoreIDs = string.Join(",", tmpid1.ToArray());

            //更新美发厅
            InfoAdmin.UpdateHairShop(hs);


            //在图片中对应新添加的美发厅ID
            foreach (string id in hs.HairShopPictureStoreIDs.Split(','))
            {
                InfoAdmin.SetPictureStoreByHairShop(hs.HairShopID, int.Parse(id));
            }

            //在标签中对应新添加的美发厅ID
            foreach (string tagid in hs.HairShopTagIDs.Split(','))
            {
                InfoAdmin.SetHairShopTag(hs.HairShopID, int.Parse(tagid));
            }

            this.Response.Redirect("HairShopAdmin.aspx");
        }


    }
}
