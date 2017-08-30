using frontend.cc.gtscloud.oilpainter.dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao
{
    interface IUserDao
    {
        /// <summary>
        /// 根据用户名查询用户
        /// </summary>
        /// <param name="username">要查询的用户名</param>
        /// <returns>用户名对应的用户实体，不存在返回null</returns>
        SecurityUserModel FindUserByUsername(string username);

        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">新密码</param>
        /// <returns>若修改成功，则返回null，若失败会返回其原因或异常消息</returns>
        string UpdateUserPassword(string username, string password);

        /// <summary>
        /// 查询所有的存在的用户
        /// </summary>
        /// <returns>数据库当前所有用户列表</returns>
        IList<SecurityUserModel> FindAllExistingUsers();

        /// <summary>
        /// 查询现有的所有用户可能的权限
        /// </summary>
        /// <returns>用户权限列表</returns>
        IList<string> SelectAllRights();

        /// <summary>
        /// 插入新用户
        /// </summary>
        /// <param name="user">待插入的用户实体</param>
        /// <returns>若插入成功，则为null，否则将表示其失败原因</returns>
        string InsertNewUser(SecurityUserModel user);

        /// <summary>
        /// 根据用户名删除用户
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>若删除成功，则为null，否则将表示其删除失败的原因</returns>
        string DeleteUser(string username);

        /// <summary>
        /// 更新用户权限信息到数据库
        /// </summary>
        /// <param name="user">要更新的用户</param>
        /// <returns>更新成功，则为null，否则为失败的原因</returns>
        string UpdateUserRight(SecurityUserModel user);
    }
}
