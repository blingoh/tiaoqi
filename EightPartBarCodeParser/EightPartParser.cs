using cc.gtscloud.BarCodeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cc.gtscloud.EightPartBarCodeParser
{
    public class EightPartParser : IBarCodeParser
    {
        public string ParseBatchNum(string barcode, string rule)
        {
            var parts = barcode.Split('-');
            var batchNum = parts[4].TrimStart('0') + "-" + parts[5].TrimStart('0');
            return batchNum.ToUpper();
        }

        public string ParseMainNum(string barcode, string rule)
        {
            var parts = barcode.Split('-');
            var mainNum = parts[1];
            if (10 < mainNum.Length)
            {
                mainNum = mainNum.Substring(mainNum.Length - 10);
            }
            return mainNum.ToUpper();
        }
    }
}
