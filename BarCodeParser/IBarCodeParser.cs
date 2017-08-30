using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cc.gtscloud.BarCodeParser
{
    public interface IBarCodeParser
    {
        /// <summary>
        /// 解析主剂料号
        /// </summary>
        /// <param name="barcode">条码内容</param>
        /// <returns>主剂料号</returns>
        string ParseMainNum(string barcode, string rule);

        /// <summary>
        /// 解析批次号
        /// </summary>
        /// <param name="barcode">条码内容</param>
        /// <returns>批次号</returns>
        string ParseBatchNum(string barcode, string rule);
    }
}
