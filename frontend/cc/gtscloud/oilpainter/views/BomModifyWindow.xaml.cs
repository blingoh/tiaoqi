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
    /// BomModifyWindow.xaml 的交互逻辑
    /// </summary>
    public partial class BomModifyWindow : MetroWindow, INotifyPropertyChanged
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
        public BomModifyWindow()
        {
            InitializeComponent();

            DataContext = this;
            _uiSync = SynchronizationContext.Current;

            StartLoadCustomersThread();
            StartLoadOilTypeThread();
        }

        #region 业务操作

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

        // 开始添加一条分支信息线程
        private void StartAddPartThread(BomPartInformationModel part)
        {
            Thread partAddThread = new Thread(new ParameterizedThreadStart(AddPartProc));
            partAddThread.Start(part);
        }
        // 添加分支信息处理方法
        private void AddPartProc(object part)
        {
            var addPart = part as BomPartInformationModel;
            // 主剂
            if (PartTypeConstant.Main.Equals(addPart.PartType))
            {
                var err = bomService.AddBomMainPart(addPart);
                if (null == err)
                {
                    _uiSync.Post(PartAddedCallback, addPart);
                }
                else
                {
                    _uiSync.Post(PartAddedCallback, err);
                }
            }
            // 固化剂
            if (PartTypeConstant.GuHua.Equals(addPart.PartType))
            {
                var err = bomService.AddBomGuhuaPart(addPart);
                if (null == err)
                {
                    _uiSync.Post(PartAddedCallback, addPart);
                }
                else
                {
                    _uiSync.Post(PartAddedCallback, err);
                }
            }
            // 稀释剂
            if (PartTypeConstant.XiShi.Equals(addPart.PartType))
            {
                var err = bomService.AddBomXishiPart(addPart);
                if (null == err)
                {
                    _uiSync.Post(PartAddedCallback, addPart);
                }
                else
                {
                    _uiSync.Post(PartAddedCallback, err);
                }
            }
        }
        // 分支添加成功的回调
        private void PartAddedCallback(object value)
        {
            // 成功
            if (value is BomPartInformationModel)
            {
                var part = value as BomPartInformationModel;
                if (part.PartType.Equals(PartTypeConstant.Main))
                {
                    NewBomInfo.MainPart.Add(part);
                    cmbMainMaterial.SelectedItem = part;
                }
                if (part.PartType.Equals(PartTypeConstant.GuHua))
                {
                    NewBomInfo.GuHua.Add(part);
                    cmbGuhua.SelectedItem = part;
                }
                if (part.PartType.Equals(PartTypeConstant.XiShi))
                {
                    NewBomInfo.XiShi.Add(part);
                    cmbXishi.SelectedItem = part;
                }
            }

            // 失败
            if (value is string)
            {
                MessageBox.Show("增加料号失败：" + value as string, "错误");
            }
        }

        // 启动线程保存BOM
        private void StartSaveBomThread(BomInfoModel bom)
        {
            Thread saveThread = new Thread(new ParameterizedThreadStart(SaveBomProc));
            saveThread.Start(bom);
        }
        // BOM保存处理类
        private void SaveBomProc(object bom)
        {
            if (bom is BomInfoModel)
            {
                // 保存
                string err = bomService.ModifyBom(bom as BomInfoModel);
                _uiSync.Post(SavedCallaback, err);
            }
        }

        // 保存后的回调
        private void SavedCallaback(object value)
        {
            if (null == value)
            {
                // 保存成功
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("更新失败：" + value as string);
            }
        }

        // 开始删除分支信息的线程
        private void StartDeletePartThread(BomPartInformationModel part)
        {
            Thread delThread = new Thread(new ParameterizedThreadStart(DeletePartProc));
            delThread.Start(part);
        }
        
        // 删除分支的处理
        private void DeletePartProc(object part)
        {
            if (part is BomPartInformationModel)
            {
                var obj = (part as BomPartInformationModel);
                var err = bomService.RemovePart(obj.BomId, obj.PartNumber, obj.PartType);
                if (null == err)
                {
                    _uiSync.Post(DeletedPartCallback, obj);
                }
                else
                {
                    _uiSync.Post(DeletedPartCallback, err);
                }
            }
        }
        // 删除后的回调
        private void DeletedPartCallback(object value)
        {
            if (value is string)
            {
                MessageBox.Show("无法删除：" + value as string, "失败");
            }
            else if (value is BomPartInformationModel)
            {
                var part = value as BomPartInformationModel;
                // 从数据源中移除项
                if (PartTypeConstant.GuHua.Equals(part.PartType))
                {
                    NewBomInfo.GuHua.Remove(part);
                }
                else if (PartTypeConstant.Main.Equals(part.PartType))
                {
                    NewBomInfo.MainPart.Remove(part);
                }
                else if (PartTypeConstant.XiShi.Equals(part.PartType))
                {
                    NewBomInfo.XiShi.Remove(part);
                }
            }
        }
        #endregion

        private void OnSaveItemButtonClicked(object sender, RoutedEventArgs e)
        {
            StartSaveBomThread(NewBomInfo.BomBasic);
        }

        private void OnAddXishiButtonClicked(object sender, RoutedEventArgs e)
        {
            var xishiNum = cmbXishi.Text;
            BomPartInformationModel xishiPart = new BomPartInformationModel(); // 创建稀释剂
            xishiPart.PartNumber = xishiNum;
            xishiPart.BomId = NewBomInfo.BomBasic.BomId;
            xishiPart.PartType = PartTypeConstant.XiShi;

            StartAddPartThread(xishiPart); // 启动线程
        }

        private void OnDeleteXishiButtonClicked(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.OK == MessageBox.Show("即将删除：" + (cmbXishi.SelectedItem as BomPartInformationModel).PartNumber + ", 是否要继续？", "确认"))
            {
                StartDeletePartThread(cmbXishi.SelectedItem as BomPartInformationModel);
            }
        }

        private void OnAddGuhuaButtonClicked(object sender, RoutedEventArgs e)
        {
            var guhuaNum = cmbGuhua.Text;
            BomPartInformationModel guhuaPart = new BomPartInformationModel(); // 创建固化剂
            guhuaPart.PartNumber = guhuaNum;
            guhuaPart.PartType = PartTypeConstant.GuHua;
            guhuaPart.BomId = NewBomInfo.BomBasic.BomId;

            StartAddPartThread(guhuaPart);
        }

        private void OnDeleteGuhuaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.OK == MessageBox.Show("即将删除：" + (cmbGuhua.SelectedItem as BomPartInformationModel).PartNumber + ", 是否要继续？", "确认"))
            {
                StartDeletePartThread(cmbGuhua.SelectedItem as BomPartInformationModel);
            }
        }

        private void OnAddMainButtonClicked(object sender, RoutedEventArgs e)
        {
            var mainNum = cmbMainMaterial.Text;
            BomPartInformationModel mainPart = new BomPartInformationModel(); // 创建固化剂
            mainPart.PartNumber = mainNum;
            mainPart.PartType = PartTypeConstant.Main;
            mainPart.BomId = NewBomInfo.BomBasic.BomId;

            StartAddPartThread(mainPart);
        }

        private void OnDeleteMainButtonClicked(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.OK == MessageBox.Show("即将删除：" + (cmbMainMaterial.SelectedItem as BomPartInformationModel).PartNumber + ", 是否要继续？", "确认"))
            {
                StartDeletePartThread(cmbMainMaterial.SelectedItem as BomPartInformationModel);
            }
        }
    }
}
