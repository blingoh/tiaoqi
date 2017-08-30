using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frontend.cc.gtscloud.oilpainter.dao.model;
using frontend.cc.gtscloud.oilpainter.dao;
using frontend.cc.gtscloud.oilpainter.dao.impl;
using frontend.cc.gtscloud.oilpainter.models;

namespace frontend.cc.gtscloud.oilpainter.services.impl
{
    /**
     * 代码改进点：
     * 1、使用AOP进行事务处理
     * 
     * */
    /// <summary>
    /// BOM服务实现类
    /// </summary>
    class BomInfoServiceImpl : IBomInfoService
    {
        private IBomDao dao = new BomInfoDaoImpl();

        public string AddBom(BomInfoModel bom)
        {
            string tip = null;
            if (null == bom)
            {
                return tip = "未指定要增加的项！";
            }

            bom.BomId = Guid.NewGuid().ToString(); // 在业务类中注入GUID

            var foundBom = FindBomsWithParam(new BomQueryModel()
            {
                BomId = bom.BomId
            });

            if (0 < foundBom?.Count)
            {
                return tip = "该项目的BOM已经存在！";
            }

            SingletonSqlMapper.Get().BeginTransaction();

            tip = dao.InsertBom(bom);

            if (null == tip) // 出错
            {
                SingletonSqlMapper.Get().CommitTransaction(); // 提交事务
            }
            else
            {
                SingletonSqlMapper.Get().RollBackTransaction(); // 回滚
            }
            return tip;
        }

        public string AddBomGuhuaPart(BomPartInformationModel guhuaPart)
        {
            string tip = null;
            if (null == guhuaPart)
            {
                return tip = "未指定要增加的项！";
            }

            var foundPart = FindPartInfo(guhuaPart);
            if (null != foundPart)
            {
                return tip = "该固化剂已经存在！";
            }

            SingletonSqlMapper.Get().BeginTransaction();
            tip = dao.InsertBomGuhuaPart(guhuaPart);

            if (null == tip)
            {
                // 提交事务
                SingletonSqlMapper.Get().CommitTransaction();
            }
            else
            {
                SingletonSqlMapper.Get().RollBackTransaction();
            }
            return tip;
        }

        public string AddBomMainPart(BomPartInformationModel mainPart)
        {
            string tip = null;
            if (null == mainPart)
            {
                return tip = "未指定要增加的项！";
            }

            var foundPart = FindPartInfo(mainPart);
            if (null != foundPart)
            {
                return tip = "该主剂料已经存在！";
            }
            SingletonSqlMapper.Get().BeginTransaction();
            tip = dao.InsertBomMainPart(mainPart);
            if (null == tip)
            {
                // 提交事务
                SingletonSqlMapper.Get().CommitTransaction();
            }
            else
            {
                SingletonSqlMapper.Get().RollBackTransaction();
            }
            return tip;
        }

        public string AddBomXishiPart(BomPartInformationModel xishiPart)
        {
            string tip = null;
            if (null == xishiPart)
            {
                return tip = "未指定要增加的项！";
            }
            var foundPart = FindPartInfo(xishiPart);
            if (null != foundPart)
            {
                return tip = "该稀释剂已经存在！";
            }
            SingletonSqlMapper.Get().BeginTransaction();
            tip = dao.InsertBomXishiPart(xishiPart);
            if (null == tip)
            {
                // 提交事务
                SingletonSqlMapper.Get().CommitTransaction();
            }
            else
            {
                SingletonSqlMapper.Get().RollBackTransaction();
            }
            return tip;
        }

        public IList<BomInfoModel> FindAllBom()
        {
            return dao.SelectAllBomInfo();
        }

        public IList<BomPartInformationModel> FindAllBomParts()
        {
            return dao.SelectAllBomPartsInfo();
        }

        public IList<BomPartInformationModel> FindAllBomParts(string bomid)
        {
            if (null == bomid || 
                0 >= bomid.Trim().Length) // 未指定bomid
            {
                return FindAllBomParts();
            }

            return dao.SelectAllBomPartsInfoForBom(bomid);
        }

        public IList<BomQueryModel> FindBomsWithParam(BomQueryModel param)
        {
            if (null == param)
            {
                return null;
            }

            return dao.SelectBomWithParameters(param);
        }

        public string ModifyBom(BomInfoModel bom)
        {
            if (null == bom)
            {
                return null;
            }
            SingletonSqlMapper.Get().BeginTransaction();
            string tip = dao.UpdateBom(bom);
            if (null == tip)
            {
                SingletonSqlMapper.Get().CommitTransaction();
            }
            else
            {
                SingletonSqlMapper.Get().RollBackTransaction();
            }
            return tip;
        }

        public string ModifyBom(BomInfoCompleteModel bom)
        {
            if (null == bom)
            {
                return null;
            }

            // 开启事务
            SingletonSqlMapper.Get().BeginTransaction();

            // 更新基本信息
            string err = dao.UpdateBom(bom.BomBasic);

            if (null != err)
            {
                SingletonSqlMapper.Get().RollBackTransaction();
                return err;
            }
            SingletonSqlMapper.Get().CommitTransaction();
            return err;
        }
        public string RemoveBom(string bomid)
        {
            string tip = null;
            if (null == bomid || 
                0 >= bomid?.Trim().Length)
            {
                return tip = "未指定要删除的项";
            }
            SingletonSqlMapper.Get().BeginTransaction();
            var err = tip = dao.DeleteBom(bomid);
            if (null == err)
            {
                err = dao.DeletePart(bomid);
                if (null == err)
                {
                    SingletonSqlMapper.Get().CommitTransaction();
                    return null;
                }
            }

            SingletonSqlMapper.Get().RollBackTransaction();
            return err;

        }

