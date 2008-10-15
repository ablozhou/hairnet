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


using HairNet.Entry;
using HairNet.Utilities;
using HairNet.Business;
using HairNet.Components.Utilities;
using System.Data.SqlClient;
using System.Collections.Generic;
using HairNet.Provider;
using System.Text;
using HairNet.Components.BackendBusiness;

namespace Web.Admin
{
    public partial class EngineerOpusInfo : System.Web.UI.Page
    {
        private const string Parameter = "ENGINEERID";
        private const string Type = "TYPE";
        private const string PATH = @"/uploadfiles/pictures/";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindControlData();
        }
        public string GetPSGIDs()
        {
            string result = "";
            int i = 0;
            foreach (ListItem li in this.chkJPList.Items)
            {
                if (li.Selected == true)
                {
                    i++;
                    if (i == 1)
                    {
                        result = li.Value;
                    }
                    else
                    {
                        result += "," + li.Value;
                    }
                }
            }
            foreach (ListItem li in this.chkMXList.Items)
            {
                if (li.Selected == true)
                {
                    i++;
                    if (i == 1)
                    {
                        result = li.Value;
                    }
                    else
                    {
                        result += "," + li.Value;
                    }
                }
            }
            foreach (ListItem li in this.chkFXList.Items)
            {
                if (li.Selected == true)
                {
                    i++;
                    if (i == 1)
                    {
                        result = li.Value;
                    }
                    else
                    {
                        result += "," + li.Value;
                    }
                }
            }
            return result;
        }
        
        
        public void btn1_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            String frontFilePath = upload.UploadImageFile(frontsidePic, PATH);
            

            PicOperate WaterMark = new PicOperate();

            //Water Mark Operation
            string newFrontFilePath = frontFilePath.Substring(0, frontFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(frontFilePath);
            
            WaterMark.AddWaterMarkOperate(frontFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newFrontFilePath, WaterSettings.CopyrightText);

            this.lbl1.Text = GetPath(newFrontFilePath);
            i1.ImageUrl = this.lbl1.Text;
            i1.Visible = true;
        }
        public void btn2_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            String flankFilePath = upload.UploadImageFile(flanksidePic, PATH);


            PicOperate WaterMark = new PicOperate();

            //Water Mark Operation
            string newFlankFilePath = flankFilePath.Substring(0, flankFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(flankFilePath);
            WaterMark.AddWaterMarkOperate(flankFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newFlankFilePath, WaterSettings.CopyrightText);

            this.lbl2.Text = GetPath(newFlankFilePath);
            i2.ImageUrl = this.lbl2.Text;
            i2.Visible = true;
        }
        public void btn3_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            String backFilePath = upload.UploadImageFile(backsidePic, PATH);


            PicOperate WaterMark = new PicOperate();

            //Water Mark Operation
            string newBackFilePath = backFilePath.Substring(0, backFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(backFilePath);

            WaterMark.AddWaterMarkOperate(backFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newBackFilePath, WaterSettings.CopyrightText);

            this.lbl3.Text = GetPath(newBackFilePath);
            i3.ImageUrl = this.lbl3.Text;
            i3.Visible = true;
        }
        public void btn4_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            String assistanceFilePath = upload.UploadImageFile(assistancePic, PATH);


            PicOperate WaterMark = new PicOperate();

            //Water Mark Operation
            string newAssistanceFilePath = assistanceFilePath.Substring(0, assistanceFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(assistanceFilePath);

            WaterMark.AddWaterMarkOperate(assistanceFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newAssistanceFilePath, WaterSettings.CopyrightText);

            this.lbl4.Text = GetPath(assistanceFilePath);
            i4.ImageUrl = this.lbl4.Text;
            i4.Visible = true;
        }

        public void btn1Small_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            String frontFilePath = upload.UploadImageFile(frontsidePicSmall, PATH);

            this.lbl1Small.Text = GetPath(frontFilePath);

