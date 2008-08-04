using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class ProductTag:TagBase
    {
        #region Fields

        private string _productIDs = string.Empty;

        #endregion

        #region Properties

        public string ProductIDs
        {
            set { this._productIDs = value; }
            get { return this._productIDs; }
        }

        #endregion

        #region Methods
        #endregion
    }
}
