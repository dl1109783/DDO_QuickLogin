using System;
using System.Diagnostics;

namespace Utilities.General
{
    /// <summary>
    /// 时间相关帮助类
    /// </summary>
    public static class TimeHelper
    {
        #region 测试项目运行时间
        public static Stopwatch Watch = new Stopwatch();
        /// <summary>
        /// 启动计时器
        /// </summary>
        public static void WatchStart()
        {
            Watch.Reset();
            Watch.Start();
        }
        /// <summary>
        /// 停止计时器
        /// </summary>
        /// <returns></returns>
        public static long WatchStop()
        {
            Watch.Stop();
            return Watch.ElapsedMilliseconds;
        }
        /// <summary>
        /// 返回当前运行时间
        /// </summary>
        /// <returns></returns>
        public static long WatchStepMilliseconds()
        {
            return Watch.ElapsedMilliseconds;
        }
        #endregion
        /// <summary>
        /// 获取时间间隔
        /// </summary>
        /// <param name="beginDate"></param>
        /// <returns></returns>
        public static int GetBetweenSeconds(this DateTime beginDate)
        {
            TimeSpan p_Day = DateTime.Now - beginDate;
            return p_Day.Seconds;
        }
        /// <summary>
        /// 获得时间之间的工作日天数
        /// </summary>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public static int GetWorkDay(DateTime beginDate, DateTime endDate)
        {
            if (beginDate > endDate)
            {
                DateTime temp = beginDate;
                beginDate = endDate;
                endDate = temp;
            }
            int i = 0;
            TimeSpan p_Day = endDate - beginDate;
            for (int x = 0; x < p_Day.Days; x++)
            {
                if (beginDate.DayOfWeek != DayOfWeek.Sunday && beginDate.DayOfWeek != DayOfWeek.Saturday)
                {
                    i++;
                }
                beginDate = beginDate.AddDays(1);
            }
            return i;
        }
        /// <summary>
        /// 获得日期月份差值
        /// </summary>
        /// <param name="beginDate">起始日期</param>
        /// <param name="p_dateEnd">截止日期</param>
        /// <returns>月差值</returns>
        public static int GetMonthDifference(DateTime? beginDate, DateTime? endDate)
        {
            if (beginDate == null || endDate == null) return 0;
            if (beginDate.Value == endDate.Value) return 0;
            DateTime begDate, enDate;
            if (beginDate > endDate)
            {
                begDate = endDate.Value;
                enDate = beginDate.Value;
            }
            else
            {
                begDate = beginDate.Value;
                enDate = endDate.Value;
            }
            return (enDate.Year - begDate.Year) * 12 + (enDate.Month - begDate.Month);
        }
    }
}
