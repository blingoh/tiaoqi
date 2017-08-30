using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao.model
{
    /// <summary>
    /// 任务实体
    /// </summary>
    public class TaskModel
    {
        /// <summary>
        /// 获取或设置作业ID
        /// </summary>
        public string TaskID
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置BOMID
        /// </summary>
        public string BomId
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置机种/品名
        /// </summary>
        public string ProductName
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置班次
        /// </summary>
        public string ShiftName
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置产线
        /// </summary>
        public string LineName
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置客户名
        /// </summary>
        public string CustomerName
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置厂商
        /// </summary>
        public string MainPartVendor
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置主剂料号
        /// </summary>
        public string MainPartNumber
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置主剂料批次号
        /// </summary>
        public string MainLotNumber
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置计划主剂料配重
        /// </summary>
        public Decimal TargetMainPartWeight
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置实际主剂料配重
        /// </summary>
        public decimal ActualMainPartWeight
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置固化剂厂商
        /// </summary>
        public string GuHuaPartVendor
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置固化剂产品料号
        /// </summary>
        public string GuHuaPartNumber
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置固化剂批次号
        /// </summary>
        public string GuHuaLotNumber
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置固化剂下限
        /// </summary>
        public decimal GuHuaWeightSPECL
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置固化剂上限
        /// </summary>
        public decimal GuHuaWeightSPECU
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置固化剂实际重量
        /// </summary>
        public decimal GuHuaActualWeight
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置固化剂比例
        /// </summary>
        public decimal GuHuaRate
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置稀释剂厂商
        /// </summary>
        public string XiShiVendor
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置稀释剂料号
        /// </summary>
        public string XiShiPartNumber
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置稀释剂批次号
        /// </summary>
        public string XiShiLotNumber
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置稀释剂下限
        /// </summary>
        public decimal XiShiWeightSPECL
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置稀释剂上限
        /// </summary>
        public decimal XiShiWeightSPECU
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置稀释剂实际重量
        /// </summary>
        public decimal XiShiActualWeight
        {
            get;set;
        }
        /// <summary>
        /// 稀释剂比例
        /// </summary>
        public decimal XiShiRate
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置油漆流速
        /// </summary>
        public decimal ActualSpeed
        {
            get;set;
        }
        /// <summary>
        /// 作业状态,7表示完成
        /// </summary>
        public int Status
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置主剂料容器重量
        /// </summary>
        public decimal MainHolderWeight
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置固化剂容器重量
        /// </summary>
        public decimal GuHuaHolderWeight
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置稀释剂容器重量
        /// </summary>
        public decimal XiShiHolderWeight
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置固化剂容差比
        /// </summary>
        public int GuHuaRangeBase
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置搅拌时间
        /// </summary>
        public int ActualDelaySeconds
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置操作员
        /// </summary>
        public string Operator
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置作业时间
        /// </summary>
        public DateTime SysDateTime
        {
            get;set;
        }

        private DateTime startDate = DateTime.Now.Subtract(new TimeSpan(7, 0, 0,0));
        private DateTime deadDate = DateTime.Now;
        /// <summary>
        /// 获取或设置开始时间
        /// </summary>
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
        /// <summary>
        /// 获取或设置截止时间
        /// </summary>
        public DateTime DeadDate
        {
            get
            {
                return deadDate;
            }
            set
            {
                deadDate = value;
            }
        }
        /// <summary>
        /// 获取或设置机种/品名
        /// </summary>
        public string PartNumber
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置厂商
        /// </summary>
        public string Supplier
        {
            get;set;
        }
    }
}
