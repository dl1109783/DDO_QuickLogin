using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace Utilities.Extend
{
    public static class TypeConvert
    {
        /// <summary>
        /// 将当前string转换成int
        /// </summary>
        /// <param name="t"></param>
        /// <param name="defVal">不能转换成Int时的默认方法. 默认为0</param>
        /// <returns></returns>
        public static int ToInt<T>(this T t, int defVal = 0)
        {
            int res = 0;
            //微软推荐使用TryParse转换类型.
            if (t != null && int.TryParse(t.ToString(), out res))
            {
                return res;
            }
            else return defVal;
        }
        /// <summary>
        /// 转为decimal
        /// </summary>
        /// <param name="t"></param>
        /// <param name="defVal"></param>
        /// <returns></returns>
        public static decimal ToDecimal<T>(this T t, decimal defVal = 0)
        {
            decimal res = defVal;
            //微软推荐使用TryParse转换类型.
            if (t != null && decimal.TryParse(t.ToString(), out res))
            {
                return res;
            }
            else return defVal;
        }

        /// <summary>
        /// 转为日期型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime ToDateTime<T>(this T date)
        {
            DateTime tmp = new DateTime(0);
            DateTime.TryParse(date.ToString(), out tmp);
            return tmp;
        }
        /// <summary>
        /// DataTable转换为List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<T> ToList<T>(this DataTable dt) where T : new()
        {
            List<T> ls = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                T temp = new T();
                ls.Add(dr.ToPropertyModel<T>(dt.Columns, temp));
            }
            return ls;
        }
        /// <summary>
        /// 把DataTable中的第一行转换为Model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <param name="temp"></param>
        /// <returns></returns>
        public static T ToModel<T>(this DataTable dt, T temp)
        {
            return ToPropertyModel(dt.Rows[0], dt.Columns, temp);
        }
        /// <summary>
        /// 将一行DataRow变为一个Model
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <param name="Columns"></param>
        /// <returns></returns>
        public static T ToPropertyModel<T>(this DataRow dr, DataColumnCollection Columns, T temp)
        {
            foreach (DataColumn dc in Columns)
            {
                if (dr[dc.ColumnName] != DBNull.Value)
                {
                    var value = dr[dc.ColumnName];
                    SetValue(temp, dc.ColumnName, value);
                }
            }
            return temp;
        }
        /// <summary>
        /// 通过反射设置字段的值
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fieldName"></param>
        /// <param name="val"></param>
        public static void SetValue(object model, string fieldName, object val)
        {
            var property = model.GetType().GetProperty(fieldName);
            object value = null;
            if (val?.ToString().Trim() != "")
            {
                switch (property.PropertyType.Name)
                {
                    case "Guid":
                        value = new Guid(val.ToString());
                        break;
                    case "TimeSpan":
                        value = TimeSpan.Parse(val.ToString());
                        break;
                    default:
                        if (!property.PropertyType.IsGenericType)
                        {
                            //如果是枚举型
                            if (property.PropertyType.BaseType == typeof(Enum))
                            {
                                value = Enum.Parse(property.PropertyType, val.ToString());
                            }
                            else value = Convert.ChangeType(val, property.PropertyType);
                        }
                        else
                        {
                            Type genericTypeDefinition = property.PropertyType.GetGenericTypeDefinition();
                            if (genericTypeDefinition == typeof(Nullable<>))
                            {
                                value = Convert.ChangeType(val, Nullable.GetUnderlyingType(property.PropertyType));
                            }
                        }
                        break;
                }
            }
            property.SetValue(model, value, null);
        }
        public static T ToFieldModel<T>(this DataRow dr, DataColumnCollection Columns, T temp)
        {
            //T temp = System.Activator.CreateInstance<T>();
            foreach (DataColumn dc in Columns)
            {
                if (dr[dc.ColumnName] != DBNull.Value)
                    //带有{get;set}的类是Property需要把下面的GetField替换成GetProperty,否则不能赋值
                    temp.GetType().GetField(dc.ColumnName)?.SetValue(temp, dr[dc.ColumnName]);
            }
            return temp;
        }
        /// <summary>
        /// 泛型类型转换
        /// </summary>
        /// <typeparam name="T">要转换的基础类型</typeparam>
        /// <param name="val">要转换的值</param>
        /// <returns></returns>
        public static T ConvertType<T>(this object val)
        {
            if (val == null) return default(T);//返回类型的默认值
            Type tp = typeof(T);
            //泛型Nullable判断，取其中的类型
            if (tp.IsGenericType)
            {
                tp = tp.GetGenericArguments()[0];
            }
            //string直接返回转换
            if (tp.Name.ToLower() == "string")
            {
                return (T)val;
            }

            //反射获取TryParse方法
            var TryParse = tp.GetMethod("TryParse", BindingFlags.Public | BindingFlags.Static, Type.DefaultBinder,
                                            new Type[] { typeof(string), tp.MakeByRefType() },
                                            new ParameterModifier[] { new ParameterModifier(2) });
            var parameters = new object[] { val.ToString(), Activator.CreateInstance(tp) };
            bool success = (bool)TryParse.Invoke(null, parameters);
            //成功返回转换后的值，否则返回类型的默认值
            if (success)
            {
                return (T)parameters[1];
            }
            return default(T);
        }

        #region 16进制数据转换
        /// <summary>
        /// 将16进制BYTE数组转换成16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ToHexString(this byte[] bytes, string strSplit = "")
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("X2") + strSplit);
                }
                hexString = strB.ToString();
            }
            return hexString;
        }

        /// <summary>
        /// HexString转Byte数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        public static byte[] HexStrToHexByte(this string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
            return returnBytes;
        }

        /// <summary>
        /// String转Byte数组
        /// </summary>
        /// <param name="ASII_Str"></param>
        /// <returns></returns>
        public static byte[] ToHexByte(this string ASII_Str)
        {
            return Encoding.ASCII.GetBytes(ASII_Str);
        }

        /// <summary>
        /// 将16进制ushort数组转换成16进制字符串
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string ToHexString(this ushort[] ushorts, string strSplit = "")
        {
            string hexString = string.Empty;
            if (ushorts != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < ushorts.Length; i++)
                {
                    strB.Append(ushorts[i].ToString("X2") + strSplit);
                }
                hexString = strB.ToString();
            }
            return hexString;
        }
        #endregion







    }
}
