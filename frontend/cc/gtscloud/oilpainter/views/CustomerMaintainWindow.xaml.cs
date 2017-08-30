using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using MahApps.Metro.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// CustomerMaintainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CustomerMaintainWindow : MetroWindow
    {
        private ICustomerService customerService = new CustomerServiceImpl();
        private SynchronizationContext _uiSyncContext;// UI同步环境上下文
        public CustomerMaintainWindow()
        {
            InitializeComponent();
            _uiSyncContext = SynchronizationContext.Current;
            StartCustomerLoadThread();
        }

        // 开启线程进行客户加载
        private void StartCustomerLoadThread()
        {
            Thread loadCustomerThread = new Thread(new ThreadStart(LoadCustomersEntry));
            loadCustomerThread.Start();
        }

        // 客户加载线程入口
        private void LoadCustomersEntry()
        {
            var all = customerService.FindAllCustomers();
            _uiSyncContext.Post(LoadedCallback, all);
        }

        private void LoadedCallback(object values) // 加载完成后的回调
        {
            if (values is IList<CustomerModel>)
            {
                cmbCustomers.DataContext = new ObservableCollection<CustomerModel>(values as IList<CustomerModel>);
                cmbCustomers.SelectedIndex = 0;
            }
        }
        // 增加客户
        private void OnAddCustomerClicked(object sender, RoutedEventArgs e)
        {
            CustomerAdd addWin = new CustomerAdd();
            addWin.Owner = this;
            addWin.ShowDialog();
            if (true == addWin.DialogResult)
            {
                StartAddCustomerThread(addWin.Customer); // 添加客户
            }
        }
        // 开启添加客户的线程
        private void StartAddCustomerThread(CustomerModel customer)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(AddCustomerEntry));
            thread.Start(customer);
        }

        // 添加客户入口
        private void AddCustomerEntry(object customer)
        {
            string result = customerService.AddCustomer(customer as CustomerModel); // 添加并处理错误
            
            if (null == result)
            {
                _uiSyncContext.Post(AddCallback, customer); // 无错误
            }
            else
            {
                _uiSyncContext.Post(AddCallback, result); // 失败
            }
        }
        // 客户添加回调
        private void AddCallback(object value)
        {
            if (value is CustomerModel)
            {
                // 添加到列表
                if (null != cmbCustomers.DataContext)
                {
                    var context = cmbCustomers.DataContext as ObservableCollection<CustomerModel>;
                    context.Add(value as CustomerModel);
                    cmbCustomers.SelectedItem = value;
                }
            }
            else if (value is string)
            {
                MessageBox.Show(value as string, "添加错误");
            }
        }

        // 删除客户点击
        private void OnButtomDeleteCustomerClicked(object sender, RoutedEventArgs e)
        {
            if (MessageBoxResult.OK == MessageBox.Show("是否要删除该客户：" + JsonConvert.SerializeObject(cmbCustomers.SelectedItem), "删除确认", MessageBoxButton.OKCancel, MessageBoxImage.Question))
            {
                StartDeleteCustomer(cmbCustomers.SelectedItem as CustomerModel);
            }
        }

        // 启动删除客户线程
        private void StartDeleteCustomer(CustomerModel customer)
        {
            Thread delThread = new Thread(new ParameterizedThreadStart(DeleteCustomerEntry));
            delThread.Start(customer); // 开启线程
        }
        // 删除线程入口
        private void DeleteCustomerEntry(object customer)
        {
            string result = customerService.RemoveCustomer((customer as CustomerModel).CustomerCode); // 删除并获取结果
            if (null == result)
            {
                _uiSyncContext.Post(DeletedCallback, customer); // 删除成功
            }
            else
            {
                _uiSyncContext.Post(DeletedCallback, result);
            }
        }
        // 删除线程回调
        private void DeletedCallback(object value)
        {
            if (value is CustomerModel)
            {
                if (null != cmbCustomers.DataContext)
                {
                    var context = cmbCustomers.DataContext as ObservableCollection<CustomerModel>;
                    context.Remove(value as CustomerModel);
                    cmbCustomers.SelectedIndex = 0;
                }
            }
            else if (value is string)
            {
                MessageBox.Show(value as string, "删除失败");
            }
        }
    }
}
