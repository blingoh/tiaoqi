using frontend.cc.gtscloud.oilpainter.models;
using frontend.config;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// PrintDebugWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PrintDebugWindow : MetroWindow
    {
        private PrinterDebugModel debugModel;
        private PrinterRecordModel printRecord;
        public PrintDebugWindow()
        {
            InitializeComponent();

            debugModel = new PrinterDebugModel();
            printRecord = new PrinterRecordModel();
            printRecord.BasicModel = debugModel;
            gridRoot.DataContext = debugModel;
        }

        private void OnTestButtonClicked(object sender, RoutedEventArgs e)
        {
            SingtonConfigContent.Instance().LastPrintRecord.BasicModel = debugModel;

            if (Owner is MainWindow)
            {
                var logined = (Owner as MainWindow).LoginedUser.UserName;
                SingtonConfigContent.Instance().LastPrintRecord.Operator = printRecord.Operator = logined;
            }

            if (CheckConfig()) // 检查配置并打印
            {
                StartPrint();
            }

        }

        // 检查配置
        private bool CheckConfig()
        {
            var printerConfig = SingtonConfigContent.Instance().Printer;
            // 调用响应的数据
            if (null == printerConfig.PrinterName ||
                0 >= printerConfig.PrinterName.Trim().Length)
            {
                MessageBox.Show("未配置打印机名，请前往\"文件->参数设置\"，进行配置！", "参数错误");
                return false;
            }

            if (null == printerConfig.LabelTemplatPath ||
                0 >= printerConfig.LabelTemplatPath.Trim().Length)
            {
                MessageBox.Show("未配置标签模板，请前往\"文件->参数设置\"，进行配置！", "参数错误");
                return false;
            }

            if (!File.Exists(printerConfig.LabelTemplatPath.Trim()))
            {
                MessageBox.Show("已配置标签模板，但未找到对应模板文件，请前往\"文件->参数设置\"，进行配置！", "参数错误");
                return false;
            }
            return true;
        }

        // 开始打印
        private void StartPrint()
        {
            var printerConfig = SingtonConfigContent.Instance().Printer;
            var printInterface = new LabelPrintCSharp.clsLabelPrint();
            printInterface.LabelPath = printerConfig.LabelTemplatPath;
            printInterface.PrintPath = printerConfig.PrinterName;
            printInterface.ClearVariableItems();
            printInterface.AddNewItem("Line", printRecord.BasicModel.LineType);
            printInterface.AddNewItem("YuanYouPartNumber", printRecord.BasicModel.OilMaterialNum);
            printInterface.AddNewItem("GuHuaPartNumber", printRecord.BasicModel.GuhuaMaterialNu);
            printInterface.AddNewItem("XiShiPartNumber", printRecord.BasicModel.XishiMaterialNum);
            printInterface.AddNewItem("Speed", printRecord.BasicModel.OilSeconds.ToString());
            printInterface.AddNewItem("PartNumber", printRecord.BasicModel.MachineType);

            printInterface.AddNewItem("Operator", printRecord.Operator);
            printInterface.AddNewItem("TiaoQiDT", printRecord.PrintDate);
            printInterface.AddNewItem("YouXiaoDT", printRecord.DeadDate);

            SingtonConfigContent.Instance().LastPrintRecord = printRecord;

            var result = printInterface.PrintLabel();
            if (result)
            {
                SingtonConfigContent.Instance().WriteCurrentConfig();
            }
        }

        // 打印上一次的按钮点击事件
        private void OnPrintLastButtonClicked(object sender, RoutedEventArgs e)
        {
            printRecord = SingtonConfigContent.Instance().LastPrintRecord;
            
            if (CheckConfig()) // 检查配置并打印
            {
                StartPrint();
            }
        }
    }
}
