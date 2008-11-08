using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    [Serializable()]
    public class HairEngineer
    {
        #region HairEngineer Fields

        private int _hairEngineerID = 0;
        private string _hairEngineerName = string.Empty;
        private string _hairEngineerAge = string.Empty;
        private int _hairEngineerSex = 0;
        //private string _hairEngineerPhoto = string.Empty;
        private int _hairShopID = 0;
        private string _hairShopName = string.Empty;
        private string _hairEngineerYear = string.Empty;
        private string _hairEngineerSkill = string.Empty;
        private string _hairEngineerTagIDs = string.Empty;
        private string _hairEngineerPictureStoreIDs = string.Empty;
        private int _hairEngineerHits = 0;
        private string _hairEngineerDescription = string.Empty;
        //private int _hairEngineerOrderNum = 0;
        //private int _hairEngineerRecommandNum = 0;
        private string _hairEngineerRawPrice = string.Empty;
        private string _hairEngineerTel = string.Empty;
        private int _hairEngineerGood = 0;
        private int _hairEngineerBad = 0;
        private string _hairEngineerClassID = "";
        private string _hairEngineerClassName = string.Empty;
        private string _hairEngineerConstellation = String.Empty;
        private bool _isImportant = false;
        private string _hairEngineerPhotoIDs = string.Empty;
        private int _hairEngineerNormal = 0;
        private int _postid = 0;
        #endregion

        #region HairEngineer Properties
        public int PostId
        {
            set { this._postid = value; }
            get { return this._postid; }
        }

        public int HairEngineerNormal
        {
            set { this._hairEngineerNormal = value; }
            get { return this._hairEngineerNormal; }
        }

        public bool IsImportant
        {
            set { this._isImportant = value; }
            get { return this._isImportant; }
        }
        public string HairEngineerPhotoIDs
        {
            set { this._hairEngineerPhotoIDs = value; }
            get { return this._hairEngineerPhotoIDs; }
        }
        public int HairEngineerID
        {
            set { this._hairEngineerID = value; }
            get { return this._hairEngineerID; }
        }

        public string HairEngineerName
        {
            set { this._hairEngineerName = value; }
            get { return this._hairEngineerName; }
        }

        public string HairEngineerAge
        {
            set { this._hairEngineerAge = value; }
            get { return this._hairEngineerAge; }
        }

        public int HairEngineerSex
        {
            set { this._hairEngineerSex = value; }
            get { return this._hairEngineerSex; }
        }

        //public string HairEngineerPhoto
        //{
        //    set { this._hairEngineerPhoto = value; }
        //    get { return this._hairEngineerPhoto; }
        //}

        public int HairShopID
        {
            set { this._hairShopID = value; }
            get { return this._hairShopID; }
        }

        public string HairShopName
        {
            set { this._hairShopName = value; }
            get { return this._hairShopName; }
        }

        public string HairEngineerYear
        {
            set { this._hairEngineerYear = value; }
            get { return this._hairEngineerYear; }
        }

        public string HairEngineerSkill
        {
            set { this._hairEngineerSkill = value; }
            get { return this._hairEngineerSkill; }
        }

        public string HairEngineerTagIDs
        {
            set { this._hairEngineerTagIDs = value; }
            get { return this._hairEngineerTagIDs; }
        }

        public string HairEngineerPictureStoreIDs
        {
            set { this._hairEngineerPictureStoreIDs = value; }
            get { return this._hairEngineerPictureStoreIDs; }
        }

        public int HairEngineerHits
        {
            set { this._hairEngineerHits = value; }
            get { return this._hairEngineerHits; }
        }

        public string HairEngineerDescription
        {
            set { this._hairEngineerDescription = value; }
            get { return this._hairEngineerDescription; }
        }

        //public int HairEngineerOrderNum
        //{
        //    set { this._hairEngineerOrderNum = value; }
        //    get { return this._hairEngineerOrderNum; }
        //}

        //public int HairEngineerRecommandNum
        //{
        //    set { this._hairEngineerRecommandNum = value; }
        //    get { return this._hairEngineerRecommandNum; }
        //}

        public string HairEngineerRawPrice
        {
            set { this._hairEngineerRawPrice = value; }
            get { return this._hairEngineerRawPrice; }
        }

        public string HairEngineerTel
        {
            set { this._hairEngineerTel = value; }
            get { return this._hairEngineerTel; }
        }

        public int HairEngineerGood
        {
            set { this._hairEngineerGood = value; }
            get { return this._hairEngineerGood; }
        }

        public int HairEngineerBad
        {
            set { this._hairEngineerBad = value; }
            get { return this._hairEngineerBad; }
        }

        public string HairEngineerClassID
        {
            set { this._hairEngineerClassID = value; }
            get { return this._hairEngineerClassID; }
        }

        public string HairEngineerClassName
        {
            set { this._hairEngineerClassName = value; }
            get { return this._hairEngineerClassName; }
        }

        public string HairEngineerConstellation
        {
            set { _hairEngineerConstellation = value; }
            get { return _hairEngineerConstellation; }
        }

        #endregion

        #region HairEngineer Methods
        #endregion
    }
}
