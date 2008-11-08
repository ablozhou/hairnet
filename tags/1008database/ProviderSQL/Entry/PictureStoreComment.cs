using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class PictureStoreComment:CommentBase
    {
        #region PictureStoreComment Fields

        private int _pictureStoreID = 0;

        #endregion

        #region PictureStoreComment Properties

        public int PictureStoreID
        {
            set { this._pictureStoreID = value; }
            get { return this._pictureStoreID; }
        }

        #endregion

        #region PictureStoreComment Methods
        #endregion
    }
}
