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

public partial class WebUserControl_Detail_Search : System.Web.UI.UserControl
{
    public string area;
    public string HotZone;
    public string Product;
    public string Square;

    public string HairStyle;
    public string FaceStyle;
    public string Temperament;
    public string Occasion;

    public string price;
    public string star;

    public string pageUrl;

    protected void Page_Load(object sender, EventArgs e)
    {
        pageUrl = HttpContext.Current.Request.Url.ToString();

        if (pageUrl.LastIndexOf("?") > 0)
        {
            pageUrl = HttpContext.Current.Request.Url.ToString().Substring(pageUrl.LastIndexOf("/") + 1, pageUrl.LastIndexOf("?") - pageUrl.LastIndexOf("/") - 1);
        }
        else
        {
            pageUrl = HttpContext.Current.Request.Url.ToString().Substring(pageUrl.LastIndexOf("/") + 1, pageUrl.Length - pageUrl.LastIndexOf("/") - 1);
        }
  
        area = this.ddlArea.ClientID;
        HotZone = this.ddlHotZone.ClientID;
        Product = this.ddlProduct.ClientID;
        Square = this.ddlSquare.ClientID;

        HairStyle = ddlHairStyle.ClientID;
        FaceStyle = ddlFaceStyle.ClientID;
        Temperament = ddlTemperament.ClientID;
        Occasion = ddlOccasion.ClientID;

        price = this.ddlPrice.ClientID;
        star = this.ddlStar.ClientID;

        if (!Page.IsPostBack)
        {
             DataHelper _DataHelper = new DataHelper();

            //绑定地区
            DataSet mapZoneDs = _DataHelper.ReadDb("select * from MapZone where MapZoneVisible='1' order by MapZoneID asc");

            if (mapZoneDs.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < mapZoneDs.Tables[0].Rows.Count; i++)
                {
                    ddlArea.Items.Add(mapZoneDs.Tables[0].Rows[i]["MapZoneName"].ToString());
                    ddlArea.Items.FindByText(mapZoneDs.Tables[0].Rows[i]["MapZoneName"].ToString()).Value = mapZoneDs.Tables[0].Rows[i]["MapZoneID"].ToString();
                }
            }

            //绑定商圈
            DataSet hotZoneDs = _DataHelper.ReadDb("select * from HotZone where HotZoneVisible='1' order by HotZoneID asc");

            if (hotZoneDs.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < hotZoneDs.Tables[0].Rows.Count; i++)
                {
                    ddlHotZone.Items.Add(hotZoneDs.Tables[0].Rows[i]["HotZoneName"].ToString());
                    ddlHotZone.Items.FindByText(hotZoneDs.Tables[0].Rows[i]["HotZoneName"].ToString()).Value = hotZoneDs.Tables[0].Rows[i]["HotZoneID"].ToString();
                }
            }

            //主打品牌
            DataSet productDs = _DataHelper.ReadDb("select * from product order by ProductID asc");

            if (productDs.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < productDs.Tables[0].Rows.Count; i++)
                {
                    ddlProduct.Items.Add(productDs.Tables[0].Rows[i]["ProductName"].ToString());
                    ddlProduct.Items.FindByText(productDs.Tables[0].Rows[i]["ProductName"].ToString()).Value = productDs.Tables[0].Rows[i]["ProductID"].ToString();
                }
            }

            //头发长度
            DataSet hairStyleDs = _DataHelper.ReadDb("select * from hairstyleclassname order by id asc");

            if (hairStyleDs.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < hairStyleDs.Tables[0].Rows.Count; i++)
                {
                    ddlHairStyle.Items.Add(hairStyleDs.Tables[0].Rows[i]["hairstyleclassname"].ToString());
                    ddlHairStyle.Items.FindByText(hairStyleDs.Tables[0].Rows[i]["hairstyleclassname"].ToString()).Value = hairStyleDs.Tables[0].Rows[i]["id"].ToString();
                }
            }

            //脸型
            DataSet faceStyleDs = _DataHelper.ReadDb("select * from facestyle order by id asc");

            if (faceStyleDs.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < faceStyleDs.Tables[0].Rows.Count; i++)
                {
                    ddlFaceStyle.Items.Add(faceStyleDs.Tables[0].Rows[i]["facestylename"].ToString());
                    ddlFaceStyle.Items.FindByText(faceStyleDs.Tables[0].Rows[i]["facestylename"].ToString()).Value = faceStyleDs.Tables[0].Rows[i]["id"].ToString();
                }
            }

            //气质
            DataSet temperamentDs = _DataHelper.ReadDb("select * from temperament order by id asc");

            if (temperamentDs.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < temperamentDs.Tables[0].Rows.Count; i++)
                {
                    ddlTemperament.Items.Add(temperamentDs.Tables[0].Rows[i]["temperament"].ToString());
                    ddlTemperament.Items.FindByText(temperamentDs.Tables[0].Rows[i]["temperament"].ToString()).Value = temperamentDs.Tables[0].Rows[i]["id"].ToString();
                }
            }

            //场合
            DataSet occasionDs = _DataHelper.ReadDb("select * from occasion order by id asc");

            if (occasionDs.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < occasionDs.Tables[0].Rows.Count; i++)
                {
                    ddlOccasion.Items.Add(occasionDs.Tables[0].Rows[i]["occasion"].ToString());
                    ddlOccasion.Items.FindByText(occasionDs.Tables[0].Rows[i]["occasion"].ToString()).Value = occasionDs.Tables[0].Rows[i]["id"].ToString();
                }
            }
        }
    }
}
