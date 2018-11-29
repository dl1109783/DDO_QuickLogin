using System;

namespace DataMaping.Attributes
{
    /// <summary>
    /// 主键标识
    /// [Key]
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class KeyAttribute : Attribute { }
    /// <summary>
    /// 设置字段类型
    /// Autoincrement字段需要2个条件
    /// 1.类型为Int64
    /// 2.只有一个主键
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DefaultValueAttribute : Attribute
    {
        public DefaultValue Default;
        public DefaultValueAttribute(DefaultValue defaultValue)
        {
            Default = defaultValue;
        }
    }

    /// <summary>
    /// 表名标识
    /// [Table("Config")]
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class TableAttribute : Attribute
    {
        public string TableName;
        public TableAttribute(string name)
        {
            TableName = name;
        }
    }
    /// <summary>
    /// 数据库连接标签-与DataBaseConfig中的Name字段对应
    /// [DataBase("SQL_TD")]
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DataBaseAttribute : Attribute
    {
        public string ConfigName;
        public DataBaseAttribute(string configName)
        {
            ConfigName = configName;
        }
    }
    /// <summary>
    /// 数据库类型
    /// </summary>
    public enum DataBaseType
    {
        SqlServer,
        Oracle,
        Sqlite,
        MySql
    }

    /// <summary>
    /// 字段类型
    /// </summary>
    public enum DefaultValue
    {
        Default,
        Autoincrement,
        DateTimeDefaultNow
    }

}
