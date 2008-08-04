using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class HairNetTag:TagBase
    {
        #region Fields

        private int _hairNetTagGroupID = 0;

        #endregion

        #region Properties

        public int HairNetTagGroupID
        {
            set { this._hairNetTagGroupID = value; }
            get { return this._hairNetTagGroupID; }
        }

        #endregion

        #region Methods
        #endregion
    }
}
