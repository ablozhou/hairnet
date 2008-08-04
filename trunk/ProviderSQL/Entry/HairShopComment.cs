using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class HairShopComment : CommentBase
    {
        #region HairShopComment Fields

        private int _hairShopID = 0;
        private bool _isGood = false;

        #endregion

        #region HairShopComment Properties

        public int HairShopID
        {
            set { this._hairShopID = value; }
            get { return this._hairShopID; }
        }

        public bool IsGood
        {
            set { this._isGood = value; }
            get { return this._isGood; }
        }

        #endregion

        #region HairShopComment Methods
        #endregion
    }
}
