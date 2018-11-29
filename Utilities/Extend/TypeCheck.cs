using System;
using System.Text.RegularExpressions;

namespace Utilities.Extend
{
    public static class TypeCheck
    {
        /// 判断是否是无符号整数
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsInt<T>(this T t)
        {
            return Regex.IsMatch(t?.ToString().Trim() ?? "", @"^\d+$");
        }
        /// <summary>
        /// 判断是否是有符号整数
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool IsInt32<T>(this T t)
        {
            return Regex.IsMatch(t?.ToString().Trim() ?? "", @"^ -?\d +$");
        }
        /// <summary>
        /// 判断值是否在范围内
        /// </summary>
        /// <param name="strNo"></param>
        /// <param name="iBeginInt"></param>
        /// <param name="iEndInt"></param>
        /// <returns></returns>
        public static bool IsInt<T>(this T strNo, int iBeginInt, int iEndInt)
        {
            if (!IsInt(strNo)) return false;
            int num = 0;
            if (!int.TryParse(strNo.ToString(), out num)) return false;
            if (num > iEndInt) return false;
            if (num < iBeginInt) return false;
            return true;
        }
        /// <summary>
        /// 判断是否偶数
        /// </summary>
        /// <param name="intI">需要判断的数</param>
        /// <returns>True偶数，False奇数</returns>
        public static bool IsEven(this int intI)
        {
            int s = 0;
            Math.DivRem(intI, 2, out s);
            return s == 0;
        }
        /// <summary>
        /// 判断Object是否是日期型
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool IsDateTime<T>(this T date)
        {
            DateTime tmp = new DateTime();
            return DateTime.TryParse(date.ToString(), out tmp);
        }





















    }
}
