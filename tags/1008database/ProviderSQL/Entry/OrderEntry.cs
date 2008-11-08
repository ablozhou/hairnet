using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class OrderEntry
    {
        #region Fields
        private int _orderID = 0;
        private DateTime _orderCreateTime = DateTime.Now;
        private int _userID = 0;
        private string _userName = string.Empty;
        private string _userPhoneNum = string.Empty;
        private int _orderStatus = 0;
        private int _channelID = 0;
        private int _productID1 = 0;
        private int _productID2 = 0;
        private int _productID3 = 0;
        private int _referenceUserID = 0;
        #endregion

        #region Properties
        public int OrderID
        {
            set { this._orderID = value; }
            get { return this._orderID; }
        }

        public DateTime OrderCreateTime
        {
            set { this._orderCreateTime = value; }
            get { return this._orderCreateTime; }
        }

        public int UserID
        {
            set { this._userID = value; }
            get { return this._userID; }
        }

        public string UserName
        {
            set { this._userName = value; }
            get { return this._userName; }
        }

        public string UserPhoneNum
        {
            set { this._userPhoneNum = value; }
            get { return this._userPhoneNum; }
        }

        public int OrderStatus
        {
            set { this._orderStatus = value; }
            get { return this._orderStatus; }
        }

        public int ChannelID
        {
            set { this._channelID = value; }
            get { return this._channelID; }
        }

        public int ProductID1
        {
            set { this._productID1 = value; }
            get { return this._productID1; }
        }

        public int ProductID2
        {
            set { this._productID2 = value; }
            get { return this._productID2; }
        }

        public int ProductID3
        {
            set { this._productID3 = value; }
            get { return this._productID3; }
        }

        public int ReferenceUserID
        {
            set { this._referenceUserID = value; }
            get { return this._referenceUserID; }
        }
        #endregion

        #region Methods
        #endregion
    }
}
