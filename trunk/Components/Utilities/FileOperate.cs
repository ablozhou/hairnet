using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HairNet.Utilities
{
    public class FileOperate
    {
        public FileOperate() 
        {
        
        }

        /// <summary>
        /// 按照年月日创建目录
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public void NewDirectory(string path,string year,string month,string day) 
        {
            if (!Directory.Exists(path + year))
            {
                Directory.CreateDirectory(path +"\\"+ year);
                Directory.CreateDirectory(path + "\\" + year + "\\" + month);
                Directory.CreateDirectory(path + "\\" + year + "\\" + month + "\\" + day + "\\images");
            }
            else 
            {
                if (!Directory.Exists(path + year + month))
                {
                    Directory.CreateDirectory(path + "\\" + year + "\\" + month);
                    Directory.CreateDirectory(path + "\\" + year + "\\" + month + "\\" + day + "\\images");
                }
                else
                {
                    if (!Directory.Exists(path + year + month + day)) 
                    {
                        Directory.CreateDirectory(path + "\\" + year + "\\" + month + "\\" + day + "\\images");
                    }
                }
            }
        }
    }
}