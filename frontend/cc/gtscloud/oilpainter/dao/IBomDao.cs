using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.dao
{
    /// <summary>
    /// BOM信息的DAO层接口
    /// </summary>
    interface IBomDao
    {
        /// <summary>
        /// 查询所有的BOM信息列表
        /// </summary>
        /// <returns>BOM信息列表</returns>
        IList<BomInfoModel> SelectAllBomInfo();

        /// <summary>
        /// 根据BOMID查找指定BOM
        /// </summary>
        /// <param name="bomid">要查找的BOMID</param>
        /// <returns>BOM信息</returns>
        BomInfoModel SelectBom(string bomid);

        /// <summary>
        /// 根据BOM ID查询其所有的分支信息
        /// </summary>
        /// <param name="bomid">要查询的BOM ID</param>
        /// <returns>所有的分支信息</returns>
        IList<BomPartInformationModel> SelectAllBomPartsInfoForBom(string bomid);

        /// <summary>
        /// 查询所有bom的所有信息
        /// </summary>
        /// <returns>所有bom的分支信息</returns>
        IList<BomPartInformationModel> SelectAllBomPartsInfo();

        /// <summary>
        /// 根据参数模糊查询bom
        /// </summary>
        /// <param name="param">要查询的BOM参数</param>
        /// <returns>BOM列表</returns>
        IList<BomQueryModel> SelectBomWithParameters(BomQueryModel param);

        /// <summary>
        /// 插入BOM信息
        /// </summary>
        /// <param name="bominfo">BOM单基本信息</param>
        /// <returns>若插入成功返回null，否则返回失败原因</returns>
        string InsertBom(BomInfoModel bominfo);

        /// <summary>
        /// 插入BOM 主剂料信息
        /// </summary>
        /// <param name="mainPart">主剂信息</param>
        /// <returns>若插入成功返回null，否则返回失败原因</returns>
        string InsertBomMainPart(BomPartInformationModel mainPart);

        /// <summary>
        /// 插入BOM 固化剂信息
        /// </summary>
        /// <param name="guhuaPart">固化剂信息</param>
        /// <returns>若插入成功返回null，否则返回失败原因</returns>
        string InsertBomGuhuaPart(BomPartInformationModel guhuaPart);

        /// <summary>
        /// 插入BOM 稀释剂信息
        /// </summary>
        /// <param name="xishiPart">稀释剂信息</param>
        /// <returns>若插入成功返回null，否则返回失败原因</returns>
        string InsertBomXishiPart(BomPartInformationModel xishiPart);

        /// <summary>
        /// 更新BOM信息
        /// </summary>
        /// <param name="bom">最新的BOM信息</param>
        /// <returns>若更新成功返回null，否则返回失败原因</returns>
        string UpdateBom(BomInfoModel bom);

        /// <summary>
        /// 删除BOM信息
        /// </summary>
        /// <param name="bomid">要删除的BOMID</param>
        /// <returns>若删除成功返回null，否则返回失败原因</returns>
        string DeleteBom(string bomid);

        /// <summary>
        /// 删除BOM主剂料信息
        /// </summary>
        /// <param name="bomid">BOMID</param>
        /// <param name="partnumber">剂料号</param>
        /// <returns>若删除成功返回null，否则返回失败原因</returns>
        string DeleteMainPart(string bomid, string partnumber);

        /// <summary>
        /// 删除BOM固化剂信息
        /// </summary>
        /// <param name="bomid">BOMID</param>
        /// <param name="partnumber">剂料号</param>
        /// <returns>若删除成功返回null，否则返回失败原因</returns>
        string DeleteGuhuaPart(string bomid, string partnumber);

        /// <summary>
        /// 删除BOM稀释剂信息
        /// </summary>
        /// <param name="bomid">BOMID</param>
        /// <param name="partnumber">剂料号</param>
        /// <returns>若删除成功返回null，否则返回失败原因</returns>
        string DeleteXishiPart(string bomid, string partnumber);

        /// <summary>
        /// 删除BOM分支信息
        /// </summary>
        /// <param name="bomid">BOMID</param>
        /// <returns>若删除成功返回null，否则返回失败原因</returns>
        string DeletePart(string bomid);

        /// <summary>
        /// 查找BOM分支信息
        /// </summary>
        /// <param name="partInfo">分支信息</param>
        /// <returns>分支信息实体</returns>
        IList<BomPartInformationModel> SelectPartInfo(BomPartInformationModel partInfo);
    }
}
