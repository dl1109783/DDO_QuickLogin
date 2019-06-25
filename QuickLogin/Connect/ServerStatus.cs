using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using QuickLogin.Properties;

namespace QuickLogin.Connect
{
    public class ServerStatus
    {
        public string queueURLs = null;
        public string loginservers;

        public string LoginServer {
            get {
                string[] strValue = loginservers.TrimEnd(new char[] { ';' }).Split(';');
                return strValue[1];//[strValue.Length - 1];
            }
        }
        public uint nowServing = 0;
        public uint lastServed = 0;
        public float waitHint = 0f;
        public string queueNames = null;
        public string loginTiers = null;
        public string loginTierLastNumbers = null;
        public string loginTierMultipliers = null;
        public bool IsOpen = false;
        public bool IsFull;
        public int farmid;
        public string allow_admin_role;
        public string allow_billing_role;
        public string deny_admin_role;
        public string deny_billing_role;
        public ServerStatus(string p_strResult)
        {

            try
            {
                XmlDocument document = new XmlDocument();
                document.LoadXml(p_strResult);
                CultureInfo info = new CultureInfo("en-US", false);
                try
                {
                    nowServing = uint.Parse(document["Status"]["nowservingqueuenumber"].InnerText.Substring(2), NumberStyles.HexNumber);
                    lastServed = uint.Parse(document["Status"]["lastassignedqueuenumber"].InnerText.Substring(2), NumberStyles.HexNumber);
                    waitHint = float.Parse(document["Status"]["wait_hint"].InnerText, info.NumberFormat);
                    queueNames = document["Status"]["queuenames"].InnerText;
                    queueURLs = document["Status"]["queueurls"].InnerText;
                }
                catch (NullReferenceException)
                {
                }
                try
                {
                    loginTiers = document["Status"]["logintiers"].InnerText;
                    loginTierLastNumbers = document["Status"]["logintierlastnumbers"].InnerText;
                    loginTierMultipliers = document["Status"]["logintiermultipliers"].InnerText;
                }
                catch (NullReferenceException)
                {
                    loginTiers = null;
                    loginTierLastNumbers = null;
                    loginTierMultipliers = null;
                }
                IsFull = bool.Parse(document["Status"]["world_full"].InnerText);
                loginservers = document["Status"]["loginservers"].InnerText;
                farmid = int.Parse(document["Status"]["farmid"].InnerText);
                allow_admin_role = document["Status"]["allow_admin_role"].InnerText;
                allow_billing_role = document["Status"]["allow_billing_role"].InnerText;
                deny_admin_role = document["Status"]["deny_admin_role"].InnerText;
                deny_billing_role = document["Status"]["deny_billing_role"].InnerText;
            }
            catch
            {
            }
        }
        string queueName;
        uint queueNumber, queueContextNumber, queueNowServing, loginTier;
        public void TakeANumber(string p_strSubscriptionName, string p_strGlsTicket, string p_strQueueURL)
        {
            int num = 5;
            while ((num > 0) && (this.queueName == null))
            {
                num--;
                this.queueName = string.Empty;
                string takeANumberParameters = "command=TakeANumber&subscription={0}&ticket={1}&ticket_type=GLS&queue_url={2}";
                string postData = string.Format(takeANumberParameters, HttpUtility.UrlEncode(p_strSubscriptionName, Encoding.ASCII), HttpUtility.UrlEncode(p_strGlsTicket, Encoding.ASCII), HttpUtility.UrlEncode(p_strQueueURL, Encoding.ASCII));
                XmlDocument document = this.LoginQueuePostRequest(Settings.Default.LoginQueueUrl, postData);
                if (document.InnerText != string.Empty)
                {
                    string innerText = document["Result"]["HResult"].InnerText;
                    int error = int.Parse(innerText.Substring(2), NumberStyles.HexNumber);
                    if (error >= 0)
                    {
                        this.queueName = document["Result"]["QueueName"].InnerText;
                        this.queueNumber = this.ParseNumeric(document["Result"]["QueueNumber"].InnerText);
                        this.queueContextNumber = this.ParseNumeric(document["Result"]["ContextNumber"].InnerText);
                        this.queueNowServing = this.ParseNumeric(document["Result"]["NowServingNumber"].InnerText);
                        if (document["Result"]["LoginTier"] != null)
                        {
                            this.loginTier = this.ParseNumeric(document["Result"]["LoginTier"].InnerText);
                            //this.altQueueNumber = this.selectedWorld.GetAltQueueNumber(this.loginTier);
                        }
                        else
                        {
                            this.loginTier = 0;
                        }
                    }
                    else
                    {
                        //ªÿ¿°¥ÌŒÛ–≈œ¢
                    }
                }
            }

        }
        private uint ParseNumeric(string s)
        {
            if ((s == null) || s.Equals(string.Empty))
            {
                return 0;
            }
            if (s.StartsWith("0x"))
            {
                return uint.Parse(s.Substring(2), NumberStyles.HexNumber);
            }
            return uint.Parse(s);
        }
        public XmlDocument LoginQueuePostRequest(string url, string postData)
        {
            XmlDocument document = new XmlDocument();
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                byte[] bytes = Encoding.UTF8.GetBytes(postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bytes.Length;
                request.UserAgent = "Turbine Launcher";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string xml = new StreamReader(response.GetResponseStream()).ReadToEnd();
                document.LoadXml(xml);
                response.Close();
            }
            catch
            {
            }
            return document;
        }
    }
}
