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
    public partial class FrmOilPaint : Form
    {
        public FrmOilPaint()
        {
            InitializeComponent();
        }

        public void DataBind(string sql)
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sErrorMessage = "";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                this.dgPaintType.DataSource = dsTemp.Tables[0].DefaultView;
                dgPaintType.Refresh();
            }
            else
            {
                dgPaintType.DataSource = null;
                dgPaintType.Refresh();
            }
        }

        private void ClearText()
        {
            this.txtPaintType.Text = "";
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";

            if (this.txtPaintType.Text.Length <= 0)
            {
                MessageBox.Show("请输入喷漆类型!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "insert into [SprayLacquerManagement].[dbo].[OilPaintTypes]([OilPaintType]) values('" + this.txtPaintType.Text + "')";
            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == true)
            {
                MessageBox.Show("油漆类型添加成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh DB
                DataBind("select [OilPaintType] as '喷漆类型' from [SprayLacquerManagement].[dbo].[OilPaintTypes]");
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
            if (this.txtPaintType.Text.Length <= 0)
            {
                MessageBox.Show("请输入油漆类型!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaintType.Focus();
                return;
            }

            string sql = "delete from [SprayLacquerManagement].[dbo].[OilPaintTypes] where [OilPaintType]='" + this.txtPaintType.Text + "'";
            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == true)
            {
                MessageBox.Show("对应喷漆信息删除成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Refresh DB
                DataBind("select [OilPaintType] as '喷漆类型' from [SprayLacquerManagement].[dbo].[OilPaintTypes]");
                ClearText();
                return;
            }
            else
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FrmOilPaint_Load(object sender, EventArgs e)
        {
            DataBind("select [OilPaintType] as '喷漆类型' from [SprayLacquerManagement].[dbo].[OilPaintTypes]");
        }

        private void dgUserInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = this.dgPaintType.CurrentRow.Index;

            this.txtPaintType.Text = dgPaintType.Rows[i].Cells[0].Value.ToString();
        }
    }
}
