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
    /// DataQueryWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DataQueryWindow : MetroWindow, INotifyPropertyChanged
    {
        private ObservableCollection<BomQueryModel> bomQueryResult = new ObservableCollection<BomQueryModel>();
        private IBomInfoService bomInfoService = new BomInfoServiceImpl();
        private SynchronizationContext _uiSync;
        private ICustomerService customerService = new CustomerServiceImpl();
        private IOilTypeService oilTypeService = new OilTypeServiceImpl();

        public event PropertyChangedEventHandler PropertyChanged;

        private BomQueryModel queryModel = new BomQueryModel();
        private BomQueryModel selectedModel = new BomQueryModel();
        public BomQueryModel QueryBomModel
        {
            get { return queryModel; }
            set
            {
                queryModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QueryBomModel"));
            }
        }

        public BomQueryModel SelectedBomModel
        {
            get { return selectedModel; }
            set
            {
                selectedModel = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QueryBomModel"));
            }
        }

        public DataQueryWindow()
        {
            InitializeComponent();
            // 设置同步上下文
            _uiSync = SynchronizationContext.Current;
            //gridQueryResult.DataContext = bomQueryResult;

            QueryBomModel = new BomQueryModel();
            gridSearch.DataContext = QueryBomModel;

            SelectedBomModel = new BomQueryModel();

            StartLoadThread();
            StartLoadCustomerAndOilTypesThread();
        }

        // 开始线程加载
        private void StartLoadThread()
        {
            Thread loadThread = new Thread(new ParameterizedThreadStart(LoadDataInDb));
            
            loadThread.Start(QueryBomModel);
        }
        // 加载用户线程
        private void StartLoadCustomerAndOilTypesThread()
        {
            Thread loadThread = new Thread(new ThreadStart(LoadCustomersAndOilTypes));

            loadThread.Start();
        }

        // 加载数据
        private void LoadDataInDb(object param)
        {
            if (param is BomQueryModel)
            {
                var queryParam = param as BomQueryModel;
                var result = bomInfoService.FindBomsWithParam(queryParam);
                _uiSync.Post(LoadedCallback, result);
            }
            
        }
        // 加载用户
        private void LoadCustomersAndOilTypes()
        {
            var customers = customerService.FindAllCustomers();
            _uiSync.Post(LoadedCallback, customers);
            var oilTypes = oilTypeService.FindAllOilTypes();
            _uiSync.Post(LoadedCallback, oilTypes);
        }
        // 数据加载后的回调
        private void LoadedCallback(object value)
        {
            if (null == value)
            {
                bomQueryResult.Clear();
                return;
            }

            if (value is IList<BomQueryModel>)
            {
                gridQueryResult.DataContext = new ObservableCollection<BomQueryModel>(value as IList<BomQueryModel>);
            }

            if (value is IList<CustomerModel>)
            {
                (value as IList<CustomerModel>).Insert(0, new CustomerModel());
                cmbCustomers.DataContext = value;
            }

            if (value is IList<OilPaintTypeModel>)
            {
                (value as IList<OilPaintTypeModel>).Insert(0, new OilPaintTypeModel());
                cmbOilTypes.DataContext = value;
            }
        }

        private void OnButtonQueryClicked(object sender, RoutedEventArgs e)
        {
            StartLoadThread();
        }

        private void OnDatagridCellDoubleClicked(object sender, MouseButtonEventArgs e)
        {
            DialogResult = true;
            SelectedBomModel = gridQueryResult.SelectedItem as BomQueryModel;
            this.Close();
        }
    }
}
