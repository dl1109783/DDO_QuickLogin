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
            hs.Add("DDO_MOTU_PreOrder_Bundle", "Ԥ������");
            hs.Add("DDODruidPack", "��³����");
            hs.Add("FULL", "ȫ��");
            hs.Add("PaidPoints", "�����û�");
            hs.Add("StormreachGuest", "����Ȩ��");
            hs.Add("StormreachStandard", "��׼Ȩ��");
            hs.Add("TREATED_AS_SUBSCRIBER", "�����û�");
            hs.Add("XP2_CharacterSlot_Premium", "��ɫ������");
            hs.Add("XP2_Premium", "U20��Ʒ");

            hs.Add("eStore_Content_Catacombs", "��Ĺ");
            hs.Add("eStore_Content_Shantokor", "���п˴���(STK)");
            hs.Add("eStore_Content_TanglerootGorge", "����");
            hs.Add("eStore_Content_Deleras", "��Ĺ");
            hs.Add("eStore_Content_ThreeBarrelCove", "��Ͱ��");
            hs.Add("eStore_Content_RuinsOfThrenal", "˾��ŵ����");
            hs.Add("eStore_Content_SorrowduskIsles", "��ĺ��");
            hs.Add("eStore_Content_VaultOfNight", "����ά��(VON����Raid)");
            hs.Add("eStore_Content_RestlessIsle", "���ε�(̩̹Raid)");
            hs.Add("eStore_Content_SandsOfMenechtarun", "ɳĮ(Ů��Raid)");
            hs.Add("eStore_Content_GiantholdRuins", "�������(U17������Raid)");
            hs.Add("eStore_Content_Necropolis", "������1");
            hs.Add("eStore_Content_Necropolis2", "������2");
            hs.Add("eStore_Content_Necropolis3", "������3");
            hs.Add("eStore_Content_Necropolis4", "������4(����Raid)");
            hs.Add("eStore_Content_ValeOfTwilight", "ʮ��ħ��(��ʬ��Raid)");
            hs.Add("eStore_Content_ReaversReach", "ˮ��(SOS)");
            hs.Add("eStore_Content_Shavarath", "ɳ����˹(ս��)");
            hs.Add("eStore_Content_CrimeWave", "ɯ�����ϼ�(�г�С��)");
            hs.Add("eStore_Content_Inspired", "���֮·(�º���U1)");
            hs.Add("eStore_Content_Dreaming", "���еĺڰ�(�º���U2)");
            hs.Add("eStore_Content_Sentinels", "�籩����ڱ�(U4)");
            hs.Add("eStore_Content_Carnival", "�ư����񻶽�(U5)");
            hs.Add("eStore_Content_Swamp", "��ɫ����(U6)");//Swamp����
            hs.Add("eStore_Content_DevilAssault", "��ħͻϮ(U7�г�Raid)");
            hs.Add("eStore_Content_Droaam2", "�籩���ս��(U8ը��)");  //Droaamը����ķ��ӹ�ͷ��
            hs.Add("eStore_Content_Taken", "����Ԥ��(U9)");//Takenȳ�Ȼ��ι�
            hs.Add("eStore_Content_Xoriat", "����ͳ��(U10)");
            hs.Add("eStore_Content_Blades1", "����������ս(U11)");
            hs.Add("eStore_Content_Blades2", "��������(U12-����Raid)");
            hs.Add("estore_Content_EveningstarAdventures", "������˹�ظ�����(U14-C1)");
            hs.Add("estore_Content_EveningstarChallenges", "������˹����ս(U14-C1)");
            hs.Add("estore_Content_EveningstarLandscape", "������˹��Ұ��(U14-C1)");
            hs.Add("estore_Content_UnderdarkAdventures", "�ڰ����򸱱���(U14-C2)");
            hs.Add("estore_Content_UnderdarkLandscape", "�ڰ�����Ұ��(U14-C2)");
            hs.Add("estore_Content_DemonwebAdventures", "��ħ����������(U14-C3-Raid)");
            hs.Add("estore_Content_DemonwebLandscape", "��ħ����Ұ��(U14-C3)");
            hs.Add("eStore_Content_Plant", "��³�����ڲ�(U15��ľ����)");//ֲ��
            hs.Add("eStore_Content_Castles", "��Ӱ֮·(U16)");//Castles�Ǳ�
            hs.Add("eStore_Content_Wheloon", "��Ӱ�����е�����(U19)");//Wheloon����   
            hs.Add("eStore_Content_Stormhorns", "�ڰ��е���ı(U20)");//Stormhorns�籩��


            hs.Add("eStore_Feature_32PtBuild", "32�㿪��");
            hs.Add("eStore_Feature_AccountBank", "��������");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_1", "������������1");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_2", "������������2");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_3", "������������3");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_4", "������������4");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_5", "������������5");
            hs.Add("eStore_Feature_AccountBank_SlotsUpgrade_6", "������������6");
            hs.Add("eStore_Feature_Bladeforged", "���������");
            hs.Add("eStore_Feature_CharSlot", "��ɫλ1");
            hs.Add("eStore_Feature_CharSlot_2", "��ɫλ2");
            hs.Add("eStore_Feature_CharSlot_3", "��ɫλ3");
            hs.Add("eStore_Feature_CharSlot_4", "��ɫλ4");
            hs.Add("eStore_Feature_CharSlot_5", "��ɫλ5");
            hs.Add("eStore_Feature_CharSlot_6", "��ɫλ6");

            hs.Add("eStore_Feature_Druid", "��³��");
            hs.Add("eStore_Feature_EpicDestinies", "��������");
            hs.Add("eStore_Feature_FavoredSoul", "����");
            hs.Add("eStore_Feature_HalfElf", "�뾫��");
            hs.Add("eStore_Feature_HalfOrc", "������");
            hs.Add("eStore_Feature_HeadStart", "���������Ѷȿ���");
            hs.Add("eStore_Feature_Monk", "����");
            hs.Add("eStore_Feature_Morninglord", "�վ���");
            hs.Add("eStore_Feature_PurpleDragonKnight", "������ʿ");
            hs.Add("eStore_Feature_Shadarkai", "Ӱ��");
            hs.Add("eStore_Feature_Warforged", "������");
            hs.Add("eStore_Feature_DeepGnome", "��Ԩ٪��");
            hs.Add("eStore_Feature_Warlock", "а��ʦ(����)");

            hs.Add("Community_Offer_YellowCube", "�ƹ���");


            string sKey = strKey.Replace("\n", "").Trim();
            if (hs.Contains(sKey))
            {
                return hs[sKey].ToString() + "\n";
            }
            NoMatch.Add(strKey);

            if (sKey.Contains("eStore_Feature_AccountBank_SharedPlatUpgrade")) return sKey.Replace("eStore_Feature_AccountBank_SharedPlatUpgrade", "�������в���") + "\n";
            if (sKey.Contains("CharacterSlot")) return sKey.Replace("CharacterSlot", "��ɫ��") + "\n";
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
            sbShow.Append("============�˻�Ȩ��=========\n");
            foreach (string _info in listBase)
            {
                sbShow.Append(GetDes(_info));
            }
            listContent.Sort();
            sbShow.Append("============����============\n");
            foreach (string _info in listContent)
            {
                sbShow.Append(GetDes(_info));
            }
            listFeature.Sort();
            sbShow.Append("============����============\n");
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
                while (true)
                {
                    i++;
                    serverStatus.GetRandomUrl();
                    //��½�Ŷ� 
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
            arg.Add("--rodat");
            arg.Add("on");

            //����
            arg.Add("--language");
            arg.Add("English");
            //dicArg.Add(" --language ZH_CN ");

            //��Ϸ����--�����ָ�����õ�һ��������
            arg.Add("--gametype");
            arg.Add("DDO");
            //��ɫ��¼��֤������
            arg.Add("--authserverurl");
            arg.Add("https://gls.ddo.com/GLS.AuthServer/Service.asmx");
            //��֤���ʱ��?
            arg.Add("--glsticketlifetime");
            arg.Add("21600");
            //ò���ǿͷ���ַ
            arg.Add("--supporturl");
            arg.Add("https://tss.turbine.com/TSSTrowser/trowser.aspx");
            //BUG�ύ��ַ2018-11-29�¼�
            arg.Add("--bugurl");
            arg.Add("http://ddobugs.turbine.com?task=ticket");
            //δ֪
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
