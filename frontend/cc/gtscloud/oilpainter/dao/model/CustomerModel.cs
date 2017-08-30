using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao.model
{
    /// <summary>
    /// 客户实体
    /// </summary>
    public class CustomerModel
    {
        /// <summary>
        /// 获取或设置客户编号
        /// </summary>
        public string CustomerCode
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置客户名称
        /// </summary>
        public string CustomerName
        {
            get;set;
        }
    }
}
