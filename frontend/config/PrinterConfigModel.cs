using frontend.cc.gtscloud.oilpainter.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.config
{
    /// <summary>
    /// 打印机参数实体
    /// </summary>
    class PrinterConfigModel : ObservablePropertyChangedModel
    {
        private string printName;
        private string labelTemplatePath;
        /// <summary>
        /// 获取或设置打印机名
        /// </summary>
        public string PrinterName
        {
            get
            {
                return printName;
            }
            set
            {
                printName = value;
                SendPropertyChangedEvent("PrinterName");
            }
        }

        /// <summary>
        /// 获取或设置标签模板位置
        /// </summary>
        public string LabelTemplatPath
        {
            get
            {
                return labelTemplatePath;
            }
            set
            {
                labelTemplatePath = value;
                SendPropertyChangedEvent("LabelTemplatPath");
            }
        }
    }
}
