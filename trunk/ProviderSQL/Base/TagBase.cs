using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class TagBase
    {
        #region Fields

        private int _tagID = 0;
        private string _tagName = string.Empty;

        #endregion

        #region Properties
        public int TagID
        {
            set { this._tagID = value; }
            get { return this._tagID; }
        }

        public string TagName
        {
            set { this._tagName = value; }
            get { return this._tagName; }
        }

        #endregion

        #region Methods
        #endregion
    }
}
