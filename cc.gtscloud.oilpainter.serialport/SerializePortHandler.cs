using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace cc.gtscloud.oilpainter.serialport
{
    /// <summary>
    /// 串口操作类
    /// </summary>
    public class SerializePortHandler : IDisposable
    {
        private SerialPort port;
        
        private volatile Queue<string> bufferQueue = new Queue<string>();

        private StringBuilder builder = new StringBuilder();

        private Thread consumerThread;

        // 委托，接收串口数据
        /// <summary>
        /// 异步接收数据，注意：该异步方式不可用于更新UI
        /// </summary>
        /// <param name="sender">发送者</param>
        /// <param name="bytes">需要接收的字节流</param>
        /// 
        public delegate void RecievedDataDelegate(object sender, byte[] bytes);

        ///// <summary>
        ///// 同步接收数据
        ///// </summary>
        ///// <param name="sender">发送者</param>
        ///// <param name="bytes">需要接收的字节流</param>
        //public delegate void SyncRecievedData(object sender, byte[] bytes);

        // 创建事件
        /// <summary>
        /// 正在接收数据
        /// </summary>
        public event RecievedDataDelegate RecievedData;

        private int unitBufferSize = 40;
        public int UnitBufferSize {
            get
            {
                return unitBufferSize;
            }
            set
            {
                unitBufferSize = value;
                if (null != port)
                {
                    port.ReceivedBytesThreshold = value;
                }
            }
        }

        ///// <summary>
        ///// 正在同步接收数据
        ///// </summary>
        //public event SyncRecievedData OnSyncRecievedData;

        /// <summary>
        /// 创建串口处理类
        /// </summary>
        /// <param name="config">根据配置文件创建</param>
        public SerializePortHandler(SerializePortConfig config)
        {
            // 初始化串口信息
            port = new SerialPort("COM" + config.Port, config.BaudRate, (Parity)config.Parity, config.BitLength, (StopBits)config.StopBitLength);
            port.ReadBufferSize = 4096;
            port.ReceivedBytesThreshold = 40;
            port.ReadTimeout = 3000;
            // 绑定串口事件
            port.DataReceived += SerialPortDataRecievedHandler;
            port.ErrorReceived += SerialPortErrorHandler;
            port.PinChanged += SerialPinChangedHandler;
        }
        // 处理串口非数据信号
        private void SerialPinChangedHandler(object sender, SerialPinChangedEventArgs e)
        {
        }
        // 处理串口错误
        private void SerialPortErrorHandler(object sender, SerialErrorReceivedEventArgs e)
        {
        }

        // 接收数据
        private void SerialPortDataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // 接收数据
            var size = port.BytesToRead;
            var buffer = new byte[size];
            port.Read(buffer, 0, size);

            var recieved = new Thread((tmpBuffer) =>
            {
                var str = Encoding.UTF8.GetString(tmpBuffer as byte[]);
                var splits = str.Split('\n');
                foreach (var split in splits)
                {
                    if (true == split?.Trim().ToUpper().StartsWith("ST") && true == split?.Trim().ToUpper().EndsWith("KG"))
                    {
                        bufferQueue.Enqueue(split);
                    }
                }
            });
            recieved.Start(buffer);
            // 丢弃当前缓冲
            port.DiscardInBuffer();

            // 开启线程进行
            if (null == consumerThread || !(consumerThread.ThreadState == ThreadState.Running))
            {
                consumerThread = new Thread(() =>
                {
                    while (0 < bufferQueue.Count)
                    {
                        var record = bufferQueue.Dequeue();
                        if (true == record?.Trim().ToUpper().EndsWith("KG"))
                        {
                            RecievedData?.Invoke(this, Encoding.UTF8.GetBytes(record));
                        }
                    }
                });
                consumerThread.Start();
            }
            
        }

        public void Dispose()
        {
            port?.Close();
            port.Dispose();
            consumerThread?.Abort();
        }

        /// <summary>
        /// 尝试打开串口
        /// </summary>
        /// <param name="err">用于接收在尝试打开串口时发生的错误信息</param>
        /// <returns>当前串口的打开状态, true为打开，false为关闭</returns>
        public bool TryToOpenSerialPort(ref string err)
        {
            try
            {
                // 当前已打开
                if (true == port?.IsOpen)
                {
                    return true;
                }
                
                // 检验串口是否存在
                var allPorts = SerialPort.GetPortNames();
                if (!allPorts.Contains(port.PortName))
                {
                    err = "当前指定的串口在该计算机中不存在，请检查对应的串口设备是否已经正确接入本计算机！";
                    return false;
                }

                port?.Open();

                // 无异常
                return true;
            }
            catch (Exception ex)
            {
                err = "发生错误：" + ex + "，位于：" + ex.StackTrace;
                return false;
            }
        }

        /// <summary>
        /// 尝试关闭串口
        /// </summary>
        /// <param name="err">用于接收在尝试关闭串口时发生的错误信息</param>
        /// <returns>当前串口的关闭状态,true为关闭，false为打开</returns>
        public bool TryToCloseSerialPort(ref string err)
        {
            // 已关闭
            if (false == port?.IsOpen)
            {
                return true;
            }

            try
            {
                port?.Close(); // 关闭串口
                return true;
            }
            catch (Exception ex)
            {
                err = "发生错误：" + ex + "，位于：" + ex.StackTrace;
                return false;
            }
        }

        public bool IsOpen
        {
            get { return port.IsOpen; }
        }

        ~SerializePortHandler()
        {
            Dispose();
            port = null;
        }
    }
}
