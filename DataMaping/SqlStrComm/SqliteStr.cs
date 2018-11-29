using DataMaping.Attributes;
using System;
using System.Text;

namespace DataMaping.SqlStrComm
{
    public class SqliteStr : VStrComm
    {
        /// <summary>
        /// Sqlite创建表的Sql语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public override string CreateTable<T>(T model)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append($"CREATE TABLE {model.TableName}(");
            foreach (Property f in model.All)
            {
                var valueType = GetTypeOnSql(f.PropertyType);
                //默认值设置
                string defaultValue = "";
                switch (f.DataFieldType)
                {
                    //自增长
                    case DefaultValue.Autoincrement:
                        if (f.IsKey)
                        {
                            if (model.PK.Count == 1)
                            {
                                defaultValue = "AUTOINCREMENT ";
                                valueType = "INTEGER";
                            }
                            else throw new Exception("自增长字段不可用于组合主键");
                        }
                        break;
                    //当期时间
                    case DefaultValue.DateTimeDefaultNow:
                        defaultValue = " DEFAULT(STRFTIME('%Y-%m-%dT%H:%M:%f', 'NOW', 'LOCALTIME')) ";
                        break;
                    case DefaultValue.Default:
                    default:
                        break;
                }
                //字段名, 类型
                sbSql.Append($" [{f.Name}] {valueType} ");
                //主键
                if (f.IsKey)
                {
                    sbSql.Append($" PRIMARY KEY {defaultValue} NOT NULL ");
                }
                else
                {
                    sbSql.Append(defaultValue);
                }
                sbSql.Append(",");
            }
            return sbSql.ToString().TrimEnd(',') + ");";
        }
        /// <summary>
        /// 判断表示否存在
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public override string ExitsTable(string tableName)
        {
            return $" select count(1) from sqlite_master where type = 'table' and name = '{tableName}' ";
        }

        /// <summary>
        /// 数据类型对照
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public override string GetTypeOnSql(Type t)
        {
            var sqlType = "";
            var csType = t.ToString().ToUpper().Replace("SYSTEM.", "");
            switch (csType)
            {
                case "DECIMAL":
                case "DOUBLE":
                case "FLOAT":
                    sqlType = "REAL";
                    break;
                case "DATETIME":
                    sqlType = "DATETIME";
                    break;
                case "SHORT":
                case "INT16":
                case "INT32":
                case "UINT":
                case "UINT16":
                case "UINT32":
                    sqlType = "INT";
                    break;
                case "INT64":
                case "UINT64":
                    sqlType = "INTEGER";
                    break;
                case "STRING":
                default:
                    sqlType = "STRING";
                    break;
            }
            return sqlType;

        }

        /// <summary>
        /// 插入Sql语句
        /// </summary>
        /// <returns></returns>
        public override string Insert<T>(T model)
        {
            var list = model.All.FindAll(p => p.DataFieldType == DefaultValue.Default);
            return $" INSERT INTO [{model.TableName}] ({GetNameStr(list)}) VALUES ({GetValueStr<T>(model, list)})";
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public override string Update<T>(T model)
        {
            var list = model.All.FindAll(p => p.DataFieldType == DefaultValue.Default);
            return $" UPDATE [{model.TableName}] SET {GetEquationStr<T>(model, list)} WHERE 1=1 {GetEquationStr<T>(model, model.PK, "and")}";
        }
        /// <summary>
        /// 获取N条数据
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="count"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public override string TopData(string tableName, int count, string where)
        {
            return $"Select * from  [{tableName}] where 1=1 {where} limit {count}";
        }
        /// <summary>
        /// 获取自增长字段生成的ID
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public override string GetAutoincrementID(string TableName)
        {
            //select last_insert_rowid() from person
            return $"SELECT seq from SQLITE_SEQUENCE where name='{TableName}'";
        }
    }
}
