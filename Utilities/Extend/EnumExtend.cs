using System;

namespace Utilities.Extend
{
    public static class EnumExtend
    {
        /// <summary>
        /// 获得名称
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string GetName<T>(this T self) where T : struct
        {
            return Enum.GetName(typeof(T), self);
        }
        /// <summary>
        /// 获得值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int GetValue<T>(this T self) where T : struct
        {
            return self.GetHashCode();
        }
        /// <summary>
        /// 名称转值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string GetNameByValue<T>(this int Value) where T : struct
        {
            return Enum.GetName(typeof(T), Value);
        }
        /// <summary>
        /// 值转名称
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static int GetValueByName<T>(this string Name) where T : struct
        {
            return (int)Enum.Parse(typeof(T), Name);
        }

        /// <summary>
        /// 通过名称获得Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static T GetEnum<T>(this string Name) where T : struct
        {
            if (Enum.TryParse<T>(Name, out T enu))
            {
                return enu;
            }
            else throw new Exception($"{Name} 不存在于枚举类型中");
        }
        /// <summary>
        /// 通过值获得Enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static T GetEnum<T>(this int Value) where T : struct
        {
            return (T)Enum.ToObject(typeof(T), Value);
        }
    }
}
/*测试
var a = SensorType.光照度传感器;
var n = a.GetName<SensorType>();
var v = a.GetValue<SensorType>();
Trace.TraceInformation(n);
Trace.TraceInformation(v.ToString());

var xn = v.GetNameByValue<SensorType>();
var xv = n.GetValueByName<SensorType>();
Trace.TraceInformation(xn);
Trace.TraceInformation(xv.ToString());

var en = xn.GetEnum<SensorType>();
var ev = xv.GetEnum<SensorType>();
Trace.TraceInformation(en.ToString());
Trace.TraceInformation(ev.ToString());
*/
