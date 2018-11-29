using System;
using System.IO;
using System.Text;

namespace Utilities.General
{
    public class Log
    {
        public static string LOG_PATH = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        public static void InsertBlankLine()
        {
            Writer(" ");
        }
        public static void Bar(string p_strMessage)
        {
            Writer($"========================== {p_strMessage } {   DateString  } ===========================");
        }
        public static void Line(string p_strMessage)
        {
            Writer($"-------------------------- { p_strMessage } { DateString } ---------------------------");
        }
        public static void Warning(string p_strMessage)
        {
            Writer($"{ DateString }<Warning> { p_strMessage}");
        }
        public static void Error(string p_strMessage)
        {
            Writer($"{DateString } <Error>   { p_strMessage}");
        }
        public static void Message(string p_strMessage)
        {
            Writer($"{DateString} <Message> {p_strMessage}");
        }
        public static void Transaction(string p_strMessage)
        {
            Writer($"{DateString } <Transac>{ p_strMessage}");
        }

        private static string DateString {
            get { return $"@[{ DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss").Trim() }]"; }
        }
        private static void Writer(string msg)
        {
            LOG_PATH = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            var logPath = "LOG" + "\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("yyyyMM") + "\\" + DateTime.Now.ToString("yyyyMMdd");
            string[] paths = logPath.Split('\\');
            foreach (string path in paths)
            {
                LOG_PATH += path + "\\";
                var dir = new DirectoryInfo(LOG_PATH);
                //判断目录是否存在, 不存在自动创建
                if (!dir.Exists || dir.Attributes != FileAttributes.Directory)
                {
                    dir.Create();
                }
            }

            var logName = DateTime.Now.ToString("yyMMdd_HH") + ".log";
            string fileFullName = LOG_PATH + logName;
            try
            {
                //var dir = new DirectoryInfo(LOG_PATH);
                ////判断目录是否存在, 不存在自动创建
                //if (!dir.Exists || dir.Attributes != FileAttributes.Directory)
                //{
                //    dir.Create();
                //}
                File.AppendAllText(fileFullName, msg + "\r\n", Encoding.Default);
            }
            catch(Exception ex)
            {

            }
        }
    }
}
