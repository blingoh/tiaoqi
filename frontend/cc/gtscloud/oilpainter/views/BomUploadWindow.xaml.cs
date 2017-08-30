using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using frontend.cc.gtscloud.oilpainter.util;
using MahApps.Metro.Controls;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// BomUploadWindow.xaml 的交互逻辑
    /// </summary>
    public partial class BomUploadWindow : MetroWindow
    {
        private BomUploadViewModel _viewModel;
        private SynchronizationContext _uiSync = SynchronizationContext.Current;

        bool uploading = false;
        public BomUploadViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                if (null != value)
                {
                    _viewModel = value;
                }
            }
        }
        public BomUploadWindow()
        {
            InitializeComponent();
            _viewModel = new BomUploadViewModel();
            gridBomUploadView.DataContext = ViewModel;
        }

        private void OnBomLoadButtonClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.DefaultExt = ".xls";
            openFileDlg.Filter = "Excel 2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx";
            openFileDlg.Multiselect = false;
            if (true == openFileDlg.ShowDialog(this))
            {
                string fileName = openFileDlg.FileName;
                ViewModel.BomFilePath = fileName;
                if (File.Exists(ViewModel.BomFilePath))
                {
                    Thread loadThread = new Thread(new ParameterizedThreadStart(LoadExcelEntry));
                    loadThread.Start(ViewModel.BomFilePath);
                }
                else
                {
                    MessageBox.Show("该文件不存在", "错误");
                    return;
                }
            }
        }

        // 线程入口，加载EXCEL
        private void LoadExcelEntry(object filename)
        {
            BomUploadItemModel.InitFieldMap();
            var map = BomUploadItemModel.FieldMap;
            ExcelHelper excelHelper = new ExcelHelper(filename as string);
            var dt = excelHelper.ExcelToDataTable("StandardFormat", true);
            if (null == dt)
            {
                _uiSync.Post(ParsedCallback, false);
                return;
            }
            var allRow = dt.Rows;
            foreach (DataRow row in allRow)
            {
                JObject json = new JObject();
                for (var i = 0; i < row.Table.Columns.Count; i++)
                {
                    json.Add(map[i], row[i].ToString());
                }
                _uiSync.Post(ParsedCallback, json);
            }
        }

        // 解析到项目后的回调
        private void ParsedCallback(object value)
        {
            if (value is JObject)
                ViewModel.Boms?.Add(JsonConvert.DeserializeObject<BomUploadItemModel>((value as JObject).ToString(Formatting.Indented)));
            else if (false == value as bool?)
            {
                MessageBox.Show("解析失败，请检查您的文件是否被占用，且格式是否正确", "解析错误");
            }
        }

        private void OnButtonUploadClicked(object sender, RoutedEventArgs e)
        {
            if (uploading)
            {
                MessageBox.Show("当前正在上传BOM，请勿重复操作！", "警告");
                return;
            }

            if (MessageBoxResult.OK == MessageBox.Show("您确定要上传所有的BOM到系统吗，这可能会造成您有重复的BOM清单，若你需要排查，请到参数设置->料号维护中进行相应的删除操作！", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question)) {

                uploading = true;

                Thread uploadThread = new Thread((items) =>
                {
                    var allBoms = items as ObservableCollection<BomUploadItemModel>;

                    var count = 0;

                    IBomInfoService service = new BomInfoServiceImpl();
                    foreach (var bom in allBoms)
                    {
                        var bomInfo = new BomInfoCompleteModel();

                        var bomBasic = new BomInfoModel();
                        bomBasic.BomId = Guid.NewGuid().ToString();
                        bomBasic.CustomerName = bom.Customer;
                        bomBasic.ProductName = bom.MachineType;
                        bomBasic.Supplier = bom.Supplier;
                        bomBasic.OilPlaintType = bom.Color;
                        bomBasic.GuHuaPercent = int.Parse(bom.GuhuaRate);
                        bomBasic.OilSpeedL = int.Parse(bom.OilSpeedLow);
                        bomBasic.OilSpeedU = int.Parse(bom.OilSpeedUp);
                        bomBasic.ValidHours = int.Parse(bom.ValidHours);
                        bomBasic.WBMS = int.Parse(bom.WBMS);
                        bomBasic.XiShiLowPercent = int.Parse(bom.XishiLow);
                        bomBasic.XiShiUpPercent = int.Parse(bom.XishiUp);

                        bomInfo.BomBasic = bomBasic;

                        // 添加剂料
                        if (null != bom.GuhuaOne && 
                            0 < bom.GuhuaOne.Trim().Length)
                        {
                            var guhua = new BomPartInformationModel();
                            guhua.BomId = bomBasic.BomId;
                            guhua.PartNumber = bom.GuhuaOne;
                            guhua.PartType = PartTypeConstant.GuHua;
                            bomInfo.GuHua.Add(guhua);
                        }
                        if (null != bom.GuhuaTwo &&
                            0 < bom.GuhuaTwo.Trim().Length)
                        {
                            var guhua = new BomPartInformationModel();
                            guhua.BomId = bomBasic.BomId;
                            guhua.PartNumber = bom.GuhuaTwo;
                            guhua.PartType = PartTypeConstant.GuHua;
                            bomInfo.GuHua.Add(guhua);
                        }
                        if (null != bom.GuhuaThree &&
                            0 < bom.GuhuaThree.Trim().Length)
                        {
                            var guhua = new BomPartInformationModel();
                            guhua.BomId = bomBasic.BomId;
                            guhua.PartNumber = bom.GuhuaThree;
                            guhua.PartType = PartTypeConstant.GuHua;
                            bomInfo.GuHua.Add(guhua);
                        }
                        if (null != bom.XishiOne &&
                            0 < bom.XishiOne.Trim().Length)
                        {
                            var xishi = new BomPartInformationModel();
                            xishi.BomId = bomBasic.BomId;
                            xishi.PartNumber = bom.XishiOne;
                            xishi.PartType = PartTypeConstant.XiShi;
                            bomInfo.XiShi.Add(xishi);
                        }
                        if (null != bom.XishiTwo &&
                            0 < bom.XishiTwo.Trim().Length)
                        {
                            var xishi = new BomPartInformationModel();
                            xishi.BomId = bomBasic.BomId;
                            xishi.PartNumber = bom.XishiTwo;
                            xishi.PartType = PartTypeConstant.XiShi;
                            bomInfo.XiShi.Add(xishi);
                        }
                        if (null != bom.XishiThree &&
                            0 < bom.XishiThree.Trim().Length)
                        {
                            var xishi = new BomPartInformationModel();
                            xishi.BomId = bomBasic.BomId;
                            xishi.PartNumber = bom.XishiThree;
                            xishi.PartType = PartTypeConstant.XiShi;
                            bomInfo.XiShi.Add(xishi);
                        }
                        if (null != bom.MainMeterialOne &&
                            0 < bom.MainMeterialOne.Trim().Length)
                        {
                            var main = new BomPartInformationModel();
                            main.BomId = bomBasic.BomId;
                            main.PartNumber = bom.MainMeterialOne;
                            main.PartType = PartTypeConstant.Main;
                            bomInfo.MainPart.Add(main);
                        }
                        if (null != bom.MainMeterialTwo &&
                            0 < bom.MainMeterialTwo.Trim().Length)
                        {
                            var main = new BomPartInformationModel();
                            main.BomId = bomBasic.BomId;
                            main.PartNumber = bom.MainMeterialTwo;
                            main.PartType = PartTypeConstant.Main;
                            bomInfo.MainPart.Add(main);
                        }
                        if (null != bom.MainMeterialThree &&
                            0 < bom.MainMeterialThree.Trim().Length)
                        {
                            var main = new BomPartInformationModel();
                            main.BomId = bomBasic.BomId;
                            main.PartNumber = bom.MainMeterialThree;
                            main.PartType = PartTypeConstant.Main;
                            bomInfo.MainPart.Add(main);
                        }

                        var err = service.AddBom(bomInfo);
                        if (null == err)
                        {
                            count++;
                        }
                    }
                    this.Invoke(() =>
                    {
                        MessageBox.Show("上传完成，共成功上传：" + count + "项", "结果");
                        uploading = false;
                    });
                });

                uploadThread.Start(ViewModel.Boms);
            }
            
        }
    }
}
