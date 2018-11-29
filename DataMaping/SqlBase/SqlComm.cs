using System.Data;
using System.Data.Common;
using Utilities.Extend;

namespace DataMaping.DatabaseComm
{
    /// <summary>
    /// 统一数据库访问类, 只需实例时传入类型
    /// </summary>
    /// <typeparam name="Conn"></typeparam>
    /// <typeparam name="Cmd"></typeparam>
    /// <typeparam name="Da"></typeparam>
    public class SqlComm<Conn, Cmd, Da> : ISqlHelper
        where Conn : DbConnection, new()
        where Cmd : DbCommand, new()
        where Da : DbDataAdapter, new()
    {
        string _connStr;
        public SqlComm(string ConnStr)
        {
            _connStr = ConnStr;
        }
        /// <summary>
        /// 执行SQL语句 返回受影响行数 [SELECT 不会返回影响行]
        /// </summary>
        /// <param name="SqlString">SQL语句</param>
        /// <returns>返回受影响行数 [SELECT 不会返回影响行]</returns>
        public int Execute(string StrSql)
        {
            using (Conn conn = new Conn())
            {
                conn.ConnectionString = _connStr;
                using (Cmd cmd = new Cmd())
                {
                    cmd.CommandText = StrSql;
                    cmd.Connection = conn;
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// 执行SQL语句 返回第一行第一列值
        /// </summary>
        /// <param name="SqlString">SQL语句</param>
        /// <returns>返回第一行第一列值</returns>
        public T ExecuteScalar<T>(string StrSql)
        {
            using (Conn conn = new Conn())
            {
                conn.ConnectionString = _connStr;
                using (Cmd cmd = new Cmd())
                {
                    cmd.CommandText = StrSql;
                    cmd.Connection = conn;
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    return cmd.ExecuteScalar().ConvertType<T>();
                }
            }
        }
        /// <summary>
        /// 获得一组数据
        /// </summary>
        /// <param name="StrSql"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string StrSql)
        {
            using (Conn conn = new Conn())
            {
                conn.ConnectionString = _connStr;
                using (Cmd cmd = new Cmd())
                {
                    cmd.CommandText = StrSql;
                    cmd.Connection = conn;
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    using (Da da = new Da())
                    {
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
