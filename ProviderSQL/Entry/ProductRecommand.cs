using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class ProductRecommand
    {
        #region Product Fields

        private int _productRecommandID = 0;
        private int _productRawID = 0;
        private string _productName = string.Empty;
        private string _productCompany = string.Empty;
        private string _productCompanyDescription = string.Empty;
        private string _productPictureStoreIDs = string.Empty;
        private string _productDescription = string.Empty;
        private string _hairShopIDs = string.Empty;
        private string _productRawPrice = string.Empty;
        private string _productPrice = string.Empty;
        private string _productDiscount = string.Empty;
        private string _productTagIDs = string.Empty;
        private string _productRecommandEx = string.Empty;
        private string _productRecommandInfo = string.Empty;

        private int _productHits = 0;
        #endregion

        #region Product Properties

        public int ProductRecommandID
        {
            set { this._productRecommandID = value; }
            get { return this._productRecommandID; }
        }

        public int ProductRawID
        {
            set { this._productRawID = value; }
            get { return this._productRawID; }
        }

        public string ProductName
        {
            set { this._productName = value; }
            get { return this._productName; }
        }

        public string ProductCompany
        {
            set { this._productCompany = value; }
            get { return this._productCompany; }
        }

        public string ProductCompanyDescription
        {
            set { this._productCompanyDescription = value; }
            get { return this._productCompanyDescription; }
        }

        public string ProductPictureStoreIDs
        {
            set { this._productPictureStoreIDs = value; }
            get { return this._productPictureStoreIDs; }
        }

        public string ProductDescription
        {
            set { this._productDescription = value; }
            get { return this._productDescription; }
        }

        public string HairShopIDs
        {
            set { this._hairShopIDs = value; }
            get { return this._hairShopIDs; }
        }

        public string ProductRawPrice
        {
            set { this._productRawPrice = value; }
            get { return this._productRawPrice; }
        }

        public string ProductPrice
        {
            set { this._productPrice = value; }
            get { return this._productPrice; }
        }

        public string ProductDiscount
        {
            set { this._productDiscount = value; }
            get { return this._productDiscount; }
        }

        public string ProductTagIDs
        {
            set { this._productTagIDs = value; }
            get { return this._productTagIDs; }
        }

        public string ProductRecommandEx
        {
            set { this._productRecommandEx = value; }
            get { return this._productRecommandEx; }
        }

        public string ProductRecommandInfo
        {
            set { this._productRecommandInfo = value; }
            get { return this._productRecommandInfo; }
        }

        public int ProductHits
        {
            set { this._productHits = value; }
            get { return this._productHits; }
        }
        #endregion

        #region Product Methods
        #endregion
    }
}
