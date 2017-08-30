using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.services
{
    /// <summary>
    /// BOM信息服务接口
    /// </summary>
    interface IBomInfoService
    {
        /// <summary>
        /// 查找所有BOM
        /// </summary>
        /// <returns>信息</returns>
        IList<BomInfoModel> FindAllBom();

        /// <summary>
        /// 根据BOMID查询BOM
        /// </summary>
        /// <param name="bomid">要查询的BOMID</param>
        /// <returns>BOM信息</returns>
        BomInfoModel FindBom(string bomid);
        /// <summary>
        /// 不区分BOM查询所有分支信息
        /// </summary>
        /// <returns>所有分支信息</returns>
        IList<BomPartInformationModel> FindAllBomParts();

        /// <summary>
        /// 根据BOMID查询分支信息
        /// </summary>
        /// <param name="bomid">要查询的BOMID</param>
        /// <returns>获取到的分支信息</returns>
        IList<BomPartInformationModel> FindAllBomParts(string bomid);

        /// <summary>
        /// 根据参数查询BOM
        /// </summary>
        /// <param name="param">要查询的BOM参数列表</param>
        /// <returns>BOM列表</returns>
        IList<BomQueryModel> FindBomsWithParam(BomQueryModel param);

        /// <summary>
        /// 查找BOM分支信心
        /// </summary>
        /// <param name="partInfo">要查找的信息</param>
        /// <returns>查找到的信息，若无结果则为null</returns>
        IList<BomPartInformationModel> FindPartInfo(BomPartInformationModel partInfo);

        /// <summary>
        /// 添加一条BOM信息
        /// </summary>
        /// <param name="bom">BOM信息</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string AddBom(BomInfoModel bom);
        /// <summary>
        /// 添加一个完整的BOM
        /// </summary>
        /// <param name="bom">要添加的BOM</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string AddBom(BomInfoCompleteModel bom);
        /// <summary>
        /// 添加主剂料信息
        /// </summary>
        /// <param name="mainPart">主剂料信息</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string AddBomMainPart(BomPartInformationModel mainPart);
        /// <summary>
        /// 添加固化剂信息
        /// </summary>
        /// <param name="mainPart">固化剂信息</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string AddBomGuhuaPart(BomPartInformationModel mainPart);
        /// <summary>
        /// 添加稀释剂信息
        /// </summary>
        /// <param name="mainPart">稀释剂信息</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string AddBomXishiPart(BomPartInformationModel mainPart);
        /// <summary>
        /// 更改BOM信息
        /// </summary>
        /// <param name="bom">BOM信息</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string ModifyBom(BomInfoModel bom);

        /// <summary>
        /// 更新BOM和分支信息
        /// </summary>
        /// <param name="bom">BOM信息</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string ModifyBom(BomInfoCompleteModel bom);

        /// <summary>
        /// 删除BOM
        /// </summary>
        /// <param name="bomid">BOMID</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string RemoveBom(string bomid);
        /// <summary>
        /// 删除主剂料信息
        /// </summary>
        /// <param name="bomid">BOMID</param>
        /// <param name="partNumber">主剂料号</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string RemoveMainPart(string bomid, string partNumber);
        /// <summary>
        /// 删除固化剂信息
        /// </summary>
        /// <param name="bomid">BOMID</param>
        /// <param name="partNumber">主剂料号</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string RemoveGuhuaPart(string bomid, string partNumber);
        /// <summary>
        /// 删除稀释剂信息
        /// </summary>
        /// <param name="bomid">BOMID</param>
        /// <param name="partNumber">主剂料号</param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string RemoveXishiPart(string bomid, string partNumber);
        /// <summary>
        /// 删除分支信息
        /// </summary>
        /// <param name="bomid">BOMID</param>
        /// <param name="partNumber">主剂料号</param>
        /// <param name="partType"></param>
        /// <returns>结果：null 为成功，否则为失败原因</returns>
        string RemovePart(string bomid, string partNumber, string partType);
    }
}
