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
    public partial class FrmProductionLine : Form
    {
        #region

        #endregion

        public FrmProductionLine()
        {
            InitializeComponent();
        }

        public void DataBind(string sql)
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sErrorMessage = "";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                this.dgLineInfo.DataSource = dsTemp.Tables[0].DefaultView;
                dgLineInfo.Refresh();
            }
            else
            {
                dgLineInfo.DataSource = null;
                dgLineInfo.Refresh();
            }
        }

        private void ClearText()
        {
            txtLineCode.Text = "";
            txtLineName.Text = "";
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            if(this.txtLineCode.Text.Length<=0)
            {
                MessageBox.Show("请输入产线编码!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLineCode.Focus();
                return;
            }

            if (this.txtLineName.Text.Length <= 0)
            {
                MessageBox.Show("请输入产线名称!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtLineName.Focus();
                return;
            }

            string sErrorMessage = "";
            string sql = "insert into [SprayLacquerManagement].[dbo].[ProductionLine]([LineCode],[LineName]) values('" + this.txtLineCode.Text + "','" + this.txtLineName.Text + "')";
            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == true)
            {
                MessageBox.Show("新产线添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBind("select [LineCode] as '产线编号', [LineName] as '产线名称'  from [SprayLacquerManagement].[dbo].[ProductionLine]");
                ClearText();
                return;
            }
            else
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FrmProductionLine_Load(object sender, EventArgs e)
        {
            DataBind("select LineCode as '产线编号', LineName as '产线名称'  from ProductionLine");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            if (this.txtLineCode.Text.Length <= 0)
            {
                MessageBox.Show("请输入产线代码!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLineCode.Focus();
                return;
            }

            string sql = "delete from [SprayLacquerManagement].[dbo].[ProductionLine] where [LineCode]='" + txtLineCode.Text + "'";
            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == true)
            {
                MessageBox.Show("产线信息删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh DB
                DataBind("select [LineCode] as '产线编号', [LineName] as '产线名称'  from [SprayLacquerManagement].[dbo].[ProductionLine]");
                ClearText();
                return;
            }
            else
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtLineCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                this.txtLineName.SelectAll();
                this.txtLineName.SelectionLength = this.txtLineName.Text.Length;
                this.txtLineName.Focus();
            }
        }
    }
}
