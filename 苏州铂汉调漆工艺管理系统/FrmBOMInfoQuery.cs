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
    public partial class FrmBOMInfoQuery : Form
    {
        public FrmBOMInfoQuery()
        {
            InitializeComponent();
        }

        public void Query()
        {
            string sql = "SELECT [CustomerName] as '客户名称',[ProductName] as '品名/机种', [PartNumber] AS '主剂料号',[Supplier] as '厂商',[OilPlaintType] as '喷漆类型',[BOMInfo].[BOMID] FROM [SprayLacquerManagement].[dbo].[BOMInfo],(SELECT * FROM [SprayLacquerManagement].[dbo].[PartsInfo] WHERE [PartType] = 'MAIN') AS T Where 1=1 AND T.[BOMID] = [BOMInfo].[BOMID]";

            if (cmbCustomer.Text.Length > 0)
            {
                sql = sql + " and CustomerName like '%" + this.cmbCustomer.Text + "%' ";
            }
            if (this.txtPartNumber.Text.Length > 0)
            {
                sql = sql + " and ProductName like '%" + this.txtPartNumber.Text + "%'";
            }

            if (this.txtSupplier.Text.Length > 0)
            {
                sql = sql + " and Supplier like '%" + this.txtSupplier.Text + "%'";
            }

            sql += "ORDER BY '客户名称'";

            DataBind(sql);
        }

        public void FillCustomer(ref string sErrorMessage)
        {
            this.cmbCustomer.Items.Clear();
            string sql = "SELECT [CustomerName] FROM [SprayLacquerManagement].[dbo].[Customer]";
            System.Data.DataSet dsTemp = new DataSet();
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                this.cmbCustomer.Items.Add("");
                for (int i = 0; i < dsTemp.Tables[0].Rows.Count; i++)
                {
                    this.cmbCustomer.Items.Add(dsTemp.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        public void FillPaintType(ref string sErrorMessage)
        {
            this.cmbPaintType.Items.Clear();
            string sql = "SELECT [OilPaintType] FROM [SprayLacquerManagement].[dbo].[OilPaintTypes]";
            System.Data.DataSet dsTemp = new DataSet();
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                this.cmbPaintType.Items.Add("");
                for (int i = 0; i < dsTemp.Tables[0].Rows.Count; i++)
                {
                    this.cmbPaintType.Items.Add(dsTemp.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        public void DataBind(string sql)
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sErrorMessage = "";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                this.dgBOMinfo.DataSource = dsTemp.Tables[0].DefaultView;
                dgBOMinfo.Refresh();
            }
            else
            {
                dgBOMinfo.DataSource = null;
                dgBOMinfo.Refresh();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void FrmBOMInfoQuery_Load(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            FillPaintType(ref sErrorMessage);
            FillCustomer(ref sErrorMessage);
            Query();
        }

        private void dgBOMinfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = this.dgBOMinfo.CurrentRow.Index;

            FrmMain.BOMID = dgBOMinfo.Rows[i].Cells["BOMID"].Value.ToString();

            this.Close();
        }
    }
}
