using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class GroupBase
    {
        #region Fields

        private int _id = 0;
        private string _name = string.Empty;

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

        #endregion

        #region Methods
        #endregion
    }
}
