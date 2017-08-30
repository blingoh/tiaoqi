using frontend.cc.gtscloud.oilpainter.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;

namespace frontend.cc.gtscloud.oilpainter.util
{
    /// <summary>
    /// 状态布尔转换
    /// </summary>
    [ValueConversion(typeof(ITaskState), typeof(bool))]
    public class StateBooleanConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ITaskState)
            {
                var state = (value as ITaskState);
                var targetState = (ITaskState.TaskStateEnum)(int.Parse(parameter as string));
                switch (targetState)
                {
                    case ITaskState.TaskStateEnum.MainMaterialState:
                        return state is MainMaterialState;
                    case ITaskState.TaskStateEnum.GuhuaMaterialState:
                        return state is GuhuaMaterialState;
                    case ITaskState.TaskStateEnum.XishiMaterialState:
                        return state is XishiMaterialState;
                    case ITaskState.TaskStateEnum.MixState:
                        return state is MixState;
                    default:
                        return false;
                }
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
