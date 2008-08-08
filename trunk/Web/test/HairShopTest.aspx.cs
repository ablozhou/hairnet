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
using HairNet.Provider;
using HairNet.Entry;
using HairNet.Enumerations;
using System.Collections.Generic;

namespace Web.test
{
    public partial class HairShopTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnTest1_OnClick(object sender, EventArgs e)
        {
            HairShop hs = new HairShop();
            hs.HairShopAddress = "testAddress";
            hs.HairShopCityID = 1;
            hs.HairShopCreateTime = "测试开业时间";
            hs.HairShopDescription = "测试美发厅描述";
            hs.HairShopDiscount = "2.0";
            hs.HairShopEmail = "testshop@hotmail.com";
            hs.HairShopEngineerNum = 10;
            hs.HairShopHotZoneID = 1;
            hs.HairShopLogo = "http://www.baidu.com/1.jpg";
            hs.HairShopMapZoneID = 1;
            hs.HairShopName = "test美发厅";
            hs.HairShopOpenTime = "早上8点";
            hs.HairShopPhoneNum = "1234566";
            hs.HairShopShortName = "美发厅简称";
            hs.HairShopWebSite = "www.baidu.com";
            hs.IsBest = true;
            hs.IsJoin = true;
            hs.IsPostMachine = true;
            hs.IsPostStation = true;
            hs.TypeID = 1;
            hs.HairShopMainIDs = "1,2";
            hs.HairShopPartialIDs = "1,2";
            hs.HairShopPictureStoreIDs = "1,2";
            hs.HairShopTagIDs = "1,2";
            hs.ProductIDs = "1,2";
            hs.WorkRangeIDs = "1,2";

            if (ProviderFactory.GetHairShopDataProviderInstance().HairShopDataPrividerCreateDeleteUpdate(hs, UserAction.Create))
            {
                Response.Write("success");
            }
            else
            {
                Response.Write("success");
            }
        }
        protected void btnTest2_OnClick(object sender, EventArgs e)
        {
            HairEngineer he = new HairEngineer();
            he.HairEngineerAge = "21";
            he.HairEngineerClassID = 1;
            he.HairEngineerDescription = "testhairEngineerDescription";
            he.HairEngineerName = "testHairEngineerName";
            he.HairEngineerPhoto = "http://www.baidu.com";
            he.HairEngineerPictureStoreIDs = "1,2";
            he.HairEngineerPrice = "12";
            he.HairEngineerRawPrice = "23";
            he.HairEngineerSex = 1;
            he.HairEngineerSkill = "剪,修";
            he.HairEngineerTagIDs = "1,2";
            he.HairEngineerYear = "2年";
            he.HairShopID = 1;


            if (ProviderFactory.GetHairEngineerDataProviderInstance().HairEngineerCreateDeleteUpdate(he, UserAction.Create))
            {
                Response.Write("success");
            }
            else
            {
                Response.Write("fail");
            }
        }
        protected void btnTest3_OnClick(object sender, EventArgs e)
        {
            Product p = new Product();
            p.HairShopIDs = "1,2";
            p.ProductCompany = "生产产品的公司";
            p.ProductCompanyDescription = "公司介绍";
            p.ProductDescription = "产品介绍";
            p.ProductDiscount = "2.0";
            p.ProductName = "测试产品";
            p.ProductPictureStoreIDs = "1,2";
            p.ProductPrice = "10";
            p.ProductRawPrice = "20";
            p.ProductTagIDs = "1,2";


            if (ProviderFactory.GetProductDataProviderInstance().ProductCreateDeleteUpdate(p, UserAction.Create))
            {
                Response.Write("success");
            }
            else
            {
                Response.Write("fail");
            }
        }
    }
}
