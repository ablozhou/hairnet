using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public class CommonDataProviderInstance :ICommonDataProvider
    {   
        /// <summary>
        /// 获得City列表
        /// </summary>
        /// <returns></returns>
        public List<City> GetCitys() 
        {
            List<City> list = new List<City>();
            return list;
        }

        /// <summary>
        /// City 添加，删除，修改
        /// </summary>
        /// <param name="city"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool CityCreateDeleteUpdate(City city, UserAction ua)
        {
            bool result = false;
            return result;
        }

        /// <summary>
        /// 通过CityID获得区域列表
        /// </summary>
        /// <param name="cityID"></param>
        /// <returns></returns>
        public List<MapZone> GetMapZonesByCityID(int cityID)
        {
            List<MapZone> list = new List<MapZone>();
            return list;
        }

        /// <summary>
        /// 区域 添加，删除，修改
        /// </summary>
        /// <param name="mapZone"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool MapZoneCreateDeleteUpdate(MapZone mapZone, UserAction ua)
        {
            bool result = false;
            return result;
        }

        /// <summary>
        /// 通过区域ID或者地段
        /// </summary>
        /// <param name="MapZoneID"></param>
        /// <returns></returns>
        public List<HotZone> GetHotZonesByMapZoneID(int MapZoneID)
        {
            List<HotZone> list = new List<HotZone>();
            return list;
        }

        /// <summary>
        /// 地段 添加，删除，修改
        /// </summary>
        /// <param name="hotZone"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HotZoneCreateDeleteUpdate(HotZone hotZone, UserAction ua)
        {
            bool result = false;
            return result;
        }

        //价格范围，列表，具体功能还没有添加到美发师，美发厅，还有，美发产品中。等待天天的需求

        /// <summary>
        /// 获得价格范围列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<PriceRange> GetPriceRanges(int count)
        {
            List<PriceRange> list = new List<PriceRange>();
            return list;
        }

        /// <summary>
        /// 价格范围 添加，删除，修改
        /// </summary>
        /// <param name="priceRange"></param>
        /// <returns></returns>
        public bool PriceRangeCreateDeleteUpdate(PriceRange priceRange)
        {
            bool result = false;
            return result;
        }

        //排序方式，现在暂不书写，这是根据天天的图设计的需求，但是，咱不适合


        /// <summary>
        /// 通过GROUPID获取美发频道关键字列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairNetTag> GetHairNetTagsByHairNetTagGroupID(int hairNetTagGroupID)
        {
            List<HairNetTag> list = new List<HairNetTag>();
            return list;
        }


        /// <summary>
        /// 美发频道关键字 添加，删除，修改
        /// </summary>
        /// <param name="hairNetTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairNetTagCreateDeleteUpdate(HairNetTag hairNetTag, UserAction ua)
        {
            bool result = false;

            return result;
        }

        /// <summary>
        /// 获得美发频道关键字分类列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairNetTagGroup> GetHairNetTagGroups(int count)
        {
            List<HairNetTagGroup> list = new List<HairNetTagGroup>();
            return list;
        }

        /// <summary>
        /// 美发频道关键字分类 添加，删除，修改
        /// </summary>
        /// <param name="hairNetTagGroup"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HairNetTagGroupCreateDeleteUpdate(HairNetTagGroup hairNetTagGroup, UserAction ua)
        {
            bool result = false;

            return result;
        }
    }
}
