using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Threading;

namespace frontend.config
{
    class SingtonConfigContent
    {
        protected static SingtonConfigContent _instance;

        protected static readonly string ConfigFolderPath = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"oilpainter", @"config");

        protected static readonly string ConfigFileName = @"sys-config";

        protected static readonly string DbConfig = @"dbconfig.config";

        protected static readonly string GuhuaPortNumLabel = @"guhua-portnum";
        protected static readonly string GuhuaBaundLabel = @"guhua-baud-rate";
        protected static readonly string GuhuaParityLabel = @"guhua-parity";
        protected static readonly string GuhuaDataBitLabel = @"guhua-data-bits";
        protected static readonly string GuhuaStopBitLabel = @"guhua-stop-bits";
        protected static readonly string XishiPortNumLabel = @"xishi-portnum";
        protected static readonly string XishiBaundLabel = @"xishi-baud-rate";
        protected static readonly string XishiParityLabel = @"xishi-parity";
        protected static readonly string XishiDataBitLabel = @"xishi-data-bits";
        protected static readonly string XishiStopBitLabel = @"xishi-stop-bits";
        protected static readonly string MainPortNumLabel = @"main-portnum";
        protected static readonly string MainBaundLabel = @"main-baud-rate";
        protected static readonly string MainParityLabel = @"main-parity";
        protected static readonly string MainDataBitLabel = @"main-data-bits";
        protected static readonly string MainStopBitLabel = @"main-stop-bits";
        protected static readonly string GuhuaDistanceLabel = @"guhua-distance";
        protected static readonly string AutoWeightLabel = @"auto-weight";
        protected static readonly string PrinterNameLabel = @"printer-name";
        protected static readonly string PrinterTemplateLabel = @"printer-template-path";
        protected static readonly string DbServerLabel = @"datasource";
        protected static readonly string DbUserLabel = @"userid";
        protected static readonly string DbPassLabel = @"password";

        protected static readonly string LastPrintLineLabel = @"last-line";
        protected static readonly string LastPrintMachineLabel = @"last-machine";
        protected static readonly string LastPrintOilNumLabel = @"last-oil-num";
        protected static readonly string LastPrintGuhuaLabel = @"last-guhua-num";
        protected static readonly string LastPrintXishiLabel = @"last-xishi-num";
        protected static readonly string LastPrintOilSecLabel = @"last-oil-seconds";
        protected static readonly string LastPrintOperatorLabel = @"last-operator";
        protected static readonly string LastPrintDateLabel = @"last-date";
        protected static readonly string LastPrintValidateTimeLabel = @"last-validate-time";

        protected static readonly string MainNumberRuleLabel = "main-material-rule";
        protected static readonly string MainBatchRuleLabel = "main-batch-rule";
        protected static readonly string GuhuaNumberRuleLabel = "guhua-material-rule";
        protected static readonly string GuhuaBatchRuleLabel = "guhua-batch-rule";
        protected static readonly string XishiNumberRuleLabel = "xishi-material-rule";
        protected static readonly string XishiBatchRuleLabel = "xishi-batch-rule";

        private BalanceSerialConfigModel basicBalance;
        private BalanceSerialConfigModel guhuaBalance;
        private BalanceSerialConfigModel xishiBalance;
        private OilSpinConfigModel oilSpin;
        private PrinterConfigModel printer;
        private DatabaseConfigModel database;
        private PrinterRecordModel lastPrintRecord;

