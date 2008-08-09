using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Provider;

namespace HairNet.Business
{
    public class UserAdmin
    {
        /// <summary>
        /// 获得用户列表
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<UserEntry> GetUsers(int count)
        {
            return ProviderFactory.GetUserDataProviderInstance().GetUsers(count);
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static bool DeleteUserByUserID(int userID)
        {
            return ProviderFactory.GetUserDataProviderInstance().UserDelete(userID);
        }
        /// <summary>
        /// 获得用户列表，名字模糊查询
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static List<UserEntry> GetUsersByUserName(string userName)
        {
            return ProviderFactory.GetUserDataProviderInstance().GetUsersByName(userName);
        }
    }
}
