using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Entry
{
    public class City : NameBase
    {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Methods
        #endregion
    }
    public class MapZone : NameBase
    {
        #region Fields

        private int _cityID = 0;

        #endregion

        #region Properties

        public int CityID
        {
            set { this._cityID = value; }
            get { return this._cityID; }
        }

        #endregion

        #region Methods
        #endregion
    }
    public class HotZone : NameBase
    {
        #region Fields

        private int _mapZoneID = 0;

        #endregion

        #region Properties

        public int MapZoneID
        {
            set { this._mapZoneID = value; }
            get { return this._mapZoneID; }
        }

        #endregion

        #region Methods
        #endregion
    }
}
