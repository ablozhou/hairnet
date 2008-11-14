using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    [Serializable()]
    public class PictureStore
    {
        #region PictureStore Fields

        private int _pictureStoreID = 0;
        private string _pictureStoreName = string.Empty;
        //private string _pictureStoreRawUrl = string.Empty;
        //private string _pictureStoreLittleUrl = string.Empty;
        private string _pictureStoreTagIDs = string.Empty;
        //private int _pictureStoreHits = 0;
        private string _pictureStoreDescription = string.Empty;
        //private string _pictureStoreHairEngineerIDs = string.Empty;
        //private string _pictureStoreHairShopIDs = string.Empty;
        private DateTime _pictureStoreCreateTime = DateTime.Now;
        private string _pictureStoreGroupIDs = string.Empty;

        #endregion

        #region PictureStore Properties
        public int PictureStoreID
        {
            set { this._pictureStoreID = value; }
            get { return this._pictureStoreID; }
        }

        public string PictureStoreName
        {
            set { this._pictureStoreName = value; }
            get { return this._pictureStoreName; }
        }

        //public string PictureStoreRawUrl
        //{
        //    set { this._pictureStoreRawUrl = value; }
        //    get { return this._pictureStoreRawUrl; }
        //}

        //public string PictureStoreLittleUrl
        //{
        //    set { this._pictureStoreLittleUrl = value; }
        //    get { return this._pictureStoreLittleUrl; }
        //}

        public string PictureStoreTagIDs
        {
            set { this._pictureStoreTagIDs = value; }
            get { return this._pictureStoreTagIDs; }
        }

        //public int PictureStoreHits
        //{
        //    set { this._pictureStoreHits = value; }
        //    get { return this._pictureStoreHits; }
        //}

        public string PictureStoreDescription
        {
            set { this._pictureStoreDescription = value; }
            get { return this._pictureStoreDescription; }
        }

        //public string PictureStoreHairEngineerIDs
        //{
        //    set { this._pictureStoreHairEngineerIDs = value; }
        //    get { return this._pictureStoreHairEngineerIDs; }
        //}

        //public string PictureStoreHairShopIDs
        //{
        //    set { this._pictureStoreHairShopIDs = value; }
        //    get { return this._pictureStoreHairShopIDs; }
        //}

        public DateTime PictureStoreCreateTime
        {
            set { this._pictureStoreCreateTime = value; }
            get { return this._pictureStoreCreateTime; }
        }

        public string PictureStoreGroupIDs
        {
            set { this._pictureStoreGroupIDs = value; }
            get { return this._pictureStoreGroupIDs; }
        }
        #endregion

        #region PictureStore Methods
        #endregion
    }
}
