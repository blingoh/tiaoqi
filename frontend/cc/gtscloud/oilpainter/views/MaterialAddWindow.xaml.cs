using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// MaterialAddWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MaterialAddWindow : MetroWindow, INotifyPropertyChanged
    {
        // 服务类
        private ICustomerService customerService = new CustomerServiceImpl();
        private IOilTypeService oilTypeService = new OilTypeServiceImpl();
        private IBomInfoService bomService = new BomInfoServiceImpl();
        SynchronizationContext _uiSync;

        public event PropertyChangedEventHandler PropertyChanged;

        private BomInfoCompleteModel newBomInfo;
        private ObservableCollection<CustomerModel> customers;
        private ObservableCollection<OilPaintTypeModel> oilPaintTypes;
        #region 属性
        /// <summary>
        /// 获取或设置新增的bom信息
        /// </summary>
        public BomInfoCompleteModel NewBomInfo
        {
            get
            {
                return newBomInfo;
            }
            set
            {
                newBomInfo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NewBomInfo"));
            }
        }
        /// <summary>
        /// 获取或设置客户列表
        /// </summary>
        public ObservableCollection<CustomerModel> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                customers = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Customers"));
            }
        }
        /// <summary>
        /// 获取或设置喷漆类型列表
        /// </summary>
        public ObservableCollection<OilPaintTypeModel> OilTypes
        {
            get
            {
                return oilPaintTypes;
            }
            set
            {
                oilPaintTypes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OilTypes"));
            }
        }
        #endregion
        #region 业务操作
        public MaterialAddWindow()
        {
            InitializeComponent();
            NewBomInfo = new BomInfoCompleteModel();
            DataContext = this;
            _uiSync = SynchronizationContext.Current;
            // 加载客户信息和喷漆类型信息
            StartLoadCustomersThread();
            StartLoadOilTypeThread();
        }
        
        // 开始加载客户线程
        private void StartLoadCustomersThread()
        {
            Thread loadThread = new Thread(new ThreadStart(LoadCustomerProc));
            loadThread.Start();
        }
        // 开始加载喷漆类型线程
        private void StartLoadOilTypeThread()
        {
            Thread loadThread = new Thread(new ThreadStart(LoadOilTypeProc));
            loadThread.Start();
        }
        // 加载后的回调
        private void LoadedCallback(object value)
        {
            if (value is IList<CustomerModel>)
            {
                Customers = new ObservableCollection<CustomerModel>(value as IList<CustomerModel>);
            }

            if (value is IList<OilPaintTypeModel>)
            {
                OilTypes = new ObservableCollection<OilPaintTypeModel>(value as IList<OilPaintTypeModel>);
            }
        }
        // 加载客户的处理
        private void LoadCustomerProc()
        {
            _uiSync.Post(LoadedCallback, customerService.FindAllCustomers());
        }
        // 加载喷漆类型的处理
        private void LoadOilTypeProc()
        {
            _uiSync.Post(LoadedCallback,
            oilTypeService.FindAllOilTypes());
        }
        // 启动增加bom线程
        private void StartAddBom()
        {
            Thread addThread = new Thread(new ParameterizedThreadStart(AddBomProc));
            addThread.Start(NewBomInfo);
        }
        private void AddBomProc(object bom)
        {
            string error = null;
            if (bom is BomInfoCompleteModel)
            {
                var bomInfo = bom as BomInfoCompleteModel;

                bomInfo.BomBasic.BomId = Guid.NewGuid().ToString();
                // 开始增加
                // 先增加基本信息，再添加分支信息，若添加失败则删除该记录
                var result = bomService.AddBom(bomInfo.BomBasic);
                error = result;
                // 添加分支信息
                if (null == error)
                {
                    foreach (var part in bomInfo.MainPart)
                    {
                        part.BomId = bomInfo.BomBasic.BomId;
                        var mainPartResult =
                            bomService.AddBomMainPart(part); // 插入主剂料
                        if (null != mainPartResult)
                        {
                            error = result;
                            break; // 发生错误
                        }
                    }
                    // 无错误
                    if (null == error)
                    {
                        foreach (var part in bomInfo.GuHua)
                        {
                            part.BomId = bomInfo.BomBasic.BomId;
                            var mainPartResult = bomService.AddBomGuhuaPart(part); // 插入主剂料
                            if (null != mainPartResult)
                            {
                                error = result;
                                break; // 发生错误
                            }
                        }
                    }
                    
                    // 无错误
                    if (null == error)
                    {
                        foreach (var part in bomInfo.XiShi)
                        {
                            part.BomId = bomInfo.BomBasic.BomId;
                            var mainPartResult = bomService.AddBomXishiPart(part); // 插入主剂料
                            if (null != mainPartResult)
                            {
                                error = result;
                                break; // 发生错误
                            }
                        }
                    }
                    
                }
                // 回滚操作
                if (null != error)
                {
                    bomService.RemoveBom(bomInfo.BomBasic.BomId);
                    foreach (var part in bomInfo.GuHua)
                    {
                        bomService.RemoveGuhuaPart(bomInfo.BomBasic.BomId, part.PartNumber);
                    }
                    foreach (var part in bomInfo.MainPart)
                    {
                        bomService.RemoveGuhuaPart(bomInfo.BomBasic.BomId, part.PartNumber);
                    }
                    foreach (var part in bomInfo.XiShi)
                    {
                        bomService.RemoveGuhuaPart(bomInfo.BomBasic.BomId, part.PartNumber);
                    }
                }

                // 通知主线程
                _uiSync.Post(AddBomCallback, error);
            }
        }
        private void AddBomCallback(object value)
        {
            if (null == value) // 无错误
            {
                DialogResult = true;
                Close();
            }
            else if (value is string)
            {
                MessageBox.Show("加入时发生错误：" + value, "增加错误");
            }
        }
        #endregion
        #region 事件响应
        // 添加稀释剂
        private void OnAddXishiButtonClicked(object sender, RoutedEventArgs e)
        {
            var xishiNum = cmbXishi.Text;
            BomPartInformationModel xishiPart = new BomPartInformationModel(); // 创建稀释剂
            xishiPart.PartNumber = xishiNum;
            xishiPart.PartType = PartTypeConstant.XiShi;
            NewBomInfo.XiShi.Add(xishiPart);  // 添加
            cmbXishi.SelectedItem = xishiPart;
        }
        // 添加固化剂
        private void OnAddGuhuaButtonClicked(object sender, RoutedEventArgs e)
        {
            var guhuaNum = cmbGuhua.Text;
            BomPartInformationModel guhuaPart = new BomPartInformationModel(); // 创建固化剂
            guhuaPart.PartNumber = guhuaNum;
            guhuaPart.PartType = PartTypeConstant.GuHua;
            NewBomInfo.GuHua.Add(guhuaPart);  // 添加
            cmbGuhua.SelectedItem = guhuaPart;
        }

        // 添加主剂料
        private void OnAddMainButtonClicked(object sender, RoutedEventArgs e)
        {
            var mainNum = cmbMainMaterial.Text;
            BomPartInformationModel mainPart = new BomPartInformationModel(); // 创建固化剂
            mainPart.PartNumber = mainNum;
            mainPart.PartType = PartTypeConstant.Main;
            NewBomInfo.MainPart.Add(mainPart);  // 添加
            cmbMainMaterial.SelectedItem = mainPart;
        }
        // 删除稀释剂
        private void OnDeleteXishiButtonClicked(object sender, RoutedEventArgs e)
        {
            NewBomInfo.XiShi.Remove(cmbXishi.SelectedItem as BomPartInformationModel);
        }
        // 删除固化
        private void OnDeleteGuhuaButtonClicked(object sender, RoutedEventArgs e)
        {
            NewBomInfo.GuHua.Remove(cmbGuhua.SelectedItem as BomPartInformationModel);
        }
        // 删除主剂料
        private void OnDeleteMainButtonClicked(object sender, RoutedEventArgs e)
        {
            NewBomInfo.MainPart.Remove(cmbMainMaterial.SelectedItem as BomPartInformationModel);
        }

        private void OnAddNewItemButtonClicked(object sender, RoutedEventArgs e)
        {
            // 检验约束
            if (NewBomInfo.BomBasic.OilSpeedL > NewBomInfo.BomBasic.OilSpeedU)
            {
                MessageBox.Show("油漆黏度上限不得高于下限，请检查", "约束错误");
                return;
            }
            if (NewBomInfo.BomBasic.XiShiLowPercent > NewBomInfo.BomBasic.XiShiUpPercent)
            {
                MessageBox.Show("稀释剂比例上限不得高于下限，请检查", "约束错误");
                return;
            }
            if (null == NewBomInfo.BomBasic.Supplier || 0 >= NewBomInfo.BomBasic.Supplier.Trim().Length)
            {
                MessageBox.Show("请指明BOM厂商", "约束错误");
                return;
            }
            if (null == NewBomInfo.BomBasic.CustomerName || 0 >= NewBomInfo.BomBasic.CustomerName.Trim().Length)
            {
                MessageBox.Show("请指明客户名", "约束错误");
                return;
            }
            if (null == NewBomInfo.BomBasic.ProductName || 0 >= NewBomInfo.BomBasic.ProductName.Trim().Length)
            {
                MessageBox.Show("请指明机种名/品名", "约束错误");
                return;
            }
            if (null == NewBomInfo.BomBasic.OilPlaintType || 0 >= NewBomInfo.BomBasic.OilPlaintType.Trim().Length)
            {
                MessageBox.Show("请指明喷漆类型", "约束错误");
                return;
            }
            if (0 >= NewBomInfo.BomBasic.OilSpeedU)
            {
                MessageBox.Show("油漆黏度上限不可为0", "约束错误");
                return;
            }
            if (0 >= NewBomInfo.BomBasic.XiShiUpPercent)
            {
                MessageBox.Show("稀释剂比例上限不可为0", "约束错误");
                return;
            }
            if (0 >= NewBomInfo.BomBasic.GuHuaPercent)
            {
                MessageBox.Show("固化剂比例不可为0", "约束错误");
                return;
            }

            // 开启线程插入数据
            StartAddBom();
        }
        #endregion
    }
}
