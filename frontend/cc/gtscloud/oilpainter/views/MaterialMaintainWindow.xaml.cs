using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using MahApps.Metro.Controls;
using System;
using System.Collections;
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
    public partial class MaterialMaintainWindow : MetroWindow, INotifyPropertyChanged
    {
        private SynchronizationContext _uiSync;
        private static int delFailed = 0;

        // 服务类
        private IBomInfoService bomService = new BomInfoServiceImpl();
        private ICustomerService customerService = new CustomerServiceImpl();
        private IOilTypeService oilTypeService = new OilTypeServiceImpl();

        #region 属性

        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<BomInfoCompleteModel> allBoms;
        private ObservableCollection<CustomerModel> allCustomers;
        private ObservableCollection<OilPaintTypeModel> allOilTypes;

        /// <summary>
        /// 获取或设置所有的BOM列表
        /// </summary>
        public ObservableCollection<BomInfoCompleteModel> AllBoms
        {
            get { return allBoms; }
            set
            {
                allBoms = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AllBoms"));
            }
        }

        /// <summary>
        /// 获取或设置所有的客户
        /// </summary>
        public ObservableCollection<CustomerModel> AllCustomers
        {
            get
            {
                return allCustomers;
            }
            set
            {
                allCustomers = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AllCustomers"));
            }
        }

        /// <summary>
        /// 获取或设置所有的喷漆类型
        /// </summary>
        public ObservableCollection<OilPaintTypeModel> AllOilTypes
        {
            get
            {
                return allOilTypes;
            }
            set
            {
                allOilTypes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AllOilTypes"));
            }
        }

        #endregion

        public MaterialMaintainWindow()
        {
            InitializeComponent();

            _uiSync = SynchronizationContext.Current;
            gridParent.DataContext = this;

            StartLoadAllBoms();
            StartLoadAllCustomers();
        }


        #region 业务处理

        // 开始加载所有的客户
        private void StartLoadAllCustomers()
        {
            Thread customerLoadThread = new Thread(new ThreadStart(LoadAllCustomersProc));
            customerLoadThread.Start();
        }
        // 开始加载所有的BOM
        private void StartLoadAllBoms()
        {
            Thread customerLoadThread = new Thread(new ThreadStart(LoadAllBomsProc));
            customerLoadThread.Start();
        }
        // 开始加载所有的油漆类型
        private void StartLoadAllOilTypes()
        {
            Thread customerLoadThread = new Thread(new ThreadStart(LoadAllOilTypesProc));
            customerLoadThread.Start();
        }
        // 开始BOM删除线程
        private void StartDeleteBoms(IList boms)
        {
            delFailed = 0;
            Thread delThread = new Thread(new ParameterizedThreadStart(DeleteBomProc));
            delThread.Start(boms);
        }

        private void DeleteBomProc(object boms)
        {
            var bomList = (boms as IList);
            for (var i = 0; i < bomList?.Count; i++)
            {
                var bom = bomList[i] as BomInfoCompleteModel;
                // 转换成功
                if (null != bom)
                {
                    // 删除
                    string err = bomService.RemoveBom(bom.BomBasic.BomId);
                    if (null != err)
                    {
                        // 通知UI删除错误
                        _uiSync.Post(DeletedBomCallback, err);
                    }
                    else
                    {
                        _uiSync.Post(DeletedBomCallback, bom); // 删除成功，通知UI更新
                    }
                }
            }

            _uiSync.Post(DeletedBomCallback, bomList.Count as int?); // 删除完毕
        }

        private void DeletedBomCallback(object value)
        {
            if (value is string)
            {
                // 失败计数
                delFailed++;
            }
            else if (value is BomInfoCompleteModel)
            {
                // 删除成功，更新UI
                AllBoms.Remove(value as BomInfoCompleteModel);
            }
            else if (null != value as int?) // 结束
            {
                // 提示框提示
                MessageBox.Show("删除完毕，共删除：" + ((value as int?) - delFailed) + "项，其中失败：" + delFailed + "项");
                dtMaterialList.SelectedIndex = 0;
            }
        }
        // 加载所有的客户的处理
        private void LoadAllCustomersProc()
        {
            var allCustomers = customerService.FindAllCustomers();
            // 通知UI
            _uiSync.Post(LoadedCallback, new ObservableCollection<CustomerModel>(allCustomers));
        }
        // 加载所有BOM的处理
        private void LoadAllBomsProc()
        {
            var allBoms = bomService.FindAllBom();
            var allObservableBoms = new ObservableCollection<BomInfoCompleteModel>();
            foreach (var bom in allBoms)
            {
                var parts = bomService.FindAllBomParts(bom.BomId); // 所有分支信息
                BomInfoCompleteModel complete = new BomInfoCompleteModel(); //完整模型
                complete.BomBasic = bom;
                // 处理分支信息
                foreach (var part in parts)
                {
                    if (part.PartType.Equals(PartTypeConstant.Main)) // 添加主剂
                    {
                        complete.MainPart.Add(part);
                    }
                    else if (part.PartType.Equals(PartTypeConstant.GuHua)) // 添加固化剂
                    {
                        complete.GuHua.Add(part);
                    }
                    else if (part.PartType.Equals(PartTypeConstant.XiShi)) // 添加稀释剂
                    {
                        complete.XiShi.Add(part);
                    }
                }

                // 添加到集合
                allObservableBoms.Add(complete);
            }

            // 通知UI
            _uiSync.Post(LoadedCallback, allObservableBoms);
        }
        // 加载所有油漆类型的处理
        private void LoadAllOilTypesProc()
        {
            var allOilTypes = oilTypeService.FindAllOilTypes();
            // 通知UI
            _uiSync.Post(LoadedCallback, new ObservableCollection<OilPaintTypeModel>(allOilTypes));
        }
        // 加载后的回调
        private void LoadedCallback(object value)
        {
            // 更改属性
            if (value is ObservableCollection<BomInfoCompleteModel>)
            {
                // 对其排序
                var list = value as ObservableCollection<BomInfoCompleteModel>;
                var sortedBoms = from bom in list orderby bom.BomBasic.ProductName select bom;
                AllBoms = new ObservableCollection<BomInfoCompleteModel>(sortedBoms);
            }
            else if (value is ObservableCollection<CustomerModel>)
            {
                AllCustomers = value as ObservableCollection<CustomerModel>;
            }
            else if (value is ObservableCollection<OilPaintTypeModel>)
            {
                AllOilTypes = value as ObservableCollection<OilPaintTypeModel>;
            }

        }

        #endregion

        #region 事件处理
        // 点击增加按钮
        private void OnAddBomButtonClicked(object sender, RoutedEventArgs e)
        {
            MaterialAddWindow addWin = new MaterialAddWindow();
            addWin.Owner = this;
            if (true == addWin.ShowDialog())
            {
                var newItem = addWin.NewBomInfo;
                AllBoms.Add(newItem);

                // 使用LINQ按照品名排序
                var sortedBoms = from bom in AllBoms orderby bom.BomBasic.ProductName select bom;
                AllBoms = new ObservableCollection<BomInfoCompleteModel>(sortedBoms);
                // 选中新加项
                dtMaterialList.SelectedItem = newItem;
            }

        }
        // 点击修改按钮
        private void OnModifyBomButtonClicked(object sender, RoutedEventArgs e)
        {
            BomModifyWindow modifyWin = new BomModifyWindow();
            modifyWin.NewBomInfo = (dtMaterialList.SelectedItem as BomInfoCompleteModel).Clone() as BomInfoCompleteModel;
            modifyWin.Owner = this;
            if (true == modifyWin.ShowDialog())
            {
                // 保存成功后，窗口关闭，应该刷新数据
                var bom = modifyWin.NewBomInfo;
                AllBoms.Remove(dtMaterialList.SelectedItem as BomInfoCompleteModel);
                AllBoms.Add(bom);
                AllBoms = new ObservableCollection<BomInfoCompleteModel>(from tmp in AllBoms orderby tmp.BomBasic.ProductName select tmp);
                dtMaterialList.SelectedItem = bom;
            }
        }

        // 点击删除按钮
        private void OnDeleteBomButtonClicked(object sender, RoutedEventArgs e)
        {
            var delItems = dtMaterialList.SelectedItems;
            if (0 >= delItems?.Count)
            {
                MessageBox.Show("未指定要删除的项", "错误");
                return;
            }

            if (MessageBoxResult.OK == MessageBox.Show("是否要删除选中的：" + delItems.Count + "项？", "确认", MessageBoxButton.OKCancel, MessageBoxImage.Question))
            {
                // 确认删除
                StartDeleteBoms(delItems);
            }
        }

        #endregion
    }
}
