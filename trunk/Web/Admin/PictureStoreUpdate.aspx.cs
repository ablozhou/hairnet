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
using HairNet.Entry;
using HairNet.Business;
using HairNet.Utilities;
using HairNet.Enumerations;

namespace Web.Admin
{
    public partial class PictureStoreUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string operateType = this.Request.QueryString["operateType"].ToString();

                if (operateType == "1")
                {
                    string pictureStoreRecommandInfo = ConfigurationManager.AppSettings["PictureStoreRecommandInfo"].ToString();

                    this.content.Value = pictureStoreRecommandInfo;
                }
                else
                {
                    int pictureStoreRecommandID = int.Parse(this.Request.QueryString["pictureStoreRecommandID"].ToString());
                    PictureStoreRecommand pse = InfoAdmin.GetPictureStoreRecommand(pictureStoreRecommandID);

                    this.content.Value = pse.PictureStoreRecommandInfo.ToString();
                }
            }
        }
        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            string operateType = this.Request.QueryString["operateType"].ToString();
            if (operateType == "1")
            {
                int pictureStoreID = int.Parse(this.Request.QueryString["pictureStoreID"].ToString());
                string pictureStoreRecommandInfo = this.content.Value;
                string pictureStoreRecommandEx = this.txtRecommandEx.Text.Trim();
                if (InfoAdmin.RecommandPictureStore(pictureStoreID, 0, pictureStoreRecommandInfo, pictureStoreRecommandEx, UserAction.Create))
                {
                    StringHelper.AlertInfo("推荐成功", this.Page);
                    this.Response.Redirect("PictureStoreAdmin.aspx");
                }
                else
                {
                    StringHelper.AlertInfo("推荐失败", this.Page);
                }
            }
            else
            {
                int pictureStoreID = int.Parse(this.Request.QueryString["pictureStoreID"].ToString());
                int pictureStoreRecommandID = int.Parse(this.Request.QueryString["pictureStoreRecommandID"].ToString());

                string pictureStoreRecommandInfo = this.content.Value;
                string pictureStoreRecommandEx = this.txtRecommandEx.Text.Trim();
                if (InfoAdmin.RecommandPictureStore(pictureStoreID, pictureStoreRecommandID, pictureStoreRecommandInfo, pictureStoreRecommandEx, UserAction.Update))
                {
                    StringHelper.AlertInfo("更新成功", this.Page);
                    this.Response.Redirect("PictureStoreRecommandAdmin.aspx");
                }
                else
                {
                    StringHelper.AlertInfo("更新失败", this.Page);
                }
            }
        }
    }
}
