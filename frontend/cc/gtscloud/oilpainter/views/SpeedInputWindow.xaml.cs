using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using frontend.config;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
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
    /// SpeedInputWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SpeedInputWindow : MetroWindow, INotifyPropertyChanged
    {
        // 定时器
        private System.Timers.Timer timer;
        /// <summary>
        /// 输入的油漆流速
        /// </summary>
        public double OilSpeed
        {
            get;set;
        }
        
        /// <summary>
        /// 当前执行的任务
        /// </summary>
        public TaskModel CurrentTask
        {
            get;set;
        }

        public ITaskState TaskState;

        private int timeout = 180;

        public event PropertyChangedEventHandler PropertyChanged;

        public double SpeedUp
        {
            get;set;
        }

        public double SpeedLow
        {
            get;set;
        }

        public int Timeout
        {
            get
            {
                return timeout;
            }
            set
            {
                timeout = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Timeout"));
            }
        }

        public SpeedInputWindow()
        {
            InitializeComponent();
            //numSpeed.DataContext = OilSpeed as double?;
            timer = new System.Timers.Timer();
            timer.Elapsed += (from, args) =>
            {
                this.Invoke(() =>
                {
                    if (0 >= Timeout)
                    {
                        timer.Enabled = false;
                    }
                    else
                    {
                        Timeout--;
                    }
                });
            };
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
            numSpeed.DataContext = this;
            lblTimeout.DataContext = this;

            Closing += WindowWillToClosed;
        }

        private void WindowWillToClosed(object sender, CancelEventArgs e)
        {
            timer.Stop();
            timer.Enabled = false;
        }

        private void OnEnsureSpeedButtonClicked(object sender, RoutedEventArgs e)
        {
            // 停止计时器
            timer.Stop();
            timer.Enabled = false;

            CurrentTask.ActualDelaySeconds = 180 - Timeout;
            CurrentTask.ActualSpeed = (decimal)OilSpeed;
            TaskState.Stop();

            Close();
        }
    }
}
