using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.config
{

    /// <summary>
    /// 调漆参数实体
    /// </summary>
    class OilSpinConfigModel
    {
        /// <summary>
        /// 获取或设置容差比
        /// </summary>
        public int DistanceRate
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置是否自动计算容器重量
        /// </summary>
        public bool AutoCalcWeight
        {
            get;set;
        }
    }
}
