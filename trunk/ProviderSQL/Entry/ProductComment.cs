using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class ProductComment:CommentBase
    {
        #region ProductComment Fields

        private int _productID = 0;

        #endregion

        #region ProductComment Properties

        public int ProductID
        {
            set { this._productID = value; }
            get { return this._productID; }
        }

        #endregion

        #region ProductComment Methods
        #endregion
    }
}
