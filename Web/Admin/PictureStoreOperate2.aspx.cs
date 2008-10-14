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

namespace Web.Admin
{
    public partial class PictureStoreOperate2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string num = this.Request.QueryString["num"].ToString();
            string picString = Session["picString"].ToString();
            string pic = Session["pic"].ToString();
            string picSmall = Session["picSmall"].ToString();

            string tempPic = Session["pic" + num.ToString()].ToString();
            string tempPicSmall = Session["picSmall" + num.ToString()].ToString();
            int picNum = int.Parse(Session["picNum"].ToString());

            string tempPicString = "<img width=100 heigth=50 src='" + tempPicSmall + "' />&nbsp;&nbsp;<img width=200 heigth=100 src='" + tempPic + "' />&nbsp;&nbsp;<a href='PictureStoreOperate2.aspx?num=" + num.ToString() + "'>É¾³ý</a>";
            picString = picString.Replace(tempPicString, string.Empty);

            int myNum = 0;
            string[] picCollection = pic.Split(";".ToCharArray());
            pic = "";
            for (int k = 0; k < picCollection.Length; k++)
            {
                if (picCollection[k] != tempPic)
                {
                    myNum++;
                    if (myNum == 1)
                    {
                        pic = picCollection[k];
                    }
                    else
                    {
                        pic += ";"+picCollection[k];
                    }
                }
            }

            myNum = 0;
            string[] picSmallCollection = picSmall.Split(";".ToCharArray());
            picSmall = "";
            for (int k = 0; k < picSmallCollection.Length; k++)
            {
                if (picSmallCollection[k] != tempPicSmall)
                {
                    myNum++;
                    if (myNum == 1)
                    {
                        picSmall = picSmallCollection[k];
                    }
                    else
                    {
                        picSmall += ";" + picSmallCollection[k];
                    }
                }
            }

            Session["picString"] = picString;
            Session["pic"] = pic;
            Session["picSmall"] = picSmall;
            
            picNum -= 1;
            Session["picNum"] = picNum;
            this.Response.Redirect("PictureStoreAdd.aspx");
        }
    }
}
