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
    public partial class FrmRegister : Form
    {
        

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void txtRegColumn1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                this.txtRegColumn2.SelectAll();
                this.txtRegColumn2.SelectionLength = this.txtRegColumn2.Text.Length;
                this.txtRegColumn2.Focus();
            }
        }

        private void txtRegColumn2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.txtRegColumn3.SelectAll();
                this.txtRegColumn3.SelectionLength = this.txtRegColumn3.Text.Length;
                this.txtRegColumn3.Focus();
            }
        }

        private void txtRegColumn3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.txtRegColumn4.SelectAll();
                this.txtRegColumn4.SelectionLength = this.txtRegColumn4.Text.Length;
                this.txtRegColumn4.Focus();
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            string sCustomerInfo = clsComputerInfo.GetCustomerInfo();
            FrmMain.sCustomerInfo = sCustomerInfo;

            if(FrmMain.RegisterStatus==true)
            {
                lblInfo.Text = "感谢您使用本产品，产品序列号如下:";
                txtRegColumn1.Text = FrmMain.RegCode.Substring(0, 4);
                txtRegColumn2.Text = FrmMain.RegCode.Substring(4, 4);
                txtRegColumn3.Text = FrmMain.RegCode.Substring(8, 4);
                txtRegColumn4.Text = FrmMain.RegCode.Substring(12, 4);

                this.txtPCCode.Text = FrmMain.sCustomerInfo;
                btnRegister.Visible = false;
            }
            else
            {
                lblInfo.Text = "请输入产品序列号，完成注册!";
                txtRegColumn1.Text = "";
                txtRegColumn2.Text = "";
                txtRegColumn3.Text = "";
                txtRegColumn4.Text = "";
                
                this.txtPCCode.Text = sCustomerInfo;
                btnRegister.Visible = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            string sRegCode=txtRegColumn1.Text.ToUpper()+txtRegColumn2.Text.ToUpper()+txtRegColumn3.Text.ToUpper()+txtRegColumn4.Text.ToUpper();
            string sCustomerInfoRes=clsComputerInfo.Decrypt(sRegCode, "F");
            string sCustomerInfo = clsComputerInfo.GetCustomerInfo();
            if(sCustomerInfoRes!=sCustomerInfo)
            {
                MessageBox.Show("无效的注册码，不可以注册!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Append into DB  sCustomerInfo,sRegCode
                string sql = "insert into [SprayLacquerManagement].[dbo].[Register]([UserInfo],[SerialNumber]) values('" + sCustomerInfo + "','" + sRegCode + "')";
                if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == false)
                {
                    MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    lblInfo.Text = "感谢您使用本产品，产品序列号如下:";
                    MessageBox.Show("产品注册成功,您可以使用本产品的所有功能!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnRegister.Visible = false;
                    return;
                }
            }
        }
    }
}
