using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Principal;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Reflection;

namespace 调漆工艺管理系统
{
    public class clsApp
    {
        //*****************************************Change Log**********************************************
        //******Init By Weiguo 2012/04/23

        //Version A1    Weiguo  2017/1/10
        //Version A9    Weiguo  2017/1/18
        //Version A12   Weiguo  2017/1/20

        //Version A12   Weiguo  2017/1/20
        //Version B     Weiguo  2017/1/22
        //Version C1    Weiguo  2017/1/24
        //Version D1    Weiguo  2017/2/15  Add License Regsiter function and Label Print Function

        //Version E     Weiguo  2017/2/28
        //Version F     Weiguo  2017/04/05

        //Version G     Weiguo  2017/5/14   update for the BOM uploading and label format

        //**************************************************************************************************
        public static LabelPrintCSharp.clsLabelPrint clsxx = new LabelPrintCSharp.clsLabelPrint();
                
        public static string sVersion = "G";
        public static string sAppName = "调漆工艺管理系统";
        public static string sConnectionString = "";
        public static string filepath = System.IO.Directory.GetCurrentDirectory() + @"\option.ini";

        private static string connectString = new DbConfigReader().GenerateConnectionString();

        /// <summary>
        /// 获取DB连接字符串
        /// </summary>
        public static string ConnectString
        {
            get
            {
                return connectString;
            }
            set
            {
                connectString = value;
            }
        }

        public struct UserInfo
        {
            public string UserName;
            public string Password;
            public string SecurityRight;//Admin,Normal User;
        }

        public struct ComPortSettings_t
        {
            public Int32 PortNum;
            public Int32 BaudRate;
            public string Parity;
            public Int32 DataBits;
            public Int32 StopBits;
        }

        public struct SystemConfiguration
        {
            //User Info
            public string ServerName;
            public string UserID;
            public string Password;

            //Scale Main
            public ComPortSettings_t ScaleMainPortSettings;
            public ComPortSettings_t ScaleGuHuaPortSettings;
            public ComPortSettings_t ScaleXiShiPortSettings;
            
            //Printer
            public string PrinterPath;
            public string LabelTemplatePath;

            //GuHua
            public int GuHuaRange;

            public int AutoScaleHolderWeight;
        }

        public struct MainCodeRuleStruct
        {
            public string MainCodeRule;
            public string MainNumRule;
        }

        public struct GuhuaCodeRuleStruct
        {
            public string MainCodeRule;
            public string MainNumRule;
        }

        public struct XishiCodeRuleStruct
        {
            public string MainCodeRule;
            public string MainNumRule;
        }

        public static string GetAssemblyTitle()
        {
            // Get Current Assembly
            Assembly asm = Assembly.GetExecutingAssembly();

            // Get Title
            AssemblyTitleAttribute titleAtt = (AssemblyTitleAttribute)Attribute.GetCustomAttribute(asm, typeof(AssemblyTitleAttribute));
            return titleAtt.Title.ToString();

        }
        
        public static bool CheckRegsiterStatus(ref bool bRegstatus,ref string sRegCode,ref string sPCCode,ref string sErrorMessage)
        {
            string sCustomerInfo = clsComputerInfo.GetCustomerInfo();

            System.Data.DataSet dsTemp = new DataSet();
            string sql = "select * from [SprayLacquerManagement].[dbo].[Register] where [UserInfo]='" + sCustomerInfo + "' ";
            if (clsApp.GetDataSet(sql, clsApp.ConnectString, ref dsTemp, ref sErrorMessage) == true)
            {
                if (dsTemp.Tables[0].Rows.Count > 0)
                {
                    bRegstatus = true;
                    sRegCode = dsTemp.Tables[0].Rows[0]["SerialNumber"].ToString();
                    return true;
                }
                else
                {
                    bRegstatus = false;
                    return true;
                }
            }
            else
            {
                bRegstatus = false;
                return false;
            }
        }

        #region Data Function

