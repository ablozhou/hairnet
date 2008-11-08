using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class Article
    {
        #region Article Fields

        private int _articleID = 0;
        private string _articleTitle = string.Empty;
        private string _articleAuthor = string.Empty;
        private string _articleContent = string.Empty;
        private string _articleTagIDs = string.Empty;
        private int _articleDigNum = 0;
        private string _articleOutLink = string.Empty;
        private string _articleSource = string.Empty;
        private DateTime _articlePublishDate = DateTime.Now;
        private int _articleGroupID = 0;

        #endregion

        #region Article Properties

        public int ArticleID
        {
            set { this._articleID = value; }
            get { return this._articleID; }
        }

        public string ArticleTitle
        {
            set { this._articleTitle = value; }
            get { return this._articleTitle; }
        }

        public string ArticleAuthor
        {
            set { this._articleAuthor = value; }
            get { return this._articleAuthor; }
        }

        public string ArticleContent
        {
            set { this._articleContent = value; }
            get { return this._articleContent; }
        }

        public string ArticleTagIDs
        {
            set { this._articleTagIDs = value; }
            get { return this._articleTagIDs; }
        }

        public int ArticleDigNum
        {
            set { this._articleDigNum = value; }
            get { return this._articleDigNum; }
        }

        public string ArticleOutLink
        {
            set { this._articleOutLink = value; }
            get { return this._articleOutLink; }
        }

        public string ArticleSource
        {
            set { this._articleSource = value; }
            get { return this._articleSource; }
        }

        public DateTime ArticlePublishDate
        {
            set { this._articlePublishDate = value; }
            get { return this._articlePublishDate; }
        }

        public int ArticleGroupID
        {
            set { this._articleGroupID = value; }
            get { return this._articleGroupID; }
        }

        #endregion

        #region Article Methods
        #endregion
    }
}
