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
            if (hs != null)
            {
                return;
            }
            hs = new Hashtable();
            hs.Add("DDO_MOTU_Bundle", "DLC|�ڰ�����(MotU)");
            hs.Add("DDO_MOTU_PreOrder_Bundle", "DLC|�ڰ�����(MotU)Ԥ��");
            hs.Add("DDO_MOTU_PreOrder_Collectors", "DLC|�ڰ�����(MotU)��ذ�");
            hs.Add("DDODruidPack", "δ����|��³����");
            hs.Add("eStore_Feywild_Ultimate", "DLC|������Ұ(U48)������");
            hs.Add("eStore_Feywild_Collectors", "DLC|������Ұ(U48)��ذ�");
            hs.Add("eStore_Feywild_Standard", "DLC|������Ұ(U48)��׼��");
            hs.Add("eStore_Saltmarsh_Ultimate", "DLC|����(U50)������");
            hs.Add("eStore_Saltmarsh_Collectors", "DLC|����(U50)��ذ�");
            hs.Add("eStore_Saltmarsh_Standard", "DLC|����(U50)��׼��");            
            
            hs.Add("Estore_Ravenloft_Discount", "DLC|ѻ��(U37)�ۿ۰�");
            hs.Add("Estore_Shadowfell_Discount", "DLC|��Ӱ�����ۿ۰�");
            hs.Add("eStore_Shadowfell_Standard", "DLC|��Ӱ���ٱ�׼��");
            hs.Add("Estore_Motu_Discount", "DLC|�ڰ������ۿ۰�)");
            hs.Add("eStore_Sharn_Ultimate", "DLC|ɳ��(U42)������");
            hs.Add("eStore_Sharn_Collectors", "DLC|ɳ��(U42)���װ�");
            hs.Add("eStore_Sharn_Standard", "DLC|ɳ��(U42)��׼��");
            hs.Add("eStore_Sharn_Standard_DM", "DLC|ɳ��(U42)��׼��-����");
            hs.Add("DDOSharnSupplies_Claimed", "DLC|ɳ��(U42)��׼��-�����");
            hs.Add("STEAMPACK01", "���|Steam�ع����1");
            hs.Add("XP2_Premium_Prepurchase", "���|XP2Ԥ��");
            hs.Add("SCBeta", "���|SCBeta");

            hs.Add("Saltmarsh_hire_bag_claimed", "���|Ӷ���ղؼ�");
            hs.Add("Saltmarsh_sentient_claimed", "���|��������10��");

            hs.Add("FULL", "Ȩ��|ȫ��");
            hs.Add("F2PDDOUp", "Ȩ��|F2PDDOUp");//����
            hs.Add("eStore_Feature_HeadStart2", "Ȩ��|�ϱ�2");

            hs.Add("DDOTrinketPower", "���|Trinket Power");            
            
            hs.Add("XP2_Base", "���|XP2������");
            hs.Add("XP2_CharacterSlot_Prepurchase_Premium", "���|XP2������");
            hs.Add("XP2_CharacterSlot_Standard", "���|XP2��׼��");
            hs.Add("XP2_Legendary_Upgrade", "���|XP2��������");            

            hs.Add("StormreachLimited", "���|DDO�޶��棨�ɰ棩");
            hs.Add("PaidPoints", "Ȩ��|�����û�");
            hs.Add("StormreachGuest", "Ȩ��|����");
            hs.Add("StormreachStandard", "Ȩ��|��׼");
            hs.Add("TREATED_AS_SUBSCRIBER", "Ȩ��|�����û�");
            hs.Add("XP2_CharacterSlot_Premium", "���|��ɫ������");
            hs.Add("XP2_Premium", "���|U20��Ʒ");
            hs.Add("15AnniversaryCloak", "���|15���궷��");
            hs.Add("EDRevampCloak", "���|����Ȧ����");
            hs.Add("EDTomeBase", "��������|����");
            hs.Add("EDTomeFeywild", "��������|������Ұ");
            hs.Add("EDTomeMotU", "��������|�ڰ�����");
            hs.Add("EDTomeSaltmarsh", "��������|����");
            hs.Add("eStore_f2p_anniversary10_bundle", "���|10����1");
            hs.Add("eStore_f2p_anniversary10_bundle_claimed", "���|10����2");
            hs.Add("eStore_f2p_anniversary10_bundle_claimed2", "���|10����3");

            hs.Add("eStore_Content_Catacombs", "������|��Ĺ");
            hs.Add("eStore_Content_Shantokor", "������|���п˴���(STK)");
            hs.Add("eStore_Content_TanglerootGorge", "������|����");
            hs.Add("eStore_Content_Deleras", "������|��Ĺ");
            hs.Add("eStore_Content_ThreeBarrelCove", "������|��Ͱ��");
            hs.Add("eStore_Content_RuinsOfThrenal", "������|˾��ŵ����");
            hs.Add("eStore_Content_SorrowduskIsles", "������|��ĺ��");
            hs.Add("eStore_Content_VaultOfNight", "������|����ά��(VON����Raid)");
            hs.Add("eStore_Content_RestlessIsle", "������|���ε�(̩̹Raid)");
            hs.Add("eStore_Content_SandsOfMenechtarun", "������|ɳĮ(Ů��Raid)");
            hs.Add("eStore_Content_GiantholdRuins", "������|�������(U17������Raid)");
            hs.Add("eStore_Content_Necropolis", "������|������1");
            hs.Add("eStore_Content_Necropolis2", "������|������2");
            hs.Add("eStore_Content_Necropolis3", "������|������3");
            hs.Add("eStore_Content_Necropolis4", "������|������4(����Raid)");
            hs.Add("eStore_Content_ValeOfTwilight", "������|ʮ��ħ��(��ʬ��Raid)");
            hs.Add("eStore_Content_ReaversReach", "������|ˮ��(SOS)");
            hs.Add("eStore_Content_Shavarath", "������|ɳ����˹(ս��)");
            hs.Add("eStore_Content_CrimeWave", "������|ɯ�����ϼ�(�г�С��)");
            hs.Add("eStore_Content_Halls", "������|ĺ������ֹ����");

            hs.Add("eStore_Content_Inspired", "������|U 1:���֮·(�º���)");
            hs.Add("eStore_Content_Dreaming", "������|U 2:���еĺڰ�(�º���)");
            hs.Add("eStore_Content_Sentinels", "������|U 4:�籩����ڱ�");
            hs.Add("eStore_Content_Carnival", "������|U 5:�ư����񻶽�");
            hs.Add("eStore_Content_Swamp", "������|U 6:��ɫ����");//Swamp����
            hs.Add("eStore_Content_DevilAssault", "������|U 7:��ħͻϮ(�г�Raid)");
            hs.Add("eStore_Content_Droaam2", "������|U 8:�籩���ս��(ը��)");  //Droaamը����ķ��ӹ�ͷ��
            hs.Add("eStore_Content_Taken", "������|U 9:����Ԥ��");//Takenȳ�Ȼ��ι�
            hs.Add("eStore_Content_Xoriat", "������|U10:����ͳ��");
            hs.Add("eStore_Content_Blades1", "������|U11:����������ս");
            hs.Add("eStore_Content_Blades2", "������|U12:��������(����Raid)");
            hs.Add("estore_Content_EveningstarAdventures", "������|U14(C1):������˹��");
            hs.Add("estore_Content_EveningstarChallenges", "������|U14(C1):������˹����ս");
            hs.Add("estore_Content_EveningstarLandscape", "������|U14(C1):������˹��Ұ��");
            hs.Add("estore_Content_UnderdarkAdventures", "������|U14(C2):�ڰ�����");
            hs.Add("estore_Content_UnderdarkLandscape", "������|U14(C2):�ڰ�����Ұ��");
            hs.Add("estore_Content_DemonwebAdventures", "������|U14(C3):��ħ����");
            hs.Add("estore_Content_DemonwebLandscape", "������|U14(C3):��ħ����Ұ��");
            hs.Add("eStore_Content_Plant", "������|U15:��³�����ڲ�(��ľ����)");//ֲ��
            hs.Add("eStore_Content_Castles", "������|U16:��Ӱ֮·");//Castles�Ǳ�
            hs.Add("eStore_Content_Wheloon", "������|U19:��Ӱ�����е�ά��");//Wheloon����   
            hs.Add("eStore_Content_Stormhorns", "������|U20:�ڰ��е���ı(ѩɽ)");//Stormhorns�籩��
            hs.Add("eStore_Content_Thunderholme", "������|U21:�׵��е���Ӱ(Ӱ��)");
            hs.Add("eStore_Content_Xoriat2", "������|U24:������(������ħ�ƹ�)");
            hs.Add("eStore_Content_Classic_TOEE", "������|U25:Ԫ�����(ToEE)");
            hs.Add("eStore_Content_Shav_Archon", "������|U27:ִ���ٵ�����(DoJ)");
            hs.Add("eStore_Content_Plague", "������|U28:��ħ�Ķ�ע");
            hs.Add("eStore_Content_Codex", "������|U29:����λ��ķ���(����ʬ��)");
            hs.Add("eStore_Content_Classic_Slave", "������|U32:ū����");
            hs.Add("eStore_Content_Dragonborn_1", "������|U35:���������(�г�˫��+Raid)");
            hs.Add("eStore_Content_Desire", "������|U36:̩˹�����");
            hs.Add("eStore_Content_Ravenloft", "������|U37:ѻ������");
            hs.Add("eStore_Content_Plume", "������|U39:����ɽ��������˵");
            hs.Add("eStore_Content_Sharn1", "������|U42:ɳ������ı");
            hs.Add("eStore_Content_Soul", "������|U43:��������(Sharn��ͷ)");
            hs.Add("eStore_Content_Classic_Keep", "������|U44:�߽���������(ˢ��)");
            hs.Add("eStore_Content_Classic_Hag", "������|U46:ʧ�ٵ�������");
            hs.Add("eStore_Content_Fey", "������|U48:������Ұ");
            hs.Add("eStore_Content_Relic", "������|U49:λ��֮�۵�Σ��");

            hs.Add("eStore_Feature_32PtBuild", "��������|32�㿪��");
            hs.Add("eStore_Feature_EpicDestinies", "��������|��������");
            hs.Add("eStore_Feature_HeadStart", "��������|���������Ѷȿ���");
            hs.Add("eStore_Feature_HOH_Passport", "��������|λ�洫��");

            hs.Add("eStore_Feature_AasimarScourge", "����ְҵ|IC����-��˹Ī");
            hs.Add("eStore_Feature_Bladeforged", "����ְҵ|IC����-���������");
            hs.Add("eStore_Feature_DeepGnome", "����ְҵ|IC����-��Ԩ٪��");
            hs.Add("eStore_Feature_PurpleDragonKnight", "����ְҵ|IC����-������ʿ");
            hs.Add("eStore_Feature_ShifterIconic", "����ְҵ|IC����-��צ������");//��ȷ��key
            hs.Add("eStore_Feature_Shadarkai", "����ְҵ|IC����-Ӱ��");
            hs.Add("eStore_Feature_Morninglord", "����ְҵ|IC����-�վ���");
            hs.Add("eStore_Feature_TieflingScoundrel", "����ְҵ|IC����-�����");

            hs.Add("eStore_Feature_Alchemist", "����ְҵ|ְҵ-������ʿ");
            hs.Add("eStore_Feature_Artificer", "����ְҵ|ְҵ-��ʦ");
            hs.Add("eStore_Feature_Druid", "����ְҵ|ְҵ-��³��");
            hs.Add("eStore_Feature_FavoredSoul", "����ְҵ|ְҵ-����");
            hs.Add("eStore_Feature_Monk", "����ְҵ|ְҵ-��ɮ");
            hs.Add("eStore_Feature_Warlock", "����ְҵ|ְҵ-а��ʦ");

            hs.Add("eStore_Feature_Aasimar", "����ְҵ|����-��˹Ī");
            hs.Add("eStore_Feature_Dragonborn", "����ְҵ|����-����");
            hs.Add("eStore_Feature_Drow", "����ְҵ|����-׿������");//��ȷ��key-׿��
            hs.Add("eStore_Feature_Gnome", "����ְҵ|����-٪��");
            hs.Add("eStore_Feature_HalfElf", "����ְҵ|����-�뾫��");
            hs.Add("eStore_Feature_HalfOrc", "����ְҵ|����-������");
            hs.Add("eStore_Feature_Shifter", "����ְҵ|����-������");//��ȷ��key-shifter
            hs.Add("eStore_Feature_Tiefling", "����ְҵ|����-�����");
            hs.Add("eStore_Feature_Warforged", "����ְҵ|����-������");
            //������-ľ����

            hs.Add("Community_Offer_YellowCube", "���|�ƹ���");

            hs.Add("eStore_Feature_CharSlot", "��ɫλ|1");
            hs.Add("eStore_Feature_MonsterManualVol02", "�����ֲ�|��2");
            hs.Add("eStore_Feature_SharedPlat", "�ֿ�|�������в���");
            hs.Add("eStore_Feature_AccountBank", "�ֿ�|��������");


            hs.Add("eStore_PremEnhancementFalconry", "ͨ���츳|��ӥ");
            hs.Add("eStore_PremEnhancementHarperAgent", "ͨ���츳|������");
            hs.Add("eStore_PremEnhancementInquisitive", "ͨ���츳|˫��");
            hs.Add("eStore_PremEnhancementVistaniKnife", "ͨ���츳|ά˹���ᵶ��");//��ȷ��key
            hs.Add("eStore_PremEnhancementHorizonWalker", "ͨ���츳|��ƽ������");//��ȷ��ke
            hs.Add("eStore_PremEnhancementFeydark", "ͨ���츳|������Ѩ����ʦ");

            hs.Add("Permadeath_Season_1_Reward_Favor", "������|S1/S5:��������(1750����)");
            hs.Add("Permadeath_Season_1_Reward_Remnants", "������|S1/S5:Ѫ��ӡ(5000����)");
            hs.Add("Permadeath_Season_4_Reward_Favor1", "������|S4:����³ͷ��(1750����)");
            hs.Add("Permadeath_Season_4_Reward_Favor2", "������|S4:����³��(5000����)");
            hs.Add("Permadeath_Season_4_Reward_Level", "������|S4:����³����(20��)");
            hs.Add("Permadeath_Season_5_Reward_Level", "������|S5:��ɫƮ��(20��)");
        }

        public event CallBackHandler OnCallBack;
        public void GetNews()
        {
            while (true)
            {
                try
                {
                    OnCallBack(ConnectType.Message, "���ڻ�ȡ������Ϣ..");
                    OnCallBack(ConnectType.GetNewsSuccess, new RSSReader().NewsList);
                    return;
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                }
                OnCallBack(ConnectType.Message, "�޷���ȡ���� , 5������� !");
                Thread.Sleep(5000);
            }
        }
        public void GetDataCenter()
        {
            while (true)
            {
                try
                {
                    OnCallBack(ConnectType.Message, "���ڻ�ȡ��������Ϣ..");
                    _Datacenter = WebServiceComm.GetDatacenter();
                    OnCallBack(ConnectType.GetDataCenterSuccess, _Datacenter.Worlds);
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(ex.ToString());
                }
                OnCallBack(ConnectType.Message, "�޷����ӵ������� , 3������� !");
                Thread.Sleep(1000);
                OnCallBack(ConnectType.Message, "�޷����ӵ������� , 2������� !");
                Thread.Sleep(1000);
                OnCallBack(ConnectType.Message, "�޷����ӵ������� , 1������� !");
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
            //NoMatch.Add(strKey);

            if (sKey.Contains("eStore_Feature_AccountBank_SharedPlatUpgrade_")) return sKey.Replace("eStore_Feature_AccountBank_SharedPlatUpgrade_", "�ֿ�|�������в���") + "\n";
            if (sKey.Contains("eStore_Feature_CharSlot_")) return sKey.Replace("eStore_Feature_CharSlot_", "��ɫλ|") + "\n";
            if (sKey.Contains("eStore_Feature_AccountBank_SlotsUpgrade_")) return sKey.Replace("eStore_Feature_AccountBank_SlotsUpgrade_", "�ֿ�|����������") + "\n";
            if (sKey.Contains("eS_AcctBank")) return sKey.Replace("eS_AcctBank", "�ֿ�|����������") + "\n";
            if (sKey.Contains("eStore_Feature_MonsterManualVol000")) return sKey.Replace("eStore_Feature_MonsterManualVol000", "�����ֲ�|��") + "\n";
            if (sKey.Contains("eStore_Feature_SingletonBank_SlotsUp_")) return sKey.Replace("eStore_Feature_SingletonBank_SlotsUp_", "�ֿ�|���ﱳ����") + "\n";
            
            return strKey;
        }
        List<string> NoMatch = new List<string>();
        /// <summary>
        /// ��ò������û�Ȩ����Ϣ
        /// </summary>
        /// <param name="p_strProductTokens"></param>
        private string GetProductTokens(List<string> p_strProductTokens)
        {
            if (p_strProductTokens == null) return "";
            StringBuilder sbShow = new StringBuilder();
            Dictionary<string, List<string>> dicPurchasedItems = new Dictionary<string, List<string>>();

            InitPurchaseItems();

            foreach (string _strProduct in p_strProductTokens)
            {
                string _retVal = GetDes(_strProduct + "\n");
                string _key = "δ����";
                if (_retVal.IndexOf("|") >= 0)
                {
                    string[] _arr = _retVal.Split('|');
                    _key = _arr[0];
                    _retVal = _arr[1];
                }
                if (!dicPurchasedItems.ContainsKey(_key))
                {
                    dicPurchasedItems.Add(_key, new List<string>());
                }
                dicPurchasedItems[_key].Add(_retVal);
            }

            foreach (string key in dicPurchasedItems.Keys)
            {
                dicPurchasedItems[key].Sort();
                sbShow.Append("[").Append(key).Append("]\n");
                foreach (string _info in dicPurchasedItems[key])
                {
                    sbShow.Append(" - ").Append(_info);
                }
                sbShow.Append("\n");
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
                    OnCallBack(ConnectType.LoginFaild, "��ȡ������״̬���� !");
                    return;
                }
                if (serverStatus.IsFull)
                {
                    OnCallBack(ConnectType.LoginFaild, "����������!");
                    return;
                }
                try
                {
                    _loginUser = WebServiceComm.LoginAccount(_Datacenter.AuthServer, _strUserName, _strPassWord);
                }
                catch
                {
                    OnCallBack(ConnectType.LoginFaild, "��¼ʧ��!");
                    return;
                }
                if (_loginUser.SubscriptionUser == null || _loginUser.SubscriptionUser.Count < 1)
                {
                    OnCallBack(ConnectType.LoginFaild, "δ�ҵ��˻�!");
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
                    //�������û�
                    OnCallBack(ConnectType.LoginFaild, "�û��ѱ�ͣ�� !");
                    return;
                }

                int i = 0;
                serverStatus.GetRandomUrl();
                while (true)
                {
                    i++;
                    //serverStatus.GetRandomUrl();
                    //serverStatus.GetFirstUrl();
                    //��½�Ŷ� 
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
                //��¼ʧ�ܣ��������޷����ӣ� 
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
            //���ܺ���û���
            arg.Add("-a");
            arg.Add(_loginUser.SelectUser.SubscriptionName);
            //��������ַ
            arg.Add("-h");
            arg.Add(serverStatus.LoginServer);
            //�²��Ǽ��ܺ�Ľ�ɫ��Ϣ
            arg.Add("--glsticketdirect");
            arg.Add(_loginUser.Ticket);
            //��������� 198.252.160.45:2900 
            arg.Add("--chatserver");
            arg.Add(_worldSelect.ChatServerUrl);
            //δ֪
            arg.Add("--rodat on");

            //����
            arg.Add("--language English");
            //dicArg.Add(" --language ZH_CN ");

            //��Ϸ����--�����ָ�����õ�һ��������
            arg.Add("--gametype DDO");
            //��ɫ��¼��֤������
            arg.Add("--authserverurl");
            arg.Add("https://gls.ddo.com/GLS.AuthServer/Service.asmx");
            //��֤���ʱ��?
            arg.Add("--glsticketlifetime 21600");
            //ò���ǿͷ���ַ
            arg.Add("--supporturl");
            arg.Add("https://tss.ddo.com/TSSTrowser/trowser.aspx");
            //BUG�ύ��ַ2018-11-29�¼�
            arg.Add("--bugurl");
            arg.Add("http://ddobugs.turbine.com?task=ticket");
            //δ֪
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
