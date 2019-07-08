using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using QuickLogin.Properties;

namespace QuickLogin.Connect
{
    public static class WebServiceComm
    {
        /// <summary>
        /// 数据中心地址，获得服务器地址，状态等数据
        /// </summary>
        static readonly string DATA_CENTER_SERVER = "http://gls.ddo.com/GLS.DataCenterServer/Service.asmx";
        static readonly string TAKE_A_NUMBER_URL = "http://gls.DDO.com/GLS.AuthServer/LoginQueue.aspx";
        static readonly XNamespace xNamespace = "http://www.turbine.com/SE/GLS";
        static readonly int Timeout = 5 * 1000;
        /// <summary>
        /// 获得服务器列表
        /// </summary>
        /// <returns></returns>
        public static Datacenter GetDatacenter()
        {
            string xml = Resources.GetDatacenters;
            var xDoc = CallUrlBySoap(DATA_CENTER_SERVER, xml);
            //var xDoc = XDocument.Parse(Resources.GetDatacenters_feedback); //测试
            Datacenter datacenter = new Datacenter();
            var xWorlds = xDoc.Descendants(xNamespace + "World");
            datacenter.Worlds = (from item in xWorlds
                                 select new World()
                                 {
                                     Name = item.GetValByNamespace("Name"),
                                     ChatServerUrl = GetRandomServerUrl(item.GetValByNamespace("ChatServerUrl")),
                                     //直接访问这个地址可以取得服务器的状态
                                     //http://gls.ddo.com/GLS.DataCenterServer/StatusServer.aspx?s=10.192.145.17
                                     StatusServerUrl = item.GetValByNamespace("StatusServerUrl"),
                                     Language = item.GetValByNamespace("Language"),
                                     Order = item.GetValByNamespace("Order")
                                 }
                     ).ToList();
            var xDatacenter = xDoc.Descendants(xNamespace + "Datacenter").FirstOrDefault();
            //登录服务器
            //https://gls-auth.ddo.com/GLS.AuthServer/Service.asmx
            datacenter.AuthServer = xDatacenter.GetValByNamespace("AuthServer");
            datacenter.LauncherConfigurationServer = xDatacenter.GetValByNamespace("LauncherConfigurationServer");
            datacenter.PatchServer = xDatacenter.GetValByNamespace("PatchServer");
            return datacenter;
        }
        /// <summary>
        /// 获取服务器状态信息
        /// </summary>
        /// <param name="StatusServerUrl"></param>
        /// <returns></returns>
        public static ServerStatus GetServerStatus(string StatusServerUrl)
        {
            var xDoc = CallUrlByGet(StatusServerUrl);
            return new ServerStatus(xDoc);
        }

        /// <summary>
        /// 验证用户名密码
        /// </summary>
        /// <param name="AuthServer"></param>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static UserProfile LoginAccount(string AuthServer, string UserName, string Password)
        {
            string xml = Resources.LoginAccount;
            var xDoc = CallUrlBySoap(AuthServer, string.Format(xml, UserName, Password));
            //var xDoc = XDocument.Parse(Resources.LoginAccount_feedback); //测试 
            UserProfile userProfile = new UserProfile();
            var xSubscription = xDoc.Descendants(xNamespace + "GameSubscription");
            userProfile.SubscriptionUser = (from item in xSubscription
                                            where item.Element(xNamespace + "Game").Value == "DDO"
                                            select new SubscriptionUser()
                                            {
                                                SubscriptionName = item.GetValByNamespace("Name"),
                                                Description = item.GetValByNamespace("Description"),
                                                Status = item.GetValByNamespace("Status"),
                                                ProductTokens = GetProductTokens(item)
                                            }
                     ).ToList();
            userProfile.Ticket = xDoc.Descendants(xNamespace + "LoginAccountResult").FirstOrDefault().Element(xNamespace + "Ticket").Value;
            return userProfile;
        }
        public static List<string> GetProductTokens(XElement item)
        {
            try
            {
                if (item != null)
                {
                    var node = item.Element(xNamespace + "ProductTokens");
                    if (node != null)
                    {
                        var els = node.Elements();
                        if (els != null && els.Count() > 0)
                        {
                            var list = (from x in els select x.Value);
                            if (list != null && list.Count() > 0)
                            {
                                return list.ToList();
                            }
                        }
                    }
                }
            }
            catch (Exception e) { Trace.WriteLine(e.ToString()); }
            return null;
        }

