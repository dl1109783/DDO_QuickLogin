using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO.Ports;
using System.Management;
using System.Threading;
using Utilities.Extend;

namespace Utilities.System
{
    public class ComHelper
    {
        public Action<CallBackType, string> CallBack;
        SerialPort ComDevice = new SerialPort();
        Thread Do;
        public ComHelper()
        {
            Do = new Thread(ComDo);
            Do.IsBackground = true;
            Do.Start();
        }
        public void Open(string PortName, int BaudRate)
        {
            ComDevice.PortName = PortName;
            //串行波特率
            ComDevice.BaudRate = BaudRate;
            //标准数据位长度    默认值8
            ComDevice.DataBits = 8;
            //奇偶校验检查协议    默认值None
            ComDevice.Parity = Parity.None;
            //获取或设置一个字节，该字节在发生奇偶校验错误时替换数据流中的无效字节
            //ComDevice.ParityReplace = '';
            //数据传输的握手协议    默认值None
            ComDevice.Handshake = Handshake.None;
            //标准停止位数    默认值One
            ComDevice.StopBits = StopBits.One;
            //否启用请求发送 (RTS) 信号   默认值false
            ComDevice.RtsEnable = true;
            //读取超时时间
            ComDevice.ReadTimeout = 2000;
            //写入超时时间
            ComDevice.WriteTimeout = 2000;
            // 获取或设置用于解释 ReadLine()和WriteLine()方法调用结束的值 默认值“\n”
            //ComDevice.NewLine = "\n";
            ComDevice.Open();
            CallBack(CallBackType.Log, $"Open Port :[{PortName}]-[{BaudRate}]");
        }
        public void End()
        {
            ComDevice.Close();
            CallBack(CallBackType.Log, $"Port closed");
        }
        private ConcurrentQueue<byte[]> SendQueue = new ConcurrentQueue<byte[]>();
        public void SendData(string StaHexStr, string SendStr, string EndHexStr)
        {
            byte[] send = StaHexStr.HexStrToHexByte().Add<byte>(SendStr.ToHexByte()).Add<byte>(EndHexStr.HexStrToHexByte());
            SendQueue.Enqueue(send);
            CallBack(CallBackType.Log, $"Add to send Queue:[{send.ToHexString(" ")}]");
        }
        public void SendData(string SendStr)
        {
            byte[] send = SendStr.ToHexByte();
            SendQueue.Enqueue(send);
            CallBack(CallBackType.Log, $"Add to send Queue:[{send.ToHexString(" ")}]");
        }
        public void SendHexStr(string SendStr)
        {
            SendQueue.Enqueue(SendStr.HexStrToHexByte());
            CallBack(CallBackType.Log, $"Add to send Queue:[{SendStr}]");
        }
        private void ComDo()
        {
            while (true)
            {
                if (ComDevice.IsOpen)
                {
                    try
                    {
                        //读取串口数据
                        if (this.ComDevice.BytesToRead > 0)
                        {
                            byte[] buffer = new byte[this.ComDevice.BytesToRead];
                            int readCount = this.ComDevice.Read(buffer, 0, buffer.Length);

                            CallBack(CallBackType.Read, buffer.ToHexString());
                        }
                        //向串口输出队列里的数据
                        while (!SendQueue.IsEmpty)
                        {
                            if (SendQueue.TryDequeue(out byte[] o))
                            {
                                this.ComDevice.Write(o, 0, o.Length);
                                CallBack(CallBackType.Log, $"send data :[{o.ToHexString(" ")}]");
                            }
                        }
                    }
                    catch (Exception ex) { }

                    //读取噪音             01 03 00 00 00 01 84 0A 
                    //读取所有数据   01 03 00 00 00 0A C5 CD
                    byte[] w = new byte[] { 0x01, 0x03, 0x00, 0x00, 0x00, 0x01, 0x84, 0x0A };
                    ComDevice.Write(w, 0, w.Length);
                    Thread.Sleep(1000);
                }
            }
        }
        /*
        01 03 02 01 EA 38 5B 
        01 03 02 01 DB F9 8F 
        01 03 02 01 E5 78 5F 
        01 03 02 01 DB F9 8F 
        01 03 02 01 E0 B8 5C 
        01 03 02 01 FA 39 97 
        01 03 02 01 D6 38 4A 
        01 03 02 01 E5 78 5F 
        01 03 02 02 44 B9 17 
        01 03 02 02 51 78 D8 
        01 03 02 02 1C B8 ED 
        01 03 02 01 DB F9 8F 
        01 03 02 01 F7 F8 52 
        01 03 02 01 FA 39 97 
        01 03 02 01 DB F9 8F 
    */
        public List<ComInfo> GetComList()
        {
            List<ComInfo> strs = new List<ComInfo>();
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE PNPClass=\"Ports\""))//select * from Win32_SerialPort
                {
                    var hardInfos = searcher.Get();
                    foreach (var hardInfo in hardInfos)//{\\A1508052\root\cimv2:Win32_PnPEntity.DeviceID="USB\\VID_1A86&PID_7523\\5&2A842259&0&3"}
                    {
                        var name = hardInfo["Name"].ToString();
                        var comId = name.Split('(', ')');

                        strs.Add(new ComInfo() { Name = name, ComId = comId[1] });
                    }
                    searcher.Dispose();
                }
                return strs;
            }
            catch (Exception ex)
            {
                CallBack(CallBackType.Log, $"GetComList Error:{ex.ToString()}");
                return null;
            }
        }


    }
    public enum CallBackType
    {
        Message,
        Log,
        Read
    }
    public class ComInfo
    {
        public string Name;
        public string ComId;
        public override string ToString()
        {
            return Name;
        }
    }
    public enum HardwareEnum
    {
        // 硬件
        Win32_Processor, // CPU 处理器
        Win32_PhysicalMemory, // 物理内存条
        Win32_Keyboard, // 键盘
        Win32_PointingDevice, // 点输入设备，包括鼠标。
        Win32_FloppyDrive, // 软盘驱动器
        Win32_DiskDrive, // 硬盘驱动器
        Win32_CDROMDrive, // 光盘驱动器
        Win32_BaseBoard, // 主板
        Win32_BIOS, // BIOS 芯片
        Win32_ParallelPort, // 并口
        Win32_SerialPort, // 串口
        Win32_SerialPortConfiguration, // 串口配置
        Win32_SoundDevice, // 多媒体设置，一般指声卡。
        Win32_SystemSlot, // 主板插槽 (ISA & PCI & AGP)
        Win32_USBController, // USB 控制器
        Win32_NetworkAdapter, // 网络适配器
        Win32_NetworkAdapterConfiguration, // 网络适配器设置
        Win32_Printer, // 打印机
        Win32_PrinterConfiguration, // 打印机设置
        Win32_PrintJob, // 打印机任务
        Win32_TCPIPPrinterPort, // 打印机端口
        Win32_POTSModem, // MODEM
        Win32_POTSModemToSerialPort, // MODEM 端口
        Win32_DesktopMonitor, // 显示器
        Win32_DisplayConfiguration, // 显卡
        Win32_DisplayControllerConfiguration, // 显卡设置
        Win32_VideoController, // 显卡细节。
        Win32_VideoSettings, // 显卡支持的显示模式。 
        // 操作系统
        Win32_TimeZone, // 时区
        Win32_SystemDriver, // 驱动程序
        Win32_DiskPartition, // 磁盘分区
        Win32_LogicalDisk, // 逻辑磁盘
        Win32_LogicalDiskToPartition, // 逻辑磁盘所在分区及始末位置。
        Win32_LogicalMemoryConfiguration, // 逻辑内存配置
        Win32_PageFile, // 系统页文件信息
        Win32_PageFileSetting, // 页文件设置
        Win32_BootConfiguration, // 系统启动配置
        Win32_ComputerSystem, // 计算机信息简要
        Win32_OperatingSystem, // 操作系统信息
        Win32_StartupCommand, // 系统自动启动程序
        Win32_Service, // 系统安装的服务
        Win32_Group, // 系统管理组
        Win32_GroupUser, // 系统组帐号
        Win32_UserAccount, // 用户帐号
        Win32_Process, // 系统进程
        Win32_Thread, // 系统线程
        Win32_Share, // 共享
        Win32_NetworkClient, // 已安装的网络客户端
        Win32_NetworkProtocol, // 已安装的网络协议
        Win32_PnPEntity,//all device
    }
}