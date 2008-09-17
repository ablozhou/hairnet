using System;
using System.Collections.Generic;
using System.Text;
using Discuz.Utility;

namespace Discuz.Crypt
{
    public class DiscuzAuthCode
    {
        #region public functions

        /// <summary>
        /// 字符串加密
        /// </summary>
        /// <param name="source">原始字串</param>
        /// <param name="key">密钥</param>
        /// <returns>加密结果</returns>
        public static string Encode(string source, string key)
        {
            return AuthCode(source, key, DiscuzAuthcodeMode.Encode, 0);
        }

        /// <summary>
        /// 字符串解密
        /// </summary>
        /// <param name="source">原始字符串</param>
        /// <param name="key">密钥</param>
        /// <returns>解密结果</returns>
        public static string Decode(string source, string key)
        {
            return AuthCode(source, key, DiscuzAuthcodeMode.Decode, 0);
        }

        #endregion

        #region enums
        private enum DiscuzAuthcodeMode
        {
            Encode,
            Decode
        }
        #endregion

        #region private functions 核心函数请勿更改

        private static Byte[] RC4(Byte[] input, String pass)
        {
            if (input == null || pass == null) return null;

            Encoding enc_default = Encoding.Default;

            byte[] output = new Byte[input.Length];
            byte[] mBox = GetKey(enc_default.GetBytes(pass), 256);

            Int64 i = 0;
            Int64 j = 0;
            for (Int64 offset = 0; offset < input.Length; offset++)
            {
                i = (i + 1) % mBox.Length;
                j = (j + mBox[i]) % mBox.Length;
                Byte temp = mBox[i];
                mBox[i] = mBox[j];
                mBox[j] = temp;
                Byte a = input[offset];
                Byte b = mBox[(mBox[i] + mBox[j]) % mBox.Length];
                output[offset] = (Byte)(a ^ b);
            }

            return output;
        }

        private static Byte[] GetKey(Byte[] pass, Int32 kLen)
        {
            Byte[] mBox = new Byte[kLen];

            for (Int64 i = 0; i < kLen; i++)
            {
                mBox[i] = (Byte)i;
            }
            Int64 j = 0;
            for (Int64 i = 0; i < kLen; i++)
            {
                j = (j + mBox[i] + pass[i % pass.Length]) % kLen;
                Byte temp = mBox[i];
                mBox[i] = mBox[j];
                mBox[j] = temp;
            }
            return mBox;
        }

        private static string AuthCode(string source, string key, DiscuzAuthcodeMode operation, int expiry)
        {
            if (source == null || key == null)
            {
                return "";
            }

            int ckey_length = 4;
            string keyb;
            string keyc;
            string cryptkey;
            string result;
            string timestamp = Utils.UnixTimestamp();

            key = Utils.MD5(key);
            string keya = Utils.MD5(Utils.CutString(key, 0, 16));
            keyb = Utils.MD5(Utils.CutString(key, 16, 16));
            keyc = ckey_length > 0
                       ? (operation == DiscuzAuthcodeMode.Decode
                              ? Utils.CutString(source, 0, ckey_length)
                              : Utils.RandomString(ckey_length))
                       : "";

            cryptkey = keya + Utils.MD5(keya + keyc);

            if (operation == DiscuzAuthcodeMode.Decode)
            {
                byte[] temp;
                try
                {
                    temp = Convert.FromBase64String(Utils.CutString(source, ckey_length));
                }
                catch
                {
                    try
                    {
                        temp = Convert.FromBase64String(Utils.CutString(source + "=", ckey_length));
                    }
                    catch
                    {
                        try
                        {
                            temp = Convert.FromBase64String(Utils.CutString(source + "==", ckey_length));
                        }
                        catch
                        {
                            return "";
                        }
                    }
                }

                result = Encoding.Default.GetString(RC4(temp, cryptkey));
                if (Utils.CutString(result, 10, 16) == Utils.CutString(Utils.MD5(Utils.CutString(result, 26) + keyb), 0, 16))
                {
                    return Utils.CutString(result, 26);
                }
                else
                {
                    return "";
                }
            }
            else
            {
                source = "0000000000" + Utils.CutString(Utils.MD5(source + keyb), 0, 16) + source;
                byte[] temp = RC4(Encoding.Default.GetBytes(source), cryptkey);
                return keyc + Convert.ToBase64String(temp);
            }
        }

        #endregion 
    }
}
