using System.Data;

namespace DataMaping.DatabaseComm
{
    public interface ISqlHelper
    {
        /// <summary>
        /// 执行SQL语句 返回受影响行数 [SELECT 不会返回影响行]
        /// </summary>
        /// <param name="cmd">SQL语句</param>
        /// <returns>返回受影响行数 [SELECT 不会返回影响行]</returns>
        int Execute(string cmd);
        /// <summary>
        /// 执行SQL语句 返回第一行第一列值
        /// </summary>
        /// <param name="cmd">SQL语句</param>
        /// <returns>返回第一行第一列值</returns>
        T ExecuteScalar<T>(string cmd);
        /// <summary>
        /// 执行SQL语句 返回结果集
        /// </summary>
        /// <param name="cmd">SQL语句</param>
        /// <returns>返回DataSet数据集</returns> 
        DataTable GetDataTable(string cmd);
    }
}
