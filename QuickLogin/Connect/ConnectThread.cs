using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

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
        public ClientType clientType;

        private Hashtable hs;
        public ConnectThread(CallBackHandler CallBak)
        {
            isClosed = false;
            isGetNews = false;
            OnCallBack += CallBak;
        }

        private void InitPurchaseItems()
        {
            hs = new Hashtable();
            hs.Add("DDO_MOTU_Bundle", "DLC-黑暗地域(MotU)");
            hs.Add("DDO_MOTU_PreOrder_Bundle", "DLC-黑暗地域预购(MotU)");
            hs.Add("DDODruidPack", "德鲁伊包");
            hs.Add("eStore_Feywild_Ultimate", "DLC-精灵荒野(豪华)");
            hs.Add("eStore_Saltmarsh_Standard", "DLC-盐沼(标准)");
            hs.Add("Estore_Ravenloft_Discount", "DLC-鸦阁(折扣)");
            hs.Add("Estore_Shadowfell_Discount", "DLC-暗影降临(折扣)");
            hs.Add("Estore_Motu_Discount", "DLC-Motu(折扣)");
            hs.Add("FULL", "全部");
            hs.Add("PaidPoints", "付费用户");
            hs.Add("StormreachGuest", "权限-试用");
            hs.Add("StormreachStandard", "权限-标准");
            hs.Add("TREATED_AS_SUBSCRIBER", "订阅用户");
            hs.Add("XP2_CharacterSlot_Premium", "角色槽赠送");
            hs.Add("XP2_Premium", "U20赠品");
            hs.Add("15AnniversaryCloak", "时装-15周年斗篷");
            hs.Add("EDRevampCloak", "时装-天命圈斗篷");
            hs.Add("EDTomeBase", "新天命书-基础");
            hs.Add("EDTomeFeywild", "新天命书-妖精荒野");
            hs.Add("EDTomeMotU", "新天命书-黑暗地域");
            hs.Add("EDTomeSaltmarsh", "新天命书-盐沼");
            hs.Add("eStore_f2p_anniversary10_bundle", "10周年礼包1");
            hs.Add("eStore_f2p_anniversary10_bundle_claimed", "10周年礼包2");
            hs.Add("eStore_f2p_anniversary10_bundle_claimed2", "10周年礼包3");

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
            hs.Add("eStore_Content_Halls", "暮星镇的闹鬼大厅");

            hs.Add("eStore_Content_Inspired", "U 1:灵感之路(新海港)");
            hs.Add("eStore_Content_Dreaming", "U 2:梦中的黑暗(新海港)");
            hs.Add("eStore_Content_Sentinels", "U 4:风暴湾的哨兵");
            hs.Add("eStore_Content_Carnival", "U 5:菲奥兰狂欢节");
            hs.Add("eStore_Content_Swamp", "U 6:红色沼泽");//Swamp沼泽
            hs.Add("eStore_Content_DevilAssault", "U 7:恶魔突袭(市场Raid)");
            hs.Add("eStore_Content_Droaam2", "U 8:风暴湾的战斗(炸船)");  //Droaam炸船里的疯子狗头人
            hs.Add("eStore_Content_Taken", "U 9:疯狂的预兆");//Taken瘸腿畸形怪
            hs.Add("eStore_Content_Xoriat", "U10:疯狂的统治");
            hs.Add("eStore_Content_Blades1", "U11:刀锋领主挑战");
            hs.Add("eStore_Content_Blades2", "U12:刀锋领主(刀锋Raid)");
            hs.Add("estore_Content_EveningstarAdventures", "U14(C1):伊尔明斯特");
            hs.Add("estore_Content_EveningstarChallenges", "U14(C1):伊尔明斯特挑战");
            hs.Add("estore_Content_EveningstarLandscape", "U14(C1):伊尔明斯特野外");
            hs.Add("estore_Content_UnderdarkAdventures", "U14(C2):黑暗地域");
            hs.Add("estore_Content_UnderdarkLandscape", "U14(C2):黑暗地域野外");
            hs.Add("estore_Content_DemonwebAdventures", "U14(C3):恶魔蛛网");
            hs.Add("estore_Content_DemonwebLandscape", "U14(C3):恶魔蛛网野外");
            hs.Add("eStore_Content_Plant", "U15:德鲁伊的内部(活木晶核)");//植物
            hs.Add("eStore_Content_Castles", "U16:阴影之路");//Castles城堡
            hs.Add("eStore_Content_Wheloon", "U19:阴影笼罩中的维伦");//Wheloon沃伦   
            hs.Add("eStore_Content_Stormhorns", "U20:黑暗中的阴谋(雪山)");//Stormhorns风暴角
            hs.Add("eStore_Content_Thunderholme", "U21:雷电中的阴影(影龙)");
            hs.Add("eStore_Content_Xoriat2", "U24:疯狂的心(新新眼魔酒馆)");
            hs.Add("eStore_Content_Classic_TOEE", "U25:元素神殿(ToEE)");
            hs.Add("eStore_Content_Shav_Archon", "U27:执政官的试炼(DoJ)");
            hs.Add("eStore_Content_Plague", "U28:恶魔的赌注");
            hs.Add("eStore_Content_Codex", "U29:无限位面的法典(传奇尸布)");
            hs.Add("eStore_Content_Classic_Slave", "U32:奴隶主");
            hs.Add("eStore_Content_Dragonborn_1", "U35:龙裔的黎明(市场双龙+Raid)");
            hs.Add("eStore_Content_Desire", "U36:泰斯雅玛矿洞");
            hs.Add("eStore_Content_Ravenloft", "U37:鸦阁迷雾");
            hs.Add("eStore_Content_Plume", "U39:白羽山及其它传说");
            hs.Add("eStore_Content_Sharn1", "U42:沙恩的主谋");
            hs.Add("eStore_Content_Soul", "U43:灵魂分裂者(Sharn码头)");
            hs.Add("eStore_Content_Classic_Keep", "U44:边疆的守望者(刷马)");
            hs.Add("eStore_Content_Classic_Hag", "U46:失踪的守门人");
            hs.Add("eStore_Content_Fey", "U48:妖精荒野");
            hs.Add("eStore_Content_Relic", "U49:位面之眼的危机");

            hs.Add("eStore_Feature_32PtBuild", "32点开卡");
            hs.Add("eStore_Feature_AccountBank", "共享银行");
            hs.Add("eStore_Feature_EpicDestinies", "传奇天命");
            hs.Add("eStore_Feature_HeadStart", "副本困难难度开启");

            hs.Add("eStore_Feature_AasimarScourge", "IC种族-阿斯莫");
            hs.Add("eStore_Feature_Bladeforged", "IC种族-刀锋机关人");
            hs.Add("eStore_Feature_DeepGnome", "IC种族-深渊侏儒");
            hs.Add("eStore_Feature_PurpleDragonKnight", "IC种族-紫龙骑士");
            hs.Add("eStore_Feature_RazorShifter", "IC种族-利爪兽形者");//待确认key
            hs.Add("eStore_Feature_Shadarkai", "IC种族-影灵");
            hs.Add("eStore_Feature_Morninglord", "IC种族-日精灵");
            hs.Add("eStore_Feature_TieflingScoundrel", "IC种族-提夫林");

            hs.Add("eStore_Feature_Alchemist", "职业-炼金术士");
            hs.Add("eStore_Feature_Artificer", "职业-技师");
            hs.Add("eStore_Feature_Druid", "职业-德鲁伊");
            hs.Add("eStore_Feature_FavoredSoul", "职业-天佑");
            hs.Add("eStore_Feature_Monk", "职业-武僧");
            hs.Add("eStore_Feature_Warlock", "职业-邪术师");

            hs.Add("eStore_Feature_Aasimar", "种族-阿斯莫");
            hs.Add("eStore_Feature_Dragonborn", "种族-龙裔");
            hs.Add("eStore_Feature_Drow", "种族-卓尔精灵");//待确认key-卓尔
            hs.Add("eStore_Feature_Gnome", "种族-侏儒");
            hs.Add("eStore_Feature_HalfElf", "种族-半精灵");
            hs.Add("eStore_Feature_HalfOrc", "种族-半兽人");
            hs.Add("eStore_Feature_Shifter", "种族-兽形者");//待确认key-shifter
            hs.Add("eStore_Feature_Tiefling", "种族-提夫林");
            hs.Add("eStore_Feature_Warforged", "种族-机关人");
            //待补充-木精灵

            hs.Add("Community_Offer_YellowCube", "黄果冻");

            hs.Add("eStore_Feature_CharSlot", "角色位1");
            hs.Add("eStore_Feature_MonsterManualVol02", "怪物手册：卷2");
            hs.Add("eStore_Feature_SharedPlat", "共享银行铂币");
            hs.Add("eStore_Feature_HOH_Passport", "位面传送");

            hs.Add("eStore_PremEnhancementFalconry", "通用天赋：猎鹰");
            hs.Add("eStore_PremEnhancementHarperAgent", "通用天赋：竖琴手");
            hs.Add("eStore_PremEnhancementInquisitive", "通用天赋：双弩");
            hs.Add("eStore_PremEnhancementVistaniKnifeFighter", "通用天赋：维斯塔尼刀客");//待确认key
            hs.Add("eStore_PremEnhancementHorizonWalker", "通用天赋：地平线行者");//待确认ke
            hs.Add("eStore_PremEnhancementFeydarkIllusionist", "通用天赋：妖精洞穴幻术师");//待确认key

            hs.Add("Permadeath_Season_1_Reward_Favor", "S1/S5:死亡凝视(1750声望)");
            hs.Add("Permadeath_Season_1_Reward_Remnants", "S1/S5:血脚印(5000声望)");
            hs.Add("Permadeath_Season_4_Reward_Favor1", "S4:克苏鲁头饰(1750声望)");
            hs.Add("Permadeath_Season_4_Reward_Favor2", "S4:克苏鲁马(5000声望)");
            hs.Add("Permadeath_Season_4_Reward_Level", "S4:克苏鲁斗篷(20级)");
            hs.Add("Permadeath_Season_5_Reward_Level", "S5:红色飘带(20级)");
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
            string sKey = strKey.Replace("\n", "").Trim();
            if (hs.Contains(sKey))
            {
                return hs[sKey].ToString() + "\n";
            }
            NoMatch.Add(strKey);

            if (sKey.Contains("eStore_Feature_AccountBank_SharedPlatUpgrade_")) return sKey.Replace("eStore_Feature_AccountBank_SharedPlatUpgrade_", "共享银行铂币") + "\n";
            if (sKey.Contains("eStore_Feature_CharSlot_")) return sKey.Replace("eStore_Feature_CharSlot_", "角色位") + "\n";
            if (sKey.Contains("eStore_Feature_AccountBank_SlotsUpgrade_")) return sKey.Replace("eStore_Feature_AccountBank_SlotsUpgrade_", "共享银行栏") + "\n";
            if (sKey.Contains("eS_AcctBank")) return sKey.Replace("eS_AcctBank", "共享银行栏") + "\n";
            if (sKey.Contains("eStore_Feature_MonsterManualVol000")) return sKey.Replace("eStore_Feature_MonsterManualVol000", "怪物手册：卷") + "\n";
            if (sKey.Contains("eStore_Feature_SingletonBank_SlotsUp_")) return sKey.Replace("eStore_Feature_SingletonBank_SlotsUp_", "人物背包栏") + "\n";
            
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
            List<string> listHC = new List<string>();

            InitPurchaseItems();
            foreach (string _strProduct in p_strProductTokens)
            {
                string _strTemp = _strProduct + "\n";
                if (_strTemp.ToUpper().IndexOf("PERMADEATH_") >= 0)
                {
                    listHC.Add(GetDes(_strTemp));
                } 
                else if (_strTemp.ToUpper().IndexOf("CONTENT") >= 0)
                {
                    listContent.Add(GetDes(_strTemp));
                }
                else if (_strTemp.ToUpper().IndexOf("FEATURE") >= 0 || _strTemp.ToUpper().IndexOf("ES_ACCTBANK") >= 0 || _strTemp.ToUpper().IndexOf("_PREMENHANCEMENT") >= 0)
                {
                    listFeature.Add(GetDes(_strTemp));
                }
                else
                {
                    listBase.Add(GetDes(_strTemp));
                }
            }
            listBase.Sort();
            sbShow.Append("[账户权限]\n");
            foreach (string _info in listBase)
            {
                sbShow.Append(" - ").Append(_info);
            }

            listHC.Sort();
            sbShow.Append("\n[赛季服]\n");
            foreach (string _info in listHC)
            {
                sbShow.Append(" - ").Append(_info);
            }

            listContent.Sort();
            sbShow.Append("\n[副 本]\n");
            foreach (string _info in listContent)
            {
                sbShow.Append(" - ").Append(_info);
            }

            listFeature.Sort();
            sbShow.Append("\n[功能特性]\n");
            foreach (string _info in listFeature)
            {
                sbShow.Append(" - ").Append(_info);
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
                serverStatus.GetRandomUrl();
                while (true)
                {
                    i++;
                    //serverStatus.GetRandomUrl();
                    //serverStatus.GetFirstUrl();
                    //登陆排队 
                    var takeNumber = WebServiceComm.TakeANumber(_loginUser.SelectUser.SubscriptionName, _loginUser.Ticket, serverStatus.QueueURL);
                    if (takeNumber.NowServingNumber >= takeNumber.QueueNumber || i > 10)
                    {
                        Thread.Sleep(takeNumber.LoginTier * 1000);
                        break;
                    }
                    Thread.Sleep(1000);
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
            arg.Add("--rodat on");

            //语言
            arg.Add("--language English");
            //dicArg.Add(" --language ZH_CN ");

            //游戏类型--或许和指环王用的一样的引擎
            arg.Add("--gametype DDO");
            //角色登录验证服务器
            arg.Add("--authserverurl");
            arg.Add("https://gls.ddo.com/GLS.AuthServer/Service.asmx");
            //验证存活时间?
            arg.Add("--glsticketlifetime 21600");
            //貌似是客服地址
            arg.Add("--supporturl");
            arg.Add("https://tss.ddo.com/TSSTrowser/trowser.aspx");
            //BUG提交地址2018-11-29新加
            arg.Add("--bugurl");
            arg.Add("http://ddobugs.turbine.com?task=ticket");
            //未知
            arg.Add("--supportserviceurl");
            arg.Add("https://tss.ddo.com/TSSTrowser/SubmitTicket.asmx");
            try
            {
                string filePath = "";
                if (clientType == default(ClientType) || clientType != ClientType.X64)
                {
                    filePath = Path.Combine(Application.StartupPath, "dndclient.exe");
                }
                else filePath = Path.Combine(Application.StartupPath, "x64\\dndclient64.exe");
                Process.Start(filePath, string.Join(" ", arg.ToArray()));
            }
            catch (Exception ex)
            {
                OnCallBack(ConnectType.Error, ex);
            }
        }
    }
    public enum ClientType
    {
        X86,
        X64,
    }

}
