using System.Diagnostics;

namespace Utilities.MultiThreading
{
    public class ResultInfo<T, R>
    {
        public T Source;
        public R Result;
        private Stopwatch Watch;
        public ResultInfo(T s)
        {
            Watch = new Stopwatch();
            Watch.Start();
            Source = s;
        }
        public void AddResult(R r)
        {
            Watch.Stop();
            Result = r;
        }
        public override string ToString()
        {
            return Watch.Elapsed + "\tSource: " + Source + "\tResult:" + Result;
        }
    }
}
