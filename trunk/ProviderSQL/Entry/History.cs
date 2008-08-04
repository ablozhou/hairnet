using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class History
    {
        #region Fields
        private int _historyID = 0;
        private int _channelID = 0;
        private DateTime _historyCreateTime = DateTime.Now;
        private string _historyUrl = string.Empty;
        private string _productName = string.Empty;
        private string _historyAction = string.Empty;
        private int _userId = 0;
        private string _historySummary = string.Empty;
        #endregion

        #region Properties
        public int HistoryID
        {
            set { this._historyID = value; }
            get { return this._historyID; }
        }
        public int ChannelID
        {
            set { this._channelID = value; }
            get { return this._channelID; }
        }

        public DateTime HistoryCreateTime
        {
            set { this._historyCreateTime = value; }
            get { return this._historyCreateTime; }
        }

        public string HistoryUrl
        {
            set { this.HistoryUrl = value; }
            get { return this.HistoryUrl; }
        }

        public string ProductName
        {
            set { this._productName = value; }
            get { return this._productName; }
        }

        public string HistoryAction
        {
            set { this._historyAction = value; }
            get { return this._historyAction; }
        }

        public int UserID
        {
            set { this._userId = value; }
            get { return this._userId; }
        }

        public string HistorySummary
        {
            set { this._historySummary = value; }
            get { return this._historySummary; }
        }
        #endregion

        #region Methods
        #endregion
    }
}
