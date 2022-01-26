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
            hs.Add("STEAMPACK01", "STEAM捆绑包");
            hs.Add("DDO_MOTU_PreOrder_Bundle", "U14预购捆绑包");
            hs.Add("DDO_MOTU_Bundle", "U14捆绑包");
            hs.Add("DDODruidPack", "德鲁伊捆绑包");
            hs.Add("FULL", "全部权限");
            hs.Add("PaidPoints", "付费用户");
            hs.Add("StormreachGuest", "试用权限");
            hs.Add("StormreachStandard", "标准权限");
            hs.Add("TREATED_AS_SUBSCRIBER", "订阅用户");
            hs.Add("Community_Offer_SnowyOwlbear", "宠物:雪枭");
            hs.Add("Community_Offer_YellowCube", "宠物:黄果冻");
            hs.Add("XP2_CharacterSlot_Premium", "角色槽赠送2");
            hs.Add("XP2_CharacterSlot_Standard", "角色槽赠送1");
            hs.Add("XP2_Premium", "U20高级赠品");
            hs.Add("XP2_Base", "U20赠品");
            hs.Add("eStore_Feature_32PtBuild", "32点开卡");
            hs.Add("eStore_Feature_AccountBank", "共享银行");
            hs.Add("eStore_Feature_SharedPlat", "共享材料银行");
            hs.Add("eS_AcctBank20", "共享金币银行");
            hs.Add("eStore_Feature_EpicDestinies", "传奇天命");
            hs.Add("EDRevampCloak", "传奇天命纪念斗篷");
            hs.Add("EDTomeBase", "传奇天命点扩展书");
            hs.Add("EDTomeMotU", "传奇天命点扩展书(U14赠送)");
            hs.Add("Estore_Motu_Discount", "U14 折扣");
            hs.Add("Estore_Ravenloft_Discount", "U37 鸦阁堡折扣");
            hs.Add("Estore_Shadowfell_Discount", "U19 维伦折扣");

            hs.Add("eStore_Feature_HeadStart", "副本困难难度开启");
            hs.Add("eStore_Feature_Bladeforged", "费伦种族解锁:刀锋机关人");
            hs.Add("eStore_Feature_Morninglord", "费伦种族解锁:日精灵");
            hs.Add("eStore_Feature_PurpleDragonKnight", "费伦种族解锁:紫龙骑士");
            hs.Add("eStore_Feature_Shadarkai", "费伦种族解锁:影灵");
            hs.Add("eStore_Feature_DeepGnome", "费伦种族解锁:深渊侏儒");
            hs.Add("eStore_Feature_Warforged", "种族解锁:机关人");
            hs.Add("eStore_Feature_HalfElf", "种族解锁:半精灵");
            hs.Add("eStore_Feature_HalfOrc", "种族解锁:半兽人");
            hs.Add("eStore_Feature_Gnome", "种族解锁:深渊侏儒");
            hs.Add("eStore_Feature_Druid", "职业解锁:德鲁伊");
            hs.Add("eStore_Feature_Monk", "职业解锁:和尚");
            hs.Add("eStore_Feature_Warlock", "职业解锁:邪术师");
            hs.Add("eStore_Feature_FavoredSoul", "职业解锁:天佑");
            hs.Add("eStore_PremEnhancementFalconry", "通用天赋解锁:猎鹰(Falconry)");


            hs.Add("eStore_Content_Shantokor", "衫托克大厅(STK)");
            hs.Add("eStore_Content_TanglerootGorge", "缠根");
            hs.Add("eStore_Content_RuinsOfThrenal", "司莱诺废墟");
            hs.Add("eStore_Content_SorrowduskIsles", "哀暮岛");
            hs.Add("eStore_Content_VaultOfNight", "红龙维拉(VON红龙Raid)");
            hs.Add("eStore_Content_RestlessIsle", "殒梦岛(泰坦Raid)");
            hs.Add("eStore_Content_SandsOfMenechtarun", "沙漠(女王Raid)");
            hs.Add("eStore_Content_Necropolis", "不死城1");
            hs.Add("eStore_Content_Necropolis2", "不死城2");
            hs.Add("eStore_Content_Necropolis3", "不死城3");
            hs.Add("eStore_Content_ValeOfTwilight", "十二魔法(裹尸布Raid)");
            hs.Add("eStore_Content_ReaversReach", "水下(SOS)");
            hs.Add("eStore_Content_Shavarath", "沙瓦雷斯(战场)");
            hs.Add("eStore_Content_CrimeWave", "莎伦辛迪加(市场小本)");



            hs.Add("eStore_Content_Inspired", "U01 灵感之路(新海港)");
            hs.Add("eStore_Content_Dreaming", "U02 梦中的黑暗(新海港)");
            //U03 免费本x4(海港火焰娜迦,12魔法眼魔黑龙..)
            hs.Add("eStore_Content_Sentinels", "U04 风暴湾的哨兵");
            hs.Add("eStore_Content_Carnival", "U05 菲奥兰狂欢节(菲家)");
            hs.Add("eStore_Content_Swamp", "U06 红色沼泽(昆家)");
            hs.Add("eStore_Content_DevilAssault", "U07 恶魔突袭(市场Raid)");
            hs.Add("eStore_Content_Droaam2", "U08 风暴湾的战斗(炸船)");  //Droaam炸船里的疯子狗头人
            hs.Add("eStore_Content_Taken", "U09 疯狂的预兆(畸形怪,海港领取)");//Taken瘸腿畸形怪
            hs.Add("eStore_Content_Xoriat", "U10 疯狂的统治(12魔法领取)");
            hs.Add("eStore_Content_Blades1", "U11 刀锋领主挑战");
            hs.Add("eStore_Content_Blades2", "U12 刀锋领主(刀锋Raid)");
            //U13 免费本x3(U14 通道)
            hs.Add("estore_Content_EveningstarAdventures", "U14-C1 伊尔明斯特副本包");
            hs.Add("estore_Content_EveningstarChallenges", "U14-C1 伊尔明斯特挑战");
            hs.Add("estore_Content_EveningstarLandscape", "U14-C1 伊尔明斯特野外");
            hs.Add("estore_Content_UnderdarkAdventures", "U14-C2 黑暗地域副本包");
            hs.Add("estore_Content_UnderdarkLandscape", "U14-C2 黑暗地域野外");
            hs.Add("estore_Content_DemonwebAdventures", "U14-C3 恶魔蛛网副本包)");
            hs.Add("estore_Content_DemonwebLandscape", "U14-C3 恶魔蛛网野外");
            hs.Add("eStore_Content_Plant", "U15 德鲁伊的内部(活木晶核)");//植物
            hs.Add("eStore_Content_Castles", "U16 阴影之路(Castles城堡)");
            hs.Add("eStore_Content_GiantholdRuins", "U17 传奇巨人领地(市场13/24)");
            //U17 巨人增强幽灵龙
            //U18 沃伦码头免费本
            hs.Add("eStore_Content_Wheloon", "U19 阴影笼罩中的沃伦(Wheloon沃伦)");
            hs.Add("eStore_Content_Stormhorns", "U20 黑暗中的阴谋(Stormhorns风暴角)");
            hs.Add("eStore_Content_Halls", "U21 鬼屋(落星镇0/28)");
            hs.Add("eStore_Content_ThreeBarrelCove", "U22 传奇三桶湾(昆家5/25)");
            hs.Add("eStore_Content_Necropolis4", "U23 不死城4-传奇果园(升天Raid)");
            hs.Add("eStore_Content_Xoriat2", "U24 U10:Xoriat后续任务");
            hs.Add("eStore_Content_Classic_TOEE", "U25 TOEE元素邪恶神殿(英雄殿7/30)");
            //U26 无新任务 更新老王
            //U27 无新任务 修复Bug
            //hs.Add("", "U28 魔鬼的策略 Devil's Gambit(守门人14/30)");
            //U29 无新任务 传奇大狗 传奇裹尸布 传奇风暴山脊
            //U30 更新侏儒
            //U31 免费任务 (落星镇15/31)
            hs.Add("eStore_Content_Classic_Slave", "U32 反对奴隶主 Slave Pits of the Undercity(守门人8/31)");
            //U33 无新任务 和尚调整 
            //U34 免费任务Tower of Frost(市场14/28)
            hs.Add("eStore_Content_Dragonborn_1", "U35 龙血预言Dragonblood Prophecy (市场10/31)");
            //hs.Add("", "U36 矿山The Mines of Tethyamar (落星镇15/31)");
            hs.Add("eStore_Content_Ravenloft", "U37 鸦阁Mists of Ravenloft (乔家10/31)");
            //hs.Add("", "U38 Disciples of Rage(乔家14/31)");
            hs.Add("eStore_Content_Plume", "U39 白羽山White Plume Mountain(守门人9/32)");
            //U40 无新任务 木精灵
            //U41 免费任务 Lost at Sea(海港15/32) 
            //hs.Add("", "U42 Masterminds of Sharn(Sharn15/32)");
            hs.Add("eStore_Content_Soul", "U43 The Soul Splitter(Sharn17/32)");
            hs.Add("eStore_Content_Classic_Keep", "U44 Keep on the Borderlands(守门人1/21)");
            hs.Add("eStore_Content_Deleras", "U45 传奇德墓(乔家3/23)");
            hs.Add("eStore_Content_Catacombs", "U45 传奇陵墓(市场5/27)");
            //hs.Add("", "U46 The Lost Gatekeepers(守门人3/32)");
            //U47  泰坦 刀锋领主 Shavarath 提升等级
            hs.Add("eStore_Content_Fey", "U48 Fables of the Feywild(海港5/32)");
            //hs.Add("", "U49 Peril of the Planar Eyes(新广场12/32)");
            //hs.Add("", "U50 Sinister Secret of Saltmarsh(守门人3/32)");
            //U50 无新任务 传奇天命更新
            /*
eStore_Content_Classic_Hag 
eStore_Content_Codex //手抄本 古籍
eStore_Content_Desire //欲望 渴望  
eStore_Content_Plague //瘟疫 鼠疫 
eStore_Content_Plume_Upgrade //羽毛 
eStore_Content_Relic //遗物
eStore_Content_Shav_Archon //执政官 统治者 
eStore_Content_Thunderholme //雷岛
 

             
             */

            hs.Add("eStore_Sharn_Standard", "U42 撒伦的主谋(Masterminds of Sharn)");


            string sKey = strKey.Trim();
            if (hs.Contains(sKey))
            {
                return hs[sKey].ToString();
            }
            if (sKey.Contains("eStore_Feature_AccountBank_SharedPlatUpgrade")) return sKey.Replace("eStore_Feature_AccountBank_SharedPlatUpgrade", "共享材料银行升级");
            if (sKey.Contains("eStore_Feature_MonsterManualVol")) return sKey.Replace("eStore_Feature_MonsterManualVol", "怪物手册");
            if (sKey.Contains("eStore_Feature_CharSlot")) return sKey.Replace("eStore_Feature_CharSlot", "角色槽");
            if (sKey.Contains("eStore_Feature_AccountBank_SlotsUpgrade")) return sKey.Replace("eStore_Feature_AccountBank_SlotsUpgrade", "共享银行升级");
            if (sKey.Contains("eStore_Feature_SingletonBank_SlotsUp")) return sKey.Replace("eStore_Feature_SingletonBank_SlotsUp", "背包升级");

            return sKey;
        }
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

            p_strProductTokens.Sort((a, z) => a.CompareTo(z));
            foreach (string _strProduct in p_strProductTokens)
            {
                switch (_strProduct)
                {

                    case string sharn when sharn.ToUpper().Contains("SHARN"):
                    case string content when content.ToUpper().Contains("CONTENT"):
                        listContent.Add(GetDes(_strProduct));
                        break;
                    case string feature when feature.ToUpper().Contains("FEATURE"):
                        listFeature.Add(GetDes(_strProduct));
                        break;
                    default:
                        listBase.Add(GetDes(_strProduct));
                        break;
                }
            }
            sbShow.Append("========副本========\n");
            listContent.Add("U03 海港免费本x4(13/18)");
            listContent.Add("U13 U14通道免费本(海港17/0)");
            listContent.Add("U18 沃伦码头免费本");
            listContent.Add("U29 传奇大狗 传奇裹尸布 传奇风暴山脊");
            listContent.Add("U31 免费任务x3(落星镇15/31)");
            listContent.Add("U34 免费任务Tower of Frost(市场14/28)");
            listContent.Add("U41 免费任务Lost at Sea(海港15/32)");
            listContent.Add("U47 免费任务The Promise of Fire(市场6/27)");

            listContent.Sort((a, z) => a.CompareTo(z));
            sbShow.Append(string.Join("\n", listContent.ToArray()));
            sbShow.Append("\n========账户权限========\n");
            sbShow.Append(string.Join("\n", listBase.ToArray()));
            sbShow.Append("\n========其他========\n");
            sbShow.Append(string.Join("\n", listFeature.ToArray()));
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
            //未知 测试下
            //arg.Add("--rodat on");

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
            //2021-12-20 被删除
            ////貌似是客服地址 
            //arg.Add("--supporturl");
            //arg.Add("https://tss.ddo.com/TSSTrowser/trowser.aspx");
            ////BUG提交地址2018-11-29新加
            //arg.Add("--bugurl");
            //arg.Add("http://ddobugs.turbine.com?task=ticket");
            ////未知 
            //arg.Add("--supportserviceurl");
            //arg.Add("https://tss.ddo.com/TSSTrowser/SubmitTicket.asmx");
            try
            {
                string filePath = "";
                switch (clientType)
                {
                    case ClientType.X64:
                        filePath = Path.Combine(Application.StartupPath, "x64\\dndclient64.exe");
                        break;
                    default:
                        filePath = Path.Combine(Application.StartupPath, "dndclient.exe");
                        break;
                }
                Process.Start(filePath, string.Join(" ", arg.ToArray()));
            }
            catch (Exception ex)
            {
                OnCallBack(ConnectType.Error, ex);
            }
        }
    }
    //dndclient.exe"  -a XXX -h 198.252.160.45:9004 --glsticketdirect xxx --chatserver 198.252.160.45:2900 --rodat on --language English --gametype DDO --authserverurl https://gls.ddo.com/GLS.AuthServer/Service.asmx --glsticketlifetime 21600
    //dndclient64.exe -a XXX -h 198.252.160.45:9004 --glsticketdirect xxx --chatserver 198.252.160.45:2900 --rodat on --language English --gametype DDO --authserverurl https://gls.ddo.com/GLS.AuthServer/Service.asmx --glsticketlifetime 21600
    public enum ClientType
    {
        X86,
        X64,
    }

}
