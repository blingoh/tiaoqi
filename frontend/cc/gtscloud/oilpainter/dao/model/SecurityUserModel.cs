using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao.model
{
    /// <summary>
    /// 用户信息实体
    /// </summary>
    public class SecurityUserModel
    {
        /// <summary>
        /// 获取或设置用户名
        /// </summary>
        public string UserName
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置密码
        /// </summary>
        public string Password
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置用户权限（职责）
        /// </summary>
        public string Right
        {
            get;set;
        }
    }
}
