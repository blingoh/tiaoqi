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
using System.Windows.Forms;

namespace 调漆工艺管理系统
{
    public partial class FrmMainPartInputSecondSolution : Form
    {
        public FrmMainPartInputSecondSolution()
        {
            InitializeComponent();
            this.txtBarCode.Focus();
        }

        public bool CheckPartNumber(string sPartNumber, ref string sErrorMessage)
        {
            if(sPartNumber.Length<=0)
            {
                sErrorMessage = "请扫描输入原油料号!";
                return false;
            }

            System.Data.DataSet dsTemp = new DataSet();
            string sql = "select * from [SprayLacquerManagement].[dbo].[PartsInfo] where [PartNumber]='" + sPartNumber + "' and [BOMID]='" + FrmMain.BOMID + "' and [PartType]='MAIN' ";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                if (dsTemp.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    sErrorMessage = "主剂料号和对应的机种、品名不匹配，请确认!";
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool CheckLotNumber(ref string sErrorMessage)
        {
            if(this.txtLotNumber.Text.Length<=0)
            {
                MessageBox.Show("请扫描输入批次号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLotNumber.SelectAll();
                this.txtLotNumber.SelectionLength = this.txtLotNumber.Text.Length;
                this.txtLotNumber.Focus();
                return false ;
            }
            else
            {
                return true;
            }
        }

        private void SubmitMainPart()
        {
            string sErrorMessage = "";
            string sPartNumber = "";
            string sLotNumber = "";

            sPartNumber=this.txtPartNumber.Text;
            sLotNumber=this.txtLotNumber.Text;

            //Check Main Part Number
            if (CheckPartNumber(sPartNumber, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPartNumber.SelectAll();
                this.txtPartNumber.SelectionLength = this.txtPartNumber.Text.Length;
                this.txtBarCode.Focus();
                return;
            }

            if(CheckLotNumber(ref sErrorMessage)==false)
            {
                return;
            }

            FrmMain.productiondata.VendorCodeMain = "";
            FrmMain.productiondata.PartNumberMain = sPartNumber;
            FrmMain.productiondata.LotNumberMain = sLotNumber;

            DialogResult = DialogResult.Yes;
            this.Close();            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitMainPart();
        }

        private void txtPartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            string sErrorMessage = "";
            if (e.KeyValue == 13)
            {
                //Check Main Part Number
                if (CheckPartNumber(this.txtPartNumber.Text, ref sErrorMessage) == false)
                {
                    MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtPartNumber.SelectAll();
                    this.txtPartNumber.SelectionLength = this.txtPartNumber.Text.Length;
                    this.txtBarCode.Focus();
                    return;
                }
                else
                {
                    this.txtLotNumber.SelectAll();
                    this.txtLotNumber.SelectionLength = this.txtLotNumber.Text.Length;
                    this.txtBarCode.Focus();
                }
            }
        }

        private void txtLotNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSubmit.Focus();
            }
        }

        private void OnBarCodeContentChanged(object sender, EventArgs e)
        {
            ParseCode((sender as TextBox).Text);

        }

        private void OnMainCodeRuleClicked(object sender, EventArgs e)
        {
            BarcodeSettings codeSettings = new BarcodeSettings();
            codeSettings.BarCode = txtBarCode.Text;
            codeSettings.CodeRule = FrmMain.mainCoeRule.MainCodeRule;
            if (codeSettings.ShowDialog(this) == DialogResult.OK)
            {
                var mainRule = codeSettings.CodeRule;
                FrmMain.mainCoeRule.MainCodeRule = mainRule;
                clsIniFile clsif = new clsIniFile(clsApp.filepath);
                clsif.Write("CodeRule", "MainCodeRule", mainRule);

                ParseCode(txtBarCode.Text);
            }
        }

        private void ParseCode(string content)
        {
            IBarCodeParser mainNumParser = null;
            IBarCodeParser batchNumParser = null;
            if (null != FrmMain.mainCoeRule.MainCodeRule &&
                0 < FrmMain.mainCoeRule.MainCodeRule.Trim().Length)
            {
                mainNumParser = new RuledParser();
            }
            if (null != FrmMain.mainCoeRule.MainNumRule &&
                0 < FrmMain.mainCoeRule.MainNumRule.Trim().Length)
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
                    txtPartNumber.Text = mainNumParser.ParseMainNum(txtBarCode.Text, FrmMain.mainCoeRule.MainCodeRule);
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
                    txtLotNumber.Text = batchNumParser.ParseBatchNum(txtBarCode.Text, FrmMain.mainCoeRule.MainNumRule);
                }
                catch
                {
                    txtLotNumber.Text = "";
                    // txtLotNumber.Text = batchNumParser.ParseMainNum(txtBarCode.Text, FrmMain.mainCoeRule.MainNumRule);
                }
            }

        }

        private void OnMainNumCodeRuleClicked(object sender, EventArgs e)
        {
            BarcodeSettings codeSettings = new BarcodeSettings();
            codeSettings.BarCode = txtBarCode.Text;
            codeSettings.CodeRule = FrmMain.mainCoeRule.MainNumRule;
            if (codeSettings.ShowDialog(this) == DialogResult.OK)
            {
                var mainNumRule = codeSettings.CodeRule;
                FrmMain.mainCoeRule.MainNumRule = mainNumRule;
                clsIniFile clsif = new clsIniFile(clsApp.filepath);
                clsif.Write("CodeRule", "MainNumCodeRule", mainNumRule);
                ParseCode(txtBarCode.Text);
            }
        }
    }
}
