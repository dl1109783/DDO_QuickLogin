using System;
using System.Windows.Forms;

namespace QuickLogin
{
    public static class Program
    {
        public static readonly string XML_FILE_PATH = "UserSettings.xml";
        public static readonly string LoginQueueUrl = "http://gls.DDO.com/GLS.AuthServer/LoginQueue.aspx";

        public static readonly string Url1 = "源码|https://gitee.com/dlanny/DDO_QuickLogin";
        public static readonly string Url2 = "官网|http://www.ddo.com/";
        public static readonly string Url3 = "账号|http://myaccount.turbine.com/";
        public static readonly string Url4 = "WiKi|http://ddowiki.com/";
        //public static readonly string Url5 = "天命模拟|http://dlanny.gitee.io/ddo_quicklogin/";
        public static readonly string Url5 = "解谜|http://solver.cubicleninja.com/";
        public static readonly string Url6 = "贴吧|https://tieba.baidu.com/f?kw=%E9%BE%99%E4%B8%8E%E5%9C%B0%E4%B8%8B%E5%9F%8E&ie=utf-8";
        public static readonly string Url7 = "QQ群|https://shang.qq.com/wpa/qunwpa?idkey=1ac28296d2b07056b37b6ccea5b567e5f3ab64a5efd5b842d0df5e718a7e4590";


        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

        }
    }
}