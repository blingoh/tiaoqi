using frontend.cc.gtscloud.oilpainter.dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.services
{
    /// <summary>
    /// 客户服务类接口
    /// </summary>
    interface ICustomerService
    {
        /// <summary>
        /// 查询所有的客户
        /// </summary>
        /// <returns>客户列表</returns>
        IList<CustomerModel> FindAllCustomers();

        /// <summary>
        /// 根据客户名查询客户
        /// </summary>
        /// <param name="name">客户名</param>
        /// <returns>客户列表</returns>
        IList<CustomerModel> FindCustomersForName(string name);

        /// <summary>
        /// 根据客户编号查询客户
        /// </summary>
        /// <param name="code">客户编号</param>
        /// <returns>客户</returns>
        CustomerModel FindCustomerForCode(string code);

        /// <summary>
        /// 增加新客户
        /// </summary>
        /// <param name="customer">要新增的客户实体</param>
        /// <returns>增加成功为null，否则为失败原因</returns>
        string AddCustomer(CustomerModel customer);

        /// <summary>
        /// 删除指定客户
        /// </summary>
        /// <param name="code">客户编号</param>
        /// <returns>删除成功为null，否则为失败原因</returns>
        string RemoveCustomer(string code);

        /// <summary>
        /// 更改客户名
        /// </summary>
        /// <param name="customer">要更改的客户编号及新客户名</param>
        /// <returns>更改成功为null，否则为失败原因</returns>
        string ModifyCustomerName(CustomerModel customer);
    }
}
