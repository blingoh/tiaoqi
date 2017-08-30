using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frontend.cc.gtscloud.oilpainter.models;
using frontend.cc.gtscloud.oilpainter.dao.impl;
using frontend.cc.gtscloud.oilpainter.dao;
using frontend.cc.gtscloud.oilpainter.dao.model;
using System.Security.Cryptography;

namespace frontend.cc.gtscloud.oilpainter.services.impl
{
    /// <summary>
    /// 用户服务实现类
    /// </summary>
    class UserServiceImpl : IUserService
    {
        IUserDao userDao = new UserDaoImpl();

        private readonly static string ERROR_NOTEMPTY_USERNAME = "用户名不能为空！";
        private readonly static string ERROR_NOTEQUAL_USERPWD = "用户名或密码不正确！";
        
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="user">要登录的用户</param>
        /// <returns>若登录成功则返回null，否则返回失败原因</returns>
        public string Login(SecurityUserModel user)
        {
            // 查询出用户
            if (null == user || null == user.UserName)
            {
                return ERROR_NOTEMPTY_USERNAME; // 参数为空
            }

            return FindAndValidateUser(user);
        }

        /// <summary>
        /// 获取所有用户，并将其密码进行加密
        /// </summary>
        /// <returns>所有用户列表</returns>
        public IList<SecurityUserModel> AllUsersEncrypt()
        {
            // 返回查找结果
            IList<SecurityUserModel> allUsers = userDao.FindAllExistingUsers();

            if (null == allUsers)
            {
                // 空结果集合
                return allUsers;
            }

            // 将用户信息加密起来返回
            foreach (var user in allUsers)
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                user.Password = BitConverter.ToString(bytes);
            }

            return allUsers;
        }

        /// <summary>
        /// 用户密码修改
        /// </summary>
        /// <see cref="cc.gtscloud.oilpainter.services.IUserService"/>
        /// <param name="user">要修改密码的用户</param>
        /// <param name="oldPassword">原始密码</param>
        /// <returns>修改成功，返回null，失败则指示失败原因或异常消息</returns>
        public string ChangePassword(SecurityUserModel user, string oldPassword)
        {
            // 查找用户
            SecurityUserModel oldUser = new SecurityUserModel();
            oldUser.UserName = user.UserName;
            oldUser.Password = oldPassword;

            string validateStr = FindAndValidateUser(oldUser); // 验证用户

            if (null != validateStr)
            {
                return validateStr; // 验证失败
            }

            // 更新密码
            return userDao.UpdateUserPassword(user.UserName, user.Password);
        }

        // 查找并验证用户
        private string FindAndValidateUser(SecurityUserModel user)
        {
            SecurityUserModel findUser = userDao.FindUserByUsername(user.UserName.Trim());

            if (null == findUser)
            {
                return ERROR_NOTEQUAL_USERPWD; // 未存在用户
            }

            if (!findUser.Password.Equals(user.Password))
            {
                return ERROR_NOTEQUAL_USERPWD; // 密码不等
            }

            return null;
        }

        /// <summary>
        /// 所有用户权限
        /// </summary>
        /// <returns>用户权限列表</returns>
        public IList<string> AllUserRights()
        {
            return userDao.SelectAllRights();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="delUser">待删除的用户</param>
        /// <returns>若删除成功，则为null，若删除失败则为失败原因</returns>
        public string DeleteUser(SecurityUserModel delUser)
        {
            if (null == delUser || null == delUser.UserName)
            {
                return "未指定要删除的用户";
            }

            return userDao.DeleteUser(delUser.UserName);
        }

        /// <summary>
        /// 注册新用户
        /// </summary>
        /// <param name="user">待注册用户</param>
        /// <returns>若添加记录成功，则为null，若失败则指示失败原因</returns>
        public string RegisterUser(SecurityUserModel user)
        {
            string tip = "缺少了必要的信息";

            if (null == user || null == user.UserName || null == user.Password)
            {
                return tip; // 缺少关键信息，拒绝添加
            }

            if (null == user.Right)
            {
                user.Right = "普通用户"; // 默认普通用户
            }

            // 查询已有用户
            var findUser = userDao.FindUserByUsername(user.UserName);

            if (null != findUser)
            {
                tip = "用户已存在，无法继续添加";
                return tip;
            }

            return userDao.InsertNewUser(user);
        }

        public string ChangeUserRight(SecurityUserModel user)
        {
            return userDao.UpdateUserRight(user);
        }
    }
}
