using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.models
{
    /// <summary>
    /// BOM查询实体
    /// </summary>
    public class BomQueryModel : ObservablePropertyChangedModel
    {
        private string customer;
        private string machineType;
        private string mainMaterial;
        private string manufacturer;
        private string paintType;
        private string bomid;
        public string BomId
        {
            get { return bomid; }
            set { bomid = value;SendPropertyChangedEvent("BomId"); }
        }
        /// <summary>
        /// 获取或设置客户名
        /// </summary>
        public string Customer
        {
            get { return customer; }
            set
            {
                customer = value;
                SendPropertyChangedEvent("Customer");
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
        /// 获取或设置主剂料号
        /// </summary>
        public string MainMaterial
        {
            get { return mainMaterial; }
            set
            {
                mainMaterial = value;
                SendPropertyChangedEvent("MainMaterial");
            }
        }
        /// <summary>
        /// 获取或设置厂商
        /// </summary>
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                manufacturer = value;
                SendPropertyChangedEvent("Manufacturer");
            }
        }
        /// <summary>
        /// 获取或设置喷漆类型
        /// </summary>
        public string PaintType
        {
            get { return paintType; }
            set
            {
                paintType = value;
                SendPropertyChangedEvent("PaintType");
            }
        }
    }
}
