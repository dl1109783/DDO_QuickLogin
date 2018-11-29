using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Utilities.MultiThreading
{
    /// <summary>
    /// 顺序执行, 按照指定线程数创建线程
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueHelper<T, R>
    {

        public bool Enabled;


        /// <summary>
        /// 待处理队列
        /// </summary>
        ConcurrentQueue<T> QueueList;
        /// <summary>
        /// 线程运行结果
        /// </summary>
        ConcurrentQueue<ResultInfo<T, R>> ResultQueue;
        /// <summary>
        /// 处理方法
        /// </summary>
        Func<T, R> _handle;
        /// <summary>
        /// 回调方法
        /// </summary>
        Action<ConcurrentQueue<ResultInfo<T, R>>, TimeSpan> _callBack;
        Stopwatch Watch;
        int _threadCount;
        /// <summary> 
        /// loopstate.Stop(); 
        /// 运行过程中可以向QueueList继续添加
        /// </summary>
        /// <param name="Handle">执行程序</param>
        /// <param name="CallBack">回调函数</param>
        /// <param name="ThreadCount">线程数</param>
        public QueueHelper(Func<T, R> Handle, Action<ConcurrentQueue<ResultInfo<T, R>>, TimeSpan> CallBack, int ThreadCount = 4)
        {
            QueueList = new ConcurrentQueue<T>();
            _handle = Handle;
            _callBack = CallBack;
            _threadCount = ThreadCount;
            Enabled = true;
        }
        public void Stop()
        {
            Enabled = false;
        }
        public void Start()
        {
            var tasks = new List<Task>();
            for (int i = 0; i < _threadCount; i++)
            {
                tasks.Add(Task.Run(() =>
               {
                   while (!QueueList.IsEmpty && Enabled)//可以改造为长期在后台运行
                   {
                       if (QueueList.TryDequeue(out T o))
                       {
                           try
                           {
                               var res = new ResultInfo<T, R>(o);
                               res.AddResult(_handle(o));
                               ResultQueue.Enqueue(res);
                           }
                           catch (Exception e)
                           {
                               Trace.TraceError(e.ToString());
                           }
                       }
                   }

               }));
            }

            Task.Run(() =>
            {
                Watch = new Stopwatch();
                Watch.Start();
                Task.WaitAll(tasks.ToArray());
                Watch.Stop();
                _callBack(ResultQueue, Watch.Elapsed);
            });

        }
        public void QueueInit()
        {
            QueueList = new ConcurrentQueue<T>();
            ResultQueue = new ConcurrentQueue<ResultInfo<T, R>>();
            Enabled = true;
        }
        public void QueueAdd(T item)
        {
            QueueList.Enqueue(item);
        }

    }
}