        public static TakeNumber TakeANumber(string SubscriptionName, string Ticket, string QueueURL)
        {
            string takeANumberParameters = "command=TakeANumber&subscription={0}&ticket={1}&ticket_type=GLS&queue_url={2}";
            string postData = string.Format(
                takeANumberParameters,
                Comm.UrlEncode(SubscriptionName, Encoding.ASCII),
                Comm.UrlEncode(Ticket, Encoding.ASCII),
                Comm.UrlEncode(QueueURL, Encoding.ASCII));
            //请求头
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(TAKE_A_NUMBER_URL);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Turbine Launcher";
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Timeout = Timeout;
            //写入数据
            request.WriteRequestData(postData);
            //返回信息
            var xDoc = request.GetResponseData();
            //登录队列， 人多时有排队现象， 不做控制会登录不了，2019-07-08
            return new TakeNumber(xDoc);
        }




        public static string GetVal(this XElement element, string Name)
        {
            string val = string.Empty;
            try
            {
                if (element != null)
                {
                    var node = element.Element(Name);
                    if (node != null && !string.IsNullOrEmpty(node.Value))
                    {
                        return node.Value.Trim();
                    }
                }
            }
            catch (Exception e) { Trace.WriteLine(e.ToString()); }
            return val;
        }


        static string GetValByNamespace(this XElement element, string Name)
        {
            string val = string.Empty;
            try
            {
                if (element != null)
                {
                    var node = element.Element(xNamespace + Name);
                    if (node != null && !string.IsNullOrEmpty(node.Value))
                    {
                        return node.Value.Trim();
                    }
                }
            }
            catch (Exception e) { Trace.WriteLine(e.ToString()); }
            return val;
        }

