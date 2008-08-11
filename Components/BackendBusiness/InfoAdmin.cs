﻿using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Provider;
using HairNet.Enumerations;

namespace HairNet.Business
{
    public class InfoAdmin
    {
        /// <summary>
        /// 获得美发厅信息列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<HairShop> GetHairShops(int count)
        {
            return ProviderFactory.GetHairShopDataProviderInstance().GetHairShops(count);  
        }

        /// <summary>
        /// 获得美发师信息列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<HairEngineer> GetHairEngineers(int count)
        {
            return ProviderFactory.GetHairEngineerDataProviderInstance().GetHairEngineers(count);
        }

        /// <summary>
        /// 获得美发产品列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<Product> GetProducts(int count)
        {
            return ProviderFactory.GetProductDataProviderInstance().GetProducts(count);  
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
        public static List<PictureStore> GetPictureStores(int count)
        {
            return ProviderFactory.GetPictureStoreDataProviderInstance().GetPictureStores(count);
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
        public static bool RecommandHairEngineer(int hairEngineerID,int hairEngineerRecommandID,string hairEngineerRecommandInfo,string hairEngineerRecommandEx,UserAction ua)
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

            return ProviderFactory.GetHairEngineerDataProviderInstance().HairEngineerCreateDeleteUpdate(hairEngineer, UserAction.Delete);
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

            return ProviderFactory.GetProductDataProviderInstance().ProductCreateDeleteUpdate(product, UserAction.Delete);
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
    }
}
