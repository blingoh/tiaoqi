using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao.model
{
    /// <summary>
    /// 油漆类型实体
    /// </summary>
    public class OilPaintTypeModel
    {
        /// <summary>
        /// 油漆类型
        /// </summary>
        public string OilPaintType
        {
            get;set;
        }

        /// <summary>
        /// 描述信息
        /// </summary>
        public string Description
        {
            get;set;
        }
    }
}
