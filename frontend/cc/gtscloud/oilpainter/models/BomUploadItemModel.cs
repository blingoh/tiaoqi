using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.models
{
    public class BomUploadItemModel : ObservablePropertyChangedModel
    {
        private static Dictionary<int, string> fieldMap = new Dictionary<int, string>();
        /// <summary>
        /// 初始化映射
        /// </summary>
        public static void InitFieldMap()
        {
            // 处理映射关系
            fieldMap.Clear();
            fieldMap.Add(0, "Customer");
            fieldMap.Add(1, "MachineType");
            fieldMap.Add(2, "Supplier");
            fieldMap.Add(3, "Color");
            fieldMap.Add(4, "MainMeterialOne");
            fieldMap.Add(5, "MainMeterialTwo");
            fieldMap.Add(6, "MainMeterialThree");
            fieldMap.Add(7, "GuhuaOne");
            fieldMap.Add(8, "GuhuaTwo");
            fieldMap.Add(9, "GuhuaThree");
            fieldMap.Add(10, "GuhuaRate");
            fieldMap.Add(11, "XishiOne");
            fieldMap.Add(12, "XishiTwo");
            fieldMap.Add(13, "XishiThree");
            fieldMap.Add(14, "XishiUp");
            fieldMap.Add(15, "XishiLow");
            fieldMap.Add(16, "OilSpeedUp");
            fieldMap.Add(17, "OilSpeedLow");
            fieldMap.Add(18, "WBMS");
            fieldMap.Add(19, "ValidHours");
        }

        public BomUploadItemModel()
        {
            InitFieldMap();
        }

        /// <summary>
        /// 获取映射字典
        /// </summary>
        public static Dictionary<int, string> FieldMap
        {
            get { return fieldMap; }
        }

        /// <summary>
        /// 获取或设置客户名
        /// </summary>
        public string Customer
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置机种名
        /// </summary>
        public string MachineType
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置供应商
        /// </summary>
        public string Supplier
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置颜色
        /// </summary>
        public string Color
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置主剂料1
        /// </summary>
        public string MainMeterialOne
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置主剂料2
        /// </summary>
        public string MainMeterialTwo
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置主剂料3
        /// </summary>
        public string MainMeterialThree
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置固化剂1
        /// </summary>
        public string GuhuaOne
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置固化剂2
        /// </summary>
        public string GuhuaTwo
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置固化剂3
        /// </summary>
        public string GuhuaThree
        {
            get; set;
        }

        /// <summary>
        /// 获取或设置固化剂比例
        /// </summary>
        public string GuhuaRate
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置稀释剂1
        /// </summary>
        public string XishiOne
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置稀释剂2
        /// </summary>
        public string XishiTwo
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置稀释剂3
        /// </summary>
        public string XishiThree
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置稀释剂比例上限
        /// </summary>
        public string XishiUp
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置稀释剂比例下限
        /// </summary>
        public string XishiLow
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置油漆黏度上限
        /// </summary>
        public string OilSpeedUp
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置油漆黏度下限
        /// </summary>
        public string OilSpeedLow
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置网布目数
        /// </summary>
        public string WBMS
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置有效时间
        /// </summary>
        public string ValidHours
        {
            get;set;
        }
    }
}
