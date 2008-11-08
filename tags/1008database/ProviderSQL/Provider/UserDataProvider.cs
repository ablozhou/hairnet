using System;
using System.Collections.Generic;
using System.Text;
using HairNet.Entry;
using HairNet.Enumerations;

namespace HairNet.Provider
{
    public interface IUserDataProvider
    {
        //定义接口方法
        
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool UserCreate(UserEntry user);
        
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        bool UserDelete(int  userID);
       
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ua"></param>
        /// <returns></returns>
        bool UserUpdate(UserEntry user);

        /// <summary>
        /// 更新用户状态（为删除用户标记）
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        bool UserUpdateStatus(int userID,bool isActive);
        
        /// <summary>
        /// 通过ID得到用户实体
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        UserEntry GetUserByID(int userID);
        
        /// <summary>
        /// 通过用户名得到用户实体
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        UserEntry GetUserByName(string userName);
        
        /// <summary>
        /// 获取制定数量的用户
        /// </summary>
        /// <param name="count">0,all users</param>
        /// <returns></returns>
        List<UserEntry> GetUsers(int count);

        /// <summary>
        /// 用户查询
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        List<UserEntry> GetUsersByName(string strUserName);

        /// <summary>
        /// EMAIL发送的临时表
        /// </summary>
        /// <param name="tempEmail"></param>
        /// <returns></returns>
        bool TempEmailCreateDeleteUpdate(TempEmail tempEmail,UserAction ua);
    }
}
