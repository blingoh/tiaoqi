using frontend.config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend.cc.gtscloud.oilpainter.services
{
    class PrinterService
    {
        /// <summary>
        /// 打印新的标签条码
        /// </summary>
        /// <param name="printRecord">要打印的记录</param>
        /// <param name="err">错误信息</param>
        public void StartPrintNew(PrinterRecordModel printRecord, ref string err)
        {
            err = CheckConfig();
            if (null != err)
            {   
                return;
            }
            var printerConfig = SingtonConfigContent.Instance().Printer;
            var printInterface = new LabelPrintCSharp.clsLabelPrint();
            printInterface.LabelPath = printerConfig.LabelTemplatPath;
            printInterface.PrintPath = printerConfig.PrinterName;
            printInterface.ClearVariableItems();
            printInterface.AddNewItem("Line", printRecord.BasicModel.LineType);
            printInterface.AddNewItem("YuanYouPartNumber", printRecord.BasicModel.OilMaterialNum);
            printInterface.AddNewItem("GuHuaPartNumber", printRecord.BasicModel.GuhuaMaterialNu);
            printInterface.AddNewItem("XiShiPartNumber", printRecord.BasicModel.XishiMaterialNum);
            printInterface.AddNewItem("Speed", printRecord.BasicModel.OilSeconds.ToString());
            printInterface.AddNewItem("PartNumber", printRecord.BasicModel.MachineType);

            printInterface.AddNewItem("Operator", printRecord.Operator);
            printInterface.AddNewItem("TiaoQiDT", printRecord.PrintDate);
            printInterface.AddNewItem("YouXiaoDT", printRecord.DeadDate);

            SingtonConfigContent.Instance().LastPrintRecord = printRecord;

            SingtonConfigContent.Instance().WriteCurrentConfig();
            // 开始打印
            var result = printInterface.PrintLabel();
            if (result)
            {
                err = null;
            }
            else
            {
                err = "打印请求已经提交，但是未打印成功，原因可能是未找到打印机或模板文件，请检查您的配置";
            }
        }
        /// <summary>
        /// 开始打印上一次的内容
        /// </summary>
        /// <param name="err">错误信息</param>
        public void StartPrintLast(ref string err)
        {
            var printRecord = SingtonConfigContent.Instance().LastPrintRecord;

            err = CheckConfig();
            if (null == err) // 检查配置并打印
            {
                StartPrintNew(printRecord, ref err);
            }
        }

        // 检查打印机配置
        private string CheckConfig()
        {
            var printerConfig = SingtonConfigContent.Instance().Printer;
            // 调用响应的数据
            if (null == printerConfig.PrinterName ||
                0 >= printerConfig.PrinterName.Trim().Length)
            {
                return "未配置打印机名，请前往\"文件->参数设置\"，进行配置！";
            }

            if (null == printerConfig.LabelTemplatPath ||
                0 >= printerConfig.LabelTemplatPath.Trim().Length)
            {
                return "未配置标签模板，请前往\"文件->参数设置\"，进行配置！";
            }

            if (!File.Exists(printerConfig.LabelTemplatPath.Trim()))
            {
                return "已配置标签模板，但未找到对应模板文件，请前往\"文件->参数设置\"，进行配置！";
            }
            return null;
        }
    }
}
