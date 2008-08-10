using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class TempEmail
    {
        #region Fields
        private int _tempEmailID = 0;
        private string _tempEmailName = string.Empty;
        private bool _tempEmailIsSend = false;
        private DateTime _tempEmailCreateTime = DateTime.Now;
        #endregion

        #region Properties
        public int TempEmailID
        {
            set { this._tempEmailID = value; }
            get { return this._tempEmailID; }
        }

        public string TempEmailName
        {
            set { this._tempEmailName = value; }
            get { return this._tempEmailName; }
        }

        public bool TempEmailIsSend
        {
            set { this._tempEmailIsSend = value; }
            get { return this._tempEmailIsSend; }
        }

        public DateTime TempEmailCreateTime
        {
            set { this._tempEmailCreateTime = value; }
            get { return this._tempEmailCreateTime; }
        }
        #endregion

        #region Methods
        #endregion
    }
}
