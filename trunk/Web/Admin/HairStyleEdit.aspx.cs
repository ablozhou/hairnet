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
using HairNet.Provider;
using HairNet.Enumerations;
using System.Collections.Generic;

namespace Web.Admin
{
    public partial class HairStyleEdit : System.Web.UI.Page
    {
        private const string Parameter = "ENGINEERID";
        private const string Type = "TYPE";
        private const string PATH = @"/uploadfiles/pictures/";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindControlData();
                string id = this.Request.QueryString["id"].ToString();
                string picturestoregroupids = string.Empty;
                string hairStyleTagIDs = "";
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "select * from hairstyle where id="+id;
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                hairStyleTagIDs = sdr["tag"].ToString();
                                this.ddlFaceStyle.SelectedValue = sdr["facestyle"].ToString();
                                this.ddlHairNature.SelectedValue = sdr["hairnature"].ToString();
                                this.ddlHairQuantity.SelectedValue = sdr["hairquantity"].ToString();
                                this.ddlHairStyleClassName.SelectedValue = sdr["hairstyle"].ToString();
                                this.ddlOccasion.SelectedValue = sdr["occasion"].ToString();
                                this.ddlSex.SelectedValue = sdr["sex"].ToString();
                                this.ddlTemperament.SelectedValue = sdr["temperament"].ToString();
                                this.txtOpusName.Text = sdr["hairname"].ToString();
                                this.txtDesc.Text = sdr["descr"].ToString();
                                picturestoregroupids = sdr["psgids"].ToString();
                                this.lblEngineerID.Text = sdr["hairEngineerID"].ToString();
                                txtBbsurl.Text = sdr["bbsurl"].ToString();
                            }
                        }
                    }
                }
                //tag逻辑
                if (hairStyleTagIDs != string.Empty)
                {
                    string[] tempTagC = hairStyleTagIDs.Split(",".ToCharArray());
                    for (int k = 0; k < tempTagC.Length; k++)
                    {
                        PictureStoreTag hst = new PictureStoreTag();
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "select * from PictureStoreTag where PictureStoreTagID=" + tempTagC[k];
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

                        if (k == 0)
                        {
                            this.txtKeywords.Text = hst.TagName;
                        }
                        else
                        {
                            this.txtKeywords.Text += "," + hst.TagName;
                        }
                    }
                }


                //

                ViewState["psgids"] = picturestoregroupids;
                string[] PSGIDSCollection = picturestoregroupids.Split(",".ToCharArray());
                foreach (string ss in PSGIDSCollection)
                {
                    foreach (ListItem llli in this.chkJPList.Items)
                    {
                        if (llli.Value == ss)
                        {
                            llli.Selected = true;
                            break;
                        }
                    }
                    foreach (ListItem llli in this.chkMXList.Items)
                    {
                        if (llli.Value == ss)
                        {
                            llli.Selected = true;
                            break;
                        }
                    }
                    foreach (ListItem llli in this.chkFXList.Items)
                    {
                        if (llli.Value == ss)
                        {
                            llli.Selected = true;
                            break;
                        }
                    }
                }
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "select * from picturestoreset where ishairstyle=1 and picturestoreid=" + id;
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                switch (sdr["HairStylePos"].ToString())
                                {
                                    case "1":
                                        this.lbl1.Text = sdr["PictureStoreUrl"].ToString();
                                        this.lbl1Small.Text = sdr["SmallPictureUrl"].ToString();

                                        i1Small.ImageUrl = sdr["SmallPictureUrl"].ToString();
                                        i1Small.Visible = true;

                                        i1.ImageUrl = sdr["PictureStoreUrl"].ToString();
                                        i1.Visible = true;
                                        this.l1.Text = sdr["ID"].ToString();
                                        break;
                                    case "2":
                                        this.lbl2.Text = sdr["PictureStoreUrl"].ToString();
                                        this.lbl2Small.Text = sdr["SmallPictureUrl"].ToString();

                                        i2Small.ImageUrl = sdr["SmallPictureUrl"].ToString();

                                        if(i2Small.ImageUrl != string.Empty)
                                        i2Small.Visible = true;

                                        i2.ImageUrl = sdr["PictureStoreUrl"].ToString();
                                        if (i2.ImageUrl != string.Empty)
                                        i2.Visible = true;
                                        this.l2.Text = sdr["ID"].ToString();
                                        break;
                                    case "3":
                                        this.lbl3.Text = sdr["PictureStoreUrl"].ToString();
                                        this.lbl3Small.Text = sdr["SmallPictureUrl"].ToString();

                                        i3Small.ImageUrl = sdr["SmallPictureUrl"].ToString();
                                        if (i3Small.ImageUrl != string.Empty)
                                        i3Small.Visible = true;

                                        i3.ImageUrl = sdr["PictureStoreUrl"].ToString();
                                        if (i3.ImageUrl != string.Empty)
                                        i3.Visible = true;
                                        this.l3.Text = sdr["ID"].ToString();
                                        break;
                                    case "4":
                                        this.lbl4.Text = sdr["PictureStoreUrl"].ToString();
                                        this.lbl4Small.Text = sdr["SmallPictureUrl"].ToString();

                                        i4Small.ImageUrl = sdr["SmallPictureUrl"].ToString();
                                        if (i4Small.ImageUrl != string.Empty)
                                        i4Small.Visible = true;

                                        i4.ImageUrl = sdr["PictureStoreUrl"].ToString();
                                        if (i4.ImageUrl != string.Empty)
                                        i4.Visible = true;
                                        this.l4.Text = sdr["ID"].ToString();
                                        break;
                                }
                            }
                        }
                    }
                }
            }
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
            int id = int.Parse(this.Request.QueryString["id"].ToString());

            string hstyleid = id.ToString();

            //tag
            string hairStyleTagIDs = "";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select id,tag from hairstyle where id =" + hstyleid;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();
                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            hairStyleTagIDs = sdr["tag"].ToString();
                        }
                    }
                }
            }
            //先处理TAG逻辑，先删除HS所对应的所有TAG
            if (hairStyleTagIDs != string.Empty)
            {
                string[] tempTagC = hairStyleTagIDs.Split(",".ToCharArray());
                for (int k = 0; k < tempTagC.Length; k++)
                {
                    PictureStoreTag hst = new PictureStoreTag();
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "select * from PictureStoreTag where PictureStoreTagID=" + tempTagC[k];
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
                    string[] tempPictureStoreIDC = hst.PictureStoreIDs.Split(",".ToCharArray());
                    string pictureStoreIDs = "";

                    int tempNum = 0;
                    for (int i = 0; i < tempPictureStoreIDC.Length; i++)
                    {
                        if (tempPictureStoreIDC[i] != hstyleid.ToString())
                        {
                            tempNum++;
                            if (tempNum == 1)
                            {
                                pictureStoreIDs = tempPictureStoreIDC[i];
                            }
                            else
                            {
                                pictureStoreIDs += "," + tempPictureStoreIDC[i];
                            }
                        }
                    }
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "update PictureStoreTag set PictureStoreIDs='" + pictureStoreIDs + "' where PictureStoreTagID=" + hst.TagID.ToString();
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

            //
            string coll = ViewState["psgids"].ToString();
            if (ViewState["psgids"].ToString() != string.Empty)
            {
                string[] PSGIDSCollection1 = ViewState["psgids"].ToString().Split(",".ToCharArray());
                foreach (string sso in PSGIDSCollection1)
                {
                    string ids = "";
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "select picturestoreids from picturestoregroup where picturestoregroupid=" + sso;
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
                            conn.Open();

                            ids = comm.ExecuteScalar().ToString();
                        }
                    }
                    string[] iids = ids.Split(",".ToCharArray());
                    ids = string.Empty;
                    for (int i = 1; i < iids.Length; i++)
                    {
                        if (iids[i] != hstyleid)
                        {
                            ids += "," + iids[i];
                        }
                    }
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "update picturestoregroup set picturestoreids = '" + ids + "' where picturestoregroupid=" + sso;
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = commString;
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
            string bbsUrl = txtBbsurl.Text.Trim();
            string keywords = txtKeywords.Text.Trim();

            int hairShopID = 0;
            int hairEngineerID = 0;

            if(this.lblEngineerID.Text != "0")
            {
                hairEngineerID = int.Parse(this.lblEngineerID.Text.ToString());

                HairEngineer he = ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerByHairEngineerID(hairEngineerID);

                hairShopID = he.HairShopID;
            }

            //tag逻辑

            //tag逻辑
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
                        string commString = "insert PictureStoreTag(PictureStoreTagName,PictureStoreIDs) values('" + tagCollection[k] + "','" + hstyleid.ToString() + "');select @@identity;";
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
                            string commString = "update PictureStoreTag set PictureStoreIDs='" + hstyleid.ToString() + "' where PictureStoreTagID=" + hst.TagID.ToString();
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
                            string commString = "update PictureStoreTag set PictureStoreIDs=PictureStoreIDs+'," + hstyleid.ToString() + "' where PictureStoreTagID=" + hst.TagID.ToString();
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
            //

            //

            //HairStyleEntity HairStyle = new HairStyleEntity(txtOpusName.Text.Trim(), newFrontFilePath, newFlankFilePath,
            //    newBackFilePath, newAssistanceFilePath, Byte.Parse(listHairStyle.SelectedValue), Byte.Parse(listFaceType.SelectedValue),
            //    Byte.Parse(listHairType.SelectedValue), Byte.Parse(listHairItem.SelectedValue), txtDesc.Text.Trim());

            HairStyleEntity HairStyle = new HairStyleEntity(tagIDs,id,iHairQuantity,bbsUrl,txtOpusName.Text.Trim(), hairShopID, hairEngineerID, iHairStyleClassName, iFaceStyle, iTemperament, iOccasion, iSex, iHairNature, txtDesc.Text.Trim(),PSGIDS,true,0);

            ProviderFactory.GetHairEngineerDataProviderInstance().HairStyleCreateDeleteUpdate(HairStyle,UserAction.Update);

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
                string commString = "update PictureStoreSet set SmallPictureUrl='"+frontFilePath+"', PictureStoreURL = '"+newFrontFilePath+"' where ID=" + this.l1.Text.ToString();
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
                string commString = "update PictureStoreSet set SmallPictureUrl='"+flankFilePath+"', PictureStoreURL = '"+newFlankFilePath+"' where ID=" + this.l2.Text.ToString();
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
                string commString = "update PictureStoreSet set SmallPictureUrl='"+backFilePath+"', PictureStoreURL = '"+newBackFilePath+"' where ID=" + this.l3.Text.ToString();
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
                string commString = "update PictureStoreSet set SmallPictureUrl='"+assistanceFilePath+"', PictureStoreURL = '"+newAssistanceFilePath+"' where ID=" + this.l4.Text.ToString();
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
                this.Response.Redirect("HairEngineerAdmin.aspx");
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
}
