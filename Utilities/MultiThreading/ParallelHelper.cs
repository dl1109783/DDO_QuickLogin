using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Utilities.MultiThreading
{
    /// <summary>
    /// 使用 Parallel.ForEach自动分配线程并行执行QueueList中的任务
    /// Handle中执行Stop或Break可跳出循环
    /// if (!b.IsStopped) b.Stop();//停止执行
    /// b.Break();//跳出执行
    /// </summary>
    /// <typeparam name="T">QueueList的类型</typeparam>
    public class ParallelHelper<T, R>
    {

        Stopwatch Watch;
        Func<T, ParallelLoopState, R> _handle;
        Action<ConcurrentQueue<ResultInfo<T, R>>, TimeSpan> _callBack;
        ParallelOptions _options;
        List<T> QueueList;
        /// <summary>
        /// 线程运行结果
        /// </summary>
        ConcurrentQueue<ResultInfo<T, R>> ResultQueue;



        public bool Enabled;
        /// <summary> 
        /// Handle执行者
        /// CallBack回调方法
        /// MaxThread最大线程数
        /// </summary>
        /// <param name="Handle">执行方法</param>
        /// <param name="CallBack">回调方法</param>
        /// <param name="MaxThread">最大线程</param>
        public ParallelHelper(Func<T, ParallelLoopState, R> Handle, Action<ConcurrentQueue<ResultInfo<T, R>>, TimeSpan> CallBack, int MaxThread = 100)
        {
            _handle = Handle;
            _callBack = CallBack;
            _options = new ParallelOptions() { MaxDegreeOfParallelism = MaxThread };
        }
        public void Stop()
        {
            Enabled = false;
        }
        /// <summary>
        /// 开始线程
        /// </summary>
        public void Start()
        {
            Watch = new Stopwatch();
            Watch.Start();
            Task.Run(() =>
            {
                Parallel.ForEach(QueueList, _options, (o, p) =>
                {
                    try
                    {
                        if (!Enabled && !p.IsStopped)
                        {
                            p.Stop();
                        }
                        var res = new ResultInfo<T, R>(o);
                        res.AddResult(_handle(o, p));
                        ResultQueue.Enqueue(res);
                    }
                    catch (Exception e)
                    {
                        Trace.TraceError(e.ToString());
                    }
                });
                Watch.Stop();
                _callBack(ResultQueue, Watch.Elapsed);
            });
        }

        public void QueueInit()
        {
            QueueList = new List<T>();
            ResultQueue = new ConcurrentQueue<ResultInfo<T, R>>();
            Enabled = true;
        }
        public void QueueAdd(T item)
        {
            QueueList.Add(item);
        }

    }
}
