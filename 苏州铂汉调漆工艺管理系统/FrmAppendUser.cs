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
    public partial class FrmAppendUser : Form
    {
        public FrmAppendUser()
        {
            InitializeComponent();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                this.txtPassword.SelectAll();
                this.txtPassword.SelectionLength = this.txtPassword.Text.Length;
                this.txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                btnAppend.Focus();
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";

            if(cmbSecurityRight.Text.Length <=0)
            {
                MessageBox.Show("请选择用户权限类别!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(this.txtUser.Text.Length <=0)
            {
                MessageBox.Show("请输入用户账号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(this.txtPassword.Text.Length<=0)
            {
                MessageBox.Show("请输入用户密码!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "insert into [SprayLacquerManagement].[dbo].[SecurityUser]([UserID],[UserPassword],[SecurityRight]) values('" + txtUser.Text + "','" + txtPassword.Text + "','" + cmbSecurityRight.Text + "')";
            if(clsApp.ExecuteSQL(sql, new DbConfigReader().GenerateConnectionString(), ref sErrorMessage)==true)
            {
                MessageBox.Show("新用户添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh DB
                DataBind("select [UserID] as '用户名', [UserPassword] as '密码',[SecurityRight] as '角色' from [SprayLacquerManagement].[dbo].[SecurityUser]");
                ClearText();
                return;
            }
            else
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        public void DataBind(string sql)
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sErrorMessage = "";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                this.dgUserInfo.DataSource = dsTemp.Tables[0].DefaultView;
                dgUserInfo.Refresh();
            }
            else
            {
                dgUserInfo.DataSource = null;
                dgUserInfo.Refresh();
            }
        }

        private void ClearText()
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void FrmAppendUser_Load(object sender, EventArgs e)
        {
            DataBind("select [UserID] as '用户名', [UserPassword] as '密码',[SecurityRight] as '角色' from [SprayLacquerManagement].[dbo].[SecurityUser]");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";

            if (cmbSecurityRight.Text.Length <= 0)
            {
                MessageBox.Show("请选择用户权限类别!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.txtUser.Text.Length <= 0)
            {
                MessageBox.Show("请输入用户账号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.txtPassword.Text.Length <= 0)
            {
                MessageBox.Show("请输入用户密码!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "update [SprayLacquerManagement].[dbo].[SecurityUser] set [UserPassword]='" + txtPassword.Text + "',[SecurityRight]='" + cmbSecurityRight.Text + "' where [UserID]='" + txtUser.Text + "'";
            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == true)
            {
                MessageBox.Show("用户信息修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh DB
                //Refresh DB
                DataBind("select [UserID] as '用户名', [UserPassword] as '密码',[SecurityRight] as '角色' from [SprayLacquerManagement].[dbo].[SecurityUser]");
                ClearText();
                return;
            }
            else
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            if (this.txtUser.Text.Length <= 0)
            {
                MessageBox.Show("请输入用户账号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }

            string sql = "delete from [SprayLacquerManagement].[dbo].[SecurityUser] where [UserID]='" + txtUser.Text + "'";
            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == true)
            {
                MessageBox.Show("用户信息删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh DB
                DataBind("select [UserID] as '用户名', [UserPassword] as '密码',[SecurityRight] as '角色' from [SprayLacquerManagement].[dbo].[SecurityUser]");
                ClearText();
                return;
            }
            else
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgUserInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = this.dgUserInfo.CurrentRow.Index;

            this.txtUser.Text = dgUserInfo.Rows[i].Cells[0].Value.ToString();
            this.txtPassword.Text = dgUserInfo.Rows[i].Cells[1].Value.ToString();
            this.cmbSecurityRight.Text = dgUserInfo.Rows[i].Cells[2].Value.ToString();

        }
    }
}
