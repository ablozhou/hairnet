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

using HairNet.Provider;
using HairNet.Entry;
using HairNet.Business;
using HairNet.Utilities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Web.Admin
{
    public partial class HairShopEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.bindtype();
                //this.bindworkranges();
                this.bindProductChklist();
                this.bindBaseInfo();
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
        private void bindBaseInfo()
        {
            string id = Request["id"];
            HairShop hs = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(int.Parse(id));

            //绑定TAG
            if (hs.HairShopTagIDs != string.Empty)
            {
                string[] tempTagC = hs.HairShopTagIDs.Split(",".ToCharArray());
                for (int k = 0; k < tempTagC.Length; k++)
                {
                    HairShopTag hst = new HairShopTag();
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "select * from HairShopTag where HairShopTagID=" + tempTagC[k];
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

                    if (k == 0)
                    {
                        this.txtHairShopTag.Text = hst.TagName;
                    }
                    else
                    {
                        this.txtHairShopTag.Text += "," + hst.TagName;
                    }
                }
            }
            txtTravelInfo.Text = hs.TravelInfo;
            txtDescription.Text = hs.HairShopDescription;
            txtHairShopAddress.Text = hs.HairShopAddress;
            txtHairShopCreateTime.Text = hs.HairShopCreateTime.ToString();
            txtHairShopDiscount.Text = hs.HairShopDiscount;
            txtHairShopEmail.Text = hs.HairShopEmail;
            txtHairShopName.Text = hs.HairShopName;
            txtHairShopOpenTime.Text = hs.HairShopOpenTime.ToString();
            txtHairShopPhoneNum.Text = hs.HairShopPhoneNum;
            txtHairShopShortName.Text = hs.HairShopShortName;
            txtHairShopWebSite.Text = hs.HairShopWebSite;
            txtHairCutPriceMin.Text = hs.HairCutDiscountMin.ToString();
            txtHairDyePriceMin.Text = hs.HairDyeDiscountMin.ToString();
            txtMarcelPriceMin.Text = hs.HairMarcelDiscountMin.ToString();
            txtConservationPriceMin.Text = hs.HairConservationDiscountMin.ToString();
            txtShapePriceMin.Text = hs.HairShapeDiscountMin.ToString();

            imgLogo.ImageUrl = hs.HairShopLogo;

            ddlTypeTable.SelectedValue = hs.TypeID.ToString();

            this.bindcity();
            ddlCity.SelectedValue = hs.HairShopCityID.ToString();
            this.bindmapzone();
            ddlMapZone.SelectedValue = hs.HairShopMapZoneID.ToString();
            this.bindhotzone();
            ddlHotZone.SelectedValue = hs.HairShopHotZoneID.ToString();

            

            tbHairCutPrice.Text = hs.HairCutPirce.ToString();
            tbHairCutDiscount.Text = hs.HairCutDiscount.ToString();
            tbMarcelPrice.Text = hs.HairMarcelPrice.ToString();
            tbMarclDiscount.Text = hs.HairMarcelDiscount.ToString();
            tbHairDyePrice.Text = hs.HairDyePrice.ToString();
            tbHairDyeDiscount.Text = hs.HairDyeDiscount.ToString();
            tbShapePrice.Text = hs.HairShapePrice.ToString();
            tbShapeDiscount.Text = hs.HairShapeDiscount.ToString();
            tbConservationPrice.Text = hs.HairConservationPrice.ToString();
            tbConservationDiscount.Text = hs.HairConservationDiscount.ToString();

            chkCut.Checked = hs.IsServeHairCut;
            chkMarcel.Checked = hs.IsServeMarce;
            chkDye.Checked = hs.IsServeDye;

            tbSquare.Text = hs.Square;
            tbLocation.Text = hs.LocationMapURL;

           
            chkIsJoin.Checked = hs.IsJoin;
            chkIsPostMachine.Checked = hs.IsPostMachine;
            chkIsPostStation.Checked = hs.IsPostStation;

            string[] productids = hs.ProductIDs.Split(",".ToCharArray());
            foreach (ListItem li in chkList.Items)
            {
                if (isExistID(li.Value, productids))
                {
                    li.Selected = true;
                }
            }
            this.txtMemberInfo.Text = hs.MemberInfo;

            ViewState["HairShop"] = hs;
        }
        public bool isExistID(string id, string[] productIDs)
        {
            for (int i = 0; i < productIDs.Length; i++)
            {
                if (productIDs[i] == id.ToString())
                {
                    return true;
                }
            }
            return false;
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

        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            if (this.txtHairShopTag.Text.Trim() != string.Empty)
            {
                string[] tagCondition = this.txtHairShopTag.Text.Split(",".ToCharArray());
                this.lblRedInfo.Visible = false;

                for (int k = 0; k < tagCondition.Length; k++)
                {
                    if (tagCondition[k] == string.Empty)
                    {
                        this.lblRedInfo.Text = "TAG格式不正确(正确的格式&nbsp;&nbsp; 1,2,3)";
                        this.lblRedInfo.Visible = true;
                        return;
                    }
                }
            }

            if (ddlHotZone.SelectedItem.Value == "28")
            {
                this.lblInfo.Visible = true;
                this.lblInfo.Text = "美发商圈未指定！";
                return;
            }

            HairShop hs = (HairShop)ViewState["HairShop"];
            //先处理TAG逻辑，先删除HS所对应的所有TAG
            if (hs.HairShopTagIDs != string.Empty)
            {
                string[] tempTagC = hs.HairShopTagIDs.Split(",".ToCharArray());
                for (int k = 0; k < tempTagC.Length; k++)
                {
                    HairShopTag hst = new HairShopTag();
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "select * from HairShopTag where HairShopTagID=" + tempTagC[k];
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
                    string[] tempHairShopIDC = hst.HairShopIDs.Split(",".ToCharArray());
                    string hairShopIDs = "";

                    int tempNum = 0;
                    for (int i = 0; i < tempHairShopIDC.Length; i++)
                    {
                        if (tempHairShopIDC[i] != hs.HairShopID.ToString())
                        {
                            tempNum++;
                            if (tempNum == 1)
                            {
                                hairShopIDs = tempHairShopIDC[i];
                            }
                            else
                            {
                                hairShopIDs += "," + tempHairShopIDC[i];
                            }
                        }
                    }
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "update HairShopTag set HairShopIDs='" + hairShopIDs + "' where HairShopTagID=" + hst.TagID.ToString();
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
            hs.HairShopName = txtHairShopName.Text.Trim();
            hs.HairShopShortName = txtHairShopShortName.Text.Trim();
            hs.TypeID = int.Parse(ddlTypeTable.SelectedValue);
            hs.HairShopWebSite = txtHairShopWebSite.Text.Trim();
            hs.HairShopEmail = txtHairShopEmail.Text.Trim();
            hs.HairShopDiscount = txtHairShopDiscount.Text.Trim();
            //获取上传图片后的路径
            if (fileLogo.Value!="")
            {
                UpLoadClass upload = new UpLoadClass();
                hs.HairShopLogo = upload.UpLoadImg(fileLogo, "/uploadfiles/logo/");
                upload = null;
            }
            else
            {
                hs.HairShopLogo = imgLogo.ImageUrl;
            }

            try
            {
                hs.HairCutDiscountMin = Decimal.Parse(txtHairCutPriceMin.Text.Trim());
            }
            catch
            {
                hs.HairCutDiscountMin = 0;
            }

            try
            {
                hs.HairMarcelDiscountMin = Decimal.Parse(txtMarcelPriceMin.Text.Trim());
            }
            catch
            {
                hs.HairMarcelDiscountMin = 0;
            }

            try
            {
                hs.HairDyeDiscountMin = Decimal.Parse(txtHairDyePriceMin.Text.Trim());
            }
            catch
            {
                hs.HairDyeDiscountMin = 0;
            }

            try
            {
                hs.HairShapeDiscountMin = Decimal.Parse(txtShapePriceMin.Text.Trim());
            }
            catch
            {
                hs.HairShapeDiscountMin = 0;
            }

            try
            {
                hs.HairConservationDiscountMin = Decimal.Parse(txtConservationPriceMin.Text.Trim());
            }
            catch
            {
                hs.HairConservationDiscountMin = 0;
            }

            hs.HairShopCreateTime = txtHairShopCreateTime.Text.Trim();
            hs.HairShopCityID = int.Parse(ddlCity.SelectedValue);
            hs.HairShopMapZoneID = int.Parse(ddlMapZone.SelectedValue);
            hs.HairShopHotZoneID = int.Parse(ddlHotZone.SelectedValue);
            hs.HairShopAddress = txtHairShopAddress.Text.Trim();
            hs.HairShopPhoneNum = txtHairShopPhoneNum.Text.Trim();
            hs.HairShopOpenTime = txtHairShopOpenTime.Text.Trim();
            hs.TravelInfo = txtTravelInfo.Text.Trim();

            hs.HairShopTagIDs = "";


            try
            {
                hs.HairCutDiscount = Decimal.Parse(tbHairCutDiscount.Text.Trim());
            }
            catch
            {
                hs.HairCutDiscount = 0;
            }
            try
            {
                hs.HairCutPirce = Decimal.Parse(tbHairCutPrice.Text.Trim());
            }
            catch
            {
                hs.HairCutPirce = 0;
            }
            try
            {
                hs.HairMarcelDiscount = Decimal.Parse(tbMarclDiscount.Text.Trim());
            }
            catch
            {
                hs.HairMarcelDiscount = 0;
            }
            try
            {
                hs.HairMarcelPrice = Decimal.Parse(tbMarcelPrice.Text.Trim());
            }
            catch
            {
                hs.HairMarcelPrice = 0;
            }

            try
            {
                hs.HairDyeDiscount = Decimal.Parse(tbHairDyeDiscount.Text.Trim());
            }
            catch
            {
                hs.HairDyeDiscount = 0;
            }
            try
            {

                hs.HairDyePrice = Decimal.Parse(tbHairDyePrice.Text.Trim());
            }
            catch
            {
                hs.HairDyePrice = 0;
            }

            try
            {
                hs.HairShapePrice = Decimal.Parse(tbShapePrice.Text.Trim());
            }
            catch
            {
                hs.HairShapePrice = 0;
            }
            try
            {
                hs.HairShapeDiscount = Decimal.Parse(tbShapeDiscount.Text.Trim());
            }
            catch
            {
                hs.HairShapeDiscount = 0;
            }
            try
            {
                hs.HairConservationPrice = Decimal.Parse(tbConservationPrice.Text.Trim());
            }
            catch
            {
                hs.HairConservationPrice = 0;
            }
            try
            {
                hs.HairConservationDiscount = Decimal.Parse(tbConservationDiscount.Text.Trim());
            }
            catch
            {
                hs.HairConservationDiscount = 0;
            }

            hs.LocationMapURL = tbLocation.Text.Trim();

            try
            {
                hs.Square = int.Parse(tbSquare.Text.Trim()).ToString();
            }
            catch
            {
                hs.Square = "0";
            }


            hs.IsServeHairCut = chkCut.Checked;
            hs.IsServeMarce = chkMarcel.Checked;
            hs.IsServeDye = chkCut.Checked;


           
            hs.IsJoin = chkIsJoin.Checked;
            hs.IsPostMachine = chkIsPostStation.Checked;
            hs.IsPostStation = chkIsPostMachine.Checked;
            hs.HairShopDescription = txtDescription.Text.Trim();

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
                    }
                    else
                    {
                        productIDs += "," + li.Value;
                    }
                }
            }
            hs.ProductIDs = productIDs;

            //TAG逻辑
            string tagIDs = "";
            string id = hs.HairShopID.ToString();
            string[] tagCollection = txtHairShopTag.Text.Split(",".ToCharArray());

            if (tagCollection[0] != string.Empty)
            {
                for (int k = 0; k < tagCollection.Length; k++)
                {
                    string tagID = "";
                    bool isExist = false;
                    HairShopTag hst = new HairShopTag();
                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSqlServer"].ConnectionString))
                    {
                        string commString = "select * from HairShopTag where HairShopTagName='" + tagCollection[k] + "'";
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
                                string commString = "update HairShopTag set HairShopIDs='" + id.ToString() + "' where HairShopTagID=" + hst.TagID.ToString();
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
                        tagIDs += "," + tagID;
                    }
                }
            }
            hs.HairShopTagIDs = tagIDs;
            Session["HairShopInfo"] = hs;
            InfoAdmin.UpdateHairShopInfo(hs);
            this.Response.Redirect("HairShopAdmin.aspx");
        }
    }
}
