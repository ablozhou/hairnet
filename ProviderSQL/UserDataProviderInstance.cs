using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Enumerations;
using HairNet.Entry;

namespace HairNet.Provider
{
    public class UserDataProviderInstance :IUserDataProvider
    {
        //具体实现
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool UserCreate(UserEntry user)
        {
            return false;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool UserDelet(UserEntry user)
        {
            return false;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        public bool UserUpdate(UserEntry user)
        {
            return false;
        }

        /// <summary>
        /// 通过ID得到用户实体
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public UserEntry GetUserByID(int userID)
        {
            UserEntry ue = new UserEntry();
            return ue;
        }

        /// <summary>
        /// 通过用户名得到用户实体
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public UserEntry GetUserByName(string userName)
        {
            UserEntry ue = new UserEntry();
            return ue;
        }

        /// <summary>
        /// 获取制定数量的用户
        /// </summary>
        /// <param name="count">0,all users</param>
        /// <returns></returns>
        public List<UserEntry> GetUsers(int count)
        {
            List<UserEntry> li = new List<UserEntry>();
            return li;
        }

        /// <summary>
        /// 用户查询
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public List<UserEntry> GetUsersByName(string strUserName)
        {
            List<UserEntry> li = new List<UserEntry>();
            return li;
           
        }

    }
}
