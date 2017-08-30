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
    public partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
        }

        #region Function
        public bool ShowConfigurationInfo(ref string sErrorMessage)
        {
            try
            {
                //Database
                this.txtServerName.Text = FrmMain.systemconfig.ServerName;
                this.txtDBUserID.Text = FrmMain.systemconfig.UserID;
                this.txtDBPSW.Text = FrmMain.systemconfig.Password;

                //Printer
                this.txtPrinterName.Text = FrmMain.systemconfig.PrinterPath;
                this.txtLabelTemplate.Text = FrmMain.systemconfig.LabelTemplatePath;

                //Scale Main Serial Port
                this.badrateScaleMain.Text = FrmMain.systemconfig.ScaleMainPortSettings.BaudRate.ToString();
                this.databitScaleMain.Text = FrmMain.systemconfig.ScaleMainPortSettings.DataBits.ToString();
                this.parityScaleMain.Text = FrmMain.systemconfig.ScaleMainPortSettings.Parity.ToString();
                this.comScaleMain.Value = FrmMain.systemconfig.ScaleMainPortSettings.PortNum;
                this.stopbitScaleMain.Text = FrmMain.systemconfig.ScaleMainPortSettings.StopBits.ToString();

                //Scale GuHua Serial Port
                this.badrateScaleGuHua.Text = FrmMain.systemconfig.ScaleGuHuaPortSettings.BaudRate.ToString();
                this.databitScaleGuHua.Text = FrmMain.systemconfig.ScaleGuHuaPortSettings.DataBits.ToString();
                this.parityScaleGuHua.Text = FrmMain.systemconfig.ScaleGuHuaPortSettings.Parity.ToString();
                this.comScaleGuHua.Value = FrmMain.systemconfig.ScaleGuHuaPortSettings.PortNum;
                this.stopbitScaleGuHua.Text = FrmMain.systemconfig.ScaleXiShiPortSettings.StopBits.ToString();

                //Scale XiShi Serial Port
                this.badrateScaleXiShi.Text = FrmMain.systemconfig.ScaleXiShiPortSettings.BaudRate.ToString();
                this.databitScaleXiShi.Text = FrmMain.systemconfig.ScaleXiShiPortSettings.DataBits.ToString();
                this.parityScaleXiShi.Text = FrmMain.systemconfig.ScaleXiShiPortSettings.Parity.ToString();
                this.comScaleXiShi.Value = FrmMain.systemconfig.ScaleXiShiPortSettings.PortNum;
                this.stopbitScaleXiShi.Text = FrmMain.systemconfig.ScaleXiShiPortSettings.StopBits.ToString();
                
                //System parameters
                this.txtGuHuaRange.Text = FrmMain.systemconfig.GuHuaRange.ToString();
                if(FrmMain.systemconfig.AutoScaleHolderWeight ==1)
                {
                    cbScaleHolderWeight.Checked = true;
                }
                else
                {
                    cbScaleHolderWeight.Checked = false;
                }

                return true;
            }
            catch (Exception e)
            {
                sErrorMessage = e.Message.ToString();
                return false;
            }
        }

        public bool SaveConfiguration(ref string sErrorMessage)
        {
            try
            { 
                FrmMain.systemconfig.ServerName = this.txtServerName.Text;
                FrmMain.systemconfig.UserID = this.txtDBUserID.Text;
                FrmMain.systemconfig.Password = this.txtDBPSW.Text;

                FrmMain.systemconfig.PrinterPath = this.txtPrinterName.Text;
                FrmMain.systemconfig.LabelTemplatePath = this.txtLabelTemplate.Text;

                //Serial Port Main
                FrmMain.systemconfig.ScaleMainPortSettings.BaudRate = int.Parse(this.badrateScaleMain.Text.ToString());
                FrmMain.systemconfig.ScaleMainPortSettings.DataBits = int.Parse(this.databitScaleMain.Text.ToString());
                FrmMain.systemconfig.ScaleMainPortSettings.Parity = this.parityScaleMain.Text.ToString();
                FrmMain.systemconfig.ScaleMainPortSettings.PortNum = int.Parse(this.comScaleMain.Value.ToString());
                FrmMain.systemconfig.ScaleMainPortSettings.StopBits =int.Parse(this.stopbitScaleMain.Text.ToString());

                //Serial Port GuHua
                FrmMain.systemconfig.ScaleGuHuaPortSettings.BaudRate = int.Parse(this.badrateScaleGuHua.Text.ToString());
                FrmMain.systemconfig.ScaleGuHuaPortSettings.DataBits = int.Parse(this.databitScaleGuHua.Text.ToString());
                FrmMain.systemconfig.ScaleGuHuaPortSettings.Parity = this.parityScaleGuHua.Text.ToString();
                FrmMain.systemconfig.ScaleGuHuaPortSettings.PortNum = int.Parse(this.comScaleGuHua.Value.ToString());
                FrmMain.systemconfig.ScaleGuHuaPortSettings.StopBits = int.Parse(this.stopbitScaleGuHua.Text.ToString());

                //Serial Port XiSHi
                FrmMain.systemconfig.ScaleXiShiPortSettings.BaudRate = int.Parse(this.badrateScaleXiShi.Text.ToString());
                FrmMain.systemconfig.ScaleXiShiPortSettings.DataBits = int.Parse(this.databitScaleXiShi.Text.ToString());
                FrmMain.systemconfig.ScaleXiShiPortSettings.Parity = this.parityScaleXiShi.Text.ToString();
                FrmMain.systemconfig.ScaleXiShiPortSettings.PortNum = int.Parse(this.comScaleXiShi.Value.ToString());
                FrmMain.systemconfig.ScaleXiShiPortSettings.StopBits = int.Parse(this.stopbitScaleXiShi.Text.ToString());

                FrmMain.systemconfig.GuHuaRange = int.Parse(this.txtGuHuaRange.Text);
                if(cbScaleHolderWeight.Checked==true )
                {
                    FrmMain.systemconfig.AutoScaleHolderWeight = 1;
                }
                else
                {
                    FrmMain.systemconfig.AutoScaleHolderWeight = 0;
                }

                clsIniFile clsif = new clsIniFile(clsApp.filepath);

                //Database
                clsif.WriteInifile("Database", "ServerName", FrmMain.systemconfig.ServerName.ToString());
                clsif.WriteInifile("Database", "UserName", FrmMain.systemconfig.UserID.ToString());
                clsif.WriteInifile("Database", "Password", FrmMain.systemconfig.Password.ToString());

                //Printer
                clsif.WriteInifile("Printer", "PrinterPath", FrmMain.systemconfig.PrinterPath.ToString());
                clsif.WriteInifile("Printer", "LabelTemplate", FrmMain.systemconfig.LabelTemplatePath.ToString());
                
                //Scale Serial Port
                clsif.WriteInifile("ScaleMain", "BaudRate", FrmMain.systemconfig.ScaleMainPortSettings.BaudRate.ToString());
                clsif.WriteInifile("ScaleMain", "PortNum", FrmMain.systemconfig.ScaleMainPortSettings.PortNum.ToString());
                clsif.WriteInifile("ScaleMain", "Parity", FrmMain.systemconfig.ScaleMainPortSettings.Parity.ToString());
                clsif.WriteInifile("ScaleMain", "DataBits", FrmMain.systemconfig.ScaleMainPortSettings.DataBits.ToString());
                clsif.WriteInifile("ScaleMain", "StopBits", FrmMain.systemconfig.ScaleMainPortSettings.StopBits.ToString());
                
                //Scale Serial Port
                clsif.WriteInifile("ScaleGuHua", "BaudRate", FrmMain.systemconfig.ScaleGuHuaPortSettings.BaudRate.ToString());
                clsif.WriteInifile("ScaleGuHua", "PortNum", FrmMain.systemconfig.ScaleGuHuaPortSettings.PortNum.ToString());
                clsif.WriteInifile("ScaleGuHua", "Parity", FrmMain.systemconfig.ScaleGuHuaPortSettings.Parity.ToString());
                clsif.WriteInifile("ScaleGuHua", "DataBits", FrmMain.systemconfig.ScaleGuHuaPortSettings.DataBits.ToString());
                clsif.WriteInifile("ScaleGuHua", "StopBits", FrmMain.systemconfig.ScaleGuHuaPortSettings.StopBits.ToString());

                //Scale Serial Port
                clsif.WriteInifile("ScaleXiShi", "BaudRate", FrmMain.systemconfig.ScaleXiShiPortSettings.BaudRate.ToString());
                clsif.WriteInifile("ScaleXiShi", "PortNum", FrmMain.systemconfig.ScaleXiShiPortSettings.PortNum.ToString());
                clsif.WriteInifile("ScaleXiShi", "Parity", FrmMain.systemconfig.ScaleXiShiPortSettings.Parity.ToString());
                clsif.WriteInifile("ScaleXiShi", "DataBits", FrmMain.systemconfig.ScaleXiShiPortSettings.DataBits.ToString());
                clsif.WriteInifile("ScaleXiShi", "StopBits", FrmMain.systemconfig.ScaleXiShiPortSettings.StopBits.ToString());

                //System parameters
                clsif.WriteInifile("Parameters", "GuHuaRange", FrmMain.systemconfig.GuHuaRange.ToString());
                clsif.WriteInifile("Parameters", "AutoScaleHolderWeight", FrmMain.systemconfig.AutoScaleHolderWeight.ToString());

                return true;
            }
            catch(Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            if (SaveConfiguration(ref sErrorMessage)==true)
            { 
            this.btnOK.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnApply.Enabled = true;
            MessageBox.Show("参数保存成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
            }
            else
            {
                MessageBox.Show("参数保存失败!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            this.btnOK.Enabled = false;
            this.btnCancel.Enabled = false;

            if (FrmMain.ReadSystemConfigurationInfo(ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowConfigurationInfo(ref sErrorMessage);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.btnApply.Enabled = false;
            this.btnOK.Enabled = true;
            this.btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            ShowConfigurationInfo(ref sErrorMessage);

            this.btnOK.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnApply.Enabled = true;
        }

        private void btnLoadAntiFake_Click(object sender, EventArgs e)
        {
            string sFileName="";
            string sErrorMessage="";

            if(clsApp.OpenBTWFile(ref sFileName,ref sErrorMessage)==true)
            {
                txtLabelTemplate.Text = sFileName;
            }
        }
    }
}
