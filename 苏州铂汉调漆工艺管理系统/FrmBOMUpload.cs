using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 调漆工艺管理系统
{
    public partial class FrmBOMUpload : Form
    {
        private DataTable dtBOMinfo = new DataTable();
        public struct BOMInfo
        {
            public string CustomerName;
            public string PartNumber;
            public string Supplier;
            public string OilPaintType;
            public string OilSpeedU;
            public string OilSpeedL;
            public string GuHuaPercent;
            public string XiShiLowPercent;
            public string XiShiUpPercent;
            public string WBMS;
            public string ValidHours;
        }
        
        public FrmBOMUpload()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            string sFileName = "";
            string sErrorMessage = "";

            if (clsApp.OpenExcelFile(ref sFileName, ref sErrorMessage) == true)
            {
                this.txtFileName.Text = sFileName;
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            var filePath = this.txtFileName.Text;
            if (!File.Exists(filePath))
            {
                MessageBox.Show("未找到指定文件，请确认您的文件路径是否正确", "错误");
                return;
            }
            dtBOMinfo = new DataTable();
            dtBOMinfo = clsApp.ExcelToDS(this.txtFileName.Text);
            dgBOMInfo.DataSource = dtBOMinfo;
            dgBOMInfo.Refresh();
        }

        public bool DataVerify(BOMInfo bi,string[] mainparts,ref string[] GuHuaParts,string[] XiShiParts,ref string sErrorMessage)
        {
            if (bi.CustomerName.Length <= 0)
            {
                sErrorMessage = "请选择输入客户名称!";
                return false;
            }

            if (bi.PartNumber.Length <= 0)
            {
                sErrorMessage = "请输入机种、品名!";
                return false;
            }

            //txtSupplier
            if (bi.Supplier.Length <= 0)
            {
                sErrorMessage ="请输入厂商名称!";
                return false;
            }

            //cmbPaintType
            if (bi.OilPaintType.Length <= 0)
            {
                sErrorMessage ="请选择输入喷漆类型!";
                return false;
            }

            //txtPaintSpeed
            if (bi.OilSpeedU.Length <= 0)
            {
                sErrorMessage ="请输入流速上限数据!";
                return false;
            }

            if (bi.OilSpeedL.Length <= 0)
            {
                sErrorMessage="请输入流速下限数据!";
                return false;
            }

            if (bi.WBMS.Length <= 0)
            {
                sErrorMessage="请输入网布目数数据!";
                return false;
            }

            if (clsApp.IsDouble(bi.OilSpeedU, ref sErrorMessage) == false)
            {
                sErrorMessage="油漆的流速数据格式不正确!";
                return false;
            }

            if (clsApp.IsDouble(bi.OilSpeedL, ref sErrorMessage) == false)
            {
                sErrorMessage = "油漆的流速数据格式不正确!";
                return false;
            }

            //txtGuHuaPercent
            if (bi.GuHuaPercent.Length <= 0)
            {
                sErrorMessage="请输入固化剂配置比例!";
                return false;
            }

            if (clsApp.IsInt(bi.GuHuaPercent, ref sErrorMessage) == false)
            {
                sErrorMessage="固化剂配比数据格式不正确!";
                return false;
            }

            //txtXiShiUpPercent
            if (bi.XiShiUpPercent.Length <= 0)
            {
                sErrorMessage="请输入稀释剂上限!";
                return false;
            }

            if (clsApp.IsInt(bi.XiShiUpPercent, ref sErrorMessage) == false)
            {
                sErrorMessage="稀释剂上限配比数据格式不正确!";
                return false;
            }

            if (bi.XiShiLowPercent.Length <= 0)
            {
                sErrorMessage="请输入稀释剂下限!";;
                return false;
            }
            if (clsApp.IsInt(bi.XiShiLowPercent, ref sErrorMessage) == false)
            {
                sErrorMessage="稀释剂下限配比数据格式不正确!";
                return false;
            }

            //Valid Hours
            if (bi.ValidHours.Length <= 0)
            {
                sErrorMessage = "请输入油漆有效时间!";
                return false;
            }

            if (clsApp.IsInt(bi.ValidHours, ref sErrorMessage) == false)
            {
                sErrorMessage = "油漆有效时间数据格式不正确!";
                return false;
            }


            if (mainparts[0].Length<=0)
            {
                sErrorMessage="请输入主剂料号!";
                return false;
            }

            if (int.Parse(bi.GuHuaPercent) != 0)
            {
                if (GuHuaParts[0].Length <= 0)
                {
                    sErrorMessage="请输入固化剂料号!";
                    return false;
                }
            }
            else
            {
                GuHuaParts[0] = "NA";
            }

            if (XiShiParts[0].Length <= 0)
            {
                sErrorMessage="请输入稀释剂料号!";
                return false;
            }

            if (int.Parse(bi.XiShiUpPercent) <= int.Parse(bi.XiShiLowPercent))
            {
                sErrorMessage="稀释剂配比数据 上限必须大于下限!";
                return false;
            }

            return true;
        }

        public bool CheckProductName(string sProductName, ref bool bExsist, ref string sErrorMessage)
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sql = "select * from [SprayLacquerManagement].[dbo].[BOMInfo] where [productname]='" + sProductName + "' ";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                if (dsTemp.Tables[0].Rows.Count > 0)
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

        public bool GetRowID(string sProductName, ref string sRowID, ref string sErrorMessage)
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sql = "select * from [SprayLacquerManagement].[dbo].[BOMInfo] where [productname]='" + sProductName + "' ";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                if (dsTemp.Tables[0].Rows.Count > 0)
                {
                    sRowID = dsTemp.Tables[0].Rows[0]["BOMID"].ToString();
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

        private bool AppendData(BOMInfo bi,string[] MainParts,string[] GuHuaParts,string[] XiShiParts,ref string sErrorMessage)
        {
            //Append Data
            string sql="";
            string sRowID = "";

            sql = "Insert into [SprayLacquerManagement].[dbo].[BOMInfo]([BOMID],[CustomerName],[ProductName],[Supplier],[OilPlaintType],[OilSpeedU],[GuHuaPercent],[XiShiUpPercent],[XiShiLowPercent],[OilSpeedL],[WBMS],[ValidHours]) ";
            sql = sql + " Values(NEWID(),'" + bi.CustomerName + "','" + bi.PartNumber + "','" + bi.Supplier + "','" + bi.OilPaintType + "'," + bi.OilSpeedU + "," + bi.GuHuaPercent + "," + bi.XiShiUpPercent + "," + bi.XiShiLowPercent + "," + bi.OilSpeedL + "," + bi.WBMS + ","+bi.ValidHours+")";
            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == true)
            {
                //Get Row ID
                if (GetRowID(bi.PartNumber, ref sRowID, ref sErrorMessage) == false)
                {
                    return false;
                }

                //Append Main Part Number Info
                for (int i = 0; i < MainParts.Length; i++)
                {
                    if (MainParts[i].Length > 0)
                    {
                        sql = "Insert into [SprayLacquerManagement].[dbo].[PartsInfo]([BOMID],[PartType],[PartNumber]) values('" + sRowID + "','MAIN','" + MainParts[i].ToString() + "' )";
                        clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                    }
                }

                //Append GuHua Part Number Info
                for (int i = 0; i < GuHuaParts.Length; i++)
                {
                    if (GuHuaParts[i].Length > 0)
                    {
                        sql = "Insert into [SprayLacquerManagement].[dbo].[PartsInfo]([BOMID],[PartType],[PartNumber]) values('" + sRowID + "','GUHUA','" + GuHuaParts[i].ToString() + "' )";
                        clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                    }
                }

                //Append XiShi Part Number Info
                for (int i = 0; i < XiShiParts.Length; i++)
                {
                    if (XiShiParts[i].Length > 0)
                    {
                        sql = "Insert into [SprayLacquerManagement].[dbo].[PartsInfo]([BOMID],[PartType],[PartNumber]) values('" + sRowID + "','XISHI','" + XiShiParts[i].ToString() + "' )";
                        clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                    }
                }

                return true;
            }    
            else
            {
                return false;
            }
        }

        private void RefreshOilPaintType()
        {
            System.Data.DataSet dsTemp = new DataSet();
            string sErrorMessage = "";

            string sql = "select distinct [OilPlaintType] as OilPaintType from [SprayLacquerManagement].[dbo].[BOMInfo] ";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                for(int i=0;i<dsTemp.Tables[0].Rows.Count;i++)
                {
                    sql= "Insert into [SprayLacquerManagement].[dbo].[OilPaintTypes]([OilPaintType],[Description]) values('" + dsTemp.Tables[0].Rows[i]["OilPaintType"].ToString()+"','') ";
                    clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage);
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            rtbErrorMessage.Clear();
            btnUpload.Enabled = false;
            bool bRes = false;
            BOMInfo bi = new BOMInfo();
            string[] MainPart = new string[3];
            string[] GuHua = new string[3];
            string[] XiShi = new string[3];

            for(int i=0;i<dtBOMinfo.Rows.Count;i++)
            {
                #region Get BOM Record
                bi.CustomerName = dtBOMinfo.Rows[i][0].ToString().Trim();
                bi.PartNumber = dtBOMinfo.Rows[i][1].ToString().Trim();
                bi.Supplier = dtBOMinfo.Rows[i][2].ToString().Trim();
                bi.OilPaintType = dtBOMinfo.Rows[i][3].ToString().Trim();

                MainPart[0] = dtBOMinfo.Rows[i][4].ToString().Trim();
                MainPart[1] = dtBOMinfo.Rows[i][5].ToString().Trim();
                MainPart[2] = dtBOMinfo.Rows[i][6].ToString().Trim();

                GuHua[0] = dtBOMinfo.Rows[i][7].ToString().Trim();
                GuHua[1] = dtBOMinfo.Rows[i][8].ToString().Trim();
                GuHua[2] = dtBOMinfo.Rows[i][9].ToString().Trim();

                bi.GuHuaPercent = dtBOMinfo.Rows[i][10].ToString().Trim();

                XiShi[0] = dtBOMinfo.Rows[i][11].ToString().Trim();
                XiShi[1] = dtBOMinfo.Rows[i][12].ToString().Trim();
                XiShi[2] = dtBOMinfo.Rows[i][13].ToString().Trim();

                bi.XiShiUpPercent = dtBOMinfo.Rows[i][14].ToString().Trim();
                bi.XiShiLowPercent = dtBOMinfo.Rows[i][15].ToString().Trim();

                bi.OilSpeedU = dtBOMinfo.Rows[i][16].ToString().Trim();
                bi.OilSpeedL = dtBOMinfo.Rows[i][17].ToString().Trim();

                bi.WBMS = dtBOMinfo.Rows[i][18].ToString().Trim();
                bi.ValidHours = dtBOMinfo.Rows[i][19].ToString().Trim();
                #endregion

                #region Verify
                if(DataVerify(bi,MainPart,ref GuHua,XiShi,ref sErrorMessage)==false)
                {
                    rtbErrorMessage.AppendText(sErrorMessage+"\r\n");
                }
                else
                {
                    if (CheckProductName(bi.PartNumber, ref bRes, ref sErrorMessage) == true)
                    {
                        if (bRes == true)
                        {
                            sErrorMessage = bi.PartNumber + "机种、品名已经存在!";
                            rtbErrorMessage.AppendText(sErrorMessage + "\r\n");
                        }
                        else
                        {
                            //Append
                            if (AppendData(bi, MainPart, GuHua, XiShi, ref sErrorMessage) == false)
                            {
                                rtbErrorMessage.AppendText(sErrorMessage + "\r\n");
                            }
                        }
                    }
                    else
                    {
                        rtbErrorMessage.AppendText(sErrorMessage + "\r\n");
                    }
                }
                #endregion
            }

            //Refresh Oil Paint Type
            RefreshOilPaintType();
            rtbErrorMessage.AppendText("Upload the BOM Data Successfully!" + "\r\n");
            MessageBox.Show("Upload the BOM Data Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnUpload.Enabled = true;
        }
    }
}
