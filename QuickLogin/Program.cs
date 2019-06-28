using System;
using System.Windows.Forms;

namespace QuickLogin
{
    public static class Program
    {
        public static readonly string XML_FILE_PATH = "UserSettings.xml";
        public static readonly string LoginQueueUrl="http://gls.DDO.com/GLS.AuthServer/LoginQueue.aspx";

        public static readonly string Url1="源码|https://gitee.com/dlanny/DDO_QuickLogin";
        public static readonly string Url2="游戏主页|http://www.ddo.com/";
        public static readonly string Url3="账户管理|http://myaccount.turbine.com/";
        public static readonly string Url4="DDO WiKi|http://ddowiki.com/";
        public static readonly string Url5="天命模拟|http://dlanny.gitee.io/ddo_quicklogin/"; 
 


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