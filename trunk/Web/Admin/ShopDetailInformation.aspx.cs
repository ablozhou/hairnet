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

using HairNet.Business;
using HairNet.Entry;
using HairNet.Provider;

namespace Web.Admin
{
    public partial class ShopDetailInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Request.Params["ID"]))
                throw new ArgumentNullException("未能提供指定参数", "未能提供参数 ID");

            GetHairShopEntity(Request.Params["ID"]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="HairShopID">HairShopID</param>
        protected void GetHairShopEntity(string HairShopID)
        {
            //HairShop item = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(int.Parse(HairShopID));
            foreach (HairShop item in InfoAdmin.GetHairShops(0, HairNet.Enumerations.OrderKey.ID))
            {
                if (item.HairShopID == Int32.Parse(HairShopID))
                {
                    txtHairShopName.Text = item.HairShopName;
                    txtHairShopShortName.Text = item.HairShopShortName;

                    foreach (TypeTable table in InfoAdmin.GetTypeTable())
                    {
                        if (table.ID == item.TypeID)
                            tbType.Text = table.Name;
                    }

                    txtHairShopWebSite.Text = item.HairShopWebSite;
                    txtHairShopEmail.Text = item.HairShopEmail;
                    txtHairShopDiscount.Text = item.HairShopDiscount;

                    tbHairCutPrice.Text = item.HairCutPirce.ToString();
                    tbHairCutDiscount.Text = item.HairCutDiscount.ToString();
                    tbMarcelPrice.Text = item.HairMarcelPrice.ToString();
                    tbMarclDiscount.Text = item.HairMarcelDiscount.ToString();
                    tbHairDyePrice.Text = item.HairDyePrice.ToString();
                    tbHairDyeDiscount.Text = item.HairDyeDiscount.ToString();
                    tbShapePrice.Text = item.HairShapePrice.ToString();
                    tbShapeDiscount.Text = item.HairShapeDiscount.ToString();
                    tbConservationPrice.Text = item.HairConservationPrice.ToString();
                    tbConservationDiscount.Text = item.HairConservationDiscount.ToString();
                    this.imgLogo.Src = item.HairShopLogo;

                    tbSquare.Text = item.Square;
                    tbLocation.Text = item.LocationMapURL;

                    txtHairShopCreateTime.Text = item.HairShopCreateTime;

                    foreach (City city in InfoAdmin.GetCityItems())
                    {
                        if (city.ID == item.HairShopCityID)
                            tbCity.Text = city.Name;
                    }

                    foreach (MapZone zone in InfoAdmin.GetMapZoneByCityID(item.HairShopCityID))
                    {
                        if (zone.ID == item.HairShopMapZoneID)
                            tbArea.Text = zone.Name;
                    }

                    foreach (HotZone hz in InfoAdmin.GetHotZoneByMapZoneID(item.HairShopMapZoneID))
                    {
                        if (hz.ID == item.HairShopHotZoneID)
                            tbZone.Text = hz.Name;
                    }

                    txtHairShopAddress.Text = item.HairShopAddress;
                    txtHairShopPhoneNum.Text = item.HairShopPhoneNum;
                    txtHairShopOpenTime.Text = item.HairShopOpenTime;
                    txtHairShopTag.Text = item.HairShopTagIDs;

                    chkCut.Checked = item.IsServeHairCut;
                    chkMarcel.Checked = item.IsServeMarce;
                    chkDye.Checked = item.IsServeDye;

                    chkIsJoin.Checked = item.IsJoin;
                    chkIsPostStation.Checked = item.IsPostStation;
                    chkIsPostMachine.Checked = item.IsPostMachine;
                }
            }
        }
    }
}