        // 私有构造
        protected SingtonConfigContent()
        {
            if (!Directory.Exists(ConfigFolderPath)) // 目录不存在，创建目录
            {
                Directory.CreateDirectory(ConfigFolderPath);
            }

            // 初始化属性
            basicBalance = new BalanceSerialConfigModel();
            guhuaBalance = new BalanceSerialConfigModel();
            oilSpin = new OilSpinConfigModel();
            xishiBalance = new BalanceSerialConfigModel();
            printer = new PrinterConfigModel();
            database = new DatabaseConfigModel();
            LastPrintRecord = new PrinterRecordModel();

            // 拼接文件路径
            string filePath = Path.Combine(ConfigFolderPath, ConfigFileName);
            if (!File.Exists(filePath + ".config")) // 文件不存在，加载默认配置
            {
                // 电子秤
                guhuaBalance.PortNumber = xishiBalance.PortNumber = basicBalance.PortNumber = 1;
                basicBalance.BaudRate = xishiBalance.BaudRate = guhuaBalance.BaudRate = 300;
                basicBalance.Parity = guhuaBalance.Parity = xishiBalance.Parity = 0;
                basicBalance.DataBits = guhuaBalance.DataBits = xishiBalance.DataBits = 5;
                basicBalance.StopBits = guhuaBalance.StopBits = xishiBalance.StopBits = 1;
                // 调漆参数
                oilSpin.DistanceRate = 1;
                oilSpin.AutoCalcWeight = true;
                //打印机
                printer.PrinterName = String.Empty;
                printer.LabelTemplatPath = String.Empty;

                WriteCurrentConfig();
            }
            else
            {
                // 配置文件存在，读取
                LoadSettings(filePath);
            }

            string dbFilePath = Path.Combine("config", DbConfig);
            if (!File.Exists(dbFilePath)) // 加载数据库配置文件
            {
                // 数据库
                database.Server = String.Empty;
                database.Username = String.Empty;
                database.Password = String.Empty;
            }
            else
            {
                ConfigurationManager.OpenExeConfiguration(dbFilePath);
            }
        }

        // 加载配置文件
        protected void LoadSettings(string filepath)
        {
            ExeConfigurationFileMap map = new ExeConfigurationFileMap { ExeConfigFilename = filepath + ".config" };
            var config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None, true);
            var settings = config.AppSettings.Settings;
            guhuaBalance.PortNumber = int.Parse(settings[GuhuaPortNumLabel].Value);
            guhuaBalance.BaudRate = int.Parse(settings[GuhuaBaundLabel].Value);
            guhuaBalance.DataBits = int.Parse(settings[GuhuaDataBitLabel].Value);
            guhuaBalance.Parity = int.Parse(settings[GuhuaParityLabel].Value);
            guhuaBalance.StopBits = int.Parse(settings[GuhuaStopBitLabel].Value);

            xishiBalance.PortNumber = int.Parse(settings[XishiPortNumLabel].Value);
            xishiBalance.BaudRate = int.Parse(settings[XishiBaundLabel].Value);
            xishiBalance.DataBits = int.Parse(settings[XishiDataBitLabel].Value);
            xishiBalance.Parity = int.Parse(settings[XishiParityLabel].Value);
            xishiBalance.StopBits = int.Parse(settings[XishiStopBitLabel].Value);

            basicBalance.PortNumber = int.Parse(settings[MainPortNumLabel].Value);
            basicBalance.BaudRate = int.Parse(settings[MainBaundLabel].Value);
            basicBalance.DataBits = int.Parse(settings[MainDataBitLabel].Value);
            basicBalance.Parity = int.Parse(settings[MainParityLabel].Value);
            basicBalance.StopBits = int.Parse(settings[MainStopBitLabel].Value);

            oilSpin.DistanceRate = int.Parse(settings[GuhuaDistanceLabel].Value);
            oilSpin.AutoCalcWeight = bool.Parse(settings[AutoWeightLabel].Value);

            printer.PrinterName = settings[PrinterNameLabel].Value;
            printer.LabelTemplatPath = settings[PrinterTemplateLabel].Value;

            LastPrintRecord.PrintDate = settings[LastPrintDateLabel].Value;
            LastPrintRecord.BasicModel.GuhuaMaterialNu = settings[LastPrintGuhuaLabel].Value;
            LastPrintRecord.BasicModel.LineType = settings[LastPrintLineLabel].Value;
            LastPrintRecord.BasicModel.MachineType = settings[LastPrintMachineLabel].Value;
            LastPrintRecord.BasicModel.OilMaterialNum = settings[LastPrintOilNumLabel].Value;
            LastPrintRecord.BasicModel.OilSeconds  = int.Parse(settings[LastPrintOilSecLabel].Value);
            LastPrintRecord.BasicModel.ValidateTime = int.Parse(settings[LastPrintValidateTimeLabel].Value);
            LastPrintRecord.Operator = settings[LastPrintOperatorLabel].Value;
            LastPrintRecord.BasicModel.XishiMaterialNum = settings[LastPrintXishiLabel].Value;

