using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.services;
using frontend.cc.gtscloud.oilpainter.services.impl;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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
    /// TechnologyTypeWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TechnologyTypeWindow : MetroWindow
    {
        private IOilTypeService oilTypeService = new OilTypeServiceImpl();

        private SynchronizationContext _uiSyncContext; // 同步上下文

        public TechnologyTypeWindow()
        {
            InitializeComponent();

            _uiSyncContext = SynchronizationContext.Current;

            StartLoadThread();
        }

        // 开启加载线程
        private void StartLoadThread()
        {
            Thread loadThread = new Thread(new ThreadStart(LoadAllOilTypesEntry));
            loadThread.Start();
        }

        // 加载油漆类型的入口
        private void LoadAllOilTypesEntry()
        {
            var all = oilTypeService.FindAllOilTypes();
            _uiSyncContext.Post(LoadedCallback, all);
        }

        // 加载成功回调
        private void LoadedCallback(object values)
        {
            // 绑定上下文
            if (values is IList<OilPaintTypeModel>)
            {
                cmbOilTypes.DataContext = values;
                cmbOilTypes.SelectedIndex = 0;
            }
        }
    }
}
