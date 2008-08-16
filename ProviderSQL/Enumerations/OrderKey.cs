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
        //针对美发厅，美发师，没有创建时间的，根据ID排序
        ID,
        //评论数
        CommentNum,
        //推荐数
        RecommandNum,
        //点击数
        HitNum,
        //预约数
        OrderNum
        
    }
}