        /// <summary>
        /// 调用WebService，SOAP 1.2协议
        /// </summary>
        /// <param name="Uri"></param>
        /// <param name="xml"></param>
        /// <returns></returns>
        static XDocument CallUrlBySoap(string Uri, string xml)
        {
            //请求头
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Uri);
            request.Method = "POST";
            request.ContentType = "application/soap+xml; charset=utf-8";
            SetHeaderValue(request.Headers, "Host", "gls.ddo.com");
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Timeout = Timeout;
            //写入数据
            request.WriteRequestData(xml);
            //返回信息
            return request.GetResponseData();
        }
        static XDocument CallUrlByGet(string Uri)
        {
            //请求头
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Uri);
            request.Method = "GET";
            request.ContentType = "text/xml; charset=utf-8";
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Timeout = Timeout;
            //返回信息
            return request.GetResponseData();
        }



        /// <summary>
        /// 读取Response中的数据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        static XDocument GetResponseData(this HttpWebRequest request)
        {
            using (StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream(), Encoding.UTF8))
            {
                string retXml = reader.ReadToEnd();
                reader.Close();
                return XDocument.Parse(retXml);
            }
        }

        /// <summary>
        /// 将数据写入RequestStream
        /// </summary>
        /// <param name="request"></param>
        /// <param name="text"></param>
        static void WriteRequestData(this HttpWebRequest request, string text)
        {
            //请求内容
            byte[] data = Encoding.UTF8.GetBytes(text);
            request.ContentLength = data.Length;
            using (Stream writer = request.GetRequestStream())
            {
                writer.Write(data, 0, data.Length);
                writer.Close();
            }
        }


        /// <summary>
        /// 设置WebRequest头
        /// </summary>
        /// <param name="header"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private static void SetHeaderValue(WebHeaderCollection header, string name, string value)
        {
            var property = typeof(WebHeaderCollection).GetProperty("InnerCollection", BindingFlags.Instance | BindingFlags.NonPublic);
            if (property != null)
            {
                var collection = property.GetValue(header, null) as NameValueCollection;
                collection[name] = value;
            }
        }
        public static T GetRandom<T>(this T[] array)
        {
            var index = new Random().Next(array.Length);
            return array[index];
        }
        public static string GetRandomServerUrl(string Url)
        {
            if (Url.Contains(';'))
            {
                return Url.Trim(';').Split(';').GetRandom();
            }
            else return Url;
        }
    }
    public class Datacenter
    {
        public List<World> Worlds;
        public string AuthServer;
        public string PatchServer;
        public string LauncherConfigurationServer;
    }
    public class World
    {
        public string Name;
        public string ChatServerUrl;
        public string StatusServerUrl;
        public string Order;
        public string Language;
        public override string ToString()
        {
            return Name;
        }
    }


    public class UserProfile
    {
        public string Ticket;
        public SubscriptionUser SelectUser;
        public List<SubscriptionUser> SubscriptionUser;
    }
    public class SubscriptionUser
    {
        public string SubscriptionName;
        public string Status;
        public string Description;
        public List<string> ProductTokens;
    }

    public class ServerStatus
    {
        /*
         <Status>
  <logintiers>0;1;2;</logintiers>
  <name>Cannith</name>
  <queuenames>B2BC2C51-E34A-44B6-B440-7B3B8708BE02;2E9F9260-623A-4B45-90CC-B503B871B2DF;</queuenames>
  <allow_billing_role>TurbineEmployee,TurbineVIP,StormreachLimited,StormreachStandard,StormreachGuest,StormreachEUPre</allow_billing_role>
  <lastassignedqueuenumber>0x00011D22</lastassignedqueuenumber>
  <logintierlastnumbers>72992;72994;72991;</logintierlastnumbers>
  <farmid>25</farmid>
  <deny_admin_role/>
  <world_full>false</world_full>
  <wait_hint>34.030</wait_hint>
  <queueurls>http://10.192.145.17:7082/LoginQueue;http://10.192.145.17:7081/LoginQueue;</queueurls>
  <allow_admin_role>Server,CustomerService,Observer,SeniorCustomerService,LeadCustomerService,Test</allow_admin_role>
  <nowservingqueuenumber>0x00011D22</nowservingqueuenumber>
  <deny_billing_role/>
  <logintiermultipliers>1;2;3;</logintiermultipliers>
  <loginservers>198.252.160.41:9004;198.252.160.41:9003;</loginservers>
  <world_pvppermission>0</world_pvppermission>
</Status>
             
             */
        public ServerStatus(XDocument xml)
        {
            XElement xDocument = xml.Root;
            LoginServers = xDocument.GetVal("loginservers").TrimEnd(';').Split(';');
            QueueURLs = xDocument.GetVal("queueurls").TrimEnd(';').Split(';');
            IsFull = xDocument.GetVal("world_full") == "true";
        }
        public string[] QueueURLs;
        public bool IsFull;
        public string[] LoginServers;
    }
    public class TakeNumber
    {
        /*
<Result>
<Command>TakeANumber</Command>
<HResult>0x00000000</HResult>
<QueueName>7EC32C5C-894A-40C6-B7E2-C0402DD8B695</QueueName>
<QueueNumber>0x000018c7</QueueNumber>
<NowServingNumber>0x000018cd</NowServingNumber>
<LoginTier>1</LoginTier>
<ContextNumber>0x000007b0</ContextNumber>
</Result>
 */
        public TakeNumber(XDocument xml)
        {
            XElement xDocument = xml.Root;
            QueueName = xDocument.GetVal("QueueName");
            string qNum = xDocument.GetVal("QueueNumber").ToUpper().TrimStart('0', 'X');
            string nowNun = xDocument.GetVal("NowServingNumber").ToUpper().TrimStart('0', 'X');
            string cNum = xDocument.GetVal("ContextNumber").ToUpper().TrimStart('0', 'X');
            string tier = xDocument.GetVal("LoginTier");
            if (!string.IsNullOrEmpty(qNum.Trim()))
            {
                QueueNumber = Convert.ToInt32(qNum, 16);
            }
            if (!string.IsNullOrEmpty(nowNun.Trim()))
            {
                NowServingNumber = Convert.ToInt32(nowNun, 16);
            }
            if (!string.IsNullOrEmpty(cNum.Trim()))
            {
                ContextNumber = Convert.ToInt32(cNum, 16);
            }
            if (!string.IsNullOrEmpty(tier.Trim()))
            {
                LoginTier = Convert.ToInt32(tier, 10);
            }
        }
        public string QueueName;
        public int QueueNumber;
        public int NowServingNumber;
        public int ContextNumber;
        public int LoginTier;
    }

}
