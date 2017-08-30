using frontend.cc.gtscloud.oilpainter.dao.model;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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
    /// CustomerAdd.xaml 的交互逻辑
    /// </summary>
    public partial class CustomerAdd : MetroWindow
    {
        /// <summary>
        /// 客户实体
        /// </summary>
        public CustomerModel Customer
        {
            get;set;
        }

        /// <summary>
        /// 构造函数
        /// </summary>

        public CustomerAdd()
        {
            InitializeComponent();
            Customer = new CustomerModel();
            gridRoot.DataContext = Customer;
        }

        private void OnEnsureAddClicked(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
