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
    public enum UpLoadFileType
    {
        //新闻上传图片
        newsUploadFile,
        //头像图片
        identityUploadFile,
        //非论坛留言版图片
        customUploadFile,
        //表情图片
        emotionUploadFile
    }
}
