using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class CommentBase
    {
        #region CommentBase Fields
        private int _commentID = 0;
        private string _commentText = string.Empty;
        private DateTime _commentCreateTime = DateTime.Now;
        private int _userID = 0;
        private string _userName = string.Empty;
        private string _userAddress = string.Empty;

        #endregion

        #region CommentBase Properties

        public int CommentID
        {
            set { this._commentID = value; }
            get { return this._commentID; }
        }

        public string CommentText
        {
            set { this._commentText = value; }
            get { return this._commentText; }
        }

        public DateTime CommentCreateTime
        {
            set { this._commentCreateTime = value; }
            get { return this._commentCreateTime; }
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

        public string UserAddress
        {
            set { this._userAddress = value; }
            get { return this._userAddress; }
        }

        #endregion

        #region CommentBase Methods
        #endregion
    }
}
