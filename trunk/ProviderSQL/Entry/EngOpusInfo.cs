using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class EngOpusInfo
    {
        private int opusID = -1;
        private int engineerID = -1;
        private string opusName = string.Empty;
        private string frontsidePic = string.Empty;
        private string flanksidePic = string.Empty;
        private string backsidePic = string.Empty;
        private string assistancePic = string.Empty;

        private int hairStyle = -1;
        private int faceStyle = -1;
        private int hairType = -1;
        private int hairItem = -1;

        private string opusDesc = string.Empty;

        public EngOpusInfo(int opusID, int engineerID, string opusName, string frontsidePic, string flanksidePic, string backsidePic,
            string assistancePic, int hairStyle, int faceStyle, int hairType, int hairItem, string opusDesc)
        {
            this.opusID = opusID;
            this.engineerID = engineerID;
            this.opusName = opusName;
            this.frontsidePic = frontsidePic;
            this.flanksidePic = flanksidePic;
            this.backsidePic = backsidePic;
            this.assistancePic = assistancePic;
            this.hairStyle = hairStyle;
            this.faceStyle = faceStyle;
            this.hairType = hairType;
            this.hairItem = hairItem;
            this.opusDesc = opusDesc;
        }

        public Int32 OpusID
        {
            set { opusID = value; }
            get { return opusID; }
        }

        public Int32 EngineerID
        {
            set { engineerID = value; }
            get { return engineerID; }
        }

        public String OpusName
        {
            set { opusName = value; }
            get { return opusName; }
        }

        public String FrontSidePic
        {
            set { frontsidePic = value; }
            get { return frontsidePic; }
        }

        public String FlankSidePic
        {
            set { flanksidePic = value; }
            get { return flanksidePic; }
        }

        public String BackSidePic
        {
            set { backsidePic = value; }
            get { return backsidePic; }
        }

        public String AssistancePic
        {
            set { assistancePic = value; }
            get { return assistancePic; }
        }

        public Int32 HairStyle
        {
            set { hairStyle = value; }
            get { return hairStyle; }
        }

        public Int32 FaceStyle
        {
            set { faceStyle = value; }
            get { return faceStyle; }
        }

        public Int32 HairType
        {
            set { hairType = value; }
            get { return hairType; }
        }

        public Int32 HairItem
        {
            set { hairItem = value; }
            get { return hairItem; }
        }

        public String OpusDesc
        {
            set { opusDesc = value; }
            get { return opusDesc; }
        }
    }
}
