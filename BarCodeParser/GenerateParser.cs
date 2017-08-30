using cc.gtscloud.BarCodeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarCodeParser
{
    public class GenerateParser : IBarCodeParser
    {
        public string ParseBatchNum(string barcode, string rule)
        {
            if (null == barcode || 
                49 > barcode.Trim().Length) // 过短编码，跳过
            {
                return null;
            }
            barcode = barcode.Trim();
            int start = 28;
            int len = 18;
            string code = barcode.Substring(start, len);
            return code.TrimStart('0').ToUpper();
        }

        public string ParseMainNum(string barcode, string rule)
        {
            if (null == barcode || 
                49 > barcode.Trim().Length) // 过短编码，跳过
            {
                return null;
            }
            barcode = barcode.Trim();
            int start = 2;
            int len = 20;
            string code = barcode.Substring(start, len);
            return code.TrimStart('0').ToUpper();
        }
    }
}
