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
    /// 待搅拌状态
    /// </summary>
    class MixState : ITaskState
    {
        public MixState(Window context) : base(context)
        {
        }

        public override void Start()
        {
            var win = context as MainWindow;
            var speed = win.OpenSpeedInputWindow();

            if (null == speed)
            {
                return;
            }
        }

        public override void Stop()
        {
            var win = context as MainWindow;
            win.TaskInfo.TaskStored.Status = 7;
            Thread updateThread = new Thread((obj) =>
            {
                var updateTask = obj as TaskModel;

                ITaskService taskService = new TaskServiceImpl();
                var err = taskService.ModifyTask(updateTask);

                win._uiSync.Post((res) =>
                {
                    if (null == res)
                    {
                        // 打印条码
                        MessageBox.Show("作业状态更新成功，准备为您打印条码，请稍后...", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                        
                        // 配置打印机
                        PrinterService printerService = new PrinterService();
                        PrinterRecordModel record = new PrinterRecordModel();
                        record.BasicModel.LineType = updateTask.LineName;
                        record.BasicModel.MachineType = updateTask.PartNumber;
                        record.BasicModel.OilMaterialNum = updateTask.MainPartNumber;
                        record.BasicModel.GuhuaMaterialNu = updateTask.GuHuaPartNumber;
                        record.BasicModel.XishiMaterialNum = updateTask.XiShiPartNumber;
                        record.PrintDate = updateTask.SysDateTime.ToString("yyyy-MM-dd HH:ss");
                        record.Operator = updateTask.Operator;
                        record.BasicModel.ValidateTime = win.TaskInfo.Bom.ValidHours;
                        record.BasicModel.OilSeconds = (int)updateTask.ActualSpeed;

                        string printErr = null;
                        printerService.StartPrintNew(record, ref printErr);

                        if (null != printErr)
                        {
                            MessageBox.Show(printErr, "打印错误");
                        }
                        else
                        {
                            MessageBox.Show("打印请求已经提交，请您查看您的打印机，若打印机无响应，请您到参数配置中检查您的打印机设置，我们已为您保存当前打印的实例，若您需要，您可以在调试中打印本次作业，本次作业结束！");
                            TransformState(); // 转换状态
                        }

                    }
                    else
                    {
                        MessageBox.Show("无法更新作业任务：" + res as string, "更新错误");
                    }
                }, err);
            });

            updateThread.Start(win.TaskInfo.TaskStored);
        }

        protected void TransformState()
        {
            // 先把串口关闭
            if (null != mainPort)
            {
                mainPort.Dispose(); // 销毁
            }

            // 返回初始状态
            var win = context as MainWindow;
            win.TaskInfo.CurrentState = new MainMaterialState(context);
        }
    }
}
