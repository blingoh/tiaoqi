using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cc.gtscloud.oilpainter.serialport
{
    /// <summary>
    /// 常规的解析类
    /// </summary>
    public class GenerateParser : ISerialPortDataParser
    {
        public WeightInfo ParseRecord(string record)
        {
            var weightInfo = new WeightInfo();

            var splits = record.Split(',');
            // 取稳定信号
            var header = splits[0];
            if (header?.Trim().ToUpper() == "ST")
            {
                try
                {
                    var tmp = splits[2].Trim('\r', '\n').ToUpper();
                    // 抽取单位
                    if (tmp.EndsWith("KG"))
                    {
                        weightInfo.Unit = "KG";
                        tmp = tmp.Replace("KG", "");
                    }
                    else if (tmp.EndsWith("MG"))
                    {
                        weightInfo.Unit = "MG";
                        tmp = tmp.Replace("MG", "");
                    }
                    else if (tmp.EndsWith("G"))
                    {
                        weightInfo.Unit = "G";
                        tmp = tmp.Replace("G", "");
                    }
                    var weightValue = double.Parse(tmp);

                    weightInfo.Weight = weightValue;
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return weightInfo;
        }
    }
}
