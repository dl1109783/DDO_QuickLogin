using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace Utilities.System
{
    public static class NetworkInformationHelper
    {

        [DllImport("IPHLPAPI.dll")]
        private static extern int SendARP(Int32 DestIP, Int32 ScrIP, ref Int64 pMacAddr, ref Int32 PhyAddrLen);

        /// <summary>
        /// 通过IP地址获取MAC
        /// </summary>
        /// <param name="hostip"></param>
        /// <returns></returns>
        public static string[] GetMacAddress(IPAddress hostip)//获取远程IP（不能跨网段）的MAC地址
        {
            string[] Mac = new string[] { "00", "00", "00", "00", "00", "00" };
            try
            {
                //hostip.ToInt32()
                // 172.16.6.159
                //var a = IPAddress.Parse("172.16.6.159");
                //var d = (int)a.Address;
                //var b = IPAddress.NetworkToHostOrder((int)a.Address);
                //var c = inet_addr("172.16.6.159"); 

                Int64 macinfo = new Int64();
                Int32 len = 6;
                //SendARP函数发送一个地址解析协议(ARP)请求获得指定的目的地IPv4地址相对应的物理地址
                SendARP((int)hostip.Address, 0, ref macinfo, ref len);
                if (macinfo == 0) return null;
                string TmpMac = Convert.ToString(macinfo, 16).PadLeft(12, '0');//转换成16进制　　注意有些没有十二位 
                for (int i = 0; i < TmpMac.Length; i = i + 2)
                {
                    Mac[i / 2] = TmpMac.Substring(i, 2).ToUpper();
                }
            }
            catch (Exception Mye)
            {
                return null;
            }
            return Mac;
        }
        /// <summary>
        /// 检查指定IP的某个端口是否打开
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        public static bool CheckPort(IPAddress ip, int port)
        {
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    IAsyncResult asyncResult = client.BeginConnect(ip, port, null, null);
                    asyncResult.AsyncWaitHandle.WaitOne(3000, true);
                    return asyncResult.IsCompleted;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// 扫描指定IP有那些端口打开了
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="begin"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static List<int> ScanPort(IPAddress ip, int begin = 0, int end = 65539)
        {
            List<int> portList = new List<int>();
            for (int i = begin; i <= end; i++)
            {
                try
                {
                    using (TcpClient client = new TcpClient())
                    {
                        client.Connect(ip, i);
                        if (client.Connected) portList.Add(i);
                    }

                }
                catch
                {
                }
            }
            return portList;
        }

        public static Int32 ToInt32(this IPAddress addr)
        {
            // careful of sign extension: convert to uint first;
            // unsigned NetworkToHostOrder ought to be provided.
            return (Int32)IPAddress.NetworkToHostOrder((int)addr.Address);
        }

        public static IPAddress ToAddr(long address)
        {
            return IPAddress.Parse(address.ToString());
            // This also works:
            // return new IPAddress((uint) IPAddress.HostToNetworkOrder(
            // (int) address)).ToString();
        }
        public static string GetHostName(IPAddress ip)
        {
            try
            {
                var host = Dns.GetHostByAddress(ip);
                return host.HostName;
            }
            catch (Exception e)
            {
                return "error";
            }
        }
        /// <summary>
        /// 获得本机网卡信息
        /// </summary>
        /// <returns></returns>
        public static IPAddress GetLocalHostNetworkInterface()
        {
            IPAddress ip = null;
            var netInfos = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in netInfos)
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    var netInfo = ni.GetIPProperties();
                    var ipList = netInfo?.UnicastAddresses;
                    if (ipList.Count > 0)
                    {
                        ip = ipList[ipList.Count - 1].Address;
                        var IPv4Mask = ipList[ipList.Count - 1].IPv4Mask;
                    }
                    var getWay = netInfo.GatewayAddresses;
                    var dnsS = netInfo.DnsAddresses;
                    var dhcp = netInfo.DhcpServerAddresses;

                }
            }
            return ip;
        }

        public static IPAddress GetLocalHostIP()
        {
            IPHostEntry me = Dns.GetHostEntry(Environment.MachineName);

            return me.AddressList[me.AddressList.Length - 1];
        }

        public static IPAddress GetLocalHostIp(string strHostName)
        {
            IPHostEntry myEntry = Dns.GetHostEntry(strHostName);
            IPAddress ipAddress = myEntry.AddressList[0];
            return ipAddress;
        }

        public static int[] GetIpByBytes(byte[] ip)
        {
            int[] iip = new int[] { 0, 0, 0, 0 };

            return iip;
        }

    }
}
