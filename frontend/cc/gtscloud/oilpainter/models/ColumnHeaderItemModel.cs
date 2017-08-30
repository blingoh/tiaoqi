using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.models
{
    public class ColumnHeaderItemModel : ObservablePropertyChangedModel
    {
        private string header;
        private bool visiable = true;
        /// <summary>
        /// 获取或设置表头文本
        /// </summary>
        public string Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
                SendPropertyChangedEvent("Header");
            }
        }
        /// <summary>
        /// 获取或设置列可见
        /// </summary>
        public bool Visiable
        {
            get
            {
                return visiable;
            }
            set
            {
                visiable = value;
                SendPropertyChangedEvent("Visiable");
            }
        }
        
    }
}
