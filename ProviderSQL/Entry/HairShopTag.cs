using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class HairShopTag : TagBase
    {
        #region Fields

        private string _hairShopIDs = string.Empty;

        #endregion

        #region Properties

        public string HairShopIDs
        {
            set { this._hairShopIDs = value; }
            get { return this._hairShopIDs; }
        }

        #endregion

        #region Methods
        #endregion
    }
}
