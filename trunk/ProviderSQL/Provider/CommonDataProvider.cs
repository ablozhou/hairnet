using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public interface ICommonDataProvider
    {
        //定义接口
        /// <summary>
        /// 获得City列表
        /// </summary>
        /// <returns></returns>
        List<City> GetCitys();

        /// <summary>
        /// City 添加，删除，修改
        /// </summary>
        /// <param name="city"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool CityCreateDeleteUpdate(City city, UserAction ua);

        /// <summary>
        /// 通过CityID获得区域列表
        /// </summary>
        /// <param name="cityID"></param>
        /// <returns></returns>
        List<MapZone> GetMapZonesByCityID(int cityID);

        /// <summary>
        /// 区域 添加，删除，修改
        /// </summary>
        /// <param name="mapZone"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool MapZoneCreateDeleteUpdate(MapZone mapZone, UserAction ua);

        /// <summary>
        /// 通过区域ID或者地段
        /// </summary>
        /// <param name="MapZoneID"></param>
        /// <returns></returns>
        List<HotZone> GetHotZonesByMapZoneID(int MapZoneID);

        /// <summary>
        /// 地段 添加，删除，修改
        /// </summary>
        /// <param name="hotZone"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HotZoneCreateDeleteUpdate(HotZone hotZone, UserAction ua);

        //价格范围，列表，具体功能还没有添加到美发师，美发厅，还有，美发产品中。等待天天的需求

        /// <summary>
        /// 获得价格范围列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<PriceRange> GetPriceRanges(int count);

        /// <summary>
        /// 价格范围 添加，删除，修改
        /// </summary>
        /// <param name="priceRange"></param>
        /// <returns></returns>
        bool PriceRangeCreateDeleteUpdate(PriceRange priceRange,UserAction ua);

        //排序方式，现在暂不书写，这是根据天天的图设计的需求，但是，咱不适合


        /// <summary>
        /// 通过GROUPID获取美发频道关键字列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairNetTag> GetHairNetTagsByHairNetTagGroupID(int hairNetTagGroupID);


        /// <summary>
        /// 美发频道关键字 添加，删除，修改
        /// </summary>
        /// <param name="hairNetTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairNetTagCreateDeleteUpdate(HairNetTag hairNetTag, UserAction ua);

        /// <summary>
        /// 获得美发频道关键字分类列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairNetTagGroup> GetHairNetTagGroups(int count);

        /// <summary>
        /// 美发频道关键字分类 添加，删除，修改
        /// </summary>
        /// <param name="hairNetTagGroup"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairNetTagGroupCreateDeleteUpdate(HairNetTagGroup hairNetTagGroup, UserAction ua);
    }
}
