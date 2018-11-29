using System;
using System.Collections.Generic;
using System.Linq;
namespace Utilities.Extend
{
    public static class GeneralExtend
    {
        public static string To16String(this Guid g)
        {
            var l = g.ToByteArray().Aggregate<byte, long>(1, (current, b) => current * (b + 1));
            return $"{l - DateTime.Now.Ticks:x}";
        }
        /// <summary>
        /// 移除末尾的指定字符
        /// </summary>
        /// <param name="s"></param>
        /// <param name="endChar"></param>
        /// <returns></returns>
        public static string RemoveEndChar(this string s, string endChar)
        {
            if (!string.IsNullOrEmpty(s) && s.EndsWith(endChar))
            {
                return s.Remove(s.LastIndexOf(endChar));
            }
            else return s;
        }

        /// <summary>
        /// 获取当前对象的名称
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static object GetName(this object self)
        {
            return self?.GetType()?.Name;
        }

        /// <summary>
        /// 数组添加,返回新数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bBig"></param>
        /// <param name="bSmall"></param>
        /// <returns></returns>
        public static T[] Add<T>(this T[] bBig, T[] bSmall)
        {
            T[] tmp = new T[bBig.Length + bSmall.Length];
            Buffer.BlockCopy(bBig, 0, tmp, 0, bBig.Length);
            Buffer.BlockCopy(bSmall, 0, tmp, bBig.Length, bSmall.Length);
            return tmp;
        }

        /// <summary>
        /// 复制泛型数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listToClone"></param>
        /// <returns></returns>
        public static List<T> Clone<T>(this List<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }

    }
}