        public string RemoveGuhuaPart(string bomid, string partNumber)
        {
            string tip = null;
            if (null == bomid ||
                0 >= bomid?.Trim().Length || 
                null == partNumber || 
                0 >= partNumber?.Trim().Length)
            {
                return tip = "未指定要删除的项";
            }
            SingletonSqlMapper.Get().BeginTransaction();
            tip = dao.DeleteGuhuaPart(bomid, partNumber);
            if (null == tip)
            {
                // 提交事务
                SingletonSqlMapper.Get().CommitTransaction();
            }
            else
            {
                SingletonSqlMapper.Get().RollBackTransaction();
            }
            return tip;

        }

        public string RemoveMainPart(string bomid, string partNumber)
        {
            string tip = null;
            if (null == bomid ||
                0 >= bomid?.Trim().Length ||
                null == partNumber ||
                0 >= partNumber?.Trim().Length)
            {
                return tip = "未指定要删除的项";
            }
            SingletonSqlMapper.Get().BeginTransaction();
            tip = dao.DeleteMainPart(bomid, partNumber);
            if (null == tip)
            {
                // 提交事务
                SingletonSqlMapper.Get().CommitTransaction();
            }
            else
            {
                SingletonSqlMapper.Get().RollBackTransaction();
            }
            return tip;
        }

        public string RemovePart(string bomid, string partNumber, string partType)
        {
            if (partType.Equals(PartTypeConstant.XiShi))
            {
                return RemoveXishiPart(bomid, partType);
            }
            else if (partType.Equals(PartTypeConstant.Main))
            {
                return RemoveMainPart(bomid, partNumber);
            }
            else if (partType.Equals(PartTypeConstant.GuHua))
            {
                return RemoveGuhuaPart(bomid, partNumber);
            }
            return "未产生任何更改，不支持的类别";
        }

        public string RemoveXishiPart(string bomid, string partNumber)
        {
            string tip = null;
            if (null == bomid ||
                0 >= bomid?.Trim().Length ||
                null == partNumber ||
                0 >= partNumber?.Trim().Length)
            {
                return tip = "未指定要删除的项";
            }
            SingletonSqlMapper.Get().BeginTransaction();
            tip = dao.DeleteXishiPart(bomid, partNumber);
            if (null == tip)
            {
                // 提交事务
                SingletonSqlMapper.Get().CommitTransaction();
            }
            else
            {
                SingletonSqlMapper.Get().RollBackTransaction();
            }
            return tip;
        }

        public IList<BomPartInformationModel> FindPartInfo(BomPartInformationModel partInfo)
        {
            return dao.SelectPartInfo(partInfo);
        }

        public string AddBom(BomInfoCompleteModel bom)
        {
            string tip = null;
            if (null == bom || null == bom.BomBasic)
            {
                return tip = "未指定要增加的项！";
            }

            // 注入BOMID
            bom.BomBasic.BomId = Guid.NewGuid().ToString();

            var foundBom = FindBomsWithParam(new BomQueryModel()
            {
                BomId = bom.BomBasic.BomId
            });

            if (0 < foundBom?.Count)
            {
                return tip = "该项目的BOM已经存在！";
            }

            // 开启事务
            SingletonSqlMapper.Get().BeginTransaction();

            tip = dao.InsertBom(bom.BomBasic);

            if (null != tip)
            {
                SingletonSqlMapper.Get().RollBackTransaction();
                return tip;
            }

            // 添加主剂料
            if (0 < bom.MainPart?.Count)
            {
                foreach (var part in bom.MainPart)
                {
                    part.BomId = bom.BomBasic.BomId;
                    tip = dao.InsertBomMainPart(part);
                    if (null != tip)
                    {
                        // 出错
                        break;
                    }
                }
            }

            if (null != tip)
            {
                SingletonSqlMapper.Get().RollBackTransaction();
                return tip;
            }

            // 添加稀释剂
            if (0 < bom.XiShi?.Count)
            {
                foreach (var part in bom.XiShi)
                {
                    part.BomId = bom.BomBasic.BomId;
                    tip = dao.InsertBomXishiPart(part);
                    if (null != tip)
                    {
                        // 出错
                        break;
                    }
                }
            }

            if (null != tip)
            {
                SingletonSqlMapper.Get().RollBackTransaction();
                return tip;
            }

            // 添加固化剂
            if (0 < bom.GuHua?.Count)
            {
                foreach (var part in bom.GuHua)
                {
                    part.BomId = bom.BomBasic.BomId;
                    tip = dao.InsertBomGuhuaPart(part);
                    if (null != tip)
                    {
                        // 出错
                        break;
                    }
                }
            }

            if (null != tip)
            {
                SingletonSqlMapper.Get().RollBackTransaction();
                return tip;
            }

            SingletonSqlMapper.Get().CommitTransaction(); // 提交
            return null;
        }

        public BomInfoModel FindBom(string bomid)
        {
            if (null == bomid)
            {
                return null;
            }

            return dao.SelectBom(bomid);
        }
    }
}
