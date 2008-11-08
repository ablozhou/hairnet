using System;

namespace HairNet.Enumerations
{
    public enum Sort
    {
        //升序
        ASC,
        //降序
        DESC
    }

    public enum TagsSort
    {
        //按名称排序
        Name,
        //按建立时间排序
        CreateDate,
        //按下属信息量排序
        InformationCount
    }
}