using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace frontend.cc.gtscloud.oilpainter.util
{
    /// <summary>
    /// 转换器，将布尔转为可见枚举
    /// </summary>
    [ValueConversion(typeof(bool), typeof(System.Windows.Visibility))]
    public class BoolVisiablityConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(System.Windows.Visibility))
            {
                if (value is bool)
                {
                    if (true == value as bool?)
                    {
                        return System.Windows.Visibility.Visible;
                    }
                    else
                    {
                        return System.Windows.Visibility.Hidden;
                    }
                }
            }
            return System.Windows.Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
