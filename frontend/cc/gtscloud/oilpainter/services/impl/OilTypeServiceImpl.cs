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
    /// 油漆类型服务类
    /// </summary>
    class OilTypeServiceImpl : IOilTypeService
    {
        private IOilTypeDao dao = new OilTypeDaoImpl();
        public string DeleteOilType(string type)
        {
            string tip = null;
            if (null == type)
            {
                // 未指定对象
                tip = "未指定要删除的油漆类型";
                return tip;
            }

            var obj = FindOilType(type);
            if (null == obj)
            {
                return tip = "不存在要删除的油漆类型";
            }

            return dao.DeleteOilType(type);
        }

        public IList<OilPaintTypeModel> FindAllOilTypes()
        {
            return dao.SelectAllTypes();
        }

        public OilPaintTypeModel FindOilType(string type)
        {
            if (null == type)
            {
                return null;
            }

            return dao.SelectOilType(type);
        }

        public string InsertOilType(OilPaintTypeModel insOilType)
        {
            string tip = null;
            if (null == insOilType || 
                null == insOilType.OilPaintType || 
                0 >= insOilType.Description.Trim().Length)
            {
                // 未指定对象
                tip = "未指定要删除的油漆类型";
                return tip;
            }

            var obj = FindOilType(insOilType.OilPaintType);
            if (null != obj)
            {
                return tip = "该油漆类型已存在";
            }

            return dao.InsertOilType(insOilType);
        }
    }
}
