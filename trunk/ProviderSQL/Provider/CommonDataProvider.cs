using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public interface ICommonDataProvider
    {
        //����ӿ�
        /// <summary>
        /// ���City�б�
        /// </summary>
        /// <returns></returns>
        List<City> GetCitys();

        /// <summary>
        /// City ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="city"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool CityCreateDeleteUpdate(City city, UserAction ua);

        /// <summary>
        /// ͨ��CityID��������б�
        /// </summary>
        /// <param name="cityID"></param>
        /// <returns></returns>
        List<MapZone> GetMapZonesByCityID(int cityID);

        /// <summary>
        /// ���� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="mapZone"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool MapZoneCreateDeleteUpdate(MapZone mapZone, UserAction ua);

        /// <summary>
        /// ͨ������ID���ߵض�
        /// </summary>
        /// <param name="MapZoneID"></param>
        /// <returns></returns>
        List<HotZone> GetHotZonesByMapZoneID(int MapZoneID);

        /// <summary>
        /// �ض� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hotZone"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HotZoneCreateDeleteUpdate(HotZone hotZone, UserAction ua);

        //�۸�Χ���б����幦�ܻ�û����ӵ�����ʦ�������������У�������Ʒ�С��ȴ����������

        /// <summary>
        /// ��ü۸�Χ�б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<PriceRange> GetPriceRanges(int count);

        /// <summary>
        /// �۸�Χ ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="priceRange"></param>
        /// <returns></returns>
        bool PriceRangeCreateDeleteUpdate(PriceRange priceRange,UserAction ua);

        //����ʽ�������ݲ���д�����Ǹ��������ͼ��Ƶ����󣬵��ǣ��۲��ʺ�


        /// <summary>
        /// ͨ��GROUPID��ȡ����Ƶ���ؼ����б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairNetTag> GetHairNetTagsByHairNetTagGroupID(int hairNetTagGroupID);


        /// <summary>
        /// ����Ƶ���ؼ��� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hairNetTag"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairNetTagCreateDeleteUpdate(HairNetTag hairNetTag, UserAction ua);

        /// <summary>
        /// �������Ƶ���ؼ��ַ����б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<HairNetTagGroup> GetHairNetTagGroups(int count);

        /// <summary>
        /// ����Ƶ���ؼ��ַ��� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hairNetTagGroup"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool HairNetTagGroupCreateDeleteUpdate(HairNetTagGroup hairNetTagGroup, UserAction ua);
    }
}
