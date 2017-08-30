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
    /// 油漆类型DAO层实现类
    /// </summary>
    class OilTypeDaoImpl : IOilTypeDao
    {
        ISqlMapper sqlMapper = SingletonSqlMapper.Get();
        private readonly static string SQL_SELECT_ALL_TYPES = "SelectAllOilTypes";
        private readonly static string SQL_SELECT_TYPE_FOR_TYPEID = "SelectOilTypeWithId";
        private readonly static string SQL_INSERT_TYPE = "InsertOilType";
        private readonly static string SQL_DELETE_TYPE = "DeleteOilType";

        public string DeleteOilType(string type)
        {
            string tip = null;
            try
            {
                sqlMapper.BeginTransaction();
                sqlMapper.Delete(SQL_DELETE_TYPE, type);
                sqlMapper.CommitTransaction();
                return null;
            }
            catch (Exception ex)
            {
                if (null == ex)
                {
                    return tip = "不可预知的异常！";
                }
                Console.WriteLine(ex?.Message);
                return tip = ex.Message;
            }
        }

        public string InsertOilType(OilPaintTypeModel oilType)
        {
            string tip = null;
            try
            {
                sqlMapper.BeginTransaction();
                sqlMapper.Insert(SQL_INSERT_TYPE, oilType);
                sqlMapper.CommitTransaction();
                return null;
            }
            catch (Exception ex)
            {
                if (null == ex)
                {
                    return tip = "不可预知的异常！";
                }
                Console.WriteLine(ex?.Message);
                return tip = ex.Message;
            }
        }

        public IList<OilPaintTypeModel> SelectAllTypes()
        {
            try
            {
                return sqlMapper.QueryForList<OilPaintTypeModel>(SQL_SELECT_ALL_TYPES, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                return null;
            }
        }

        public OilPaintTypeModel SelectOilType(string type)
        {
            try
            {
                return sqlMapper.QueryForObject<OilPaintTypeModel>(SQL_SELECT_TYPE_FOR_TYPEID, type);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                return null;
            }
        }
    }
}
