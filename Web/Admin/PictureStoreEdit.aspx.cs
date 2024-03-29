﻿using System;
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
using HairNet.Entry;
using System.Collections.Generic;
using System.IO;
using HairNet.Components.Utilities;
using HairNet.Utilities;
using System.Data.SqlClient;
using HairNet.Provider;

namespace Web.Admin
{
    public partial class PictureStoreEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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

                BindControlData();
                this.SetInfo();
                ViewState["num"] = 0;
            }
        }
        private void SetInfo()
        {
            string id = Request["id"];
            PictureStore ps = InfoAdmin.GetPictureStoreByPictureStoreID(int.Parse(id));
            

            txtPictureStoreName.Text = ps.PictureStoreName;
            txtPictureStoreDescription.Text = ps.PictureStoreDescription;
            //txtPictureStoreTag.Text = InfoAdmin.GetPictureStoreTagNames(ps.PictureStoreTagIDs);
           
            string[] PSGIDSCollection = ps.PictureStoreGroupIDs.Split(",".ToCharArray());
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
            string hairStyleTagIDs = "";

            string hairStyleID = "";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select * from HairStyle where PictureStoreId=" + ps.PictureStoreID.ToString();
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
                            hairStyleID = sdr["id"].ToString();
                            this.ddlFaceStyle.SelectedValue = sdr["facestyle"].ToString();
                            this.ddlHairNature.SelectedValue = sdr["hairnature"].ToString();
                            this.ddlHairQuantity.SelectedValue = sdr["hairquantity"].ToString();
                            this.ddlHairStyleClassName.SelectedValue = sdr["hairstyle"].ToString();
                            this.ddlOccasion.SelectedValue = sdr["occasion"].ToString();
                            this.ddlSex.SelectedValue = sdr["sex"].ToString();
                            this.ddlTemperament.SelectedValue = sdr["temperament"].ToString();
                

                            this.txtBbsurl.Text = sdr["bbsUrl"].ToString();

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
                        this.txtPictureStoreTag.Text = hst.TagName;
                    }
                    else
                    {
                        this.txtPictureStoreTag.Text += "," + hst.TagName;
                    }
                }
            }

            //

            int i = 0;
            string imgString = string.Empty;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {

                string commString = "select * from PictureStoreSet where PictureStoreId=" + hairStyleID;

                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            i++;
                            if (i == 1)
                            {
                                imgString = "<img src='" + sdr["SmallPictureUrl"].ToString() + "' width=100 height=50 /><a href='" + sdr["PictureStoreURL"].ToString() + "' target='_blank'><img src='" + sdr["PictureStoreURL"].ToString() + "' width=200 height=100 /></a>&nbsp;&nbsp;<a href='PictureStoreOperate.aspx?id=" + sdr["id"].ToString() + "&pid=" + ps.PictureStoreID.ToString() + "'>删除</a>";
                            }
                            else
                            {
                                imgString += "<img src='" + sdr["SmallPictureUrl"].ToString() + "' width=100 height=50 /><a href='" + sdr["PictureStoreURL"].ToString() + "' target='_blank'><img src='" + sdr["PictureStoreURL"].ToString() + "' width=200 height=100 /></a>&nbsp;&nbsp;<a href='PictureStoreOperate.aspx?id=" + sdr["id"].ToString() + "&pid=" + ps.PictureStoreID.ToString() + "'>删除</a>";
                            }
                        }
                    }
                }

            }
            this.lblImg.Text = imgString;
            ViewState["PictureStoreInfo"] = ps;
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
        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            if (this.txtPictureStoreTag.Text.Trim() != string.Empty)
            {
                string[] tagCondition = this.txtPictureStoreTag.Text.Split(",".ToCharArray());
                this.lblRedInfo1.Visible = false;

                for (int k = 0; k < tagCondition.Length; k++)
                {
                    if (tagCondition[k] == string.Empty)
                    {
                        this.lblRedInfo1.Text = "TAG格式不正确(正确的格式&nbsp;&nbsp; 1,2,3)";
                        this.lblRedInfo1.Visible = true;
                        return;
                    }
                }
            }

            string PSGIDS = this.GetPSGIDs();
            PictureStore ps = (PictureStore)ViewState["PictureStoreInfo"];

            //先删除
            string hstyleid = string.Empty;
            string hairStyleTagIDs = "";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select id,tag from hairstyle where picturestoreid =" + ps.PictureStoreID.ToString();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();
                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            hstyleid = sdr["id"].ToString();
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
            if (ps.PictureStoreGroupIDs != "")
            {
                string[] PSGIDSCollection1 = ps.PictureStoreGroupIDs.Split(",".ToCharArray());
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

                            object obj= comm.ExecuteScalar();
                            if(obj != null)
                            ids = obj.ToString();
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



            ps.PictureStoreName = txtPictureStoreName.Text.Trim();
            ps.PictureStoreGroupIDs = PSGIDS;
            ps.PictureStoreDescription = txtPictureStoreDescription.Text.Trim();
            //ps.PictureStoreHits = 0;
            ps.PictureStoreCreateTime = DateTime.Now;
            //ps.PictureStoreRawUrl = string.Empty;
            //ps.PictureStoreLittleUrl = string.Empty;

            //if (uploadpic.Value != "")
            //{
            //    UpLoadClass upload = new UpLoadClass();
            //    string filepath = upload.UpLoadImg(uploadpic, "/uploadfiles/pictures/");
            //    upload = null;
            //    //处理图片
            //    PicOperate po = new PicOperate();
            //    string newfilepath = filepath.Substring(0, filepath.LastIndexOf(".")) + "_new" + Path.GetExtension(filepath);
            //    po.AddWaterMarkOperate(Server.MapPath(filepath), Server.MapPath(WaterSettings.WaterMarkPath), Server.MapPath(newfilepath), WaterSettings.CopyrightText);
            //    ps.PictureStoreRawUrl = newfilepath;
            //    ps.PictureStoreLittleUrl = po.CreateMicroPic(newfilepath, "", WaterSettings.PictureScaleSize[0], WaterSettings.PictureScaleSize[1]);
            //    po = null;
            //}
            
            string[] ppicString = this.pic.Text.Split(";".ToCharArray());
            if (ppicString[0] != string.Empty)
            {
                foreach (string pps in ppicString)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL,IsHairStyle,HairStylePos) values(" + hstyleid + ",'" + pps + "',0,0)";
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
            }

            InfoAdmin.UpdatePictureStore(ps);

            string iHairNature = this.ddlHairNature.SelectedItem.Value;
            string iHairQuantity = this.ddlHairQuantity.SelectedItem.Value;
            string iFaceStyle = this.ddlFaceStyle.SelectedItem.Value;
            string iSex = this.ddlSex.SelectedItem.Value;
            string iHairStyleClassName = this.ddlHairStyleClassName.SelectedItem.Value;
            string iTemperament = this.ddlTemperament.SelectedItem.Value;
            string iOccasion = this.ddlOccasion.SelectedItem.Value;

            int hairShopID = 0;
            int hairEngineerID = 0;
            //
            //tag逻辑
            string tagIDs = "";
            string[] tagCollection = txtPictureStoreTag.Text.Split(",".ToCharArray());
            if (tagCollection[0] != string.Empty)
            {
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
            }
            //
            
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "update HairStyle set tag='" + tagIDs + "',bbsUrl='"+txtBbsurl.Text+"',hairname='" + ps.PictureStoreName + "',hairShopID=" + hairShopID.ToString() + ",hairEngineerID=" + hairEngineerID.ToString() + ",hairnature=" + iHairNature + ",hairquantity=" + iHairQuantity + ",facestyle=" + iFaceStyle + ",sex=" + iSex + ",hairstyle=" + iHairStyleClassName + ",temperament=" + iTemperament + ",occasion=" + iOccasion + ",descr='" + ps.PictureStoreDescription + "', psgids='" + PSGIDS + "' where picturestoreid=" + ps.PictureStoreID.ToString();
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

            //同步TAG
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "update PictureStore set PictureStoreTagIDs = '" + tagIDs + "' where PictureStoreid=" + ps.PictureStoreID.ToString();
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

            string[] PPSGCollection = PSGIDS.Split(",".ToCharArray());
            foreach (string s in PPSGCollection)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "update PictureStoreGroup set PictureStoreIDs = PictureStoreIDs+'," + hstyleid + "' where PictureStoreGroupID=" + s;
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

            this.Response.Redirect("PictureStoreAdmin.aspx");
        }
        public string GetPath(string path)
        {
            string result = string.Empty;
            path = path.Replace(@"\", @"/");
            result = path.Substring(path.IndexOf("uploadfiles") - 1);
            return result;
        }
        protected void btnPicUpload1_OnClick(object sender, EventArgs e)
        {
            this.lblRedInfo.Visible = false;
            this.btnPicUpload.Enabled = false;

            if (uploadpic1.FileName == string.Empty || uploadpicsmall.Value == string.Empty)
            {
                this.lblRedInfo.Text = "上传大小图片地址不能为空！";
                this.lblRedInfo.Visible = true;
                this.btnPicUpload.Enabled = true;
                return;
            }

            PictureStore ps = (PictureStore)ViewState["PictureStoreInfo"];

            UpLoadClass upload = new UpLoadClass();
            string filepath = "";
            string newfilepath = upload.UploadImageFile(uploadpic1, "/uploadfiles/pictures/");
            PicOperate WaterMark = new PicOperate();

            //Water Mark Operation
            filepath = newfilepath.Substring(0, newfilepath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(newfilepath);

            WaterMark.AddWaterMarkOperate(newfilepath, Server.MapPath(WaterSettings.WaterMarkPath), filepath, WaterSettings.CopyrightText);

            filepath = GetPath(filepath);
            System.Threading.Thread.Sleep(1000);
            string filepathSmall = upload.UpLoadImg(uploadpicsmall, "/uploadfiles/pictures/");

            string hairStyleID = "";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select id from HairStyle where PictureStoreId=" + ps.PictureStoreID.ToString();
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            hairStyleID = sdr["id"].ToString();

                        }
                    }
                }
            }

            if (filepath != string.Empty)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL,SmallPictureUrl,IsHairStyle,HairStylePos) values(" + hairStyleID + ",'" + filepath + "','" + filepathSmall + "',0,0)";
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
                int pssid = 0;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "select top 1 * from PictureStoreSet where IsHairStyle=0 order by id desc";
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = commString;
                        conn.Open();

                        using (SqlDataReader sdr = comm.ExecuteReader())
                        {
                            if (sdr.Read())
                            {
                                pssid = Convert.ToInt32(sdr["ID"].ToString());
                            }
                        }
                    }
                }

                this.lblImg.Text = "<img src='" + filepathSmall + "' width=100 height=50 /><a href='" + filepath + "' target='_blank'><img src='" + filepath + "' width=200 height=100 /></a>&nbsp;&nbsp;<a href='PictureStoreOperate.aspx?id=" + pssid + "&pid=" + ps.PictureStoreID.ToString() + "'>删除</a>" + "&nbsp;&nbsp;" + this.lblImg.Text;

                this.btnPicUpload.Enabled = true;
            }
        }
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
        }
    }
}
