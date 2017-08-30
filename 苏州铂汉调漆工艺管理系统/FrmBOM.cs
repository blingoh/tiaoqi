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
    public partial class FrmBOM : Form
    {
        public int nOperationStatus; //1-Append 2-Edit 3-Delete  0-Default

        public FrmBOM()
        {
            InitializeComponent();
        }

        #region Function
        private bool CheckListInfoExsist(ListBox lbtemp,string siteminfo)
        {
            if(lbtemp.Items.Count <=0)
            {
                return false;
            }
            else
            {
                for(int i=0;i<lbtemp.Items.Count;i++)
                {
                    if(lbtemp.Items[i].ToString()==siteminfo)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void InitButtion()
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            btnAppend.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            nOperationStatus = 0;

            txtPaintSpeedL.Enabled = false;
            txtWangBuMuShu.Enabled = false;
            this.txtValidHours.Enabled = false;
            this.txtGuHuaPart.Enabled = false;
            this.txtMainPart.Enabled = false;
            this.txtPaintSpeedU.Enabled = false;
            this.txtPartNumber.Enabled = false;
            this.txtSupplier.Enabled = false;
            this.txtXiShiLowPercent.Enabled = false;
            this.txtXiShiLowPercent.Enabled = false;
            this.txtXiShiPart.Enabled = false;
            this.txtXiShiUpPercent.Enabled = false;
            this.cmbCustomer.Enabled = false;
            this.cmbPaintType.Enabled = false;
            txtGuHuaPercent.Enabled = false;
            txtOilName.Enabled = false;

            lbMain.Enabled = false;
            lbGuHua.Enabled = false;
            lbXiShi.Enabled = false;
        }

        public void Operation()
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAppend.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtPaintSpeedL.Enabled = true;
            txtWangBuMuShu.Enabled = true;
            this.txtValidHours.Enabled = true;
            this.txtGuHuaPart.Enabled = true;
            this.txtMainPart.Enabled = true;
            this.txtPaintSpeedU.Enabled = true;
            this.txtPartNumber.Enabled = true;
            this.txtSupplier.Enabled = true;
            this.txtXiShiLowPercent.Enabled = true;
            this.txtXiShiLowPercent.Enabled = true;
            this.txtXiShiPart.Enabled = true;
            this.txtXiShiUpPercent.Enabled = true;
            this.cmbCustomer.Enabled = true;
            this.cmbPaintType.Enabled = true;
            this.txtOilName.Enabled = true;
            txtGuHuaPercent.Enabled = true;

            lbMain.Enabled = true;
            lbGuHua.Enabled = true;
            lbXiShi.Enabled = true;
        }

        public void FillCustomer(ref string sErrorMessage)
        {
            cmbCustomer.Items.Clear();
            string sql = "SELECT [CustomerName] FROM [SprayLacquerManagement].[dbo].[Customer]";
            System.Data.DataSet dsTemp = new DataSet();
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                for(int i=0;i<dsTemp.Tables[0].Rows.Count;i++)
                {
                    cmbCustomer.Items.Add(dsTemp.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        public void FillPaintType(ref string sErrorMessage)
        {
            cmbPaintType.Items.Clear();
            string sql = "SELECT [OilPaintType] FROM [SprayLacquerManagement].[dbo].[OilPaintTypes]";
            System.Data.DataSet dsTemp = new DataSet();
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
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

        public bool CheckProductName(string sProductName,ref bool bExsist,ref string sErrorMessage)
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sql = "select * from [SprayLacquerManagement].[dbo].[BOMInfo] where [productname]='" + sProductName + "' ";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                if(dsTemp.Tables[0].Rows.Count>0)
                {
                    bExsist = true;
                    return true;
                }
                else
                {
                    bExsist = false;
                    return true;
                }
            }
            else
            {
                bExsist = true;
                return false;
            }
        }

        public bool GetRowID(string sProductName,ref string sRowID,ref string sErrorMessage)
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sql = "select * from [SprayLacquerManagement].[dbo].[BOMInfo] where [productname]='" + sProductName + "' ";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                if (dsTemp.Tables[0].Rows.Count > 0)
                {
                    sRowID =dsTemp.Tables[0].Rows[0]["BOMID"].ToString();
                    return true;
                }
                else
                {
                    sRowID = "";
                    sErrorMessage = "没有发现对应的产品的BOM配置信息!";
                    return false;
                }
            }
            else
            {
                sRowID = "";
                return false;
            }
        }

        private void ClearText()
        {
            this.txtGuHuaPart.Text = "";
            this.txtMainPart.Text = "";
            this.txtPaintSpeedU.Text = "";
            this.txtPaintSpeedL.Text = "";
            this.txtPartNumber.Text = "";
            this.txtSupplier.Text = "";
            this.txtXiShiLowPercent.Text = "";
            this.txtXiShiLowPercent.Text = "";
            this.txtXiShiPart.Text = "";
            this.txtXiShiUpPercent.Text = "";
            this.txtWangBuMuShu.Text = "";
            this.txtValidHours.Text = "";
            this.txtOilName.Text = "";

            txtGuHuaPercent.Text = "";

            lbMain.Items.Clear();
            lbGuHua.Items.Clear();
            lbXiShi.Items.Clear();


        }

        public bool DataVerify(ref string sErrorMessage)
        {
            if(cmbCustomer.Text.Length<=0)
            {
                MessageBox.Show("请选择输入客户名称!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                cmbCustomer.Focus();
                return false;
            }

            if (txtPartNumber.Text.Length<=0)
            {
                MessageBox.Show("请输入机种、品名!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                txtPartNumber.Focus();
                return false;
            }

            //txtSupplier
            if (txtSupplier.Text.Length <= 0)
            {
                MessageBox.Show("请输入厂商名称!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                txtSupplier.Focus();
                return false;
            }

            //cmbPaintType
            if (cmbPaintType.Text.Length <= 0)
            {
                MessageBox.Show("请选择输入喷漆类型!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                this.cmbPaintType.Focus();
                return false;
            }

            //txtPaintSpeed
            if (txtPaintSpeedU.Text.Length <= 0)
            {
                MessageBox.Show("请输入流速上限数据!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                txtPaintSpeedU.Focus();
                return false;
            }

            if (txtPaintSpeedL.Text.Length <= 0)
            {
                MessageBox.Show("请输入流速下限数据!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                txtPaintSpeedL.Focus();
                return false;
            }

            if (this.txtWangBuMuShu.Text.Length <= 0)
            {
                MessageBox.Show("请输入网布目数数据!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                txtWangBuMuShu.Focus();
                return false;
            }

            if (clsApp.IsDouble(this.txtPaintSpeedU.Text, ref sErrorMessage) == false)
            {
                MessageBox.Show("油漆的流速数据格式不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPaintSpeedU.SelectAll();
                this.txtPaintSpeedU.SelectionLength = this.txtPaintSpeedU.Text.Length;
                this.txtPaintSpeedU.Focus();
                return false;
            }

            //txtGuHuaPercent
            if (txtGuHuaPercent.Text.Length <= 0)
            {
                MessageBox.Show("请输入固化剂配置比例!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                txtGuHuaPercent.Focus();
                return false;
            }
            if (clsApp.IsInt(this.txtGuHuaPercent.Text,ref sErrorMessage) == false)
            {
                MessageBox.Show("固化剂配比数据格式不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtGuHuaPercent.SelectAll();
                this.txtGuHuaPercent.SelectionLength = this.txtGuHuaPercent.Text.Length;
                this.txtGuHuaPercent.Focus();
                return false;
            }

            //txtXiShiUpPercent
            if (txtXiShiUpPercent.Text.Length <= 0)
            {
                MessageBox.Show("请输入稀释剂上限!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                txtXiShiUpPercent.Focus();
                return false;
            }
            if (clsApp.IsInt(this.txtXiShiUpPercent.Text,ref sErrorMessage) == false)
            {
                MessageBox.Show("稀释剂上限配比数据格式不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtXiShiUpPercent.SelectAll();
                this.txtXiShiUpPercent.SelectionLength = this.txtXiShiUpPercent.Text.Length;
                this.txtXiShiUpPercent.Focus();
                return false;
            }

            if (this.Text.Length <= 0)
            {
                MessageBox.Show("请输入稀释剂下限!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                txtXiShiLowPercent.Focus();
                return false;
            }

            if (txtXiShiLowPercent.Text.Length <= 0)
            {
                MessageBox.Show("请输入稀释剂下限!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                txtXiShiLowPercent.Focus();
                return false;
            }
            if (clsApp.IsInt(this.txtXiShiLowPercent.Text,ref sErrorMessage) == false)
            {
                MessageBox.Show("稀释剂下限配比数据格式不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtXiShiLowPercent.SelectAll();
                this.txtXiShiLowPercent.SelectionLength = this.txtXiShiLowPercent.Text.Length;
                this.txtXiShiLowPercent.Focus();
                return false;
            }

            if (this.txtValidHours.Text.Length <= 0)
            {
                MessageBox.Show("请输入油漆有效时间!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 0;
                this.txtValidHours.Focus();
                return false;
            }

            if (clsApp.IsInt(this.txtValidHours.Text, ref sErrorMessage) == false)
            {
                MessageBox.Show("油漆有效时间数据格式不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtXiShiLowPercent.SelectAll();
                this.txtXiShiLowPercent.SelectionLength = this.txtXiShiLowPercent.Text.Length;
                this.txtXiShiLowPercent.Focus();
                return false;
            }
            
            if (lbMain.Items.Count<=0)
            {
                MessageBox.Show("请输入主剂料号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 1;
                txtMainPart.Text = "";
                txtMainPart.Focus();
                return false;
            }

            if (int.Parse(txtGuHuaPercent.Text)!=0)
            {
                if (lbGuHua.Items.Count <= 0)
                {
                    MessageBox.Show("请输入固化剂料号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbMain.SelectedIndex = 1;
                    this.txtGuHuaPart.Text = "";
                    txtGuHuaPart.Focus();
                    return false;
                }
            }
            else
            {
                lbGuHua.Items.Clear();
                lbGuHua.Items.Add("NA");
            }

            if (lbXiShi.Items.Count <= 0)
            {
                MessageBox.Show("请输入稀释剂料号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMain.SelectedIndex = 1;
                this.txtXiShiPart.Text = "";
                txtXiShiPart.Focus();
                return false;
            }
            
            if(int.Parse(this.txtXiShiUpPercent.Text)<=int.Parse(this.txtXiShiLowPercent.Text))
            {
                MessageBox.Show("稀释剂配比数据 上限必须大于下限!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;    
        }

        public bool AppendData(ref string sErrorMessage)
        {
            return true;
        }

        public bool RefreshandShowMainData()
        {
            string sErrorMessage = "";
            System.Data.DataSet dsTemp = new DataSet();
            string sql = "SELECT [CustomerName] as '客户名称',[ProductName] as '品名/机种',T.PartNumber as '主剂料号',[Supplier] as '厂商',[OilPlaintType] as '喷漆类型',[OilSpeedU] as '流速上限',[OilSpeedL] as '流速下限',[WBMS] as '网布目数',[GuHuaPercent] as '固化剂比例',[XiShiUpPercent] as '稀释剂比例(上限)',[XiShiLowPercent] as '稀释剂比例(下限)',ValidHours as '油漆有效时间' FROM [SprayLacquerManagement].[dbo].[BOMInfo],(SELECT * FROM [SprayLacquerManagement].[dbo].[PartsInfo] WHERE [PartType] = 'MAIN' AND [BOMID] = '" + FrmMain.BOMID + "') AS T where [BOMInfo].[BOMID] = '" + FrmMain.BOMID + "'  ORDER BY '客户名称'";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                if (dsTemp.Tables[0].Rows.Count > 0)
                {

                    string clientName = dsTemp.Tables[0].Rows[0]["客户名称"].ToString();

                    cmbCustomer.Text = clientName;
                    this.txtPartNumber.Text = dsTemp.Tables[0].Rows[0]["品名/机种"].ToString();
                    this.txtSupplier.Text = dsTemp.Tables[0].Rows[0]["厂商"].ToString();

                    this.cmbPaintType.Text = dsTemp.Tables[0].Rows[0]["喷漆类型"].ToString();

                    this.txtPaintSpeedU.Text = dsTemp.Tables[0].Rows[0]["流速上限"].ToString();
                    this.txtPaintSpeedL.Text = dsTemp.Tables[0].Rows[0]["流速下限"].ToString();
                    this.txtWangBuMuShu.Text = dsTemp.Tables[0].Rows[0]["网布目数"].ToString();
                    this.txtGuHuaPercent.Text = dsTemp.Tables[0].Rows[0]["固化剂比例"].ToString();
                    this.txtValidHours.Text = dsTemp.Tables[0].Rows[0]["油漆有效时间"].ToString();
                    this.txtXiShiUpPercent.Text = dsTemp.Tables[0].Rows[0]["稀释剂比例(上限)"].ToString();
                    this.txtXiShiLowPercent.Text = dsTemp.Tables[0].Rows[0]["稀释剂比例(下限)"].ToString();
                    //this.txtOilName.Text = dsTemp.Tables[0].Rows[0]["油漆名"].ToString();
                    return true;
                }
                else
                {
                    sErrorMessage = "没有发现对应的产品的BOM配置信息!";
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool RefreshandShowDetailData()
        {
            string sErrorMessage = "";
            lbMain.Items.Clear();
            lbGuHua.Items.Clear();
            lbXiShi.Items.Clear();

            System.Data.DataSet dsTemp = new DataSet();
            string sql = "SELECT [PartType],[PartNumber] FROM [SprayLacquerManagement].[dbo].[PartsInfo] where [BOMID]='" + FrmMain.BOMID + "'";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                if (dsTemp.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsTemp.Tables[0].Rows.Count;i++ )
                    {
                        if(dsTemp.Tables[0].Rows[i]["PartType"].ToString().ToUpper()=="MAIN")
                        {
                            lbMain.Items.Add(dsTemp.Tables[0].Rows[i]["PartNumber"].ToString());
                        }
                        else if(dsTemp.Tables[0].Rows[i]["PartType"].ToString().ToUpper()=="GUHUA")
                        {
                            lbGuHua.Items.Add(dsTemp.Tables[0].Rows[i]["PartNumber"].ToString());
                        }
                        else if(dsTemp.Tables[0].Rows[i]["PartType"].ToString().ToUpper()=="XISHI")
                        {
                            lbXiShi.Items.Add(dsTemp.Tables[0].Rows[i]["PartNumber"].ToString());
                        }
                        else
                        {
                            //Nothing
                        }
                    }
                    
                    return true;
                }
                else
                {
                    sErrorMessage = "没有发现对应的产品的BOM配置信息!";
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
        // 页面加载方法，用于页面初始载入进行数据加载
        // 默认以客户进行排序
        private void FrmBOM_Load(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            //Refresh Data
            string sql = "SELECT [CustomerName] as '客户名称',[ProductName] as '品名/机种',T.PartNumber as '主剂料号',[Supplier] as '厂商',[OilPlaintType] as '喷漆类型',[OilSpeedU] as '流速上限',[OilSpeedL] as '流速下限',[WBMS] as '网布目数',[GuHuaPercent] as '固化剂比例',[XiShiUpPercent] as '稀释剂比例(上限)',[XiShiLowPercent] as '稀释剂比例(下限)',ValidHours as '油漆有效时间',[BOMInfo].[BOMID] FROM [SprayLacquerManagement].[dbo].[BOMInfo],(SELECT * FROM [SprayLacquerManagement].[dbo].[PartsInfo] WHERE [PartType] = 'MAIN') AS T where [BOMInfo].[BOMID] = T.[BOMID]  ORDER BY '客户名称'";
            FrmMain.BOMID = "";
            DataBind(sql);
            ClearText();
            FillCustomer(ref sErrorMessage);
            FillPaintType(ref sErrorMessage);
            InitButtion();
        }
        
        private void btnAppendMainPart_Click(object sender, EventArgs e)
        {
            if(txtMainPart.Text.Length<=0)
            {
                MessageBox.Show("请输入主剂料号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if(CheckListInfoExsist(this.lbGuHua,this.txtMainPart.Text)==true)
            {
                MessageBox.Show("输入的主剂料号和固化剂料号不能一样!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMainPart.SelectAll();
                txtMainPart.SelectionLength = this.txtMainPart.Text.Length;
                txtMainPart.Focus();
                return;
            }

            if (CheckListInfoExsist(this.lbXiShi, this.txtMainPart.Text) == true)
            {
                MessageBox.Show("输入的主剂料号和稀释剂料号不能一样!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMainPart.SelectAll();
                txtMainPart.SelectionLength = this.txtMainPart.Text.Length;
                txtMainPart.Focus();
                return;
            }

            if(CheckListInfoExsist(this.lbMain,this.txtMainPart.Text)==true)
            {
                MessageBox.Show("输入的主剂料号已经存在!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMainPart.SelectAll();
                txtMainPart.SelectionLength = this.txtMainPart.Text.Length;
                txtMainPart.Focus();
                return;
            }
            else
            {
                lbMain.Items.Add(this.txtMainPart.Text);
                this.txtMainPart.Text = "";
                txtMainPart.SelectAll();
                txtMainPart.SelectionLength = this.txtMainPart.Text.Length;
                txtMainPart.Focus();
                return;
            }
        }

        private void btnRemoveMainPart_Click(object sender, EventArgs e)
        {
            lbMain.Items.Remove(this.txtMainPart.Text);
            this.txtMainPart.Text = "";
        }

        private void lbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtMainPart.Text = lbMain.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void txtMainPart_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                btnAppendMainPart.Focus();
            }
        }

        private void lbGuHua_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtGuHuaPart.Text = this.lbGuHua.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void txtGuHuaPart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnAppendGuHuaPart.Focus();
            }
        }

        private void btnAppendGuHuaPart_Click(object sender, EventArgs e)
        {
            if (this.txtGuHuaPart.Text.Length <= 0)
            {
                MessageBox.Show("请输入固化剂料号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckListInfoExsist(this.lbMain, this.txtGuHuaPart.Text) == true)
            {
                MessageBox.Show("输入的固化剂料号不能和主剂料号一样!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuHuaPart.SelectAll();
                txtGuHuaPart.SelectionLength = this.txtGuHuaPart.Text.Length;
                txtGuHuaPart.Focus();
                return;
            }

            if (CheckListInfoExsist(this.lbXiShi, this.txtGuHuaPart.Text) == true)
            {
                MessageBox.Show("输入的固化剂料号不能和稀释剂料号一样!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuHuaPart.SelectAll();
                txtGuHuaPart.SelectionLength = this.txtGuHuaPart.Text.Length;
                txtGuHuaPart.Focus();
                return;
            }

            if (CheckListInfoExsist(this.lbGuHua, this.txtGuHuaPart.Text) == true)
            {
                MessageBox.Show("输入的固化剂料号已经存在!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuHuaPart.SelectAll();
                txtGuHuaPart.SelectionLength = this.txtGuHuaPart.Text.Length;
                txtGuHuaPart.Focus();
                return;
            }
            else
            {
                lbGuHua.Items.Add(this.txtGuHuaPart.Text);
                this.txtGuHuaPart.Text = "";
                txtGuHuaPart.SelectAll();
                txtGuHuaPart.SelectionLength = this.txtGuHuaPart.Text.Length;
                txtGuHuaPart.Focus();
                return;
            }
        }

        private void btnRemoveGuHuaPart_Click(object sender, EventArgs e)
        {
            lbGuHua.Items.Remove(this.txtGuHuaPart.Text);
            this.txtGuHuaPart.Text = "";
        }

        private void txtXiShiPart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnAppendXiShiPart.Focus();
            }
        }

        private void btnAppendXiShiPart_Click(object sender, EventArgs e)
        {
            if (this.txtXiShiPart.Text.Length <= 0)
            {
                MessageBox.Show("请输入稀释剂料号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckListInfoExsist(this.lbMain, this.txtXiShiPart.Text) == true)
            {
                MessageBox.Show("输入的稀释剂料号不能和主剂料号一样!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXiShiPart.SelectAll();
                txtXiShiPart.SelectionLength = this.txtXiShiPart.Text.Length;
                txtXiShiPart.Focus();
                return;
            }

            if (CheckListInfoExsist(this.lbGuHua, this.txtXiShiPart.Text) == true)
            {
                MessageBox.Show("输入的稀释剂料号不能和固化剂料号一样!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXiShiPart.SelectAll();
                txtXiShiPart.SelectionLength = this.txtXiShiPart.Text.Length;
                txtXiShiPart.Focus();
                return;
            }

            if (CheckListInfoExsist(this.lbXiShi, this.txtXiShiPart.Text) == true)
            {
                MessageBox.Show("输入的稀释剂料号已经存在!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXiShiPart.SelectAll();
                txtXiShiPart.SelectionLength = this.txtXiShiPart.Text.Length;
                txtXiShiPart.Focus();
                return;
            }
            else
            {
                lbXiShi.Items.Add(this.txtXiShiPart.Text);
                this.txtXiShiPart.Text = "";
                txtXiShiPart.SelectAll();
                txtXiShiPart.SelectionLength = this.txtXiShiPart.Text.Length;
                txtXiShiPart.Focus();
                return;
            }
        }

        private void btnRemoveXiShiPart_Click(object sender, EventArgs e)
        {
            lbXiShi.Items.Remove(this.txtXiShiPart.Text);
            this.txtXiShiPart.Text = "";
        }

        private void lbXiShi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtXiShiPart.Text = lbXiShi.SelectedItem.ToString();
            }
            catch
            {

            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            Operation();
            ClearText();
            nOperationStatus = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (FrmMain.BOMID.Length <= 0)
            {
                MessageBox.Show("请选择需要修改的记录!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nOperationStatus = 2;
            Operation();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (FrmMain.BOMID.Length <= 0)
            {
                MessageBox.Show("请选择需要删除的记录!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 删除已选项
            int delIndex = dgBOMinfo.CurrentRow.Index;
            var delObj = dgBOMinfo.DataSource as DataView;
            var row = delObj[delIndex];
            var clientName = row.Row[0];
            var kind = row.Row[1];
            var brand = row.Row[2];
            var type = row.Row[3];
            if (MessageBox.Show(@"你确认要删除：“" + clientName + "-" + kind + "-" + brand + "-" + type + "”的产品吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                (dgBOMinfo.DataSource as DataView).Delete(delIndex);

                nOperationStatus = 3;
                Operation();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            string sql = "";
            bool bRes=false;
            string sRowID="";

            //Save
            switch (nOperationStatus)
            {
                case 1:
                    //Data Verification
                    if (DataVerify(ref sErrorMessage)==false)
                    {
                        //MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //check Prodcut name exsist
                    if (CheckProductName(this.txtPartNumber.Text,ref bRes,ref sErrorMessage)==true)
                    {
                        if(bRes==true)
                        {
                            MessageBox.Show("机种、品名已经存在!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtPartNumber.SelectAll();
                            txtPartNumber.SelectionLength = this.txtPartNumber.Text.Length;
                            txtPartNumber.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    //Append Data
                    sql = "Insert into [SprayLacquerManagement].[dbo].[BOMInfo]([BOMID],[CustomerName],[ProductName],[Supplier],[OilPlaintType],[OilSpeedU],[GuHuaPercent],[XiShiUpPercent],[XiShiLowPercent],[OilSpeedL],[WBMS],[validhours],[OilName]) ";
                    sql = sql + " Values(NEWID(),'" + cmbCustomer.Text + "','" + txtPartNumber.Text + "','" + txtSupplier.Text + "','" + cmbPaintType.Text + "'," + txtPaintSpeedU.Text + "," + txtGuHuaPercent.Text + "," + txtXiShiUpPercent.Text + "," + txtXiShiLowPercent.Text + ","+this.txtPaintSpeedL.Text+","+this.txtWangBuMuShu.Text+","+this.txtValidHours.Text+ ",'" + txtOilName.Text + "')";
                    if(clsApp.ExecuteSQL(sql,clsApp.ConnectString,ref sErrorMessage)==true)
                    {
                        //Get Row ID
                        if(GetRowID(this.txtPartNumber.Text,ref sRowID,ref sErrorMessage)==false)
                        {
                            MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        //Append Main Part Number Info
                        for(int i=0;i<lbMain.Items.Count;i++)
                        {
                            sql = "Insert into [SprayLacquerManagement].[dbo].[PartsInfo]([BOMID],[PartType],[PartNumber]) values('" + sRowID + "','MAIN','" + lbMain.Items[i].ToString() + "' )";
                            clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                        }

                        //Append GuHua Part Number Info
                        for (int i = 0; i < lbGuHua.Items.Count; i++)
                        {
                            sql = "Insert into [SprayLacquerManagement].[dbo].[PartsInfo]([BOMID],[PartType],[PartNumber]) values('" + sRowID + "','GUHUA','" + lbGuHua.Items[i].ToString() + "' )";
                            clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                        }

                        //Append XiShi Part Number Info
                        for (int i = 0; i < lbXiShi.Items.Count; i++)
                        {
                            sql = "Insert into [SprayLacquerManagement].[dbo].[PartsInfo]([BOMID],[PartType],[PartNumber]) values('" + sRowID + "','XISHI','" + lbXiShi.Items[i].ToString() + "' )";
                            clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                        }

                        //Refresh Data
                        sql = "SELECT [CustomerName] as '客户名称',[ProductName] as '品名/机种',T.PartNumber as '主剂料号',[Supplier] as '厂商',[OilName] as '油漆名',[OilPlaintType] as '喷漆类型',[OilSpeedU] as '流速上限',[OilSpeedL] as '流速下限',[WBMS] as '网布目数',[GuHuaPercent] as '固化剂比例',[XiShiUpPercent] as '稀释剂比例(上限)',[XiShiLowPercent] as '稀释剂比例(下限)',ValidHours as '油漆有效时间',[BOMInfo].[BOMID] FROM [SprayLacquerManagement].[dbo].[BOMInfo],(SELECT * FROM [SprayLacquerManagement].[dbo].[PartsInfo] WHERE [PartType] = 'MAIN') AS T where [BOMInfo].[BOMID] = T.[BOMID]  ORDER BY '客户名称'";

                        // DataBind(sql);
                        // 避免刷新
                        var dtview = dgBOMinfo.DataSource as DataView;
                        var row = dtview.AddNew();
                        row[0] = cmbCustomer.Text;
                        row[1] = txtPartNumber.Text;
                        row[2] = txtSupplier.Text;
                        row[3] = txtOilName.Text;
                        row[4] = cmbPaintType.Text;
                        row[5] = txtPaintSpeedU.Text;
                        row[6] = txtGuHuaPercent.Text;
                        row[7] = txtXiShiUpPercent.Text;
                        row[8] = txtXiShiLowPercent.Text;
                        row[9] = this.txtPaintSpeedL.Text;
                        row[10] = this.txtWangBuMuShu.Text;
                        row[11] = this.txtValidHours.Text;
                        
                        InitButtion();
                        nOperationStatus = 0;
                    }
                    else
                    {
                        MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;
                case 2:
                    if (MessageBox.Show("确定要修改对应BOM信息吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    {
                        //Cancel
                        RefreshandShowMainData();
                        RefreshandShowDetailData();

                        InitButtion();
                        nOperationStatus = 0;
                        return;
                    }

                    if (DataVerify(ref sErrorMessage) == false)
                    {
                        //MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //Edit Main Data
                    sql = "update [SprayLacquerManagement].[dbo].[BOMInfo] set [CustomerName]='" + cmbCustomer.Text + "',[Supplier]='" + txtSupplier.Text + "',[OilPlaintType]='" + cmbPaintType.Text + "',[OilSpeedU]=" + txtPaintSpeedU.Text + ",[OilSpeedL]=" + txtPaintSpeedL.Text + ",[WBMS]=" + this.txtWangBuMuShu.Text + ", ";
                    sql = sql + " [GuHuaPercent]=" + txtGuHuaPercent.Text + ",[XiShiUpPercent]=" + txtXiShiUpPercent.Text + ",[XiShiLowPercent]=" + txtXiShiLowPercent.Text + ",[ValidHours]="+this.txtValidHours.Text+ ", [OilName]='" + txtOilName.Text + "'" + " where [BOMID]='" + FrmMain.BOMID + "' and [ProductName]='" + txtPartNumber.Text + "'";
                     
                    if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == true)
                    {
                        //Edit Detail Data
                        sql = "delete from [SprayLacquerManagement].[dbo].[PartsInfo] where [BOMID]='" + FrmMain.BOMID + "' ";
                        clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                        //Append Main Part Number Info
                        for (int i = 0; i < lbMain.Items.Count; i++)
                        {
                            sql = "Insert into [SprayLacquerManagement].[dbo].[PartsInfo]([BOMID],[PartType],[PartNumber]) values('" + FrmMain.BOMID + "','MAIN','" + lbMain.Items[i].ToString() + "' )";
                            clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                        }

                        //Append GuHua Part Number Info
                        for (int i = 0; i < lbGuHua.Items.Count; i++)
                        {
                            sql = "Insert into [SprayLacquerManagement].[dbo].[PartsInfo]([BOMID],[PartType],[PartNumber]) values('" + FrmMain.BOMID + "','GUHUA','" + lbGuHua.Items[i].ToString() + "' )";
                            clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                        }

                        //Append XiShi Part Number Info
                        for (int i = 0; i < lbXiShi.Items.Count; i++)
                        {
                            sql = "Insert into [SprayLacquerManagement].[dbo].[PartsInfo]([BOMID],[PartType],[PartNumber]) values('" + FrmMain.BOMID + "','XISHI','" + lbXiShi.Items[i].ToString() + "' )";
                            clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                        }

                        //Refresh Data
                        sql = "SELECT [CustomerName] as '客户名称',[ProductName] as '品名/机种',[Supplier] as '厂商',[OilName] as '油漆名',[OilPlaintType] as '喷漆类型',[OilSpeedU] as '流速上限',[OilSpeedL] as '流速下限',[WBMS] as '网布目数',[GuHuaPercent] as '固化剂比例',[XiShiUpPercent] as '稀释剂比例(上限)',[XiShiLowPercent] as '稀释剂比例(下限)',ValidHours as '油漆有效时间',[BOMID]  FROM [SprayLacquerManagement].[dbo].[BOMInfo] ORDER BY '客户名称'";
                        DataBind(sql);

                        InitButtion();
                        nOperationStatus = 0;
                    }
                    else
                    {
                        MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    break;
                case 3:
                    //Delete Data
                    if(FrmMain.BOMID.Length <=0)
                    {
                        MessageBox.Show("请选择需要删除的记录!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (MessageBox.Show("确定要删除对应BOM信息吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                    {
                        InitButtion();
                        nOperationStatus = 0;
                        return;
                    }

                    //Delete Data
                    sql = "Delete from [SprayLacquerManagement].[dbo].[BOMInfo] where [BOMID]='" + FrmMain.BOMID + "' ";
                    string sql1= "delete from [SprayLacquerManagement].[dbo].[PartsInfo] where [BOMID]='" + FrmMain.BOMID + "' ";
                    if (clsApp.ExecuteSQL(sql,sql1, clsApp.ConnectString, ref sErrorMessage) == true)
                    {
                        //Refresh Data
                        //sql = "SELECT [CustomerName] as '客户名称',[ProductName] as '品名/机种',[Supplier] as '厂商',[OilPlaintType] as '喷漆类型',[OilSpeedU] as '流速上限',[OilSpeedL] as '流速下限',[WBMS] as '网布目数',[GuHuaPercent] as '固化剂比例',[XiShiUpPercent] as '稀释剂比例(上限)',[XiShiLowPercent] as '稀释剂比例(下限)',ValidHours as '油漆有效时间',[BOMID]  FROM BOMInfo ORDER BY '客户名称'";
                        //DataBind(sql);

                        ClearText();
                        InitButtion();
                        nOperationStatus = 0;
                    }
                    else
                    {
                        MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Cancel
            //Refresh and SHow Data
            if(nOperationStatus==1)
            {
                ClearText();
            }
            else
            { 
                RefreshandShowMainData();
                RefreshandShowDetailData();
            }

            InitButtion();
            nOperationStatus = 0;
            return;
        }

        private void txtPartNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                this.txtSupplier.SelectAll();
                this.txtSupplier.SelectionLength = this.txtSupplier.Text.Length;
                this.txtSupplier.Focus();
            }
        }

        private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.cmbPaintType.Focus();
            }
        }

        private void txtPaintSpeed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.txtGuHuaPercent.SelectAll();
                this.txtGuHuaPercent.SelectionLength = this.txtGuHuaPercent.Text.Length;
                this.txtGuHuaPercent.Focus();
            }
        }

        private void txtXiShiUpPercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.txtXiShiLowPercent.SelectAll();
                this.txtXiShiLowPercent.SelectionLength = this.txtXiShiLowPercent.Text.Length;
                this.txtXiShiLowPercent.Focus();
            }
        }

        private void txtXiShiLowPercent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                tbMain.SelectedIndex = 1;
                this.txtMainPart.SelectAll();
                this.txtMainPart.SelectionLength = this.txtMainPart.Text.Length;
                this.txtMainPart.Focus();

            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FrmMain.BOMID = "";
            FrmBOMInfoQuery frmbiq = new FrmBOMInfoQuery();
            frmbiq.ShowDialog();

            //check BOMID
            if(FrmMain.BOMID.Length>0)
            {
                //Refresh Data
                string sql = "SELECT [CustomerName] as '客户名称',[ProductName] as '品名/机种',[Supplier] as '厂商',[OilName] as '油漆名',[OilPlaintType] as '喷漆类型',[OilSpeedU] as '流速上限',[OilSpeedL] as '流速下限',[WBMS] as '网布目数',[GuHuaPercent] as '固化剂比例',[XiShiUpPercent] as '稀释剂比例(上限)',[XiShiLowPercent] as '稀释剂比例(下限)',ValidHours as '油漆有效时间',[BOMID]  FROM [SprayLacquerManagement].[dbo].[BOMInfo] ORDER BY '客户名称'";
                DataBind(sql);

                RefreshandShowMainData();
                RefreshandShowDetailData();
            }
        }

        private void dgBOMinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = this.dgBOMinfo.CurrentRow.Index;

            FrmMain.BOMID = dgBOMinfo.Rows[i].Cells["BOMID"].Value.ToString();

            //Refresh and SHow Data
            RefreshandShowMainData();
            RefreshandShowDetailData();
        }

        private void FrmBOM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nOperationStatus == 1)
            {
                if (MessageBox.Show("新增BOM信息还没有操作完成，确定要退出吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                                        
                }
                else
                {
                    e.Cancel = true;
                }
            }

            if (nOperationStatus == 2)
            {
                if (MessageBox.Show("对BOM信息所做的修改操作还没有完成，确定要退出吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    
                }
                else
                {
                    e.Cancel = true;
                }
            }

            if (nOperationStatus == 3)
            {
                if (MessageBox.Show("对BOM信息所做的删除操作还没有完成，确定要退出吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
