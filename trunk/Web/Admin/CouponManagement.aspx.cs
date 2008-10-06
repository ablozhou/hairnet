using System;
using System.Collections;
using System.Configuration;
using System.Data;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


using HairNet.Business;

namespace Web.Admin
{
    public partial class CouponManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGridData();
        }

        /// <summary>
        /// 
        /// </summary>
        protected void BindGridData()
        {
            dg.DataKeyField = "ID";
            dg.DataSource = InfoAdmin.GetCouponList();
            dg.DataBind();
        }

        protected void dg_OnPageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            dg.CurrentPageIndex = e.NewPageIndex;
            this.BindGridData();
        }

        protected void dg_DeleteCommand(object source, DataGridCommandEventArgs e)
        {
            InfoAdmin.DeleteCoupon(dg.DataKeys[e.Item.ItemIndex].ToString());
            this.BindGridData();
        }

        protected void dg_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            //if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            //    if (e.CommandName == "delete")
            //    {
            //        int couponID = int.Parse(dg.DataKeys[e.Item.ItemIndex].ToString());

            //        if (InfoAdmin.DeleteCoupon(couponID))
            //            StringHelper.AlertInfo("删除成功", this.Page);
            //        else
            //            StringHelper.AlertInfo("删除失败", this.Page);
            //    }
        }
    }
}
