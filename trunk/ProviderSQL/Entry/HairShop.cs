using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Provider;

namespace HairNet.Entry
{
    [Serializable()]
    public class HairShop
    {
        #region HairShop Fields

        private int _hairShopID =0;
        private string _hairShopName = string.Empty;
        private int _hairShopCityID = 0;
        private string _hairShopCityName = string.Empty;
        private int _hairShopMapZoneID = 0;
        private string _hairShopMapZoneName = string.Empty;
        private int _hairShopHotZoneID = 0;
        private string _hairShopHotZoneName = string.Empty;
        private string _hairShopAddress = string.Empty;
        private string _hairShopPhoneNum = string.Empty;
        private string _hairShopPictureStoreIDs = string.Empty;
        private string _hairShopMainIDs = string.Empty;
        private string _hairShopPartialIDs = string.Empty;
        private int _hairShopEngineerNum = 0;
        private string _hairShopOpenTime = string.Empty;
        private int _hairShopOrderNum = 0;
        private int _hairShopVisitNum = 0;
        private string _workRangeIDs = string.Empty;
        private string _hairShopWebSite = string.Empty;
        private string _hairShopEmail = string.Empty;
        private string _hairShopDiscount = string.Empty;
        private string _hairShopLogo = string.Empty;
        private int _hairShopRecommandNum = 0;
        private string _hairShopCreateTime = string.Empty;
        private string _hairShopDescription = string.Empty;
        private string _productIDs = string.Empty;
        private string _hairShopTagIDs = string.Empty;
        private string _hairshopShortName = string.Empty;
        private bool _isBest = false;
        private bool _isJoin = false;
        private int _typeID = 0;
        private string _typeName = string.Empty;
        private bool _isPostStation = false;
        private bool _isPostMachine = false;
        private int _hairShopGood = 0;
        private int _hairShopBad = 0;

        #endregion

        #region HairShop Properties

        public int HairShopID
        {
            set{this._hairShopID = value;}
            get{return this._hairShopID;}
        }

        
        public string HairShopName
        {
            set { this._hairShopName = value; }
            get { return this._hairShopName; }
        }

        
        public int HairShopCityID
        {
            set { this._hairShopCityID = value; }
            get { return this._hairShopCityID; }
        }

        
        public string HairShopCityName
        {
            set { this._hairShopCityName = value; }
            get { return this._hairShopCityName; }
        }

        
        public int HairShopMapZoneID
        {
            set { this._hairShopMapZoneID = value; }
            get { return this._hairShopMapZoneID; }
        }

        
        public string HairShopMapZoneName
        {
            set { this._hairShopMapZoneName = value; }
            get { return this._hairShopMapZoneName; }
        }

        
        public int HairShopHotZoneID
        {
            set { this._hairShopHotZoneID = value; }
            get { return this._hairShopHotZoneID; }
        }

        
        public string HairShopHotZoneName
        {
            set { this._hairShopHotZoneName = value; }
            get { return this._hairShopHotZoneName; }
        }

        public string HairShopAddress
        {
            set { this._hairShopAddress = value; }
            get { return this._hairShopAddress; }
        }

        public string HairShopPhoneNum
        {
            set { this._hairShopPhoneNum = value; }
            get { return this._hairShopPhoneNum; }
        }

        public string HairShopPictureStoreIDs
        {
            set { this._hairShopPictureStoreIDs = value; }
            get { return this._hairShopPictureStoreIDs; }
        }

        public string HairShopMainIDs
        {
            set { this._hairShopMainIDs = value; }
            get { return this._hairShopMainIDs; }
        }

        public string HairShopPartialIDs
        {
            set { this._hairShopPartialIDs = value; }
            get { return this._hairShopPartialIDs; }
        }

        public int HairShopEngineerNum
        {
            set { this._hairShopEngineerNum = value; }
            get { return this._hairShopEngineerNum; }
        }

        public string HairShopOpenTime
        {
            set { this._hairShopOpenTime = value; }
            get { return this._hairShopOpenTime; }
        }

        public int HairShopOrderNum
        {
            set { this._hairShopOrderNum = value; }
            get { return this._hairShopOrderNum; }
        }

        public int HairShopVisitNum
        {
            set { this._hairShopVisitNum = value; }
            get { return this._hairShopVisitNum; }
        }

        public string WorkRangeIDs
        {
            set { this._workRangeIDs = value; }
            get { return this._workRangeIDs; }
        }

        public string HairShopWebSite
        {
            set { this._hairShopWebSite = value; }
            get { return this._hairShopWebSite; }
        }

        public string HairShopEmail
        {
            set { this._hairShopEmail = value; }
            get { return this._hairShopEmail; }
        }

        public string HairShopDiscount
        {
            set { this._hairShopDiscount = value; }
            get { return this._hairShopDiscount; }
        }

        public string HairShopLogo
        {
            set { this._hairShopLogo = value; }
            get { return this._hairShopLogo; }
        }

        public int HairShopRecommandNum
        {
            set { this._hairShopRecommandNum = value; }
            get { return this._hairShopRecommandNum; }
        }

        public string HairShopCreateTime
        {
            set { this._hairShopCreateTime = value; }
            get { return this._hairShopCreateTime; }
        }

        public string HairShopDescription
        {
            set { this._hairShopDescription = value; }
            get { return this._hairShopDescription; }
        }

        public string ProductIDs
        {
            set { this._productIDs = value; }
            get { return this._productIDs; }
        }

        public string HairShopTagIDs
        {
            set { this._hairShopTagIDs = value; }
            get { return this._hairShopTagIDs; }
        }

        public string HairShopShortName
        {
            set { this._hairshopShortName = value; }
            get { return this._hairshopShortName; }
        }

        public bool IsBest
        {
            set { this._isBest = value; }
            get { return this._isBest; }
        }

        public bool IsJoin
        {
            set { this._isJoin = value; }
            get { return this._isJoin; }
        }

        public int TypeID
        {
            set { this._typeID = value; }
            get { return this._typeID; }
        }
        public string TypeName
        {
            set { this._typeName = value; }
            get { return this._typeName; }
        }

        public bool IsPostStation
        {
            set { this._isPostStation = value; }
            get { return this._isPostStation; }
        }

        public bool IsPostMachine
        {
            set { this._isPostMachine = value; }
            get { return this._isPostMachine; }
        }

        public int HairShopGood
        {
            set { this._hairShopGood = value; }
            get { return this._hairShopGood; }
        }

        public int HairShopBad
        {
            set { this._hairShopBad = value; }
            get { return this._hairShopBad; }
        }
        #endregion

        #region HairShop Methods

        //Todo

        #endregion
    }
}
