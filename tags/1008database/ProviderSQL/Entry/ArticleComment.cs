using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class ArticleComment:CommentBase
    {
        #region ArticleComment Fields

        private int _articleID = 0;

        #endregion

        #region ArticleComment Properties

        public int ArticleID
        {
            set { this._articleID = value; }
            get { return this._articleID; }
        }

        #endregion

        #region ArticleComment Methods
        #endregion
    }
}
