using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using QuickLogin.AuthServer;
using QuickLogin.DataCenterServer;

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
        /// <summary>
        /// ��������
        /// </summary>
        GLSDatacenterInfoServerSoapClient _datacenter;
        /// <summary>
        /// ��½������
        /// </summary>
        GlobalLoginSystemAuthenticationServiceSoapClient _loginServer;

        public bool isClosed;
        public World _worldSelect;

        public bool isGetNews;
        public string _strUserName;
        public string _strPassWord;
        public ConnectThread(CallBackHandler CallBak)
        {
            isClosed = false;
            isGetNews = false;
            _datacenter = new GLSDatacenterInfoServerSoapClient();
            _loginServer = new GlobalLoginSystemAuthenticationServiceSoapClient();
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
                    OnCallBack(ConnectType.GetNewsSuccess, new RSSReader().itemList);
                    return;
                }
                catch
                {
                    // OnCallBack(ConnectType.Error, ex); 
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
                    foreach (Datacenter datacenter in _datacenter.GetDatacenters("DDO"))
                    {
                        if ((datacenter != null) && datacenter.Name.Equals("DDO"))
                        {
                            OnCallBack(ConnectType.GetDataCenterSuccess, datacenter.Worlds);
                            return;
                        }
                    }
                }
                catch
                {
                    //OnCallBack(ConnectType.Error, exxx.ToString());
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
            hs.Add("Community_Offer_YellowCube", "�ƹ���");


            string sKey = strKey.Replace("\n", "").Trim();
            if (hs.Contains(sKey))
            {
                return hs[sKey].ToString() + "\n";
            }
            return strKey;
        }
        /// <summary>
        /// ��ò������û�Ȩ����Ϣ
        /// </summary>
        /// <param name="p_strProductTokens"></param>
        private string GetProductTokens(string[] p_strProductTokens)
        {
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
            GameSubscription _userGSB = null;
            ServerStatus _worldSelectStatus;
            bool blGet = true;
            int i = 0;
            while (blGet)
            {
                i++;
                try
                {
                    #region ��½��֤
                    StatusServerResult[] _worldStatus = _datacenter.GetDatacenterStatus("DDO");//ȡ������״̬ 
                    if (_worldStatus != null && _worldSelect.StatusServerUrl.LastIndexOf('=') > 0)
                    {
                        //http://gls.ddo.com/GLS.DataCenterServer/StatusServer.aspx?s=10.192.145.41
                        string strServerIP = _worldSelect.StatusServerUrl.Split('=')[1];
                        foreach (StatusServerResult sr in _worldStatus)
                        {
                            if (sr.ServerName == strServerIP)
                            {
                                if (sr.Results.Trim() == string.Empty)
                                {
                                    OnCallBack(ConnectType.LoginFaild, "����������Ӧ !");
                                    return;
                                }
                                _worldSelectStatus = new ServerStatus(sr.Results);
                                if (_worldSelectStatus != null && !_worldSelectStatus.IsFull && !_worldSelectStatus.IsOpen)
                                {
                                    _worldSelect.LoginServerUrl = _worldSelectStatus.LoginServer;//74.201.106.22:9004;74.201.106.22:9003;
                                    _loginUser = _loginServer.LoginAccount(_strUserName, _strPassWord, null);

                                    if (_loginUser != null && _loginUser.Subscriptions != null)
                                    {
                                        ArrayList al = new ArrayList();
                                        foreach (GameSubscription gsb in _loginUser.Subscriptions)
                                        {
                                            if (gsb.Game == "DDO")
                                            {
                                                al.Add(gsb);
                                            }
                                        }
                                        if (al.Count == 1) _userGSB = (GameSubscription)al[0];
                                        else if (al.Count > 1)
                                        {
                                            CheckUser cu = new CheckUser(al);
                                            cu.ShowDialog();
                                            _userGSB = cu.checkGsb;
                                            cu.Dispose();
                                        }
                                    }
                                    if (_userGSB != null)
                                    {
                                        string[] strQueueURLs = _worldSelectStatus.queueURLs.TrimEnd(';').Split(';');
                                        _worldSelectStatus.TakeANumber(_userGSB.Name, _loginUser.Ticket, strQueueURLs[strQueueURLs.Length - 1]);//http://10.67.112.22:7082/LoginQueue;http://10.67.112.22:7081/LoginQueue;
                                        blGet = false;
                                        break;
                                    }
                                    else
                                    {
                                        OnCallBack(ConnectType.LoginFaild, "û���ҵ�DDO�˻�");
                                        return;
                                    }
                                }
                                else break;
                            }
                        }
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    OnCallBack(ConnectType.Error, ex);
                    //��¼ʧ�ܣ��������޷����ӣ�
                    blGet = false;
                    return;
                }
                if (i > 10)
                {
                    OnCallBack(ConnectType.LoginFaild, "����������Ӧ !");
                    blGet = false;
                    return;
                }
            }
            if (_userGSB != null && _userGSB.Status.Equals("Banned"))
            {
                //�������û�
                OnCallBack(ConnectType.LoginFaild, "�û��ѱ�ͣ�� !");
                blGet = false;
                return;
            }
            UserList userLists = new UserList();
            userLists.DefaultUser = new User();
            userLists.DefaultUser.UserName = _strUserName;
            userLists.DefaultUser.PassWord = _strPassWord;
            userLists.DefaultUser.WorldName = _worldSelect.Name;

            //��������?
            //http://gls.DDO.com/GLS.DataCenterServer/Service.asmx
            StringBuilder builder = new StringBuilder();
            //���ܺ���û���
            builder.Append("-a " + _userGSB.Name);
            //��������ַ
            builder.Append(" -h " + _worldSelect.LoginServerUrl);
            //�²��Ǽ��ܺ�Ľ�ɫ��Ϣ
            builder.Append(" --glsticketdirect " + _loginUser.Ticket);
            //��������� 198.252.160.45:2900 
            builder.Append(" --chatserver " + _worldSelect.ChatServerUrl.Split(';')[0]);
            //δ֪
            builder.Append(" --rodat on ");

            //����
            builder.Append(" --language English ");
            //builder.Append(" --language ZH_CN ");

            //��Ϸ����--�����ָ�����õ�һ��������
            builder.Append(" --gametype DDO ");

            //��ɫ��¼��֤������
            builder.Append(" --authserverurl https://gls.ddo.com/GLS.AuthServer/Service.asmx  ");
            //��֤���ʱ��?
            builder.Append(" --glsticketlifetime 21600");

            //ò���ǿͷ���ַ
            builder.Append(" --supporturl https://tss.turbine.com/TSSTrowser/trowser.aspx  ");

            //BUG�ύ��ַ2018-11-29�¼�
            builder.Append("  --bugurl http://ddobugs.turbine.com?task=ticket  ");

            //δ֪
            builder.Append(" --supportserviceurl https://tss.turbine.com/TSSTrowser/SubmitTicket.asmx ");

            builder.Append("");
            try
            {
                userLists.Save(builder.ToString());
                //��¼̫���������������Ӧ������1���ٵ�¼
                Thread.Sleep(1000);
                Process.Start(new ProcessStartInfo("dndclient.exe", builder.ToString()));
                OnCallBack(ConnectType.LoginSuccess, GetProductTokens(_userGSB.ProductTokens));
            }
            catch (Exception ex)
            {
                OnCallBack(ConnectType.Error, ex);
            }
        }
    }

}
