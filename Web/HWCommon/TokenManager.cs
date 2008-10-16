
using System;
using System.Text;

namespace HWCommon
{
    /// <summary>
    /// TokenManager 的摘要说明。
    /// </summary>
    public class TokenManager
    {
        private static char Separator = (char)0x1EEC;

        /// <summary>
        /// 验证令牌
        /// </summary>
        /// <param name="strUserToken">令牌</param>
        /// <param name="user">用户对象</param>
        /// <returns></returns>
        public static bool ValidateUserToken(ref string strUserToken, out UserInfo user)
        {
            user = null;
            try
            {
                int pos = strUserToken.IndexOf(",");
                if (pos > 0)
                {
                    strUserToken = strUserToken.Substring(pos + 1, strUserToken.Length - pos - 1);
                    strUserToken = Cryptogram.DecryptUserToken(strUserToken);
                    if (strUserToken != "")
                    {
                        string[] temparr = strUserToken.Split(Separator);
                        //string ssss = Cryptogram.ComputeHashString(temparr[0] + temparr[2]);
                        //if (long.Parse(temparr[6]) > System.DateTime.Now.Ticks && Cryptogram.ComputeHashString(temparr[0] + temparr[2]) == temparr[7])
                        //{
                        //    string active = "", blogname = "";

                        //    if (temparr.Length < 9 || temparr[8] == "")
                        //    {
                        //        if (HWCommon.UserAuth.isActiveUser(temparr[0]))
                        //            active = "1";
                        //        else
                        //            active = "0";
                        //    }
                        //    else
                        //        active = temparr[8];

                        //    if (temparr.Length < 10 || temparr[9] == "")
                        //    {
                        //        if (!HWCommon.Util.getBlogNameByUserID(temparr[0], out blogname))
                        //            blogname = temparr[0];
                        //    }
                        //    else
                        //        blogname = temparr[9];

                            user = new UserInfo(temparr[0], temparr[1]);
                            if (GenerateUserToken(user, out strUserToken))
                            {
                                return true;
                            }
                        //}
                    }
                }
            }
            catch
            {
            }
            return false;
        }


    

        public static bool GenerateUserToken(UserInfo user, out string userToken)
        {
            userToken = "";
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(user.ID);
                sb.Append(Separator);
               
                sb.Append(user.UserName);
                sb.Append(Separator);
                
                userToken = Cryptogram.EncryptUserToken(sb.ToString());
                if (userToken != "")
                {
                    userToken = user.ID + "|" + user.UserName + "," + userToken;
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }
    }
}
