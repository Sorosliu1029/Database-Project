using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BookSaleManagement
{
    class CPublic
    {
        // 用于记录登录用户信息的字符串数组
        public static string[] userInfo = new string[4];
        //完善用户信息时的用户名
        public static string userName;
        // 使用MD5加密字符串的方法
        public static string GetMd5Str(string myString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            // 获取字符串对应的字符数组
            byte[] fromData = System.Text.Encoding.Unicode.GetBytes(myString);
            // 获取哈希字符串数组
            byte[] toData = md5.ComputeHash(fromData);
            string byteStr = null;
            for (int i = 0; i < toData.Length; i++)
            {
                // 将字符数组连接还原成字符串,以十六进制的方式表示,不带前导"0x"
                byteStr += toData[i].ToString("x");
            }
            return byteStr;
        }
    }
}
