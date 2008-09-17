using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Discuz.Utility
{
    public class Utils
    {
        /// <summary>
        /// ȡ��ǰʱ��� unix ʱ���
        /// </summary>
        /// <returns></returns>
        internal static string UnixTimestamp()
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            DateTime dtNow = DateTime.Parse(DateTime.Now.ToString());
            TimeSpan toNow = dtNow.Subtract(dtStart);
            string timeStamp = toNow.Ticks.ToString();
            return timeStamp.Substring(0, timeStamp.Length - 7);
        }

        /// <summary>
        /// md5 ʵ��
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        internal static string MD5(string str)
        {
            if (string.IsNullOrEmpty(str))
                str = "";
            byte[] b = Encoding.Default.GetBytes(str);
            b = new MD5CryptoServiceProvider().ComputeHash(b);
            string ret = "";
            for (int i = 0; i < b.Length; i++)
            {
                ret += b[i].ToString("x").PadLeft(2, '0');
            }
            return ret;
        }

        /// <summary>
        /// base64 ����
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        internal static string Base64Encode(string str)
        {
            try
            {
                byte[] bytes_1 = Encoding.Default.GetBytes(str);
                return Convert.ToBase64String(bytes_1);
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// base64 ����
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        internal static string Base64Decode(string str)
        {
            try
            {
                byte[] bytes_2 = Convert.FromBase64String(str);
                return Encoding.Default.GetString(bytes_2);
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// ��������ַ�
        /// </summary>
        /// <param name="lens"></param>
        /// <returns></returns>
        internal static string RandomString(int lens)
        {
            char[] CharArray = {
                                   'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's'
                                   , 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K',
                                   'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2'
                                   , '3', '4', '5', '6', '7', '8', '9'
                               };
            int clens = CharArray.Length;
            string sCode = "";
            Random random = new Random();
            for (int i = 0; i < lens; i++)
            {
                sCode += CharArray[random.Next(clens)];
            }
            return sCode;
        }

        /// <summary>
        /// �ַ�����ȡ
        /// </summary>
        /// <param name="str"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        internal static string CutString(string str, int startIndex)
        {
            return CutString(str, startIndex, str.Length);
        }

        /// <summary>
        /// ���ַ�����ָ��λ�ý�ȡָ�����ȵ����ַ���
        /// </summary>
        /// <param name="str">ԭ�ַ���</param>
        /// <param name="startIndex">���ַ�������ʼλ��</param>
        /// <param name="length">���ַ����ĳ���</param>
        /// <returns>���ַ���</returns>
        internal static string CutString(string str, int startIndex, int length)
        {
            if (startIndex >= 0)
            {
                if (length < 0)
                {
                    length = length * -1;
                    if (startIndex - length < 0)
                    {
                        length = startIndex;
                        startIndex = 0;
                    }
                    else
                    {
                        startIndex = startIndex - length;
                    }
                }


                if (startIndex > str.Length)
                {
                    return "";
                }
            }
            else
            {
                if (length < 0)
                    return "";
                else
                {
                    if (length + startIndex > 0)
                    {
                        length = length + startIndex;
                        startIndex = 0;
                    }
                    else
                    {
                        return "";
                    }
                }
            }

            if (str.Length - startIndex < length)
            {
                length = str.Length - startIndex;
            }

            return str.Substring(startIndex, length);
        }

        /// <summary>
        /// ��ȫ���� url �ַ�����Ҫ���� winform ����
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        internal static string UrlEncode(string str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = Encoding.Default.GetBytes(str);
            for (int i = 0; i < byStr.Length; i++)
            {
                if ((byStr[i] < 58 && byStr[i] > 47) || (byStr[i] < 91 && byStr[i] > 64) ||
                    (byStr[i] < 123 && byStr[i] > 96))
                {
                    byte[] temp = { byStr[i] };
                    sb.Append(Encoding.ASCII.GetString(temp));
                }
                else
                {
                    sb.Append(@"%" + Convert.ToString(byStr[i], 16));
                }
            }

            return (sb.ToString());
        }
    }
}
