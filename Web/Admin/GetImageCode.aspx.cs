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
using System.IO;
using System.Drawing;
namespace Web.Admin
{
    public partial class GetImageCode : System.Web.UI.Page
    {



        #region 验证码长度(默认5个验证码的长度)
        int length = 5;
        #endregion

        #region 验证码字体大小(默认10像素)
        int fontSize = 10;
        #endregion

        #region 边框补(默认1像素)
        int padding = 1;
        #endregion

        #region 是否输出燥点(默认输出)
        bool chaos = true;
        #endregion

        #region 输出燥点的颜色(默认灰色)
        Color chaosColor = System.Drawing.Color.Pink;
        #endregion

        #region 自定义背景色(默认白色)
        Color backgroundColor = Color.White;
        #endregion

        #region 自定义随机颜色数组
        Color[] colors = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
        #endregion

        #region 自定义字体数组
        string[] fonts = { "Arial", "Georgia" };
        #endregion

        #region 自定义随机码字符串序列(使用逗号分隔)
        string codeSerial = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            Web.Admin.VerifyCode v = new Web.Admin.VerifyCode();

            v.Length = this.length;

            v.FontSize = this.fontSize;

            v.Chaos = this.chaos;

            v.BackgroundColor = this.backgroundColor;

            v.ChaosColor = this.chaosColor;

            v.CodeSerial = this.codeSerial;

            v.Colors = this.colors;

            v.Fonts = this.fonts;

            v.Padding = this.padding;

            string code = v.CreateVerifyCode();                //取随机码

            v.CreateImageOnPage(code, this.Context);        // 输出图片

            //Session["CheckCode"] = code.ToLower();            // 使用Session["CheckCode"]取验证码的值
            Response.Cookies.Add(new HttpCookie("CheckCode", code.ToLower()));// 使用Cookies取验证码的值


        }
    }
}

      

