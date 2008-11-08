using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class HairEngineerTag:TagBase
    {
        #region Fields

        private string _hairEngineerIDs = string.Empty;

        #endregion

        #region Properties

        public string HairEngineerIDs
        {
            set { this._hairEngineerIDs = value; }
            get { return this._hairEngineerIDs; }
        }

        #endregion

        #region Methods
        #endregion
    }
}
