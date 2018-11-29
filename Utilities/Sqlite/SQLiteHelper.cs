using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Utilities.Sqlite
{
    public class SqliteHelper
    {
        private static string _dbFileName = $"{AppDomain.CurrentDomain.SetupInformation.ApplicationBase}\\db.sqlite3";
        private static string _connStr = $"Data Source={_dbFileName};Pooling=true;FailIfMissing=false;Synchronous=Off;Journal Mode=WAL;Cache Size=5000";
        private static SQLiteConnection _SQLiteConn = new SQLiteConnection(_connStr);

        #region 方法
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        private static void Open()
        {
            if (_SQLiteConn.State == ConnectionState.Closed)
            {
                _SQLiteConn.Open();
            }
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        private static void Close()
        {
            if (_SQLiteConn.State != ConnectionState.Closed)
            {
                _SQLiteConn.Close();
            }
        }


        /// <summary>
        /// 执行SQL语句 返回受影响行数 [SELECT 不会返回影响行]
        /// </summary>
        /// <param name="command">SQL语句</param>
        /// <returns>返回受影响行数 [SELECT 不会返回影响行]</returns>
        public static int Execute(string command)
        {
            int result = -1;
            Open();
            using (SQLiteCommand sqlitecmd = new SQLiteCommand(command, _SQLiteConn))
            {
                result = sqlitecmd.ExecuteNonQuery();
            }
            return result;
        }

        /// <summary>
        /// 执行SQL语句 返回第一行第一列值
        /// </summary>
        /// <param name="command">SQL语句</param>
        /// <returns>返回第一行第一列值</returns>
        public static object ExecuteScalar(string command)
        {
            object result = null;
            Open();
            using (SQLiteCommand sqlitecmd = new SQLiteCommand(command, _SQLiteConn))
            {
                result = sqlitecmd.ExecuteScalar();
            }
            return result;
        }
        /// <summary>
        /// 执行SQL语句 返回结果集
        /// </summary>
        /// <param name="command">SQL语句</param>
        /// <returns>返回DataSet数据集</returns> 
        public static DataTable GetDataTable(string command)
        {
            DataTable dt = new DataTable();
            Open();
            using (SQLiteCommand sqlitecmd = new SQLiteCommand(command, _SQLiteConn))
            {
                using (SQLiteDataAdapter sqliteadapter = new SQLiteDataAdapter(sqlitecmd))
                {
                    sqliteadapter.Fill(dt);
                }
            }

            return dt;
        }
        #endregion


        /// <summary>
        /// 判断值是否存在
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public static bool Exits(string tableName, string where)
        {
            string strSql = $"select count(1) from {tableName} where 1=1 {where} ";
            if (int.TryParse(ExecuteScalar(strSql).ToString(), out int count))
            {
                return count != 0;
            }
            return false;
        }
        /// <summary>
        /// 判断表是否存在
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static bool ExitsTable(string tableName)
        {
            if (!File.Exists(_dbFileName))
            {
                return false;
            }
            string strSql = $" select count(1) from sqlite_master where type = 'table' and name = '{tableName}' ";
            if (int.TryParse(ExecuteScalar(strSql).ToString(), out int count))
            {
                return count != 0;
            }
            return false;
        }
        /// <summary>
        /// 删除语句
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public static bool Del(string tableName, string where)
        {
            string strSql = $"delete from  {tableName} where 1=1  {where} ";
            return Execute(strSql) != 0;
        }





    }
}
/*
 **********************sqlite 性能优化**********************************
 批量插入使用事务--[^a-z\u4e00-\u9fbb]
 关闭同步，Synchronous=Off，提升性能。添删改操作时不必同步等待写入磁盘，操作系统会延迟若干毫秒批量写入
设置WAL模式，Journal Mode=WAL，减少锁定。写入向前日志模式，避免多线程访问时锁定数据库，写入时不必使用排它锁影响其它线程读取，而是把事务操作写入到WAL文件中，延迟合并
加大缓存，Cache Size=5000，提升性能。操作系统通过文件映射MapFile把整个数据库文件映射进入内存，实际查询时会把用到数据所在附近页预先加载进入缓存，极大提升查询性能
***************************************SQLite中的数据类型*********************************
SQLite是不区分大小写的，但也有一些命令是大小写敏感的，比如GLOB和glob在SQLite的语句中有不同的含义。
SQLite使用一个更普遍的动态类型系统。在SQLite中，值的数据类型与值本身是相关的，而不是与它的容器相关
SQLite有5个原始的数据类型，被称为存储类。存储类这个词表明了一个值在磁盘上存储的格式，其实就是类型或数据类型的同义词。如下即是存储类：
    NULL        	值是一个NULL值。
    INTEGER	值是一个带符号的整数，根据值的大小存储在1、2、3、4、6 或8字节中。
    REAL        	值是一个浮点值，存储为8字节的IEEE浮点数字。
    TEXT	        值是一个文本字符串，使用数据库编码（UTF-8、UTF-16BE或UTF-16LE）存储。
    BLOB	    值是一个blob数据，完全根据它的输入存储。

SQLite通过值的表示法来判断其类型，下面就是SQLite的推理方法： 
     SQL语句中用单引号或双引号括起来的文字被指派为TEXT。
     如果文字是未用引号括起来的数据，并且没有小数点和指数，被指派为INTEGER。
     如果文字是未用引号括起来的数据，并且带有小数点或指数，被指派为REAL。
     用NULL说明的值被指派为NULL存储类。
     如果一个值的格式为X’ABCD’，其中ABCD为16进制数字，则该值被指派为BLOB。X前缀大小写皆可。
SQLite单独的一个字段可能包含不同存储类的值。可以被排序，因为这些值可以相互比较。有完善定义的规则来做这件事。
     不同存储类的值可以通过它们各自类的“类值”进行排序，定义如下：
     NULL存储类具有最低的类值。一个具有NULL存储类的值比所有其它值都小(包括其它具有NULL存储类的值)。在NULL值之间，没有特别的可排序值。
     INTEGER或REAL存储类值高于NULL，它们的类值相等。INTEGER值和REAL值通过其数值进行比较。
     TEXT存储类的值比INTEGER和REAL高。数值永远比字符串的值低。当两个TEXT值进行比较时，其值大小由“排序法”决定。
     BLOB存储类具有最高的类值。具有BLOB类的值大于其它所有类的值。BLOB值之间在比较时使用C函数memcmp()。
所以，当SQLite对一个字段进行排序时，首先按存储类排序，然后再进行类内的排序 (NULL类内部各值不必排序) 。
弱类型(manifest typing)
可以为SQLite的字段定义类型，但这不是必须的，你可以尽管违反类型定义。
这是因为在任何情况下，SQLite都可以接受一个值并推断它的类型。字段可以有类型。类型可以通过值来推断。

INTEGER            INT、NTEGER、TINYINT、SMALLINT、MEDIUMINT、BIGINT、UNSIGNED BIG INT、INT2、INT8	
TEXT                  CHARACTER(20)、VARCHAR(255)、VARYING CHARACTER(255)、NCHAR(55)、NATIVE CHARACTER(70)、NVARCHAR(100)、TEXT、CLOB	
NONE                BLOB、no datatype specified
REAL                 REAL、DOUBLE、DOUBLE PRECISION、FLOAT	
NUMERIC           NUMERIC、DECIMAL(10,5)、BOOLEAN、DATE、DATETIME	
布尔值被存储为整数 0（false）和 1（true）
日期和时间存储为TEXT、REAL或 INTEGER值。
您可以以任何上述格式来存储日期和时间，并且可以使用内置的日期和时间函数来自由转换不同格式。

***************************************SQLite中常用的约束*********************************
PRIMARY Key约束        唯一标识数据库表中的各行/记录。
NOT NULL约束             确保某列不能有NULL值。
DEFAULT约束               当某列没有指定值时，为该列提供默认值。
UNIQUE约束                确保某列中的所有值是不同的。
CHECK约束                 CHECK约束确保某列中的所有值满足一定条件。
AUTOINCREMENT       字段值自动递增,insert或者update时不需要指定值，自动的，而且是从1开始的 ,只能用于INTEGER 
例子
CREATE TABLE AndroidTeam(
   id           INTEGER         PRIMARY KEY   AUTOINCREMENT  NOT NULL,
   name     TEXT               NOT NULL,
   age        INT                 DEFAULT(18),
   address  CHAR(50)       UNIQUE              NOT NULL,
   money    REAL              CHECK(money > 0)
);

隐式索引
    建立表时,系统会自动为主键和UNIQUE唯一值键建立隐式索引
索引
    CREATE INDEX index_name ON table_name;
单列索引
    CREATE INDEX index_name ON table_name (column_name);
唯一索引
    CREATE UNIQUE INDEX index_name ON table_name (column_name);
组合索引
    CREATE INDEX index_name on table_name (column1, column2);
注意
    索引不应该使用在较小的表上。
    索引不应该使用在有频繁的大批量的更新或插入操作的表上。
    索引不应该使用在含有大量的NULL值的列上。
    索引不应该使用在频繁操作的列上。
在SQLite中，除了重命名表和在已有的表中添加列，ALTER TABLE命令不支持其他操作

子查询
    子查询必须用括号括起来。
    子查询在SELECT子句中只能有一个列，除非在主查询中有多列与子查询的所选列进行比较。
    ORDER BY不能用在子查询中，虽然主查询可以使用ORDER BY。
    子查询返回多于一行，只能与多值运算符一起使用，如IN运算符。
    BETWEEN运算符不能与子查询一起使用，但是BETWEEN可在子查询内使用。
LIMIT 限制由SELECT语句返回的数据数量
    SELECT column1, column2, columnN FROM table_name LIMIT [no of rows]
HAVING子句允许指定条件来过滤将出现在最终结果中的分组结果。WHERE子句在所选列上设置条件，而HAVING子句则在由GROUP BY子句创建的分组上设置条件。
    SELECT column1, column2
    FROM table1, table2
    WHERE column1='a'
    GROUP BY column1, column2
    HAVING column2>18
    ORDER BY column1, column2;
注意 HAVING子句必须放在GROUP BY子句之后，必须放在ORDER BY子句之前。

DISTINCT关键字与SELECT语句一起使用，来消除所有重复的记录，并只获取唯一一次记录。

***************************************SQLite常用函数************************************
COUNT函数	             计算一个数据库表中的行数。
MAX函数	                 选择某列的最大值。
MIN函数	                 选择某列的最小值。
AVG函数	                 计算某列的平均值。
SUM函数	                 数值列计算总和。
RANDOM函数	             返回一个介于-9223372036854775808和+9223372036854775807之间的伪随机整数。
ABS函数	                 返回数值参数的绝对值。
UPPER函数         	     字符串转换为大写字母。
LOWER函数	             字符串转换为小写字母。
LENGTH函数	             返回字符串的长度。
sqlite_version函数      返回SQLite库的版本。

***************************************SQLite常用日期处理************************************
* 使用”T”作为分隔日期和时间的文字字符。
date(timestring, modifiers…)	以YYYY-MM-DD格式返回日期。
time(timestring, modifiers…)	以 HH:MM:SS 格式返回时间。
datetime(timestring, modifiers…)	以 YYYY-MM-DD HH:MM:SS 格式返回。
julianday(timestring, modifiers…)	这将返回从格林尼治时间的公元前4714年11月24日正午算起的天数。

strftime(timestring, modifiers…)	这将根据第一个参数指定的格式字符串返回格式化的日期。具体格式见下边讲解。
%d	一月中的第几天，01-31
%f	带小数部分的秒，SS.SSS
%H	小时，00-23
%j	一年中的第几天，001-366
%J	儒略日数，DDDD.DDDD
%m	月，00-12
%M	分，00-59
%s	从 1970-01-01 算起的秒数
%S	秒，00-59
%w	一周中的第几天，0-6 (0 is Sunday)
%W	一年中的第几周，01-53
%Y	年，YYYY
%%	% symbol
计算当前日期：
SELECT date('now');
2013-05-07

计算当前月份的最后一天：
SELECT date('now','start of month','+1 month','-1 day');
2013-05-31

计算给定UNIX时间戳1092941466的日期和时间：
SELECT datetime(1092941466, 'unixepoch');
2004-08-19 18:51:06

计算给定UNIX时间戳1092941466相对本地时区的日期和时间：
SELECT datetime(1092941466, 'unixepoch', 'localtime');
2004-08-19 11:51:06

计算当前的UNIX时间戳：
SELECT datetime(1092941466, 'unixepoch', 'localtime');
1367926057

计算美国"独立宣言"签署以来的天数：
SELECT julianday('now') - julianday('1776-07-04');
86504.4775830326

计算从2004年某一特定时刻以来的秒数：
SELECT strftime('%s','now') - strftime('%s','2004-01-01 02:34:56');
295001572

计算当年10月的第一个星期二的日期：
SELECT date('now','start of year','+9 months','weekday 2');
2013-10-01

计算从UNIX纪元算起的以秒为单位的时间（类似 strftime('%s','now') ，不同的是这里有包括小数部分）：
SELECT (julianday('now') - 2440587.5)*86400.0;
1367926077.12598

在UTC与本地时间值之间进行转换，当格式化日期时，使用utc或localtime修饰符，如下所示：
SELECT time('12:00', 'localtime');
05:00:00

SELECT time('12:00', 'utc');
19:00:00

***************************************SQLite系统表查询************************************
查询表
    SELECT count(1) FROM sqlite_master WHERE type = 'table' and name = 'tablename1'
列出所有索引
    SELECT * FROM sqlite_master WHERE type = 'index';
查询所有触发器
    SELECT name FROM sqlite_master WHERE type = 'trigger';
删除触发器（TRIGGERS）
    DROP TRIGGER trigger_name;

***************************************SQLite中常用的连接*********************************
交叉连接（CROSS JOIN） 把第一个表的每一行与第二个表的每一行进行匹配
    SELECT ... FROM table1 CROSS JOIN table2
内连接（INNER JOIN）     根据连接谓词结合两个表（table1和table2）的列值来创建一个新的结果表
    SELECT ... FROM table1 JOIN table2 USING ( column1 ,... )
外连接（OUTER JOIN）    是内连接（INNER JOIN）的扩展。SQLite只支持左外连接（LEFT OUTER JOIN）
    SELECT ... FROM table1 LEFT OUTER JOIN table2 USING ( column1 ,... )

***************************************触发器（Trigger）************************************
列或表发生DELETE、INSERT或UPDATE时触发

CREATE 
TRIGGER trigger_name [BEFORE|AFTER] event_name 
ON table_name 
BEGIN
 -- Trigger logic goes here....
END;
查询所有触发器
    SELECT name FROM sqlite_master WHERE type = 'trigger';
删除触发器（TRIGGERS）
    DROP TRIGGER trigger_name;
 * **/
