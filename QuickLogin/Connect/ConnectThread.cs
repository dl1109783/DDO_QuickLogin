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
            hs.Add("DDO_MOTU_Bundle", "DLC|黑暗地域(MotU)");
            hs.Add("DDO_MOTU_PreOrder_Bundle", "DLC|黑暗地域(MotU)预购");
            hs.Add("DDO_MOTU_PreOrder_Collectors", "DLC|黑暗地域(MotU)典藏包");
            hs.Add("DDODruidPack", "未分类|德鲁伊包");
            hs.Add("eStore_Feywild_Ultimate", "DLC|妖精荒野(U48)豪华包");
            hs.Add("eStore_Feywild_Collectors", "DLC|妖精荒野(U48)典藏包");
            hs.Add("eStore_Feywild_Standard", "DLC|妖精荒野(U48)标准包");
            hs.Add("eStore_Saltmarsh_Ultimate", "DLC|盐沼(U50)豪华包");
            hs.Add("eStore_Saltmarsh_Collectors", "DLC|盐沼(U50)典藏包");
            hs.Add("eStore_Saltmarsh_Standard", "DLC|盐沼(U50)标准包");

            hs.Add("Estore_Ravenloft_Discount", "DLC|鸦阁(U37)折扣包");
            hs.Add("Estore_Shadowfell_Discount", "DLC|暗影降临折扣包");
            hs.Add("eStore_Shadowfell_Standard", "DLC|暗影降临标准包");
            hs.Add("Estore_Motu_Discount", "DLC|黑暗地域折扣包)");
            hs.Add("eStore_Sharn_Ultimate", "DLC|沙恩(U42)豪华包");
            hs.Add("eStore_Sharn_Collectors", "DLC|沙恩(U42)进阶包");
            hs.Add("eStore_Sharn_Standard", "DLC|沙恩(U42)标准包");
            hs.Add("eStore_Sharn_Standard_DM", "DLC|沙恩(U42)标准包-副本");
            hs.Add("DDOSharnSupplies_Claimed", "DLC|沙恩(U42)标准包-星钻等");
            hs.Add("STEAMPACK01", "礼包|Steam特供礼包1");
            hs.Add("XP2_Premium_Prepurchase", "礼包|XP2预购");
            hs.Add("SCBeta", "礼包|SCBeta");

            hs.Add("Saltmarsh_hire_bag_claimed", "礼包|佣兵收藏夹");
            hs.Add("Saltmarsh_sentient_claimed", "礼包|智能武器10槽");

            hs.Add("FULL", "权限|全部");
            hs.Add("F2PDDOUp", "权限|F2PDDOUp");//？？
            hs.Add("eStore_Feature_HeadStart2", "权限|老兵2");

            hs.Add("DDOTrinketPower", "礼包|Trinket Power");

            hs.Add("XP2_Base", "礼包|XP2基础包");
            hs.Add("XP2_CharacterSlot_Prepurchase_Premium", "礼包|XP2人物栏");
            
            hs.Add("XP2_Legendary_Upgrade", "礼包|XP2传奇升级");

            hs.Add("StormreachLimited", "礼包|DDO限定版（旧版）");
            hs.Add("PaidPoints", "权限|付费用户");
            hs.Add("StormreachGuest", "权限|试用");
            hs.Add("StormreachStandard", "权限|标准");
            hs.Add("TREATED_AS_SUBSCRIBER", "权限|订阅用户");
            
            hs.Add("XP2_Premium", "礼包|U20赠品");
            hs.Add("15AnniversaryCloak", "礼包|15周年斗篷");
            hs.Add("EDRevampCloak", "礼包|天命圈斗篷");
            hs.Add("EDTomeBase", "新天命书|基础");
            hs.Add("EDTomeFeywild", "新天命书|妖精荒野");
            hs.Add("EDTomeMotU", "新天命书|黑暗地域");
            hs.Add("EDTomeSaltmarsh", "新天命书|盐沼");
            hs.Add("eStore_f2p_anniversary10_bundle", "礼包|10周年1");
            hs.Add("eStore_f2p_anniversary10_bundle_claimed", "礼包|10周年2");
            hs.Add("eStore_f2p_anniversary10_bundle_claimed2", "礼包|10周年3");

            
            hs.Add("eStore_Content_Shantokor", "副本包|衫托克大厅(STK)");
            hs.Add("eStore_Content_TanglerootGorge", "副本包|缠根"); 
            
            hs.Add("eStore_Content_RuinsOfThrenal", "副本包|司莱诺废墟");
            hs.Add("eStore_Content_SorrowduskIsles", "副本包|哀暮岛");
            hs.Add("eStore_Content_VaultOfNight", "副本包|红龙维拉(VON红龙Raid)");
            hs.Add("eStore_Content_RestlessIsle", "副本包|殒梦岛(泰坦Raid)");
            hs.Add("eStore_Content_SandsOfMenechtarun", "副本包|沙漠(女王Raid)");
            
            hs.Add("eStore_Content_Necropolis", "副本包|不死城1");
            hs.Add("eStore_Content_Necropolis2", "副本包|不死城2");
            hs.Add("eStore_Content_Necropolis3", "副本包|不死城3");
            
            hs.Add("eStore_Content_ValeOfTwilight", "副本包|十二魔法(裹尸布Raid)");
            hs.Add("eStore_Content_ReaversReach", "副本包|水下(SOS)");
            hs.Add("eStore_Content_Shavarath", "副本包|沙瓦雷斯(战场)");
            hs.Add("eStore_Content_CrimeWave", "副本包|莎伦辛迪加(市场小本)");
            hs.Add("eStore_Content_Halls", "副本包|暮星镇的闹鬼大厅");

            hs.Add("eStore_Content_Inspired", "副本包|U 1:灵感之路(新海港)");
            hs.Add("eStore_Content_Dreaming", "副本包|U 2:梦中的黑暗(新海港)");
            //U03 免费本x4(海港火焰娜迦,12魔法眼魔黑龙..)
            hs.Add("eStore_Content_Sentinels", "副本包|U 4:风暴湾的哨兵");
            hs.Add("eStore_Content_Carnival", "副本包|U 5:菲奥兰狂欢节");
            hs.Add("eStore_Content_Swamp", "副本包|U 6:红色沼泽");//Swamp沼泽
            hs.Add("eStore_Content_DevilAssault", "副本包|U 7:恶魔突袭(市场Raid)");
            hs.Add("eStore_Content_Droaam2", "副本包|U 8:风暴湾的战斗(炸船)");  //Droaam炸船里的疯子狗头人
            hs.Add("eStore_Content_Taken", "副本包|U 9:疯狂的预兆");//Taken瘸腿畸形怪
            hs.Add("eStore_Content_Xoriat", "副本包|U10:疯狂的统治");
            hs.Add("eStore_Content_Blades1", "副本包|U11:刀锋领主挑战");
            hs.Add("eStore_Content_Blades2", "副本包|U12:刀锋领主(刀锋Raid)");
            //U13 免费本x3(U14 通道)
            hs.Add("estore_Content_EveningstarAdventures", "副本包|U14(C1):伊尔明斯特");
            hs.Add("estore_Content_EveningstarChallenges", "副本包|U14(C1):伊尔明斯特挑战");
            hs.Add("estore_Content_EveningstarLandscape", "副本包|U14(C1):伊尔明斯特野外");
            hs.Add("estore_Content_UnderdarkAdventures", "副本包|U14(C2):黑暗地域");
            hs.Add("estore_Content_UnderdarkLandscape", "副本包|U14(C2):黑暗地域野外");
            hs.Add("estore_Content_DemonwebAdventures", "副本包|U14(C3):恶魔蛛网");
            hs.Add("estore_Content_DemonwebLandscape", "副本包|U14(C3):恶魔蛛网野外");
            hs.Add("eStore_Content_Plant", "副本包|U15:德鲁伊的内部(活木晶核)");//植物
            hs.Add("eStore_Content_Castles", "副本包|U16:阴影之路");//Castles城堡
            hs.Add("eStore_Content_GiantholdRuins", "副本包|U17:传奇巨人领地(幽灵龙Raid13/24)");
            //U18 沃伦码头免费本
            hs.Add("eStore_Content_Wheloon", "副本包|U19:阴影笼罩中的维伦");//Wheloon沃伦   
            hs.Add("eStore_Content_Stormhorns", "副本包|U20:黑暗中的阴谋(雪山)");//Stormhorns风暴角
            hs.Add("eStore_Content_Thunderholme", "副本包|U21:雷电中的阴影(影龙)");
            hs.Add("eStore_Content_ThreeBarrelCove", "副本包|U22:传奇三桶湾(昆家5/25)");
            hs.Add("eStore_Content_Necropolis4", "副本包|U23:不死城4-传奇果园(升天Raid)");
            hs.Add("eStore_Content_Xoriat2", "副本包|U24:疯狂的心(新新眼魔酒馆)");
            hs.Add("eStore_Content_Classic_TOEE", "副本包|U25:元素神殿(ToEE 英雄殿7/30)");
            //U26 无新任务 更新老王
            hs.Add("eStore_Content_Shav_Archon", "副本包|U27:执政官的试炼(DoJ)");
            hs.Add("eStore_Content_Plague", "副本包|U28:恶魔的赌注(守门人14/30)");
            hs.Add("eStore_Content_Codex", "副本包|U29:无限位面的法典(传奇尸布)");//传奇大狗 传奇裹尸布 传奇风暴山脊
            //U30 更新侏儒
            //U31 免费任务 (落星镇15/31)
            hs.Add("eStore_Content_Classic_Slave", "副本包|U32:奴隶主(守门人8/31)");
            //U33 无新任务 和尚调整 
            //U34 免费任务Tower of Frost(市场14/28)
            hs.Add("eStore_Content_Dragonborn_1", "副本包|U35:龙裔的黎明(市场双龙+Raid10/31)");
            hs.Add("eStore_Content_Desire", "副本包|U36:泰斯雅玛矿洞(落星镇15/31)");
            hs.Add("eStore_Content_Ravenloft", "副本包|U37:鸦阁迷雾(乔家10/31)");
            //hs.Add("", "U38 Disciples of Rage(乔家14/31)");
            hs.Add("eStore_Content_Plume", "副本包|U39:白羽山及其它传说(守门人9/32)");
            //U40 无新任务 木精灵
            //U41 免费任务 Lost at Sea(海港15/32) 
            hs.Add("eStore_Content_Sharn1", "副本包|U42:沙恩的主谋(Sharn15/32)");
            hs.Add("eStore_Content_Soul", "副本包|U43:灵魂分裂者(Sharn码头17/32)");
            hs.Add("eStore_Content_Classic_Keep", "副本包|U44:边疆的守望者(刷马1/21)");
            hs.Add("eStore_Content_Deleras", "U45 传奇德墓(乔家3/23)");
            hs.Add("eStore_Content_Catacombs", "U45 传奇陵墓(市场5/27)");
            hs.Add("eStore_Content_Classic_Hag", "副本包|U46:失踪的守门人(3/32)");
            //U47  泰坦 刀锋领主 Shavarath 提升等级上限
            hs.Add("eStore_Content_Fey", "副本包|U48:妖精荒野(海港5/32)");
            hs.Add("eStore_Content_Relic", "副本包|U49:位面之眼的危机(新广场12/32)");
            //hs.Add("", "U50 Sinister Secret of Saltmarsh(守门人3/32)");

            hs.Add("eStore_Feature_32PtBuild", "辅助功能|32点开卡");
            hs.Add("eStore_Feature_EpicDestinies", "辅助功能|传奇天命");
            hs.Add("eStore_Feature_HeadStart", "辅助功能|副本困难难度开启");
            hs.Add("eStore_Feature_HOH_Passport", "辅助功能|位面传送");

            hs.Add("eStore_Feature_AasimarScourge", "种族职业|IC种族-阿斯莫");
            hs.Add("eStore_Feature_Bladeforged", "种族职业|IC种族-刀锋机关人");
            hs.Add("eStore_Feature_DeepGnome", "种族职业|IC种族-深渊侏儒");
            hs.Add("eStore_Feature_PurpleDragonKnight", "种族职业|IC种族-紫龙骑士");
            hs.Add("eStore_Feature_ShifterIconic", "种族职业|IC种族-利爪兽形者");//待确认key
            hs.Add("eStore_Feature_Shadarkai", "种族职业|IC种族-影灵");
            hs.Add("eStore_Feature_Morninglord", "种族职业|IC种族-日精灵");
            hs.Add("eStore_Feature_TieflingScoundrel", "种族职业|IC种族-提夫林");

            hs.Add("eStore_Feature_Alchemist", "种族职业|职业-炼金术士");
            hs.Add("eStore_Feature_Artificer", "种族职业|职业-技师");
            hs.Add("eStore_Feature_Druid", "种族职业|职业-德鲁伊");
            hs.Add("eStore_Feature_FavoredSoul", "种族职业|职业-天佑");
            hs.Add("eStore_Feature_Monk", "种族职业|职业-武僧");
            hs.Add("eStore_Feature_Warlock", "种族职业|职业-邪术师");

            hs.Add("eStore_Feature_Aasimar", "种族职业|种族-阿斯莫");
            hs.Add("eStore_Feature_Dragonborn", "种族职业|种族-龙裔");
            hs.Add("eStore_Feature_Drow", "种族职业|种族-卓尔精灵");//待确认key-卓尔
            hs.Add("eStore_Feature_Gnome", "种族职业|种族-侏儒");
            hs.Add("eStore_Feature_HalfElf", "种族职业|种族-半精灵");
            hs.Add("eStore_Feature_HalfOrc", "种族职业|种族-半兽人");
            hs.Add("eStore_Feature_Shifter", "种族职业|种族-兽形者");//待确认key-shifter
            hs.Add("eStore_Feature_Tiefling", "种族职业|种族-提夫林");
            hs.Add("eStore_Feature_Warforged", "种族职业|种族-机关人");
            //待补充-木精灵

            hs.Add("Community_Offer_YellowCube", "礼包|黄果冻");
            hs.Add("Community_Offer_SnowyOwlbear", "宠物|雪枭");
            hs.Add("XP2_CharacterSlot_Premium", "礼包|角色槽赠送");
            hs.Add("XP2_CharacterSlot_Standard", "礼包|XP2标准包");


            hs.Add("eStore_PremEnhancementFalconry", "通用天赋|猎鹰");
            hs.Add("eStore_PremEnhancementHarperAgent", "通用天赋|竖琴手");
            hs.Add("eStore_PremEnhancementInquisitive", "通用天赋|双弩");
            hs.Add("eStore_PremEnhancementVistaniKnife", "通用天赋|维斯塔尼刀客");//待确认key
            hs.Add("eStore_PremEnhancementHorizonWalker", "通用天赋|地平线行者");//待确认ke
            hs.Add("eStore_PremEnhancementFeydark", "通用天赋|妖精洞穴幻术师");

            hs.Add("Permadeath_Season_1_Reward_Favor", "赛季服|S1/S5:死亡凝视(1750声望)");
            hs.Add("Permadeath_Season_1_Reward_Remnants", "赛季服|S1/S5:血脚印(5000声望)");
            hs.Add("Permadeath_Season_4_Reward_Favor1", "赛季服|S4:克苏鲁头饰(1750声望)");
            hs.Add("Permadeath_Season_4_Reward_Favor2", "赛季服|S4:克苏鲁马(5000声望)");
            hs.Add("Permadeath_Season_4_Reward_Level", "赛季服|S4:克苏鲁斗篷(20级)");
            hs.Add("Permadeath_Season_5_Reward_Level", "赛季服|S5:红色飘带(20级)");



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
            listContent.Add("U29 传奇大狗 传奇风暴山脊");
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
            //未知 关了也能用.2022-01-30
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
            //2021-12-20 被删除 官方客户端已经删除下列链接, 并且游戏界面中已经没有这些
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
