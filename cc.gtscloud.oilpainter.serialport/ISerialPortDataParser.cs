using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cc.gtscloud.oilpainter.serialport
{
    /// <summary>
    /// 提供一个解析接口，供扩展使用
    /// </summary>
    public interface ISerialPortDataParser
    {
        /// <summary>
        /// 根据串口数据解析出重量和单位
        /// </summary>
        /// <param name="record">记录信息</param>
        /// <returns>重量实体，包含重量值及单位</returns>
        WeightInfo ParseRecord(string record);
    }
}
