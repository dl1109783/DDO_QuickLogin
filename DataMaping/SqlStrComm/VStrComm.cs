using DataMaping.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataMaping.SqlStrComm
{
    public abstract class VStrComm
    {
        /// <summary>
        /// 判断表是否存在, 不同数据库不同的语句, 需分别重载此方法编写Sql语句
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public abstract string ExitsTable(string tableName);
        /// <summary>
        /// 创建表操作, 不同数据库不同的语句, 需分别重载此方法编写Sql语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract string CreateTable<T>(T model) where T : MBase;

        /// <summary>
        /// 获得C#类型对应的数据库类型.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public abstract string GetTypeOnSql(Type t);
        /// <summary>
        /// 获取最新的N条记录
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public abstract string TopData(string tableName, int count, string where);
        /// <summary>
        /// 插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract string Insert<T>(T model) where T : MBase;
        /// <summary>
        /// 更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract string Update<T>(T model) where T : MBase;
        /// <summary>
        /// 获得自增长字段的ID
        /// </summary>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public abstract string GetAutoincrementID(string TableName);
        /// <summary>
        /// 按条件删除数据
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Where"></param>
        /// <returns></returns>
        public virtual string Del(string TableName, string Where)
        {
            return $" DELETE FROM [{TableName}] WHERE 1=1  {Where} ";
        }
        /// <summary>
        /// 删除语句
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual string Del<T>(T model) where T : MBase
        {
            return Del(model.TableName, GetEquationStr<T>(model, model.PK, "and"));
        }
        /// <summary>
        /// 查找数据
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="where"></param>
        /// <param name="fields"></param>
        /// <returns></returns>
        public virtual string Select(string TableName, string where, string fields = "*")
        {
            return $" SELECT {fields} FROM [{TableName}] WHERE 1=1 {where} ";
        }
        /// <summary>
        /// 查询语句
        /// </summary>
        /// <param name="tableName"></param>        
        /// <param name="where"></param>
        /// <param name="selectFields"></param>
        /// <returns></returns>
        public virtual string Select<T>(T model, string where) where T : MBase
        {
            return Select(model.TableName, where, GetNameStr(model.All));
        }
        /// <summary>
        /// 查询语句
        /// </summary>
        /// <param name="tableName"></param>        
        /// <param name="where"></param>
        /// <param name="selectFields"></param>
        /// <returns></returns>
        public virtual string GetModel<T>(T model) where T : MBase
        {
            return Select<T>(model, GetEquationStr<T>(model, model.PK, "and"));
        }
        /// <summary>
        /// 按条件判断是否存在
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Where"></param>
        /// <returns></returns>
        public string Exits(string TableName, string Where)
        {
            return $" SELECT COUNT(1) FROM [{ TableName}] WHERE 1=1 {Where} ";
        }
        /// <summary>
        /// 根据主键判断是否存在
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual string Exits<T>(T model) where T : MBase
        {
            return Exits(model.TableName, GetEquationStr<T>(model, model.PK, "and"));
        }
        /// <summary>
        /// 按照参数拼装字段名
        /// </summary>
        /// <param name="lf"></param>
        /// <returns></returns>
        public virtual string GetNameStr(List<Property> lf, string prefix = "")
        {
            StringBuilder sbName = new StringBuilder();
            foreach (Property f in lf)
            {
                //如果带有前缀则添加前缀
                if (!string.IsNullOrWhiteSpace(prefix))
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
        public virtual string GetValueStr<T>(T m, List<Property> lf)
        {
            StringBuilder sbValue = new StringBuilder();
            foreach (Property f in lf)
            {
                sbValue.Append($" '{f.GetValue<T>(m)}' ,");
            }
            return sbValue.ToString().TrimEnd(',');
        }
        /// <summary>
        /// 按照参数拼装更新语句
        /// </summary>
        /// <param name="lf"></param> 
        /// <returns></returns>
        public string GetEquationStr<T>(T m, List<Property> lf, string prefix = "")
        {
            StringBuilder sbKey = new StringBuilder();
            foreach (Property f in lf)
            {
                sbKey.Append($" {prefix} [{f.Name}]='{f.GetValue<T>(m)}' ,");
            }
            return sbKey.ToString().TrimEnd(',');
        }

    }
}
