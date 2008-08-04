using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class Product
    {
        #region Product Fields

        private int _productID = 0;
        private string _productName = string.Empty;
        private string _productCompany = string.Empty;
        private string _productCompanyDescription = string.Empty;
        private string _productPictureStoreIDs = string.Empty;
        private int _productHits = 0;
        private string _productDescription = string.Empty;
        private string _hairShopIDs = string.Empty;
        private string _productRawPrice = string.Empty;
        private string _productPrice = string.Empty;
        private string _productDiscount = string.Empty;
        private string _productTagIDs = string.Empty;

        #endregion

        #region Product Properties

        public int ProductID
        {
            set { this._productID = value; }
            get { return this._productID; }
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

        public int ProductHits
        {
            set { this._productHits = value; }
            get { return this._productHits; }
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
            set { this.ProductRawPrice = value; }
            get { return this.ProductRawPrice; }
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
        

        #endregion

        #region Product Methods
        #endregion
    }
}
