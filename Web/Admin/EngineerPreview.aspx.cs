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
    public partial class EngineerPreview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.Params["id"]))
            {
                dvEngineer.DataSource = InfoAdmin.GetHairEngineerInfoByID(Request.Params["id"]);
                dvEngineer.DataBind();
            }
            else
            {
                dvEngineer.DataSource = null;
                dvEngineer.DataBind();
            }

        }
    }
}
