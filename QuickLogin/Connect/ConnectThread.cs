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
            Hashtable hs = new Hashtable();
            hs.Add("STEAMPACK01", "STEAM�����");
            hs.Add("DDO_MOTU_PreOrder_Bundle", "U14Ԥ�������");
            hs.Add("DDO_MOTU_Bundle", "U14�����");
            hs.Add("DDODruidPack", "��³�������");
            hs.Add("FULL", "ȫ��Ȩ��");
            hs.Add("PaidPoints", "�����û�");
            hs.Add("StormreachGuest", "����Ȩ��");
            hs.Add("StormreachStandard", "��׼Ȩ��");
            hs.Add("TREATED_AS_SUBSCRIBER", "�����û�");
            hs.Add("Community_Offer_SnowyOwlbear", "����:ѩ��");
            hs.Add("Community_Offer_YellowCube", "����:�ƹ���");
            hs.Add("XP2_CharacterSlot_Premium", "��ɫ������2");
            hs.Add("XP2_CharacterSlot_Standard", "��ɫ������1");
            hs.Add("XP2_Premium", "U20�߼���Ʒ");
            hs.Add("XP2_Base", "U20��Ʒ");
            hs.Add("eStore_Feature_32PtBuild", "32�㿪��");
            hs.Add("eStore_Feature_AccountBank", "��������");
            hs.Add("eStore_Feature_SharedPlat", "�����������");
            hs.Add("eS_AcctBank20", "����������");
            hs.Add("eStore_Feature_EpicDestinies", "��������");
            hs.Add("EDRevampCloak", "�������������");
            hs.Add("EDTomeBase", "������������չ��");
            hs.Add("EDTomeMotU", "������������չ��(U14����)");
            hs.Add("Estore_Motu_Discount", "U14 �ۿ�");
            hs.Add("Estore_Ravenloft_Discount", "U37 ѻ���ۿ�");
            hs.Add("Estore_Shadowfell_Discount", "U19 ά���ۿ�");

            hs.Add("eStore_Feature_HeadStart", "���������Ѷȿ���");
            hs.Add("eStore_Feature_Bladeforged", "�����������:���������");
            hs.Add("eStore_Feature_Morninglord", "�����������:�վ���");
            hs.Add("eStore_Feature_PurpleDragonKnight", "�����������:������ʿ");
            hs.Add("eStore_Feature_Shadarkai", "�����������:Ӱ��");
            hs.Add("eStore_Feature_DeepGnome", "�����������:��Ԩ٪��");
            hs.Add("eStore_Feature_Warforged", "�������:������");
            hs.Add("eStore_Feature_HalfElf", "�������:�뾫��");
            hs.Add("eStore_Feature_HalfOrc", "�������:������");
            hs.Add("eStore_Feature_Gnome", "�������:��Ԩ٪��");
            hs.Add("eStore_Feature_Druid", "ְҵ����:��³��");
            hs.Add("eStore_Feature_Monk", "ְҵ����:����");
            hs.Add("eStore_Feature_Warlock", "ְҵ����:а��ʦ");
            hs.Add("eStore_Feature_FavoredSoul", "ְҵ����:����");
            hs.Add("eStore_PremEnhancementFalconry", "ͨ���츳����:��ӥ(Falconry)");


            hs.Add("eStore_Content_Shantokor", "���п˴���(STK)");
            hs.Add("eStore_Content_TanglerootGorge", "����");
            hs.Add("eStore_Content_RuinsOfThrenal", "˾��ŵ����");
            hs.Add("eStore_Content_SorrowduskIsles", "��ĺ��");
            hs.Add("eStore_Content_VaultOfNight", "����ά��(VON����Raid)");
            hs.Add("eStore_Content_RestlessIsle", "���ε�(̩̹Raid)");
            hs.Add("eStore_Content_SandsOfMenechtarun", "ɳĮ(Ů��Raid)");
            hs.Add("eStore_Content_Necropolis", "������1");
            hs.Add("eStore_Content_Necropolis2", "������2");
            hs.Add("eStore_Content_Necropolis3", "������3");
            hs.Add("eStore_Content_ValeOfTwilight", "ʮ��ħ��(��ʬ��Raid)");
            hs.Add("eStore_Content_ReaversReach", "ˮ��(SOS)");
            hs.Add("eStore_Content_Shavarath", "ɳ����˹(ս��)");
            hs.Add("eStore_Content_CrimeWave", "ɯ�����ϼ�(�г�С��)");



            hs.Add("eStore_Content_Inspired", "U01 ���֮·(�º���)");
            hs.Add("eStore_Content_Dreaming", "U02 ���еĺڰ�(�º���)");
            //U03 ��ѱ�x4(���ۻ�������,12ħ����ħ����..)
            hs.Add("eStore_Content_Sentinels", "U04 �籩����ڱ�");
            hs.Add("eStore_Content_Carnival", "U05 �ư����񻶽�(�Ƽ�)");
            hs.Add("eStore_Content_Swamp", "U06 ��ɫ����(����)");
            hs.Add("eStore_Content_DevilAssault", "U07 ��ħͻϮ(�г�Raid)");
            hs.Add("eStore_Content_Droaam2", "U08 �籩���ս��(ը��)");  //Droaamը����ķ��ӹ�ͷ��
            hs.Add("eStore_Content_Taken", "U09 ����Ԥ��(���ι�,������ȡ)");//Takenȳ�Ȼ��ι�
            hs.Add("eStore_Content_Xoriat", "U10 ����ͳ��(12ħ����ȡ)");
            hs.Add("eStore_Content_Blades1", "U11 ����������ս");
            hs.Add("eStore_Content_Blades2", "U12 ��������(����Raid)");
            //U13 ��ѱ�x3(U14 ͨ��)
            hs.Add("estore_Content_EveningstarAdventures", "U14-C1 ������˹�ظ�����");
            hs.Add("estore_Content_EveningstarChallenges", "U14-C1 ������˹����ս");
            hs.Add("estore_Content_EveningstarLandscape", "U14-C1 ������˹��Ұ��");
            hs.Add("estore_Content_UnderdarkAdventures", "U14-C2 �ڰ����򸱱���");
            hs.Add("estore_Content_UnderdarkLandscape", "U14-C2 �ڰ�����Ұ��");
            hs.Add("estore_Content_DemonwebAdventures", "U14-C3 ��ħ����������)");
            hs.Add("estore_Content_DemonwebLandscape", "U14-C3 ��ħ����Ұ��");
            hs.Add("eStore_Content_Plant", "U15 ��³�����ڲ�(��ľ����)");//ֲ��
            hs.Add("eStore_Content_Castles", "U16 ��Ӱ֮·(Castles�Ǳ�)");
            hs.Add("eStore_Content_GiantholdRuins", "U17 ����������(�г�13/24)");
            //U17 ������ǿ������
            //U18 ������ͷ��ѱ�
            hs.Add("eStore_Content_Wheloon", "U19 ��Ӱ�����е�����(Wheloon����)");
            hs.Add("eStore_Content_Stormhorns", "U20 �ڰ��е���ı(Stormhorns�籩��)");
            hs.Add("eStore_Content_Halls", "U21 ����(������0/28)");
            hs.Add("eStore_Content_ThreeBarrelCove", "U22 ������Ͱ��(����5/25)");
            hs.Add("eStore_Content_Necropolis4", "U23 ������4-�����԰(����Raid)");
            hs.Add("eStore_Content_Xoriat2", "U24 U10:Xoriat��������");
            hs.Add("eStore_Content_Classic_TOEE", "U25 TOEEԪ��а�����(Ӣ�۵�7/30)");
            //U26 �������� ��������
            //U27 �������� �޸�Bug
            //hs.Add("", "U28 ħ��Ĳ��� Devil's Gambit(������14/30)");
            //U29 �������� ����� �����ʬ�� ����籩ɽ��
            //U30 ����٪��
            //U31 ������� (������15/31)
            hs.Add("eStore_Content_Classic_Slave", "U32 ����ū���� Slave Pits of the Undercity(������8/31)");
            //U33 �������� ���е��� 
            //U34 �������Tower of Frost(�г�14/28)
            hs.Add("eStore_Content_Dragonborn_1", "U35 ��ѪԤ��Dragonblood Prophecy (�г�10/31)");
            //hs.Add("", "U36 ��ɽThe Mines of Tethyamar (������15/31)");
            hs.Add("eStore_Content_Ravenloft", "U37 ѻ��Mists of Ravenloft (�Ǽ�10/31)");
            //hs.Add("", "U38 Disciples of Rage(�Ǽ�14/31)");
            hs.Add("eStore_Content_Plume", "U39 ����ɽWhite Plume Mountain(������9/32)");
            //U40 �������� ľ����
            //U41 ������� Lost at Sea(����15/32) 
            //hs.Add("", "U42 Masterminds of Sharn(Sharn15/32)");
            hs.Add("eStore_Content_Soul", "U43 The Soul Splitter(Sharn17/32)");
            hs.Add("eStore_Content_Classic_Keep", "U44 Keep on the Borderlands(������1/21)");
            hs.Add("eStore_Content_Deleras", "U45 �����Ĺ(�Ǽ�3/23)");
            hs.Add("eStore_Content_Catacombs", "U45 ������Ĺ(�г�5/27)");
            //hs.Add("", "U46 The Lost Gatekeepers(������3/32)");
            //U47  ̩̹ �������� Shavarath �����ȼ�
            hs.Add("eStore_Content_Fey", "U48 Fables of the Feywild(����5/32)");
            //hs.Add("", "U49 Peril of the Planar Eyes(�¹㳡12/32)");
            //hs.Add("", "U50 Sinister Secret of Saltmarsh(������3/32)");
            //U50 �������� ������������
            /*
eStore_Content_Classic_Hag 
eStore_Content_Codex //�ֳ��� �ż�
eStore_Content_Desire //���� ����  
eStore_Content_Plague //���� ���� 
eStore_Content_Plume_Upgrade //��ë 
eStore_Content_Relic //����
eStore_Content_Shav_Archon //ִ���� ͳ���� 
eStore_Content_Thunderholme //�׵�
 

             
             */

            hs.Add("eStore_Sharn_Standard", "U42 ���׵���ı(Masterminds of Sharn)");


            string sKey = strKey.Trim();
            if (hs.Contains(sKey))
            {
                return hs[sKey].ToString();
            }
            if (sKey.Contains("eStore_Feature_AccountBank_SharedPlatUpgrade")) return sKey.Replace("eStore_Feature_AccountBank_SharedPlatUpgrade", "���������������");
            if (sKey.Contains("eStore_Feature_MonsterManualVol")) return sKey.Replace("eStore_Feature_MonsterManualVol", "�����ֲ�");
            if (sKey.Contains("eStore_Feature_CharSlot")) return sKey.Replace("eStore_Feature_CharSlot", "��ɫ��");
            if (sKey.Contains("eStore_Feature_AccountBank_SlotsUpgrade")) return sKey.Replace("eStore_Feature_AccountBank_SlotsUpgrade", "������������");
            if (sKey.Contains("eStore_Feature_SingletonBank_SlotsUp")) return sKey.Replace("eStore_Feature_SingletonBank_SlotsUp", "��������");

            return sKey;
        }
        /// <summary>
        /// ��ò������û�Ȩ����Ϣ
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
            sbShow.Append("========����========\n");
            listContent.Add("U03 ������ѱ�x4(13/18)");
            listContent.Add("U13 U14ͨ����ѱ�(����17/0)");
            listContent.Add("U18 ������ͷ��ѱ�");
            listContent.Add("U29 ����� �����ʬ�� ����籩ɽ��");
            listContent.Add("U31 �������x3(������15/31)");
            listContent.Add("U34 �������Tower of Frost(�г�14/28)");
            listContent.Add("U41 �������Lost at Sea(����15/32)");
            listContent.Add("U47 �������The Promise of Fire(�г�6/27)");

            listContent.Sort((a, z) => a.CompareTo(z));
            sbShow.Append(string.Join("\n", listContent.ToArray()));
            sbShow.Append("\n========�˻�Ȩ��========\n");
            sbShow.Append(string.Join("\n", listBase.ToArray()));
            sbShow.Append("\n========����========\n");
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
            //δ֪ ������
            //arg.Add("--rodat on");

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
            //2021-12-20 ��ɾ��
            ////ò���ǿͷ���ַ 
            //arg.Add("--supporturl");
            //arg.Add("https://tss.ddo.com/TSSTrowser/trowser.aspx");
            ////BUG�ύ��ַ2018-11-29�¼�
            //arg.Add("--bugurl");
            //arg.Add("http://ddobugs.turbine.com?task=ticket");
            ////δ֪ 
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
