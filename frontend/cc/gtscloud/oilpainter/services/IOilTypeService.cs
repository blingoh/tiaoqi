using frontend.cc.gtscloud.oilpainter.dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.services
{
    /// <summary>
    /// 油漆类型服务类接口
    /// </summary>
    interface IOilTypeService
    {
        /// <summary>
        /// 查找所有的油漆类型
        /// </summary>
        /// <returns>所有的油漆类型</returns>
        IList<OilPaintTypeModel> FindAllOilTypes();
        /// <summary>
        /// 查找油漆类型
        /// </summary>
        /// <param name="type">要查找的油漆类型</param>
        /// <returns>油漆类型实体</returns>
        OilPaintTypeModel FindOilType(string type);

        /// <summary>
        /// 插入油漆类型
        /// </summary>
        /// <param name="insOilType">待插入油漆类型</param>
        /// <returns>若插入成功则为null，否则为插入失败的消息</returns>
        string InsertOilType(OilPaintTypeModel insOilType);

        /// <summary>
        /// 删除油漆类型
        /// </summary>
        /// <param name="type">要删除的油漆类型</param>
        /// <returns>若插入成功则为null，否则为插入失败的消息</returns>
        string DeleteOilType(string type);
    }
}
