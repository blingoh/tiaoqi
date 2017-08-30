using cc.gtscloud.oilpainter.serialport;
using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using frontend.cc.gtscloud.oilpainter.views;
using frontend.cc.gtscloud.oilpainter.views.context;
using frontend.config;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace frontend
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        public void SendBalanceChangeNotify()
        {
            // 主剂料
            RoutedEventArgs newEventArgs = new RoutedEventArgs(SizeChangedEvent);
            rectOilRate.RaiseEvent(newEventArgs);

            // 固化剂
            RoutedEventArgs solidArgs = new RoutedEventArgs(SizeChangedEvent);
            rectSolidifyRate.RaiseEvent(solidArgs);


            // 稀释剂
            RoutedEventArgs xishiArgs = new RoutedEventArgs(SizeChangedEvent);
            rectAttenuationRate.RaiseEvent(xishiArgs);
        }

        private IProductLineService productLineService = new ProductLineServiceImpl();

        private TaskViewModel taskInfo = new TaskViewModel();
        public SerializePortHandler MainPort;
        public SerializePortHandler GuhuaPort;
        public SerializePortHandler XishiPort;
        protected internal SynchronizationContext _uiSync;
        private static int bucketEnsureCount = 0; // 用于标记空桶重量的测算次数
        private static bool updatedEmptyBucket = false; // 标记是否已更新空桶重量
        // 主页面所配置的任务信息
        /// <summary>
        /// 获取或设置
        /// </summary>
        public TaskViewModel TaskInfo
        {
            get { return taskInfo; }
            set
            {
                taskInfo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TaskInfo"));
            }
        }
        
        /// <summary>
        /// 已登录用户
        /// </summary>
        public SecurityUserModel LoginedUser
        {
            get;set;
        }

        // 班次列表
        public IList<string> workTimeList;

        public event PropertyChangedEventHandler PropertyChanged;
        

        public MainWindow()
        {
            InitializeComponent();
                        
            workTimeList = new List<string>();
            workTimeList.Add("早班");
            workTimeList.Add("中班");
            workTimeList.Add("晚班");
            cmbWorkNumber.DataContext = workTimeList;

            _uiSync = SynchronizationContext.Current;

            TaskInfo = new TaskViewModel();
            TaskInfo.GuhuaMaterialInfo = new MaterialInfo(PartTypeConstant.GuHua);

            TaskInfo.MainMetiralInfo = new MaterialInfo(PartTypeConstant.Main);

            TaskInfo.XishiMaterialInfo = new MaterialInfo(PartTypeConstant.XiShi);
            
            TaskInfo.OilWeight = new OilWeightInfo();
            TaskInfo.CurrentState = new MainMaterialState(this);

            TaskInfo.MachineType = new BomQueryModel();

            gridRoot.DataContext = TaskInfo;

            StartLoadProductLineThread();
        }

        private void StartLoadProductLineThread()
        {
            Thread loadThread = new Thread(new ThreadStart(LoadProductLineProc));
            loadThread.Start();
        }

        private void LoadProductLineProc()
        {
            _uiSync.Post(LoadedCallback, productLineService.FindAllProductLines());
        }

        private void LoadedCallback(object value)
        {
            if (value is IList<ProductLineModel>)
            {
                cmbProductLine.ItemsSource = value as IList<ProductLineModel>;
            }
        }

        #region 事件响应
        private void OnBomInfoUploadMenuItemClicked(object sender, RoutedEventArgs e)
        {
            BomUploadWindow bomUpload = new BomUploadWindow();
            bomUpload.Owner = this;
            bomUpload.ShowDialog();
        }
        // 判断快捷键是否执行
        private void WhetherUploadBomCommandExe(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        // 上传BOM的快捷键方法
        private void OnUploadBomCommandCalled(object sender, ExecutedRoutedEventArgs e)
        {
        }
        // 是否因该显示帮助
        private void WhetherOpenHelpDocument(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        // 帮助窗口显示
        private void OnHelpDocumentOpend(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("暂时显示的窗口");
        }
        // 修改密码菜单被点击
        private void OnMenuItemChangePasswordClicked(object sender, RoutedEventArgs e)
        {
            ChangePasswordWindow changePassword = new ChangePasswordWindow();
            changePassword.Owner = this;
            changePassword.ShowDialog();
        }
        // 用户维护菜单被点击
        private void OnMenuItemUserMaintainClicked(object sender, RoutedEventArgs e)
        {
            UserMaintainWindow userMaintain = new UserMaintainWindow();
            userMaintain.Owner = this;
            UserMaintainWinContext context = new UserMaintainWinContext();
            userMaintain.DataContext = context;
            userMaintain.ShowDialog();
        }

        private void OnMenuItemProductLineMaintainClicked(object sender, RoutedEventArgs e)
        {
            ProductLineMaintainWindow productLineMaintain = new ProductLineMaintainWindow();
            productLineMaintain.Owner = this;
            productLineMaintain.ShowDialog();
        }

        private void OnMenuItemMaterialNumberMantainClicked(object sender, RoutedEventArgs e)
        {
            MaterialMaintainWindow materialMaintain = new MaterialMaintainWindow();
            materialMaintain.Owner = this;
            materialMaintain.ShowDialog();
        }

        private void OnMenuItemTechTypeClicked(object sender, RoutedEventArgs e)
        {
            TechnologyTypeWindow techTypeWin = new TechnologyTypeWindow();
            techTypeWin.Owner = this;
            techTypeWin.ShowDialog();
        }

        private void OnMenuItemCustomerMaintainClicked(object sender, RoutedEventArgs e)
        {
            CustomerMaintainWindow customerMaintain = new CustomerMaintainWindow();
            customerMaintain.Owner = this;
            customerMaintain.ShowDialog();
        }

        private void OnMenuItemParamConfigClicked(object sender, RoutedEventArgs e)
        {
            ParameterConfigWindow paramConfig = new ParameterConfigWindow();
            paramConfig.Owner = this;
            paramConfig.ShowDialog();
        }

        private void OnMenuItemPrintDebugClicked(object sender, RoutedEventArgs e)
        {
            PrintDebugWindow printDebug = new PrintDebugWindow();
            printDebug.Owner = this;
            printDebug.ShowDialog();
        }

        private void OnMenuItemSerialPortDebugClicked(object sender, RoutedEventArgs e)
        {
            SerialPortDebugWindow serialDebug = new SerialPortDebugWindow();
            serialDebug.Owner = this;
            serialDebug.ShowDialog();
        }

        private void OnMenuItemSpeedInputClicked(object sender, RoutedEventArgs e)
        {
            SpeedInputWindow speedInput = new SpeedInputWindow();
            speedInput.Owner = this;
            speedInput.ShowDialog();
        }

        private void OnMenuItemDataQueryClicked(object sender, RoutedEventArgs e)
        {
            DataAnalyzeWindow dataAnalyze = new DataAnalyzeWindow();
            dataAnalyze.Owner = this;
            dataAnalyze.ShowDialog();
        }

        private void OnMenuItemSerialCodeClicked(object sender, RoutedEventArgs e)
        {
            RegisterProductWindow register = new RegisterProductWindow();
            register.Owner = this;
            register.ShowDialog();
        }

        private void OnMenuItemHelpClicked(object sender, RoutedEventArgs e)
        {

        }

        // 开始称重主剂料
        private void OnButtonStartWeightClicked(object sender, RoutedEventArgs e)
        {
            if (TaskInfo.CurrentState.TaskName == ITaskState.StopName)
            {
                TaskInfo.CurrentState.Stop();
            }
            else
            {
                updatedEmptyBucket = false;
                bucketEnsureCount = 0;
                // 状态执行
                TaskInfo.CurrentState.Start();
            }
        }
        

        private void OnQueryBomClicked(object sender, RoutedEventArgs e)
        {
            DataQueryWindow dataquery = new DataQueryWindow();
            dataquery.Owner = this;
            dataquery.ShowDialog();
            if (true == dataquery.DialogResult)
            {
                var bom = dataquery.SelectedBomModel;

                // 开启线程加载BOM
                Thread thread = new Thread((id) =>
                {
                    IBomInfoService service = new BomInfoServiceImpl();
                    var foundBom = service.FindBom(id as string);
                    if (null != foundBom)
                    {
                        this.Invoke(() =>
                        {
                            TaskInfo.MachineType = bom;
                            TaskInfo.Bom = foundBom;
                        });
                    }
                    else
                    {
                        this.Invoke(() =>
                        {
                            MessageBox.Show("当前选定的机种在BOM清单中未找到，请联系管理员检查您的数据是否完整，并尝试重建该BOM", "错误");
                        });
                    }
                });
                thread.Start(bom.BomId);
            }
        }
        /// <summary>
        /// 打开剂料号的输入窗口
        /// <returns>输入窗口输入的主剂料</returns>
        /// </summary>
        public MaterialInfo OpenMaterialWindow()
        {
            if (null == TaskInfo.WorkTime || 0 >= TaskInfo.WorkTime.Trim().Length)
            {
                MessageBox.Show("请选择班次", "非法");
                return null;
            }

            if (null == TaskInfo.ProductLine || 0 >= TaskInfo.ProductLine.Trim().Length)
            {
                MessageBox.Show("请选择产线", "非法");
                return null;
            }

            if (null == TaskInfo.MachineType || 
                null == TaskInfo.MachineType.MachineType || 
                0 >= TaskInfo.MachineType.MachineType.Trim().Length ||
                null == TaskInfo.MachineType.Manufacturer ||
                0 >= TaskInfo.MachineType.Manufacturer.Trim().Length ||
                null == TaskInfo.MachineType.PaintType ||
                0 >= TaskInfo.MachineType.PaintType.Trim().Length)
            {
                MessageBox.Show("请选择油漆信息", "非法");
                return null;
            }

            if (null == TaskInfo.OilWeight ||
                0 >= TaskInfo.OilWeight.PlanWeight)
            {
                MessageBox.Show("请选择计划配重", "非法");
                return null;
            }

            MaterialInputWindow inputWin = new MaterialInputWindow();
            inputWin.BOMId = TaskInfo.MachineType.BomId;
            inputWin.Owner = this;
            inputWin.MaterialType = PartTypeConstant.Main;
            if (true == inputWin.ShowDialog())
            {
                return inputWin.MaterialNumInfo;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 打开固化剂输入窗口
        /// </summary>
        /// <returns>输入窗口输入的固化剂信息</returns>
        public MaterialInfo OpenGuhuaWindow()
        {
            MaterialInputWindow inputWin = new MaterialInputWindow();
            inputWin.BOMId = TaskInfo.MachineType.BomId;
            inputWin.Owner = this;
            inputWin.MaterialType = PartTypeConstant.GuHua;
            if (true == inputWin.ShowDialog())
            {
                return inputWin.MaterialNumInfo;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 打开稀释剂窗口
        /// </summary>
        /// <returns>输入窗口输入的稀释剂信息</returns>
        public MaterialInfo OpenXishiWindow()
        {
            MaterialInputWindow inputWin = new MaterialInputWindow();
            inputWin.BOMId = TaskInfo.MachineType.BomId;
            inputWin.Owner = this;
            inputWin.MaterialType = PartTypeConstant.XiShi;
            if (true == inputWin.ShowDialog())
            {
                return inputWin.MaterialNumInfo;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 打开流速输入的窗口
        /// </summary>
        /// <returns>输入的流速</returns>
        internal string OpenSpeedInputWindow()
        {
            SpeedInputWindow speedWin = new SpeedInputWindow();
            speedWin.CurrentTask = TaskInfo.TaskStored;
            speedWin.TaskState = TaskInfo.CurrentState;
            speedWin.SpeedUp = double.Parse(TaskInfo.Bom.OilSpeedU.ToString("0.00"));
            speedWin.SpeedLow = double.Parse(TaskInfo.Bom.OilSpeedL.ToString("0.00"));
            speedWin.Owner = this;
            if (true == speedWin.ShowDialog())
            {
                if (0 >= speedWin.OilSpeed)
                {
                    if (MessageBoxResult.OK == MessageBox.Show("当前输入的流速不大于0，您是否确认输入正确？", "确认", MessageBoxButton.OKCancel, MessageBoxImage.Question))
                    {
                        return speedWin.OilSpeed + "," + speedWin.Timeout;
                    }
                    else
                    {
                        return null;
                    }
                }
                return speedWin.OilSpeed + "," + speedWin.Timeout;
            }
            return null;
        }

        private void OnButtonMixClicked(object sender, RoutedEventArgs e)
        {
            TaskInfo.CurrentState.Start();
        }
        #endregion

        #region 处理串口

        private StringBuilder mainResultStringBuilder = new StringBuilder();
        internal void HandleMainPortData(object sender, byte[] buffer)
        {
            // 接收资源
            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke(() =>
            {
                var text = Encoding.UTF8.GetString(buffer);
                ParseAndBind(text, TaskInfo.MainMetiralInfo, PartTypeConstant.Main);
                
            });
        }
        /// <summary>
        /// 解析固化剂串口信息
        /// </summary>
        /// <param name="sender">发送方(串口Handler)</param>
        /// <param name="bytes">需要解析的字节</param>
        internal void HandleGuhuaPortData(object sender, byte[] bytes)
        {
            // 接收资源
            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke(() =>
            {
                var text = Encoding.UTF8.GetString(bytes);

                ParseAndBind(text, TaskInfo.GuhuaMaterialInfo, PartTypeConstant.GuHua);

            });
        }
        /// <summary>
        /// 解析稀释剂串口信息
        /// </summary>
        /// <param name="sender">发送方(串口Handler)</param>
        /// <param name="bytes">需要解析的字节</param>
        internal void HandleXishiPortData(object sender, byte[] bytes)
        {
            // 接收资源
            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke(() =>
            {
                var text = Encoding.UTF8.GetString(bytes);

                ParseAndBind(text, TaskInfo.XishiMaterialInfo, PartTypeConstant.XiShi);
            });
        }

        // 解析并且绑定到模型
        protected void ParseAndBind(string text, MaterialInfo materialInfo, string type)
        {
            if (!updatedEmptyBucket)
            {
                // 解析为空桶重量
                ISerialPortDataParser weightParser = new GenerateParser();
                var value = weightParser.ParseRecord(text);
                if (null != value)
                {
                    if (5 > bucketEnsureCount)
                    {
                        // 绑定上去
                        if (value.Unit.ToUpper() == "KG")
                        {
                            materialInfo.EmptyBucketWeight = value.Weight * 1000;
                        }
                        else if (value.Unit.ToUpper() == "G")
                        {
                            materialInfo.EmptyBucketWeight = value.Weight;
                        }
                        else
                        {
                            materialInfo.EmptyBucketWeight = value.Weight * 1000000;
                        }

                        // 绑定后增加计数器
                        bucketEnsureCount++;
                    }
                    else
                    {
                        bucketEnsureCount = 0;
                        updatedEmptyBucket = true;
                    }
                }
            }
            else
            {
                // 解析为油漆重量
                ISerialPortDataParser weightParser = new GenerateParser();
                var value = weightParser.ParseRecord(text);

                if (null != value)
                {
                    if (SingtonConfigContent.Instance().OilSpin.AutoCalcWeight) // 自动计算重量
                    {
                        if ("KG" == value.Unit.ToUpper())
                        {
                            materialInfo.CurrentBalanceWeight = value.Weight - materialInfo.EmptyBucketWeight / 1000;
                        }
                        else if ("G" == value.Unit.ToUpper())
                        {
                            materialInfo.CurrentBalanceWeight = value.Weight / 1000 - materialInfo.EmptyBucketWeight / 1000;
                        }
                        else
                        {
                            materialInfo.CurrentBalanceWeight = value.Weight / 1000000 - materialInfo.EmptyBucketWeight / 1000;
                        }
                    }
                    else
                    {
                        if ("KG" == value.Unit.ToUpper())
                        {
                            materialInfo.CurrentBalanceWeight = value.Weight;
                        }
                        else if ("G" == value.Unit.ToUpper())
                        {
                            materialInfo.CurrentBalanceWeight = value.Weight / 1000;
                        }
                        else
                        {
                            materialInfo.CurrentBalanceWeight = value.Weight / 1000000;
                        }
                    }

                    if (type == PartTypeConstant.Main)
                    {
                        TaskInfo.OilWeight.ActualWeight = materialInfo.CurrentBalanceWeight;
                    }

                    SendBalanceChangeNotify();
                }
            }
        }
        #endregion

        
    }
}
