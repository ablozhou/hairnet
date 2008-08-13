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
        /// ���City�б�
        /// </summary>
        /// <returns></returns>
        public List<City> GetCitys() 
        {
            List<City> list = new List<City>();
            return list;
        }

        /// <summary>
        /// City ��ӣ�ɾ�����޸�
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
        /// ͨ��CityID��������б�
        /// </summary>
        /// <param name="cityID"></param>
        /// <returns></returns>
        public List<MapZone> GetMapZonesByCityID(int cityID)
        {
            List<MapZone> list = new List<MapZone>();
            return list;
        }

        /// <summary>
        /// ���� ��ӣ�ɾ�����޸�
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
        /// ͨ������ID���ߵض�
        /// </summary>
        /// <param name="MapZoneID"></param>
        /// <returns></returns>
        public List<HotZone> GetHotZonesByMapZoneID(int MapZoneID)
        {
            List<HotZone> list = new List<HotZone>();
            return list;
        }

        /// <summary>
        /// �ض� ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="hotZone"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool HotZoneCreateDeleteUpdate(HotZone hotZone, UserAction ua)
        {
            bool result = false;
            return result;
        }

        //�۸�Χ���б����幦�ܻ�û����ӵ�����ʦ�������������У�������Ʒ�С��ȴ����������

        /// <summary>
        /// ��ü۸�Χ�б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<PriceRange> GetPriceRanges(int count)
        {
            List<PriceRange> list = new List<PriceRange>();
            return list;
        }

        /// <summary>
        /// �۸�Χ ��ӣ�ɾ�����޸�
        /// </summary>
        /// <param name="priceRange"></param>
        /// <returns></returns>
        public bool PriceRangeCreateDeleteUpdate(PriceRange priceRange)
        {
            bool result = false;
            return result;
        }

        //����ʽ�������ݲ���д�����Ǹ��������ͼ��Ƶ����󣬵��ǣ��۲��ʺ�


        /// <summary>
        /// ͨ��GROUPID��ȡ����Ƶ���ؼ����б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairNetTag> GetHairNetTagsByHairNetTagGroupID(int hairNetTagGroupID)
        {
            List<HairNetTag> list = new List<HairNetTag>();
            return list;
        }


        /// <summary>
        /// ����Ƶ���ؼ��� ��ӣ�ɾ�����޸�
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
        /// �������Ƶ���ؼ��ַ����б�
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<HairNetTagGroup> GetHairNetTagGroups(int count)
        {
            List<HairNetTagGroup> list = new List<HairNetTagGroup>();
            return list;
        }

        /// <summary>
        /// ����Ƶ���ؼ��ַ��� ��ӣ�ɾ�����޸�
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
