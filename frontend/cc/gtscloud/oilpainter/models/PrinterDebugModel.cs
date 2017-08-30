using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.models
{
    /// <summary>
    /// 打印机调试实体
    /// </summary>
    class PrinterDebugModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string lineType;
        private string machineType;
        private string oilMaterialNum;
        private string guhuaMaterialNum;
        private string xishiMaterialNum;
        private int oilSeconds;
        private int validateTime;

        /// <summary>
        /// 获取或设置线别
        /// </summary>
        public string LineType
        {
            get { return lineType; }
            set
            {
                lineType = value;
                SendPropertyChangedEvent("LineType");
            }
        }

        /// <summary>
        /// 获取或设置机种
        /// </summary>
        public string MachineType
        {
            get { return machineType; }
            set
            {
                machineType = value;
                SendPropertyChangedEvent("MachineType");

            }
        }

        /// <summary>
        /// 获取或设置原油料号
        /// </summary>
        public string OilMaterialNum
        {
            get
            {
                return oilMaterialNum;
            }
            set
            {
                oilMaterialNum = value;
                SendPropertyChangedEvent("OilMaterialNum");

            }
        }

        /// <summary>
        /// 获取或设置固化剂料号
        /// </summary>
        public string GuhuaMaterialNu
        {
            get { return guhuaMaterialNum; }
            set
            {
                guhuaMaterialNum = value;
                SendPropertyChangedEvent("GuhuaMaterialNu");
            }
        }

        /// <summary>
        /// 获取或设置稀释剂料号
        /// </summary>
        public string XishiMaterialNum
        {
            get { return xishiMaterialNum; }
            set
            {
                xishiMaterialNum = value;
                SendPropertyChangedEvent("XishiMaterialNum");
            }
        }

        /// <summary>
        /// 获取或设置油漆秒数
        /// </summary>
        public int OilSeconds
        {
            get { return oilSeconds; }
            set
            {
                oilSeconds = value;
                SendPropertyChangedEvent("OilSeconds");
            }
        }

        /// <summary>
        /// 获取或设置有效时间
        /// </summary>
        public int ValidateTime
        {
            get { return validateTime; }
            set { validateTime = value;
                SendPropertyChangedEvent("ValidateTime");
            }
        }

        // 发送属性更改通知事件
        private void SendPropertyChangedEvent(string propertyName)
        {
            if (null != PropertyChanged)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
