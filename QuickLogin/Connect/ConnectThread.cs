using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace QuickLogin.Connect
{
    public enum ConnectType
    {
        Error = 1,
        GetDataCenterSuccess = 2,
        Message = 3,
        LoginSuccess = 4,
        LoginFaild = 5,
        GetNewsSuccess = 6,
    }
    public delegate void CallBackHandler(ConnectType p_strType, object p_strReturn);
    public delegate void CallBackInvokeDelegate(ConnectType p_Type, object p_str);
    public class ConnectThread
    {


        public bool isClosed;
        public World _worldSelect;
        public Datacenter _Datacenter;
        public bool isGetNews;
        public string _strUserName;
        public string _strPassWord;
        public ConnectThread(CallBackHandler CallBak)
        {
            isClosed = false;
            isGetNews = false;
            OnCallBack += CallBak;
        }
        public event CallBackHandler OnCallBack;
        public void GetNews()
        {
            while (true)
            {
                try
                {
                    OnCallBack(ConnectType.Message, "正在获取新闻信息..");
                    OnCallBack(ConnectType.GetNewsSuccess, new RSSReader().NewsList);
                    return;
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                }
                OnCallBack(ConnectType.Message, "无法获取新闻 , 5秒后重试 !");
                Thread.Sleep(5000);
            }
        }
        public void GetDataCenter()
        {
            while (true)
            {
                try
                {
                    OnCallBack(ConnectType.Message, "正在获取服务器信息..");
                    _Datacenter = WebServiceComm.GetDatacenter();
                    OnCallBack(ConnectType.GetDataCenterSuccess, _Datacenter.Worlds);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                }
                OnCallBack(ConnectType.Message, "无法连接到服务器 , 3秒后重试 !");
                Thread.Sleep(1000);
                OnCallBack(ConnectType.Message, "无法连接到服务器 , 2秒后重试 !");
                Thread.Sleep(1000);
                OnCallBack(ConnectType.Message, "无法连接到服务器 , 1秒后重试 !");
                Thread.Sleep(1000);
            }
        }
        private string GetDes(string strKey)
        {
            Hashtable hs = new Hashtable();
            hs.Add("DDO_MOTU_PreOrder_Bundle", "预购捆绑");
            hs.Add("DDODruidPack", "德鲁伊包");
            hs.Add("FULL", "全部");
            hs.Add("PaidPoints", "付费用户");
            hs.Add("StormreachGuest", "试用权限");
            hs.Add("StormreachStandard", "标准权限");
            hs.Add("TREATED_AS_SUBSCRIBER", "订阅用户");
            hs.Add("XP2_CharacterSlot_Premium", "角色槽赠送");
            hs.Add("XP2_Premium", "U20赠品");

            hs.Add("eStore_Content_Catacombs", "陵墓");
            hs.Add("eStore_Content_Shantokor", "衫托克大厅(STK)");
            hs.Add("eStore_Content_TanglerootGorge", "缠根");
            hs.Add("eStore_Content_Deleras", "德墓");
            hs.Add("eStore_Content_ThreeBarrelCove", "三桶湾");
            hs.Add("eStore_Content_RuinsOfThrenal", "司莱诺废墟");
            hs.Add("eStore_Content_SorrowduskIsles", "哀暮岛");
            hs.Add("eStore_Content_VaultOfNight", "红龙维拉(VON红龙Raid)");
            hs.Add("eStore_Content_RestlessIsle", "殒梦岛(泰坦Raid)");
            hs.Add("eStore_Content_SandsOfMenechtarun", "沙漠(女王Raid)");
            hs.Add("eStore_Content_GiantholdRuins", "巨人领地(U17幽灵龙Raid)");
            hs.Add("eStore_Content_Necropolis", "不死城1");
            hs.Add("eStore_Content_Necropolis2", "不死城2");
            hs.Add("eStore_Content_Necropolis3", "不死城3");
            hs.Add("eStore_Content_Necropolis4", "不死城4(升天Raid)");
            hs.Add("eStore_Content_ValeOfTwilight", "十二魔法(裹尸布Raid)");
            hs.Add("eStore_Content_ReaversReach", "水下(SOS)");
            hs.Add("eStore_Content_Shavarath", "沙瓦雷斯(战场)");
            hs.Add("eStore_Content_CrimeWave", "莎伦辛迪加(市场小本)");
            hs.Add("eStore_Content_Inspired", "灵感之路(新海港U1)");
            hs.Add("eStore_Content_Dreaming", "梦中的黑暗(新海港U2)");
            hs.Add("eStore_Content_Sentinels", "风暴湾的哨兵(U4)");
            hs.Add("eStore_Content_Carnival", "菲奥兰狂欢节(U5)");
            hs.Add("eStore_Content_Swamp", "红色沼泽(U6)");//Swamp沼泽
            hs.Add("eStore_Content_DevilAssault", "恶魔突袭(U7市场Raid)");
            hs.Add("eStore_Content_Droaam2", "风暴湾的战斗(U8炸船)");  //Droaam炸船里的疯子狗头人
            hs.Add("eStore_Content_Taken", "疯狂的预兆(U9)");//Taken瘸腿畸形怪
            hs.Add("eStore_Content_Xoriat", "疯狂的统治(U10)");
            hs.Add("eStore_Content_Blades1", "刀锋领主挑战(U11)");
            hs.Add("eStore_Content_Blades2", "刀锋领主(U12-刀锋Raid)");
            hs.Add("estore_Content_EveningstarAdventures", "伊尔明斯特副本包(U14-C1)");
            hs.Add("estore_Content_EveningstarChallenges", "伊尔明斯特挑战(U14-C1)");
            hs.Add("estore_Content_EveningstarLandscape", "伊尔明斯特野外(U14-C1)");
            hs.Add("estore_Content_UnderdarkAdventures", "黑暗地域副本包(U14-C2)");
            hs.Add("estore_Content_UnderdarkLandscape", "黑暗地域野外(U14-C2)");
            hs.Add("estore_Content_DemonwebAdventures", "恶魔蛛网副本包(U14-C3-Raid)");
            hs.Add("estore_Content_DemonwebLandscape", "恶魔蛛网野外(U14-C3)");
            hs.Add("eStore_Content_Plant", "德鲁伊的内部(U15活木晶核)");//植物
            hs.Add("eStore_Content_Castles", "阴影之路(U16)");//Castles城堡
            hs.Add("eStore_Content_Wheloon", "阴影笼罩中的沃伦(U19)");//Wheloon沃伦   
            hs.Add("eStore_Content_Stormhorns", "黑暗中的阴谋(U20)");//Stormhorns风暴角


            hs.Add("eStore_Feature_32PtBuild", "32点开卡");
            hs.Add("eStore_Feature_AccountBank", "共享银行");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_1", "共享银行升级1");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_2", "共享银行升级2");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_3", "共享银行升级3");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_4", "共享银行升级4");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_5", "共享银行升级5");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_6", "共享银行升级6");
            hs.Add("eStore_Feature_Bladeforged", "刀锋机关人");
            hs.Add("eStore_Feature_CharSlot", "角色位1");
            hs.Add("eStore_Feature_CharSlot_2", "角色位2");
            hs.Add("eStore_Feature_CharSlot_3", "角色位3");
            hs.Add("eStore_Feature_CharSlot_4", "角色位4");
            hs.Add("eStore_Feature_CharSlot_5", "角色位5");
            hs.Add("eStore_Feature_CharSlot_6", "角色位6");

            hs.Add("eStore_Feature_Druid", "德鲁伊");
            hs.Add("eStore_Feature_EpicDestinies", "传奇天命");
            hs.Add("eStore_Feature_FavoredSoul", "天佑");
            hs.Add("eStore_Feature_HalfElf", "半精灵");
            hs.Add("eStore_Feature_HalfOrc", "半兽人");
            hs.Add("eStore_Feature_HeadStart", "副本困难难度开启");
            hs.Add("eStore_Feature_Monk", "和尚");
            hs.Add("eStore_Feature_Morninglord", "日精灵");
            hs.Add("eStore_Feature_PurpleDragonKnight", "紫龙骑士");
            hs.Add("eStore_Feature_Shadarkai", "影灵");
            hs.Add("eStore_Feature_Warforged", "机关人");
            hs.Add("eStore_Feature_DeepGnome", "深渊侏儒");
            hs.Add("eStore_Feature_Warlock", "邪术师(老王)");

            hs.Add("Community_Offer_YellowCube", "黄果冻");


            string sKey = strKey.Replace("\n", "").Trim();
            if (hs.Contains(sKey))
            {
                return hs[sKey].ToString() + "\n";
            }
            NoMatch.Add(strKey);

            if (sKey.Contains("eStore_Feature_AccountBank_SharedPlatUpgrade")) return sKey.Replace("eStore_Feature_AccountBank_SharedPlatUpgrade", "共享银行铂币") + "\n";
            if (sKey.Contains("CharacterSlot")) return sKey.Replace("CharacterSlot", "角色槽") + "\n";
            return strKey;
        }
        List<string> NoMatch = new List<string>();
        /// <summary>
        /// 获得并处理用户权限信息
        /// </summary>
        /// <param name="p_strProductTokens"></param>
        private string GetProductTokens(List<string> p_strProductTokens)
        {
            if (p_strProductTokens == null) return "";
            StringBuilder sbShow = new StringBuilder();
            List<string> listContent = new List<string>();
            List<string> listFeature = new List<string>();
            List<string> listBase = new List<string>();
            foreach (string _strProduct in p_strProductTokens)
            {
                string _strTemp = _strProduct + "\n";
                if (_strTemp.ToUpper().IndexOf("CONTENT") > 0)
                {
                    listContent.Add(_strTemp);
                }
                else if (_strTemp.ToUpper().IndexOf("FEATURE") > 0)
                {
                    listFeature.Add(_strTemp);
                }
                else
                {
                    listBase.Add(_strTemp);
                }
            }
            listBase.Sort();
            sbShow.Append("============账户权限=========\n");
            foreach (string _info in listBase)
            {
                sbShow.Append(GetDes(_info));
            }
            listContent.Sort();
            sbShow.Append("============副本============\n");
            foreach (string _info in listContent)
            {
                sbShow.Append(GetDes(_info));
            }
            listFeature.Sort();
            sbShow.Append("============其他============\n");
            foreach (string _info in listFeature)
            {
                sbShow.Append(GetDes(_info));
            }
            return sbShow.ToString();
        }
        public void LoginUser()
        {
            UserProfile _loginUser = null;
            ServerStatus serverStatus = null;
            try
            {
                try
                {
                    serverStatus = WebServiceComm.GetServerStatus(_worldSelect.StatusServerUrl);
                }
                catch
                {
                    OnCallBack(ConnectType.LoginFaild, "获取服务器状态出错 !");
                    return;
                }
                if (serverStatus.IsFull)
                {
                    OnCallBack(ConnectType.LoginFaild, "服务器已满!");
                    return;
                }
                try
                {
                    _loginUser = WebServiceComm.LoginAccount(_Datacenter.AuthServer, _strUserName, _strPassWord);
                }
                catch
                {
                    OnCallBack(ConnectType.LoginFaild, "登录失败!");
                    return;
                }
                if (_loginUser.SubscriptionUser == null || _loginUser.SubscriptionUser.Count < 1)
                {
                    OnCallBack(ConnectType.LoginFaild, "未找到账户!");
                    return;
                }
                else if (_loginUser.SubscriptionUser.Count > 1)
                {
                    CheckUser cu = new CheckUser(_loginUser.SubscriptionUser);
                    cu.ShowDialog();
                    _loginUser.SelectUser = cu.SelectUser;
                    cu.Dispose();
                }
                if (_loginUser.SelectUser == null) _loginUser.SelectUser = _loginUser.SubscriptionUser[0];

                if (_loginUser.SelectUser.Status.Equals("Banned"))
                {
                    //被禁用用户
                    OnCallBack(ConnectType.LoginFaild, "用户已被停用 !");
                    return;
                }

                int i = 0;
                while (true)
                {
                    i++;
                    serverStatus.GetRandomUrl();
                    //登陆排队 
                    var takeNumber = WebServiceComm.TakeANumber(_loginUser.SelectUser.SubscriptionName, _loginUser.Ticket, serverStatus.QueueURL);
                    Thread.Sleep(1000);
                    if (takeNumber.NowServingNumber >= takeNumber.QueueNumber || i > 10)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                OnCallBack(ConnectType.Error, ex);
                //登录失败，服务器无法连接！ 
                return;
            }
            UserList userLists = new UserList();
            userLists.DefaultUser = new User();
            userLists.DefaultUser.UserName = _strUserName;
            userLists.DefaultUser.PassWord = _strPassWord;
            userLists.DefaultUser.WorldName = _worldSelect.Name;
            userLists.Save();
            OnCallBack(ConnectType.LoginSuccess, GetProductTokens(_loginUser.SelectUser.ProductTokens));

            List<string> arg = new List<string>();
            //加密后的用户名
            arg.Add("-a");
            arg.Add(_loginUser.SelectUser.SubscriptionName);
            //服务器地址
            arg.Add("-h");
            arg.Add(serverStatus.LoginServer);
            //猜测是加密后的角色信息
            arg.Add("--glsticketdirect");
            arg.Add(_loginUser.Ticket);
            //聊天服务器 198.252.160.45:2900 
            arg.Add("--chatserver");
            arg.Add(_worldSelect.ChatServerUrl);
            //未知
            arg.Add("--rodat");
            arg.Add("on");

            //语言
            arg.Add("--language");
            arg.Add("English");
            //dicArg.Add(" --language ZH_CN ");

            //游戏类型--或许和指环王用的一样的引擎
            arg.Add("--gametype");
            arg.Add("DDO");
            //角色登录验证服务器
            arg.Add("--authserverurl");
            arg.Add("https://gls.ddo.com/GLS.AuthServer/Service.asmx");
            //验证存活时间?
            arg.Add("--glsticketlifetime");
            arg.Add("21600");
            //貌似是客服地址
            arg.Add("--supporturl");
            arg.Add("https://tss.turbine.com/TSSTrowser/trowser.aspx");
            //BUG提交地址2018-11-29新加
            arg.Add("--bugurl");
            arg.Add("http://ddobugs.turbine.com?task=ticket");
            //未知
            arg.Add("--supportserviceurl");
            arg.Add("https://tss.turbine.com/TSSTrowser/SubmitTicket.asmx");
            try
            {
                Process.Start("dndclient.exe", string.Join(" ", arg.ToArray()));
            }
            catch (Exception ex)
            {
                OnCallBack(ConnectType.Error, ex);
            }
        }
    }

}