        #region ExecuteSQl
        /// <summary>
        /// Execute Sql
        /// </summary>
        /// <param name="sSql">Execute SQL</param>
        /// <param name="sErrorMessage">Error Message</param>
        /// <returns></returns>
        public static bool ExecuteSQL(string sSql, string sConnectionString, ref string sErrorMessage)
        {
            System.Data.SqlClient.SqlConnection SqlCon = new SqlConnection();
            System.Data.SqlClient.SqlTransaction SqlTra;
            System.Data.SqlClient.SqlCommand SqlCom = new SqlCommand();

            SqlCon.ConnectionString = sConnectionString;
            try
            {
                if (SqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCon.Close();
                }

                //Connect EKanban
                SqlCon.Open();
            }
            catch (Exception ex)
            {
                //Connection Exception
                sErrorMessage = ex.Message.ToString();
                return false;
            }

            //Execute SQL
            try
            {
                SqlTra = SqlCon.BeginTransaction();
                SqlCom.Connection = SqlCon;
                SqlCom.Transaction = SqlTra;
                SqlCom.CommandText = sSql;
                SqlCom.ExecuteNonQuery();

                SqlTra.Commit();
                SqlCon.Close();
                SqlCon.Dispose();
                SqlCon = null;
                SqlCom = null;
                return true;
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public static bool ExecuteSQL(string sSql1, string sSql2, string sConnectionString, ref string sErrorMessage)
        {
            System.Data.SqlClient.SqlConnection SqlCon = new SqlConnection();
            System.Data.SqlClient.SqlTransaction SqlTra;
            System.Data.SqlClient.SqlCommand SqlCom = new SqlCommand();

            SqlCon.ConnectionString = sConnectionString;
            try
            {
                if (SqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCon.Close();
                }

                //Connect EKanban
                SqlCon.Open();
            }
            catch (Exception ex)
            {
                //Connection Exception
                sErrorMessage = ex.Message.ToString();
                return false;
            }

            //Execute SQL
            try
            {
                SqlTra = SqlCon.BeginTransaction();
                SqlCom.Connection = SqlCon;
                SqlCom.Transaction = SqlTra;
                SqlCom.CommandText = sSql1;
                SqlCom.ExecuteNonQuery();
                SqlCom.CommandText = sSql2;
                SqlCom.ExecuteNonQuery();
                SqlTra.Commit();
                SqlCon.Close();
                SqlCon.Dispose();
                SqlCon = null;
                SqlCom = null;
                return true;
            }
            catch (Exception ex)
            {
                sErrorMessage = sSql1 + "  " + sSql2 + ex.Message.ToString();
                return false;
            }
        }
        #endregion

        #region Get Data Set
        public static bool GetDataSet(string sSql, string sConnectionString, ref System.Data.DataSet dstemp, ref string sErrorMessage)
        {
            System.Data.SqlClient.SqlConnection SqlCon = new SqlConnection();
            System.Data.SqlClient.SqlCommand SqlCom = new SqlCommand();
            System.Data.SqlClient.SqlDataAdapter sdtemp;
            dstemp.Tables.Clear();
            sErrorMessage = "";
            SqlCon.ConnectionString = sConnectionString;
            try
            {
                if (SqlCon.State == System.Data.ConnectionState.Open)
                {
                    SqlCon.Close();
                }

                //Connect QCDCS
                SqlCon.Open();
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }

            try
            {
                sdtemp = new SqlDataAdapter(sSql, SqlCon);
                sdtemp.Fill(dstemp);
                SqlCon.Close();
                SqlCon.Dispose();
                SqlCon = null;
                SqlCom = null;
                return true;
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }
        #endregion

        #endregion

        #region File Function
        public static bool OpenExcelFile(ref string sFileName, ref string sErrorMessage)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog openfiledialog = new OpenFileDialog();
                openfiledialog.Filter = "All Files|*.*";

                //openfiledialog.Filter = "BOM Files (*.xls)|*.xls|" + "All Files|*.*";
                openfiledialog.ShowDialog();
                sFileName = openfiledialog.FileName.ToString();

                if (sFileName.Length > 0)
                {
                    sErrorMessage = "";
                    return true;
                }
                else if (sFileName.Length == 0)
                {
                    sErrorMessage = "Please Select Excel File!";
                    return false;
                }
                else
                {
                    sErrorMessage = "File Format Error!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public static bool OpenBTWFile(ref string sFileName, ref string sErrorMessage)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog openfiledialog = new OpenFileDialog();
                //openfiledialog.Filter = "All Files|*.*";

                openfiledialog.Filter = "Flash Files (*.btw)|*.btw|" + "All Files|*.*";
                openfiledialog.ShowDialog();
                sFileName = openfiledialog.FileName.ToString();

                if (sFileName.Length > 0)
                {
                    sErrorMessage = "";
                    return true;
                }
                else if (sFileName.Length == 0)
                {
                    sErrorMessage = "Please Select BTW File!";
                    return false;
                }
                else
                {
                    sErrorMessage = "File Format Error!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public static void DataGridViewToExcel(DataGridView dgv)   
        {   
            SaveFileDialog dlg = new SaveFileDialog();   
            dlg.Filter = "Execl files (*.xls)|*.xls";   
            dlg.FilterIndex = 0;   
            dlg.RestoreDirectory = true;   
            dlg.CreatePrompt = true;   
            dlg.Title = "保存为Excel文件";   
  
            if (dlg.ShowDialog() == DialogResult.OK)   
            {   
                Stream myStream;   
                myStream = dlg.OpenFile();   
                StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));   
                string columnTitle = "";   
                try  
                {   
                    //写入列标题   
                    for (int i = 0; i < dgv.ColumnCount; i++)   
                    {   
                        if (i > 0)   
                        {   
                            columnTitle += "\t";   
                        }   
                        columnTitle += dgv.Columns[i].HeaderText;   
                    }   
                    sw.WriteLine(columnTitle);   
  
                    //写入列内容   
                    for (int j = 0; j < dgv.Rows.Count; j++)   
                    {   
                        string columnValue = "";   
                        for (int k = 0; k < dgv.Columns.Count; k++)   
                        {   
                            if (k > 0)   
                            {   
                                columnValue += "\t";   
                            }   
                            if (dgv.Rows[j].Cells[k].Value == null)   
                                columnValue += "";   
                            else  
                                columnValue += dgv.Rows[j].Cells[k].Value.ToString().Trim();   
                        }   
                        sw.WriteLine(columnValue);   
                    }   
                    sw.Close();   
                    myStream.Close();   
                }   
                catch (Exception e)   
                {   
                    MessageBox.Show(e.ToString());   
                }   
                finally  
                {   
                    sw.Close();   
                    myStream.Close();   
                }   
            }   
        }   

        public static bool GenerateSummaryReport(string sqlwhere,bool isShowExcel,string sStart,string sEnd,ref string sErrorMessage)
        {
            string sql = "SELECT [LineName],[ProductName],sum([ActualMainPartWeight]) as Main,sum([GuHuaActualWeight]) as GuHua,sum([XiShiActualWeight]) as XiShi FROM [SprayLacquerManagement].[dbo].[Task],[SprayLacquerManagement].[dbo].[BOMINfo]  where [SprayLacquerManagement].[dbo].[Task].[BOMID]=[SprayLacquerManagement].[dbo].[BOMInfo].[BOMID] and [status]=7 ";
            sql = sql +  sqlwhere + "group by [LineName],[ProductName]";


            string sqlgetline = "select distinct [LineName] as Line FROM [SprayLacquerManagement].[dbo].[Task],[SprayLacquerManagement].[dbo].[BOMINFO]  where [SprayLacquerManagement].[dbo].[BOMINFO].[BOMID]=[SprayLacquerManagement].[dbo].[Task].[BOMID] and [Status]=7 " + sqlwhere;
            string sqlgetPartnumber = "select distinct [ProductName] as PartNumber FROM [SprayLacquerManagement].[dbo].[Task],[SprayLacquerManagement].[dbo].[BOMInfo]  where [SprayLacquerManagement].[dbo].[Task].[BOMID]=[SprayLacquerManagement].[dbo].[BOMINFO].[BOMID] and [Status]=7 " + sqlwhere;
            System.Data.DataSet dsTemp = new DataSet();
            System.Data.DataSet dsLine = new DataSet();
            System.Data.DataSet dsPartNumber = new DataSet();
            
            if (GetDataSet(sql, ConnectString, ref dsTemp, ref sErrorMessage) == false)
            {
                return false;
            }
            if (GetDataSet(sqlgetline, ConnectString, ref dsLine, ref sErrorMessage) == false)
            {
                return false;
            }
            if (GetDataSet(sqlgetPartnumber, ConnectString, ref dsPartNumber, ref sErrorMessage) == false)
            {
                return false;
            }

            if (dsTemp.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("没有调漆数据,无法汇总!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //建立Excel对象      
            Excel.Application excel = new Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = isShowExcel;

            Excel.Workbooks workbooks = excel.Workbooks;
            Excel.Workbook workbook = (Excel.Workbook)workbooks.get_Item(1);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            //生成字段名称      
            Excel.Range range;

            excel.Cells[5, 1] = "生产线别";
            excel.Cells[5, 2] = "油漆类型";

            range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[2, dsLine.Tables[0].Rows.Count + 3]];
            range.ClearContents();
            range.MergeCells = true;
            range.Value = "调漆工艺汇总报表";
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            range = worksheet.Range[worksheet.Cells[3, 1], worksheet.Cells[3, dsLine.Tables[0].Rows.Count + 3]];
            range.ClearContents();
            range.MergeCells = true;
            range.Value = "统计时间：" + sStart + "~" + sEnd ;
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;


            range = worksheet.Range[worksheet.Cells[6 , 1], worksheet.Cells[8 , 1]];
            range.ClearContents();
            range.MergeCells = true;
            range.Value = "合计";
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            excel.Cells[6,2] = "原油";
            excel.Cells[7,2] = "固化剂";
            excel.Cells[8, 2] = "稀释剂";

            System.Data.DataSet dsPartNumSum = new DataSet();
            string sqlpartnumsum = "SELECT sum([ActualMainPartWeight]) as Main,sum([GuHuaActualWeight]) as GuHua,sum([XiShiActualWeight]) as XiShi FROM [SprayLacquerManagement].[dbo].[task],[SprayLacquerManagement].[dbo].[BOMINFO]  where [SprayLacquerManagement].[dbo].[task].[BOMID]=[SprayLacquerManagement].[dbo].[BOMINFO].[BOMID] and [Status]=7 " + sqlwhere;
            if (GetDataSet(sqlpartnumsum, ConnectString, ref dsPartNumSum, ref sErrorMessage) == true)
            {
                excel.Cells[6, dsLine.Tables[0].Rows.Count + 3] = dsPartNumSum.Tables[0].Rows[0]["Main"].ToString();
                excel.Cells[7 , dsLine.Tables[0].Rows.Count + 3] = dsPartNumSum.Tables[0].Rows[0]["GuHua"].ToString();
                excel.Cells[8 , dsLine.Tables[0].Rows.Count + 3] = dsPartNumSum.Tables[0].Rows[0]["XiShi"].ToString();
            }

            for (int i = 1; i <= dsPartNumber.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j <= dsLine.Tables[0].Rows.Count; j++)
                {
                    excel.Cells[3 * i + 6, j + 3] = 0;
                    excel.Cells[3 * i + 7, j + 3] = 0;
                    excel.Cells[3 * i +8, j + 3] = 0;
                }
            }

            for (int i = 1; i <= dsPartNumber.Tables[0].Rows.Count;i++)
            {
                range = worksheet.Range[worksheet.Cells[6+ 3*i, 1], worksheet.Cells[8 + 3*i, 1]];
                range.ClearContents();
                range.MergeCells = true;
                range.Value = dsPartNumber.Tables[0].Rows[i-1]["PartNumber"].ToString();
                range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                range.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                excel.Cells[6 + 3 * i, 2] = "原油";
                excel.Cells[7 + 3 * i, 2] = "固化剂";
                excel.Cells[8+ 3 * i, 2] = "稀释剂";

                string sPartNumber = dsPartNumber.Tables[0].Rows[i-1]["PartNumber"].ToString();
                
                for (int j = 0; j <= dsLine.Tables[0].Rows.Count; j++ )
                { 
                    //Title
                    if (j == dsLine.Tables[0].Rows.Count)
                    {
                        excel.Cells[5, j + 3] = "汇总";

                    }
                    else
                    {
                        //System.Data.DataSet dsPartNumSum = new DataSet();
                        sqlpartnumsum = "SELECT sum([ActualMainPartWeight]) as Main,sum([GuHuaActualWeight]) as GuHua,sum([XiShiActualWeight]) as XiShi FROM [SprayLacquerManagement].[dbo].[task],[SprayLacquerManagement].[dbo].[BOMInfo]  where [SprayLacquerManagement].[dbo].[task].[BOMID]=[SprayLacquerManagement].[dbo].[BOMinfo].[BOMID]  and [Status]=7 " + sqlwhere + " and [ProductName]='" + sPartNumber + "'";
                        if (GetDataSet(sqlpartnumsum, ConnectString, ref dsPartNumSum, ref sErrorMessage) == true)
                        {
                            excel.Cells[6 + 3 * i, dsLine.Tables[0].Rows.Count + 3] = dsPartNumSum.Tables[0].Rows[0]["Main"].ToString();
                            excel.Cells[7 + 3 * i, dsLine.Tables[0].Rows.Count + 3] = dsPartNumSum.Tables[0].Rows[0]["GuHua"].ToString();
                            excel.Cells[8 + 3 * i, dsLine.Tables[0].Rows.Count + 3] = dsPartNumSum.Tables[0].Rows[0]["XiShi"].ToString();
                        }


                        excel.Cells[5, j + 3] = dsLine.Tables[0].Rows[j]["Line"].ToString();
                        string sLine = dsLine.Tables[0].Rows[j]["Line"].ToString();


                        sqlpartnumsum = "SELECT sum([ActualMainPartWeight]) as Main,sum([GuHuaActualWeight]) as GuHua,sum([XiShiActualWeight]) as XiShi  FROM [SprayLacquerManagement].[dbo].[task],[SprayLacquerManagement].[dbo].[BOMINFO]  where [SprayLacquerManagement].[dbo].[Task].[BOMID]=[SprayLacquerManagement].[dbo].[BOMINFO].[BOMID] and [Status]=7 " + sqlwhere + " and [LineName]='" + sLine + "'";
                        if (GetDataSet(sqlpartnumsum, ConnectString, ref dsPartNumSum, ref sErrorMessage) == true)
                        {
                            excel.Cells[6, j + 3] = dsPartNumSum.Tables[0].Rows[0]["Main"].ToString();
                            excel.Cells[7, j + 3] = dsPartNumSum.Tables[0].Rows[0]["GuHua"].ToString();
                            excel.Cells[8, j + 3] = dsPartNumSum.Tables[0].Rows[0]["XiShi"].ToString();
                        }


                        for (int x = 0; x < dsTemp.Tables[0].Rows.Count; x++)
                        {
                            if (dsTemp.Tables[0].Rows[x]["LineName"].ToString() == sLine && dsTemp.Tables[0].Rows[x]["ProductName"].ToString() == sPartNumber)
                            {
                                excel.Cells[3 * i + 6, j + 3] = dsTemp.Tables[0].Rows[x]["Main"].ToString();
                                excel.Cells[3 * i + 7, j + 3] = dsTemp.Tables[0].Rows[x]["GuHua"].ToString();
                                excel.Cells[3 * i + 8, j + 3] = dsTemp.Tables[0].Rows[x]["XiShi"].ToString();
                            }
                        }
                    }
                }
            }


        return true;
        }

        public static bool DataGridviewShowToExcel(DataGridView dgv, bool isShowExcle)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("没有调漆数据!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //建立Excel对象      
            Excel.Application excel = new Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = isShowExcle;
            //生成字段名称      
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }
            //填充数据      
            for (int i = 0; i < dgv.RowCount ; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv[j, i].ValueType == typeof(string))
                    {
                        excel.Cells[i + 2, j + 1] = "'" + dgv[j, i].Value.ToString();
                    }
                    else
                    {
                        excel.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();
                    }
                }
            }
            return true;
        }    

