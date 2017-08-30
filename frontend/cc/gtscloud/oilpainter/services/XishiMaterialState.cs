using cc.gtscloud.oilpainter.serialport;
using frontend.cc.gtscloud.oilpainter.dao.model;
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
    /// 稀释剂状态
    /// </summary>
    class XishiMaterialState : ITaskState
    {
        public XishiMaterialState(Window context) : base(context)
        {
        }

        public override void Start()
        {
            if (TaskName == StartName)
            {
                // 打开窗口
                var win = (context as MainWindow);
                var material = win.OpenXishiWindow();
                if (null == material)
                {
                    return;
                }
                else
                {
                    // 配置任务信息
                    var task = win.TaskInfo;
                    task.XishiMaterialInfo.MaterialNumber = material.MaterialNumber;
                    task.XishiMaterialInfo.BatchNumber = material.BatchNumber;
                    task.XishiMaterialInfo.StandardUp = win.TaskInfo.MainMetiralInfo.FinalWeight * (win.TaskInfo.Bom.XiShiUpPercent / 100.0);
                    task.XishiMaterialInfo.StandardLow = task.MainMetiralInfo.FinalWeight * (win.TaskInfo.Bom.XiShiLowPercent / 100.0);
                }

                //初始化串口
                SerializePortHandler mainPort;
                SerializePortConfig mainConfig = new SerializePortConfig();
                mainConfig.BaudRate = SingtonConfigContent.Instance().XishiBalance.BaudRate;
                mainConfig.Parity = SingtonConfigContent.Instance().XishiBalance.Parity;
                mainConfig.BitLength = SingtonConfigContent.Instance().XishiBalance.DataBits;
                mainConfig.Port = SingtonConfigContent.Instance().XishiBalance.PortNumber;
                mainConfig.StopBitLength = SingtonConfigContent.Instance().XishiBalance.StopBits;
                mainPort = new SerializePortHandler(mainConfig);
                
                win.MainPort = mainPort;
                mainPort.UnitBufferSize = 80; // 为使数据更稳定，加大数据个数

                mainPort.RecievedData += win.HandleXishiPortData;

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
            var win = (context as MainWindow);
            // 判断域
            var rate = double.Parse(win.TaskInfo.XishiMaterialInfo.CurrentRate.Replace("%", ""));
            //var top = (win.TaskInfo.XishiMaterialInfo.StandardUp / 1.02) / win.TaskInfo.XishiMaterialInfo.StandardLow;
            var value = (rate / 100) * win.TaskInfo.XishiMaterialInfo.StandardLow;
            if (win.TaskInfo.XishiMaterialInfo.StandardLow <= value && value <= win.TaskInfo.XishiMaterialInfo.StandardUp)
            {
                // 符合要求，更新任务
                var task = win.TaskInfo.TaskStored;
                task.XiShiActualWeight = (decimal)win.TaskInfo.XishiMaterialInfo.FinalWeight;
                task.XiShiHolderWeight = (decimal)win.TaskInfo.XishiMaterialInfo.EmptyBucketWeight;
                task.XiShiLotNumber = win.TaskInfo.XishiMaterialInfo.BatchNumber;
                task.XiShiPartNumber = win.TaskInfo.XishiMaterialInfo.MaterialNumber;
                task.XiShiRate = decimal.Parse(win.TaskInfo.XishiMaterialInfo.CurrentRate.Replace("%", ""));
                task.XiShiVendor = "";
                task.XiShiWeightSPECL = (decimal)win.TaskInfo.XishiMaterialInfo.StandardLow;
                task.XiShiWeightSPECU = (decimal)win.TaskInfo.XishiMaterialInfo.StandardUp;

                task.Status = 5;

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
                MessageBox.Show("当前稀释剂量不满足条件，无法完成，其重量按照" + win.TaskInfo.Bom.XiShiLowPercent + "%-" + win.TaskInfo.Bom.XiShiUpPercent + "%之间，因此重量应当在" + win.TaskInfo.XishiMaterialInfo.StandardLow + "-" + win.TaskInfo.XishiMaterialInfo.StandardUp + "KG之间", "稀释剂量错误");
                return;
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
            win.TaskInfo.CurrentState = new MixState(context);
        }
    }
}
