using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao.model
{
    /// <summary>
    /// 产品注册实体
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// 获取或设置用户信息，主机信息
        /// </summary>
        public string UserInfo
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置序列号
        /// </summary>
        public string SerialNumber
        {
            get;set;
        }
    }
}
