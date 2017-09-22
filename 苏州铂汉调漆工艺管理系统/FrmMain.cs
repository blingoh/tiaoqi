using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace 调漆工艺管理系统
{
    public partial class FrmMain : Form
    {
        #region Variables
        public static string sCustomerInfo = "";
        public static bool RegisterStatus = false;
        public static string RegCode = "";

        public static clsApp.UserInfo userinfo = new clsApp.UserInfo();
        public static clsApp.SystemConfiguration systemconfig = new clsApp.SystemConfiguration();
        public string DBConnectionString = "";
        public static string BOMID;

        public static clsApp.MainCodeRuleStruct mainCoeRule = new clsApp.MainCodeRuleStruct();
        public static clsApp.GuhuaCodeRuleStruct guhuaCodeRule = new clsApp.GuhuaCodeRuleStruct();
        public static clsApp.XishiCodeRuleStruct xishiCodeRule = new clsApp.XishiCodeRuleStruct();

        public string spPortMain_Result = "";
        public string spPortGuHua_Result = "";
        public string spPortXiShi_Result = "";
        
        private long received_count_Main = 0;//接收计数
        private StringBuilder builderMain = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。
        
        private long received_count_GuHua = 0;//接收计数
        private StringBuilder builderGuHua = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。

        private long received_count_XiShi = 0;//接收计数
        private StringBuilder builderXiShi = new StringBuilder();//避免在事件处理方法中反复的创建，定义到外面。

        public static TaskData productiondata = new TaskData();

        public bool MainListening = false;
        public bool GuHuaListening = false;
        public bool XiShiListening = false;
        
        
        public struct TaskData
        {
            public string TaskID;
            public string BOMID;
            public string ShiftName;
            public string LineName;
            public string PartNumber;
            public string Supplier;
            public string YouQiType;

            public string VendorCodeMain;
            public string PartNumberMain;
            public string LotNumberMain;
            public double HolderWeightMain;
            public double TargetWeightMain;
            public double ActualWeightMain;
            public bool GetMainHolderWeight;

            public string VendorCodeGuHua;
            public string PartNumberGuHua;
            public string LotNumberGuHua;
            public int GuHuaRangeBase;
            public double HolderWeightGuHua;
            public double TargetWeightGuHua;
            public double GuHuaWeightSPECL;
            public double GuHuaWeightSPECU;
            public double ActualWeightGuHua;
            public double GuHUaTargetRate;
            public double GuHuaActualRate;
            public bool GetGuHuaHolderWeight;

            public string VendorCodeXiShi;
            public string PartNumberXiShi;
            public string LotNumberXiShi;
            public double HolderWeightXiShi;
            public int XiShiTargetSPECL;
            public int XiShiTargetSPECU;
            public double XiShiWeightSPECL;
            public double XiShiWeightSPECU;
            public double XiShiActualRate;
            public double ActualWeightXiShi;
            public bool GetXiShiHolderWeight;

            
            public int ActualDelaySeconds;

            public double OilSpeedU;
            public double OilSpeedL;
            public double ActualSpeed;
            public double ValidHours;

            public int Status; //0-NA 1-Main 2-GuHua,3-XiSHi 4-SpeedConfirm
        }

        private bool taskStop; // 是否作业已被停止

        #endregion

        public FrmMain()
        {
            InitializeComponent();
            lnkLblAccount.Text = userinfo.UserName + "（" + userinfo.SecurityRight + "）";
            ClientSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            tsslUserType.Text = "职责：" + userinfo.SecurityRight;
            tsslUserInfo.Text = "用户名：" + userinfo.UserName;
        }

        #region Function
        public void ClearProductionData()
        {
            productiondata.VendorCodeMain="";
            productiondata.PartNumberMain = "";
            productiondata.LotNumberMain = "";
            productiondata.HolderWeightMain = 0;
            productiondata.TargetWeightMain = 0;
            productiondata.ActualWeightMain = 0;
            productiondata.GetMainHolderWeight = false;

            productiondata.VendorCodeGuHua = "";
            productiondata.PartNumberGuHua = "";
            productiondata.LotNumberGuHua = "";
            productiondata.GuHuaRangeBase = FrmMain.systemconfig.GuHuaRange;
            productiondata.HolderWeightGuHua = 0;
            productiondata.TargetWeightGuHua = 0;
            productiondata.ActualWeightGuHua = 0;
            productiondata.GuHuaActualRate = 0;
            productiondata.GetGuHuaHolderWeight = false;

            productiondata.VendorCodeXiShi = "";
            productiondata.PartNumberXiShi = "";
            productiondata.LotNumberXiShi = "";
            productiondata.HolderWeightXiShi = 0;
            productiondata.XiShiWeightSPECL = 0;
            productiondata.XiShiWeightSPECU = 0;
            productiondata.XiShiActualRate = 0;
            productiondata.ActualWeightXiShi = 0;
            productiondata.GetXiShiHolderWeight = false;

            productiondata.ActualSpeed = 0;

            productiondata.Status = 0;
        }

        public void InitProductionData()
        {
            productiondata.BOMID = "";
            productiondata.ShiftName = "";
            productiondata.LineName = "";

            productiondata.VendorCodeMain="";
            productiondata.PartNumberMain = "";
            productiondata.LotNumberMain = "";
            productiondata.HolderWeightMain = 0;
            productiondata.TargetWeightMain = 0;
            productiondata.ActualWeightMain = 0;
            productiondata.GetMainHolderWeight = false;

            productiondata.VendorCodeGuHua = "";
            productiondata.PartNumberGuHua = "";
            productiondata.LotNumberGuHua = "";
            productiondata.GuHuaRangeBase = FrmMain.systemconfig.GuHuaRange;
            productiondata.HolderWeightGuHua = 0;
            productiondata.TargetWeightGuHua = 0;
            productiondata.ActualWeightGuHua = 0;
            productiondata.GuHuaActualRate = 0;
            productiondata.GetGuHuaHolderWeight = false;

            productiondata.VendorCodeXiShi = "";
            productiondata.PartNumberXiShi = "";
            productiondata.LotNumberXiShi = "";
            productiondata.HolderWeightXiShi = 0;
            productiondata.XiShiWeightSPECL = 0;
            productiondata.XiShiWeightSPECU = 0;
            productiondata.XiShiActualRate = 0;
            productiondata.ActualWeightXiShi = 0;
            productiondata.GetXiShiHolderWeight = false;

            productiondata.ActualSpeed = 0;

            productiondata.Status = 0;
        }

        public void InitMainUi()
        {
            btnSubmit.Visible = false;
            btnMainPart.Enabled = true;
            btnGuHua.Enabled = false;
            btnXiShi.Enabled = false;
            btnStopMain.Enabled = btnStopGuhua.Enabled = btnStopXishi.Enabled = false;
            btnMainCard.Enabled = btnGuHuaCard.Enabled = btnXiShiCard.Enabled = false;

            //lblMainPartVendor.Text = "";
            lblMainPartNumber.Text = "";
            lblMainPartsLotNumber.Text = "";

            //lblGuHuaPartVendor.Text = "";
            lblGuHuaPartNumber.Text = "";
            lblGuHuaLotNum.Text = "";

            //lblXiShiVendor.Text = "";
            lblXiSHiPartNumber.Text = "";
            lblXiShiLot.Text = "";

            pbMainParts.Value = 0;
            pbGuHuaParts.Value = 0;
            pbXiShiParts.Value = 0;
            pbXiShiParts.Max = 100;
            pbGuHuaParts.Max = 100;
            pbMainParts.Max = 100;
            
            lblMainPartWeight.Text = "0.0";
            lblGuHuaPartWeight.Text = "0.0";
            lblXiShiPartWeight.Text = "0.0";

            lblMainHolderWeight.Text = "";
            lblGuHuaHolderWeight.Text = "";
            lblXiShiHolderWeight.Text = "";

            txtMainPartTargetWeight.Enabled = true;
            cmbShift.Enabled = true;
            cmbProductionLine.Enabled = true;
            txtPartNumber.Enabled = true;
            txtSupplier.Enabled = true;
            lblPaintType.Enabled = true;
            btnQuery.Enabled = true;

        }

        public void InitSystemConfigurationInfo()
        {
            systemconfig.ServerName = "";
            systemconfig.UserID = "";
            systemconfig.Password = "";

            systemconfig.PrinterPath = "";
            systemconfig.LabelTemplatePath = "";
        }

        public bool RefreshandShowMainData()
        {
            string sErrorMessage = "";
            System.Data.DataSet dsTemp = new DataSet();
            string sql = "SELECT [BOMID],[CustomerName] as '客户名称',[ProductName] as '品名/机种',[Supplier] as '厂商',[OilPlaintType] as '喷漆类型',[OilSpeedU] as '流速上限',[OilSpeedL] as '流速下限',[GuHuaPercent] as '固化剂比例',[XiShiUpPercent] as '稀释剂比例(上限)',[XiShiLowPercent] as '稀释剂比例(下限)',[ValidHours]  FROM [SprayLacquerManagement].[dbo].[BOMInfo] where [BOMID]='" + FrmMain.BOMID + "'";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                if (dsTemp.Tables[0].Rows.Count > 0)
                {

                    this.txtPartNumber.Text = dsTemp.Tables[0].Rows[0]["品名/机种"].ToString();
                    this.txtSupplier.Text = dsTemp.Tables[0].Rows[0]["厂商"].ToString();
                    this.lblPaintType.Text = dsTemp.Tables[0].Rows[0]["喷漆类型"].ToString();
                    
                    productiondata.GuHUaTargetRate=int.Parse(dsTemp.Tables[0].Rows[0]["固化剂比例"].ToString());
                    productiondata.XiShiTargetSPECL=int.Parse(dsTemp.Tables[0].Rows[0]["稀释剂比例(下限)"].ToString());
                    productiondata.XiShiTargetSPECU=int.Parse(dsTemp.Tables[0].Rows[0]["稀释剂比例(上限)"].ToString());

                    productiondata.OilSpeedU = double.Parse(dsTemp.Tables[0].Rows[0]["流速上限"].ToString());
                    productiondata.OilSpeedL = double.Parse(dsTemp.Tables[0].Rows[0]["流速下限"].ToString());
                    productiondata.ValidHours = int.Parse(dsTemp.Tables[0].Rows[0]["ValidHours"].ToString());

                    productiondata.BOMID = FrmMain.BOMID;
                    FrmMain.productiondata.GetMainHolderWeight = false;
                    FrmMain.productiondata.Status = 0; //Start working for the Main Parts
                    FrmMain.productiondata.TaskID = "";
                    FrmMain.productiondata.PartNumber = this.txtPartNumber.Text;
                    FrmMain.productiondata.ShiftName = cmbShift.Text;
                    FrmMain.productiondata.LineName = cmbProductionLine.Text;
                    FrmMain.productiondata.Supplier = txtSupplier.Text;

                    lblMainPartInfo.Text = "原 油(100)";
                    lblGuHuaPartInfo.Text = "固化剂("+((int)productiondata.GuHUaTargetRate).ToString()+")";
                    lblXiShiPartInfo.Text = "稀释剂(" + ((int)productiondata.XiShiTargetSPECL).ToString() + "~" + ((int)productiondata.XiShiTargetSPECU).ToString() + ")";

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

        public static bool ReadSystemConfigurationInfo(ref string sErrorMessage)
        {
            clsIniFile clsif = new clsIniFile(clsApp.filepath);
            
            //Scale Port for 基础漆
            FrmMain.systemconfig.ScaleMainPortSettings.BaudRate = clsif.ReadInt("ScaleMain", "BaudRate");
            FrmMain.systemconfig.ScaleMainPortSettings.PortNum = clsif.ReadInt("ScaleMain", "PortNum");
            FrmMain.systemconfig.ScaleMainPortSettings.Parity = clsif.ReadString("ScaleMain", "Parity");
            FrmMain.systemconfig.ScaleMainPortSettings.DataBits = clsif.ReadInt("ScaleMain", "DataBits");
            FrmMain.systemconfig.ScaleMainPortSettings.StopBits = clsif.ReadInt("ScaleMain", "StopBits");

            //Scale Port for 固化剂
            FrmMain.systemconfig.ScaleGuHuaPortSettings.BaudRate = clsif.ReadInt("ScaleGuHua", "BaudRate");
            FrmMain.systemconfig.ScaleGuHuaPortSettings.PortNum = clsif.ReadInt("ScaleGuHua", "PortNum");
            FrmMain.systemconfig.ScaleGuHuaPortSettings.Parity = clsif.ReadString("ScaleGuHua", "Parity");
            FrmMain.systemconfig.ScaleGuHuaPortSettings.DataBits = clsif.ReadInt("ScaleGuHua", "DataBits");
            FrmMain.systemconfig.ScaleGuHuaPortSettings.StopBits = clsif.ReadInt("ScaleGuHua", "StopBits");

            //Scale Port for 稀释
            FrmMain.systemconfig.ScaleXiShiPortSettings.BaudRate = clsif.ReadInt("ScaleXiShi", "BaudRate");
            FrmMain.systemconfig.ScaleXiShiPortSettings.PortNum = clsif.ReadInt("ScaleXiShi", "PortNum");
            FrmMain.systemconfig.ScaleXiShiPortSettings.Parity = clsif.ReadString("ScaleXiShi", "Parity");
            FrmMain.systemconfig.ScaleXiShiPortSettings.DataBits = clsif.ReadInt("ScaleXiShi", "DataBits");
            FrmMain.systemconfig.ScaleXiShiPortSettings.StopBits = clsif.ReadInt("ScaleXiShi", "StopBits");
            
            //Printer Info
            FrmMain.systemconfig.PrinterPath = clsif.ReadString("Printer", "PrinterPath");
            FrmMain.systemconfig.LabelTemplatePath = clsif.ReadString("Printer", "LabelTemplate");

            //System Parameters
            FrmMain.systemconfig.GuHuaRange = clsif.ReadInt("Parameters", "GuHuaRange");
            FrmMain.systemconfig.AutoScaleHolderWeight = clsif.ReadInt("Parameters", "AutoScaleHolderWeight");

            // 数据库
            FrmMain.systemconfig.UserID = clsif.ReadString("Database", "UserName");
            FrmMain.systemconfig.Password = clsif.ReadString("Database", "Password");
            FrmMain.systemconfig.ServerName = clsif.ReadString("Database", "ServerName");

            FrmMain.mainCoeRule.MainCodeRule = clsif.ReadString("CodeRule", "MainCodeRule");
            FrmMain.mainCoeRule.MainNumRule = clsif.ReadString("CodeRule", "MainNumCodeRule");
            FrmMain.guhuaCodeRule.MainCodeRule = clsif.ReadString("CodeRule", "GuHuaMainCodeRule");
            FrmMain.guhuaCodeRule.MainNumRule = clsif.ReadString("CodeRule", "GuHuaMainNumCodeRule");
            FrmMain.xishiCodeRule.MainCodeRule = clsif.ReadString("CodeRule", "XiShiMainCodeRule");
            FrmMain.xishiCodeRule.MainNumRule = clsif.ReadString("CodeRule", "XiShiMainNumCodeRule");

            return true;
        }

        private bool GetNewID(ref string sNewID, ref string sErrorMessage)
        {
            string sql = "select newid()";
            System.Data.DataSet dsTemp = new DataSet();
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                sNewID = dsTemp.Tables[0].Rows[0][0].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FillProductionLine(ref string sErrorMessage)
        {
            this.cmbProductionLine.Items.Clear();
            string sql = "SELECT * FROM [SprayLacquerManagement].[dbo].[ProductionLine]";
            System.Data.DataSet dsTemp = new DataSet();
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                for (int i = 0; i < dsTemp.Tables[0].Rows.Count; i++)
                {
                    this.cmbProductionLine.Items.Add(dsTemp.Tables[0].Rows[i][1].ToString());
                }
            }
        }

        #endregion

        #region Scale Serial Port Function

        #region Main Part Scale

        public bool ComINIT_Main(ref string sErrorMessage)
        {
            try
            {
                if (spPortMain.IsOpen)
                {
                    spPortMain.Close();
                }

                spPortMain.PortName = "COM" + FrmMain.systemconfig.ScaleMainPortSettings.PortNum.ToString();
                spPortMain.BaudRate =FrmMain.systemconfig.ScaleMainPortSettings.BaudRate;
                spPortMain.DataBits = FrmMain.systemconfig.ScaleMainPortSettings.DataBits;

                switch (FrmMain.systemconfig.ScaleMainPortSettings.Parity.ToUpper())
                {
                    case "NONE":
                        spPortMain.Parity = System.IO.Ports.Parity.None;
                        break;
                    case "EVEN":
                        spPortMain.Parity = System.IO.Ports.Parity.Even;
                        break;
                    case "ODD":
                        spPortMain.Parity = System.IO.Ports.Parity.Odd;
                        break;
                    case "MARK":
                        spPortMain.Parity = System.IO.Ports.Parity.Mark;
                        break;
                    case "SPACE":
                        spPortMain.Parity = System.IO.Ports.Parity.Space;
                        break;
                    default:
                        break;
                }

                switch (FrmMain.systemconfig.ScaleMainPortSettings.StopBits)
                {
                    case 1:
                        spPortMain.StopBits = System.IO.Ports.StopBits.One;
                        break;
                    case 2:
                        spPortMain.StopBits = System.IO.Ports.StopBits.Two;
                        break;
                    default:
                        break;
                }

                sErrorMessage = "";
                return true;
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public bool ComOpenMain(ref string sErrorMessage)
        {
            if (spPortMain.IsOpen)
            {
                return true;
            }

            try
            {
                spPortMain.Open();
                return true;
            }
            catch (System.Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public bool ComCloseMain(SerialPort sptemp, ref string sErrorMessage)
        {
            if (spPortMain.IsOpen == true)
            {
                try
                {
                    while (MainListening || GuHuaListening || XiShiListening)
                    {
                        Application.DoEvents();
                    }
                    spPortMain.Close();
                    return true;
                }
                catch (System.Exception ex)
                {
                    sErrorMessage = ex.Message.ToString();
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private string SplitResult(string sTemp)
        {
            string sxx=sTemp.Replace("O", "").Replace("L", "").Replace("U", "").Replace("N", "").Replace("S", "").Replace("N", "").Replace("T", "").Replace("R", "").Replace("?", "").Replace("+", "").Replace("-", "").Replace("k", "").Replace("g", "").Replace(",", "").Replace("\r", "").Trim();
            try
            {
                double dx = double.Parse(sxx);
                return sxx;
            }
            catch(Exception ex)
            {
                return "";
            }

        }

        private void spPortMain_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (spPortMain.IsOpen ==false )
            {
                return;
            }
            MainListening = true;
            double dRes = 0;
            int n = spPortMain.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            received_count_Main += n;//增加接收计数
            spPortMain.Read(buf, 0, n);//读取缓冲数据
            builderMain.Remove(0, builderMain.Length);//清除字符串构造器的内容

            string sTemp;
            string[] xxx;

            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
                spPortMain_Result = spPortMain_Result + System.Text.Encoding.ASCII.GetString(buf);
                
                if (spPortMain_Result.Length >= 80)
                {
                    xxx = spPortMain_Result.Split('\n');
                    sTemp = "";
                    for (int i = xxx.Length-1; i >0;i-- )
                    {
                        if(xxx[i].IndexOf("\r")>0)
                        {
                            sTemp = xxx[i].ToString();
                            break;
                        }
                        else
                        {
                            sTemp = "";
                        }
                    }

                    sTemp = SplitResult(sTemp);
                    if(sTemp.Length<=0)
                    {
                        return;
                    }

                    if (FrmMain.systemconfig.AutoScaleHolderWeight == 1 && FrmMain.productiondata.GetMainHolderWeight == false)
                    {
                        dRes =double.Parse(sTemp);

                        //get holder weight
                        spPortMain_Result = "";
                        FrmMain.productiondata.GetMainHolderWeight = true;

                        FrmMain.productiondata.HolderWeightMain = dRes;
                        lblMainHolderWeight.Text = dRes.ToString("0.000")+"kg";
                        MainListening = false;
                        return;
                    }
                    else
                    {
                        if (FrmMain.systemconfig.AutoScaleHolderWeight == 1)
                        {
                            dRes = double.Parse(sTemp)-double.Parse(lblMainHolderWeight.Text.Replace("kg","").Trim());
                            if (lblMainPartWeight.Text != dRes.ToString("0.000"))
                            {
                                lblMainPartWeight.Text = dRes.ToString("0.000");
                            }
                        }
                        else
                        {
                            dRes = double.Parse(sTemp);

                            if (lblMainPartWeight.Text != sTemp)
                            {
                                lblMainPartWeight.Text = sTemp;
                            }
                            
                        }
                    }

                    spPortMain_Result = "";
                    this.txtMainPartActualWeight.Text = dRes.ToString();
                    FrmMain.productiondata.ActualWeightMain = dRes;
                    this.txtMainPartRaiseWeight.Text = System.Math.Abs(dRes - double.Parse(this.txtMainPartTargetWeight.Text)).ToString();

                    //Calculate Percent
                    double x = dRes * 100 / double.Parse(txtMainPartTargetWeight.Text);
                    if ((int)x > 100)
                    {
                        this.pbMainParts.Max = (int)x;
                    }
                    else
                    {
                        this.pbMainParts.Max = 100;
                    }

                    this.pbMainParts.Value = (int)x;

                    if ((int)x < 97)
                    {
                        pbMainParts.BarColorSolid = Color.Yellow;
                    }
                    else if ((int)x >= 97 && (int)x <= 103)
                    {
                        pbMainParts.BarColorSolid = Color.Green;
                    }
                    else
                    {
                        pbMainParts.BarColorSolid = Color.Red;
                    }

                    FrmMain.productiondata.GuHuaWeightSPECL = dRes * 0.95 * 1000 * productiondata.GuHUaTargetRate / 100;
                    FrmMain.productiondata.GuHuaWeightSPECU = dRes * 1.05 * 1000 * productiondata.GuHUaTargetRate / 100;

                    FrmMain.productiondata.XiShiWeightSPECL = dRes * productiondata.XiShiTargetSPECL / 100;
                    FrmMain.productiondata.XiShiWeightSPECU = dRes * productiondata.XiShiTargetSPECU / 100;
                }

            }));
            MainListening = false;
        }

        #endregion

        #region GuHua 
        public bool ComINIT_GuHua(ref string sErrorMessage)
        {
            try
            {
                if (spPortGuHua.IsOpen)
                {
                    spPortGuHua.Close();
                }

                spPortGuHua.PortName = "COM" + FrmMain.systemconfig.ScaleGuHuaPortSettings.PortNum.ToString();
                spPortGuHua.BaudRate = FrmMain.systemconfig.ScaleGuHuaPortSettings.BaudRate;
                spPortGuHua.DataBits = FrmMain.systemconfig.ScaleGuHuaPortSettings.DataBits;

                switch (FrmMain.systemconfig.ScaleGuHuaPortSettings.Parity.ToUpper())
                {
                    case "NONE":
                        spPortGuHua.Parity = System.IO.Ports.Parity.None;
                        break;
                    case "EVEN":
                        spPortGuHua.Parity = System.IO.Ports.Parity.Even;
                        break;
                    case "ODD":
                        spPortGuHua.Parity = System.IO.Ports.Parity.Odd;
                        break;
                    case "MARK":
                        spPortGuHua.Parity = System.IO.Ports.Parity.Mark;
                        break;
                    case "SPACE":
                        spPortGuHua.Parity = System.IO.Ports.Parity.Space;
                        break;
                    default:
                        break;
                }

                switch (FrmMain.systemconfig.ScaleGuHuaPortSettings.StopBits)
                {
                    case 1:
                        spPortGuHua.StopBits = System.IO.Ports.StopBits.One;
                        break;
                    case 2:
                        spPortGuHua.StopBits = System.IO.Ports.StopBits.Two;
                        break;
                    default:
                        break;
                }

                sErrorMessage = "";
                return true;
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public bool ComOpenGuHua(ref string sErrorMessage)
        {
            if (spPortGuHua.IsOpen)
            {
                return true;
            }

            try
            {
                spPortGuHua.Open();
                return true;
            }
            catch (System.Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public bool ComCloseGuHua(SerialPort sptemp, ref string sErrorMessage)
        {
            if (spPortGuHua.IsOpen == true)
            {
                try
                {
                    //spPortGuHua.DiscardInBuffer();
                    while (MainListening || GuHuaListening || XiShiListening)
                    {
                        Application.DoEvents();
                    }
                    spPortGuHua.Close();
                    return true;
                }
                catch (System.Exception ex)
                {
                    sErrorMessage = ex.Message.ToString();
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void spPortGuHua_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (spPortGuHua.IsOpen == false)
            {
                return;
            }
            GuHuaListening = true;
            double dRes = 0;
            int n = spPortGuHua.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            received_count_GuHua += n;//增加接收计数
            spPortGuHua.Read(buf, 0, n);//读取缓冲数据
            builderGuHua.Remove(0, builderGuHua.Length);//清除字符串构造器的内容

            string sTemp;
            string[] xxx;

            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
                spPortMain_Result = spPortMain_Result + System.Text.Encoding.ASCII.GetString(buf);

                if (spPortMain_Result.Length >= 80)
                {
                    xxx = spPortMain_Result.Split('\n');
                    sTemp = "";
                    for (int i = xxx.Length - 1; i > 0; i--)
                    {
                        if (xxx[i].IndexOf("\r")>0)
                        {
                            sTemp = xxx[i].ToString();
                            break;
                        }
                        else
                        {
                            sTemp = "";
                        }
                    }

                    sTemp = SplitResult(sTemp);
                    if (sTemp.Length <= 0)
                    {
                        return;
                    }

                    if (FrmMain.systemconfig.AutoScaleHolderWeight == 1 && FrmMain.productiondata.GetGuHuaHolderWeight == false)
                    {
                        dRes = double.Parse(sTemp);

                        //get holder weight
                        spPortGuHua_Result = "";
                        FrmMain.productiondata.GetGuHuaHolderWeight = true;

                        FrmMain.productiondata.HolderWeightGuHua = dRes;
                        
                        lblGuHuaHolderWeight.Text = dRes.ToString("0.0")+"g";
                        GuHuaListening = false;
                        
                        return;
                    }
                    else
                    {
                        if (FrmMain.systemconfig.AutoScaleHolderWeight == 1)
                        {
                            dRes = double.Parse(sTemp) - double.Parse(lblGuHuaHolderWeight.Text.Replace("g","").Trim());
                            if (lblGuHuaPartWeight.Text != dRes.ToString("0.0"))
                            {
                                lblGuHuaPartWeight.Text = dRes.ToString("0.0");
                            }
                        }
                        else
                        {
                            dRes = double.Parse(sTemp);

                            if (lblGuHuaPartWeight.Text != sTemp)
                            {
                                lblGuHuaPartWeight.Text = sTemp;
                            }

                        }
                    }

                    spPortGuHua_Result = "";
                    FrmMain.productiondata.ActualWeightGuHua = dRes;

                    //Calculate Percent
                    double x = dRes * 2 * 100 / (productiondata.GuHuaWeightSPECL + productiondata.GuHuaWeightSPECU);

                    if ((int)x >= 100)
                    {
                        this.pbGuHuaParts.Max = (int)x;
                    }
                    else
                    {
                        this.pbGuHuaParts.Max = 100;
                    }

                    pbGuHuaParts.Value = (int)x;
                    if ((int)x < 97)
                    {
                        pbGuHuaParts.BarColorSolid = Color.Yellow;
                    }
                    else if ((int)x >= 97 && (int)x <= 103)
                    {
                        pbGuHuaParts.BarColorSolid = Color.Green;
                    }
                    else
                    {
                        pbGuHuaParts.BarColorSolid = Color.Red;
                    }
                    
                    FrmMain.productiondata.GuHuaActualRate = dRes * 100 / (double.Parse(this.txtMainPartActualWeight.Text) * 1000);
                }

            }));
            GuHuaListening = false;
        }

       #endregion

        #region XiSHi
        public bool ComINIT_XiShi(ref string sErrorMessage)
        {
            try
            {
                if (spPortXiShi.IsOpen)
                {
                    spPortXiShi.Close();
                }

                spPortXiShi.PortName = "COM" + FrmMain.systemconfig.ScaleXiShiPortSettings.PortNum.ToString();
                spPortXiShi.BaudRate = FrmMain.systemconfig.ScaleXiShiPortSettings.BaudRate;
                spPortXiShi.DataBits = FrmMain.systemconfig.ScaleXiShiPortSettings.DataBits;

                switch (FrmMain.systemconfig.ScaleXiShiPortSettings.Parity.ToUpper())
                {
                    case "NONE":
                        spPortXiShi.Parity = System.IO.Ports.Parity.None;
                        break;
                    case "EVEN":
                        spPortXiShi.Parity = System.IO.Ports.Parity.Even;
                        break;
                    case "ODD":
                        spPortXiShi.Parity = System.IO.Ports.Parity.Odd;
                        break;
                    case "MARK":
                        spPortXiShi.Parity = System.IO.Ports.Parity.Mark;
                        break;
                    case "SPACE":
                        spPortXiShi.Parity = System.IO.Ports.Parity.Space;
                        break;
                    default:
                        break;
                }

                switch (FrmMain.systemconfig.ScaleXiShiPortSettings.StopBits)
                {
                    case 1:
                        spPortXiShi.StopBits = System.IO.Ports.StopBits.One;
                        break;
                    case 2:
                        spPortXiShi.StopBits = System.IO.Ports.StopBits.Two;
                        break;
                    default:
                        break;
                }

                sErrorMessage = "";
                return true;
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public bool ComOpenXiShi(ref string sErrorMessage)
        {
            if (spPortXiShi.IsOpen)
            {
                return true;
            }

            try
            {
                spPortXiShi.Open();
                return true;
            }
            catch (System.Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public bool ComCloseXiShi(SerialPort sptemp, ref string sErrorMessage)
        {
            if (spPortXiShi.IsOpen == true)
            {
                try
                {
                    spPortXiShi.DiscardInBuffer();
                    while (MainListening || GuHuaListening || XiShiListening)
                    {
                        Application.DoEvents();
                    }
                    spPortXiShi.Close();
                    return true;
                }
                catch (System.Exception ex)
                {
                    sErrorMessage = ex.Message.ToString();
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private void spPortXiShi_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (spPortXiShi.IsOpen==false )
            {
                return;
            }

            XiShiListening = true;
            double dRes = 0;
            int n = spPortXiShi.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            received_count_XiShi += n;//增加接收计数
            spPortXiShi.Read(buf, 0, n);//读取缓冲数据
            builderXiShi.Remove(0, builderXiShi.Length);//清除字符串构造器的内容

            string sTemp;
            string[] xxx;

            //因为要访问ui资源，所以需要使用invoke方式同步ui。
            this.Invoke((EventHandler)(delegate
            {
                spPortXiShi_Result = spPortXiShi_Result + System.Text.Encoding.ASCII.GetString(buf);

                if (spPortXiShi_Result.Length >= 80)
                {
                    xxx = spPortXiShi_Result.Split('\n');
                    sTemp = "";
                    for (int i = xxx.Length - 1; i > 0; i--)
                    {
                        if (xxx[i].IndexOf("\r")>0)
                        {
                            sTemp = xxx[i].ToString();
                            break;
                        }
                        else
                        {
                            sTemp = "";
                        }
                    }

                    sTemp = SplitResult(sTemp);

                    if (sTemp.Length <= 0)
                    {
                        return;
                    }

                    if (FrmMain.systemconfig.AutoScaleHolderWeight == 1 && FrmMain.productiondata.GetXiShiHolderWeight == false)
                    {
                        dRes = double.Parse(sTemp);

                        //get holder weight
                        spPortMain_Result = "";
                        FrmMain.productiondata.GetXiShiHolderWeight = true;

                        FrmMain.productiondata.HolderWeightXiShi = dRes;
                        lblXiShiHolderWeight.Text = dRes.ToString("0.000")+"kg";
                        XiShiListening = false;
                        return;
                    }
                    else
                    {
                        if (FrmMain.systemconfig.AutoScaleHolderWeight == 1)
                        {
                            dRes = double.Parse(sTemp) - double.Parse(lblXiShiHolderWeight.Text.Replace("kg","").Trim());
                            if (lblXiShiPartWeight.Text != dRes.ToString("0.000"))
                            {
                                lblXiShiPartWeight.Text = dRes.ToString("0.000");
                            }
                        }
                        else
                        {
                            dRes = double.Parse(sTemp);

                            if (lblXiShiPartWeight.Text != sTemp)
                            {
                                lblXiShiPartWeight.Text = sTemp;
                            }

                        }
                    }

                    spPortXiShi_Result = "";
                    FrmMain.productiondata.ActualWeightXiShi = dRes;
                    
                    //Calculate pbBar Percent
                    double x = dRes * 100 / (double.Parse(this.txtMainPartActualWeight.Text));
                        
                    if ((int)x > 100)
                    {
                        this.pbXiShiParts.Max = (int)x;
                    }
                    else
                    {
                        this.pbXiShiParts.Max = 100;
                    }

                    this.pbXiShiParts.Value = (int)x;

                    if (dRes<productiondata.XiShiTargetSPECL*(double.Parse(this.txtMainPartActualWeight.Text)/100))
                    {
                        pbXiShiParts.BarColorSolid = Color.Yellow;
                    }
                    else if (dRes >= productiondata.XiShiTargetSPECL * (double.Parse(this.txtMainPartActualWeight.Text) / 100) && dRes <= productiondata.XiShiTargetSPECU * (double.Parse(this.txtMainPartActualWeight.Text) / 100))
                    {
                        pbXiShiParts.BarColorSolid = Color.Green;
                    }
                    else
                    {
                        pbXiShiParts.BarColorSolid = Color.Red;
                    }

                    FrmMain.productiondata.XiShiActualRate=dRes * 100 / (double.Parse(this.txtMainPartActualWeight.Text));
                }
            }));
            XiShiListening = false;
        }
        
        #endregion

        #endregion

        #region Events
        private void tsbAbout_Click(object sender, EventArgs e)
        {
            FrmAbout frmabout = new FrmAbout();
            frmabout.ShowDialog();
        }

        private void SecurityRightRefresh()
        {
            if (FrmMain.userinfo.SecurityRight=="管理员")
            {
                tsbUserMainten.Visible = true;
                tsbProductionMainten.Visible = true;
                tsbBOMMainten.Visible = true;
                tsbOptionSettings.Visible = true;

                smConfig.Visible = true;
            }
            else
            {
                tsbUserMainten.Visible = false;
                tsbProductionMainten.Visible = false;
                tsbBOMMainten.Visible = false;
                tsbOptionSettings.Visible = false;
                smConfig.Visible = false;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            InitSystemConfigurationInfo();
            InitMainUi();
            InitProductionData();

            if (ReadSystemConfigurationInfo(ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FillProductionLine(ref sErrorMessage);
            
            //Check Register Status
            if (clsApp.CheckRegsiterStatus(ref RegisterStatus,ref RegCode, ref FrmMain.sCustomerInfo,ref sErrorMessage) == false)
            {
                MessageBox.Show("请尽快完成产品注册,未注册产品不能打印标签!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }

            //Application.DoEvents();
            
            //OnFormEntered(this, null);
        }

        private void tsbChangePSW_Click(object sender, EventArgs e)
        {
            FrmChangePSW frmcpsw = new FrmChangePSW();
            frmcpsw.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmOption frmoption = new FrmOption();
            frmoption.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmAppendUser frmau = new FrmAppendUser();
            frmau.ShowDialog();
        }

        private void tsbProductionMainten_Click(object sender, EventArgs e)
        {
            FrmProductionLine frmproduction = new FrmProductionLine();
            frmproduction.ShowDialog();
        }

        private void tsbBOMMainten_Click(object sender, EventArgs e)
        {
            FrmBOM frmpartnumber = new FrmBOM();
            frmpartnumber.ShowDialog();
        }

        private void msChangePSW_Click(object sender, EventArgs e)
        {
            FrmChangePSW frmcpsw = new FrmChangePSW();
            frmcpsw.ShowDialog();
        }

        private void smUserMainten_Click(object sender, EventArgs e)
        {
            FrmAppendUser frmau = new FrmAppendUser();
            frmau.ShowDialog();
        }

        private void msProductionSettings_Click(object sender, EventArgs e)
        {
            FrmProductionLine frmproduction = new FrmProductionLine();
            frmproduction.ShowDialog();
        }

        private void msBOMMainten_Click(object sender, EventArgs e)
        {
            FrmBOM frmpartnumber = new FrmBOM();
            frmpartnumber.ShowDialog();
        }

        private void msSystemSettings_Click(object sender, EventArgs e)
        {
            FrmOption frmoption = new FrmOption();
            frmoption.ShowDialog();
        }

        private void msOilPaintType_Click(object sender, EventArgs e)
        {
            FrmOilPaint frmop = new FrmOilPaint();
            frmop.ShowDialog();
        }

        private void msCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer frmcustomer = new FrmCustomer();
            frmcustomer.ShowDialog();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FrmMain.BOMID = "";
            FrmBOMInfoQuery frmbiq = new FrmBOMInfoQuery();
            frmbiq.ShowDialog();

            //check BOMID
            if (FrmMain.BOMID.Length > 0)
            {
                //Get Data
                string sql = "SELECT [CustomerName] as '客户名称',[ProductName] as '品名/机种',[Supplier] as '厂商',[OilPlaintType] as '喷漆类型',[OilSpeedU] as '流速上限',[OilSpeedL] as '流速下限',[GuHuaPercent] as '固化剂比例',[XiShiUpPercent] as '稀释剂比例(上限)',[XiShiLowPercent] as '稀释剂比例(下限)',[BOMID]  FROM BOMInfo where BOMID='" + FrmMain.BOMID + "' ORDER BY '客户名称'";
                
                RefreshandShowMainData();
            }
        }

        private void msRS232_Click(object sender, EventArgs e)
        {
            FrmScaleDebug frmsd = new FrmScaleDebug();
            frmsd.ShowDialog();
        }

        private bool GuHuaPartStart()
        {
            string sErrorMessage = "";

            if (FrmMain.BOMID.Length <= 0)
            {
                MessageBox.Show("请选择需要调配的机种型号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            FrmGuHuaPartInput frmgpi = new FrmGuHuaPartInput();
            frmgpi.ShowDialog();

            if (frmgpi.DialogResult != DialogResult.Yes)
            {
                return false;
            }

            received_count_GuHua = 0;
            builderGuHua = new StringBuilder();

            if (ComCloseGuHua(spPortGuHua, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ComINIT_GuHua(ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Refresh Data

            //lblGuHuaPartVendor.Text = productiondata.VendorCodeGuHua;
            lblGuHuaPartNumber.Text = productiondata.PartNumberGuHua;
            lblGuHuaLotNum.Text = productiondata.LotNumberGuHua;  
            pbGuHuaParts.Max = 105;
            pbGuHuaParts.Value = 0;
            lblGuHuaPartWeight.Text = "0";

            FrmMain.productiondata.GetGuHuaHolderWeight = false;
            FrmMain.productiondata.Status = 2;//Start working the GuHua Parts

            if (ComOpenGuHua(ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuHuaPartStart_Click(object sender, EventArgs e)
        {
            GuHuaPartStart();
        }

        private bool MainPartCheck()
        {
            string sErrorMessage = "";
            InitMainUi();
            ClearProductionData();

            MainListening = false;
            GuHuaListening = false;
            XiShiListening = false;

            if (cmbShift.Text.Length <= 0)
            {
                MessageBox.Show("请输入班次信息!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbProductionLine.Text.Length <= 0)
            {
                MessageBox.Show("请输入产线信息!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmbProductionLine.Focus();
                return false;
            }

            if (FrmMain.BOMID.Length <= 0)
            {
                MessageBox.Show("请选择需要调配的机种型号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPartNumber.Text.Length <= 0)
            {
                MessageBox.Show("请输入计划配漆的主剂重量!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnQuery.Focus();
                return false;
            }

            if (txtMainPartTargetWeight.Text.Length <= 0)
            {
                MessageBox.Show("请输入计划配漆的主剂重量!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMainPartTargetWeight.SelectAll();
                this.txtMainPartTargetWeight.SelectionLength = this.txtMainPartTargetWeight.Text.Length;
                this.txtMainPartTargetWeight.Focus();
                return false;
            }

            if (clsApp.IsDouble(this.txtMainPartTargetWeight.Text, ref sErrorMessage) == false)
            {
                MessageBox.Show("输入计划配漆的主剂重量格式不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtMainPartTargetWeight.SelectAll();
                this.txtMainPartTargetWeight.SelectionLength = this.txtMainPartTargetWeight.Text.Length;
                this.txtMainPartTargetWeight.Focus();
                return false;
            }

            FrmMainPartInputSecondSolution frmmpi = new FrmMainPartInputSecondSolution();
            frmmpi.ShowDialog();

            if (frmmpi.DialogResult != DialogResult.Yes)
            {
                return false;
            }

            return true;
        }
        
        private bool MainPartStart()
        {
            string sErrorMessage = "";
            //InitMainUi();
            //ClearProductionData();

            //MainListening = false;
            //GuHuaListening = false;
            //XiShiListening = false;

            //if (cmbShift.Text.Length <= 0)
            //{
            //    MessageBox.Show("请输入班次信息!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            //if (cmbProductionLine.Text.Length <= 0)
            //{
            //    MessageBox.Show("请输入产线信息!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.cmbProductionLine.Focus();
            //    return false;
            //}

            //if (FrmMain.BOMID.Length <= 0)
            //{
            //    MessageBox.Show("请选择需要调配的机种型号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            //if (txtPartNumber.Text.Length <= 0)
            //{
            //    MessageBox.Show("请输入计划配漆的主剂重量!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    btnQuery.Focus();
            //    return false;
            //}

            //if (txtMainPartTargetWeight.Text.Length <= 0)
            //{
            //    MessageBox.Show("请输入计划配漆的主剂重量!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.txtMainPartTargetWeight.SelectAll();
            //    this.txtMainPartTargetWeight.SelectionLength = this.txtMainPartTargetWeight.Text.Length;
            //    this.txtMainPartTargetWeight.Focus();
            //    return false;
            //}

            //if (clsApp.IsDouble(this.txtMainPartTargetWeight.Text, ref sErrorMessage) == false)
            //{
            //    MessageBox.Show("输入计划配漆的主剂重量格式不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.txtMainPartTargetWeight.SelectAll();
            //    this.txtMainPartTargetWeight.SelectionLength = this.txtMainPartTargetWeight.Text.Length;
            //    this.txtMainPartTargetWeight.Focus();
            //    return false;
            //}

            //FrmMainPartInputSecondSolution frmmpi = new FrmMainPartInputSecondSolution();
            //frmmpi.ShowDialog();

            //if (frmmpi.DialogResult != DialogResult.Yes)
            //{
            //    return false;
            //}

            //***********************************************************************//

            //Start Serial Port to get the transtion data
            received_count_Main = 0;
            builderMain = new StringBuilder();
            if (ComCloseMain(spPortMain, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ComINIT_Main(ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Refresh Data
            txtMainPartTargetWeight.Enabled = false;

            FrmMain.productiondata.TargetWeightMain = double.Parse(this.txtMainPartTargetWeight.Text.ToString());

            //lblMainPartVendor.Text = productiondata.VendorCodeMain;
            lblMainPartNumber.Text = productiondata.PartNumberMain;
            lblMainPartsLotNumber.Text = productiondata.LotNumberMain;

            pbMainParts.Max = 100;
            pbMainParts.Value = 0;
            lblMainPartWeight.Text = "0";

            if (ComOpenMain(ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

              return true;

            //***********************************************************************//
        }

        //private void btnMainPartStart_Click(object sender, EventArgs e)
        //{
        //    MainPartStart();
        //}

        private bool XiShiPartStart()
        {
            string sErrorMessage = "";

            if (FrmMain.BOMID.Length <= 0)
            {
                MessageBox.Show("请选择需要调配的机种型号!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            FrmXiShiPartInput frmxsp = new FrmXiShiPartInput();
            frmxsp.ShowDialog();

            if (frmxsp.DialogResult != DialogResult.Yes)
            {
                return false;
            }

            //Start working on the XiShi 
            received_count_XiShi = 0;
            builderXiShi = new StringBuilder();

            if (ComCloseXiShi(spPortXiShi, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ComINIT_XiShi(ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Refresh Data
            //lblXiShiVendor.Text = productiondata.VendorCodeXiShi;
            lblXiSHiPartNumber.Text = productiondata.PartNumberXiShi;
            lblXiShiLot.Text = productiondata.LotNumberXiShi;

            pbXiShiParts.Max = 100;
            pbXiShiParts.Value = 0;
            lblXiShiPartWeight.Text = "0";

            FrmMain.productiondata.GetXiShiHolderWeight = false;
            FrmMain.productiondata.Status = 4;

            if (ComOpenXiShi(ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnXiShiPartStart_Click(object sender, EventArgs e)
        {
            XiShiPartStart();
        }

        private bool MainPartStop()
        {
            string sErrorMessage = "";
            string sql = "";

            if (lblMainPartWeight.Text.Length<0)
            {
                MessageBox.Show("请先配原油,未检测到原油的重量,不能结束!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(double.Parse(lblMainPartWeight.Text)<=0)
            {
                MessageBox.Show("请先配原油,未检测到原油的重量,不能结束!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Get NewID
            if (GetNewID(ref FrmMain.productiondata.TaskID, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Append Data
            FrmMain.productiondata.Status = 1;
            sql = "Insert into [SprayLacquerManagement].[dbo].[Task]([TaskID],[BOMID],[ShiftName],[LineName],[PartNumber],[MainPartVendor],[MainPartNumber],[MainLotNumber],[TargetMainPartWeight],[ActualMainPartWeight],[GuHuaWeightSPECL],[GuHuaWeightSPECU],[XiShiWeightSPECL],[XiShiWeightSPECU],[Status],[GuHuaRangeBase],[Operator],[MainHolderWeight],[SysDateTime])";
            sql = sql + " values('" + FrmMain.productiondata.TaskID + "','" + FrmMain.productiondata.BOMID + "','" + FrmMain.productiondata.ShiftName.ToString() + "','" + FrmMain.productiondata.LineName + "','" + FrmMain.productiondata.PartNumber + "','" + FrmMain.productiondata.VendorCodeMain + "','" + FrmMain.productiondata.PartNumberMain + "','" + FrmMain.productiondata.LotNumberMain + "', ";
            sql = sql + " " + FrmMain.productiondata.TargetWeightMain.ToString() + "," + FrmMain.productiondata.ActualWeightMain.ToString() + "," + FrmMain.productiondata.GuHuaWeightSPECL.ToString() + "," + FrmMain.productiondata.GuHuaWeightSPECU + "," + FrmMain.productiondata.XiShiWeightSPECL.ToString() + "," + FrmMain.productiondata.XiShiWeightSPECU.ToString() + ",";
            sql = sql + " " + FrmMain.productiondata.GuHuaRangeBase.ToString() + "," + FrmMain.productiondata.Status.ToString() + ",'" + userinfo.UserName + "'," + FrmMain.productiondata.HolderWeightMain.ToString() + ",getdate() )";

            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmMain.productiondata.Status = 0;
                return false;
            }
            else
            {
               return ComCloseMain(spPortMain, ref sErrorMessage);
            }
        }

        private bool GuHuaPartStop()
        {
            string sErrorMessage = "";
            string sql = "";

            double dGuHuaRes = double.Parse(lblGuHuaPartWeight.Text);
            double dGhHuaRate = productiondata.GuHUaTargetRate / 100;
            double dMainRes = double.Parse(lblMainPartWeight.Text);

            // + (dMainRes * 1000 * dGhHuaRate * 0.97).ToString() + "~" + (dMainRes * 1000 * dGhHuaRate * 1.04).ToString()
            if (dGuHuaRes < dMainRes * 1000 * dGhHuaRate * 0.97 || dGuHuaRes > dMainRes * 1000 * dGhHuaRate * 1.04)
            {
                MessageBox.Show("固化剂比例不符合标准值，请调整后再结束!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            //Append GuHua Data
            FrmMain.productiondata.Status = 3;
            sql = "Update [SprayLacquerManagement].[dbo].[Task] Set [GuHuaPartVendor]='" + productiondata.VendorCodeGuHua + "',[GuHuaPartNumber]='" + productiondata.PartNumberGuHua + "',[GuHuaLotNumber]='" + productiondata.LotNumberGuHua + "', ";
            sql = sql + " [GuHuaWeightSPECL]=" + productiondata.GuHuaWeightSPECL.ToString() + ",[GuHuaWeightSPECU]=" + productiondata.GuHuaWeightSPECU.ToString() + ",[GuHuaActualWeight]=" + productiondata.ActualWeightGuHua.ToString() + " , ";
            sql = sql + " [GuHuaRate]=" + productiondata.GuHuaActualRate.ToString() + ",[GuHuaHolderWeight]=" + productiondata.HolderWeightGuHua.ToString() + ",[GuHuaRangeBase]=" + productiondata.GuHuaRangeBase.ToString() + ",[Status]=" + productiondata.Status + "  where [TaskID]='" + productiondata.TaskID + "'  and [BOMID]='" + productiondata.BOMID + "' ";

            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmMain.productiondata.Status = 2;
                return false;
            }
            else
            {
                return ComCloseGuHua(spPortGuHua, ref sErrorMessage);
            }
        }

        private bool XiShiPartStop()
        {
            string sErrorMessage = "";
            string sql = "";
            bool bGuHuaRateIssue = false;
            bool bXiSHiRateIssue = false;
            double dGuHuaRes;
            double dGhHuaRate;
            double dMainRes;
            double dXiShiRes;

            //Check Rate

            if(productiondata.GuHUaTargetRate!=0)
            { 
                dGuHuaRes = double.Parse(lblGuHuaPartWeight.Text);
                dGhHuaRate = productiondata.GuHUaTargetRate / 100;
                dMainRes = double.Parse(lblMainPartWeight.Text);
                dXiShiRes = double.Parse(lblXiShiPartWeight.Text);
            }
            else
            {
                dGuHuaRes = 0;
                dGhHuaRate = 0;
                dMainRes = double.Parse(lblMainPartWeight.Text);
                dXiShiRes = double.Parse(lblXiShiPartWeight.Text);
            }

            //if (dGuHuaRes < dMainRes * 1000 * dGhHuaRate * 0.97 || dGuHuaRes > dMainRes * 1000 * dGhHuaRate * 1.04)
            //{
            //    bGuHuaRateIssue = true;
            //}

            if ((dXiShiRes <= productiondata.XiShiTargetSPECL * dMainRes / 100) || (dXiShiRes >= productiondata.XiShiTargetSPECU * dMainRes / 100))
            {
                bXiSHiRateIssue = true;
            }

            if (bXiSHiRateIssue == true)
            {
                MessageBox.Show("稀释剂比例不符合标准值，请调整后再结束!", "警告",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            FrmMain.productiondata.Status = 5;
            sql = "Update [SprayLacquerManagement].[dbo].[Task] Set [XiShiVendor]='" + productiondata.VendorCodeXiShi + "',[XiShiPartNumber]='" + productiondata.PartNumberXiShi + "',[XiShiLotNumber]='" + productiondata.LotNumberXiShi + "', ";
            sql = sql + " [XiShiWeightSPECL]=" + productiondata.XiShiWeightSPECL.ToString() + ",[XiShiWeightSPECU]=" + productiondata.XiShiWeightSPECU.ToString() + ",[XiShiActualWeight]=" + productiondata.ActualWeightXiShi.ToString() + ", ";
            sql = sql + " [XiShiRate]=" + productiondata.XiShiActualRate.ToString() + ",[XiShiHolderWeight]=" + productiondata.HolderWeightXiShi.ToString() + ", [Status]=" + productiondata.Status + " ";
            sql = sql + "  where [TaskID]='" + productiondata.TaskID + "'  and [BOMID]='" + productiondata.BOMID + "' ";

            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == false)
            {
                MessageBox.Show(sErrorMessage, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmMain.productiondata.Status = 4;
                return false;
            }
            else
            {
                return ComCloseXiShi(spPortXiShi, ref sErrorMessage);
            }
        }

        private void btnXiShiPartStop_Click(object sender, EventArgs e)
        {
            XiShiPartStop();
        }
        
        private void tsSpeedInput_Click(object sender, EventArgs e)
        {
            FrmSpeedInput frmsi = new FrmSpeedInput();
            frmsi.ShowDialog();
        }

        private int GetJiaoBanSeconds()
        {
            int nSeconds = 0;
            nSeconds = 180;
            Random ro=new Random();
            nSeconds =nSeconds+ ro.Next(0, 40);
            return nSeconds;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sql = "";
            string sErrorMessage = "";

            FrmSpeedInput frmspeedinput = new FrmSpeedInput();
            frmspeedinput.ShowDialog();
            
            if (frmspeedinput.DialogResult != DialogResult.Yes)
            {
                FrmMain.productiondata.Status = 6;
                return;
            }

            //Continute Save Data
            productiondata.ActualDelaySeconds = GetJiaoBanSeconds();

            FrmMain.productiondata.Status = 7;
            sql = "Update [SprayLacquerManagement].[dbo].[Task] Set [Status]=" + FrmMain.productiondata.Status.ToString() + ",[ActualSpeed]=" + productiondata.ActualSpeed + ",[ActualDelaySeconds]=" + productiondata.ActualDelaySeconds.ToString();
            sql= sql + "  where [TaskID]='" + productiondata.TaskID + "'  and [BOMID]='" + productiondata.BOMID + "' ";

            if (clsApp.ExecuteSQL(sql, clsApp.ConnectString, ref sErrorMessage) == false)
            {
                FrmMain.productiondata.Status = 6;
                return;
            }
            else
            {
                //Refresh Data

                //Print Label
                if (FrmMain.RegisterStatus == false)
                {
                    MessageBox.Show("您没有注册本软件，不能打印标签!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Print(ref sErrorMessage);
                }
                //Release Button
                btnSubmit.Visible = false;
                btnMainPart.Enabled = true;
                btnGuHua.Enabled = false;
                btnXiShi.Enabled = false;
                txtMainPartTargetWeight.Enabled = true;
            }
        }
        
        private void Print(ref string sErrorMessage)
        {
            //string sLabelPath = @"C:\E437908\8-PP\苏州海岸线\苏州铂汉\苏州铂汉调漆工艺管理系统\Software\CurrentSoftware\苏州铂汉调漆工艺管理系统\苏州铂汉调漆工艺管理系统\bin\Debug\Template.BTW";
            //string sPrintPath = "ZDesigner GT800 (ZPL)";
            clsApp.PrintLabelInit(FrmMain.systemconfig.LabelTemplatePath, FrmMain.systemconfig.PrinterPath, ref sErrorMessage);

            clsApp.AddPrintVariable("Line", productiondata.LineName.ToString());
            clsApp.AddPrintVariable("YuanYouPartNumber", FrmMain.productiondata.PartNumberMain);
            clsApp.AddPrintVariable("GuHuaPartNumber", productiondata.PartNumberGuHua);
            clsApp.AddPrintVariable("XiShiPartNumber", productiondata.PartNumberXiShi);
            clsApp.AddPrintVariable("Speed", productiondata.ActualSpeed.ToString());
            clsApp.AddPrintVariable("PartNumber", productiondata.PartNumber.ToString());

            clsApp.AddPrintVariable("Operator", FrmMain.userinfo.UserName);
            clsApp.AddPrintVariable("TiaoQiDT", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            clsApp.AddPrintVariable("YouXiaoDT", System.DateTime.Now.AddHours(productiondata.ValidHours).ToString("yyyy-MM-dd HH:mm"));

            clsIniFile clsif = new clsIniFile(clsApp.filepath);
            clsif.WriteInifile("Printer", "Line", productiondata.LineName.ToString());
            clsif.WriteInifile("Printer", "PartNumber", FrmMain.productiondata.PartNumber);
            clsif.WriteInifile("Printer", "ValidHours", FrmMain.productiondata.ValidHours.ToString());
            
            clsif.WriteInifile("Printer", "YuanYou", FrmMain.productiondata.PartNumberMain);
            clsif.WriteInifile("Printer", "GuHua", productiondata.PartNumberGuHua);
            clsif.WriteInifile("Printer", "XiShi", productiondata.PartNumberXiShi);
            clsif.WriteInifile("Printer", "DateTime", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            clsif.WriteInifile("Printer", "ValidDateTime", System.DateTime.Now.AddHours(productiondata.ValidHours).ToString("yyyy-MM-dd HH:mm"));
            clsif.WriteInifile("Printer", "Speed", productiondata.ActualSpeed.ToString());
            clsif.WriteInifile("Printer", "Operator", FrmMain.userinfo.UserName);
            
            clsApp.Print(ref sErrorMessage);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmTaskQuery frmtq = new FrmTaskQuery();
            frmtq.ShowDialog();
        }
        
        private void msDataExport_Click(object sender, EventArgs e)
        {
            FrmTaskQuery frmtq = new FrmTaskQuery();
            frmtq.ShowDialog();
        }
        
        private void btnLoading_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void txtSupplier_EnabledChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).ForeColor = Color.Black;
        }

        private void msPrint_Click(object sender, EventArgs e)
        {
            FrmPrinter frmp = new FrmPrinter();
            frmp.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmRegister frmr = new FrmRegister();
            frmr.ShowDialog();
        }

        private void btnMainPart_Click(object sender, EventArgs e)
        {
            if (btnMainPart.Text == "开始")
            {
                if (MainPartCheck() == true)
                {
                    btnMainPart.Text = "调漆开始";
                    btnMainCard.Enabled = true;
                    btnStopMain.Enabled = true;

                    cmbShift.Enabled = false;
                    cmbProductionLine.Enabled = false;
                    txtPartNumber.Enabled = false;
                    txtSupplier.Enabled = false;
                    lblPaintType.Enabled = false;
                    btnQuery.Enabled = false;
                }
            }
            else
            {
                if (btnMainPart.Text == "调漆开始")
                {
                    if(MainPartStart() == true)
                    {
                        btnMainPart.Text = "结束";
                        btnMainCard.Enabled = false;
                    }
                }
                else
                {
                    if (MainPartStop() == true)
                    {
                        btnMainPart.Text = "开始";
                        btnMainPart.Enabled = false;
                        btnStopMain.Enabled = false;

                        if (productiondata.GuHUaTargetRate != 0)
                        {
                            btnGuHua.Enabled = true;
                            btnStopGuhua.Enabled = true;
                        }
                        else
                        {
                            FrmMain.productiondata.HolderWeightGuHua = 0;
                            FrmMain.productiondata.ActualWeightGuHua = 0;
                            lblGuHuaHolderWeight.Text = "0 g";
                            lblGuHuaPartWeight.Text = "0";
                            FrmMain.productiondata.GuHuaActualRate = 0;
                            btnXiShi.Enabled = true;
                            btnStopXishi.Enabled = true;
                        }
                    }
                }
            }

        }

        private void btnGuHua_Click(object sender, EventArgs e)
        {
            if (btnGuHua.Text == "开始")
            {

                if(GuHuaPartStart()==true)
                {
                    btnGuHua.Text = "结束";
                }
            }
            else
            {
                if(GuHuaPartStop()==true)
                {
                    btnGuHua.Text = "开始";
                    btnGuHua.Enabled = false;
                    btnStopGuhua.Enabled = false;
                    btnStopXishi.Enabled = true;
                    btnXiShi.Enabled = true;
                }
                
            }
        }

        private void btnXiShi_Click(object sender, EventArgs e)
        {
            if (btnXiShi.Text == "开始")
            {
                if(XiShiPartStart()==true)
                {
                    btnXiShi.Text = "结束";
                }
            }
            else
            {
                if(XiShiPartStop()==true)
                {
                    btnXiShi.Text = "开始";
                    btnXiShi.Enabled = false;
                    btnSubmit.Visible = true;

                }
            }
        }

        private void txtMainPartTargetWeight_KeyDown(object sender, KeyEventArgs e)
        {
            string sErrorMessage = "";

            if(e.KeyValue==13)
            {
                if (txtMainPartTargetWeight.Text.Length <= 0)
                {
                    MessageBox.Show("请输入计划配漆的主剂重量!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtMainPartTargetWeight.SelectAll();
                    this.txtMainPartTargetWeight.SelectionLength = this.txtMainPartTargetWeight.Text.Length;
                    this.txtMainPartTargetWeight.Focus();
                    return;
                }

                if (clsApp.IsDouble(this.txtMainPartTargetWeight.Text, ref sErrorMessage) == false)
                {
                    MessageBox.Show("输入计划配漆的主剂重量格式不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtMainPartTargetWeight.SelectAll();
                    this.txtMainPartTargetWeight.SelectionLength = this.txtMainPartTargetWeight.Text.Length;
                    this.txtMainPartTargetWeight.Focus();
                    return;
                }

                btnMainPart.Focus();
            }
        }

        private void FrmMain_Leave(object sender, EventArgs e)
        {
            string sErrorMessage = "";
            ComCloseMain(spPortMain, ref sErrorMessage);
            ComCloseGuHua(spPortGuHua, ref sErrorMessage);
            ComCloseXiShi(spPortXiShi, ref sErrorMessage);
        }

        private void bOM上传ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBOMUpload frmbomupload = new FrmBOMUpload();
            frmbomupload.ShowDialog();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Size = new Size(w, h);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = null;
            if (ComCloseMain(spPortMain, ref msg))
            {
            }

            btnMainPart.Text = "开始";

            InitMainUi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = null;
            if (ComCloseGuHua(spPortGuHua, ref msg) == true)
            {
            }

            btnGuHua.Text = "开始";

            ClearProductionData();
            InitMainUi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg = null;
            if (ComCloseGuHua(spPortXiShi, ref msg) == true)
            {

            }
            btnXiShi.Text = "开始";
            ClearProductionData();
            InitMainUi();
        }

        //打印标识卡点击事件
        private void btnMainCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请将原油放上电子秤称重", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnMainCard.Enabled = false;
            FrmMain.productiondata.YouQiType = "原油";
            FrmBiaoShiKa BiaoShiKa = new FrmBiaoShiKa();
            BiaoShiKa.ShowDialog();

        }
    }
}
