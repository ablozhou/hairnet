﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using HairNet.Utilities;
using HairNet.Entry;
using System.Collections.Generic;
using HairNet.Business;
using System.IO;
using HairNet.Components.Utilities;
using System.Data.SqlClient;
using HairNet.Provider;

namespace Web.Admin
{
    public partial class PictureStoreAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   
                BindControlData();
                    
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

                if (Session["num"] == null || Session["num"].ToString() == string.Empty)
                {
                    Session["num"] = 0;
                }
                if (Session["picNum"] == null || Session["picNum"].ToString() == string.Empty)
                {
                    Session["picNum"] = 0;
                }
                else
                {
                     txtPictureStoreName.Text =Session["PictureStoreName"].ToString();
                     txtPictureStoreDescription.Text = Session["PictureStoreDescription"].ToString();
                     txtPictureStoreTag.Text = Session["PictureTags"].ToString();
                     this.ddlHairNature.SelectedValue = Session["iHairNature"].ToString();
                     this.ddlHairQuantity.SelectedValue = Session["iHairQuantity"].ToString();
                     this.ddlFaceStyle.SelectedValue = Session["iFaceStyle"].ToString();
                     this.ddlSex.SelectedValue = Session["iSex"].ToString();
                     this.ddlHairStyleClassName.SelectedValue = Session["iHairStyleClassName"].ToString();
                     this.ddlTemperament.SelectedValue = Session["iTemperament"].ToString();
                     this.ddlOccasion.SelectedValue = Session["iOccasion"].ToString();
                     txtBbsurl.Text = Session["bbsUrl"].ToString();

                     picString.Text = Session["picString"].ToString();
                     pic.Text = Session["pic"].ToString();
                     picsmall.Text = Session["picSmall"].ToString();

                     string[] PSGIDSCollection = Session["PSGIDS"].ToString().Split(",".ToCharArray());
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
                }
            }
        }
        public string GetPSGIDs()
        {
            string result = "";
            int i =0;
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
                        result += ","+li.Value;
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
        protected void btnSubmit_OnClick(object sender,EventArgs e)
        {
            Session["num"] = "";
            Session["picNum"] = "";
            Session["PictureStoreName"] = "";
            Session["PictureStoreDescription"] = "";
            Session["PictureTags"] = "";
            Session["iHairNature"] = "";
            Session["iHairQuantity"] = "";
            Session["iFaceStyle"] = "";
            Session["iSex"] = "";
            Session["iHairStyleClassName"] = "";
            Session["iTemperament"] = "";
            Session["iOccasion"] = "";
            Session["bbsUrl"] = "";
            Session["picString"] = "";
            Session["pic"] = "";
            Session["picSmall"] = "";
            Session["PSGIDS"] = "";

            string PSGIDS = this.GetPSGIDs();
            PictureStore ps = new PictureStore();
            ps.PictureStoreName = txtPictureStoreName.Text.Trim();
            ps.PictureStoreGroupIDs = PSGIDS;
            ps.PictureStoreDescription = txtPictureStoreDescription.Text.Trim();
            
            ps.PictureStoreHits = 0;
            ps.PictureStoreCreateTime = DateTime.Now;
            ps.PictureStoreRawUrl = "";
            ps.PictureStoreLittleUrl = "";

            ps.PictureStoreID = InfoAdmin.AddPictureStore(ps);

            Byte iHairNature = Byte.Parse(this.ddlHairNature.SelectedItem.Value);
            Byte iHairQuantity = Byte.Parse(this.ddlHairQuantity.SelectedItem.Value);
            Byte iFaceStyle = Byte.Parse(this.ddlFaceStyle.SelectedItem.Value);
            Byte iSex = Byte.Parse(this.ddlSex.SelectedItem.Value);
            Byte iHairStyleClassName = Byte.Parse(this.ddlHairStyleClassName.SelectedItem.Value);
            Byte iTemperament = Byte.Parse(this.ddlTemperament.SelectedItem.Value);
            Byte iOccasion = Byte.Parse(this.ddlOccasion.SelectedItem.Value);
            string bbsUrl = txtBbsurl.Text.Trim();
            int hairShopID = 0;
            int hairEngineerID = 0;

            HairStyleEntity HairStyle = new HairStyleEntity(this.txtPictureStoreName.Text.Trim(),iHairQuantity,bbsUrl, hairShopID, hairEngineerID, iHairStyleClassName, iFaceStyle, iTemperament, iOccasion, iSex, iHairNature,ps.PictureStoreID, this.txtPictureStoreDescription.Text.Trim(),PSGIDS,false,0);

            InfoAdmin.AddHairStyle(HairStyle);

            string hstyleid = string.Empty;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "select id from hairstyle order by id desc";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = commString;
                    conn.Open();

                    hstyleid = comm.ExecuteScalar().ToString();
                }
            }

            //tag逻辑
            string tagIDs = "";
            string[] tagCollection = txtPictureStoreTag.Text.Split(",".ToCharArray());
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
            HairStyleEntity HairStyle1 = new HairStyleEntity(int.Parse(hstyleid),tagIDs,txtPictureStoreName.Text.Trim(), iHairQuantity, bbsUrl, hairShopID, hairEngineerID, iHairStyleClassName, iFaceStyle, iTemperament, iOccasion, iSex, iHairNature, ps.PictureStoreID, this.txtPictureStoreDescription.Text.Trim(), PSGIDS, false, 0);
            
            InfoAdmin.UpdateHairStyle(HairStyle1);
            //

            

            string[] PPSGCollection = PSGIDS.Split(",".ToCharArray());
            foreach (string s in PPSGCollection)
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                {
                    string commString = "update PictureStoreGroup set PictureStoreIDs = PictureStoreIDs+',"+hstyleid+"' where PictureStoreGroupID="+s;
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


            string[] ppicString = this.pic.Text.Split(";".ToCharArray());
            string[] ppicSmallString = this.picsmall.Text.Split(";".ToCharArray());

            if (ppicString[0] != string.Empty)
            {
                for(int k=0;k<ppicString.Length;k++)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL,SmallPictureUrl,IsHairStyle,HairStylePos) values(" + ps.PictureStoreID.ToString() + ",'" + ppicString[k] + "','"+ppicSmallString[k]+"',0,0)";
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

            this.Response.Redirect("PictureStoreAdmin.aspx");
        }
        protected void btnPicUpload1_OnClick(object sender, EventArgs e)
        {   
            UpLoadClass upload = new UpLoadClass();
            string filepath = upload.UpLoadImg(uploadpic1, "/uploadfiles/pictures/");
            System.Threading.Thread.Sleep(1000);
            string filepathSmall = upload.UpLoadImg(uploadpicsmall, "/uploadfiles/pictures/");

            if (filepath != string.Empty)
            {
                int num = Convert.ToInt32(Session["num"].ToString());
                num++;
                Session["num"] = num;
                int picNum = int.Parse(Session["picNum"].ToString());
                picNum++;

                if (picNum == 1)
                {   
                    Session["pic" + num.ToString()] = filepath;
                    Session["picSmall" + num.ToString()] = filepathSmall;

                    this.picString.Text = "<img width=100 heigth=50 src='" + filepathSmall + "' />&nbsp;&nbsp;<img width=200 heigth=100 src='" + filepath + "' />&nbsp;&nbsp;<a href='PictureStoreOperate2.aspx?num="+num.ToString()+"'>删除</a>";
                    this.pic.Text = filepath;
                    this.picsmall.Text = filepathSmall; 
                }
                else
                {   
                    

                    this.picString.Text += "&nbsp;&nbsp;<img width=100 heigth=50 src='" + filepathSmall + "' />&nbsp;&nbsp;<img width=200 heigth=100 src='" + filepath + "' />&nbsp;&nbsp;<a href='PictureStoreOperate2.aspx?num=" + num.ToString() + "'>删除</a>";
                    this.pic.Text += ";" + filepath;
                    this.picsmall.Text += ";" + filepathSmall;
                }
                Session["pic" + num.ToString()] = filepath;
                Session["picSmall" + num.ToString()] = filepathSmall;

                Session["picString"] = this.picString.Text;
                Session["pic"] = this.pic.Text;
                Session["picSmall"] = this.picsmall.Text;

                Session["picNum"] = picNum;

                Session["PSGIDS"] = this.GetPSGIDs();
                Session["PictureStoreName"] = txtPictureStoreName.Text.Trim();
                Session["PictureStoreDescription"] = txtPictureStoreDescription.Text.Trim();
                Session["PictureTags"] = txtPictureStoreTag.Text.Trim();
                Session["iHairNature"] = this.ddlHairNature.SelectedItem.Value;
                Session["iHairQuantity"] = this.ddlHairQuantity.SelectedItem.Value;
                Session["iFaceStyle"] = this.ddlFaceStyle.SelectedItem.Value;
                Session["iSex"] = this.ddlSex.SelectedItem.Value;
                Session["iHairStyleClassName"] = this.ddlHairStyleClassName.SelectedItem.Value;
                Session["iTemperament"] = this.ddlTemperament.SelectedItem.Value;
                Session["iOccasion"] = this.ddlOccasion.SelectedItem.Value;
                Session["bbsUrl"] = txtBbsurl.Text.Trim();
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
