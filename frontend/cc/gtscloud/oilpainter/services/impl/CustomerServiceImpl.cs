using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.dao.impl;
using frontend.cc.gtscloud.oilpainter.dao;

namespace frontend.cc.gtscloud.oilpainter.services.impl
{
    /// <summary>
    /// 客户服务类
    /// </summary>
    class CustomerServiceImpl : ICustomerService
    {
        private ICustomerDao dao = new CustomerDaoImpl();
        public string AddCustomer(CustomerModel customer)
        {
            string tip = null;
            if (null == customer ||
                null == customer.CustomerCode ||
                null == customer.CustomerName ||
                0 >= customer.CustomerCode.Trim().Length ||
                0 >= customer.CustomerName.Trim().Length)
            {
                tip = "缺少必要信息，无法增加";
                return tip;
            }

            // 查找是否已经存在
            var obj = dao.SelectCustomerWithCode(customer.CustomerCode);
            if (null != obj)
            {
                tip = "客户编号已经存在，请重新设置编号！";
                return tip;
            }

            return dao.InsertCustomer(customer);
        }

        public string RemoveCustomer(string code)
        {
            string tip = null;
            // 检验参数，避免不安全删除
            if (null == code)
            {
                tip = "未指定要删除的客户";
                return tip;
            }

            var obj = dao.SelectCustomerWithCode(code);
            if (null == obj) // 不存在
            {
                tip = "要删除的用户不存在于当前系统中";
                return tip;
            }

            return dao.DeleteCustomer(code);
        }

        public IList<CustomerModel> FindAllCustomers()
        {
            return dao.SelectAllCustomers();
        }

        public CustomerModel FindCustomerForCode(string code)
        {
            if (null == code ||
                0 >= code.Trim().Length) // 指定编号为空，则查询所有用户中第一条记录
            {
                var all = dao.SelectAllCustomers();
                if (null != all && 0 < all.Count)
                {
                    return all[0];
                }
                return null;
            }

            return dao.SelectCustomerWithCode(code);
        }

        public IList<CustomerModel> FindCustomersForName(string name)
        {
            if (null == name ||
                0 >= name.Trim().Length) // 姓名为null，直接返回所有用户
            {
                return FindAllCustomers();
            }
            return dao.SelectCustomersWithName(name);
        }

        public string ModifyCustomerName(CustomerModel customer)
        {
            string tip = null;
            if (null == customer ||
                null == customer.CustomerCode ||
                null == customer.CustomerName ||
                0 >= customer.CustomerCode.Trim().Length ||
                0 >= customer.CustomerName.Trim().Length)
            {
                tip = "缺少必要信息，无法修改";
                return tip;
            }

            return dao.UpdateCustomerName(customer);
        }
    }
}
