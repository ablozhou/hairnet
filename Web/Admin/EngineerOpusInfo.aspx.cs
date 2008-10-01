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

using HairNet.Provider.Entry;

namespace Web.Admin
{
    public partial class EngineerOpusInfo : System.Web.UI.Page
    {
        private const string Parameter = "ENGINEERID";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Request.Params[Parameter]))
                throw new ArgumentNullException("缺少参数", "未提供工程师ID");

            if (!IsPostBack)
                BindControlData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            EngOpusInfo engOpusInfo = new EngOpusInfo(Int32.Parse(Request.Params[Parameter]), txtOpusName.Text.Trim(),
                frontsidePic.FileName, flanksidePic.FileName, backsidePic.FileName, assistancePic.FileName,
                Int32.Parse(listHairStyle.SelectedValue), Int32.Parse(listFaceType.SelectedValue),
                Int32.Parse(listHairType.SelectedValue), Int32.Parse(listHairItem.SelectedValue),
                txtDesc.Text.Trim());
        }

        /// <summary>
        /// 
        /// </summary>
        protected void BindControlData()
        {
            //
            listHairStyle.Items.Add(new ListItem("长发", "1"));
            listHairStyle.Items.Add(new ListItem("中发", "2"));
            listHairStyle.Items.Add(new ListItem("短发", "3"));
            listHairStyle.Items.Add(new ListItem("卷发", "4"));
            listHairStyle.Items.Add(new ListItem("直发", "5"));

            //
            listFaceType.Items.Add(new ListItem("瓜子脸", "1"));
            listFaceType.Items.Add(new ListItem("鹅蛋脸", "2"));
            listFaceType.Items.Add(new ListItem("长形", "3"));
            listFaceType.Items.Add(new ListItem("圆形", "4"));
            listFaceType.Items.Add(new ListItem("方形", "5"));
        }

        protected void Validation()
        {
            if (String.IsNullOrEmpty(txtOpusName.Text.Trim()))
                throw new ArgumentNullException("非空字段不能为空", "作品名称不能为空");


            if (!frontsidePic.HasFile && System.IO.Path.GetExtension(frontsidePic.FileName).ToUpper() != "JPG")
                throw new ArgumentException("上传文件错误", "正面图片上传图片错误");

            if (!frontsidePic.HasFile && System.IO.Path.GetExtension(flanksidePic.FileName).ToUpper() != "JPG")
                throw new ArgumentException("上传文件错误", "侧面图片上传图片错误");

            if (!frontsidePic.HasFile && System.IO.Path.GetExtension(backsidePic.FileName).ToUpper() != "JPG")
                throw new ArgumentException("上传文件错误", "背面图片上传图片错误");

            if (!frontsidePic.HasFile && System.IO.Path.GetExtension(assistancePic.FileName).ToUpper() != "JPG")
                throw new ArgumentException("上传文件错误", "辅助图片上传图片错误");
        }
    }
}
