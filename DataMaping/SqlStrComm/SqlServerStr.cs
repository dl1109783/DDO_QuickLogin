using DataMaping.Attributes;
using System;
using System.Text;

namespace DataMaping.SqlStrComm
{
    public class SqlServerStr : VStrComm
    {
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
                        defaultValue = " IDENTITY ";
                        valueType = "int";
                        break;
                    //当期时间
                    case DefaultValue.DateTimeDefaultNow:
                        defaultValue = " DEFAULT (getdate()) ";
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
                    sbSql.Append(defaultValue + " NULL ");
                }
                sbSql.Append(",");
            }
            return sbSql.ToString().TrimEnd(',') + ");";
        }

        public override string ExitsTable(string tableName)
        {
            return $"SELECT count(1) FROM dbo.SysObjects WHERE ID = object_id(N'[{tableName}]') AND OBJECTPROPERTY(ID, 'IsTable') = 1";
        }
        public override string TopData(string tableName, int count, string where)
        {
            return $"Select Top {count} * from  [{tableName}] where 1=1 {where} ";
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
        public override string GetTypeOnSql(Type t)
        {
            var sqlType = "";
            var csType = t.ToString().ToUpper().Replace("SYSTEM.", "");
            switch (csType)
            {
                case "BOOLEAN":
                    sqlType = "BIT";
                    break;
                case "BYTE":
                case "SBYTE":
                    sqlType = "TINYINT";
                    break;

                case "UINT32":
                case "UINT16":
                case "INT16":
                case "INT32":
                    sqlType = "INT";
                    break;
                case "INT64":
                case "LONG":
                    sqlType = "BIGINT";
                    break;
                case "SINGLE":
                case "FLOAT":
                case "UINT64":
                    sqlType = "REAL";
                    break;
                case "DOUBLE":
                    sqlType = "FLOAT";
                    break;
                case "DECIMAL":
                    sqlType = "DECIMAL(18,2)";
                    break;
                case "DATETIME":
                    sqlType = "DATETIME";
                    break;
                case "BYTE[]":
                    sqlType = "BINARY";
                    break;
                case "CHAR":
                    sqlType = "CHAR";
                    break;
                case "GUID":
                    sqlType = "UNIQUEIDENTIFIER";
                    break;
                case "STRING":
                default:
                    sqlType = "NVARCHAR(50)";
                    break;
            }
            return sqlType;
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
        /// 2、@@identity系统函数：该用处在执行阶段，用于捕获最近一次插入数据所产生的自增号。在应用程序中非常有用，比如新增一个新数据，然后获取该id，接着用于查询显示。
        /// 3、IDENT_CURRENT('数据表名')：可以找出指定表的目前最大自增号，可以取代SELECT MAX语句，加快查询。特别是在大并发的时候，如果用SELECT MAX可能会出现获取不正确的序号，而且当表非常大的时候SELECT MAX也是需要很长时间的。
        /// 4、SCOPE_IDENTITY()函数：在存储过程、触发器执行过程中的自增加号数。但和@@identity有些不同，@@identity返回的是整个事务中的目前值，而本函数仅返回该存储过程、触发器程序中的新增数据表的号码。@@identity在一个事务有延伸或调用另外一个表的INDENTITY属性是，会产生差异，而本函数主要用于处理这种问题。
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public override string GetAutoincrementID(string TableName)
        {
            return $" select IDENT_CURRENT ('{TableName}') ";
        }
    }
}
