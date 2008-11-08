
using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Web;
using System.Collections;
using HWKEY;

namespace HWCommon
{
    /// <summary>
    /// Cryptogram 的摘要说明。
    /// </summary>
    public class Cryptogram
    {
        private static TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();

        static Cryptogram()
        {
            des.Mode = System.Security.Cryptography.CipherMode.CBC;
            des.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
        }
        public static string CreateUpperMD5(string str)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToUpper();
        }
        public static string CreateLowerMD5(string str)
        {
            return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").ToLower();
        }
        public static string EncryptPhotoid(string photoid)
        {
            if (photoid == "") return "";
            try
            {
                byte[] buf;

                if (Encrypt(KEY.passKEY, KEY.passIV, ConvertStringToByteArray(photoid), out buf))
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < buf.Length; i++)
                    {
                        sb.Append(buf[i].ToString("X").Length == 2 ? buf[i].ToString("X") : "0" + buf[i].ToString("X"));
                    }
                    return sb.ToString();
                }
                else
                    return "";
            }
            catch
            {
            }
            return "";
        }
        /// <summary>
        /// 加密密码
        /// </summary>
        /// <param name="Password">待加密的密码明文</param>
        /// <returns></returns>
        public static string EncryptPassword(string Password)
        {
            if (Password == "") return "";
            try
            {
                byte[] Encrypted;

                if (Encrypt(KEY.passKEY, KEY.passIV, ConvertStringToByteArray(Password), out Encrypted))
                {
                    return ToBase64String(Encrypted);
                }
                else
                    return "";
            }
            catch (Exception ex)
            {
                string a = ex.ToString();
            }
            return "";
        }
        /// <summary>
        /// 解密密码
        /// </summary>
        /// <param name="Password">待解密的密码密文</param>
        /// <returns></returns>
        public static string DecryptPassword(string Password)
        {
            if (Password == "") return "";
            try
            {
                byte[] Decrypted;

                if (Decrypt(KEY.passKEY, KEY.passIV, FromBase64String(Password), out Decrypted))
                {
                    return ConvertByteArrayToString(Decrypted);
                }
                else
                    return "";
            }
            catch (Exception e)
            {
                string errmsg = e.ToString();
            }
            return "";
        }
        /// <summary>
        /// 加密UserToken
        /// </summary>
        /// <param name="UserToken">待加密的UserToken明文</param>
        /// <returns></returns>
        public static string EncryptUserToken(string UserToken)
        {
            if (UserToken == "") return "";
            try
            {
                byte[] Encrypted;
                if (Encrypt(KEY.cookieKEY, KEY.cookieIV, ConvertStringToByteArray(UserToken), out Encrypted))
                {
                    return ToBase64String(Encrypted);
                }
                else
                    return "";
            }
            catch
            {
            }
            return "";
        }
        /// <summary>
        /// 解密UserToken
        /// </summary>
        /// <param name="UserToken">待解密的UserToken密文</param>
        /// <returns></returns>
        public static string DecryptUserToken(string UserToken)
        {
            if (UserToken == "") return "";
            try
            {
                byte[] Decrypted;
                if (Decrypt(KEY.cookieKEY, KEY.cookieIV, FromBase64String(UserToken), out Decrypted))
                {
                    return ConvertByteArrayToString(Decrypted);
                }
                else
                    return "";
            }
            catch (Exception exp)
            {
                string s = exp.Message;
            }
            return "";
        }
        /// <summary>
        /// 生成摘要
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ComputeHashString(string s)
        {
            return ToBase64String(ComputeHash(ConvertStringToByteArray(s)));
        }
        private static byte[] ComputeHash(byte[] buf)
        {
            return ((HashAlgorithm)CryptoConfig.CreateFromName("SHA1")).ComputeHash(buf);
        }
        private static bool Encrypt(byte[] KEY, byte[] IV, byte[] TobeEncrypted, out byte[] Encrypted)
        {
            Encrypted = null;
            try
            {
                byte[] tmpiv ={ 0, 1, 2, 3, 4, 5, 6, 7 };
                for (int ii = 0; ii < 8; ii++)
                {
                    tmpiv[ii] = IV[ii];
                }
                byte[] tmpkey ={ 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7 };
                for (int ii = 0; ii < 24; ii++)
                {
                    tmpkey[ii] = KEY[ii];
                }
                ICryptoTransform tridesencrypt = des.CreateEncryptor(tmpkey, tmpiv);
                Encrypted = tridesencrypt.TransformFinalBlock(TobeEncrypted, 0, TobeEncrypted.Length);
                des.Clear();
                return true;
            }
            catch
            {
            }
            return false;
        }
        private static bool Decrypt(byte[] KEY, byte[] IV, byte[] TobeDecrypted, out  byte[] Decrypted)
        {
            Decrypted = null;
            try
            {
                byte[] tmpiv ={ 0, 1, 2, 3, 4, 5, 6, 7 };
                for (int ii = 0; ii < 8; ii++)
                {
                    tmpiv[ii] = IV[ii];
                }
                byte[] tmpkey ={ 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7 };
                for (int ii = 0; ii < 24; ii++)
                {
                    tmpkey[ii] = KEY[ii];
                }
                ICryptoTransform tridesdecrypt = des.CreateDecryptor(tmpkey, tmpiv);
                Decrypted = tridesdecrypt.TransformFinalBlock(TobeDecrypted, 0, TobeDecrypted.Length);
                des.Clear();
            }
            catch
            {
            }
            return true;
        }
        private static string ToBase64String(byte[] buf)
        {
            return System.Convert.ToBase64String(buf);
        }
        private static byte[] FromBase64String(string s)
        {
            return System.Convert.FromBase64String(s);
        }
        private static byte[] ConvertStringToByteArray(String s)
        {
            return System.Text.Encoding.GetEncoding("utf-8").GetBytes(s);
        }
        private static string ConvertByteArrayToString(byte[] buf)
        {
            return System.Text.Encoding.GetEncoding("utf-8").GetString(buf);
        }

        public static string MD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = Encoding.Default.GetBytes(str);
            byte[] result = md5.ComputeHash(data);
            string ret = "";
            for (int i = 0; i < result.Length; i++)
            {
                ret = ret + result[i].ToString("x").PadLeft(2, '0');
            }
            return ret;
        }

 


    }
}