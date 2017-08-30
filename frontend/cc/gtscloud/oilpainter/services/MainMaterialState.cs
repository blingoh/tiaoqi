using cc.gtscloud.oilpainter.serialport;
using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using frontend.cc.gtscloud.oilpainter.services.impl;
using frontend.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace frontend.cc.gtscloud.oilpainter.services
{
    /// <summary>
    /// 调主剂料状态
    /// </summary>
    class MainMaterialState : ITaskState
    {
        public MainMaterialState(Window context) : base(context)
        {
        }

        public override void Start()
        {
            if (TaskName == StartName)
            {
                // 打开窗口
                var material = (context as MainWindow).OpenMaterialWindow();
                if (null == material)
                {
                    return;
                }
                else
                {
                    // 配置任务信息
                    var task = (context as MainWindow).TaskInfo;
                    task.MainMetiralInfo.MaterialNumber = material.MaterialNumber;
                    task.MainMetiralInfo.BatchNumber = material.BatchNumber;
                    task.MainMetiralInfo.StandardUp = task.OilWeight.PlanWeight;
                    task.MainMetiralInfo.StandardLow = 0;
                }

                //初始化串口
                SerializePortConfig mainConfig = new SerializePortConfig();
                mainConfig.BaudRate = SingtonConfigContent.Instance().BasicBalance.BaudRate;
                mainConfig.Parity = SingtonConfigContent.Instance().BasicBalance.Parity;
                mainConfig.BitLength = SingtonConfigContent.Instance().BasicBalance.DataBits;
                mainConfig.Port = SingtonConfigContent.Instance().BasicBalance.PortNumber;
                mainConfig.StopBitLength = SingtonConfigContent.Instance().BasicBalance.StopBits;
                mainPort = new SerializePortHandler(mainConfig);

                var mainWin = (context as MainWindow);
                mainWin.MainPort = mainPort;
                mainPort.UnitBufferSize = 80; // 为使数据更稳定，加大数据个数

                mainPort.RecievedData += mainWin.HandleMainPortData;

                string err = null;
                var opend = mainPort.TryToOpenSerialPort(ref err);
                if (!opend)
                {
                    MessageBox.Show("无法打开端口，请检查您的端口配置！", "端口错误");
                    return;
                }

                // 开始
                TaskName = StopName;
            }
        }

        public override void Stop()
        {
            var win = context as MainWindow;

            // 如果重量未检测则不能转换状态
            if (0 >= win.TaskInfo.MainMetiralInfo.CurrentBalanceWeight || win.TaskInfo.MainMetiralInfo.StandardUp < win.TaskInfo.MainMetiralInfo.CurrentBalanceWeight)
            {
                MessageBox.Show("原油重量不在设定的阈值内，请重新加入原油", "阈值限制");
                return;
            }
            
            // 确定最终重量
            win.TaskInfo.MainMetiralInfo.FinalWeight = win.TaskInfo.MainMetiralInfo.CurrentBalanceWeight;

            //// 默认固化剂比例 95-105（沿用V1.0）
            //win.TaskInfo.GuhuaMaterialInfo.StandardLow = 0.95 * win.TaskInfo.MainMetiralInfo.FinalWeight; // 单位为KG
            //win.TaskInfo.GuhuaMaterialInfo.StandardUp = 1.05 * win.TaskInfo.MainMetiralInfo.FinalWeight;

            //// 加载稀释剂比例
            //win.TaskInfo.XishiMaterialInfo.StandardLow = win.TaskInfo.MainMetiralInfo.FinalWeight * (win.TaskInfo.Bom.XiShiLowPercent / 100.0);
            //win.TaskInfo.XishiMaterialInfo.StandardUp = win.TaskInfo.MainMetiralInfo.FinalWeight *  (win.TaskInfo.Bom.XiShiUpPercent / 100.0);

            // 创建任务
            var newWork = new dao.model.TaskModel();
            win.TaskInfo.TaskStored = new dao.model.TaskModel();
            // 创建ID
            newWork.BomId = win.TaskInfo.Bom.BomId;
            newWork.TaskID = Guid.NewGuid().ToString();
            // 补充主任务信息
            newWork.LineName = win.TaskInfo.ProductLine;
            newWork.ShiftName = win.TaskInfo.WorkTime;
            newWork.ProductName = win.TaskInfo.MachineType.MachineType;
            newWork.PartNumber = newWork.ProductName;
            newWork.MainPartVendor = win.TaskInfo.MachineType.Manufacturer;
            newWork.MainPartNumber = win.TaskInfo.MainMetiralInfo.MaterialNumber;
            newWork.MainLotNumber = win.TaskInfo.MainMetiralInfo.BatchNumber;
            newWork.TargetMainPartWeight = (decimal)win.TaskInfo.OilWeight.PlanWeight;
            newWork.ActualMainPartWeight = (decimal)win.TaskInfo.MainMetiralInfo.FinalWeight;
            newWork.Status = 1;
            newWork.Operator = win.LoginedUser.UserName;
            newWork.MainHolderWeight = (decimal)win.TaskInfo.MainMetiralInfo.EmptyBucketWeight;
            newWork.SysDateTime = DateTime.Now;

            win.TaskInfo.TaskStored = newWork;

            // 开始线程插入
            Thread thread = new Thread((work) =>
            {
                var insWork = work as TaskModel;
                ITaskService taskService = new TaskServiceImpl();
                var err = taskService.AddTask(insWork);
                win._uiSync.Post((obj) =>
                {
                    if (null == obj)
                    {
                        TrsanformState(); // 转变状态
                    }
                    else
                    {
                        MessageBox.Show("无法建立任务：" + obj as string, "失败");
                    }
                }, err);
            });
            thread.Start(newWork);
            
        }

        // 状态转化
        protected void TrsanformState()
        {
            var win = context as MainWindow;
            // 先把串口关闭
            if (null != mainPort)
            {
                mainPort.Dispose(); // 销毁
            }

            TaskName = StartName;
            // 做一些检查
            if (0 >= win.TaskInfo.Bom.GuHuaPercent)
            {
                // 不需要固化剂
                win.TaskInfo.CurrentState = new XishiMaterialState(context);
            }
            else
            {
                win.TaskInfo.CurrentState = new GuhuaMaterialState(context);
                win.TaskInfo.GuhuaMaterialInfo.StandardLow = win.TaskInfo.GuhuaMaterialInfo.StandardUp = win.TaskInfo.MainMetiralInfo.FinalWeight * (win.TaskInfo.Bom.GuHuaPercent / 100); // 单位为KG
            }
        }
    }
}
