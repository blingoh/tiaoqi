using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace frontend.cc.gtscloud.oilpainter.views
{
    /// <summary>
    /// ColumnPage.xaml 的交互逻辑
    /// </summary>
    public partial class ColumnPage : Page
    {
        public ColumnPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 变形的事件
        /// </summary>
        public static readonly RoutedEvent GrowEvent = EventManager.RegisterRoutedEvent(
        "Grow", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ColumnPage));

        /// <summary>
        /// 变形的处理
        /// </summary>
        public event RoutedEventHandler Grow
        {
            add { AddHandler(GrowEvent, value); }
            remove { RemoveHandler(GrowEvent, value); }
        }

        // 事件冒泡
        void RaiseTapEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(ColumnPage.GrowEvent);
            RaiseEvent(newEventArgs);
        }

        /// <summary>
        /// 通知变形
        /// </summary>
        public void NotifyGrow()
        {
            RaiseTapEvent();
        }
    }
}
