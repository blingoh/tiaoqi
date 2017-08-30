using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using frontend.cc.gtscloud.oilpainter.util;
using MahApps.Metro.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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
    /// DataAnalyzeWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DataAnalyzeWindow : MetroWindow, INotifyPropertyChanged, IObserver<ColumnHeaderModel>, IDisposable
    {
        private ITaskService taskService = new TaskServiceImpl();
        private ColumnHeaderModel showColumns;
        private IList<string> workTimes = new List<string>()
        {
            "",
            "早班",
            "中班",
            "晚班"
        };

        private IList<string> stateList = new List<string>()
        {
            "",
            "完成",
            "未完成"
        };

        IProductLineService productLineService = new ProductLineServiceImpl();

        IUserService userService = new UserServiceImpl();
        
        private ObservableCollection<TaskModel> tasks;

        public ObservableCollection<TaskModel> Tasks
        {
            get
            {
                return tasks;
            }
            set
            {
                tasks = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tasks"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public IList<string> StateList
        {
            get { return stateList; }
            set { stateList = value; }
        }

        public IList<string> WorkTimes
        {
            get { return workTimes; }
            set { workTimes = value; }
        }

        public IList<ProductLineModel> ProductLines
        {
            get;set;
        }

        public IList<SecurityUserModel> Users
        {
            get;set;
        }

        private TaskModel queryParam;
        public TaskModel QueryParam
        {
            get
            {
                return queryParam;
            }
            set
            {
                queryParam = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QueryParam"));
            }
        }

        /// <summary>
        /// 获取或设置显示列模型
        /// </summary>
        public ColumnHeaderModel ShowColumns
        {
            get
            {
                return showColumns;
            }
            set
            {
                showColumns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ShowCulumns"));
            }
        }

        public DataAnalyzeWindow()
        {
            InitializeComponent();
            showColumns = new ColumnHeaderModel();
            //showColumns.Subscribe(this);
            tasks = new ObservableCollection<TaskModel>();

            var taskList = taskService.FindTasksWithParam(new TaskModel());
            tasks = new ObservableCollection<TaskModel>(taskList);

            Users = userService.AllUsersEncrypt();
            Users.Insert(0, new SecurityUserModel());

            ProductLines = productLineService.FindAllProductLines();
            ProductLines.Insert(0, new ProductLineModel());

            QueryParam = new TaskModel();

            DataContext = this;
        }
        
        // 观察到改变
        public void OnNext(ColumnHeaderModel value)
        {

        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }

        private void OnQueryButtonClicked(object sender, RoutedEventArgs e)
        {
            var searchedTask = taskService.FindTasksWithParam(QueryParam);
            Tasks = new ObservableCollection<TaskModel>(searchedTask);
        }

        private void OnExportDetailButtonClicked(object sender, RoutedEventArgs e)
        {
            string saveFileName = OpenSaveFileDialog(); // 获取文件保存路径
            if (null == saveFileName)
            {
                return;
            }

            ExcelHelper helper = new ExcelHelper(saveFileName);
            var dt = new DataTable();
            var columns = dtTasks.Columns;
            Dictionary<string, int> colIndexMap = new Dictionary<string, int>(); // 构建列->索引映射
            int index = 0;
            foreach(var col in columns)
            {
                if (Visibility.Visible == col.Visibility)
                {
                    dt.Columns.Add(col.Header as string);
                    var path = ((col as DataGridTextColumn).Binding as Binding).Path.Path; // 取绑定属性
                    // 构建映射字典
                    if (!colIndexMap.ContainsKey(path))
                    {
                        colIndexMap.Add(path, index++);
                    }
                    else
                    {
                        colIndexMap[path] = index++;
                    }
                }
            }
            // 加两列
            dt.Columns.Add("用料标准比例");
            dt.Columns.Add("用料实际比例");
            foreach (var task in dtTasks.ItemsSource as ObservableCollection<TaskModel>)
            {
                var row = dt.NewRow();
                foreach (var propertyInfo in typeof(TaskModel).GetProperties())
                {
                    var propName = propertyInfo.Name;
                    if (colIndexMap.ContainsKey(propName))
                    {
                        // 取映射
                        index = colIndexMap[propName];
                        row[index] = propertyInfo.GetValue(task);
                    }
                }
                row["用料标准比例"] = task.TargetMainPartWeight + ":" + task.GuHuaWeightSPECL + "-" + task.GuHuaWeightSPECU + ":" + task.XiShiWeightSPECL + "-" + task.XiShiWeightSPECU;
                row["用料实际比例"] = task.ActualMainPartWeight + ":" + task.GuHuaActualWeight + ":" + task.XiShiActualWeight;
                dt.Rows.Add(row);
            }
            
            int rowCount = helper.DataTableToExcel(dt, "DetailSheet", true);
            if (0 < rowCount)
            {
                MessageBox.Show("数据导出成功，共导出：" + rowCount + "行");
                System.Diagnostics.Process.Start("Explorer.exe", "/select," + saveFileName);
            }
            else
            {
                MessageBox.Show("数据导出失败，请稍后重试");
            }
        }

        private string OpenSaveFileDialog()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel 2003兼容性报表(*.xls)|xls|Excel 2007报表(*.xlsx)|xlsx";
            save.Title = "保存报表";

            // 打开
            if (true == save.ShowDialog())
            {
                return save.FileName;
            }

            return null; // 未选定
        }
    }
}
