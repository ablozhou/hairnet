using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class NameBase
    {
        #region Fields

        private int _id = 0;
        private string _name = string.Empty;
        private bool _isVisible = true;

        #endregion

        #region Properties

        public int ID
        {
            set { this._id = value; }
            get { return this._id; }
        }

        public string Name
        {
            set { this._name = value; }
            get { return this._name; }
        }

        public bool IsVisible
        {
            set { this._isVisible = value; }
            get { return this._isVisible; }
        }

        #endregion

        #region Methods
        #endregion
    }
}
