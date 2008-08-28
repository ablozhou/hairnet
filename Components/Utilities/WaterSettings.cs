using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace HairNet.Components.Utilities
{
    public class WaterSettings
    {
        public static string WaterMarkPath
        {
            get
            {
                return ConfigurationManager.AppSettings["WaterMarkPath"];
            }
        }

        public static string CopyrightText
        {
            get
            {
                return ConfigurationManager.AppSettings["CopyrightText"];
            }
        }

        public static int[] PictureScaleSize
        {
            get
            {
                string[] size = ConfigurationManager.AppSettings["PictureScaleSize"].Split(',');
                Converter<string, int> converter = delegate(string s) { return int.Parse(s); };
                return Array.ConvertAll<string, int>(size, converter);
            }
        }
    }
}
