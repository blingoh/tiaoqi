using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.config
{
    /// <summary>
    /// 电子秤串口配置实体
    /// </summary>
    class BalanceSerialConfigModel
    {
        /// <summary>
        /// 获取或设置串口号
        /// </summary>
        public int PortNumber
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置波特率
        /// </summary>
        public int BaudRate
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置相等数
        /// </summary>
        public int Parity
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置数据率
        /// </summary>
        public int DataBits
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置停止率
        /// </summary>
        public int StopBits
        {
            get;set;
        }
    }
}
