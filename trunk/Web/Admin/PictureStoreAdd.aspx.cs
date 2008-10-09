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
                ViewState["num"] = 0;
                BindControlData();
                if (Session["pspg1"] == null || Session["pspg1"].ToString()==string.Empty)
                {

                }
                else
                {
                    this.ddlPictureStoreParentGroup.SelectedValue = Session["pspg1"].ToString();
                    this.ddlPictureStoreGroup.Items.Clear();
                    List<PictureStoreGroup> list = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupsByParentID(int.Parse(this.ddlPictureStoreParentGroup.SelectedItem.Value), 0);
                    ListItem li = new ListItem();
                    li.Value = "0";
                    li.Text = "请选择小类";
                    this.ddlPictureStoreGroup.Items.Add(li);
                    for (int i = 0; i < list.Count; i++)
                    {
                        ListItem lli = new ListItem();
                        lli.Value = list[i].ID.ToString();
                        lli.Text = list[i].Name.ToString();
                        this.ddlPictureStoreGroup.Items.Add(lli);
                    }
                    if (Session["psg1"] == null || Session["psg1"].ToString() == string.Empty)
                    {

                    }
                    else
                    {
                        this.ddlPictureStoreGroup.SelectedValue = Session["psg1"].ToString(); 
                    }
                }
            }
        }
        public void ddlPictureStoreParentGroup_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlPictureStoreGroup.Items.Clear();
            List<PictureStoreGroup> list = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroupsByParentID(int.Parse(this.ddlPictureStoreParentGroup.SelectedItem.Value), 0);
            ListItem li = new ListItem();
            li.Value = "0";
            li.Text = "请选择小类";
            this.ddlPictureStoreGroup.Items.Add(li);
            for (int i = 0; i < list.Count; i++)
            {
                ListItem lli = new ListItem();
                lli.Value = list[i].ID.ToString();
                lli.Text = list[i].Name.ToString();
                this.ddlPictureStoreGroup.Items.Add(lli);
            }
        }

        protected void btnSubmit_OnClick(object sender,EventArgs e)
        {
            PictureStore ps = new PictureStore();
            ps.PictureStoreName = txtPictureStoreName.Text.Trim();
            ps.PictureStoreGroupIDs = ddlPictureStoreGroup.SelectedItem.Value;
            ps.PictureStoreDescription = txtPictureStoreDescription.Text.Trim();
            ps.PictureStoreTagIDs = InfoAdmin.GetPictureStoreTagIDs(txtPictureStoreTag.Text.Trim());
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

            int hairShopID = 0;
            int hairEngineerID = 0;

            HairStyleEntity HairStyle = new HairStyleEntity(this.txtPictureStoreName.Text.Trim(), hairShopID, hairEngineerID, iHairStyleClassName, iFaceStyle, iTemperament, iOccasion, iSex, iHairNature,ps.PictureStoreID, this.txtPictureStoreDescription.Text.Trim());

            InfoAdmin.AddHairStyle(HairStyle);

            string[] ppicString = this.pic.Text.Split(";".ToCharArray());
            if (ppicString[0] != string.Empty)
            {
                foreach (string pps in ppicString)
                {
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ToString()))
                    {
                        string commString = "insert into PictureStoreSet(PictureStoreId,PictureStoreURL,IsHairStyle,HairStylePos) values(" + ps.PictureStoreID.ToString() + ",'" + pps + "',0,0)";
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

            foreach (string tagid in ps.PictureStoreTagIDs.Split(','))
            {
                InfoAdmin.SetPictureStoreTag(ps.PictureStoreID, int.Parse(tagid));
            }
            this.Response.Redirect("PictureStoreAdmin.aspx");
        }
        protected void btnPicUpload1_OnClick(object sender, EventArgs e)
        {
            
            UpLoadClass upload = new UpLoadClass();
            string filepath = upload.UpLoadImg(uploadpic1, "/uploadfiles/pictures/");
            if (filepath != string.Empty)
            {
                int num = Convert.ToInt32(ViewState["num"].ToString());
                num++;
                ViewState["num"] = num;
                if (num == 1)
                {
                    this.picString.Text = "<img width=200 heigth=100 src='" + filepath + "' />";
                    this.pic.Text = filepath;
                }
                else
                {
                    this.picString.Text += "&nbsp;&nbsp;<img width=200 heigth=100 src='" + filepath + "' />";
                    this.pic.Text += ";" + filepath;
                }
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
