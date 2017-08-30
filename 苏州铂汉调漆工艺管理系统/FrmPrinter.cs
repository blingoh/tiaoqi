using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 调漆工艺管理系统
{
    public partial class FrmPrinter : Form
    {
        public FrmPrinter()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //**********Print Label***********
            string sErrorMessage = "";
            string sLabelPath = FrmMain.systemconfig.LabelTemplatePath;// @"C:\E437908\8-PP\苏州海岸线\苏州铂汉\苏州铂汉调漆工艺管理系统\Software\CurrentSoftware\苏州铂汉调漆工艺管理系统\苏州铂汉调漆工艺管理系统\bin\Debug\Template.BTW";
            string sPrintPath = FrmMain.systemconfig.PrinterPath;// "ZDesigner GT800 (ZPL)";
            clsApp.PrintLabelInit(sLabelPath, sPrintPath,  ref sErrorMessage);
            clsApp.AddPrintVariable("Line", this.txtLine.Text);
            clsApp.AddPrintVariable("YuanYouPartNumber", this.txtYuanYouPartNumber.Text);
            clsApp.AddPrintVariable("GuHuaPartNumber", this.txtGuHuaPartNumber.Text);
            clsApp.AddPrintVariable("XiShiPartNumber", this.txtXiShiPartNumber.Text);
            clsApp.AddPrintVariable("Speed", this.txtSpaintSpeed.Text);
            clsApp.AddPrintVariable("PartNumber", this.txtPartNumber.Text);

            clsApp.AddPrintVariable("Operator", FrmMain.userinfo.UserName);
            clsApp.AddPrintVariable("TiaoQiDT", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            clsApp.AddPrintVariable("YouXiaoDT", System.DateTime.Now.AddHours(int.Parse(this.txtValidHours.Text)).ToString("yyyy-MM-dd HH:mm"));
            
            clsApp.Print(ref sErrorMessage);
            //********************************
        }

        private void FrmPrinter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsIniFile clsif = new clsIniFile(clsApp.filepath);
            string sLine = clsif.ReadString("Printer", "Line");
            string sYuanYou = clsif.ReadString("Printer", "YuanYou");
            string sGuHua = clsif.ReadString("Printer", "GuHua");
            string sXiSHi= clsif.ReadString("Printer", "XiShi");
            string sDateTime = clsif.ReadString("Printer", "DateTime");
            string sValidDateTime = clsif.ReadString("Printer", "ValidDateTime");
            string sSpeed = clsif.ReadString("Printer", "Speed");
            string sOperator = clsif.ReadString("Printer", "Operator");
            string sPartNumber = clsif.ReadString("Printer", "PartNumber");
            int nValidHours=clsif.ReadInt("Printer","nValidHours");

            //**********Print Label***********
            string sErrorMessage = "";
            string sLabelPath = FrmMain.systemconfig.LabelTemplatePath;// @"C:\E437908\8-PP\苏州海岸线\苏州铂汉\苏州铂汉调漆工艺管理系统\Software\CurrentSoftware\苏州铂汉调漆工艺管理系统\苏州铂汉调漆工艺管理系统\bin\Debug\Template.BTW";
            string sPrintPath = FrmMain.systemconfig.PrinterPath;// "ZDesigner GT800 (ZPL)";
            clsApp.PrintLabelInit(sLabelPath, sPrintPath, ref sErrorMessage);
            clsApp.AddPrintVariable("Line", sLine);
            clsApp.AddPrintVariable("PartNumber", sPartNumber);

            clsApp.AddPrintVariable("YuanYouPartNumber", sYuanYou);
            clsApp.AddPrintVariable("GuHuaPartNumber", sGuHua);
            clsApp.AddPrintVariable("XiShiPartNumber", sXiSHi);
            clsApp.AddPrintVariable("Speed",sSpeed);

            clsApp.AddPrintVariable("Operator", sOperator);
            clsApp.AddPrintVariable("TiaoQiDT", sDateTime);
            clsApp.AddPrintVariable("YouXiaoDT", sValidDateTime);

            clsApp.AddPrintVariable("TiaoQiDT", sDateTime);
            clsApp.AddPrintVariable("YouXiaoDT", sValidDateTime);

            clsApp.Print(ref sErrorMessage);
            //********************************

        }
    }
}
