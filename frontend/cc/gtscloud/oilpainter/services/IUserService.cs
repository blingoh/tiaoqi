using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.services
{
    /// <summary>
    /// 用户服务接口
    /// </summary>
    interface IUserService
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="user">要登录的用户</param>
        /// <returns>若登录成功则返回null，否则返回失败原因</returns>
        string Login(SecurityUserModel user);
        
        /// <summary>
        /// 获取所有用户，并将其密码进行加密
        /// </summary>
        /// <returns>所有用户列表</returns>
        IList<SecurityUserModel> AllUsersEncrypt();

        /// <summary>
        /// 用户密码修改
        /// </summary>
        /// <param name="user">要修改密码的用户</param>
        /// <param name="oldPassword">原始密码</param>
        /// <returns>修改成功，返回null，失败则指示失败原因或异常消息</returns>
        string ChangePassword(SecurityUserModel user, string oldPassword);

        /// <summary>
        /// 所有用户权限
        /// </summary>
        /// <returns>用户权限列表</returns>
        IList<string> AllUserRights();

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="delUser">待删除的用户</param>
        /// <returns>若删除成功，则为null，若删除失败则为失败原因</returns>
        string DeleteUser(SecurityUserModel delUser);

        /// <summary>
        /// 注册新用户
        /// </summary>
        /// <param name="user">待注册用户</param>
        /// <returns>若添加记录成功，则为null，若失败则指示失败原因</returns>
        string RegisterUser(SecurityUserModel user);

        /// <summary>
        /// 修改用户职责信息
        /// </summary>
        /// <param name="user">要更新的用户信息</param>
        /// <returns>若修改成功，则为null，否则指示失败的原因</returns>
        string ChangeUserRight(SecurityUserModel user);
    }
}
