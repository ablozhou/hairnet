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
using HairNet.Provider;
using HairNet.Enumerations;
using HairNet.Entry;
using HairNet.Utilities;

namespace Web.Admin
{
    public partial class PictureStoreGroupEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string id = this.Request.QueryString["id"].ToString();
                string pid = this.Request.QueryString["pid"].ToString();

                switch (id)
                {
                    case "1":
                        this.lblGroupName.Text = "街拍";
                        break;
                    case "2":
                        this.lblGroupName.Text = "明星";
                        break;
                    case "3":
                        this.lblGroupName.Text = "发型";
                        break;
                }
                PictureStoreGroup psg = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupByPictureStoreGroupID(int.Parse(pid));
                this.txtLittleGroupname.Text = psg.Name;
            }
        }
        public void btnSubmit_OnClick(object sender, EventArgs e)
        {
            if (this.txtLittleGroupname.Text.Trim() == string.Empty)
            {
                this.lblInfo.Text = "请输入分类名称！";
                return;
            }

            string id = this.Request.QueryString["id"].ToString();
            string pid = this.Request.QueryString["pid"].ToString();

            PictureStoreGroup psg = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupByPictureStoreGroupID(int.Parse(pid));
            psg.Name = this.txtLittleGroupname.Text.Trim();
            psg.PictureStoreGroupParentID = int.Parse(id);
            psg.ID = int.Parse(pid);

            if (ProviderFactory.GetPictureStoreDataProviderInstance().PictureStoreGroupCreateDeleteUpdate(psg, UserAction.Update))
            {
                StringHelper.AlertInfo("更新成功", this.Page);
                this.Response.Redirect("PictureStoreGroupAdmin.aspx?id="+id);
            }
            else
            {
                StringHelper.AlertInfo("更新失败", this.Page);
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            string id = this.Request.QueryString["id"].ToString();
            Response.Redirect("PictureStoreGroupAdmin.aspx?id=" + id, true);

        }
    }
}
