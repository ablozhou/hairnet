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
                                this.ddlFaceStyle.SelectedValue = sdr["facestyle"].ToString();
                                this.ddlHairNature.SelectedValue = sdr["hairnature"].ToString();
                                this.ddlHairQuantity.SelectedValue = sdr["hairquantity"].ToString();
                                this.ddlHairStyleClassName.SelectedValue = sdr["hairstyle"].ToString();
                                this.ddlOccasion.SelectedValue = sdr["occasion"].ToString();
                                this.ddlSex.SelectedValue = sdr["sex"].ToString();
                                this.ddlTemperament.SelectedValue = sdr["temperament"].ToString();
                                this.txtOpusName.Text = sdr["hairname"].ToString();
                                this.txtDesc.Text = sdr["descr"].ToString();
                            }
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
                                    case "5":
                                        this.lbl1.Text = sdr["PictureStoreUrl"].ToString();
                                        i1.ImageUrl = sdr["PictureStoreUrl"].ToString();
                                        i1.Visible = true;
                                        this.l1.Text = sdr["ID"].ToString();
                                        break;
                                    case "6":
                                        this.lbl2.Text = sdr["PictureStoreUrl"].ToString();
                                        i2.ImageUrl = sdr["PictureStoreUrl"].ToString();
                                        i2.Visible = true;
                                        this.l2.Text = sdr["ID"].ToString();
                                        break;
                                    case "7":
                                        this.lbl3.Text = sdr["PictureStoreUrl"].ToString();
                                        i3.ImageUrl = sdr["PictureStoreUrl"].ToString();
                                        i3.Visible = true;
                                        this.l3.Text = sdr["ID"].ToString();
                                        break;
                                    case "8":
                                        this.lbl4.Text = sdr["PictureStoreUrl"].ToString();
                                        i4.ImageUrl = sdr["PictureStoreUrl"].ToString();
                                        i4.Visible = true;
                                        this.l4.Text = sdr["ID"].ToString();
                                        break;
                                    case "1":
                                        this.lbl1new.Text = sdr["PictureStoreUrl"].ToString();
                                        this.l5.Text = sdr["ID"].ToString();
                                        break;
                                    case "2":
                                        this.lbl2new.Text = sdr["PictureStoreUrl"].ToString();
                                        this.l6.Text = sdr["ID"].ToString();
                                        break;
                                    case "3":
                                        this.lbl3new.Text = sdr["PictureStoreUrl"].ToString();
                                        this.l7.Text = sdr["ID"].ToString();
                                        break;
                                    case "4":
                                        this.lbl4new.Text = sdr["PictureStoreUrl"].ToString();
                                        this.l8.Text = sdr["ID"].ToString();
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }
        public void btn1_OnClick(object sender, EventArgs e)
        {
            UpLoadClass upload = new UpLoadClass();
            String frontFilePath = upload.UploadImageFile(frontsidePic, PATH);


            PicOperate WaterMark = new PicOperate();

            //Water Mark Operation
            string newFrontFilePath = frontFilePath.Substring(0, frontFilePath.LastIndexOf(".")) + "_new" + System.IO.Path.GetExtension(frontFilePath);

            WaterMark.AddWaterMarkOperate(frontFilePath, Server.MapPath(WaterSettings.WaterMarkPath), newFrontFilePath, WaterSettings.CopyrightText);

            string path1 = frontFilePath.Substring(frontFilePath.IndexOf("uploadfiles"));

            this.lbl1.Text = GetPath(frontFilePath);
            this.lbl1new.Text = GetPath(newFrontFilePath);
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

            string path1 = flankFilePath.Substring(flankFilePath.IndexOf("uploadfiles"));

            this.lbl2.Text = GetPath(flankFilePath);
            this.lbl2new.Text = GetPath(newFlankFilePath);
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

            string path1 = backFilePath.Substring(backFilePath.IndexOf("uploadfiles"));

            this.lbl3.Text = GetPath(backFilePath);
            this.lbl3new.Text = GetPath(newBackFilePath);
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

            string path1 = assistanceFilePath.Substring(assistanceFilePath.IndexOf("uploadfiles"));

            this.lbl4.Text = GetPath(assistanceFilePath);
            this.lbl4new.Text = GetPath(newAssistanceFilePath);
            i4.ImageUrl = this.lbl4.Text;
            i4.Visible = true;
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

            int id = int.Parse(this.Request.QueryString["id"].ToString());

            String frontFilePath = this.lbl1.Text;
            String flankFilePath = this.lbl2.Text;
            String backFilePath = this.lbl3.Text;
            String assistanceFilePath = this.lbl4.Text;

            string newFrontFilePath = this.lbl1new.Text;
            string newFlankFilePath = this.lbl2new.Text;
            string newBackFilePath = this.lbl3new.Text;
            string newAssistanceFilePath = this.lbl4new.Text;


            Byte iHairNature = Byte.Parse(this.ddlHairNature.SelectedItem.Value);
            Byte iHairQuantity = Byte.Parse(this.ddlHairQuantity.SelectedItem.Value);
            Byte iFaceStyle = Byte.Parse(this.ddlFaceStyle.SelectedItem.Value);
            Byte iSex = Byte.Parse(this.ddlSex.SelectedItem.Value);
            Byte iHairStyleClassName = Byte.Parse(this.ddlHairStyleClassName.SelectedItem.Value);
            Byte iTemperament = Byte.Parse(this.ddlTemperament.SelectedItem.Value);
            Byte iOccasion = Byte.Parse(this.ddlOccasion.SelectedItem.Value);

            int hairShopID = 0;
            int hairEngineerID = 0;

            try
            {
                hairEngineerID = int.Parse(this.Request.QueryString["ENGINEERID"].ToString());
            }
            catch
            { }

            try
            {
                hairShopID = int.Parse(this.Request.QueryString["SHOPID"].ToString());
            }
            catch
            { }

            //HairStyleEntity HairStyle = new HairStyleEntity(txtOpusName.Text.Trim(), newFrontFilePath, newFlankFilePath,
            //    newBackFilePath, newAssistanceFilePath, Byte.Parse(listHairStyle.SelectedValue), Byte.Parse(listFaceType.SelectedValue),
            //    Byte.Parse(listHairType.SelectedValue), Byte.Parse(listHairItem.SelectedValue), txtDesc.Text.Trim());

            HairStyleEntity HairStyle = new HairStyleEntity(id,txtOpusName.Text.Trim(), hairShopID, hairEngineerID, iHairStyleClassName, iFaceStyle, iTemperament, iOccasion, iSex, iHairNature, txtDesc.Text.Trim());

            ProviderFactory.GetHairEngineerDataProviderInstance().HairStyleCreateDeleteUpdate(HairStyle,UserAction.Update);

            
            //大图
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "update PictureStoreSet set PictureStoreURL = '"+newFrontFilePath+"' where ID=" + this.l5.Text.ToString();
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
                string commString = "update PictureStoreSet set PictureStoreURL = '"+newFlankFilePath+"' where ID=" + this.l6.Text.ToString();
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
                string commString = "update PictureStoreSet set PictureStoreURL = '"+newBackFilePath+"' where ID=" + this.l7.Text.ToString();
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
                string commString = "update PictureStoreSet set PictureStoreURL = '"+newAssistanceFilePath+"' where ID=" + this.l8.Text.ToString();
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
            //小图
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
            {
                string commString = "update PictureStoreSet set PictureStoreURL = '"+frontFilePath+"' where ID=" + this.l1.Text.ToString();
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
                string commString = "update PictureStoreSet set PictureStoreURL = '"+flankFilePath+"' where ID=" + this.l2.Text.ToString();
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
                string commString = "update PictureStoreSet set PictureStoreURL = '"+backFilePath+"' where ID=" + this.l3.Text.ToString();
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
                string commString = "update PictureStoreSet set PictureStoreURL = '" + assistanceFilePath + "' where ID=" + this.l4.Text.ToString();
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
            }
        }
    }
}
