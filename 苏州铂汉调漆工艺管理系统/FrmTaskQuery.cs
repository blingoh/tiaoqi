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
    public partial class FrmTaskQuery : Form
    {

        public FrmTaskQuery()
        {
            InitializeComponent();
        }

        public void FillProductionLine(ref string sErrorMessage)
        {
            this.cmbProductionLine.Items.Clear();
            string sql = "SELECT * FROM [SprayLacquerManagement].[dbo].[ProductionLine]";
            System.Data.DataSet dsTemp = new DataSet();
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                this.cmbProductionLine.Items.Add("");
                for (int i = 0; i < dsTemp.Tables[0].Rows.Count; i++)
                {
                    this.cmbProductionLine.Items.Add(dsTemp.Tables[0].Rows[i][1].ToString());
                }
            }
        }

        public void FillOperator(ref string sErrorMessage)
        {
            this.cmbOperator.Items.Clear();
            string sql = "SELECT [UserID] FROM [SprayLacquerManagement].[dbo].[SecurityUser]";
            System.Data.DataSet dsTemp = new DataSet();
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                this.cmbOperator.Items.Add("");
                for (int i = 0; i < dsTemp.Tables[0].Rows.Count; i++)
                {
                    this.cmbOperator.Items.Add(dsTemp.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        private void AppendSQL(ref string sql,string sqlColumn)
        {
            sql = sql + sqlColumn;
            return;
        }

        private string GetBasicSQL()
        {
            string sql = "select ";
            
            if(cbLine.Checked==true )
            {
                AppendSQL(ref sql, "[LineName] AS '产线',");
            }

            if(cbShift.Checked==true)
            {
                AppendSQL(ref sql, "[ShiftName] as '班次',");
            }

            if(cbPartNumber.Checked==true)
            {
                AppendSQL(ref sql, "[ProductName] as '机种',");
            }

            if (cbSupplier.Checked == true)
            {
                AppendSQL(ref sql, "[Supplier] as '厂商',");
            }

            if (cbCustomer.Checked==true)
            {
                AppendSQL(ref sql, "[CustomerName] as '客户',");
            }

            if (cbMainVendor.Checked == true)
            {
                AppendSQL(ref sql, "[MainPartVendor] as '主剂厂商',");
            }

            if(actualPercent.Checked == true)
            {
                AppendSQL(ref sql, "cast([GuHuaRate] as varchar(6))+':'+cast([XiShiRate] as varchar(6)) as '实际比例(固：稀)',");
            }

            if (biaozhunPercent.Checked == true)
            {
                AppendSQL(ref sql, "cast([GuHuaRate] as varchar(6))+':'+cast(XiShiWeightSPECU as varchar(6))+'-'+CAST([XiShiWeightSPECL] as varchar(6)) as '标准比例(固：稀)',");
            }


            if (cbMainPartNumber.Checked == true)
            {
                AppendSQL(ref sql, "[MainPartNumber] as '主剂料号',");
            }

            if (cbMainPartLot.Checked == true)
            {
                AppendSQL(ref sql, "[MainLotNumber] as '主剂批号',");
            }

            if (cbMainPartWeight.Checked == true)
            {
                AppendSQL(ref sql, "[ActualMainPartWeight] as '主剂重量',");
            }

            if (cbMainHolderWeight.Checked==true)
            {
                AppendSQL(ref sql, "[MainHolderWeight] as '主剂容器重量',");
            }

            if (cbGuHuaVendor.Checked == true)
            {
                AppendSQL(ref sql, "[GuHuaPartVendor] as '固化剂厂商',");
            }

            if (cbGuHuaPartNumber.Checked == true)
            {
                AppendSQL(ref sql, "[GuHuaPartNumber] as '固化剂料号',");
            }

            if (cbGuHuaLot.Checked == true)
            {
                AppendSQL(ref sql, "[GuHuaLotNumber] as '固化剂批号',");
            }

            if (cbGuHuaWeight.Checked == true)
            {
                AppendSQL(ref sql, "[GuHuaActualWeight]/1000.0 as '固化剂重量',");
            }

            if (cbGuHuaHolderWeight.Checked == true)
            {
                AppendSQL(ref sql, "[GuHuaHolderWeight] as '固化剂容器重量',");
            }

            if (cbGuHuaActualRate.Checked == true)
            {
                AppendSQL(ref sql, "[GuHuaRate] as '固化剂实际比例',");
            }

            if (cbGuHuaDefinePercent.Checked == true)
            {
                AppendSQL(ref sql, "[GuHuaPercent] as '固化剂目标比例',");
            }

            if (cbXiShiVendor.Checked == true)
            {
                AppendSQL(ref sql, "[XiShiVendor] as '稀释剂厂商',");
            }
            
            if (cbXiShiPartNumber.Checked == true)
            {
                AppendSQL(ref sql, "[XiShiPartNumber] as '稀释剂料号',");
            }

            if (cbXiShiLot.Checked == true)
            {
                AppendSQL(ref sql, "[XiShiLotNumber] as '稀释剂批号',");
            }

            if (cbXiShiSPECU.Checked == true)
            {
                AppendSQL(ref sql, "[XiShiWeightSPECU] as '稀释剂下限',");
            }

            if (cbXiShiSPECL.Checked == true)
            {
                AppendSQL(ref sql, "[XiShiWeightSPECL] as '稀释剂上限',");
            }

            if (cbXiShiWeight.Checked == true)
            {
                AppendSQL(ref sql, "[XiShiActualWeight] as '稀释剂重量',");
            }
            
            if (cbXiShiHolderWeight.Checked == true)
            {
                AppendSQL(ref sql, "[XiShiHolderWeight] as '稀释剂容器重量',");
            }

            if (cbXiShiActualRate.Checked == true)
            {
                AppendSQL(ref sql, "[XiShiRate] as '稀释剂比例',");
            }

            if (cbDelayTime.Checked == true)
            { 
                AppendSQL(ref sql, "[ActualDelaySeconds] as '搅拌时间',");
            }

            if (cbSpeedResult.Checked == true)
            {
                AppendSQL(ref sql, "[ActualSpeed] as '流速',");
            }

            AppendSQL(ref sql, "[Operator] as '操作员',");
            AppendSQL(ref sql, "[SysDateTime] as '操作时间' ");
            sql = sql + " from   [SprayLacquerManagement].[dbo].[task], [SprayLacquerManagement].[dbo].[BOMINfo] where [SprayLacquerManagement].[dbo].[task].[BOMID]=[SprayLacquerManagement].[dbo].[BOMINFO].[BOMID] ";//status=7 ";
            return sql;
        }

        private string GenerateWhereStr()
        {
            string where = "";

            where = where + " and SysDateTime>='" + dtStart.Value.ToString("yyyy-MM-dd") + "'  and SysDateTime<='" + dtEnd.Value.ToString("yyyy-MM-dd") + "' ";

            if (cmbShift.Text.Length > 0)
            {
                where = where + " and ShiftName like '%" + cmbShift.Text + "%' ";
            }

            if (cmbProductionLine.Text.Length > 0)
            {
                where = where + " and LineName='" + this.cmbProductionLine.Text + "' ";
            }

            if (txtPartNumber.Text.Length > 0)
            {
                where = where + " and ProductName like '%" + this.txtPartNumber.Text + "%' ";
            }

            if (txtSupplier.Text.Length > 0)
            {
                where = where + " and Supplier like '%" + this.txtSupplier.Text + "%' ";
            }

            if (txtMainPartNumber.Text.Length > 0)
            {
                where = where + " and MainPartNumber like '%" + this.txtMainPartNumber.Text + "%' ";
            }

            if (this.cmbStatus.Text == "完成")
            {
                where = where + " and Status =7 ";
            }
            else if (this.cmbStatus.Text == "未完成")
            {
                where = where + " and Status <>7 ";
            }
            else
            {

            }
            return where;
        }

        private string GenerateSumWhereStr()
        {
            string where = "";

            where = where + " and SysDateTime>='" + dtStart.Value.ToString("yyyy-MM-dd") + "'  and SysDateTime<='" + dtEnd.Value.ToString("yyyy-MM-dd") + "' ";

            if (cmbShift.Text.Length > 0)
            {
                where = where + " and ShiftName like '%" + cmbShift.Text + "%' ";
            }

            if (cmbProductionLine.Text.Length > 0)
            {
                where = where + " and LineName='" + this.cmbProductionLine.Text + "' ";
            }

            if (txtPartNumber.Text.Length > 0)
            {
                where = where + " and ProductName like '%" + this.txtPartNumber.Text + "%' ";
            }

            if (txtSupplier.Text.Length > 0)
            {
                where = where + " and Supplier like '%" + this.txtSupplier.Text + "%' ";
            }

            if (txtMainPartNumber.Text.Length > 0)
            {
                where = where + " and MainPartNumber like '%" + this.txtMainPartNumber.Text + "%' ";
            }

            if (this.cmbStatus.Text == "完成")
            {
                where = where + " and Status =7 ";
            }
            else if (this.cmbStatus.Text == "未完成")
            {
                where = where + " and Status <>7 ";
            }
            else
            {

            }
            return where;
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            string sql = GetBasicSQL();
            sql = sql + GenerateWhereStr() + " order by [sysdatetime] desc";
            DataBind(sql,ref sErrorMessage);
        }

        public void DataBind(string sql,ref string sErrorMessage)
        {
            System.Data.DataSet dsTemp = new DataSet();

            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                this.dgTaskRecord.DataSource = dsTemp.Tables[0].DefaultView;
                dgTaskRecord.Refresh();
            }
            else
            {
                dgTaskRecord.DataSource = null;
                dgTaskRecord.Refresh();
            }
        }

        private void SelectAllCheckBox()
        {
            foreach (Control ctemp in plCheckBox.Controls)
            {
                if (ctemp is CheckBox)
                {
                    ((CheckBox)ctemp).Checked = true;
                }
            }
        }

        private void SelectAllCheckBoxNo()
        {
            foreach (Control ctemp in plCheckBox.Controls)
            {
                if (ctemp is CheckBox)
                {
                    ((CheckBox)ctemp).Checked = false;
                }
            }
        }

        private void FrmTaskQuery_Load(object sender, EventArgs e)
        {
            string sErrorMessage="";
            FillProductionLine(ref sErrorMessage);
            FillOperator(ref sErrorMessage);
            SelectAllCheckBox();
        }
        
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            SelectAllCheckBox();
        }

        private void btnNoSelectAll_Click(object sender, EventArgs e)
        {
            SelectAllCheckBoxNo();
        }
        
        private void btnExport_Click(object sender, EventArgs e)
        {
            clsApp.DataGridviewShowToExcel(this.dgTaskRecord,true);
        }

        private void btnExportSumary_Click(object sender, EventArgs e)
        {
            string sErrorMessage="";
            string where = GenerateSumWhereStr();

            clsApp.GenerateSummaryReport(where,true,dtStart.Value.ToString("yyyy-MM-dd"),dtEnd.Value.ToString("yyyy-MM-dd"),ref sErrorMessage);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
