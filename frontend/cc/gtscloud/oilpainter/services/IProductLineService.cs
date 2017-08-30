using frontend.cc.gtscloud.oilpainter.dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.services
{
    /// <summary>
    /// 产品线服务接口
    /// </summary>
    interface IProductLineService
    {
        /// <summary>
        /// 添加一条产线
        /// </summary>
        /// <param name="productline">要添加的产线</param>
        /// <returns>若添加成功，则为nulll，否则为添加失败的原因</returns>
        string AddProductLine(ProductLineModel productline);

        /// <summary>
        /// 查找所有的产线
        /// </summary>
        /// <returns>所有产线</returns>
        IList<ProductLineModel> FindAllProductLines();

        /// <summary>
        /// 根据产线编号查询指定产线
        /// </summary>
        /// <param name="code">产线编号</param>
        /// <returns>指定产线实体</returns>
        ProductLineModel FindProductLineWithCode(string code);

        /// <summary>
        /// 更新产线
        /// </summary>
        /// <param name="productLine">要更新的产线，其产线Code作为唯一标识</param>
        /// <returns>若更新失败则为原因，成功则为null</returns>
        string UpdateProductLine(ProductLineModel productLine);

        /// <summary>
        /// 删除一条产线
        /// </summary>
        /// <param name="code">要删除的产线编码</param>
        /// <returns>若删除成功，则为null，否则为失败原因</returns>
        string DeleteProductLine(string code);
    }
}
