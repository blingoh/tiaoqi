using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao.model
{
    /// <summary>
    /// 生产线实体
    /// </summary>
    public class ProductLineModel
    {
        /// <summary>
        /// 获取或设置生产线编码
        /// </summary>
        public string LineCode
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置生产线名
        /// </summary>
        public string LineName
        {
            get;set;
        }
    }

}
