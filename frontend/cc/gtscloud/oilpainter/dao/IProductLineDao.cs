using frontend.cc.gtscloud.oilpainter.dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao
{
    /// <summary>
    /// 产线DAO层接口
    /// </summary>
    interface IProductLineDao
    {
        #region 查
        /// <summary>
        /// 查询所有的生产线
        /// </summary>
        /// <returns>所有生产线列表</returns>
        IList<ProductLineModel> SelectAllProductLines();

        /// <summary>
        /// 根据产线号查询生产线
        /// </summary>
        /// <param name="linecode">生产线号</param>
        /// <returns>执行的生产线，若不存在则为null，否则为唯一的一条产线实体</returns>
        ProductLineModel SelectProductLineWithCode(string linecode);
        #endregion
        #region 增
        /// <summary>
        /// 新增一条产线
        /// </summary>
        /// <param name="productline">要新增的产线内容</param>
        /// <returns>若新增成功，则为null，否则其指示失败原因</returns>
        string InsertProductLine(ProductLineModel productline);
        #endregion

        #region 删
        /// <summary>
        /// 删除所有的生产线（危险）
        /// </summary>
        /// <returns>若删除成功，则为null，否则应指示其失败原因</returns>
        string DeleteAllProductLines();

        /// <summary>
        /// 根据生产线号，删除指定的生产线
        /// </summary>
        /// <param name="linecode">待删除生产线编号</param>
        /// <returns>若删除成功，则为null，否则应指示其失败原因</returns>
        string DeleteProductLineWithCode(string linecode);
        #endregion
        #region 改
        /// <summary>
        /// 更新产线名
        /// </summary>
        /// <param name="productline">要更新的产线的信息</param>
        /// <returns>若更新成功，则为null，否则应指示其失败原因</returns>
        string UpdateProductLineName(ProductLineModel productline);
        #endregion

    }
}
