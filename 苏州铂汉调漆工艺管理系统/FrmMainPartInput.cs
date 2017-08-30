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
    public partial class FrmMainPartInput : Form
    {
        public FrmMainPartInput()
        {
            InitializeComponent();
        }

        public bool CheckPartNumber(string sPartNumber, ref string sErrorMessage)
        {
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

        private void txtVendorCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SubmitMainPart();
            }
        }

        private void SubmitMainPart()
        {
            string sErrorMessage = "";
            string sPartNumber = "";
            string sLotNumber = "";

            string[] xx = this.txtVendorCode.Text.Split('-');
            if (xx.Length != 7)
            {
                MessageBox.Show("请扫描正确的二维条码 ", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtVendorCode.SelectAll();
                this.txtVendorCode.SelectionLength = this.txtVendorCode.Text.Length;
                this.txtVendorCode.Focus();
            }
            else
            {
                this.txtVendorCode.Text = xx[1];
                sPartNumber = xx[4];
                sLotNumber = xx[5];

                //Check Main Part Number
                if (CheckPartNumber(sPartNumber, ref sErrorMessage) == false)
                {
                    MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtVendorCode.SelectAll();
                    this.txtVendorCode.SelectionLength = this.txtVendorCode.Text.Length;
                    this.txtVendorCode.Focus();
                    return;
                }
                else
                {
                    FrmMain.productiondata.VendorCodeMain = this.txtVendorCode.Text;
                    FrmMain.productiondata.PartNumberMain = sPartNumber;
                    FrmMain.productiondata.LotNumberMain = sLotNumber;

                    DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
        }

        private void FrmMainPartInput_Load(object sender, EventArgs e)
        {
            this.txtVendorCode.SelectAll();
            this.txtVendorCode.SelectionLength = this.txtVendorCode.Text.Length;
            this.txtVendorCode.Focus();
            return;
        }
    }
}