            i1Small.ImageUrl = this.lbl1Small.Text;
            i1Small.Visible = true;
        }
        public void btn2Small_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            String flankFilePath = upload.UploadImageFile(flanksidePicSmall, PATH);


            this.lbl2Small.Text = GetPath(flankFilePath);

            i2Small.ImageUrl = this.lbl2Small.Text;
            i2Small.Visible = true;
        }
        public void btn3Small_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            String backFilePath = upload.UploadImageFile(backsidePicSmall, PATH);

            this.lbl3Small.Text = GetPath(backFilePath);

            i3Small.ImageUrl = this.lbl3Small.Text;
            i3Small.Visible = true;
        }
        public void btn4Small_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            String assistanceFilePath = upload.UploadImageFile(assistancePicSmall, PATH);


            this.lbl4Small.Text = GetPath(assistanceFilePath);

            i4Small.ImageUrl = this.lbl4Small.Text;
            i4Small.Visible = true;
        }

        public string GetPath(string path)
        {
            string result = string.Empty;
            path.Replace(@"\", @"/");
            result = path.Substring(path.IndexOf("uploadfiles") - 1);
            return result;
        }

        public string buildBBSContent(HairStyleEntity hst)
        {
            StringBuilder cntBuilder = new StringBuilder();
            cntBuilder.AppendLine("[img=300,400]" + lbl1.Text+"[/img]");//正面大图
            cntBuilder.AppendLine("[img=90,120]" + lbl2Small.Text + "[/img]");//侧面小图
            cntBuilder.AppendLine("[img=90,120]" + lbl3Small.Text + "[/img]");//背面小图
            cntBuilder.AppendLine("发质："+hst.HairNatrueName);
            cntBuilder.AppendLine("发量："+hst.HairQuantityName);
            cntBuilder.AppendLine("脸型："+hst.FaceStyleName);
            cntBuilder.AppendLine("场合："+hst.OccasionName);
            cntBuilder.AppendLine("发型师："+hst.HairEngineerName);
            cntBuilder.AppendLine("美发厅："+hst.HairShopName);
            cntBuilder.AppendLine("发型解析："+hst.Description);
            cntBuilder.AppendLine("[url=HairLastPage.aspx?id="+hst.ID.ToString()+"]查看详情[/url]");

            return cntBuilder.ToString();
        }
 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //UpLoadClass upload = new UpLoadClass();
            //String frontFilePath = upload.UploadImageFile(frontsidePic, PATH);
            //String flankFilePath = upload.UploadImageFile(flanksidePic, PATH);
            //String backFilePath = upload.UploadImageFile(backsidePic, PATH);
            //String assistanceFilePath = upload.UploadImageFile(assistancePic, PATH);

            //PicOperate WaterMark = new PicOperate();

            ////Water Mark Operation
            //string newFrontFilePath = frontFilePath.Substring(0, frontFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(frontFilePath);
            //string newFlankFilePath = flankFilePath.Substring(0, flankFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(flankFilePath);
            //string newBackFilePath = backFilePath.Substring(0, backFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(backFilePath);
            //string newAssistanceFilePath = assistanceFilePath.Substring(0, assistanceFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(assistanceFilePath);

            //WaterMark.AddWaterMarkOperate(frontFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newFrontFilePath, WaterSettings.CopyrightText);
            //WaterMark.AddWaterMarkOperate(flankFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newFlankFilePath, WaterSettings.CopyrightText);
            //WaterMark.AddWaterMarkOperate(backFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newBackFilePath, WaterSettings.CopyrightText);
            //WaterMark.AddWaterMarkOperate(assistanceFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newAssistanceFilePath, WaterSettings.CopyrightText);
            string PSGIDS = this.GetPSGIDs();
            String frontFilePath = this.lbl1Small.Text;
            String flankFilePath = this.lbl2Small.Text;
            String backFilePath = this.lbl3Small.Text;
            String assistanceFilePath = this.lbl4Small.Text;

            string newFrontFilePath = this.lbl1.Text;
            string newFlankFilePath = this.lbl2.Text;
            string newBackFilePath = this.lbl3.Text;
            string newAssistanceFilePath = this.lbl4.Text;

            Byte iHairNature = Byte.Parse(this.ddlHairNature.SelectedItem.Value);
            Byte iHairQuantity = Byte.Parse(this.ddlHairQuantity.SelectedItem.Value);
            Byte iFaceStyle = Byte.Parse(this.ddlFaceStyle.SelectedItem.Value);
            Byte iSex = Byte.Parse(this.ddlSex.SelectedItem.Value);
            Byte iHairStyleClassName = Byte.Parse(this.ddlHairStyleClassName.SelectedItem.Value);
            Byte iTemperament = Byte.Parse(this.ddlTemperament.SelectedItem.Value);
            Byte iOccasion = Byte.Parse(this.ddlOccasion.SelectedItem.Value);
            string bbsUrl = txtBbsurl.Text.Trim();//美发圈
            string keywords = txtKeywords.Text.Trim();

            int hairShopID = 0;
            int hairEngineerID = 0;
            HairEngineer he = null;
            string shopName = string.Empty;
            string engineerName = string.Empty;
            try
            {
                hairEngineerID = int.Parse(this.Request.QueryString["ENGINEERID"].ToString());

                 he = ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerByHairEngineerID(hairEngineerID);

   
                if (he != null)
                {   
                    hairShopID = he.HairShopID; 
                    shopName = he.HairShopName;
                    engineerName = he.HairEngineerName;
                }
            }
            catch
            { }

          

            //HairStyleEntity HairStyle = new HairStyleEntity(txtOpusName.Text.Trim(), newFrontFilePath, newFlankFilePath,
            //    newBackFilePath, newAssistanceFilePath, Byte.Parse(listHairStyle.SelectedValue), Byte.Parse(listFaceType.SelectedValue),
            //    Byte.Parse(listHairType.SelectedValue), Byte.Parse(listHairItem.SelectedValue), txtDesc.Text.Trim());

            HairStyleEntity HairStyle = new HairStyleEntity(txtOpusName.Text.Trim(),iHairQuantity, bbsUrl,hairShopID, hairEngineerID, iHairStyleClassName, iFaceStyle, iTemperament, iOccasion, iSex, iHairNature, txtDesc.Text.Trim(), PSGIDS, true, 0);
            HairStyle.FaceStyleName = ddlFaceStyle.SelectedItem.Text;
            HairStyle.HairEngineerName = engineerName;
            HairStyle.HairNatrueName = ddlHairNature.SelectedItem.Text;
            HairStyle.HairQuantityName = ddlHairQuantity.SelectedItem.Text;
            HairStyle.HairShopName = shopName;
            HairStyle.HairStyleText = ddlHairStyleClassName.SelectedItem.Text;
            HairStyle.OccasionName = ddlOccasion.SelectedItem.Text;
            HairStyle.SexName = ddlSex.SelectedItem.Text;
            HairStyle.TemperamentName = ddlTemperament.SelectedItem.Text;
            
            InfoAdmin.AddHairStyle(HairStyle);

            string id = "";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select top 1 * from HairStyle order by id desc";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    id = comm.ExecuteScalar().ToString(); 
                }
            }

            HairStyle.ID = int.Parse(id);
            //add bbs post
            string content = buildBBSContent(HairStyle);

            BBSPost post = new BBSPost();
            int postid = 0;
            bool bSuc = post.AddPost(HairStyle.HairName, content, BBSPost.Category.HairStyle, out postid);
            if (bSuc)
            {
                HairStyle.PostID = postid;

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "update hairstyle set postid=" + HairStyle.PostID.ToString() + " where ID=" + HairStyle.ID.ToString();
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
            }

            //TAG逻辑

            string tagIDs = "";
            string[] tagCollection = txtKeywords.Text.Split(",".ToCharArray());
            for (int k = 0; k < tagCollection.Length; k++)
            {
                string tagID = "";
                bool isExist = false;
                PictureStoreTag hst = new PictureStoreTag();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from PictureStoreTag where PictureStoreTagName='" + tagCollection[k] + "'";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.CommandText = commString;
                        comm.Connection = conn;
                        conn.Open();
                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                try
                                {
                                    hst.TagID = int.Parse(sdr["PictureStoreTagID"].ToString());
                                    hst.TagName = sdr["PictureStoreTagName"].ToString();
                                    hst.PictureStoreIDs = sdr["PictureStoreIDs"].ToString();
                                }
                                catch
                                { }
                            }
                        }
                    }
                }
                if (hst.TagID == 0)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "insert PictureStoreTag(PictureStoreTagName,PictureStoreIDs) values('" + tagCollection[k] + "','" + id + "');select @@identity;";
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.CommandText = commString;
                            comm.Connection = conn;
                            conn.Open();

                            tagID = comm.ExecuteScalar().ToString();
                        }
                    }
                }
                else
                {
                    tagID = hst.TagID.ToString();
                    if (hst.PictureStoreIDs == string.Empty)
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "update PictureStoreTag set PictureStoreIDs='" + id + "' where PictureStoreTagID=" + hst.TagID.ToString();
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = commString;
                                comm.Connection = conn;
                                conn.Open();
                                try
                                {
                                    comm.ExecuteNonQuery();
                                }
                                catch
                                { }
                            }
                        }
                    }
                    else
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "update PictureStoreTag set PictureStoreIDs=PictureStoreIDs+'," + id + "' where PictureStoreTagID=" + hst.TagID.ToString();
                            using (SqlCommand comm = new SqlCommand())
                            {
                                comm.CommandText = commString;
                                comm.Connection = conn;
                                conn.Open();
                                try
                                {
                                    comm.ExecuteNonQuery();
                                }
                                catch
                                { }
                            }
                        }
                    }
                }
                if (k == 0)
                {
                    tagIDs = tagID;
                }
                else
                {
                    tagIDs += "," + tagID;
                }
            }
            HairStyleEntity HairStyle1 = new HairStyleEntity(int.Parse(id),tagIDs,txtOpusName.Text.Trim(), iHairQuantity, bbsUrl, hairShopID, hairEngineerID, iHairStyleClassName, iFaceStyle, iTemperament, iOccasion, iSex, iHairNature, txtDesc.Text.Trim(), PSGIDS, true, 0);

            InfoAdmin.UpdateHairStyle(HairStyle1);

            //

            string[] PPSGCollection = PSGIDS.Split(",".ToCharArray());
            foreach (string s in PPSGCollection)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "update PictureStoreGroup set PictureStoreIDs = PictureStoreIDs+'," + id + "' where PictureStoreGroupID=" + s;
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        try
                        {
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        { }
                    }
                }
            }

            //大图
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL,IsHairStyle,HairStylePos,SmallPictureUrl) values(" + id + ",'" + newFrontFilePath + "',1,1,'"+frontFilePath+"')";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    { }
                }
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL,IsHairStyle,HairStylePos,SmallPictureUrl) values(" + id + ",'" + newFlankFilePath + "',1,2,'"+flankFilePath+"')";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    { }
                }
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL,IsHairStyle,HairStylePos,SmallPictureUrl) values(" + id + ",'" + newBackFilePath + "',1,3,'"+backFilePath+"')";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    { }
                }
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL,IsHairStyle,HairStylePos,SmallPictureUrl) values(" + id + ",'" + newAssistanceFilePath + "',1,4,'"+assistanceFilePath+"')";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    { }
                }
            }
            
            if (hairEngineerID != 0)
            {
                this.Response.Redirect("HairEngineerAddSwitch.aspx?id="+this.Request.QueryString["ENGINEERID"].ToString()+"&shopid="+this.Request.QueryString["shopid"].ToString());
            }
            else
            {
                this.Response.Redirect("HairStyleAdmin.aspx");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        protected void BindControlData()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select * from hairnature";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem li = new ListItem();
                            li.Value = sdr["id"].ToString();
                            li.Text = sdr["hairnature"].ToString();

                            this.ddlHairNature.Items.Add(li);
                        }
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select * from facestyle";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem li = new ListItem();
                            li.Value = sdr["id"].ToString();
                            li.Text = sdr["facestylename"].ToString();

                            this.ddlFaceStyle.Items.Add(li);
                        }
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select * from hairquantity";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem li = new ListItem();
                            li.Value = sdr["id"].ToString();
                            li.Text = sdr["hairquantity"].ToString();

                            this.ddlHairQuantity.Items.Add(li);
                        }
                    }
                }
            }


            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select * from hairstyleclassname";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem li = new ListItem();
                            li.Value = sdr["id"].ToString();
                            li.Text = sdr["hairstyleclassname"].ToString();

                            this.ddlHairStyleClassName.Items.Add(li);
                        }
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select * from temperament";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem li = new ListItem();
                            li.Value = sdr["id"].ToString();
                            li.Text = sdr["temperament"].ToString();

                            this.ddlTemperament.Items.Add(li);
                        }
                    }
                }
            }
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select * from occasion";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ListItem li = new ListItem();
                            li.Value = sdr["id"].ToString();
                            li.Text = sdr["occasion"].ToString();

                            this.ddlOccasion.Items.Add(li);
                        }
                    }
                }
            }

            List<PictureStoreGroup> list1 = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupsByParentID(1, 0);

            for (int i = 0; i < list1.Count; i++)
            {
                ListItem lli = new ListItem();
                lli.Value = list1[i].ID.ToString();
                lli.Text = list1[i].Name.ToString();
                this.chkJPList.Items.Add(lli);
            }
            List<PictureStoreGroup> list2 = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupsByParentID(2, 0);

            for (int i = 0; i < list2.Count; i++)
            {
                ListItem lli = new ListItem();
                lli.Value = list2[i].ID.ToString();
                lli.Text = list2[i].Name.ToString();
                this.chkMXList.Items.Add(lli);
            }
            List<PictureStoreGroup> list3 = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupsByParentID(3, 0);

            for (int i = 0; i < list3.Count; i++)
            {
                ListItem lli = new ListItem();
                lli.Value = list3[i].ID.ToString();
                lli.Text = list3[i].Name.ToString();
                this.chkFXList.Items.Add(lli);
            }
        }
    }
}
