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
    /// ProductLineMaintainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ProductLineMaintainWindow : MetroWindow
    {
        private SynchronizationContext _uiSyncContext = null;
        private IProductLineService productLineService = new ProductLineServiceImpl();
        public ProductLineMaintainWindow()
        {
            InitializeComponent();
            _uiSyncContext = SynchronizationContext.Current;

            StartLoadProductLine();
        }

        // 加载所有产线
        private void StartLoadProductLine()
        {
            Thread loadThread = new Thread(LoadProductLineThreadEntry);

            loadThread.Start();
        }

        // 加载所有产线的入口
        private void LoadProductLineThreadEntry()
        {
            IList<ProductLineModel> lines = productLineService.FindAllProductLines();
            _uiSyncContext.Post(ProductLineLoadedCallback, lines);
        }

        // 产线加载成功后的回调
        private void ProductLineLoadedCallback(object value)
        {
            if (value is IList<ProductLineModel>)
            {
                var productLines = value as IList<ProductLineModel>;
                var curIndex = cmbProductLineNumber.SelectedIndex;
                cmbProductLineNumber.DataContext = new ObservableCollection<ProductLineModel>(productLines);
                if (0 > curIndex) // 初始状态
                {
                    cmbProductLineNumber.SelectedIndex = 0;
                }
                else
                {
                    cmbProductLineNumber.SelectedIndex = curIndex;
                }
            }
        }

        // 修改按钮单击事件
        private void OnButtonModifyClicked(object sender, RoutedEventArgs e)
        {
            Button self = sender as Button;
            if ("修改".Equals(self.Content))
            {
                txtProductLineName.IsReadOnly = false;
                (sender as Button).Content = "保存";
                btnDelete.Content = "取消";
            }
            else if ("保存".Equals(self.Content))
            {
                txtProductLineName.IsReadOnly = true;
                (sender as Button).Content = "修改";
                ProductLineModel selectedLine = cmbProductLineNumber.SelectedItem as ProductLineModel;
                selectedLine.LineName = txtProductLineName.Text;
                StartUpdateThread(selectedLine);
            }
        }

        // 开启线程更新
        private void StartUpdateThread(ProductLineModel productLine)
        {
            Thread updateThread = new Thread(new ParameterizedThreadStart(UpdateProductLineEntry));
            updateThread.Start(productLine);
        }
        
        // 线程入口更新
        private void UpdateProductLineEntry(object productLine)
        {
            string tip = productLineService.UpdateProductLine(productLine as ProductLineModel);
            if (null == tip) // 更新成功
            {
                _uiSyncContext.Post(UpdatedCallback, true);
            }
            else
            {
                // 更新失败
                _uiSyncContext.Post(UpdatedCallback, tip);
            }
        }

        // 更新后的回调
        private void UpdatedCallback(object success)
        {
            if (success is string)
            {
                MessageBox.Show(success as string, "更新失败");
            }
            else if (success is bool?)
            {
                if (true == (success as bool?))
                {
                    MessageBox.Show("更新成功", "提示");
                    btnDelete.IsEnabled = true;
                    btnModifySave.IsEnabled = true;
                    StartLoadProductLine();
                }
            }
        }

        // 重置按妞
        private void ResetButtons()
        {
            cmbProductLineNumber.IsEditable = false;
            txtProductLineName.IsReadOnly = true;
            btnAddSave.Content = "增加";
            btnAddSave.IsEnabled = true;
            btnDelete.Content = "删除";
            btnDelete.IsEnabled = true;
            btnModifySave.Content = "修改";
            btnModifySave.IsEnabled = true;
        }

        // 删除按钮被点击事件
        private void OnButtonDeleteClicked(object sender, RoutedEventArgs e)
        {
            if ("取消".Equals((sender as Button).Content))
            {
                ResetButtons();
                StartLoadProductLine();
                return;
            }

            var line = cmbProductLineNumber.SelectedItem;
            string msg = JsonConvert.SerializeObject(line);
            if (MessageBox.Show("是否要删除产线：" + msg, "删除确认", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                StartDeleteThread(line as ProductLineModel);
            }
        }

        // 开启产线删除线程
        private void StartDeleteThread(ProductLineModel productLine)
        {
            Thread delThread = new Thread(new ParameterizedThreadStart(DeleteLineThreadEntry));
            delThread.Start(productLine);
        }

        // 删除进程入口
        private void DeleteLineThreadEntry(object delObj)
        {
            string result = productLineService.DeleteProductLine((delObj as ProductLineModel).LineCode);
            
            _uiSyncContext.Post(DeletedCallback, result);
        }
        // 删除回调
        private void DeletedCallback(object value)
        {
            if (null == value)
            {
                MessageBox.Show("删除成功", "提示");
                StartLoadProductLine();
            }
            else
            {
                MessageBox.Show("删除失败：" + value, "失败");
            }
        }

        // 新增按钮被点击事件
        private void OnButtonAddClicked(object sender, RoutedEventArgs e)
        {
            string addTitle = "增加";
            string saveTitle = "保存";
            Button self = sender as Button;
            if (addTitle.Equals(self.Content))
            {
                // 开启编辑模式
                cmbProductLineNumber.IsEditable = true;
                txtProductLineName.IsReadOnly = false;
                // 禁用按钮
                btnModifySave.IsEnabled = false;
                btnDelete.Content = "取消";
                self.Content = saveTitle;
            }
            else if (saveTitle.Equals(self.Content))
            {
                cmbProductLineNumber.IsEditable = false;
                txtProductLineName.IsReadOnly = true;
                btnAddSave.IsEnabled = false;
                var context = (cmbProductLineNumber.DataContext as IList<ProductLineModel>);
                var line = new ProductLineModel();
                line.LineCode = cmbProductLineNumber.Text;
                line.LineName = txtProductLineName.Text;
                context.Add(line);
                cmbProductLineNumber.DataContext = context;
                cmbProductLineNumber.SelectedItem = line;
                // 开启线程增加
                StartAddLineThread(cmbProductLineNumber.SelectedItem as ProductLineModel);
                self.Content = addTitle;
            }
        }

        private void StartAddLineThread(ProductLineModel line)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(AddLineThreadEntry));
            
            thread.Start(line);
        }

        private void AddLineThreadEntry(object lineObj)
        {
            string tip = productLineService.AddProductLine(lineObj as ProductLineModel);
            _uiSyncContext.Post(AddLineCallback, tip);
        }

        private void AddLineCallback(object value)
        {
            if (null != value)
            {
                MessageBox.Show("添加失败：" + value, "失败");
                var context = cmbProductLineNumber.DataContext as IList<ProductLineModel>;
                context.Remove(cmbProductLineNumber.SelectedItem as ProductLineModel);
            }
            else
            {
                ResetButtons();
            }
        }
    }
}
