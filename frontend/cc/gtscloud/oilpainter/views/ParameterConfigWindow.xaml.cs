using frontend.config;
using MahApps.Metro.Controls;
using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace frontend.cc.gtscloud.oilpainter.views
{   
    /// <summary>
    /// ParameterConfigWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ParameterConfigWindow : MetroWindow
    {
        private IList<int> baudRateList = new List<int>(10);
        private IList<string> parityList = new List<string>(5);
        private IList<int> dataBitsList = new List<int>(4);
        private IList<int> stopBitsList = new List<int>(2);

        public ParameterConfigWindow()
        {
            InitializeComponent();

            gridAll.DataContext = SingtonConfigContent.Instance();
            for (var i = 0; i < 10; i++)
            {
                baudRateList.Add(300 * (int)Math.Pow(2, i));
            }
            for (var i = 0; i < 4; i++)
            {
                dataBitsList.Add(5 + i);
            }
            for (var i = 0; i < 2; i++)
            {
                stopBitsList.Add(1 + i);
            }
            parityList.Add("None");
            parityList.Add("Odd");
            parityList.Add("Even");
            parityList.Add("Mark");
            parityList.Add("Space");

            cmbBasicBaudRate.ItemsSource = baudRateList;
            cmbBasicDataBits.ItemsSource = dataBitsList;
            cmbBasicParity.ItemsSource = parityList;
            cmbBasicStopBits.ItemsSource = stopBitsList;

            cmbGuhuaBaudRate.ItemsSource = baudRateList;
            cmbGuhuaDataBits.ItemsSource = dataBitsList;
            cmbGuhuaParity.ItemsSource = parityList;
            cmbGuhuaStopBits.ItemsSource = stopBitsList;

            cmbXishiBaudRate.ItemsSource = baudRateList;
            cmbXishiDataBits.ItemsSource = dataBitsList;
            cmbXishiParity.ItemsSource = parityList;
            cmbXishiStopBits.ItemsSource = stopBitsList;
        }
        // 保存按钮
        private void OnButtonSaveClicked(object sender, RoutedEventArgs e)
        {
            var obj = SingtonConfigContent.Instance();
            Console.WriteLine(obj);
        }

        // 窗口关闭
        private void OnConfigWinClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SingtonConfigContent.Instance().WriteCurrentConfig();// 保存当前配置
        }

        // 浏览加载打印机模板
        private void OnLoadPrinterTemplateClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.DefaultExt = ".btw";
            openFileDlg.Filter = "Bar Code Template File(.btw)|*.btw";
            openFileDlg.Multiselect = false;
            if (true == openFileDlg.ShowDialog(this))
            {
                string fileName = openFileDlg.FileName;
                SingtonConfigContent.Instance().Printer.LabelTemplatPath = fileName;
            }
        }
    }
}