        public static bool OpenTextFile(ref string sFileName, ref string sErrorMessage)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog openfiledialog = new OpenFileDialog();
                //openfiledialog.Filter = "All Files|*.*";

                openfiledialog.Filter = "Flash Files (*.txt)|*.txt|" + "All Files|*.*";
                openfiledialog.ShowDialog();
                sFileName = openfiledialog.FileName.ToString();

                if (sFileName.Length > 0)
                {
                    sErrorMessage = "";
                    return true;
                }
                else if (sFileName.Length == 0)
                {
                    sErrorMessage = "Please Select Text File!";
                    return false;
                }
                else
                {
                    sErrorMessage = "File Format Error!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public static bool FileExists(string sFileName)
        {
            try
            {
                if (System.IO.File.Exists(sFileName) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public string OpenDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "PRN Files (*.PRN)|*.PRN|Text Files (*.TXT)|*.TXT|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                return FileName;
            }
            else
            {
                return "";
            }
        }

        #endregion

        #region Number Verification
        public static bool IsNumeric(string value)
        {

            return Regex.IsMatch(value, @"^[+-]?/d*[.]?/d*$");

        }

        public static bool IsInt(string value,ref string sErrorMessage)
        {
            try
            {
                int nxx = int.Parse(value);
                return true;
            }
            catch(Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public static bool IsDouble(string value,ref string sErrorMessage)
        {
            try
            {
                double dxx = double.Parse(value);
                return true;
            }
            catch(Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }
        public static bool IsInt(string value)
        {

            return Regex.IsMatch(value, @"^[+-]?/d*$");

        }

        public static bool IsUnsign(string value)
        {

            return Regex.IsMatch(value, @"^/d*[.]?/d*$");

        }
        #endregion

        #region Label Print
        public static bool PrintLabelInit(string sLabelPath, string sPrintPath, ref string sErrorMessage)
        {
            try
            {
                clsxx.LabelPath = sLabelPath;
                clsxx.PrintPath = sPrintPath;
                clsxx.ClearVariableItems();
                //clsxx.AddNewItem("TEST", sValue);
                //clsxx.PrintLabel();
                return true;
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }

        public static bool AddPrintVariable(string sVarName,string sVarValue)
        {
            clsxx.AddNewItem(sVarName, sVarValue);
            return true;
        }

        public static bool Print(ref string sErrorMessage)
        {
            try
            {
                clsxx.PrintLabel();
                return true;
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message.ToString();
                return false;
            }
        }
        #endregion

        public static DataTable ExcelToDS(string strFileName)
        {
            System.Data.DataTable dtRes = new DataTable();

            #region Init Column
            dtRes.Columns.Add("客户");
            dtRes.Columns.Add("机种");
            dtRes.Columns.Add("厂商");
            dtRes.Columns.Add("颜色");
            dtRes.Columns.Add("主剂1");
            dtRes.Columns.Add("主剂2");
            dtRes.Columns.Add("主剂3");
            dtRes.Columns.Add("固化剂1");
            dtRes.Columns.Add("固化剂2");
            dtRes.Columns.Add("固化剂3");
            dtRes.Columns.Add("固化剂比例");
            dtRes.Columns.Add("稀释剂1");
            dtRes.Columns.Add("稀释剂2");
            dtRes.Columns.Add("稀释剂3");
            dtRes.Columns.Add("稀释剂上限");
            dtRes.Columns.Add("稀释剂下限");
            dtRes.Columns.Add("粘度上限");
            dtRes.Columns.Add("粘度下限");
            dtRes.Columns.Add("网布目数");
            dtRes.Columns.Add("有效时间");
            #endregion

            #region Open EXCEL
            object missing = System.Reflection.Missing.Value;
            Excel.Application excel = new Excel.Application();

            excel.Visible = false; excel.UserControl = false;
            // 以只读的形式打开EXCEL文件
            Excel.Workbook wb = excel.Application.Workbooks.Open(strFileName, missing, true, missing, missing, missing,
              missing, missing, missing, true, missing, missing, missing, missing, missing);
            //取得第一个工作薄
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);
            #endregion

            //取得总记录行数   (包括标题列)
            int rowsint = ws.UsedRange.Cells.Rows.Count; //得到行数
            int columnsint = ws.UsedRange.Cells.Columns.Count;//得到列数
            System.Data.DataRow dr;

            for (int i = 2; i <= rowsint;i++ )
            {
                dr = dtRes.NewRow();
                dr[0]=  ws.get_Range("A" + i.ToString(), missing).Value;
                dr[1] = ws.get_Range("B" + i.ToString(), missing).Value;
                dr[2] = ws.get_Range("C" + i.ToString(), missing).Value;
                dr[3] = ws.get_Range("D" + i.ToString(), missing).Value;
                dr[4] = ws.get_Range("E" + i.ToString(), missing).Value;
                dr[5] = ws.get_Range("F" + i.ToString(), missing).Value;
                dr[6] = ws.get_Range("G" + i.ToString(), missing).Value;
                dr[7] = ws.get_Range("H" + i.ToString(), missing).Value;
                dr[8] = ws.get_Range("I" + i.ToString(), missing).Value;
                dr[9] = ws.get_Range("J" + i.ToString(), missing).Value;
                dr[10] = ws.get_Range("K" + i.ToString(), missing).Value;
                dr[11] = ws.get_Range("L" + i.ToString(), missing).Value;
                dr[12] = ws.get_Range("M" + i.ToString(), missing).Value;
                dr[13] = ws.get_Range("N" + i.ToString(), missing).Value;
                dr[14] = ws.get_Range("O" + i.ToString(), missing).Value;
                dr[15] = ws.get_Range("P" + i.ToString(), missing).Value;
                dr[16] = ws.get_Range("Q" + i.ToString(), missing).Value;
                dr[17] = ws.get_Range("R" + i.ToString(), missing).Value;
                dr[18] = ws.get_Range("S" + i.ToString(), missing).Value;
                dr[19] = ws.get_Range("T" + i.ToString(), missing).Value;

                dtRes.Rows.Add(dr);              
            }
            
            excel.Quit();
            excel = null;
            return dtRes;
        } 

    }
}
