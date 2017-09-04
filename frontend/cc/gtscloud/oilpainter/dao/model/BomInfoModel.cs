using frontend.cc.gtscloud.oilpainter.models;
using System;

namespace frontend.cc.gtscloud.oilpainter.dao.model
{
    /// <summary>
    /// BOM物料主信息
    /// </summary>
    [Serializable]
    public class BomInfoModel : ObservablePropertyChangedModel
    {
        private string bomid;
        private string customer;
        private string productName;
        private string supplier;
        private string oilPanintType;
        private decimal oilSpeedUp;
        private decimal guhuaPersent;
        private decimal xishiUpPersent;
        private decimal xishiLowPercent;
        private decimal oilSpeedLow;
        private int wbms;
        private int validateHours;
        /// <summary>
        /// 获取或设置BOMID
        /// </summary>
        public string BomId
        {
            get
            {
                return bomid;
            }
            set
            {
                bomid = value;
                SendPropertyChangedEvent("BomId");
            }
        }

        /// <summary>
        /// 获取或设置客户名
        /// </summary>
        public string CustomerName
        {
            get
            {
                return customer;
            }
            set
            {
                customer = value;
                SendPropertyChangedEvent("CustomerName");
            }
        }

        /// <summary>
        /// 获取或设置产品名称
        /// </summary>
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
                SendPropertyChangedEvent("ProductName");
            }
        }

        /// <summary>
        /// 获取或设置供应商
        /// </summary>
        public string Supplier
        {
            get
            {
                return supplier;
            }
            set
            {
                supplier = value;
                SendPropertyChangedEvent("Supplier");
            }
        }

        /// <summary>
        /// 获取或设置油漆类型
        /// </summary>
        public string OilPlaintType
        {
            get
            {
                return oilPanintType;
            }
            set
            {
                oilPanintType = value;
                SendPropertyChangedEvent("OilPlaintType");
            }
        }

        /// <summary>
        /// 获取或设置油漆速度上限
        /// </summary>
        public Decimal OilSpeedU
        {
            get
            {
                return oilSpeedUp;
            }
            set
            {
                oilSpeedUp = value;
                SendPropertyChangedEvent("OilSpeedU");
            }
        }

        /// <summary>
        /// 获取或设置固化剂比例
        /// </summary>
        public int GuHuaPercent
        {
            get
            {
                return (int)guhuaPersent;
            }
            set
            {
                guhuaPersent = value;
                SendPropertyChangedEvent("GuHuaPercent");
            }
        }

        /// <summary>
        /// 获取或设置稀释剂上限
        /// </summary>
        public int XiShiUpPercent
        {
            get
            {
                return (int)xishiUpPersent;
            }
            set
            {
                xishiUpPersent = value;
                SendPropertyChangedEvent("XiShiUpPercent");
            }
        }

        /// <summary>
        /// 获取或设置稀释剂下限
        /// </summary>
        public int XiShiLowPercent
        {
            get
            {
                return (int)xishiLowPercent;
            }
            set
            {
                xishiLowPercent = value;
                SendPropertyChangedEvent("XiShiLowPercent");
            }
        }

        /// <summary>
        /// 获取或设置油漆流速下限
        /// </summary>
        public Decimal OilSpeedL
        {
            get
            {
                return oilSpeedLow;
            }
            set
            {
                oilSpeedLow = value;
                SendPropertyChangedEvent("OilSpeedL");
            }
        }

        /// <summary>
        /// 获取或设置WBMS
        /// </summary>
        public int WBMS
        {
            get
            {
                return wbms;
            }
            set
            {
                wbms = value;
                SendPropertyChangedEvent("WBMS");
            }
        }

        /// <summary>
        /// 获取或设置合法时间
        /// </summary>
        public int ValidHours
        {
            get
            {
                return validateHours;
            }
            set
            {
                validateHours = value;
                SendPropertyChangedEvent("ValidHours");
            }
        }
    }
}
