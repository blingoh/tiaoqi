using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao.impl
{
    /// <summary>
    /// 用户持久层
    /// </summary>
    class UserDaoImpl : IUserDao
    {
        private readonly static string SQL_SELECT_USER_BY_USERNAME = @"FindUserByUsername";
        private readonly static string SQL_UPDATE_USER_PASSWORD = "UpdateUserPassword";
        private readonly static string SQL_SELECT_ALL_USERS = "FindAllUsers";
        private readonly static string SQL_SELECT_ALL_RIGHTS = "FindAllRights";
        private readonly static string SQL_INSERT_NEW_USER = "InsertNewUser";
        private readonly static string SQL_DELETE_USER = "DeleteUser";
        private readonly static string SQL_UPDATE_USER_RIGHT = "UpdateUserRight";

        /// <summary>
        /// 根据用户名查询用户
        /// </summary>
        /// <param name="username">要查询的用户名</param>
        /// <returns>用户名对应的用户实体，不存在返回null</returns>
        public SecurityUserModel FindUserByUsername(string username)
        {
            ISqlMapper mapperInstance = SingletonSqlMapper.Instance();

            if (null == mapperInstance)
            {
                return null;
            }
            
            try
            {
                SecurityUserModel user = mapperInstance.QueryForObject<SecurityUserModel>(SQL_SELECT_USER_BY_USERNAME, username);
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
        
        /// <summary>
        /// 更新用户密码
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">新密码</param>
        /// <returns>若修改成功，则返回null，若失败会返回其原因或异常消息</returns>
        public string UpdateUserPassword(string username, string password)
        {
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            try
            {
                SecurityUserModel user = new SecurityUserModel();
                user.UserName = username;
                user.Password = password;

                mapper.BeginTransaction();
                int row = mapper.Update(SQL_UPDATE_USER_PASSWORD, user);
                mapper.CommitTransaction();
                return null;
            }
            catch
            {
                mapper.RollBackTransaction();
                string tip = "不可预知的错误，请稍后再试！"; // 结果
                return tip;
            }
        }

        /// <summary>
        /// 查询所有的存在的用户
        /// </summary>
        /// <returns>数据库当前所有用户列表</returns>
        public IList<SecurityUserModel> FindAllExistingUsers()
        {
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            return mapper.QueryForList<SecurityUserModel>(SQL_SELECT_ALL_USERS, null);
        }

        /// <summary>
        /// 查询现有的所有用户可能的权限
        /// </summary>
        /// <returns>用户权限列表</returns>
        public IList<string> SelectAllRights()
        {
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            return mapper.QueryForList<string>(SQL_SELECT_ALL_RIGHTS, null);
        }

        /// <summary>
        /// 插入新用户
        /// </summary>
        /// <param name="user">待插入的用户实体</param>
        /// <returns>若插入成功，则为null，否则将表示其失败原因</returns>
        public string InsertNewUser(SecurityUserModel user)
        {
            string tip = "相关请求已经提交，但是可能并未造成影响！";
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            try
            {
                mapper.BeginTransaction();
                mapper.Insert(SQL_INSERT_NEW_USER, user); // 插入，并接受主键
                mapper.CommitTransaction();
                return null;
            }
            catch (Exception ex)
            {
                tip += "\n" + ex.Message;
                mapper.RollBackTransaction();
                return tip;
            }
        }

        /// <summary>
        /// 根据用户名删除用户
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns>若删除成功，则为null，否则将表示其删除失败的原因</returns>
        public string DeleteUser(string username)
        {
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            string tip = "所有相关请求已经提交，但是可能并未造成相关影响！";
            try
            {
                mapper.BeginTransaction();
                int row = mapper.Delete(SQL_DELETE_USER, username);
                mapper.CommitTransaction();

                if (0 >= row)
                {
                    return tip;  // 未产生任何更改
                }
                else
                {
                    return null; // 无错误
                }
            }
            catch (Exception ex)
            {
                mapper.RollBackTransaction();
                tip = ex.Message;
                return tip;
            }
        }

        public string UpdateUserRight(SecurityUserModel user)
        {
            string tip = "缺少必要的信息，拒绝请求！";
            if (null == user || null == user.UserName)
            {
                return tip;
            }

            ISqlMapper mapper = SingletonSqlMapper.Instance();
            int row = mapper.Update(SQL_UPDATE_USER_RIGHT, user);

            if (0 >= row)
            {
                tip = "相关的请求已经提交，但是可能并未产生任何修改！";
                return tip;
            }
            else
            {
                return null;
            }
        }
    }
}
