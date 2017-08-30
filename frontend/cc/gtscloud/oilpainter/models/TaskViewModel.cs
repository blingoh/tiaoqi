using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace frontend.cc.gtscloud.oilpainter.models
{
    /// <summary>
    /// 原油重量信息
    /// </summary>
    public class OilWeightInfo : ObservablePropertyChangedModel
    {
        private double plan;
        private double actual;
        /// <summary>
        /// 获取或设置计划配重
        /// </summary>
        public Double PlanWeight
        {
            get
            {
                return plan;
            }
            set
            {
                plan = value;
                SendPropertyChangedEvent("PlanWeight");
                SendPropertyChangedEvent("DifferWeight");
            }
        }
        /// <summary>
        /// 获取或设置实际配重
        /// </summary>
        public Double ActualWeight
        {
            get
            {
                return actual;
            }
            set
            {
                actual = value;
                SendPropertyChangedEvent("ActualWeight");
                SendPropertyChangedEvent("DifferWeight");
            }
        }
        /// <summary>
        /// 获取差重
        /// </summary>
        public Double DifferWeight
        {
            get
            {
                return PlanWeight - ActualWeight;
            }
        }
    }
    /// <summary>
    /// 各剂料信息
    /// </summary>
    public class MaterialInfo : ObservablePropertyChangedModel
    {
        private string materialNumber;
        private string batchNumber;
        private double currentBanlanceWeight;
        private double finalWeight;
        private double emptyBucketWeight;
        private double standardUp = 20;
        private double standardLow;
        
        private string type;

        public static SolidColorBrush Yellow = new SolidColorBrush(Color.FromArgb(255, 255, 152, 0));
        public static SolidColorBrush Green = new SolidColorBrush(Color.FromArgb(255, 76, 175, 80));
        public static SolidColorBrush Gray = new SolidColorBrush(Color.FromArgb(255, 66, 66, 66));
        public static SolidColorBrush Red = new SolidColorBrush(Color.FromArgb(255, 244, 67, 54));

        public MaterialInfo(string type)
        {
            this.type = type;
        }

        /// <summary>
        /// 获取或设置原料号
        /// </summary>
        public string MaterialNumber
        {
            get
            {
                return materialNumber;
            }
            set
            {
                materialNumber = value;
                SendPropertyChangedEvent("MaterialNumber");
            }
        }
        /// <summary>
        /// 获取或设置批次号
        /// </summary>
        public string BatchNumber
        {
            get
            {
                return batchNumber;
            }
            set
            {
                batchNumber = value;
                SendPropertyChangedEvent("BatchNumber");
            }
        }
        /// <summary>
        /// 获取或设置上一次秤重
        /// </summary>
        public double LastBalanceWeight
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置当前称重(KG)
        /// </summary>
        public double CurrentBalanceWeight
        {
            get
            {
                return currentBanlanceWeight;
            }
            set
            {
                currentBanlanceWeight = value;
                SendPropertyChangedEvent("CurrentBalanceWeight");
                SendPropertyChangedEvent("CurrentMargin");
                SendPropertyChangedEvent("CurrentRate");
                SendPropertyChangedEvent("CurrentColor");
            }
        }
        /// <summary>
        /// 获取或设置最终原料重量
        /// </summary>
        public double FinalWeight
        {
            get
            {
                return finalWeight;
            }
            set
            {
                finalWeight = value;
                SendPropertyChangedEvent("FinalWeight");
            }
        }
        /// <summary>
        /// 获取或设置空桶重量(G)
        /// </summary>
        public double EmptyBucketWeight
        {
            get
            {
                return emptyBucketWeight;
            }
            set
            {
                emptyBucketWeight = value;
                SendPropertyChangedEvent("EmptyBucketWeight");
            }
        }
        /// <summary>
        /// 获取或设置标准上限
        /// </summary>
        public double StandardUp
        {
            get
            {
                return Math.Round(standardUp, 3);
            }
            set
            {
                standardUp = value;
                SendPropertyChangedEvent("StandardUp");
                SendPropertyChangedEvent("CurrentMargin");
                SendPropertyChangedEvent("CurrentRate");
                SendPropertyChangedEvent("CurrentColor");
            }
        }
        /// <summary>
        /// 获取或设置标准下限
        /// </summary>
        public double StandardLow
        {
            get
            {
                return Math.Round(standardUp, 3);
            }
            set
            {
                standardLow = value;
                SendPropertyChangedEvent("StandardLow");
                SendPropertyChangedEvent("CurrentMargin");
                SendPropertyChangedEvent("CurrentRate");
                SendPropertyChangedEvent("CurrentColor");
            }
        }
        /// <summary>
        /// 获取当前margin
        /// </summary>
        public Thickness CurrentMargin
        {
            get
            {
                var h = 240;
                if (0 == StandardUp)
                {
                    return new Thickness(0, h, 0, 0);
                }
                double rate = CurrentBalanceWeight / StandardUp;
                double actualH = rate * h; // 实际高度
                var marginTop = h - actualH;
                marginTop = marginTop < 0 ? 0 : marginTop;
                return new Thickness(0, marginTop, 0, 0);
            }
        }
        
        /// <summary>
        /// 获取当前比例
        /// </summary>
        public string CurrentRate
        {
            get
            {
                var h = 240;
                var contentH = h - CurrentMargin.Top;
                if (0 == contentH)
                {
                    return 0 + " %";
                }
                else
                {
                    var low = StandardLow;
                    if (0 == low)
                    {
                        low = StandardUp;
                    }
                    if (0 == low)
                    {
                        return 0 + "%";
                    }
                    var rate = CurrentBalanceWeight / low;
                    return (Math.Round(rate * 100, 2)).ToString("0.00") + "%";
                }
            }
        }

        private Brush currentColor = null;
        /// <summary>
        /// 当前颜色
        /// </summary>
        public Brush CurrentColor
        {
            get
            {
                var rate = CurrentRate;
                rate = rate.Replace("%", "");
                var doubleRate = double.Parse(rate);
                
                // 约定，上限不为0，下限为0的为主剂
                // 下限与上限相等为固化剂
                // 上限与下限不等为稀释剂
                if (PartTypeConstant.Main == type) // 主剂
                {
                    if (98 > doubleRate)
                    {
                        return Yellow;
                    }
                    else if (98 <= doubleRate && 102 >= doubleRate)
                    {
                        return Green;
                    }
                    else
                    {
                        return Red;
                    }
                }
                else if (PartTypeConstant.GuHua == type) // 固化剂
                {
                    var value = (doubleRate / 100.0) * StandardLow;
                    var gray = StandardLow * 0.9;
                    var yellow = StandardLow * 0.98;
                    var green = StandardUp * 1.02;
                    if (yellow >= value)
                    {
                        return Yellow; // 黄灯
                    }
                    else if (green >= value)
                    {
                        return Green; // 绿灯
                    }
                    else
                    {
                        return Red; // 红灯
                    }
                }
                else // 稀释剂
                {
                    var value = (doubleRate / 100.0) * StandardLow;
                    
                    if (value < StandardLow)
                    {
                        return Yellow;
                    }
                    else if (StandardLow <= value && StandardUp >= value)
                    {
                        return Green;
                    }
                    else
                    {
                        return Red;
                    }
                }
                
            }
        }
    }

    /// <summary>
    /// 调漆任务的界面数据模型实体
    /// </summary>
    public class TaskViewModel : ObservablePropertyChangedModel
    {
        private string worktime;
        /// <summary>
        /// 获取或设置班次信息
        /// </summary>
        public string WorkTime
        {
            get
            {
                return worktime;
            }
            set
            {
                worktime = value;
                SendPropertyChangedEvent("WorkTime");
            }
        }
        private string productLine;
        /// <summary>
        /// 获取或设置产线信息
        /// </summary>
        public string ProductLine
        {
            get
            {
                return productLine;
            }
            set
            {
                productLine = value;
                SendPropertyChangedEvent("ProductLine");
            }
        }
        private BomQueryModel bomInfo;
        /// <summary>
        /// 获取或设置机种信息
        /// </summary>
        public BomQueryModel MachineType
        {
            get
            {
                return bomInfo;
            }
            set
            {
                bomInfo = value;
                SendPropertyChangedEvent("MachineType");
            }
        }
        
        private OilWeightInfo oilWeight;
        /// <summary>
        /// 获取或设置原油的配重信息
        /// </summary>
        public OilWeightInfo OilWeight
        {
            get { return oilWeight; }
            set
            {
                oilWeight = value;
                SendPropertyChangedEvent("OilWeight");
            }
        }
        
        private MaterialInfo mainMaterialInfo;
        /// <summary>
        /// 获取或设置主剂料信息
        /// </summary>
        public MaterialInfo MainMetiralInfo
        {
            get
            {
                return mainMaterialInfo;
            }

            set
            {
                mainMaterialInfo = value;
                SendPropertyChangedEvent("MainMetiralInfo");
            }
        }
        private MaterialInfo guhuaMaterialInfo;
        /// <summary>
        /// 获取或设置固化剂信息
        /// </summary>
        public MaterialInfo GuhuaMaterialInfo
        {
            get
            {
                return guhuaMaterialInfo;
            }
            set
            {
                guhuaMaterialInfo = value;
                SendPropertyChangedEvent("GuhuaMaterialInfo");
            }
        }
        private MaterialInfo xishiMaterialInfo;
        /// <summary>
        /// 获取或设置稀释剂信息
        /// </summary>
        public MaterialInfo XishiMaterialInfo
        {
            get
            {
                return xishiMaterialInfo;
            }
            set
            {
                xishiMaterialInfo = value;
                SendPropertyChangedEvent("XishiMaterialInfo");
            }
        }

        private ITaskState state;
        /// <summary>
        /// 当前任务状态
        /// </summary>
        public ITaskState CurrentState
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                SendPropertyChangedEvent("CurrentState");
            }
        }
        
        /// <summary>
        /// 获取或设置BOM
        /// </summary>
        public BomInfoModel Bom
        {
            get; set;
        }

        /// <summary>
        /// 存储在数据库中的任务模型
        /// </summary>
        public TaskModel TaskStored
        {
            get;set;
        }
    }
}
