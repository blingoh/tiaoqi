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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
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
            this.txtCustomerName.Text = "";
            this.txtCustomerCode.Text = "";
        }

        private void txtCustomerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                this.txtCustomerName.SelectAll();
                this.txtCustomerName.SelectionLength = this.txtCustomerName.Text.Length;
                this.txtCustomerName.Focus();
            }
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnAppend.Focus();
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";

            if (this.txtCustomerCode.Text.Length <= 0)
            {
                MessageBox.Show("请输入客户代码!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.txtCustomerName.Text.Length <= 0)
            {
                MessageBox.Show("请输入客户名称!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "insert into [SprayLacquerManagement].[dbo].[Customer]([CustomerCode],[CustomerName]) values('" + this.txtCustomerCode.Text + "','" + this.txtCustomerName.Text + "')";
            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == true)
            {
                MessageBox.Show("新客户信息添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh DB
                DataBind("select [CustomerCode] as '客户代码', [CustomerName] as '客户名称' from [SprayLacquerManagement].[dbo].[Customer]");
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
            if (this.txtCustomerCode.Text.Length <= 0)
            {
                MessageBox.Show("请输入客户代码!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtCustomerCode.Focus();
                return;
            }

            string sql = "delete from [SprayLacquerManagement].[dbo].[Customer] where [CustomerCode]='" + txtCustomerCode.Text + "'";
            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == true)
            {
                MessageBox.Show("客户信息删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh DB
                DataBind("select [CustomerCode] as '客户代码', [CustomerName] as '客户名称' from [SprayLacquerManagement].[dbo].[Customer]");
                ClearText();
                return;
            }
            else
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            DataBind("select CustomerCode as '客户代码', CustomerName as '客户名称' from Customer");
        }

        private void dgUserInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = this.dgUserInfo.CurrentRow.Index;

            this.txtCustomerCode.Text = dgUserInfo.Rows[i].Cells[0].Value.ToString();
            this.txtCustomerName.Text = dgUserInfo.Rows[i].Cells[1].Value.ToString();
        }
    }
}
