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
    public partial class FrmChangePSW : Form
    {
        public FrmChangePSW()
        {
            InitializeComponent();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                this.txtOldPassword.SelectAll();
                this.txtOldPassword.SelectionLength= this.txtOldPassword.Text.Length;
                this.txtOldPassword.Focus();
            }
        }

        private void txtOldPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtNewPassword.SelectAll();
                this.txtNewPassword.SelectionLength = this.txtNewPassword.Text.Length;
                this.txtNewPassword.Focus();
            }
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtConfirmPasswrd.SelectAll();
                this.txtConfirmPasswrd.SelectionLength = this.txtConfirmPasswrd.Text.Length;
                this.txtConfirmPasswrd.Focus();
            }
        }

        private void txtConfirmPasswrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnSubmit.Focus();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";

            if(this.txtUserName.Text!=FrmMain.userinfo.UserName)
            {
                MessageBox.Show("只能修改当前用户的密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtUserName.SelectAll();
                this.txtUserName.SelectionLength = this.txtUserName.Text.Length;
                this.txtUserName.Focus();
                return;
            }

            if (this.txtNewPassword.Text != this.txtConfirmPasswrd.Text)
            {
                MessageBox.Show("新密码输入有误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewPassword.SelectAll();
                this.txtNewPassword.SelectionLength = this.txtNewPassword.Text.Length;
                this.txtNewPassword.Focus();
                return;
            }

            System.Data.DataSet dsTemp = new DataSet();
            string sql = "select * from [SprayLacquerManagement].[dbo].[SecurityUser] where [UserID]='" + this.txtUserName.Text + "' and [UserPassword]='" + this.txtOldPassword.Text + "' ";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (dsTemp.Tables[0].Rows.Count >= 1)
                {
                    //Update Password
                    sql = "update [SprayLacquerManagement].[dbo].[SecurityUser] set [Userpassword]='" + this.txtNewPassword.Text + "' where [UserID]='" + txtUserName.Text + "' ";
                    if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == false)
                    {
                        MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("密码修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("无效的用户名或者密码不匹配!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
