using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frontend.cc.gtscloud.oilpainter.dao.model;
using IBatisNet.DataMapper;

namespace frontend.cc.gtscloud.oilpainter.dao.impl
{
    /// <summary>
    /// 客户DAO层实现
    /// </summary>
    class CustomerDaoImpl : ICustomerDao
    {
        private readonly static string SQL_SELECT_ALL_CUSTOMERS = "SelectAllCustomers";
        private readonly static string SQL_SELECT_CUSTOMER_WITH_CODE = "SelectCustomerWithCode";
        private readonly static string SQL_SELECT_CUSTOMERS_WITH_NAME = "SelectCustomersWithName";
        private readonly static string SQL_INSERT_CUSTOMER = "InsertNewCustomer";
        private readonly static string SQL_UPDATE_CUSTOMER_NAME = "UpdateCustomerName";
        private readonly static string SQL_DELETE_CUSTOMER_WITH_CODE = "DeleteCustomerWithCode";

        ISqlMapper sqlMapper = SingletonSqlMapper.Instance();

        public string DeleteCustomer(string code)
        {
            string tip = null;
            try
            {
                sqlMapper.BeginTransaction();
                sqlMapper.Delete(SQL_DELETE_CUSTOMER_WITH_CODE, code);
                sqlMapper.CommitTransaction();
                return null;
            }
            catch (Exception ex)
            {
                sqlMapper.RollBackTransaction();
                if (null == ex)
                {
                    return tip = "不可预知的异常";
                }
                Console.WriteLine(ex.Message);
                return tip = ex.Message;
            }
        }

        public string InsertCustomer(CustomerModel customer)
        {
            string tip = null;
            try
            {
                sqlMapper.BeginTransaction();
                sqlMapper.Insert(SQL_INSERT_CUSTOMER, customer);
                sqlMapper.CommitTransaction();
                return tip;
            }
            catch (Exception ex)
            {
                sqlMapper.RollBackTransaction();
                if (null == ex)
                {
                    return null;
                }
                Console.WriteLine(ex.Message);
                return tip = ex.Message;
            }
        }

        public IList<CustomerModel> SelectAllCustomers()
        {
            try
            {
                var allCustomers = sqlMapper.QueryForList<CustomerModel>(SQL_SELECT_ALL_CUSTOMERS, null);
                return allCustomers;
            }
            catch (Exception ex)
            {
                if (null == ex)
                {
                    return null;
                }
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public IList<CustomerModel> SelectCustomersWithName(string name)
        {
            try
            {
                var allCustomers = sqlMapper.QueryForList<CustomerModel>(SQL_SELECT_CUSTOMERS_WITH_NAME, name);
                return allCustomers;
            }
            catch (Exception ex)
            {
                if (null == ex)
                {
                    return null;
                }
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public CustomerModel SelectCustomerWithCode(string code)
        {
            try
            {
                var allCustomers = sqlMapper.QueryForObject<CustomerModel>(SQL_SELECT_CUSTOMER_WITH_CODE, code);
                return allCustomers;
            }
            catch (Exception ex)
            {
                if (null == ex)
                {
                    return null;
                }
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public string UpdateCustomerName(CustomerModel customer)
        {
            string tip = null;
            try
            {
                sqlMapper.BeginTransaction();
                var allCustomers = sqlMapper.QueryForList<CustomerModel>(SQL_UPDATE_CUSTOMER_NAME, customer);
                sqlMapper.CommitTransaction();
                return tip;
            }
            catch (Exception ex)
            {
                sqlMapper.RollBackTransaction();
                if (null == ex)
                {
                    return tip = "不可预知的异常";
                }
                Console.WriteLine(ex.Message);
                return tip = ex.Message;
            }
        }
    }
}
