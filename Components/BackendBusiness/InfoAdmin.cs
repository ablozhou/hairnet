using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Provider;
using HairNet.Enumerations;
using System.Collections;
using System.Data;

namespace HairNet.Business
{
    public class InfoAdmin
    {
        /// <summary>
        /// 获得美发厅信息列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<HairShop> GetHairShops(int count, OrderKey ok)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShops(count, ok);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Top"></param>
        /// <param name="orderKey"></param>
        /// <returns></returns>
        public static DataTable GetHairShopList(int Top, OrderKey orderKey)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShopList(Top, orderKey);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Top"></param>
        /// <param name="orderKey"></param>
        /// <param name="WhereCaused"></param>
        /// <returns></returns>
        public static DataTable GetHairShopList(int Top, OrderKey orderKey, String WhereCaused)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShopList(Top, WhereCaused, orderKey);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="ok"></param>
        /// <returns></returns>
        public static List<HairShop> GetHairShops(int count, OrderKey ok, string hairShopName)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShops(count, ok, hairShopName);
        }

        /// <summary>
        /// 获得美发师信息列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<HairEngineer> GetHairEngineers(int count, OrderKey ok)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineers(count, ok);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="ok"></param>
        /// <param name="hairEngineerName"></param>
        /// <returns></returns>
        public static List<HairEngineer> GetHairEngineers(int count, OrderKey ok, string hairEngineerName)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineers(count, ok, hairEngineerName);
        }

        /// <summary>
        /// 获得美发产品列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<Product> GetProducts(int count, OrderKey ok)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProducts(count, ok);
        }

        public static string GetProductTagIDs(string productTagNames)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProductTagIDs(productTagNames);
        }

        public static string GetProductTagNames(string productTagIDs)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProductTagNames(productTagIDs);
        }

        public static Product GetProductByProductID(string productID)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProductByProductID(int.Parse(productID));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="ok"></param>
        /// <param name="productName"></param>
        /// <returns></returns>
        public static List<Product> GetProducts(int count, OrderKey ok, string productName)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProducts(count, ok, productName);
        }

        /// <summary>
        /// 获得美发厅推荐列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<HairShopRecommand> GetHairShopRecommands(int count)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShopRecommands(count);
        }

        /// <summary>
        /// 获得美发师推荐列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<HairEngineerRecommand> GetHairEngineerRecommands(int count)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerRecommands(count);
        }

        /// <summary>
        /// 获得美发产品推荐列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<ProductRecommand> GetProductRecommands(int count)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProductRecommands(0);
        }
        /// <summary>
        /// 获得美发师推荐信息
        /// </summary>
        /// <param name="hairEngineerRecommandID"></param>
        /// <returns></returns>
        public static HairEngineerRecommand GetHairEngineerRecommand(int hairEngineerRecommandID)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerRecommandByHairEngineerRecommandID(hairEngineerRecommandID);
        }
        /// <summary>
        /// 获得美发厅推荐信息
        /// </summary>
        /// <param name="hairShopRecommandID"></param>
        /// <returns></returns>
        public static HairShopRecommand GetHairShopRecommand(int hairShopRecommandID)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShopRecommandByHairShopRecommandID(hairShopRecommandID);
        }
        /// <summary>
        /// 获得美发产品推荐信息
        /// </summary>
        /// <param name="productRecommandID"></param>
        /// <returns></returns>
        public static ProductRecommand GetProductRecommand(int productRecommandID)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProductRecommandByProductRecommandID(productRecommandID);
        }
        /// <summary>
        /// 获得图片库信息列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<PictureStore> GetPictureStores(int count, OrderKey ok)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStores(count, ok);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="ok"></param>
        /// <returns></returns>
        public static List<PictureStore> GetPictureStores(int count, OrderKey ok, string pictureStoreName)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStores(count, ok, pictureStoreName);
        }
        /// <summary>
        /// 获得图片库信息推荐列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<PictureStoreRecommand> GetPictureStoreRecommands(int count)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreRecommands(count);
        }

        /// <summary>
        /// 获取美发店风格字符串
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string GetTypeNameById(int id)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetTypeNameById(id);
        }

        /// <summary>
        /// 获得图片推荐
        /// </summary>
        /// <param name="pictureStoreRecommandID"></param>
        /// <returns></returns>
        public static PictureStoreRecommand GetPictureStoreRecommand(int pictureStoreRecommandID)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreRecommandByPictureStoreRecommandID(pictureStoreRecommandID);
        }
        /// <summary>
        /// 推荐美发厅
        /// </summary>
        /// <param name="hairShopID"></param>
        /// <param name="hairShopRecommandID"></param>
        /// <param name="hairShopRecommandInfo"></param>
        /// <param name="hairShopRecommandEx"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public static bool RecommandHairShop(int hairShopID, int hairShopRecommandID, string hairShopRecommandInfo, string hairShopRecommandEx, UserAction ua)
        {
            bool result = false;

            HairShop hairShop = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(hairShopID);

            if (hairShop == null)
            {
                return false;
            }

            HairShopRecommand hairShopRecommand = new HairShopRecommand();
            hairShopRecommand.HairShopRecommandID = hairShopRecommandID;
            hairShopRecommand.HairShopRawID = hairShop.HairShopID;
            hairShopRecommand.HairShopName = hairShop.HairShopName;
            hairShopRecommand.HairShopCityID = hairShop.HairShopCityID;
            hairShopRecommand.HairShopMapZoneID = hairShop.HairShopMapZoneID;
            hairShopRecommand.HairShopHotZoneID = hairShop.HairShopHotZoneID;
            hairShopRecommand.HairShopAddress = hairShop.HairShopAddress;
            hairShopRecommand.HairShopPhoneNum = hairShop.HairShopPhoneNum;
            hairShopRecommand.HairShopPictureStoreIDs = hairShop.HairShopPictureStoreIDs;
            hairShopRecommand.HairShopEngineerNum = hairShop.HairShopEngineerNum;
            hairShopRecommand.HairShopOpenTime = hairShop.HairShopOpenTime;
            hairShopRecommand.WorkRangeIDs = hairShop.WorkRangeIDs;
            hairShopRecommand.HairShopWebSite = hairShop.HairShopWebSite;
            hairShopRecommand.HairShopEmail = hairShop.HairShopEmail;
            hairShopRecommand.HairShopDiscount = hairShop.HairShopDiscount;
            hairShopRecommand.HairShopLogo = hairShop.HairShopLogo;
            hairShopRecommand.HairShopCreateTime = hairShop.HairShopCreateTime;
            hairShopRecommand.HairShopDescription = hairShop.HairShopDescription;
            hairShopRecommand.ProductIDs = hairShop.ProductIDs;
            hairShopRecommand.HairShopTagIDs = hairShop.HairShopTagIDs;
            hairShopRecommand.HairShopShortName = hairShop.HairShopShortName;
            hairShopRecommand.IsBest = hairShop.IsBest;
            hairShopRecommand.IsJoin = hairShop.IsJoin;
            hairShopRecommand.TypeID = hairShop.TypeID;
            hairShopRecommand.IsPostMachine = hairShop.IsPostMachine;
            hairShopRecommand.IsPostStation = hairShop.IsPostStation;
            hairShopRecommand.HairShopRecommandEx = hairShopRecommandEx;
            hairShopRecommand.HairShopRecommandInfo = hairShopRecommandInfo;

            if (ProviderFactory.GetHairShopDataProviderInstance().HairShopRecommandCreateDeleteUpdate(hairShopRecommand, ua))
            {
                result = true;
            }

            return result;
        }
        /// <summary>
        /// 推荐美发师
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <param name="hairEngineerRecommandInfo"></param>
        /// <returns></returns>
        public static bool RecommandHairEngineer(int hairEngineerID, int hairEngineerRecommandID, string hairEngineerRecommandInfo, string hairEngineerRecommandEx, UserAction ua)
        {
            bool result = false;

            HairEngineer hairEngineer = ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerByHairEngineerID(hairEngineerID);

            if (hairEngineer == null)
            {
                return false;
            }

            HairEngineerRecommand hairEngineerRecommand = new HairEngineerRecommand();
            hairEngineerRecommand.HairEngineerRawID = hairEngineer.HairEngineerID;
            hairEngineerRecommand.HairEngineerName = hairEngineer.HairEngineerName;
            hairEngineerRecommand.HairEngineerAge = hairEngineer.HairEngineerAge;
            hairEngineerRecommand.HairEngineerSex = hairEngineer.HairEngineerSex;
            hairEngineerRecommand.HairEngineerPhoto = hairEngineer.HairEngineerPhoto;
            hairEngineerRecommand.HairShopID = hairEngineer.HairShopID;
            hairEngineerRecommand.HairEngineerYear = hairEngineer.HairEngineerYear;
            hairEngineerRecommand.HairEngineerSkill = hairEngineer.HairEngineerSkill;
            hairEngineerRecommand.HairEngineerTagIDs = hairEngineer.HairEngineerTagIDs;
            hairEngineerRecommand.HairEngineerPictureStoreIDs = hairEngineer.HairEngineerPictureStoreIDs;
            hairEngineerRecommand.HairEngineerDescription = hairEngineer.HairEngineerDescription;
            hairEngineerRecommand.HairEngineerRawPrice = hairEngineer.HairEngineerRawPrice;
            hairEngineerRecommand.HairEngineerClassID = hairEngineer.HairEngineerClassID;
            hairEngineerRecommand.HairEngineerRecommandEx = hairEngineerRecommandEx;
            hairEngineerRecommand.HairEngineerRecommandInfo = hairEngineerRecommandInfo;
            hairEngineerRecommand.HairEngineerRecommandID = hairEngineerRecommandID;

            if (ProviderFactory.GetHairEngineerDataProviderInstance().HairEngineerRecommandCreateDeleteUpdate(hairEngineerRecommand, ua))
            {
                result = true;
            }

            return result;
        }
        /// <summary>
        /// 推荐美发产品
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="productRecommandID"></param>
        /// <param name="productRecommandInfo"></param>
        /// <param name="productRecommandEx"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public static bool RecommandProduct(int productID, int productRecommandID, string productRecommandInfo, string productRecommandEx, UserAction ua)
        {
            bool result = false;

            Product product = ProviderFactory.GetProductDataProviderInstance().GetProductByProductID(productID);

            if (product == null)
            {
                return false;
            }

            ProductRecommand productRecommand = new ProductRecommand();
            productRecommand.ProductRecommandID = productRecommandID;
            productRecommand.ProductRawID = product.ProductID;
            productRecommand.ProductName = product.ProductName;
            productRecommand.ProductCompany = product.ProductCompany;
            productRecommand.ProductCompanyDescription = product.ProductCompanyDescription;
            productRecommand.ProductPictureStoreIDs = product.ProductPictureStoreIDs;
            productRecommand.ProductDescription = product.ProductDescription;
            productRecommand.HairShopIDs = product.HairShopIDs;
            productRecommand.ProductRawPrice = product.ProductRawPrice;
            productRecommand.ProductPrice = product.ProductPrice;
            productRecommand.ProductDiscount = product.ProductDiscount;
            productRecommand.ProductTagIDs = product.ProductTagIDs;
            productRecommand.ProductRecommandEx = productRecommandEx;
            productRecommand.ProductRecommandInfo = productRecommandInfo;

            if (ProviderFactory.GetProductDataProviderInstance().ProductRecommandCreateDeleteUpdate(productRecommand, ua))
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// 推荐图片库 添加，删除，修改
        /// </summary>
        /// <param name="pictureStoreID"></param>
        /// <param name="pictureStoreRecommandID"></param>
        /// <param name="pictureStoreRecommandInfo"></param>
        /// <param name="pictureStoreRecommandEx"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public static bool RecommandPictureStore(int pictureStoreID, int pictureStoreRecommandID, string pictureStoreRecommandInfo, string pictureStoreRecommandEx, UserAction ua)
        {
            bool result = false;

            PictureStore product = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreByPictureStoreID(pictureStoreID);

            if (product == null)
            {
                return false;
            }

            PictureStoreRecommand pictureStoreRecommand = new PictureStoreRecommand();
            pictureStoreRecommand.PictureStoreRecommandID = pictureStoreRecommandID;
            pictureStoreRecommand.PictureStoreRawID = product.PictureStoreID;
            pictureStoreRecommand.PictureStoreName = product.PictureStoreName;
            pictureStoreRecommand.PictureStoreRawUrl = product.PictureStoreRawUrl;
            pictureStoreRecommand.PictureStoreLittleUrl = product.PictureStoreLittleUrl;
            pictureStoreRecommand.PictureStoreTagIDs = product.PictureStoreTagIDs;
            pictureStoreRecommand.PictureStoreDescription = product.PictureStoreDescription;
            pictureStoreRecommand.PictureStoreHairEngineerIDs = product.PictureStoreHairEngineerIDs;
            pictureStoreRecommand.PictureStoreHairShopIDs = product.PictureStoreHairShopIDs;
            pictureStoreRecommand.PictureStoreCreateTime = product.PictureStoreCreateTime;
            pictureStoreRecommand.PictureStoreGroupIDs = product.PictureStoreGroupIDs;
            pictureStoreRecommand.PictureStoreRecommandEx = pictureStoreRecommandEx;
            pictureStoreRecommand.PictureStoreRecommandInfo = pictureStoreRecommandInfo;

            if (ProviderFactory.GetPictureStoreDataProviderInstance().PictureStoreRecommandCreateDeleteUpdate(pictureStoreRecommand, ua))
            {
                result = true;
            }

            return result;
        }
        /// <summary>
        /// 删除美发厅
        /// </summary>
        /// <param name="hairShopID"></param>
        /// <returns></returns>
        public static bool DeleteHairShop(int hairShopID)
        {
            HairShop hairshop = new HairShop();
            hairshop.HairShopID = hairShopID;

            return ProviderFactory.GetHairShopDataProviderInstance().HairShopDataPrividerCreateDeleteUpdate(hairshop, UserAction.Delete);
        }
        /// <summary>
        /// 删除美发师
        /// </summary>
        /// <param name="hairEngineerID"></param>
        /// <returns></returns>
        public static bool DeleteHairEngineer(int hairEngineerID)
        {
            HairEngineer hairEngineer = new HairEngineer();
            hairEngineer.HairEngineerID = hairEngineerID;
            int outID = 0;
            return ProviderFactory.GetHairEngineerDataProviderInstance().HairEngineerCreateDeleteUpdate(hairEngineer, UserAction.Delete, out outID);
        }
        /// <summary>
        /// 删除美发产品
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public static bool DeleteProduct(int productID)
        {
            Product product = new Product();
            product.ProductID = productID;
            int tmp = 0;
            return ProviderFactory.GetProductDataProviderInstance().ProductCreateDeleteUpdate(product, UserAction.Delete, out tmp);
        }

        /// <summary>
        /// 删除图片库信息
        /// </summary>
        /// <param name="pictureStoreID"></param>
        /// <returns></returns>
        public static bool DeletePictureStore(int pictureStoreID)
        {
            PictureStore pictureStore = new PictureStore();
            pictureStore.PictureStoreID = pictureStoreID;

            return ProviderFactory.GetPictureStoreDataProviderInstance().PictureStoreCreateDeleteUpdate(pictureStore, UserAction.Delete);
        }
        public static List<HairEngineerComment> GetHairEngineerComments(int count)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerComments(count);
        }
        public static List<HairEngineerComment> GetHairEngineerCommentsByKeyText(int count, string keyText)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerCommentsByKeyText(count, keyText);
        }
        public static bool DeleteHairEngineerCommentByHairEngineerCommentID(int hairEngineerCommentID)
        {
            HairEngineerComment hairEngineerComment = new HairEngineerComment();
            hairEngineerComment.CommentID = hairEngineerCommentID;
            return ProviderFactory.GetHairEngineerDataProviderInstance().HairEngineerCommentCreateDeleteUpdate(hairEngineerComment, UserAction.Delete);
        }
        public static List<HairEngineerComment> GetHairEngineerCommentsByTimeZone(int count, string sTime, string eTime)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerCommentsByTimeZone(count, sTime, eTime);
        }

        public static List<HairShopComment> GetHairShopComments(int count)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShopComments(count);
        }
        public static List<HairShopComment> GetHairShopCommentsByKeyText(int count, string keyText)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShopCommentsByKeyText(count, keyText);
        }
        public static bool DeleteHairShopCommentByHairShopCommentID(int hairShopCommentID)
        {
            HairShopComment hairShopComment = new HairShopComment();
            hairShopComment.CommentID = hairShopCommentID;
            return ProviderFactory.GetHairShopDataProviderInstance().HairShopCommentCreateDeleteUpdate(hairShopComment, UserAction.Delete);
        }
        public static List<HairShopComment> GetHairShopCommentsByTimeZone(int count, string sTime, string eTime)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShopCommentsByTimeZone(count, sTime, eTime);
        }

        public static List<ProductComment> GetProductComments(int count)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProductComments(count);
        }
        public static List<ProductComment> GetProductCommentsByKeyText(int count, string keyText)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProductCommentsByKeyText(count, keyText);
        }
        public static bool DeleteProductCommentByProductCommentID(int productCommentID)
        {
            ProductComment productComment = new ProductComment();
            productComment.CommentID = productCommentID;
            return ProviderFactory.GetProductDataProviderInstance().ProductCommentCreateDeleteUpdate(productComment, UserAction.Delete);
        }
        public static List<ProductComment> GetProductCommentsByTimeZone(int count, string sTime, string eTime)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProductCommentsByTimeZone(count, sTime, eTime);
        }

        public static List<PictureStoreComment> GetPictureStoreComments(int count)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreComments(count);
        }
        public static List<PictureStoreComment> GetPictureStoreCommentsByKeyText(int count, string keyText)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreCommentsByKeyText(count, keyText);
        }
        public static bool DeletePictureStoreCommentByPictureStoreCommentID(int pictureStoreCommentID)
        {
            PictureStoreComment pictureStoreComment = new PictureStoreComment();
            pictureStoreComment.CommentID = pictureStoreCommentID;
            return ProviderFactory.GetPictureStoreDataProviderInstance().PictureStoreCommentCreateDeleteUpdate(pictureStoreComment, UserAction.Delete);
        }
        public static List<PictureStoreComment> GetPictureStoreCommentsByTimeZone(int count, string sTime, string eTime)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreCommentsByTimeZone(count, sTime, eTime);
        }
        /// <summary>
        /// 获取城市列表
        /// </summary>
        /// <returns></returns>
        public static List<City> GetCityItems()
        {
            return ProviderFactory.GetCommonDataProviderInstance().GetCitys();
        }
        /// <summary>
        /// 根据CityID获取区域列表
        /// </summary>
        /// <param name="cityid"></param>
        /// <returns></returns>
        public static List<MapZone> GetMapZoneByCityID(int cityid)
        {
            return ProviderFactory.GetCommonDataProviderInstance().GetMapZonesByCityID(cityid);
        }

        public static List<HotZone> GetHotZoneByMapZoneID(int mapzoneid)
        {
            return ProviderFactory.GetCommonDataProviderInstance().GetHotZonesByMapZoneID(mapzoneid);
        }

        public static List<TypeTable> GetTypeTable()
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetTypeTables();
        }

        public static List<WorkRange> GetWorkRange()
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetWorkRanges();
        }

        [Obsolete("Not the latest version, please refet to AddHairShopInfo method")]
        public static int AddHairShop(HairShop hairShop)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().AddHairShop(hairShop);
        }

        public static void AddHairShopInfo(HairShop hairShop)
        {
            ProviderFactory.GetHairShopDataProviderInstance().HairShopCreateDeleteUpdate(hairShop, UserAction.Create);
        }

        public static void UpdateHairShopInfo(HairShop hairShop)
        {
            ProviderFactory.GetHairShopDataProviderInstance().HairShopCreateDeleteUpdate(hairShop, UserAction.Update);
        }

        public static void DeleteHairShopInfo(HairShop hairShop)
        {
            ProviderFactory.GetHairShopDataProviderInstance().HairShopCreateDeleteUpdate(hairShop, UserAction.Delete);
        }

        [Obsolete("Not the latest version, please refet to UpdateHairShopInfo method")]
        public static bool UpdateHairShop(HairShop hairShop)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().HairShopDataPrividerCreateDeleteUpdate(hairShop, UserAction.Update);
        }

        public static void AddCoupon(Coupon coupon)
        {
            ProviderFactory.GetHairShopDataProviderInstance().CouponCreateDeleteUpdate(coupon, UserAction.Create);
        }

        public static void UpdateCoupon(Coupon coupon)
        {
            ProviderFactory.GetHairShopDataProviderInstance().CouponCreateDeleteUpdate(coupon, UserAction.Update);
        }

        public static void DeleteCoupon(Coupon coupon)
        {
            ProviderFactory.GetHairShopDataProviderInstance().CouponCreateDeleteUpdate(coupon, UserAction.Delete);
        }

        public static bool UpdateProduct(Product product)
        {
            int tmp = 0;
            return ProviderFactory.GetProductDataProviderInstance().ProductCreateDeleteUpdate(product, UserAction.Update, out tmp);
        }

        public static bool UpdatePictureStore(PictureStore ps)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().PictureStoreCreateDeleteUpdate(ps, UserAction.Update);
        }
        public static string GetHairShopTagIDs(string tagNames)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShopTagIDs(tagNames);
        }
        public static string GetHairShopTagNames(string tagIDs)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShopTagNames(tagIDs);
        }
        public static string GetHairEngineerTagNames(string tagIDs)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerTagNames(tagIDs);
        }
        public static List<PictureStoreGroup> GetPictureStoreGroups(int count)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreGroups(count);
        }
        public static string GetPictureStoreTagIDs(string tagNames)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreTagIDs(tagNames);
        }
        public static string GetPictureStoreTagNames(string tagIDs)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreTagNames(tagIDs);
        }
        public static string GetHairEngineerTagIDs(string tagNames)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerTagIDs(tagNames);
        }
        public static int AddPictureStore(PictureStore ps)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().AddPictureStore(ps);
        }

        /// <summary>
        /// 设置图片标签里对应的图片ID
        /// </summary>
        /// <param name="PictureStoreID">图片ID</param>
        /// <param name="PictureStoreTagID">标签ID</param>
        public static void SetPictureStoreTag(int PictureStoreID, int PictureStoreTagID)
        {
            PictureStoreTag pst = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreTagByPictureStoreTagID(PictureStoreTagID);
            string[] pic_ids = pst.PictureStoreIDs.Split(',');
            if (!ArrayIsExist<string>(PictureStoreID.ToString(), pic_ids))
            {
                if (pst.PictureStoreIDs == "")
                {
                    pst.PictureStoreIDs = PictureStoreID.ToString();
                }
                else
                {
                    pst.PictureStoreIDs += "," + PictureStoreID.ToString();
                }
                ProviderFactory.GetPictureStoreDataProviderInstance().PictureStoreTagCreateDeleteUpdate(pst, UserAction.Update);
            }
        }

        public static void SetPictureStoreByHairShop(int HairShopID, int PictureStoreID)
        {
            PictureStore ps = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreByPictureStoreID(PictureStoreID);
            string[] hairshop_ids = ps.PictureStoreHairShopIDs.Split(',');
            if (!ArrayIsExist<string>(HairShopID.ToString(), hairshop_ids))
            {
                if (ps.PictureStoreHairShopIDs == "")
                {
                    ps.PictureStoreHairShopIDs = HairShopID.ToString();
                }
                else
                {
                    ps.PictureStoreHairShopIDs += "," + HairShopID.ToString();
                }
                ProviderFactory.GetPictureStoreDataProviderInstance().PictureStoreCreateDeleteUpdate(ps, UserAction.Update);
            }
        }

        public static void SetHairShopByProduct(int ProductID, int HairShopID)
        {
            HairShop hs = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopByHairShopID(HairShopID);
            string[] product_ids = hs.ProductIDs.Split(',');
            if (!ArrayIsExist<string>(ProductID.ToString(), product_ids))
            {
                if (hs.ProductIDs == "")
                {
                    hs.ProductIDs = ProductID.ToString();
                }
                else
                {
                    hs.ProductIDs += "," + ProductID.ToString();
                }
                ProviderFactory.GetHairShopDataProviderInstance().HairShopDataPrividerCreateDeleteUpdate(hs, UserAction.Update);
            }
        }

        public static void SetPictureStoreByHairEngineer(int HairEngineerID, int PictureStoreID)
        {
            PictureStore ps = ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreByPictureStoreID(PictureStoreID);
            string[] he_ids = ps.PictureStoreHairShopIDs.Split(',');
            if (!ArrayIsExist<string>(HairEngineerID.ToString(), he_ids))
            {
                if (ps.PictureStoreHairShopIDs == "")
                {
                    ps.PictureStoreHairShopIDs = HairEngineerID.ToString();
                }
                else
                {
                    ps.PictureStoreHairShopIDs += "," + HairEngineerID.ToString();
                }
                ProviderFactory.GetPictureStoreDataProviderInstance().PictureStoreCreateDeleteUpdate(ps, UserAction.Update);
            }
        }
        public static void SetHairShopTag(int HairShopID, int HairShopTagID)
        {
            HairShopTag hst = ProviderFactory.GetHairShopDataProviderInstance().GetHairShopTagByHairShopTagID(HairShopTagID);
            string[] tagids = hst.HairShopIDs.Split(',');
            if (!ArrayIsExist<string>(HairShopID.ToString(), tagids))
            {
                if (hst.HairShopIDs == "")
                {
                    hst.HairShopIDs = HairShopID.ToString();
                }
                else
                {
                    hst.HairShopIDs += "," + HairShopID.ToString();
                }
                ProviderFactory.GetHairShopDataProviderInstance().HairShopTagCreateDeleteUpdate(hst, UserAction.Update);
            }
        }

        public static void SetProductTag(int ProductID, int ProductTagID)
        {
            ProductTag pt = ProviderFactory.GetProductDataProviderInstance().GetProductTagByProductTagID(ProductTagID);
            string[] tagids = pt.ProductIDs.Split(',');
            if (!ArrayIsExist<string>(ProductID.ToString(), tagids))
            {
                if (pt.ProductIDs == "")
                {
                    pt.ProductIDs = ProductID.ToString();
                }
                else
                {
                    pt.ProductIDs += "," + ProductID.ToString();
                }
                ProviderFactory.GetProductDataProviderInstance().ProductTagCreateDeleteUpdate(pt, UserAction.Update);
            }
        }

        public static void SetHairEngineerTag(int HairEngineerID, int HairEngineerTagID)
        {
            HairEngineerTag het = ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerTagByHairEngineerTagID(HairEngineerTagID);
            string[] tagids = het.HairEngineerIDs.Split(',');
            if (!ArrayIsExist<string>(HairEngineerID.ToString(), tagids))
            {
                if (het.HairEngineerIDs == "")
                {
                    het.HairEngineerIDs = HairEngineerID.ToString();
                }
                else
                {
                    het.HairEngineerIDs += "," + HairEngineerID.ToString();
                }
                ProviderFactory.GetHairEngineerDataProviderInstance().HairEngineerTagCreateDeleteUpdate(het, UserAction.Update);
            }
        }

        private static bool ArrayIsExist<T>(T p, T[] pn) where T : class, IEnumerable
        {
            bool isExist = false;
            foreach (T o in pn)
            {
                if (o == p)
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }

        public static PictureStore GetPictureStoreByPictureStoreID(int id)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStoreByPictureStoreID(id);
        }

        public static List<HairEngineerClass> GetHairEngineerClasses()
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerClasses();
        }

        public static int AddHairEngineer(HairEngineer he)
        {
            int hairEngineerID = 0;
            ProviderFactory.GetHairEngineerDataProviderInstance().HairEngineerCreateDeleteUpdate(he, UserAction.Create, out hairEngineerID);
            return hairEngineerID;
        }

        public static int AddProduct(Product product)
        {
            int productID = 0;
            ProviderFactory.GetProductDataProviderInstance().ProductCreateDeleteUpdate(product, UserAction.Create, out productID);
            return productID;
        }

        public static bool UpdateHairEngineer(HairEngineer he)
        {
            int tmp = 0;
            return ProviderFactory.GetHairEngineerDataProviderInstance().HairEngineerCreateDeleteUpdate(he, UserAction.Update, out tmp);
        }

        public static HairEngineer GetHairEngineerByHairEngineerID(int HairEngineerID)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerByHairEngineerID(HairEngineerID);
        }

        /// <summary>
        /// Add HairStyle Entity
        /// </summary>
        /// <param name="HairStyleEnt"></param>
        public static void AddHairStyle(HairStyleEntity HairStyleEnt)
        {
            ProviderFactory.GetHairEngineerDataProviderInstance().HairStyleCreateDeleteUpdate(HairStyleEnt, UserAction.Create);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="HairStyleEnt"></param>
        public static void UpdateHairStyle(HairStyleEntity HairStyleEnt)
        {
            ProviderFactory.GetHairEngineerDataProviderInstance().HairStyleCreateDeleteUpdate(HairStyleEnt, UserAction.Update);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="HairStyleEnt"></param>
        public static void DeleteHairStyle(HairStyleEntity HairStyleEnt)
        {
            ProviderFactory.GetHairEngineerDataProviderInstance().HairStyleCreateDeleteUpdate(HairStyleEnt, UserAction.Delete);
        }

        /// <summary>
        /// 获取发型表
        /// </summary>
        /// <param name="hairStyleName">发型名字</param>
        /// <returns></returns>
        public static List<HairStyleEntity> GetHairStyleListByName(string hairStyleName)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairStyleListByName( hairStyleName);    
        }

        /// <summary>
        /// 获取发型表
        /// </summary>
        /// <param name="hairStyleName"></param>
        /// <returns></returns>
        /// <author>zhh</author>
        /// <date>2008.10.5</date>
        public static List<HairStyleEntity> GetHairStyleList()
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairStyleList();

        }  
        /// <summary>
        /// 获取发型表
        /// </summary>
        /// <param name="hairStyleName"></param>
        /// <returns></returns>
        /// <author>zhh</author>
        /// <date>2008.10.5</date>
        public static List<HairStyleEntity> GetHairStyleListByID(int ID)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairStyleListByID( ID);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable GetCouponList()
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetCouponList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="couponID"></param>
        public static void DeleteCoupon(String couponID)
        {
            ProviderFactory.GetHairShopDataProviderInstance().DeleteCoupon(couponID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="HairEngineerID">HairEngineerID</param>
        /// <returns></returns>
        public static DataTable GetHairEngineerInfoByID(String HairEngineerID)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineerInfoByID(Int32.Parse(HairEngineerID));
        }

        public static bool DeleteHairStyle(int hairStyleID)
        {
            HairStyleEntity hs = new HairStyleEntity(hairStyleID);
             ProviderFactory.GetHairEngineerDataProviderInstance().HairStyleCreateDeleteUpdate(hs, UserAction.Delete);
            return true;
            //throw new NotImplementedException();
        }
    }
}
