using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.models
{
    public class ColumnHeaderModel : ObservablePropertyChangedModel, IObservable<ColumnHeaderModel>
    {
        private bool isNeedProductLine = true;

        private IList<IObserver<ColumnHeaderModel>> observers;

        public ColumnHeaderModel()
        {
            observers = new List<IObserver<ColumnHeaderModel>>(); // 使用观察者列表
        }
        public bool IsNeedProductLine
        {
            get
            {
                return isNeedProductLine;
            }
            set
            {
                isNeedProductLine = value;
                SendPropertyChangedEvent("IsNeedProductLine");
                foreach(var observer in observers)
                {
                    observer.OnNext(this);
                }
            }
        }

        private bool isNeedWorkTime = true;
        public bool IsNeedWorkTime
        {
            get
            {
                return isNeedWorkTime;
            }
            set
            {
                isNeedWorkTime = value;
                SendPropertyChangedEvent("IsWorkTime");
                foreach (var observer in observers)
                {
                    observer.OnNext(this);
                }
            }
        }

        public IDisposable Subscribe(IObserver<ColumnHeaderModel> observer)
        {
            observers.Add(observer);
            return null;
        }
        
        private bool isNeedProductName = true;
        /// <summary>
        /// 机种
        /// </summary>
        public bool IsNeedProductName
        {
            get
            {
                return isNeedProductName;
            }
            set
            {
                isNeedProductName = value;
                SendPropertyChangedEvent("IsNeedProductName");
            }
        }

        private bool isNeedManufacturer = true;
        /// <summary>
        /// 厂商
        /// </summary>
        public bool IsNeedManufacturer
        {
            get
            {
                return isNeedManufacturer;
            }
            set
            {
                isNeedManufacturer = value;
                SendPropertyChangedEvent("IsNeedManufacturer");
            }
        }

        private bool isNeedCustomer = true;
        /// <summary>
        /// 客户
        /// </summary>
        public bool IsNeedCustomer
        {
            get
            {
                return isNeedCustomer;
            }
            set
            {
                isNeedCustomer = value;
                SendPropertyChangedEvent("IsNeedCustomer");
            }
        }

        private bool isNeedMainMaterialManufacturer = true;
        /// <summary>
        /// 主剂生产厂商
        /// </summary>
        public bool IsNeedMainMaterialManufacturer
        {
            get
            {
                return isNeedMainMaterialManufacturer;
            }
            set
            {
                isNeedMainMaterialManufacturer = value;
                SendPropertyChangedEvent("IsNeedMainMaterialManufacturer");
            }
        }

        private bool isNeedMainMaterialNumber = true;
        /// <summary>
        /// 主剂料号
        /// </summary>
        public bool IsNeedMainMaterialNumber
        {
            get
            {
                return isNeedMainMaterialNumber;
            }
            set
            {
                isNeedMainMaterialNumber = value;
                SendPropertyChangedEvent("IsNeedMainMaterialNumber");
            }
        }

        private bool isNeedMainBatchNumber = true;
        /// <summary>
        /// 主剂批次号
        /// </summary>
        public bool IsNeedMainBatchNumber
        {
            get
            {
                return isNeedMainBatchNumber;
            }
            set
            {
                isNeedMainBatchNumber = value;
                SendPropertyChangedEvent("IsNeedMainBatchNumber");
            }
        }

        private bool isNeedMainWeight = true;
        /// <summary>
        /// 主剂重量
        /// </summary>
        public bool IsNeedMainWeight
        {
            get
            {
                return isNeedMainWeight;
            }
            set
            {
                isNeedMainWeight = value;
                SendPropertyChangedEvent("IsNeedMainWeight");
            }
        }

        private bool isNeedMainBucketWeight = true;
        /// <summary>
        /// 主剂容器重量
        /// </summary>
        public bool IsNeedMainBucketWeight
        {
            get
            {
                return isNeedMainBucketWeight;
            }
            set
            {
                isNeedMainBucketWeight = value;
                SendPropertyChangedEvent("IsNeedMainBucketWeight");
            }
        }

        private bool isNeedGuhuaManufacturer = true;
        /// <summary>
        /// 固化剂生产厂商
        /// </summary>
        public bool IsNeedGuhuaManufacturer
        {
            get
            {
                return isNeedGuhuaManufacturer;
            }
            set
            {
                isNeedGuhuaManufacturer = value;
                SendPropertyChangedEvent("IsNeedGuhuaManufacturer");
            }
        }

        private bool isNeedGuhuaNumber = true;
        /// <summary>
        /// 固化剂料号
        /// </summary>
        public bool IsNeedGuhuaNumber
        {
            get
            {
                return isNeedGuhuaNumber;
            }
            set
            {
                isNeedGuhuaNumber = value;
                SendPropertyChangedEvent("IsNeedGuhuaNumber");
            }
        }

        private bool isNeedGuhuaBatchNumber = true;
        /// <summary>
        /// 固化剂批次号
        /// </summary>
        public bool IsNeedGuhuaBatchNumber
        {
            get
            {
                return isNeedGuhuaBatchNumber;
            }
            set
            {
                isNeedGuhuaBatchNumber = value;
                SendPropertyChangedEvent("IsNeedGuhuaBatchNumber");
            }
        }

        private bool isNeedGuhuaWeight = true;
        /// <summary>
        /// 固化剂重量
        /// </summary>
        public bool IsNeedGuhuaWeight
        {
            get
            {
                return isNeedGuhuaWeight;
            }
            set
            {
                isNeedGuhuaWeight = value;
                SendPropertyChangedEvent("IsNeedGuhuaWeight");
            }
        }

        private bool isNeedGuhuaBucketWeight = true;
        /// <summary>
        /// 固化剂容器重量
        /// </summary>
        public bool IsNeedGuhuaBucketWeight
        {
            get
            {
                return isNeedGuhuaBucketWeight;
            }
            set
            {
                isNeedGuhuaBucketWeight = value;
                SendPropertyChangedEvent("IsNeedGuhuaBucketWeight");
            }
        }

        private bool isNeedGuhuaPlanRate = true;
        /// <summary>
        /// 固化剂设定添加比例
        /// </summary>
        public bool IsNeedGuhuaPlanRate
        {
            get
            {
                return isNeedGuhuaPlanRate;
            }
            set
            {
                isNeedGuhuaPlanRate = value;
                SendPropertyChangedEvent("IsNeedGuhuaPlanRate");
            }
        }

        private bool isNeedGuhuaActualRate = true;
        /// <summary>
        /// 固化剂实际添加比例
        /// </summary>
        public bool IsNeedGuhuaActualRate
        {
            get
            {
                return isNeedGuhuaActualRate;
            }
            set
            {
                isNeedGuhuaActualRate = value;
                SendPropertyChangedEvent("IsNeedGuhuaActualRate");
            }
        }

        private bool isNeedXishiManufacturer = true;
        /// <summary>
        /// 稀释剂生产厂商
        /// </summary>
        public bool IsNeedXishiManufacturer
        {
            get
            {
                return isNeedXishiManufacturer;
            }
            set
            {
                isNeedXishiManufacturer = value;
                SendPropertyChangedEvent("IsNeedXishiManufacturer");
            }
        }

        private bool isNeedXishiNumber = true;
        /// <summary>
        /// 稀释剂料号
        /// </summary>
        public bool IsNeedXishiNumber
        {
            get
            {
                return isNeedXishiNumber;
            }
            set
            {
                isNeedXishiNumber = value;
                SendPropertyChangedEvent("IsNeedXishiNumber");
            }
        }

        private bool isNeedXishiBucketWeight = true;
        /// <summary>
        /// 稀释剂容器重量
        /// </summary>
        public bool IsNeedXishiBucketWeight
        {
            get
            {
                return isNeedXishiBucketWeight;
            }
            set
            {
                isNeedXishiBucketWeight = value;
                SendPropertyChangedEvent("IsNeedXishiBucketWeight");
            }
        }

        private bool isNeedXishiBatchNumber = true;
        /// <summary>
        /// 稀释剂批次号
        /// </summary>
        public bool IsNeedXishiBatchNumber
        {
            get
            {
                return isNeedXishiBatchNumber;
            }
            set
            {
                isNeedXishiBatchNumber = value;
                SendPropertyChangedEvent("IsNeedXishiBatchNumber");
            }
        }

        private bool isNeedXishiPlanRateUp = true;
        /// <summary>
        /// 稀释剂设定比例上限
        /// </summary>
        public bool IsNeedXishiPlanRateUp
        {
            get
            {
                return isNeedXishiPlanRateUp;
            }
            set
            {
                isNeedXishiPlanRateUp = value;
                SendPropertyChangedEvent("IsNeedXishiPlanRateUp");
            }
        }

        private bool isNeedXishiPlanRateLow = true;
        /// <summary>
        /// 稀释剂设定比例下限
        /// </summary>
        public bool IsNeedXishiPlanRateLow
        {
            get
            {
                return isNeedXishiPlanRateLow;
            }
            set
            {
                isNeedXishiPlanRateLow = value;
                SendPropertyChangedEvent("IsNeedXishiPlanRateLow");
            }
        }

        private bool isNeedXishiWeight = true;
        /// <summary>
        /// 稀释剂重量
        /// </summary>
        public bool IsNeedXishiWeight
        {
            get
            {
                return isNeedXishiWeight;
            }
            set
            {
                isNeedXishiWeight = value;
                SendPropertyChangedEvent("IsNeedXishiWeight");
            }
        }

        private bool isNeedXishiActualRate = true;
        /// <summary>
        /// 稀释剂实际添加比例
        /// </summary>
        public bool IsNeedXishiActualRate
        {
            get
            {
                return isNeedXishiActualRate;
            }
            set
            {
                isNeedXishiActualRate = value;
                SendPropertyChangedEvent("IsNeedXishiActualRate");
            }
        }

        private bool isNeedBaudTime = true;
        /// <summary>
        /// 搅拌时间
        /// </summary>
        public bool IsNeedBaudTime
        {
            get
            {
                return isNeedBaudTime;
            }
            set
            {
                isNeedBaudTime = value;
                SendPropertyChangedEvent("IsNeedBaudTime");
            }
        }

        private bool isNeedOilSpeed = true;
        /// <summary>
        /// 油漆黏度（流速）
        /// </summary>
        public bool IsNeedOilSpeed
        {
            get
            {
                return isNeedOilSpeed;
            }
            set
            {
                isNeedOilSpeed = value;
                SendPropertyChangedEvent("IsNeedOilSpeed");
            }
        }
    }
}
