using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace frontend
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        //protected override void OnStartup(StartupEventArgs args)
        //{
        //    bool createNew;
        //    Mutex mutex = new Mutex(true, "b4d22fd6-df08-4d46-bcb4-f20c386436eb", out createNew);
        //    if (createNew)
        //        mutex.WaitOne();
        //    else
        //    {
        //        MessageBox.Show("程序已经启动了");
        //        Application.Current.Shutdown();
        //    }
        //    GC.KeepAlive(createNew);
        //}

        private Mutex mutex;
        public App()
        {
            Startup += StartupHander;
        }

        private void StartupHander(object sender, StartupEventArgs e)
        {
            bool createNew;
            mutex = new Mutex(true, "b4d22fd6-df08-4d46-bcb4-f20c386436eb", out createNew);
            if (!createNew)
            {
                MessageBox.Show("当前程序实例已经启动，请结束在此之前的所有工作，并关闭实例后启动该应用程序", "启动错误");
                Environment.Exit(0);
            }
            GC.KeepAlive(createNew);
        }

    }
}
