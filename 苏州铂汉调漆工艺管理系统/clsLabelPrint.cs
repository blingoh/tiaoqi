using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 调漆工艺管理系统
{
    public class clsLabelPrint
    {
        //public static bool PrintLabel(string sLabelPath, string sPrintPath, string sItem1, string sItem2, string sItem3, ref string sErrorMessage)
        //{
        //    try
        //    {
        //        BarTender.ApplicationClass barapp = new BarTender.ApplicationClass();
        //        BarTender.Format format = barapp.Formats.Open(sLabelPath, false, sPrintPath);
        //        format.SetNamedSubStringValue("PartName", sItem1);
        //        format.SetNamedSubStringValue("PartNumber", sItem2);
        //        format.SetNamedSubStringValue("Operator", sItem3);
        //        format.PrintOut(false, false);
        //        format.Close(BarTender.BtSaveOptions.btDoNotSaveChanges);
        //        barapp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges);
        //        sErrorMessage = "";
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        sErrorMessage = ex.Message.ToString();
        //        return false;
        //    }
        //}
    }
}
