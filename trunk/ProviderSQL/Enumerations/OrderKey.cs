using System;
using System.Collections.Generic;
using System.Text;

namespace HairNet.Enumerations
{
    public enum OrderKey
    {
        //按照时间排序
        Time,
        //按照好评坏平排序
        Good,
        //按照用户排序，可能是用户ID,也可能是相应的实体ID排序，具体情况具体分析
        ID
    }
}
