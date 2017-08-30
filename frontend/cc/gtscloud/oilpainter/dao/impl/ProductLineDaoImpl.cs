using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frontend.cc.gtscloud.oilpainter.dao.model;
using IBatisNet.DataMapper;
using log4net;

namespace frontend.cc.gtscloud.oilpainter.dao.impl
{
    /// <summary>
    /// 产线DAO层实现
    /// </summary>
    class ProductLineDaoImpl : IProductLineDao
    {
        private static ILog LOG;
        private readonly static string SQL_SELECT_ALL_PRODUCTLINE = "SelectAllProductLines";
        private readonly static string SQL_SELECT_PRODUCTLINE_WITH_CODE = "SelectProductLineWithCode";
        private readonly static string SQL_INSERT_PRODUCTLINE = "InsertProductLine";
        private readonly static string SQL_DELETE_ALL_PRODUCTLINE = "DeleteAllProductLines";
        private readonly static string SQL_DELETE_PRODUCTLINE_WITH_CODE = "DeleteProductLineWithCode";
        private readonly static string SQL_UPDATE_PRODUCTLINE = "UpdateLineName";

        public ProductLineDaoImpl()
        {
            LOG = LogManager.GetLogger(this.GetType());
        }

        public string DeleteAllProductLines()
        {
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            try
            {
                mapper.BeginTransaction();
                mapper.Delete(SQL_DELETE_ALL_PRODUCTLINE, null);
                mapper.CommitTransaction();
                return null;
            }
            catch (Exception ex)
            {
                string tip = "发生错误：" + ex.Message;
                mapper.RollBackTransaction();
                return tip;
            }
        }

        public string DeleteProductLineWithCode(string linecode)
        {
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            try
            {
                mapper.BeginTransaction();
                mapper.Delete(SQL_DELETE_PRODUCTLINE_WITH_CODE, linecode);
                mapper.CommitTransaction();
                return null;
            }
            catch (Exception ex)
            {
                mapper.RollBackTransaction();
                string tip = "发生错误：" + ex.Message;
                return tip;
            }
        }

        public string InsertProductLine(ProductLineModel productline)
        {
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            try
            {
                mapper.Insert(SQL_INSERT_PRODUCTLINE, productline);
                return null;
            }
            catch (Exception ex)
            {
                string tip = "发生错误：" + ex.Message;
                return tip;
            }
        }

        public IList<ProductLineModel> SelectAllProductLines()
        {
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            try
            {
                return mapper.QueryForList<ProductLineModel>(SQL_SELECT_ALL_PRODUCTLINE, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LOG.Info(ex);
                return null;
            }
        }

        public ProductLineModel SelectProductLineWithCode(string linecode)
        {
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            try
            {
                ProductLineModel productLine = mapper.QueryForObject<ProductLineModel>(SQL_SELECT_PRODUCTLINE_WITH_CODE, linecode);
                return productLine;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public string UpdateProductLineName(ProductLineModel productline)
        {
            ISqlMapper mapper = SingletonSqlMapper.Instance();
            try
            {
                mapper.BeginTransaction();
                mapper.Update(SQL_UPDATE_PRODUCTLINE, productline);
                mapper.CommitTransaction();
                return null;
            }
            catch (Exception ex)
            {
                string tip = "发生不可预知的错误：" + ex.Message;
                mapper.RollBackTransaction();
                return tip;
            }
        }
    }
}
