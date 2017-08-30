using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.models
{
    public class UserModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get;set;
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get;set;
        }

        /// <summary>
        /// 权限
        /// </summary>
        public string Right
        {
            get;set;
        }

        /// <summary>
        /// 含参构造函数
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="right">用户权限</param>
        public UserModel(string username, string password, string right)
        {
            Password = password;
            UserName = username;
            Right = right;
        }

        /// <summary>
        /// 默认构造
        /// </summary>
        public UserModel()
        {

        }
    }
}
