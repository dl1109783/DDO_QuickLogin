using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using DataMaping.Attributes;
using DataMaping.Config;
using DataMaping.DatabaseComm;
using DataMaping.SqlStrComm;
using Newtonsoft.Json;
using Utilities.Extend;
using Utilities.General;

namespace DataMaping
{
    [JsonObject(MemberSerialization.OptOut)]
    public class MBase
    {
        [JsonIgnore]
        public ISqlHelper sql;
        [JsonIgnore]
        public VStrComm cmdStr;
        /// <summary>
        /// 表名
        /// </summary>
        [JsonIgnore]
        public string TableName;
        [JsonIgnore]
        public DataBaseType MyDataBaseType;
        /// <summary>
        /// 所有字段
        /// </summary>
        [JsonIgnore]
        public List<Property> All;
        [JsonIgnore]
        public List<Property> Other;
        [JsonIgnore]
        public List<Property> PK;

        /// <summary>
        /// 构造函数
        /// </summary>
        public MBase()
        {
            var ConnStr = string.Empty;
            var isInit = false;
            //获得数据库类型
            var dbAttribute = (DataBaseAttribute)this.GetType().GetCustomAttribute(typeof(DataBaseAttribute));
            //如果标签里设置了数据库类型就取设置里的
            if (dbAttribute != null)
            {
                DataBaseConfig config = new DataBaseConfig(dbAttribute.ConfigName);
                MyDataBaseType = config.DataBase;//.GetEnum<DataBaseType>()
                ConnStr = config.ConnStr;
                isInit = config.Init;
            }
            //如果标签没有设置数据库类型就取配置文件里的
            else
            {
                MyDataBaseType = DataBaseType.Sqlite;
                string dbPath = $"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}\\DataBase\\";
                FileHelper.CheckDir(dbPath);
                ConnStr = "Data Source=\".\\DataBase\\AppConfig.db\";Pooling=true;FailIfMissing=false;Synchronous=Off;Journal Mode=WAL;Cache Size=5000";
                isInit = true;
            }

            //获取标签里的表名
            var tableAttribute = (TableAttribute)this.GetType().GetCustomAttribute(typeof(TableAttribute));
            //如果标注里有指定表名则按照标注
            if (tableAttribute != null)
            {
                TableName = tableAttribute.TableName;
            }
            else
            {
                //通过反射获取类名,作为表名 
                TableName = this.GetType().Name;
                //Fix bug, 泛型model反射取得的类名会带有`1字符
                if (TableName.IndexOf('`') > 0)
                {
                    TableName = TableName.Substring(0, TableName.IndexOf('`'));
                }
            }



            //将Model的属性放入List列表方便查询
            All = new List<Property>();
            //GetFields取字段,不带get set; 
            //GetProperties取属性, 带有get set  
            var fl = this.GetType().GetProperties();
            foreach (PropertyInfo i in fl)
            {
                All.Add(new Property(i));
            }
            Other = All.Where(p => !p.IsKey).ToList<Property>();
            PK = All.Where(p => p.IsKey).ToList<Property>();

            //实例数据库访问类
            switch (MyDataBaseType)
            {
                case DataBaseType.MySql:
                    break;
                case DataBaseType.Oracle:
                    break;
                case DataBaseType.Sqlite:
                    sql = new SqlComm<SQLiteConnection, SQLiteCommand, SQLiteDataAdapter>(ConnStr);
                    cmdStr = new SqliteStr();
                    break;
                case DataBaseType.SqlServer:
                    sql = new SqlComm<SqlConnection, SqlCommand, SqlDataAdapter>(ConnStr);
                    cmdStr = new SqlServerStr();
                    break;
                default:
                    break;
            }
            if (isInit && !ExitsTable())
            {
                CreateTable();
            }
        }


        /// <summary>
        /// 判断表是否存在
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public bool ExitsTable()
        {
            var sqlStr = cmdStr.ExitsTable(TableName);
            return sql.ExecuteScalar<int>(sqlStr) != 0;
        }

        /// <summary>
        /// 创建表
        /// </summary>
        /// <returns></returns>
        public bool CreateTable()
        {
            var sqlStr = cmdStr.CreateTable(this);
            return sql.Execute(sqlStr) != 0;
        }

        /// <summary>
        /// 插入
        /// </summary>
        /// <returns></returns>
        public bool Insert()
        {
            var sqlStr = cmdStr.Insert(this);
            bool res = sql.Execute(sqlStr) != 0;
            if (res)
            {
                var list = All.FindAll(p => p.DataFieldType == DefaultValue.Autoincrement);
                if (list.Count > 0)
                {
                    sqlStr = cmdStr.GetAutoincrementID(TableName);
                    var val = sql.ExecuteScalar<Int64>(sqlStr);
                    TypeConvert.SetValue(this, ((Property)list[0]).Name, val);
                }
            }
            return res;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public bool Del()
        {
            var sqlStr = cmdStr.Del(this);
            return Del(sqlStr);
        }
        public bool Del(string Sql)
        {
            return sql.Execute(Sql) != 0;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            var sqlStr = cmdStr.Update(this);
            return sql.Execute(sqlStr) != 0;
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            if (Exits())
            {
                return Update();
            }
            else
            {
                return Insert();
            }
        }
        /// <summary>
        /// 判断主键对应的记录是否存在                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        /// </summary>
        /// <returns></returns>
        public bool Exits()
        {
            var sqlStr = cmdStr.Exits(this);
            //检查记录
            return sql.ExecuteScalar<int>(sqlStr) != 0;
        }

        /// <summary>
        /// 获得当前对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns> 
        public void GetModel(string sqlStr = "")
        {
            if (string.IsNullOrEmpty(sqlStr)) sqlStr = cmdStr.GetModel(this);
            else sqlStr = cmdStr.Select(this, sqlStr);
            var dt = sql.GetDataTable(sqlStr);
            if (dt.Rows.Count > 0)
            {
                dt.Rows[0].ToPropertyModel(dt?.Columns, this);
            }
        }
        /// <summary>
        /// 按照条件获得前N条记录
        /// </summary>
        /// <param name="where"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public DataTable GetTopData(int count, string where = "")
        {
            var sqlStr = cmdStr.TopData(TableName, count, where);
            return sql.GetDataTable(sqlStr);
        }
        /// <summary>
        /// 根据条件获取数据
        /// </summary>
        /// <param name="Where"></param>
        /// <returns></returns>
        public DataTable GetTable(string Where = "")
        {
            var sqlStr = cmdStr.Select(this, Where);
            return sql.GetDataTable(sqlStr);
        }
        /// <summary>
        /// 根据条件获取泛型对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Where"></param>
        /// <returns></returns>
        public List<T> GetList<T>(string Where = "") where T : new()
        {
            return GetTable(Where).ToList<T>();
        }



    }
}
