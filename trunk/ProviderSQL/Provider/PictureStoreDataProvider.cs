using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public interface IPictureStoreDataProvider
    {
        bool PictureStoreCreateDeleteUpdate(PictureStore pictureStore, UserAction ua);
        bool PictureStoreRecommandCreateDeleteUpdate(PictureStoreRecommand pictureStoreRecommand, UserAction ua);

        PictureStore GetPictureStoreByPictureStoreID(int pictureStoreID);
        List<PictureStore> GetPictureStores(int count,OrderKey ok);
        List<PictureStore> GetPictureStores(int count, OrderKey ok,string pictureStoreName);

        PictureStoreRecommand GetPictureStoreRecommandByPictureStoreRecommandID(int pictureStoreRecommandID);
        List<PictureStoreRecommand> GetPictureStoreRecommands(int count);

        bool PictureStoreCommentCreateDeleteUpdate(PictureStoreComment pictureStoreComment, UserAction ua);
        List<PictureStoreComment> GetPictureStoreCommentsByPictureStoreID(int pictureStoreID,int count,OrderKey ok);
        List<PictureStoreComment> GetPictureStoreCommentsByUserID(int userID, int count, OrderKey ok);

        bool PictureStoreGroupCreateDeleteUpdate(PictureStoreGroup pictureStoreGroup, UserAction ua);
        List<PictureStoreGroup> GetPictureStoreGroups(int count);
        PictureStoreGroup GetPictureStoreGroupByPictureStoreGroupID(int pictureStoreGroupID);
        List<PictureStoreGroup> GetPictureStoreGroupsByParentID(int parentID, int count);

        bool PictureStoreTagCreateDeleteUpdate(PictureStoreTag pictureStoreTag, UserAction ua);
        List<PictureStoreTag> GetPictureStoreTags(int count);
        PictureStoreTag GetPictureStoreTagByPictureStoreTagID(int pictureStoreTagID);

        string GetPictureStoreTagIDs(string tagNames);
        string GetPictureStoreTagNames(string tagIDs);
        int AddPictureStore(PictureStore ps);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<PictureStoreComment> GetPictureStoreComments(int count);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        List<PictureStoreComment> GetPictureStoreCommentsByKeyText(int count, string keyText);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="sTime"></param>
        /// <param name="eTime"></param>
        /// <returns></returns>
        List<PictureStoreComment> GetPictureStoreCommentsByTimeZone(int count, string sTime, string eTime);
    }
}
