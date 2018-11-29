using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Utilities.General
{
    public static class HttpHelper
    {
        public static string Request(string url, string data = "", RequestMethod requestMethod = RequestMethod.Get)
        {
            try
            {
                HttpClient http = new HttpClient(new HttpClientHandler()
                {
                    //启用压缩,节省流量
                    AutomaticDecompression = DecompressionMethods.GZip
                });

                HttpResponseMessage response = null;
                switch (requestMethod)
                {
                    case RequestMethod.Send:
                        HttpRequestMessage hrm = new HttpRequestMessage(HttpMethod.Get, url);
                        HttpContent hc = new StringContent(data);
                        hc.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                        hrm.Content = hc;
                        response = http.SendAsync(hrm).Result;
                        break;
                    case RequestMethod.Put:
                        HttpContent putContent = new StringContent(data);
                        putContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                        response = http.PutAsync(url, putContent).Result;
                        break;
                    case RequestMethod.Get:
                        http.DefaultRequestHeaders.Add("ContentType", "application/x-www-form-urlencoded");
                        response = http.GetAsync(url).Result;
                        break;
                    case RequestMethod.Post:
                        HttpContent httpContent = new StringContent(data);
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                        response = http.PostAsync(url, httpContent).Result;
                        break;
                    default:
                        break;
                }
                var res = response?.Content.ReadAsStringAsync().Result;

                return res;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
    public enum RequestMethod
    {
        Get,
        Post,
        Send,
        Put
    }
}
