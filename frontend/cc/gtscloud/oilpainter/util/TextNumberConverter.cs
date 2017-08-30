using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace frontend.cc.gtscloud.oilpainter.util
{
    /// <summary>
    /// 值转换器，用于将数字转为字符串
    /// </summary>
    [ValueConversion(typeof(int), typeof(string))]
    class TextNumberConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType.Equals(typeof(object)))
            {
                return value.ToString();
            }
            else if (targetType.Equals(typeof(int)))
            {
                if (value is int)
                {
                    return value;
                }
                
            }
            throw new NotSupportedException("无法完成转换");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType.Equals(typeof(int)))
            {
                int num;
                bool success = int.TryParse((value as ComboBoxItem).Content as string, out num);
                if (!success)
                {
                    num = 0;
                    throw new Exception("无法完成转换");
                }

                return num;
            }
            
            if (targetType.Equals(typeof(string)))
            {
                return (value as ComboBoxItem).Content;
            }

            throw new NotSupportedException("不可转换的数据类型");
        }
    }
}
