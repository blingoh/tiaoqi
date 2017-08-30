using cc.gtscloud.BarCodeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarCodeParser
{
    public class RuledParser : IBarCodeParser
    {
        public string ParseBatchNum(string barcode, string rule)
        {
            if (null == barcode ||
                   49 > barcode.Trim().Length) // 过短编码，跳过
            {
                return null;
            }
            barcode = barcode.Trim();
            var pos = rule.Split(',');
            var chs = barcode.ToCharArray();
            StringBuilder builder = new StringBuilder();
            foreach (var p in pos)
            {
                builder.Append("" + chs[int.Parse(p)]);
            }
            return builder.ToString().ToUpper().TrimStart('0');
        }

        public string ParseMainNum(string barcode, string rule)
        {
            if (null == barcode ||
                   49 > barcode.Trim().Length) // 过短编码，跳过
            {
                return null;
            }
            barcode = barcode.Trim();
            var pos = rule.Split(',');
            var chs = barcode.ToCharArray();
            StringBuilder builder = new StringBuilder();
            foreach (var p in pos)
            {
                builder.Append("" + chs[int.Parse(p)]);
            }
            return builder.ToString().ToUpper().TrimStart('0');
        }
    }
}
