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
using HairNet.Entry;
using HairNet.Business;
using HairNet.Enumerations;
using System.Collections.Generic;

namespace Web.Admin
{
    public partial class HairShopEdit2 : System.Web.UI.Page
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
            HairShop hs = (HairShop)Session["HairShopInfo"];

            if (hs.HairShopMainIDs != "")
            {
                string[] mainID = hs.HairShopMainIDs.Split(',');
                foreach (string mid in mainID)
                {
                    ddlHairShopName.SelectedValue = mid;
                    this.AddMain();
                }
            }

            if (hs.HairShopPartialIDs != "")
            {
                string[] partID = hs.HairShopPartialIDs.Split(',');
                foreach (string pid in partID)
                {
                    ddlHairShopName.SelectedValue = pid;
                    this.AddPart();
                }
            }
        }

        void AddMain()
        {
            try
            {
                DataRow row = ((DataTable)ViewState["dtZD"]).NewRow();
                row["Name"] = ddlHairShopName.SelectedItem.Text;
                row["ID"] = ddlHairShopName.SelectedItem.Value;
                ((DataTable)ViewState["dtZD"]).Rows.Add(row);
                ddlHairShopName.Items.RemoveAt(ddlHairShopName.SelectedIndex);
            }
            catch { }
            this.bindTable();
        }

        void AddPart()
        {
            try
            {
                DataRow row = ((DataTable)ViewState["dtFD"]).NewRow();
                row["Name"] = ddlHairShopName.SelectedItem.Text;
                row["ID"] = ddlHairShopName.SelectedItem.Value;
                ((DataTable)ViewState["dtFD"]).Rows.Add(row);
                ddlHairShopName.Items.RemoveAt(ddlHairShopName.SelectedIndex);
            }
            catch { }
            this.bindTable();
        }

        void bindTable()
        {
            if (ViewState["dtZD"] == null)
            {
                DataTable dt = new DataTable("dtZD");
                dt.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("Name") });
                ViewState["dtZD"] = dt;
            }
            if (ViewState["dtFD"] == null)
            {
                DataTable dt = new DataTable("dtFD");
                dt.Columns.AddRange(new DataColumn[] { new DataColumn("ID"), new DataColumn("Name") });
                ViewState["dtFD"] = dt;
            }

            gvZD.DataSource = (DataTable)ViewState["dtZD"];
            gvZD.DataKeyNames = new string[] { "ID" };
            gvZD.DataBind();
            gvFD.DataSource = (DataTable)ViewState["dtFD"];
            gvFD.DataKeyNames = new string[] { "ID" };
            gvFD.DataBind();

        }

        void bindHairShop()
        {
            ddlHairShopName.DataSource = InfoAdmin.GetHairShops(0, OrderKey.ID);
            ddlHairShopName.DataTextField = "HairShopName";
            ddlHairShopName.DataValueField = "HairShopID";
            ddlHairShopName.DataBind();
        }

        protected void gvZD_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvZD.Rows[e.RowIndex];
            ddlHairShopName.Items.Add(new ListItem(row.Cells[0].Text, gvZD.DataKeys[e.RowIndex].Value.ToString()));
            ((DataTable)ViewState["dtZD"]).Rows.RemoveAt(e.RowIndex);

            this.bindTable();
        }

        protected void gvFD_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvFD.Rows[e.RowIndex];
            ddlHairShopName.Items.Add(new ListItem(row.Cells[0].Text, gvFD.DataKeys[e.RowIndex].Value.ToString()));
            ((DataTable)ViewState["dtFD"]).Rows.RemoveAt(e.RowIndex);

            this.bindTable();
        }

        protected void btnAddMain_Click(object sender, EventArgs e)
        {
            if (ddlHairShopName.SelectedItem != null)
            {
                this.AddMain();
            }
        }

        protected void btnAddPartial_Click(object sender, EventArgs e)
        {
            if (ddlHairShopName.SelectedItem != null)
            {
                this.AddPart();
            }
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            HairShop hs = (HairShop)Session["HairShopInfo"];

            List<string> id1 = new List<string>();
            for (int i = 0; i < gvZD.DataKeys.Count; i++)
            {
                id1.Add(gvZD.DataKeys[i].Value.ToString());
            }
            id1.Sort();
            hs.HairShopMainIDs = string.Join(",", id1.ToArray());

            List<string> id2 = new List<string>();
            for (int i = 0; i < gvFD.DataKeys.Count; i++)
            {
                id2.Add(gvFD.DataKeys[i].Value.ToString());
            }
            id2.Sort();
            hs.HairShopPartialIDs = string.Join(",", id2.ToArray());

            Session["HairShopInfo"] = hs;

            this.Response.Redirect("HairShopEdit3.aspx");
        }
    }
}
