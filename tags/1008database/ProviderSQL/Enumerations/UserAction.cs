using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace HairNet.Enumerations
{
    public enum UserAction
    {
        Create=1,
        Update=2,
        Delete=3
    }
}
