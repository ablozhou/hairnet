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
using HairNet.Utilities;
using HairNet.Business;
using HairNet.Components.Utilities;

namespace Web.Admin
{
    public partial class EngineerOpusInfo : System.Web.UI.Page
    {
        private const string Parameter = "ENGINEERID";
        private const string Type = "TYPE";
        private const string PATH = @"/uploadfiles/pictures/";

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(Request.Params[Parameter]))
            //    throw new ArgumentNullException("缺少参数", "未提供工程师ID");

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
            UpLoadClass upload = new UpLoadClass();
            String frontFilePath = upload.UploadImageFile(frontsidePic, PATH);
            String flankFilePath = upload.UploadImageFile(flanksidePic, PATH);
            String backFilePath = upload.UploadImageFile(backsidePic, PATH);
            String assistanceFilePath = upload.UploadImageFile(assistancePic, PATH);

            PicOperate WaterMark = new PicOperate();

            //Water Mark Operation
            string newFrontFilePath = frontFilePath.Substring(0, frontFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(frontFilePath);
            string newFlankFilePath = flankFilePath.Substring(0, flankFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(flankFilePath);
            string newBackFilePath = backFilePath.Substring(0, backFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(backFilePath);
            string newAssistanceFilePath = assistanceFilePath.Substring(0, assistanceFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(assistanceFilePath);

            WaterMark.AddWaterMarkOperate(frontFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newFrontFilePath, WaterSettings.CopyrightText);
            WaterMark.AddWaterMarkOperate(flankFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newFlankFilePath, WaterSettings.CopyrightText);
            WaterMark.AddWaterMarkOperate(backFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newBackFilePath, WaterSettings.CopyrightText);
            WaterMark.AddWaterMarkOperate(assistanceFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newAssistanceFilePath, WaterSettings.CopyrightText);


            HairStyleEntity HairStyle = new HairStyleEntity(txtOpusName.Text.Trim(), newFrontFilePath, newFlankFilePath,
                newBackFilePath, newAssistanceFilePath, Byte.Parse(listHairStyle.SelectedValue), Byte.Parse(listFaceType.SelectedValue),
                Byte.Parse(listHairType.SelectedValue), Byte.Parse(listHairItem.SelectedValue), txtDesc.Text.Trim());

            InfoAdmin.AddHairStyle(HairStyle);
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

            //
            listHairType.Items.Add(new ListItem("测试", "1"));

            //
            listHairItem.Items.Add(new ListItem("测试", "1"));
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
