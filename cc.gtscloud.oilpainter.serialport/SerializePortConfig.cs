using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cc.gtscloud.oilpainter.serialport
{
    /// <summary>
    /// 串口设置类
    /// </summary>
    public class SerializePortConfig
    {
        private int port = 1; // 默认为1
        private int baudRate = 300; // 串口波特率，默认为300
        private int bitLen = 5; // 单个字节的位数，默认为4
        private int parity = 0; // 奇偶校验填充位，默认不填充
        private int stopBitLen = 1; // 字节停止长度，默认为1
        /// <summary>
        /// 获取或设置串口号，默认使用COM1
        /// </summary>
        public int Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
            }
        }

        /// <summary>
        /// 获取或设置串口波特率，默认为300
        /// </summary>
        public int BaudRate
        {
            get
            {
                return baudRate;
            }
            set
            {
                baudRate = value;
            }
        }
        
        /// <summary>
        /// 获取或设置单个字节的bit位长度，默认使用5bit/Byte
        /// </summary>
        public int BitLength
        {
            get
            {
                return bitLen;
            }
            set
            {
                bitLen = value;
            }
        }

        /// <summary>
        /// 获取或设置奇偶校验检查协议，默认使用0表示没有奇偶校验检查，see also:
        /// <seealso cref="System.IO.Ports.SerialPort.Parity"/>
        /// </summary>
        public int Parity
        {
            get
            {
                return parity;
            }
            set
            {
                parity = value;
            }
        }

        /// <summary>
        /// 获取或设置串口停止位长度，默认为1
        /// </summary>
        public int StopBitLength
        {
            get
            {
                return stopBitLen;
            }
            set
            {
                stopBitLen = value;
            }
        }
    }
}
