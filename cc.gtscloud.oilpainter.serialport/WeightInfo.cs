using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cc.gtscloud.oilpainter.serialport
{
    /// <summary>
    /// 重量信息
    /// </summary>
    public class WeightInfo
    {
        /// <summary>
        /// 获取或设置重量
        /// </summary>
        public double Weight
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置单位
        /// </summary>
        public string Unit
        {
            get;set;
        }
    }
}
