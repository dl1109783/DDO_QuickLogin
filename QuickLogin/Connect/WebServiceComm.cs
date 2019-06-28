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
            var xDatacenter = xDoc.Root;
            ServerStatus serverStatus = new ServerStatus();
            serverStatus.LoginServers = xDatacenter.GetVal("loginservers").TrimEnd(';').Split(';');
            serverStatus.QueueURLs = xDatacenter.GetVal("queueurls").TrimEnd(';').Split(';');
            serverStatus.IsFull = xDatacenter.GetVal("world_full") == "true";
            return serverStatus;
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
            //var xDoc = CallUrlBySoap(AuthServer, string.Format(xml, UserName, Password));
            var xDoc = XDocument.Parse(Resources.LoginAccount_feedback); //测试 
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

        public static void TakeANumber(string SubscriptionName, string Ticket, string QueueURL)
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
        }




        static string GetVal(this XElement element, string Name)
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
    public class ServerStatus
    {
        public string[] QueueURLs;
        public bool IsFull;
        public string[] LoginServers;
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

}
