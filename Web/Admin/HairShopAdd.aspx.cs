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
using System.Collections.Generic;
using HairNet.Entry;
using HairNet.Business;
using HairNet.Utilities;
using System.Data.SqlClient;
using HairNet.Provider;
using HairNet.Enumerations;

namespace Web.Admin
{
    public partial class HairShopAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindcity();
                this.bindmapzone();
                this.bindhotzone();
                this.bindtype();
                this.bindworkranges();
                this.bindProductChklist();
            }
        }
        protected void bindProductChklist()
        {
            int num = 0;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "select * from Product";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            num++;

                            ListItem li = new ListItem();
                            li.Text = sdr["ProductName"].ToString();
                            li.Value = sdr["ProductID"].ToString();

                            this.chkList.Items.Add(li);
                        }
                    }
                }
            }
            if (num == 0)
            {
                this.lblProductInfo.Text = "当前数据库里面没有产品，请先添加产品！";
            }
        }

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            HairShop hs = new HairShop();
            hs.HairShopName = txtHairShopName.Text.Trim();
            hs.HairShopShortName = txtHairShopShortName.Text.Trim();
            hs.TypeID = int.Parse(ddlTypeTable.SelectedValue);
            hs.HairShopWebSite = txtHairShopWebSite.Text.Trim();
            hs.HairShopEmail = txtHairShopEmail.Text.Trim();
            hs.HairShopDiscount = txtHairShopDiscount.Text.Trim();
            //获取上传图片后的路径
            UpLoadClass upload = new UpLoadClass();
            if (!PicOperate.isPermission(StringHelper.GetExtraType(fileLogo.Value)))
            {
                this.lblInfo.Text = "上传图片格式不对";
                this.lblInfo.Visible = true;
                return;
            } 
            hs.HairShopLogo = upload.UpLoadImg(fileLogo, "/uploadfiles/logo/");

            hs.HairShopCreateTime = txtHairShopCreateTime.Text.Trim();
            hs.HairShopCityID = int.Parse(ddlCity.SelectedValue);
            hs.HairShopMapZoneID = int.Parse(ddlMapZone.SelectedValue);
            hs.HairShopHotZoneID = int.Parse(ddlHotZone.SelectedValue);

            hs.HairShopAddress = txtHairShopAddress.Text.Trim();
            hs.HairShopPhoneNum = txtHairShopPhoneNum.Text.Trim();
            hs.HairShopOpenTime = txtHairShopOpenTime.Text.Trim();

            //TAG逻辑，先复制空，然后插入TAG表,然后UPDATE美发厅表
            hs.HairShopTagIDs = "";


            //List<string> IDs = new List<string>();
            //int chkI = chkListWorkRange.Items.Count;
            //for (int i = 0; i < chkI; i++)
            //{
            //    if (chkListWorkRange.Items[i].Selected)
            //    {
            //        IDs.Add(chkListWorkRange.Items[i].Value);
            //    }
            //}
            //IDs.Sort();
            //hs.WorkRangeIDs = string.Join(",", IDs.ToArray());


            //hs.IsBest = chkIsBest.Checked;
            hs.IsJoin = chkIsJoin.Checked;
            hs.IsPostMachine = chkIsPostStation.Checked;
            hs.IsPostStation = chkIsPostMachine.Checked;
            hs.HairShopDescription = txtDescription.Text.Trim();

            //Session["HairShopInfo"] = hs;

            hs.HairCutDiscount = Decimal.Parse(tbHairCutDiscount.Text.Trim());
            hs.HairCutPirce = Decimal.Parse(tbHairCutPrice.Text.Trim());
            hs.HairMarcelDiscount = Decimal.Parse(tbMarclDiscount.Text.Trim());
            hs.HairMarcelPrice = Decimal.Parse(tbMarcelPrice.Text.Trim());
            hs.HairDyeDiscount = Decimal.Parse(tbHairDyeDiscount.Text.Trim());
            hs.HairDyePrice = Decimal.Parse(tbHairDyePrice.Text.Trim());

            hs.HairShapePrice = Decimal.Parse(tbShapePrice.Text.Trim());
            hs.HairShapeDiscount = Decimal.Parse(tbShapeDiscount.Text.Trim());
            hs.HairConservationPrice = Decimal.Parse(tbConservationPrice.Text.Trim());
            hs.HairConservationDiscount = Decimal.Parse(tbConservationDiscount.Text.Trim());

            hs.LocationMapURL = tbLocation.Text.Trim();
            hs.Square = TextBox4.Text.Trim();

            hs.IsServeHairCut = chkCut.Checked;
            hs.IsServeMarce = chkMarcel.Checked;
            hs.IsServeDye = chkCut.Checked;

            hs.MemberInfo = txtMemberInfo.Text.Trim();

            string productIDs = "";
            int num = 0;
            foreach (ListItem li in this.chkList.Items)
            {   
                if (li.Selected)
                {
                    num++;
                    if (num == 1)
                    {
                        productIDs = li.Value;
                        hs.ProductsName = li.Text;
                    }
                    else
                    {
                        productIDs += ","+li.Value;
                        hs.ProductsName += "," + li.Text;
                    }
                }
            }
            hs.ProductIDs = productIDs;
            //InfoAdmin.AddHairShop(hs);
            InfoAdmin.AddHairShopInfo(hs);
            Session["HairShopAdd"] = hs;

            string id = "";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
            {
                string commString = "select top 1 * from HairShop order by HairShopID desc";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.CommandText = commString;
                    comm.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = comm.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            id = sdr["HairShopID"].ToString();
                        }
                    }
                }
            }
            string tagIDs = "";
            string[] tagCollection = txtHairShopTag.Text.Split(",".ToCharArray());
            for (int k = 0; k < tagCollection.Length; k++)
            {
                string tagID = "";
                bool isExist = false;
                HairShopTag hst = new HairShopTag();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                {
                    string commString = "select * from HairShopTag where HairShopTagName='"+tagCollection[k]+"'";
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
                                    hst.TagID = int.Parse(sdr["HairShopTagID"].ToString());
                                    hst.TagName = sdr["HairShopTagName"].ToString();
                                    hst.HairShopIDs = sdr["HairShopIDs"].ToString();
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
                        string commString = "insert HairShopTag(HairShopTagName,HairShopIDs) values('" + tagCollection[k] + "','" + id.ToString() + "');select @@identity;";
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
                    if (hst.HairShopIDs == string.Empty)
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                        {
                            string commString = "update HairShopTag set HairShopIDs='"+id.ToString()+"' where HairShopTagID="+hst.TagID.ToString();
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
                            string commString = "update HairShopTag set HairShopIDs=HairShopIDs+'," + id.ToString() + "' where HairShopTagID=" + hst.TagID.ToString();
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
                    tagIDs += ","+tagID;
                }
            }
            hs.HairShopTagIDs = tagIDs;
            hs.HairShopID = int.Parse(id.ToString());
            ProviderFactory.GetHairShopDataProviderInstance().HairShopCreateDeleteUpdate(hs, UserAction.Update);

            this.Response.Redirect("HairShopAddNext1.aspx?id="+id.ToString());

            //this.Response.Redirect("HairEngineerAdd.aspx");
        }

        private void bindtype()
        {
            ddlTypeTable.DataSource = InfoAdmin.GetTypeTable();
            ddlTypeTable.DataTextField = "Name";
            ddlTypeTable.DataValueField = "ID";
            ddlTypeTable.DataBind();
        }

        private void bindworkranges()
        {
            chkListWorkRange.DataSource = InfoAdmin.GetWorkRange();
            chkListWorkRange.DataTextField = "Name";
            chkListWorkRange.DataValueField = "ID";
            chkListWorkRange.DataBind();
        }

        private void bindcity()
        {
            ddlCity.DataSource = InfoAdmin.GetCityItems();
            ddlCity.DataTextField = "Name";
            ddlCity.DataValueField = "ID";
            ddlCity.DataBind();
        }

        private void bindmapzone()
        {
            if (ddlCity.Items.Count != 0)
            {
                ddlMapZone.DataSource = InfoAdmin.GetMapZoneByCityID(int.Parse(ddlCity.SelectedValue));
                ddlMapZone.DataTextField = "Name";
                ddlMapZone.DataValueField = "ID";
                ddlMapZone.DataBind();
            }
        }

        private void bindhotzone()
        {
            if (ddlMapZone.Items.Count != 0)
            {
                ddlHotZone.DataSource = InfoAdmin.GetHotZoneByMapZoneID(int.Parse(ddlMapZone.SelectedValue));
                ddlHotZone.DataTextField = "Name";
                ddlHotZone.DataValueField = "ID";
                ddlHotZone.DataBind();
            }
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bindmapzone();
            this.bindhotzone();
        }

        protected void ddlMapZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.bindhotzone();
        }

        //protected void btnAddCoupon_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("AddCoupon.aspx");
        //}
    }
}
