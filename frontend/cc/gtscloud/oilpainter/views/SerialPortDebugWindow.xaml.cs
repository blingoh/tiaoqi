using cc.gtscloud.oilpainter.serialport;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO.Ports;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace frontend.cc.gtscloud.oilpainter.views
{
    /// <summary>
    /// SerialPortDebugWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SerialPortDebugWindow : MetroWindow, INotifyPropertyChanged
    {
        private IList<string> parities = new List<string>()
        {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"
        };

        private IList<int> baudRates = new List<int>()
        {
            300,
            600,
            1200,
            2400,
            4800,
            9600,
            19200,
            38400,
            57600,
            115200
        };

        private IList<int> dataBits = new List<int>()
        {
            5,
            6,
            7,
            8
        };

        private IList<decimal> stopBits = new List<decimal>()
        {
            0,
            1,
            2,
            new decimal(1.5)
        };

        private SerializePortHandler handler;

        /// <summary>
        /// 获取奇偶校验信息
        /// </summary>
        public IList<string> ParityList
        {
            get { return parities; }
        }

        /// <summary>
        /// 获取波特率
        /// </summary>
        public IList<int> BaudBits
        {
            get { return baudRates; }
        }

        /// <summary>
        /// 获取字节位长
        /// </summary>
        public IList<int> BitLen
        {
            get { return dataBits; }
        }

        /// <summary>
        /// 设置停止位
        /// </summary>
        public IList<decimal> StopBits
        {
            get
            {
                return stopBits;
            }
        }

        /// <summary>
        /// 串口配置
        /// </summary>
        public SerializePortConfig SerialPortConfig
        {
            get;
            set;
        }
        /// <summary>
        /// 获取或设置当前重量
        /// </summary>
        public string CurrentWeight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentWeight"));
            }
        }

        private string unit;
        private string weight;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 获取或设置当前单位
        /// </summary>
        public string Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Unit"));
            }
        }

        public ObservableCollection<string> DataRecords
        {
            get;
            set;
        }

        public SerialPortDebugWindow()
        {
            InitializeComponent();
            SerialPortConfig = new SerializePortConfig();
            DataRecords = new ObservableCollection<string>();
            DataContext = this;
        }

        private void OnStartDebugClicked(object sender, RoutedEventArgs e)
        {
            if (0 >= SerialPortConfig.StopBitLength)
            {
                MessageBox.Show("暂不支持Stop Bits为0", "非法");
                return;
            }

            if (null != handler)
            {
                handler.Dispose();
                handler = null;
            }

            handler = new SerializePortHandler(SerialPortConfig);
            // 绑定事件
            handler.RecievedData += (from, data) =>
            {
                this.Invoke(() =>
                {
                    var str = Encoding.UTF8.GetString(data);

                    DataRecords.Add("接收数据：" + str); // 添加日志

                    ISerialPortDataParser parser = new GenerateParser(); // 解析
                    var weightInfo = parser.ParseRecord(str);
                    CurrentWeight = weightInfo.Weight.ToString();
                    Unit = weightInfo.Unit;
                });
                Application.Current.Dispatcher.Invoke(DispatcherPriority.Background,
                                          new Action(delegate { }));
            };
            string err = null;
            var result = handler.TryToOpenSerialPort(ref err);
            if (!result)
            {
                MessageBox.Show(err, "串口打开失败");
            }
        }
        private void OnStopButtonClicked(object sender, RoutedEventArgs e)
        {
            string err = null;
            handler.TryToCloseSerialPort(ref err);
            if (null != err)
            {
                MessageBox.Show("关闭串口出现错误：" + err, "关闭错误");
            }
        }
    }
}
