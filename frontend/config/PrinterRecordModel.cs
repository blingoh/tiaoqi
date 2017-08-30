using frontend.cc.gtscloud.oilpainter.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.config
{
    /// <summary>
    /// 打印机记录实体
    /// </summary>
    class PrinterRecordModel : ObservablePropertyChangedModel
    {
        private PrinterDebugModel basic;
        private string worker;
        private string validateTime;
        private DateTime printDate = DateTime.Now;

        public PrinterRecordModel()
        {
            basic = new PrinterDebugModel();
            
        }

        private readonly static string DateFormat = "yyyy-MM-dd HH:mm";

        /// <summary>
        /// 获取和设置基本打印数据
        /// </summary>
        public PrinterDebugModel BasicModel
        {
            get { return basic; }
            set
            {
                basic = value;
                SendPropertyChangedEvent("BasicModel");
            }
        }

        /// <summary>
        /// 获取和设置操作员
        /// </summary>
        public string Operator
        {
            get { return worker; }
            set
            {
                worker = value;
                SendPropertyChangedEvent("Operator");
            }
        }

        /// <summary>
        /// 获取打印日期
        /// </summary>
        public string PrintDate
        {
            get
            {
                return printDate.ToString(DateFormat);
            }
            set { printDate = DateTime.Parse(value); }
        }

        /// <summary>
        /// 获取有效截止日期
        /// </summary>
        public string DeadDate
        {
            get
            {
                var dead = printDate.Add(new TimeSpan(basic.ValidateTime, 0, 0));
                return dead.ToString(DateFormat);
            }
            private set { }
        }
    }
}
