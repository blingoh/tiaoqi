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
    class ProductLineServiceImpl : IProductLineService
    {
        private IProductLineDao dao = new ProductLineDaoImpl();
        public string AddProductLine(ProductLineModel productline)
        {
            if (null == productline || null == productline.LineCode || null == productline.LineName 
                || 0 >= productline.LineCode.Trim().Length ||
                0 >= productline.LineName.Trim().Length)
            {
                string tip = "不完整的信息无法新增！";
                return tip;
            }

            // 查找
            var model = FindProductLineWithCode(productline.LineCode);
            if (null != model)
            {
                string tip = "该产线编码已经存在，无法新增";
                return tip;
            }

            return dao.InsertProductLine(productline);
        }

        public IList<ProductLineModel> FindAllProductLines()
        {
            return dao.SelectAllProductLines();
        }

        public ProductLineModel FindProductLineWithCode(string code)
        {
            if (null == code || 0 >= code.Trim().Length)
            {
                return null;
            }
            return dao.SelectProductLineWithCode(code);
        }

        public string UpdateProductLine(ProductLineModel productLine)
        {
            if (null == productLine || null == productLine.LineCode || 0 >= productLine.LineCode.Trim().Length)
            {
                string tip = "未指定要更改的项目";
                return tip;
            }

            var model = FindProductLineWithCode(productLine.LineCode);
            if (null == model)
            {
                string tip = @"未指定要更改的项目";
                return tip;
            }

            return dao.UpdateProductLineName(productLine);
        }

        public string DeleteProductLine(string code)
        {
            if (null == code || 0 >= code.Trim().Length)
            {
                string tip = "未指定要删除的项目";
                return tip;
            }
            var model = FindProductLineWithCode(code);
            if (null == model)
            {
                string tip = @"未指定要更改的项目";
                return tip;
            }
            return dao.DeleteProductLineWithCode(code);
        }
    }
}
