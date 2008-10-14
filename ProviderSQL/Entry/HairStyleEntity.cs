using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    [Serializable]
    public class HairStyleEntity
    {
        private int id = 0;
        private string hairName = string.Empty;
        private Byte hairStyle = 0;
        private Byte faceStyle = 0;
        private Byte temperament = 1;
        private Byte occasion = 0;
        private Byte sex = 0;
        private string bigPic = string.Empty;
        private string smallPic_F = string.Empty;
        private string smallPic_B = string.Empty;
        private string smallPic_S = string.Empty;

        private string pic1 = string.Empty;
        private string pic2 = string.Empty;
        private string pic3 = string.Empty;
        private int hairShopID = 0;
        private int hairEngineerID = 0;
        private int hairQuantity = 0;
        private Byte hairNature = 0;
        private Byte hairColor = 0;
        private DateTime createTime;
        private string bbsURL = string.Empty;
        private int good = 0;
        private int normal = 0;
        private int bad = 0;
        private string tag = string.Empty;
        private string description = string.Empty;
        private int picturestoreid = 0;
        private string psgids = string.Empty;
        private bool _isHairStyle = false;
        private int _postID = 0;

        public bool IsHairStyle
        {
            set { this._isHairStyle = value; }
            get { return this._isHairStyle; }
        }

        public int PostID
        {
            set { this._postID = value; }
            get { return this._postID; }
        }

        public string PSGIDS
        {
            set { this.psgids = value; }
            get { return this.psgids; }
        }

        public string Description
        {
            set { this.description = value; }
            get { return this.description; }
        }
        public int PictureStoreId
        {
            set { this.picturestoreid = value; }
            get { return this.picturestoreid; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="hairName">hairName</param>
        /// <param name="hairStyle">hairStyle</param>
        /// <param name="faceStyle">faceStyle</param>
        /// <param name="temperament">temperament</param>
        /// <param name="occasion">occasion</param>
        /// <param name="sex">sex</param>
        /// <param name="bigPic">bigPic</param>
        /// <param name="smallPic_F">smallPic_F</param>
        /// <param name="smallPic_B">smallPic_B</param>
        /// <param name="smallPic_S">smallPic_S</param>
        /// <param name="pic1">pic1</param>
        /// <param name="pic2">pic2</param>
        /// <param name="pic3">pic3</param>
        /// <param name="hairShopID">hairShopID</param>
        /// <param name="hairEngineerID">hairEngineerID</param>
        /// <param name="hairQuantity">hairQuantity</param>
        /// <param name="hairNature">hairNature</param>
        /// <param name="hairColor">hairColor</param>
        /// <param name="createTime">createTime</param>
        /// <param name="bbsURL">bbsURL</param>
        /// <param name="good">good</param>
        /// <param name="normal">normal</param>
        /// <param name="bad">bad</param>
        /// <param name="tag">tag</param>
        public HairStyleEntity(int id, string hairName, Byte hairStyle, Byte faceStyle, Byte temperament, Byte occasion, Byte sex,
            string bigPic, string smallPic_F, string smallPic_B, string smallPic_S, string pic1, string pic2, string pic3,
            int hairShopID, int hairEngineerID, int hairQuantity, Byte hairNature, Byte hairColor, DateTime createTime, 
            string bbsURL, int good, int normal, int bad, string tag)
        {
            this.id = id;
            this.hairName = hairName;
            this.hairStyle = hairStyle;
            this.faceStyle = faceStyle;
            this.temperament = temperament;
            this.occasion = occasion;
            this.sex = sex;
            this.bigPic = bigPic;
            this.smallPic_F = smallPic_F;
            this.smallPic_B = smallPic_B;
            this.smallPic_S = smallPic_S;
            this.pic1 = pic1;
            this.pic2 = pic2;
            this.pic3 = pic3;
            this.hairShopID = hairShopID;
            this.hairEngineerID = hairEngineerID;
            this.hairQuantity = hairQuantity;
            this.hairNature = hairNature;
            this.hairColor = hairColor;
            this.createTime = createTime;
            this.bbsURL = bbsURL;
            this.good = good;
            this.normal = normal;
            this.bad = bad;
            this.tag = tag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hairName">hairName</param>
        /// <param name="bigPic">bigPic</param>
        /// <param name="smallPic_F">smallPic_F</param>
        /// <param name="smallPic_B">smallPic_B</param>
        /// <param name="smallPic_S">smallPic_S</param>
        /// <param name="hairStyle">hairStyle</param>
        /// <param name="faceStyle">faceStyle</param>
        /// <param name="hairQuantity">hairQuantity</param>
        /// <param name="hairNature">hairNature</param>
        /// <param name="tag">tag</param>
        public HairStyleEntity(string hairName, int hairQuantity, string bbsUrl, int hairShopID, int hairEngineerID, Byte hairStyle, Byte faceStyle, Byte temperament, Byte occasion, Byte sex, Byte hairNature, string idesc, string ppsgids, bool isHairStyle, int postID)
        {
            this.hairName = hairName;
            this.hairShopID = hairShopID;
            this.hairEngineerID = hairEngineerID;
            this.hairStyle = hairStyle;
            this.faceStyle = faceStyle;
            this.hairQuantity = hairQuantity;
            this.hairNature = hairNature;
            this.temperament = temperament;
            this.occasion = occasion;
            this.sex = sex;
            this.description = idesc;
            this.PSGIDS = ppsgids;
            this.IsHairStyle = isHairStyle;
            this.bbsURL = bbsUrl;
            this.PostID = postID;
        }
        public HairStyleEntity(int hairStyleID, string tagIDs, string hairName, int hairQuantity, string bbsUrl, int hairShopID, int hairEngineerID, Byte hairStyle, Byte faceStyle, Byte temperament, Byte occasion, Byte sex, Byte hairNature, string idesc, string ppsgids, bool isHairStyle, int postID)
        {
            this.id = hairStyleID;
            this.tag = tagIDs;
            this.hairName = hairName;
            this.hairShopID = hairShopID;
            this.hairEngineerID = hairEngineerID;
            this.hairStyle = hairStyle;
            this.faceStyle = faceStyle;
            this.hairQuantity = hairQuantity;
            this.hairNature = hairNature;
            this.temperament = temperament;
            this.occasion = occasion;
            this.sex = sex;
            this.description = idesc;
            this.PSGIDS = ppsgids;
            this.IsHairStyle = isHairStyle;
            this.bbsURL = bbsUrl;
            this.PostID = postID;
        }
        public HairStyleEntity(int hsid, int hairQuantity, string bbsUrl, string hairName, int hairShopID, int hairEngineerID, Byte hairStyle, Byte faceStyle, Byte temperament, Byte occasion, Byte sex, Byte hairNature, string idesc, string ppsgids, bool isHairStyle, int postID)
        {
            this.id = hsid;
            this.hairName = hairName;
            this.hairShopID = hairShopID;
            this.hairEngineerID = hairEngineerID;
            this.hairStyle = hairStyle;
            this.faceStyle = faceStyle;
            this.hairQuantity = hairQuantity;
            this.hairNature = hairNature;
            this.temperament = temperament;
            this.occasion = occasion;
            this.sex = sex;
            this.description = idesc;
            this.PSGIDS = ppsgids;
            this.IsHairStyle = isHairStyle;
            this.PostID = postID;
            this.bbsURL = bbsUrl;
        }
        public HairStyleEntity(string tagIDs,int hsid, int hairQuantity, string bbsUrl, string hairName, int hairShopID, int hairEngineerID, Byte hairStyle, Byte faceStyle, Byte temperament, Byte occasion, Byte sex, Byte hairNature, string idesc, string ppsgids, bool isHairStyle, int postID)
        {
            this.id = hsid;
            this.tag = tagIDs;
            this.hairName = hairName;
            this.hairShopID = hairShopID;
            this.hairEngineerID = hairEngineerID;
            this.hairStyle = hairStyle;
            this.faceStyle = faceStyle;
            this.hairQuantity = hairQuantity;
            this.hairNature = hairNature;
            this.temperament = temperament;
            this.occasion = occasion;
            this.sex = sex;
            this.description = idesc;
            this.PSGIDS = ppsgids;
            this.IsHairStyle = isHairStyle;
            this.PostID = postID;
            this.bbsURL = bbsUrl;
        }
        public HairStyleEntity(string hairName, int hairQuantity, string bbsUrl, int hairShopID, int hairEngineerID, Byte hairStyle, Byte faceStyle, Byte temperament, Byte occasion, Byte sex, Byte hairNature, int picsid, string idesc, string ppsgids, bool isHairStyle, int postID)
        {
            this.hairName = hairName;
            this.hairShopID = hairShopID;
            this.hairEngineerID = hairEngineerID;
            this.hairStyle = hairStyle;
            this.faceStyle = faceStyle;
            this.hairQuantity = hairQuantity;
            this.hairNature = hairNature;
            this.temperament = temperament;
            this.occasion = occasion;
            this.sex = sex;
            this.description = idesc;
            this.picturestoreid = picsid;
            this.PSGIDS = ppsgids;
            this.IsHairStyle = isHairStyle;
            this.PostID = postID;
            this.bbsURL = bbsUrl;
        }
        public HairStyleEntity(int hairStyleID,string tagIDs,string hairName, int hairQuantity, string bbsUrl, int hairShopID, int hairEngineerID, Byte hairStyle, Byte faceStyle, Byte temperament, Byte occasion, Byte sex, Byte hairNature, int picsid, string idesc, string ppsgids, bool isHairStyle, int postID)
        {
            this.id = hairStyleID;
            this.tag = tagIDs;
            this.hairName = hairName;
            this.hairShopID = hairShopID;
            this.hairEngineerID = hairEngineerID;
            this.hairStyle = hairStyle;
            this.faceStyle = faceStyle;
            this.hairQuantity = hairQuantity;
            this.hairNature = hairNature;
            this.temperament = temperament;
            this.occasion = occasion;
            this.sex = sex;
            this.description = idesc;
            this.picturestoreid = picsid;
            this.PSGIDS = ppsgids;
            this.IsHairStyle = isHairStyle;
            this.PostID = postID;
            this.bbsURL = bbsUrl;
        }
        public HairStyleEntity(string hairName, string bigPic, string bbsUrl, string smallPic_F, string smallPic_B, string smallPic_S, Byte hairStyle,
            Byte faceStyle, Byte hairQuantity, Byte hairNature, string tag, string desc, int pictureid, bool isHairStyle, int postID)
        {
            this.hairName = hairName;
            this.bigPic = bigPic;
            this.smallPic_F = smallPic_F;
            this.smallPic_B = smallPic_B;
            this.smallPic_S = smallPic_S;
            this.hairStyle = hairStyle;
            this.faceStyle = faceStyle;
            this.hairQuantity = hairQuantity;
            this.hairNature = hairNature;
            this.tag = tag;
            this.description = desc;
            this.picturestoreid = pictureid;
            this.IsHairStyle = isHairStyle;
            this.PostID = postID;
            this.bbsURL = bbsUrl;
        }

        public Int32 ID
        {
            set { id = value; }
            get { return id; }
        }

        public String HairName
        {
            set { hairName = value; }
            get { return hairName; }
        }

        public Byte HairStyle
        {
            set { hairStyle = value; }
            get { return hairStyle; }
        }

        public Byte FaceStyle
        {
            set { faceStyle = value; }
            get { return faceStyle; }
        }

        public Byte Temperament
        {
            set { temperament = value; }
            get { return temperament; }
        }

        public Byte Occasion
        {
            set { occasion = value; }
            get { return occasion; }
        }

        public Byte Sex
        {
            set { sex = value; }
            get { return sex; }
        }

        public String BigPic
        {
            set { bigPic = value; }
            get { return bigPic; }
        }

        public String SmallPic_F
        {
            set { smallPic_F = value; }
            get { return smallPic_F; }
        }

        public String SmallPic_B
        {
            set { smallPic_B = value; }
            get { return smallPic_B; }
        }

        public String SmallPic_S
        {
            set { smallPic_S = value; }
            get { return smallPic_S; }
        }

        public String Pic1
        {
            set { pic1 = value; }
            get { return pic1; }
        }

        public String Pic2
        {
            set { pic2 = value; }
            get { return pic2; }
        }

        public String Pic3
        {
            set { pic3 = value; }
            get { return pic3; }
        }

        public Int32 HairShopID
        {
            set { hairShopID = value; }
            get { return hairShopID; }
        }

        public Int32 HairEngineerID
        {
            set { hairEngineerID = value; }
            get { return hairEngineerID; }
        }

        public Int32 HairQuantity
        {
            set { hairQuantity = value; }
            get { return hairQuantity; }
        }

        public Byte HairNature
        {
            set { hairNature = value; }
            get { return hairNature; }
        }

        public Byte HairColor
        {
            set { hairColor = value; }
            get { return hairColor; }
        }

        public DateTime CreateTime
        {
            set { createTime = value; }
            get { return DateTime.Now; }
        }

        public String BBSURL
        {
            set { bbsURL = value; }
            get { return bbsURL; }
        }

        public Int32 Good
        {
            set { good = value; }
            get { return good; }
        }

        public Int32 Normal
        {
            set { normal = value; }
            get { return normal; }
        }

        public Int32 Bad
        {
            set { bad = value; }
            get { return bad; }
        }

        public String Tag
        {
            set { tag = value; }
            get { return tag; }
        }
    }
}
