using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class HairNetTagGroup:GroupBase
    {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Methods
        #endregion
    }
    public class PictureStoreGroup : GroupBase
    {
        #region Fields

        private int _pictureStoreGroupParentID = 0;
        private string _pictureStoreIDs = string.Empty;

        #endregion

        #region Properties

        public int PictureStoreGroupParentID
        {
            set { this._pictureStoreGroupParentID = value; }
            get { return this._pictureStoreGroupParentID; }
        }

        public string PictureStoreIDs
        {
            set { this._pictureStoreIDs = value; }
            get { return this._pictureStoreIDs; }
        }

        #endregion

        #region Methods
        #endregion
    }
    public class ArticleGroup : GroupBase
    {
        #region Fields

        private int _articleGroupParentID = 0;
        private string _articleIDs = string.Empty;

        #endregion

        #region Properties

        public int ArticleGroupParentID
        {
            set { this._articleGroupParentID = value; }
            get { return this._articleGroupParentID; }
        }

        public string ArticleIDs
        {
            set { this._articleIDs = value; }
            get { return this._articleIDs; }
        }

        #endregion

        #region Methods
        #endregion
    }
}
