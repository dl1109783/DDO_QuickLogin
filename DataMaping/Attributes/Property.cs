using System;
using System.Reflection;

namespace DataMaping.Attributes
{
    public class Property
    {
        public PropertyInfo proInfo;
        public Property(PropertyInfo pInfo)
        {
            Name = pInfo.Name;
            proInfo = pInfo;
            PropertyType = pInfo.PropertyType;
            //判断字段是否包含key标记
            IsKey = pInfo.GetCustomAttributes(typeof(KeyAttribute), true).Length > 0;
            //获得字段的特殊数据类型(Guid 自增长字段等)
            var dbAttribute = (DefaultValueAttribute)pInfo.GetCustomAttribute(typeof(DefaultValueAttribute));
            DataFieldType = dbAttribute == null ? DefaultValue.Default : dbAttribute.Default;
        }

        /// <summary>
        /// 字段名称
        /// </summary>
        public string Name;
        /// <summary>
        /// 字段值
        /// </summary>
        public object GetValue<T>(T model)
        {
            var prty = model.GetType()?.GetProperty(Name);
            var val = prty?.GetValue(model);
            var type = prty?.PropertyType;
            if (type == typeof(DateTime))
            {
                if (((DateTime)val) < new DateTime(1900, 1, 1))
                {
                    return new DateTime(1900, 1, 1).ToString("s");
                }
                else return ((DateTime)val).ToString("s");
            }
            return val;
        }
        /// <summary>
        /// 字段类型
        /// </summary>
        public Type PropertyType;
        /// <summary>
        /// 是否主键
        /// </summary>
        public bool IsKey;
        /// <summary>
        /// 是否是自动生成的字段
        /// </summary>
        public DefaultValue DataFieldType;
    }
}
