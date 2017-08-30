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
    public partial class FrmXiShiPartInput : Form
    {
        public FrmXiShiPartInput()
        {
            InitializeComponent();
        }

        private void txtVendorCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
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

        public bool CheckPartNumber(string sPartNumber, ref string sErrorMessage)
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sql = "select * from [SprayLacquerManagement].[dbo].[PartsInfo] where [PartNumber]='" + sPartNumber + "' and [BOMID]='" + FrmMain.BOMID + "' and [PartType]='XISHI' ";
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";

            //Check GU Hua Part Number
            if (CheckPartNumber(this.txtPartNumber.Text, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPartNumber.SelectAll();
                this.txtPartNumber.SelectionLength = this.txtPartNumber.Text.Length;
                this.txtPartNumber.Focus();
                return;
            }
            else
            {
                FrmMain.productiondata.VendorCodeXiShi = "";
                FrmMain.productiondata.PartNumberXiShi = this.txtPartNumber.Text;
                FrmMain.productiondata.LotNumberXiShi = this.txtLotNumber.Text;

                DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void BtnMainCodeRuleClicked(object sender, EventArgs e)
        {
            BarcodeSettings codeSettings = new BarcodeSettings();
            codeSettings.BarCode = txtBarCode.Text;
            codeSettings.CodeRule = FrmMain.xishiCodeRule.MainCodeRule;
            if (codeSettings.ShowDialog(this) == DialogResult.OK)
            {
                var mainRule = codeSettings.CodeRule;
                FrmMain.xishiCodeRule.MainCodeRule = mainRule;
                clsIniFile clsif = new clsIniFile(clsApp.filepath);
                clsif.Write("CodeRule", "XiShiMainCodeRule", mainRule);

                ParseCode(txtBarCode.Text);
            }
        }

        private void btnLotNumRuleClicked(object sender, EventArgs e)
        {
            BarcodeSettings codeSettings = new BarcodeSettings();
            codeSettings.BarCode = txtBarCode.Text;
            codeSettings.CodeRule = FrmMain.xishiCodeRule.MainNumRule;
            if (codeSettings.ShowDialog(this) == DialogResult.OK)
            {
                var mainNumRule = codeSettings.CodeRule;
                FrmMain.xishiCodeRule.MainNumRule = mainNumRule;
                clsIniFile clsif = new clsIniFile(clsApp.filepath);
                clsif.Write("CodeRule", "XiShiMainNumCodeRule", mainNumRule);
                ParseCode(txtBarCode.Text);
            }
        }

        private void OnBarCodeContentChanged(object sender, EventArgs e)
        {
            ParseCode((sender as TextBox).Text);
        }

        private void ParseCode(string content)
        {
            IBarCodeParser mainNumParser = null;
            IBarCodeParser batchNumParser = null;
            if (null != FrmMain.xishiCodeRule.MainCodeRule &&
                0 < FrmMain.xishiCodeRule.MainCodeRule.Trim().Length)
            {
                mainNumParser = new RuledParser();
            }
            if (null != FrmMain.xishiCodeRule.MainNumRule &&
                0 < FrmMain.xishiCodeRule.MainNumRule.Trim().Length)
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
                    txtPartNumber.Text = mainNumParser.ParseMainNum(txtBarCode.Text, FrmMain.xishiCodeRule.MainCodeRule);
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
                    txtLotNumber.Text = batchNumParser.ParseBatchNum(txtBarCode.Text, FrmMain.xishiCodeRule.MainNumRule);
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
