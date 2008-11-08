using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class HairEngineerComment : CommentBase
    {
        #region HairEngineerComment Fields

        private int _hairEngineerID = 0;
        private bool _isGood = false;

        #endregion

        #region HairEngineerComment Properties

        public int HairEngineerID
        {
            set { this._hairEngineerID = value; }
            get { return this._hairEngineerID; }
        }

        public bool IsGood
        {
            set { this._isGood = value; }
            get { return this._isGood; }
        }

        #endregion

        #region HairEngineerComment Methods
        #endregion
    }
}
