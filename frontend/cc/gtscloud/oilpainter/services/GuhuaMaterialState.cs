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
    /// 调固化剂状态
    /// </summary>
    class GuhuaMaterialState : ITaskState
    {
        public GuhuaMaterialState(Window context) : base(context)
        {
        }

        public override void Start()
        {
            if (TaskName == StartName)
            {
                // 打开窗口
                var material = (context as MainWindow).OpenGuhuaWindow();
                if (null == material)
                {
                    return;
                }
                else
                {
                    // 配置任务信息
                    var task = (context as MainWindow).TaskInfo;
                    task.GuhuaMaterialInfo.MaterialNumber = material.MaterialNumber;
                    task.GuhuaMaterialInfo.BatchNumber = material.BatchNumber;
                    // 解析好上下限
                    var guhuaRate = task.Bom.GuHuaPercent;

                    task.GuhuaMaterialInfo.StandardLow = task.MainMetiralInfo.FinalWeight * ((guhuaRate / 100.0) * 0.95);
                    task.GuhuaMaterialInfo.StandardUp = task.MainMetiralInfo.FinalWeight * ((guhuaRate / 100.0) * 1.05);
                }

                //初始化串口
                SerializePortConfig portConfig = new SerializePortConfig();
                portConfig.BaudRate = SingtonConfigContent.Instance().GuhuaBalance.BaudRate;
                portConfig.Parity = SingtonConfigContent.Instance().GuhuaBalance.Parity;
                portConfig.BitLength = SingtonConfigContent.Instance().GuhuaBalance.DataBits;
                portConfig.Port = SingtonConfigContent.Instance().GuhuaBalance.PortNumber;
                portConfig.StopBitLength = SingtonConfigContent.Instance().GuhuaBalance.StopBits;
                mainPort = new SerializePortHandler(portConfig);

                var mainWin = (context as MainWindow);
                mainWin.MainPort = mainPort;
                mainPort.UnitBufferSize = 80; // 为使数据更稳定，加大数据个数

                mainPort.RecievedData += mainWin.HandleGuhuaPortData;

                string err = null;
                var opend = mainPort.TryToOpenSerialPort(ref err);
                if (!opend)
                {
                    MessageBox.Show("无法打开端口，请检查您的端口配置！", "端口错误");
                    return;
                }

                // 开始变结束
                TaskName = StopName;
            }
        }

        public override void Stop()
        {
            var win = (context as MainWindow);

            // 判断阈值
            if (win.TaskInfo.GuhuaMaterialInfo.CurrentColor.Equals(MaterialInfo.Green))
            {
                var task = win.TaskInfo.TaskStored;
                task.GuHuaActualWeight = (decimal)win.TaskInfo.GuhuaMaterialInfo.FinalWeight;
                task.GuHuaHolderWeight = (decimal)win.TaskInfo.GuhuaMaterialInfo.EmptyBucketWeight;
                task.GuHuaPartNumber = win.TaskInfo.GuhuaMaterialInfo.MaterialNumber;
                task.GuHuaLotNumber = win.TaskInfo.GuhuaMaterialInfo.BatchNumber;
                task.GuHuaPartVendor = "";
                task.GuHuaRangeBase = SingtonConfigContent.Instance().OilSpin.DistanceRate;
                task.GuHuaRate = decimal.Parse(win.TaskInfo.GuhuaMaterialInfo.CurrentRate.Replace("%", ""));
                task.GuHuaWeightSPECL = (decimal)win.TaskInfo.GuhuaMaterialInfo.StandardLow;
                task.GuHuaWeightSPECU = (decimal)win.TaskInfo.GuhuaMaterialInfo.StandardUp;
                task.Operator = win.LoginedUser.UserName;
                task.Status = 3;

                Thread updateThread = new Thread((obj) =>
                {
                    var updateTask = obj as TaskModel;

                    ITaskService taskService = new TaskServiceImpl();
                    var err = taskService.ModifyTask(updateTask);

                    win._uiSync.Post((res) =>
                    {
                        if (null == res)
                        {
                            TransformState(); // 转换状态
                        }
                        else
                        {
                            MessageBox.Show("无法更新作业任务：" + res as string, "更新错误");
                        }
                    }, err);
                });

                updateThread.Start(task);
                
            }
            else
            {
                MessageBox.Show("根据BOM设定，您当前的重量不符合要求，请重新调整。根据BOM固化剂比例为：" + win.TaskInfo.Bom.GuHuaPercent + "%, 根据要求，固化剂重量应在：" + win.TaskInfo.GuhuaMaterialInfo.StandardLow + "-" + win.TaskInfo.GuhuaMaterialInfo.StandardUp + "KG之间。", "重量不符");
            }
        }

        protected void TransformState()
        {
            var win = context as MainWindow;
            // 先把串口关闭
            if (null != mainPort)
            {
                mainPort.Dispose(); // 销毁
            }
            TaskName = StartName;
            win.TaskInfo.CurrentState = new XishiMaterialState(context);
        }
    }
}
