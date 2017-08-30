using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.config
{
    /// <summary>
    /// 数据库配置参数实体
    /// </summary>
    class DatabaseConfigModel
    {
        /// <summary>
        /// 获取或设置主机地址/域名
        /// </summary>
        public string Server
        {
            get;set;
        }

        /// <summary>
        /// 获取或设置用户名
        /// </summary>
        public string Username
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
    }
}
