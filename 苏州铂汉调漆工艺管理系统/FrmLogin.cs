using System ;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace 调漆工艺管理系统
{
    public partial class FrmLogin : Form
    {
        private static string REG_SECURITY_KEY = "Security\\AccountOption\\Pass";
        public FrmLogin()
        {
            InitializeComponent();

            RegReaderWriter regRw = new RegReaderWriter();
            bool hasAccount = regRw.HasKey(REG_SECURITY_KEY);

            if (hasAccount)
            {
                string account = (string) regRw.GetValue(REG_SECURITY_KEY, "account");
                string pwd = (string) regRw.GetValue(REG_SECURITY_KEY, "pwd");
                
                if (null != account)
                {
                    account = Encoding.UTF8.GetString(Convert.FromBase64String(account));
                }

                if (null != pwd)
                {
                    pwd = Encoding.UTF8.GetString(Convert.FromBase64String(pwd));
                }

                txtUserName.Text = account;
                txtPassword.Text = pwd;
                FrmMain.userinfo.UserName = account;
                FrmMain.userinfo.Password = pwd;

                if (null != account || null != pwd)
                {
                    chkRemember.Checked = true;
                }
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.txtPassword.SelectAll();
                this.txtPassword.SelectionLength = this.txtPassword.Text.Length;
                this.txtPassword.Focus();
            }
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";

            System.Data.DataSet dsTemp = new DataSet();
            string sql = "select * from [SprayLacquerManagement].[dbo].[SecurityUser] where [UserID]='" + this.txtUserName.Text + "' and [UserPassword]='" + this.txtPassword.Text + "' ";
            if (clsApp.GetDataSet(sql, new DbConfigReader().GenerateConnectionString(), ref dsTemp, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (dsTemp.Tables[0].Rows.Count >= 1)
                {
                    FrmMain.userinfo.UserName = this.txtUserName.Text;
                    FrmMain.userinfo.SecurityRight = dsTemp.Tables[0].Rows[0]["SecurityRight"].ToString();
                    DialogResult = DialogResult.Yes;

                    if (chkRemember.Checked)
                    {
                        // 存储账号
                        string accountStr = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtUserName.Text));
                        // 是否存储密码
                        string pwdStr = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtPassword.Text));

                        RegReaderWriter regRW = new RegReaderWriter();
                        regRW.WriteValueForKey("Security\\AccountOption\\Pass", "account", accountStr);
                        regRW.WriteValueForKey("Security\\AccountOption\\Pass", "pwd", pwdStr);
                    } else
                    {
                        // 删除键值
                        DeleteRegKey();
                    }
                }
                else
                {
                    MessageBox.Show("请检查用户名或密码!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtUserName.SelectAll();
                    this.txtUserName.SelectionLength = this.txtUserName.Text.Length;
                    this.txtUserName.Focus();
                    DeleteRegKey();
                    return;
                }
            }
        }

        /// <summary>
        /// 删除用户信息注册表
        /// </summary>
        private void DeleteRegKey()
        {
            var reg = new RegReaderWriter();
            reg.DeleteValue(REG_SECURITY_KEY , "account");
            reg.DeleteValue(REG_SECURITY_KEY , "pwd");
        }
        
    }
}
