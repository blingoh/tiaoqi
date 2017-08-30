using BarCodeParser;
using cc.gtscloud.BarCodeParser;
using cc.gtscloud.EightPartBarCodeParser;
using SevenPartBarCodeParser;
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
    public partial class FrmGuHuaPartInput : Form
    {
        public FrmGuHuaPartInput()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            
            //Check GU Hua Part Number
            if(CheckPartNumber(this.txtPartNumber.Text,ref sErrorMessage)==false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPartNumber.SelectAll();
                this.txtPartNumber.SelectionLength = this.txtPartNumber.Text.Length;
                this.txtPartNumber.Focus();
                return;
            }
            else
            {
                FrmMain.productiondata.VendorCodeGuHua = "";
                FrmMain.productiondata.PartNumberGuHua = this.txtPartNumber.Text;
                FrmMain.productiondata.LotNumberGuHua = this.txtLotNumber.Text;

                DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        public bool CheckPartNumber(string sPartNumber, ref string sErrorMessage)
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sql = "select * from [SprayLacquerManagement].[dbo].[PartsInfo] where [PartNumber]='" + sPartNumber + "' and [BOMID]='"+FrmMain.BOMID+"' and [PartType]='GUHUA' ";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                if (dsTemp.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    sErrorMessage = "固化剂料号和对应的机种、品名不匹配，请确认!";
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtVendorCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                this.txtPartNumber.SelectAll();
                this.txtPartNumber.SelectionLength = this.txtPartNumber.Text.Length;
                this.txtPartNumber.Focus();
            }
        }

        private void txtPartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.txtLotNumber.SelectAll();
                this.txtLotNumber.SelectionLength = this.txtLotNumber.Text.Length;
                this.txtLotNumber.Focus();
            }
        }

        private void txtLotNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSubmit.Focus();
            }
        }

        private void OnBarValueChanged(object sender, EventArgs e)
        {
            ParseCode((sender as TextBox).Text);
        }

        private void OnBtnPartNumClicked(object sender, EventArgs e)
        {
            BarcodeSettings codeSettings = new BarcodeSettings();
            codeSettings.BarCode = txtBarCode.Text;
            codeSettings.CodeRule = FrmMain.guhuaCodeRule.MainCodeRule;
            if (codeSettings.ShowDialog(this) == DialogResult.OK)
            {
                var mainRule = codeSettings.CodeRule;
                FrmMain.guhuaCodeRule.MainCodeRule = mainRule;
                clsIniFile clsif = new clsIniFile(clsApp.filepath);
                clsif.Write("CodeRule", "GuHuaMainCodeRule", mainRule);

                ParseCode(txtBarCode.Text);
            }
        }

        private void OnBtnLotNumClicked(object sender, EventArgs e)
        {
            BarcodeSettings codeSettings = new BarcodeSettings();
            codeSettings.BarCode = txtBarCode.Text;
            codeSettings.CodeRule = FrmMain.guhuaCodeRule.MainNumRule;
            if (codeSettings.ShowDialog(this) == DialogResult.OK)
            {
                var mainNumRule = codeSettings.CodeRule;
                FrmMain.guhuaCodeRule.MainNumRule = mainNumRule;
                clsIniFile clsif = new clsIniFile(clsApp.filepath);
                clsif.Write("CodeRule", "GuHuaMainNumCodeRule", mainNumRule);
                ParseCode(txtBarCode.Text);
            }
        }

        private void ParseCode(string content)
        {
            IBarCodeParser mainNumParser = null;
            IBarCodeParser batchNumParser = null;
            if (null != FrmMain.guhuaCodeRule.MainCodeRule &&
                0 < FrmMain.guhuaCodeRule.MainCodeRule.Trim().Length)
            {
                mainNumParser = new RuledParser();
            }
            if (null != FrmMain.guhuaCodeRule.MainNumRule &&
                0 < FrmMain.guhuaCodeRule.MainNumRule.Trim().Length)
            {
                batchNumParser = new RuledParser();
            }
            //if (null == mainNumParser && 7 == content.Split('-').Length)
            //{
            //    mainNumParser = new SevenPartParser();
            //}
            //else if (null == mainNumParser && 8 == content.Split('-').Length)
            //{
            //    mainNumParser = new EightPartParser();
            //}

            //if (null == batchNumParser && 7 == content.Split('-').Length)
            //{
            //    batchNumParser = new SevenPartParser();
            //}
            //else if (null == batchNumParser && 8 == content.Split('-').Length)
            //{
            //    batchNumParser = new EightPartParser();
            //}

            if (null == mainNumParser)
            {
                mainNumParser = new GenerateParser();
            }

            if (null == batchNumParser)
            {
                batchNumParser = new GenerateParser();
            }

            if (null != mainNumParser)
            {
                try
                {
                    txtPartNumber.Text = mainNumParser.ParseMainNum(txtBarCode.Text, FrmMain.guhuaCodeRule.MainCodeRule);
                }
                catch
                {
                    txtPartNumber.Text = "";
                }
            }

            if (null != mainNumParser)
            {
                try
                {
                    txtLotNumber.Text = batchNumParser.ParseBatchNum(txtBarCode.Text, FrmMain.guhuaCodeRule.MainNumRule);
                }
                catch
                {
                    txtLotNumber.Text = "";
                    // txtLotNumber.Text = batchNumParser.ParseMainNum(txtBarCode.Text, FrmMain.mainCoeRule.MainNumRule);
                }
            }

        }
    }
}
