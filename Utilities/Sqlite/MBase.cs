using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Utilities.Sqlite
{
    public class MBase
    {
        public MBase()
        {
            //通过反射获取类名,作为表名
            TableName = this.GetType().Name;
            PK = new List<Property>();
            Other = new List<Property>();
            All = new List<Property>();
            //GetPropertys取字段,不带get set; 
            //GetProperties取属性, 带有get set  
            var fl = this.GetType().GetProperties();
            foreach (PropertyInfo i in fl)
            {
                Property f = new Property()
                {
                    Name = i.Name,
                    PropertyType = i.PropertyType
                };

                //判断字段是否包含[key]标记
                f.IsKey = i.GetCustomAttributes(typeof(KeyAttribute), true).Length > 0;
                f.IsAutoincrement = i.GetCustomAttributes(typeof(AutoincrementAttribute), true).Length > 0;
                if (f.IsAutoincrement)
                {
                    AutoincrementPropertyName = i.Name;
                }
                if (f.IsKey)
                {
                    PK.Add(f);
                }
                else
                {
                    Other.Add(f);
                }
                All.Add(f);
            }
        }
        /// <summary>
        /// 主键字段
        /// </summary>
        private List<Property> PK;
        /// <summary>
        /// 非主键字段
        /// </summary>
        private List<Property> Other;
        /// <summary>
        /// 所有字段
        /// </summary>
        private List<Property> All;
        private string AutoincrementPropertyName;
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName;
        /// <summary>
        /// 创建表
        /// </summary>
        /// <returns></returns>
        public bool CreateTable()
        {
            //GetValueChange();
            if (SqliteHelper.ExitsTable(TableName))
            {
                return false;
            }
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append($"CREATE TABLE {TableName}(");
            foreach (Property f in PK)
            {
                if (f.IsAutoincrement)
                {
                    sbSql.Append($" [{f.Name}]  INTEGER  PRIMARY KEY AUTOINCREMENT NOT NULL, ");
                }
                else
                {
                    sbSql.Append($" [{f.Name}]  {f.SqlType } PRIMARY KEY NOT NULL, ");
                }
            }
            foreach (Property f in Other)
            {
                sbSql.Append($" [{f.Name}]  {f.SqlType } ,");
            }
            return SqliteHelper.Execute(sbSql.ToString().TrimEnd(',') + ");") != 0;
        }
        /// <summary>
        /// 判断记录是否存在
        /// </summary>
        /// <returns></returns>
        public bool IsExits()
        {
            GetValueChange();
            if (PK.Count < 1) throw new Exception("PK数组长度为0,请检测是否存在PK");
            foreach (Property f in PK)
            {
                if (string.IsNullOrEmpty(f.Value))
                {
                    throw new Exception("主键不能为空,请检查主键的值是否正确");
                }
            }
            if (!SqliteHelper.ExitsTable(TableName))
            {
                CreateTable();
                return false;
            }
            return SqliteHelper.Exits(TableName, GetEquationStr(PK, "and"));
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <returns></returns>
        public bool Del()
        {
            GetValueChange();
            return SqliteHelper.Del(TableName, GetEquationStr(PK, "and")); ;
        }
        public bool GetLast()
        {
            if (!string.IsNullOrWhiteSpace(AutoincrementPropertyName))
            {
                var dt = SqliteHelper.GetDataTable($"select  {GetNameStr(All, "Max")}  from {TableName} ;  ");
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (dr[dc.ColumnName] != DBNull.Value)
                            this.GetType().GetProperty(dc.ColumnName)?.SetValue(this, dr[dc.ColumnName]);
                    }
                    return true;
                }
            }
            return false;
        }
        public DataTable GetTop(int count)
        {
            if (!string.IsNullOrWhiteSpace(AutoincrementPropertyName))
            {
                var dt = SqliteHelper.GetDataTable($"select {GetNameStr(All)}  from { TableName}   order by[{AutoincrementPropertyName}] desc limit 0,{count};");
                return dt;
            }
            else return null;
        }
        /// <summary>
        /// 获取所有数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetData(string where)
        {
            var dt = SqliteHelper.GetDataTable($"select {GetNameStr(All)} from {TableName} where 1=1 {where}");
            return dt;
        }
        public List<T> GetList<T>(string where) where T : new()
        {
            DataTable dt = GetData(where);
            List<T> ls = new List<T>();
            foreach (DataRow dr in dt.Rows)
            {
                T temp = new T();
                //T temp = System.Activator.CreateInstance<T>();
                foreach (DataColumn dc in dt.Columns)
                {
                    if (dr[dc.ColumnName] != DBNull.Value)
                        temp.GetType().GetProperty(dc.ColumnName)?.SetValue(temp, dr[dc.ColumnName]);
                }
                ls.Add(temp);
            }
            return ls;
        }
        /// <summary>
        /// 根据PK获得Model的其他数据
        /// </summary>
        public bool GetModel()
        {
            GetValueChange();
            var dt = GetData(GetEquationStr(PK, "and"));
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                foreach (DataColumn dc in dt.Columns)
                {
                    if (dr[dc.ColumnName] != DBNull.Value)
                        this.GetType().GetProperty(dc.ColumnName)?.SetValue(this, dr[dc.ColumnName]);
                }
                return true;
            }
            return false;
        }
        public bool Add()
        {
            GetValueChange();
            StringBuilder sbSql = new StringBuilder();
            List<Property> list = All.Clone();
            if (!string.IsNullOrWhiteSpace(AutoincrementPropertyName))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].IsAutoincrement)
                    {
                        list.Remove(list[i]);
                    }
                }
            }
            sbSql.Append($"INSERT INTO {TableName} ");
            sbSql.Append($"({GetNameStr(list)   } ) ");
            sbSql.Append($"VALUES ({GetValueStr(list)} );");
            bool res = SqliteHelper.Execute(sbSql.ToString()) > 0;
            if (res && !string.IsNullOrWhiteSpace(AutoincrementPropertyName))
            {
                var id = SqliteHelper.ExecuteScalar($"SELECT seq from SQLITE_SEQUENCE where name='{TableName}'");
                if (id != null && id != DBNull.Value)
                {
                    if (int.TryParse(id.ToString(), out int i))
                    {
                        this.GetType()?.GetProperty(AutoincrementPropertyName)?.SetValue(this, i);
                        //讲值的变化映射到List中
                        GetValueChange();
                    }
                }
            }
            return res;
        }
        public bool Update()
        {
            GetValueChange();
            StringBuilder sbSql = new StringBuilder();
            //update 
            sbSql.Append($"UPDATE  {TableName} ");
            sbSql.Append($" SET {GetEquationStr(All)} ");
            sbSql.Append($"WHERE 1=1  {GetEquationStr(PK, "and")}  ");
            return SqliteHelper.Execute(sbSql.ToString()) > 0;
        }
        /// <summary>
        /// 保存Model, 根据PK检索, 数据库中不存在则Insert ,已有数据则Update
        /// 保存时会检查是否存在数据库文件, 是否存在表, 如不存在则会创建数据库和表, so. 直接保存吧少年 ^_^
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            if (IsExits())
            {
                return Update();
            }
            else
            {
                return Add();
            }
        }

        #region comm
        /// <summary>
        /// 获取值的变化并同步到List中
        /// 执行过赋值操作后请至少执行一次此方法
        /// </summary>
        public void GetValueChange()
        {
            for (int i = 0; i < All.Count; i++)
            {
                var value = this.GetType()?.GetProperty(All[i].Name)?.GetValue(this);
                if (value != null)
                {
                    //C#7 Pattern Matching(匹配模式)
                    switch (value)
                    {
                        case DateTime dt:
                            if (dt.Year == 1)
                            {
                                All[i].Value = "1900-01-01 00:00:00";
                            }
                            else All[i].Value = dt.ToString("s");
                            break;
                        default:
                            All[i].Value = value.ToString();
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// 按照参数拼装字段名
        /// </summary>
        /// <param name="lf"></param>
        /// <returns></returns>
        public string GetNameStr(List<Property> lf, string prefix = "")
        {
            StringBuilder sbName = new StringBuilder();
            foreach (Property f in lf)
            {
                if (f.IsAutoincrement && !string.IsNullOrWhiteSpace(prefix))
                {
                    sbName.Append($"{prefix}([{f.Name}]) ,");
                }
                else sbName.Append($" [{f.Name}] ,");
            }
            return sbName.ToString().TrimEnd(',');
        }
        /// <summary>
        /// 按照参数拼装值
        /// </summary>
        /// <param name="lf"></param>
        /// <returns></returns>
        public string GetValueStr(List<Property> lf)
        {
            StringBuilder sbValue = new StringBuilder();
            foreach (Property f in lf)
            {
                sbValue.Append($" '{f.Value}' ,");
            }
            return sbValue.ToString().TrimEnd(',');
        }

        /// <summary>
        /// 按照参数拼装更新语句
        /// </summary>
        /// <param name="lf"></param>
        /// <returns></returns>
        public string GetEquationStr(List<Property> lf, string prefix = "")
        {
            StringBuilder sbKey = new StringBuilder();
            foreach (Property f in lf)
            {
                sbKey.Append($" {prefix} [{f.Name}]='{f.Value}' ,");
            }
            return sbKey.ToString().TrimEnd(',');

        }
        #endregion

    }
    /// <summary>
    /// 主键标识
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class KeyAttribute : Attribute { }
    /// <summary>
    /// 自动生成的字段
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class AutoincrementAttribute : Attribute { }
    //insert into test (des) values('aaa');SELECT seq from SQLITE_SEQUENCE where name='test'; 
    /// <summary>
    /// 字段描述对象
    /// </summary>
    public class Property : ICloneable
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        public string Name;
        /// <summary>
        /// 字段值
        /// </summary>
        public string Value;
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
        public bool IsAutoincrement;
        /// <summary>
        /// 在数据库中的类型映射
        /// </summary>
        public string SqlType {
            get {
                string sqlType = "VARCHAR";
                if (PropertyType != null)
                {

                    switch (PropertyType.ToString().ToUpper())
                    {
                        case "SYSTEM.DECIMAL":
                        case "SYSTEM.DOUBLE":
                        case "SYSTEM.FLOAT":
                            sqlType = "REAL";
                            break;
                        case "SYSTEM.DATETIME":
                            sqlType = "DATETIME DEFAULT('1900-01-01 00:00:00')";
                            break;
                        case "SYSTEM.SHORT":
                        case "SYSTEM.INT16":
                        case "SYSTEM.INT32":
                        case "SYSTEM.UINT":
                        case "SYSTEM.UINT16":
                        case "SYSTEM.UINT32":
                            sqlType = "INT";
                            break;
                        default:
                            sqlType = PropertyType.ToString().ToUpper().Replace("SYSTEM.", "");
                            break;
                    }
                }
                return sqlType;
            }
        }
        public object Clone()
        {
            return new Property() { Name = Name, Value = Value, PropertyType = PropertyType, IsKey = IsKey, IsAutoincrement = IsAutoincrement };
        }
    }

    public static class Ex
    {
        public static List<T> Clone<T>(this List<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }

}
