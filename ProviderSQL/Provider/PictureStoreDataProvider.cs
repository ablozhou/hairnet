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
    }
}
