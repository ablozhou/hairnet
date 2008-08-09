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
using HairNet.Enumerations;
using HairNet.Utilities;

namespace Web.Admin
{
    public partial class HairEngineerRecommandUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string operateType = this.Request.QueryString["operateType"].ToString();

                if (operateType == "1")
                {
                    string hairEngineerRecommandInfo = ConfigurationManager.AppSettings["HairEngineerRecommandInfo"].ToString();

                    this.content.Value = hairEngineerRecommandInfo;
                }
                else
                {
                    int hairEngineerRecommandID = int.Parse(this.Request.QueryString["hairEngineerRecommandID"].ToString());
                    HairEngineerRecommand he = InfoAdmin.GetHairEngineerRecommand(hairEngineerRecommandID);

                    this.content.Value = he.HairEngineerRecommandInfo;
                }
            }
        }
        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            string operateType = this.Request.QueryString["operateType"].ToString();
            if (operateType == "1")
            {
                int hairEngineerID = int.Parse(this.Request.QueryString["hairEngineerID"].ToString());
                string hairEngineerRecommandInfo = this.content.Value;
                string hairEngineerRecommandEx = this.txtRecommandEx.Text.Trim();
                if (InfoAdmin.RecommandHairEngineer(hairEngineerID, 0, hairEngineerRecommandInfo, hairEngineerRecommandEx, UserAction.Create))
                {
                    StringHelper.AlertInfo("推荐成功", this.Page);
                    this.Response.Redirect("HairEngineerAdmin.aspx");
                }
                else
                {
                    StringHelper.AlertInfo("推荐失败", this.Page);
                }
            }
            else
            {
                int hairEngineerID = int.Parse(this.Request.QueryString["hairEngineerID"].ToString());
                int hairEngineerRecommandID = int.Parse(this.Request.QueryString["hairEngineerRecommandID"].ToString());

                string hairEngineerRecommandInfo = this.content.Value;
                string hairEngineerRecommandEx = this.txtRecommandEx.Text.Trim();
                if (InfoAdmin.RecommandHairEngineer(hairEngineerID, hairEngineerRecommandID, hairEngineerRecommandInfo, hairEngineerRecommandEx, UserAction.Update))
                {
                    StringHelper.AlertInfo("更新成功", this.Page);
                    this.Response.Redirect("HairEngineerRecommandAdmin.aspx");
                }
                else
                {
                    StringHelper.AlertInfo("更新失败", this.Page);
                }
            }
        }
    }
}
