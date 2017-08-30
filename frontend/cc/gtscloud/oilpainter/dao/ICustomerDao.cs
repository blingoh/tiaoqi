using frontend.cc.gtscloud.oilpainter.dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao
{
    /// <summary>
    /// 客户DAO层接口
    /// </summary>
    interface ICustomerDao
    {
        /// <summary>
        /// 新增一个客户
        /// </summary>
        /// <param name="customer">要新增的客户实体</param>
        /// <returns>若新增失败则为失败原因，否则为null</returns>
        string InsertCustomer(CustomerModel customer);
        /// <summary>
        /// 更新客户名
        /// </summary>
        /// <param name="customer">要更改的客户名，并以用户编码作为唯一标识</param>
        /// <returns>若更新失败则为失败原因，否则为null</returns>
        string UpdateCustomerName(CustomerModel customer);

        /// <summary>
        /// 查询所有的客户列表
        /// </summary>
        /// <returns>现有的客户列表</returns>
        IList<CustomerModel> SelectAllCustomers();

        /// <summary>
        /// 根据客户编码查询唯一的客户
        /// </summary>
        /// <param name="code">要查询的客户编码</param>
        /// <returns>唯一的客户实体，未查询到则为null</returns>
        CustomerModel SelectCustomerWithCode(string code);

        /// <summary>
        /// 根据客户名查询客户
        /// </summary>
        /// <param name="name">要查询的客户名</param>
        /// <returns>符合要求的客户名</returns>
        IList<CustomerModel> SelectCustomersWithName(string name);

        /// <summary>
        /// 删除指定的客户
        /// </summary>
        /// <param name="code">要删除的客户编码</param>
        /// <returns>若删除失败则为失败原因，否则为null</returns>
        string DeleteCustomer(string code);
    }
}
