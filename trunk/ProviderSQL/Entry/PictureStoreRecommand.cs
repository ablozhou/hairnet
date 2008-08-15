using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class PictureStoreRecommand
    {
        #region PictureStore Fields

        private int _pictureStoreRecommandID = 0;
        private int _pictureStoreRawID = 0;
        private string _pictureStoreName = string.Empty;
        private string _pictureStoreRawUrl = string.Empty;
        private string _pictureStoreLittleUrl = string.Empty;
        private string _pictureStoreTagIDs = string.Empty;
        private int _pictureStoreHits = 0;
        private string _pictureStoreDescription = string.Empty;
        private string _pictureStoreHairEngineerIDs = string.Empty;
        private string _pictureStoreHairShopIDs = string.Empty;
        private DateTime _pictureStoreCreateTime = DateTime.Now;
        private string _pictureStoreGroupIDs = string.Empty;
        private string _pictureStoreRecommandEx = string.Empty;
        private string _pictureStoreRecommandInfo = string.Empty;

        #endregion

        #region PictureStore Properties

        public int PictureStoreRecommandID
        {
            set { this._pictureStoreRecommandID = value; }
            get { return this._pictureStoreRecommandID; }
        }

        public int PictureStoreRawID
        {
            set { this._pictureStoreRawID = value; }
            get { return this._pictureStoreRawID; }
        }

        public string PictureStoreName
        {
            set { this._pictureStoreName = value; }
            get { return this._pictureStoreName; }
        }

        public string PictureStoreRawUrl
        {
            set { this._pictureStoreRawUrl = value; }
            get { return this._pictureStoreRawUrl; }
        }

        public string PictureStoreLittleUrl
        {
            set { this._pictureStoreLittleUrl = value; }
            get { return this._pictureStoreLittleUrl; }
        }

        public string PictureStoreTagIDs
        {
            set { this._pictureStoreTagIDs = value; }
            get { return this._pictureStoreTagIDs; }
        }

        public int PictureStoreHits
        {
            set { this._pictureStoreHits = value; }
            get { return this._pictureStoreHits; }
        }

        public string PictureStoreDescription
        {
            set { this._pictureStoreDescription = value; }
            get { return this._pictureStoreDescription; }
        }

        public string PictureStoreHairEngineerIDs
        {
            set { this._pictureStoreHairEngineerIDs = value; }
            get { return this._pictureStoreHairEngineerIDs; }
        }

        public string PictureStoreHairShopIDs
        {
            set { this._pictureStoreHairShopIDs = value; }
            get { return this._pictureStoreHairShopIDs; }
        }

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

        public string PictureStoreRecommandEx
        {
            set { this._pictureStoreRecommandEx = value; }
            get { return this._pictureStoreRecommandEx; }
        }

        public string PictureStoreRecommandInfo
        {
            set { this._pictureStoreRecommandInfo = value; }
            get { return this._pictureStoreRecommandInfo; }
        }
        #endregion

        #region PictureStore Methods
        #endregion
    }
}
