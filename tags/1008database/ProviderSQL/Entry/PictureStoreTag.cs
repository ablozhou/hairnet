using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class PictureStoreTag:TagBase
    {
        #region Fields

        private string _pictureStoreIDs = string.Empty;

        #endregion

        #region Properties

        public string PictureStoreIDs
        {
            set { this._pictureStoreIDs = value; }
            get { return this._pictureStoreIDs; }
        }

        #endregion

        #region Methods
        #endregion
    }
}
