using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class ArticleTag:TagBase
    {
        #region Fields

        private string _articleIDs = string.Empty;

        #endregion

        #region Properties

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
