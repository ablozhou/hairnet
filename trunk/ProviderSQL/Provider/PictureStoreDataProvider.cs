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
        List<PictureStore> GetPictureStores(int count);

        PictureStoreRecommand GetPictureStoreRecommandByPictureStoreRecommandID(int pictureStoreRecommandID);
        List<PictureStoreRecommand> GetPictureStoreRecommands(int count);

        bool PictureStoreCommentCreateDeleteUpdate(PictureStoreComment pictureStoreComment, UserAction ua);
        List<PictureStoreComment> GetPictureStoreCommentsByPictureStoreID(int pictureStoreID,int count,string orderKey);
        List<PictureStoreComment> GetPictureStoreCommentsByUserID(int userID, int count, string orderKey);

        bool PictureStoreGroupCreateDeleteUpdate(PictureStoreGroup pictureStoreGroup, UserAction ua);
        List<PictureStoreGroup> GetPictureStoreGroups(int count);
        PictureStoreGroup GetPictureStoreGroupByPictureStoreGroupID(int pictureStoreGroupID);
        List<PictureStoreGroup> GetPictureStoreGroupsByParentID(int parentID, int count);

        bool PictureStoreTagCreateDeleteUpdate(PictureStoreTag pictureStoreTag, UserAction ua);
        List<PictureStoreTag> GetPictureStoreTags(int count);
        PictureStoreTag GetPictureStoreTagByPictureStoreTagID(int pictureStoreTagID);
    }
}