            // 编码规则
            MainCodeRule = settings[MainNumberRuleLabel].Value;
            MainNumRule = settings[MainBatchRuleLabel].Value;
            GuhuaCodeRule = settings[GuhuaNumberRuleLabel].Value;
            GuhuaNumRule = settings[GuhuaBatchRuleLabel].Value;
            XishiCodeRule = settings[XishiNumberRuleLabel].Value;
            XishiNumRule = settings[XishiBatchRuleLabel].Value;
        }
        /// <summary>
        /// 写入当前配置到文件
        /// </summary>
        public void WriteCurrentConfig()
        {
            Thread writeThread = new Thread(new ParameterizedThreadStart(ConfigWritterEntry));
            writeThread.Start(Path.Combine(ConfigFolderPath, ConfigFileName));
        }
        // 后台写入
        private void ConfigWritterEntry(object filepath)
        {
            if (File.Exists(filepath as string + ".config"))
            {
                SaveAndWriteEntry(filepath);
            }
            else
            {
                CreateAndWriteEntry(filepath);
            }
        }
        // 保存并写入配置
        private void SaveAndWriteEntry(object filepath)
        {
            ExeConfigurationFileMap map = new ExeConfigurationFileMap { ExeConfigFilename = filepath + ".config" };
            var config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None, true);
            var settings = config.AppSettings.Settings;
            settings[GuhuaPortNumLabel].Value = guhuaBalance.PortNumber.ToString();
            settings[GuhuaBaundLabel].Value = guhuaBalance.BaudRate.ToString();
            settings[GuhuaDataBitLabel].Value = guhuaBalance.DataBits.ToString();
            settings[GuhuaParityLabel].Value = guhuaBalance.Parity.ToString();
            settings[GuhuaStopBitLabel].Value = guhuaBalance.StopBits.ToString();

            settings[XishiPortNumLabel].Value = xishiBalance.PortNumber.ToString();
            settings[XishiBaundLabel].Value = xishiBalance.BaudRate.ToString();
            settings[XishiDataBitLabel].Value = xishiBalance.DataBits.ToString();
            settings[XishiParityLabel].Value = xishiBalance.Parity.ToString();
            settings[XishiStopBitLabel].Value = xishiBalance.StopBits.ToString();

            settings[MainPortNumLabel].Value = basicBalance.PortNumber.ToString();
            settings[MainBaundLabel].Value = basicBalance.BaudRate.ToString();
            settings[MainDataBitLabel].Value = basicBalance.DataBits.ToString();
            settings[MainParityLabel].Value = basicBalance.Parity.ToString();
            settings[MainStopBitLabel].Value = basicBalance.StopBits.ToString();

            settings[GuhuaDistanceLabel].Value = oilSpin.DistanceRate.ToString();
            settings[AutoWeightLabel].Value = oilSpin.AutoCalcWeight.ToString();

            settings[PrinterNameLabel].Value = printer.PrinterName;
            settings[PrinterTemplateLabel].Value = printer.LabelTemplatPath;

            settings[LastPrintDateLabel].Value = LastPrintRecord.PrintDate ;
            settings[LastPrintValidateTimeLabel].Value = LastPrintRecord.BasicModel.ValidateTime.ToString();
            settings[LastPrintGuhuaLabel].Value = LastPrintRecord.BasicModel.GuhuaMaterialNu;
            settings[LastPrintLineLabel].Value = LastPrintRecord.BasicModel.LineType;
            settings[LastPrintMachineLabel].Value = LastPrintRecord.BasicModel.MachineType;
            settings[LastPrintOilNumLabel].Value = LastPrintRecord.BasicModel.OilMaterialNum;
            settings[LastPrintOilSecLabel].Value = LastPrintRecord.BasicModel.OilSeconds.ToString();
            settings[LastPrintOperatorLabel].Value = LastPrintRecord.Operator;
            settings[LastPrintXishiLabel].Value = LastPrintRecord.BasicModel.XishiMaterialNum;

            // 编码规则
            settings[MainNumberRuleLabel].Value = MainCodeRule;
            settings[MainBatchRuleLabel].Value = MainNumRule;
            settings[GuhuaNumberRuleLabel].Value = GuhuaCodeRule;
            settings[GuhuaBatchRuleLabel].Value = GuhuaNumRule;
            settings[XishiNumberRuleLabel].Value = XishiCodeRule;
            settings[XishiBatchRuleLabel].Value = XishiNumRule;

            if (File.Exists(filepath as string))
            {
                config.Save(ConfigurationSaveMode.Modified);
            }
            else
            {
                config.Save(ConfigurationSaveMode.Full);
            }
        }
        // 创建并写入配置
        private void CreateAndWriteEntry(object filepath)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            settings.Add(new KeyValueConfigurationElement(GuhuaPortNumLabel, guhuaBalance.PortNumber.ToString()));
            settings.Add(new KeyValueConfigurationElement(GuhuaBaundLabel, guhuaBalance.BaudRate.ToString()));
            settings.Add(new KeyValueConfigurationElement(GuhuaDataBitLabel, guhuaBalance.DataBits.ToString()));
            settings.Add(new KeyValueConfigurationElement(GuhuaParityLabel, guhuaBalance.Parity.ToString()));
            settings.Add(new KeyValueConfigurationElement(GuhuaStopBitLabel, guhuaBalance.StopBits.ToString()));

            settings.Add(new KeyValueConfigurationElement(XishiPortNumLabel, xishiBalance.PortNumber.ToString()));
            settings.Add(new KeyValueConfigurationElement(XishiBaundLabel, xishiBalance.BaudRate.ToString()));
            settings.Add(new KeyValueConfigurationElement(XishiDataBitLabel, xishiBalance.DataBits.ToString()));
            settings.Add(new KeyValueConfigurationElement(XishiParityLabel, xishiBalance.Parity.ToString()));
            settings.Add(new KeyValueConfigurationElement(XishiStopBitLabel, xishiBalance.StopBits.ToString()));

            settings.Add(new KeyValueConfigurationElement(MainPortNumLabel, basicBalance.PortNumber.ToString()));
            settings.Add(new KeyValueConfigurationElement(MainBaundLabel, basicBalance.BaudRate.ToString()));
            settings.Add(new KeyValueConfigurationElement(MainDataBitLabel, basicBalance.DataBits.ToString()));
            settings.Add(new KeyValueConfigurationElement(MainParityLabel, basicBalance.Parity.ToString()));
            settings.Add(new KeyValueConfigurationElement(MainStopBitLabel, basicBalance.StopBits.ToString()));

            settings.Add(new KeyValueConfigurationElement(GuhuaDistanceLabel, oilSpin.DistanceRate.ToString()));
            settings.Add(new KeyValueConfigurationElement(AutoWeightLabel, oilSpin.AutoCalcWeight.ToString()));

            settings.Add(new KeyValueConfigurationElement(PrinterNameLabel, printer.PrinterName));
            settings.Add(new KeyValueConfigurationElement(PrinterTemplateLabel, printer.LabelTemplatPath));

            settings.Add(new KeyValueConfigurationElement(LastPrintDateLabel, LastPrintRecord.PrintDate));
            settings.Add(new KeyValueConfigurationElement(LastPrintValidateTimeLabel, LastPrintRecord.BasicModel.ValidateTime.ToString())); 
            settings.Add(new KeyValueConfigurationElement(LastPrintGuhuaLabel, LastPrintRecord.BasicModel.GuhuaMaterialNu));
            settings.Add(new KeyValueConfigurationElement(LastPrintLineLabel, LastPrintRecord.BasicModel.LineType)); 
            settings.Add(new KeyValueConfigurationElement(LastPrintMachineLabel, LastPrintRecord.BasicModel.MachineType)); 
            settings.Add(new KeyValueConfigurationElement(LastPrintOilNumLabel, LastPrintRecord.BasicModel.OilMaterialNum));
            settings.Add(new KeyValueConfigurationElement(LastPrintOilSecLabel, LastPrintRecord.BasicModel.OilSeconds.ToString()));
            settings.Add(new KeyValueConfigurationElement(LastPrintOperatorLabel, LastPrintRecord.Operator));
            settings.Add(new KeyValueConfigurationElement(LastPrintXishiLabel, LastPrintRecord.BasicModel.XishiMaterialNum));

            // 编码规则
            settings.Add(new KeyValueConfigurationElement(MainNumberRuleLabel, MainCodeRule));
            settings.Add(new KeyValueConfigurationElement(MainBatchRuleLabel, MainNumRule));
            settings.Add(new KeyValueConfigurationElement(GuhuaNumberRuleLabel, GuhuaCodeRule));
            settings.Add(new KeyValueConfigurationElement(GuhuaBatchRuleLabel, GuhuaNumRule));
            settings.Add(new KeyValueConfigurationElement(XishiNumberRuleLabel, XishiCodeRule));
            settings.Add(new KeyValueConfigurationElement(XishiBatchRuleLabel, XishiNumRule));

            // ConfigurationManager.RefreshSection("appSettings");

            if (File.Exists(filepath as string))
            {
                config.Save(ConfigurationSaveMode.Modified);
            }
            else
            {
                config.SaveAs(filepath as string + ".config", ConfigurationSaveMode.Full);
            }
        }
        /// <summary>
        /// 获取配置文件的唯一实例
        /// </summary>
        /// <returns>配置文件转为对象的唯一实例</returns>
        public static SingtonConfigContent Instance()
        {
            if (_instance == null)
            {
                lock (typeof(SingtonConfigContent))
                {
                    if (_instance == null) // double-check
                    {
                        _instance = new SingtonConfigContent();
                    }
                }
            }
            return _instance;
        }
        /// <summary>
        /// 获取或设置基础电子秤串口设置
        /// </summary>
        public BalanceSerialConfigModel BasicBalance
        {
            get { return basicBalance; }
            set
            {
                if (null != value)
                {
                    basicBalance = value;
                }
            }
        }
        /// <summary>
        /// 获取或设置固化剂电子秤串口设置
        /// </summary>
        public BalanceSerialConfigModel GuhuaBalance
        {
            get { return guhuaBalance; }
            set
            {
                if (null != value)
                {
                    guhuaBalance = value;
                }
            }
        }
        /// <summary>
        /// 获取或设置稀释剂电子秤串口设置
        /// </summary>
        public BalanceSerialConfigModel XishiBalance
        {
            get { return xishiBalance; }
            set
            {
                if (null != value)
                {
                    xishiBalance = value;
                }
            }
        }

        /// <summary>
        /// 获取或设置调漆参数
        /// </summary>
        public OilSpinConfigModel OilSpin
        {
            get { return oilSpin; }
            set
            {
                if (null != value)
                {
                    oilSpin = value;
                }
            }
        }

        /// <summary>
        /// 获取或设置打印机参数
        /// </summary>
        public PrinterConfigModel Printer
        {
            get { return printer; }
            set
            {
                if (null != value)
                {
                    printer = value;
                }
            }
        }

        /// <summary>
        /// 获取或设置数据库参数
        /// </summary>
        public DatabaseConfigModel Database
        {
            get { return database; }
            set
            {
                if (null != value)
                {
                    database = value;
                }
            }
        }

        /// <summary>
        /// 获取和设置上一次打印记录
        /// </summary>
        public PrinterRecordModel LastPrintRecord
        {
            get;
            set;
        }
        /// <summary>
        /// 获取或设置主剂料号编码规则
        /// </summary>
        public string MainCodeRule
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置主剂料批次号编码规则
        /// </summary>
        public string MainNumRule
        {
            get;set;
        }
        /// <summary>
        /// 获取或设置固化剂主剂料编码规则
        /// </summary>
        public string GuhuaCodeRule
        {
            get; set;
        }
        /// <summary>
        /// 获取或设置固化剂批次号编码规则
        /// </summary>
        public string GuhuaNumRule
        {
            get; set;
        }
        /// <summary>
        /// 获取或设置稀释剂编码规则
        /// </summary>
        public string XishiCodeRule
        {
            get; set;
        }
        /// <summary>
        /// 获取或设置稀释剂批次号编码规则
        /// </summary>
        public string XishiNumRule
        {
            get; set;
        }
    }
}
