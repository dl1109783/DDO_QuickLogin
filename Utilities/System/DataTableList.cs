using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Utilities.System
{
    public static class DataTableList
    {
        /// <summary>
        /// IList 转换 DataTable
        /// </summary>
        /// <typeparam name="TSource">model</typeparam>
        /// <param name="data">List</param>
        /// <returns>DataTable集合</returns>
        public static DataTable ToDataTable<TSource>(this IList<TSource> data)
        {
            DataTable dataTable = new DataTable(typeof(TSource).Name);
            PropertyInfo[] props = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ??
                    prop.PropertyType);
            }

            foreach (TSource item in data)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        /// <summary>
        /// DataTable 转换 List
        /// </summary>
        /// <typeparam name="TSource">model</typeparam>
        /// <param name="dataTable">DataTable集合</param>
        /// <returns>List集合</returns>
        public static List<TSource> ToList<TSource>(this DataTable dataTable) where TSource : new()
        {
            var dataList = new List<TSource>();
            if (dataTable == null)
            {
                return null;
            }
            //const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;
            //var objFieldNames = (from PropertyInfo aProp in typeof(TSource).GetProperties(flags)
            //                     select new
            //                     {
            //                         Name = aProp.Name,
            //                         Type = Nullable.GetUnderlyingType(aProp.PropertyType) ??
            //                 aProp.PropertyType
            //                     }).ToList();
            //var dataTblFieldNames = (from DataColumn aHeader in dataTable.Columns
            //                         select new
            //                         {
            //                             Name = aHeader.ColumnName,
            //                             Type = aHeader.DataType
            //                         }).ToList();
            //var commonFields = objFieldNames.Intersect(dataTblFieldNames).ToList();

            //foreach (DataRow dataRow in dataTable.AsEnumerable().ToList())
            //{
            //    var aTSource = new TSource();
            //    foreach (var aField in commonFields)
            //    {
            //        PropertyInfo propertyInfos = aTSource.GetType().GetProperty(aField.Name);
            //        var value = (dataRow[aField.Name] == DBNull.Value) ?
            //            null : dataRow[aField.Name] == "null" ? "" : dataRow[aField.Name]; //if database field is nullable
            //        propertyInfos.SetValue(aTSource, value, null);
            //    }
            //    dataList.Add(aTSource);
            //}
            //return dataList;


            //创建一个属性的列表
            List<PropertyInfo> prlist = new List<PropertyInfo>();
            //获取TResult的类型实例  反射的入口
            Type t = typeof(TSource);
            //获得TResult 的所有的Public 属性 并找出TResult属性和DataTable的列名称相同的属性(PropertyInfo) 并加入到属性列表 
            Array.ForEach<PropertyInfo>(t.GetProperties(), p => { if (dataTable.Columns.IndexOf(p.Name) != -1) prlist.Add(p); });

            foreach (DataRow row in dataTable.Rows)
            {
                //创建TResult的实例
                TSource ob = new TSource();

                //找到对应的数据  并赋值
                prlist.ForEach(p => { if (row[p.Name] != DBNull.Value) p.SetValue(ob, ChangeType(row[p.Name],p.PropertyType), null); });
                //放入到返回的集合中.
                dataList.Add(ob);
            }
            return dataList;
        }

        ///     将数据转化为 type 类型
        /// </summary>
        /// <param name="value">要转化的值</param>
        /// <param name="type">目标类型</param>
        /// <returns>转化为目标类型的 Object 对象</returns>
        private static object ChangeType(object value, Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                NullableConverter convertor = new NullableConverter(type);
                return Convert.IsDBNull(value) ? null : convertor.ConvertFrom(value);
            }
            return Convert.ChangeType(Convert.IsDBNull(value) ? null : value, type);
        }

    }
}
