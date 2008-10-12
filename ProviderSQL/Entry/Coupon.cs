using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class Coupon
    {
        private int id = 0;
        private string name = string.Empty;
        private int hairShopID = 0;
        private string discount = string.Empty;
        private string expiredDate = string.Empty;
        private string phoneNumber = string.Empty;
        private string couponTag = string.Empty;
        private string description = string.Empty;
        private string imageUrl = string.Empty;
        private int _postID = 0;
        private string _imageSmallUrl = string.Empty;

        public int PostID
        {
            set { this._postID = value; }
            get { return this._postID; }
        }

        public string ImageSmallUrl
        {
            set { this._imageSmallUrl = value; }
            get { return this._imageSmallUrl; }
        }        

        public Coupon(int id, string name, int hairShopID, string discount, string expiredDate, string phoneNumber, string couponTag,
            string description)
        {
            this.id = id;
            this.name = name;
            this.hairShopID = hairShopID;
            this.discount = discount;
            this.expiredDate = expiredDate;
            this.phoneNumber = phoneNumber;
            this.couponTag = couponTag;
            this.description = description;
        }
        public Coupon(int id, string name, int hairShopID, string discount, string expiredDate, string phoneNumber, string couponTag,
            string description,string url,int postID,string imageSmallUrl)
        {
            this.id = id;
            this.name = name;
            this.hairShopID = hairShopID;
            this.discount = discount;
            this.expiredDate = expiredDate;
            this.phoneNumber = phoneNumber;
            this.couponTag = couponTag;
            this.description = description;
            this.imageUrl = url;
            this.PostID = postID;
            this.ImageSmallUrl = imageSmallUrl;
        }
        public string ImageUrl
        {
            set { this.imageUrl = value; }
            get { return this.imageUrl; }
        }
        public Int32 ID
        {
            set { id = value; }
            get { return id; }
        }

        public String Name
        {
            set { name = value; }
            get { return name; }
        }

        public Int32 HairShopID
        {
            set { hairShopID = value; }
            get { return hairShopID; }
        }

        public String Discount
        {
            set { discount = value; }
            get { return discount; }
        }

        public String ExpiredDate
        {
            set { expiredDate = value; }
            get { return expiredDate; }
        }

        public String PhoneNumber
        {
            set { phoneNumber = value; }
            get { return phoneNumber; }
        }

        public String CouponTag
        {
            set { couponTag = value; }
            get { return couponTag; }
        }

        public String Description
        {
            set { description = value; }
            get { return description; }
        }
    }
}
