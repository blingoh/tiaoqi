using frontend.cc.gtscloud.oilpainter.dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao
{
    /// <summary>
    /// 油漆类型DAO层接口
    /// </summary>
    interface IOilTypeDao
    {
        /// <summary>
        /// 查询所有的油漆类型
        /// </summary>
        /// <returns>所有油漆类型</returns>
        IList<OilPaintTypeModel> SelectAllTypes();

        /// <summary>
        /// 查询指定的油漆类型信息
        /// </summary>
        /// <param name="type">油漆类型</param>
        /// <returns>油漆类型实体</returns>
        OilPaintTypeModel SelectOilType(string type);

        /// <summary>
        /// 插入新的油漆类型
        /// </summary>
        /// <param name="oilType">待插入油漆类型实体</param>
        /// <returns>若新增成功则为null，否则为失败原因</returns>
        string InsertOilType(OilPaintTypeModel oilType);

        /// <summary>
        /// 删除油漆类型
        /// </summary>
        /// <param name="type">待删除油漆类型</param>
        /// <returns>若删除成功则为null，否则为失败原因</returns>
        string DeleteOilType(string type);
    }
}
