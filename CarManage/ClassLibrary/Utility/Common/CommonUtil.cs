using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassLibrary.Utility.Common
{
    public class CommonUtil
    {
        /// <summary>
        /// 过滤输入（移除首尾空格）
        /// </summary>
        /// <param name="input">输入</param>
        /// <returns>返回过滤后的字符串</returns>
        public static string FilterInput(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            return input.Trim();
        }
        /// <summary>
        /// 检查字符串，如果字符串为NULL，则返回空串
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CheckText(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return input;
        }

        /// <summary>
        /// 深度复制对象
        /// </summary>
        /// <typeparam name="T">源对象泛型</typeparam>
        /// <param name="input">源对象</param>
        /// <returns>返回复制后的新对象</returns>
        public static T DeepClone<T>(T input)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, input);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }

        private static Regex RegCHZN = new Regex("[\u4e00-\u9fff]");

        /// <summary> 
        /// 检查是否含有中文或中文标点
        /// </summary> 
        /// <param name="InputText">需要检查的字符串</param> 
        public static bool ContainsCNChar(string input)
        {
            //for (int i = 0; i < input.Length; i++)
            //{
            //    //汉字或中文标点
            //    if ((short)input[i] < 0 || (short)input[i] > 127)
            //    {
            //        return true;
            //    }
            //}

            //return false;

            return RegCHZN.IsMatch(input);
        }
    }
}
