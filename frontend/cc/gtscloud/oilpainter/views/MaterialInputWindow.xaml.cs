using BarCodeParser;
using cc.gtscloud.BarCodeParser;
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
    /// MaterialInputWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MaterialInputWindow : MetroWindow, INotifyPropertyChanged
    {

        #region 属性
        /// <summary>
        /// 原料类型：固化剂、稀释剂、主剂
        /// </summary>
        public string MaterialType
        {
            get;set;
        }
        /// <summary>
        /// 设置当前选定的BOMID
        /// </summary>
        public string BOMId
        {
            get;set;
        }
        private MaterialInfo materialNumInfo;

        public event PropertyChangedEventHandler PropertyChanged;

        public MaterialInfo MaterialNumInfo
        {
            get
            {
                return materialNumInfo;
            }
            set
            {
                materialNumInfo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MaterialNumInfo"));
            }
        }


        #endregion
        public MaterialInputWindow()
        {
            InitializeComponent();

            MaterialNumInfo = new MaterialInfo(PartTypeConstant.Main);

            DataContext = this;
        }

        #region 业务处理
        /// <summary>
        /// 检验料号输入是否合法
        /// </summary>
        protected void SubmitCheck()
        {
            var info = new BomPartInformationModel();
            info.BomId = BOMId;
            info.PartNumber = MaterialNumInfo.MaterialNumber;
            info.PartType = MaterialType;
            Thread loadThread = new Thread((partInfo) =>
            {
                IBomInfoService service = new BomInfoServiceImpl();
                var allParts = service.FindPartInfo(partInfo as BomPartInformationModel);

                if (null == allParts || 0 >= allParts.Count)
                {
                    this.Invoke(() =>
                    {
                        MessageBox.Show("当前主剂料号，不为当前BOM所配置的剂料，请换用其他的剂料", "不匹配");
                        btnSubmit.IsEnabled = true;
                    });
                }
                else
                {
                    this.Invoke(() =>
                    {
                        MessageBox.Show("当前剂料识别成功，您提交后，将为您自动计算容器重量，请您待界面容器重量值稳定后再添加油漆！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                        DialogResult = true;
                        btnSubmit.IsEnabled = true;
                        Close();
                    });
                }

            });

            loadThread.Start(info);
            btnSubmit.IsEnabled = false;
        }
        #endregion

        #region 事件处理
        // 码值内容改变
        private void OnTxtBarCodeContentChanged(object sender, TextChangedEventArgs e)
        {
            ParseCode((sender as TextBox).Text);
        }
        
        private void ParseCode(string content)
        {
            if (null == content || 10 > content.Length)
            {
                return;
            }

            IBarCodeParser mainNumParser = null;
            IBarCodeParser batchNumParser = null;
            if (null != SingtonConfigContent.Instance().MainCodeRule &&
                0 < SingtonConfigContent.Instance().MainCodeRule.Length)
            {
                mainNumParser = new RuledParser();
            }
            if (null != SingtonConfigContent.Instance().MainNumRule &&
                0 < SingtonConfigContent.Instance().MainNumRule.Trim().Length)
            {
                batchNumParser = new RuledParser();
            }
            
            if (null == mainNumParser)
            {
                mainNumParser = new GenerateParser();
            }

            if (null == batchNumParser)
            {
                batchNumParser = new GenerateParser();
            }

            if (null != mainNumParser)
            {
                try
                {
                    MaterialNumInfo.MaterialNumber = mainNumParser.ParseMainNum(content, SingtonConfigContent.Instance().MainCodeRule);
                }
                catch
                {
                    txtBarCode.Text = "";
                }
            }

            if (null != mainNumParser)
            {
                try
                {
                    MaterialNumInfo.BatchNumber = batchNumParser.ParseBatchNum(content, SingtonConfigContent.Instance().MainNumRule);
                }
                catch
                {
                    MaterialNumInfo.BatchNumber = "";
                }
            }

        }

        private void OnSubmitClicked(object sender, RoutedEventArgs e)
        {
            if (null == MaterialNumInfo.MaterialNumber || 0 >= MaterialNumInfo?.MaterialNumber.Trim().Length)
            {
                MessageBox.Show("请输入剂料号后再提交", "非法");
                return;
            }
            if (null == MaterialNumInfo.BatchNumber || 0 >= MaterialNumInfo?.BatchNumber.Trim().Length)
            {
                MessageBox.Show("请输入批次号后再提交", "非法");
                return;
            }

            // 检验
            SubmitCheck();
        }
        #endregion
        
    }
}
