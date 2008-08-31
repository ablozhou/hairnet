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
using HairNet.Enumerations;
using HairNet.Entry;
using System.Collections.Generic;

namespace Web.Admin
{
    public partial class ProductEdit2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindTable();
                this.bindHairShop();
                this.SetInfo();
            }
        }

        void SetInfo()
        {
            Product product = (Product)Session["ProductInfo"];

            if (product.HairShopIDs != "")
            {
                string[] ids = product.HairShopIDs.Split(',');
                foreach (string id in ids)
                {
                    ddlHairShopName.SelectedValue = id;
                    this.AddHairShop();
                }
            }
        }

        void bindHairShop()
        {
            ddlHairShopName.DataSource = InfoAdmin.GetHairShops(0, OrderKey.ID);
            ddlHairShopName.DataTextField = "HairShopName";
            ddlHairShopName.DataValueField = "HairShopID";
            ddlHairShopName.DataBind();
        }

        void bindTable()
        {
            if (ViewState["dtList"] == null)
            {
                DataTable dt = new DataTable("dtList");
                dt.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("Name") });
                ViewState["dtList"] = dt;
            }

            gvHairShopList.DataSource = (DataTable)ViewState["dtList"];
            gvHairShopList.DataKeyNames = new string[] { "ID" };
            gvHairShopList.DataBind();
        }

        void AddHairShop()
        {
            try
            {
                DataRow row = ((DataTable)ViewState["dtList"]).NewRow();
                row["Name"] = ddlHairShopName.SelectedItem.Text;
                row["ID"] = ddlHairShopName.SelectedItem.Value;
                ((DataTable)ViewState["dtList"]).Rows.Add(row);
                ddlHairShopName.Items.RemoveAt(ddlHairShopName.SelectedIndex);
            }
            catch { }
            this.bindTable();
        }

        protected void btnAddMain_Click(object sender, EventArgs e)
        {
            if (ddlHairShopName.SelectedItem != null)
            {
                this.AddHairShop();
            }
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            Product product = (Product)Session["ProductInfo"];

            List<string> id1 = new List<string>();
            for (int i = 0; i < gvHairShopList.DataKeys.Count; i++)
            {
                id1.Add(gvHairShopList.DataKeys[i].Value.ToString());
            }
            id1.Sort();
            product.HairShopIDs = string.Join(",", id1.ToArray());

            Session["ProductInfo"] = product;

            this.Response.Redirect("ProductEdit3.aspx");
        }

        protected void gvZD_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvHairShopList.Rows[e.RowIndex];
            ddlHairShopName.Items.Add(new ListItem(row.Cells[0].Text, gvHairShopList.DataKeys[e.RowIndex].Value.ToString()));
            ((DataTable)ViewState["dtList"]).Rows.RemoveAt(e.RowIndex);

            this.bindTable();
        }
    }
}
