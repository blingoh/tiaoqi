using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.models;
using IBatisNet.Common.Logging;
using IBatisNet.DataMapper;

namespace frontend.cc.gtscloud.oilpainter.dao.impl
{
    /// <summary>
    /// BOM信息Dao层实现类
    /// </summary>
    class BomInfoDaoImpl : IBomDao
    {
        private readonly static string SQL_SELECT_ALL_BOMS = "SelectAllBomInfo";
        private readonly static string SQL_SELECT_ALL_BOM_PARTS = "SelectAllPartsInfo";
        private readonly static string SQL_SELECT_BOM_PARTS_FOR_BOM = "SelectAllPartsWithBomID";
        private readonly static string SQL_SELECT_ALL_BOM_WITH_PARAM = "SelectBomWithParameter";
        private readonly static string SQL_SELECT_BOM_PART_INFO = "SelectPartInfo";
        private readonly static string SQL_SELECT_BOM_WITH_ID = "SelectBomWithID";

        private readonly static string SQL_INSERT_BOM = "InsertBom";
        private readonly static string SQL_INSERT_BOM_MAIN_PART = "InsertMainPartInfo";
        private readonly static string SQL_INSERT_BOM_GUHUA_PART = "InsertGuhuaPartInfo";
        private readonly static string SQL_INSERT_BOM_XISHI_PART = "InsertXishiPartInfo";
        private readonly static string SQL_UPDATE_BOM = "UpdateBomInfo";
        private readonly static string SQL_DELETE_BOM = "DeleteBom";
        private readonly static string SQL_DELETE_BOM_MAIN_PART = "DeleteMainPart";
        private readonly static string SQL_DELETE_BOM_GUHUA_PART = "DeleteGuhuaPart";
        private readonly static string SQL_DELETE_BOM_XISHI_PART = "DeleteXishiPart";
        private readonly static string SQL_DELETE_PART = "DeleteBomPart";

        private static ILog LOG;
        ISqlMapper mapper = SingletonSqlMapper.Get();

        public string DeleteBom(string bomid)
        {
            string tip = null;
            try
            {
                mapper.Delete(SQL_DELETE_BOM, bomid);
                return tip;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                tip = "发生意外错误错误: " + ex?.Message;
                return tip;
            }
        }

        public string DeleteGuhuaPart(string bomid, string partnumber)
        {
            string tip = null;
            try
            {
                mapper.Delete(SQL_DELETE_BOM_GUHUA_PART, bomid);
                return tip;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                tip = "发生意外错误错误: " + ex?.Message;
                return tip;
            }
        }

        public string DeleteMainPart(string bomid, string partnumber)
        {
            string tip = null;
            try
            {
                mapper.Delete(SQL_DELETE_BOM_MAIN_PART, bomid);
                return tip;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                tip = "发生意外错误错误: " + ex?.Message;
                return tip;
            }
        }

        public string DeleteXishiPart(string bomid, string partnumber)
        {
            string tip = null;
            try
            {
                mapper.Delete(SQL_DELETE_BOM_XISHI_PART, bomid);
                return tip;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                tip = "发生意外错误错误: " + ex?.Message;
                return tip;
            }
        }

        public string InsertBom(BomInfoModel bominfo)
        {
            string tip = null;
            try
            {
                mapper.Insert(SQL_INSERT_BOM, bominfo);
                return tip;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                tip = "发生意外错误错误: " + ex?.Message;
                return tip;
            }
        }

        public string InsertBomGuhuaPart(BomPartInformationModel guhuaPart)
        {
            string tip = null;
            try
            {
                mapper.Insert(SQL_INSERT_BOM_GUHUA_PART, guhuaPart);
                return tip;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                tip = "发生意外错误错误: " + ex?.Message;
                return tip;
            }
        }

        public string InsertBomMainPart(BomPartInformationModel mainPart)
        {
            string tip = null;
            try
            {
                mapper.Insert(SQL_INSERT_BOM_MAIN_PART, mainPart);
                return tip;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                tip = "发生意外错误错误: " + ex?.Message;
                return tip;
            }
        }

        public string InsertBomXishiPart(BomPartInformationModel xishiPart)
        {
            string tip = null;
            try
            {
                mapper.Insert(SQL_INSERT_BOM_XISHI_PART, xishiPart);
                return tip;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                tip = "发生意外错误错误: " + ex?.Message;
                return tip;
            }
        }

        public IList<BomInfoModel> SelectAllBomInfo()
        {
            try
            {
                return mapper.QueryForList<BomInfoModel>(SQL_SELECT_ALL_BOMS, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public IList<BomPartInformationModel> SelectAllBomPartsInfo()
        {
            try
            {
                return mapper.QueryForList<BomPartInformationModel>(SQL_SELECT_ALL_BOM_PARTS, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                return null;
            }
        }

        public IList<BomPartInformationModel> SelectAllBomPartsInfoForBom(string bomid)
        {
            try
            {
                return mapper.QueryForList<BomPartInformationModel>(SQL_SELECT_BOM_PARTS_FOR_BOM, bomid);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex?.Message);
                return null;
            }
        }

        public IList<BomQueryModel> SelectBomWithParameters(BomQueryModel param)
        {
            try
            {
                return mapper.QueryForList<BomQueryModel>(SQL_SELECT_ALL_BOM_WITH_PARAM, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                return null;
            }
        }

        public string UpdateBom(BomInfoModel bom)
        {
            string tip = null;
            try
            {
                mapper.Update(SQL_UPDATE_BOM, bom);
                return tip;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                tip = "发生意外错误错误: " + ex?.Message;
                return tip;
            }
        }

        public IList<BomPartInformationModel> SelectPartInfo(BomPartInformationModel partInfo)
        {
            try
            {
                return mapper.QueryForList<BomPartInformationModel>(SQL_SELECT_BOM_PART_INFO, partInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                return null;
            }
        }

        public string DeletePart(string bomid)
        {
            try
            {
                mapper.Delete(SQL_DELETE_PART, bomid);
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                return ex.Message;
            }
        }

        public BomInfoModel SelectBom(string bomid)
        {
            try
            {
                return mapper.QueryForObject<BomInfoModel>(SQL_SELECT_BOM_WITH_ID, bomid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex?.Message);
                return null;
            }
        }
    }
}
