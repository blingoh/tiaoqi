using System.Windows.Forms;

namespace 调漆工艺管理系统
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            ProgBar.cBlendItems cBlendItems16 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints16 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems17 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints17 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems18 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints18 = new ProgBar.cFocalPoints();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbChangePSW = new System.Windows.Forms.ToolStripButton();
            this.tsbUserMainten = new System.Windows.Forms.ToolStripButton();
            this.tsbProductionMainten = new System.Windows.Forms.ToolStripButton();
            this.tsbBOMMainten = new System.Windows.Forms.ToolStripButton();
            this.tsbOptionSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbAbout = new System.Windows.Forms.ToolStripButton();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.smConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.msChangePSW = new System.Windows.Forms.ToolStripMenuItem();
            this.smUserMainten = new System.Windows.Forms.ToolStripMenuItem();
            this.msProductionSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.msBOMMainten = new System.Windows.Forms.ToolStripMenuItem();
            this.msOilPaintType = new System.Windows.Forms.ToolStripMenuItem();
            this.msCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.msSystemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.bOM上传ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.msRS232 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSpeedInput = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msDataExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUserInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUserType = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnScale = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnFrameRight = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel41 = new System.Windows.Forms.Panel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.panel44 = new System.Windows.Forms.Panel();
            this.panel45 = new System.Windows.Forms.Panel();
            this.panel46 = new System.Windows.Forms.Panel();
            this.pbXiShiParts = new ProgBar.ProgBarPlus();
            this.panel65 = new System.Windows.Forms.Panel();
            this.panel47 = new System.Windows.Forms.Panel();
            this.panel48 = new System.Windows.Forms.Panel();
            this.panel49 = new System.Windows.Forms.Panel();
            this.btnStopXishi = new System.Windows.Forms.Button();
            this.lblXiShiLot = new System.Windows.Forms.Label();
            this.lblXiSHiPartNumber = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.panel50 = new System.Windows.Forms.Panel();
            this.btnXiShiCard = new System.Windows.Forms.Button();
            this.btnXiShi = new System.Windows.Forms.Button();
            this.panel51 = new System.Windows.Forms.Panel();
            this.panel52 = new System.Windows.Forms.Panel();
            this.lblXiShiPartWeight = new System.Windows.Forms.Label();
            this.panel53 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.panel54 = new System.Windows.Forms.Panel();
            this.panel55 = new System.Windows.Forms.Panel();
            this.panel56 = new System.Windows.Forms.Panel();
            this.panel57 = new System.Windows.Forms.Panel();
            this.lblXiShiHolderWeight = new System.Windows.Forms.Label();
            this.panel58 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.panel59 = new System.Windows.Forms.Panel();
            this.panel60 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.panel61 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.panel62 = new System.Windows.Forms.Panel();
            this.lblXiShiPartInfo = new System.Windows.Forms.Label();
            this.panel42 = new System.Windows.Forms.Panel();
            this.pbGuHua = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.pbGuHuaParts = new ProgBar.ProgBarPlus();
            this.panel64 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btnStopGuhua = new System.Windows.Forms.Button();
            this.lblGuHuaLotNum = new System.Windows.Forms.Label();
            this.lblGuHuaPartNumber = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel28 = new System.Windows.Forms.Panel();
            this.btnGuHuaCard = new System.Windows.Forms.Button();
            this.btnGuHua = new System.Windows.Forms.Button();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.lblGuHuaPartWeight = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.lblGuHuaHolderWeight = new System.Windows.Forms.Label();
            this.panel36 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.panel40 = new System.Windows.Forms.Panel();
            this.lblGuHuaPartInfo = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.pbMain = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pbMainParts = new ProgBar.ProgBarPlus();
            this.panel63 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.pnMainFoot = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnStopMain = new System.Windows.Forms.Button();
            this.lblMainPartsLotNumber = new System.Windows.Forms.Label();
            this.lblMainPartNumber = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnMainCard = new System.Windows.Forms.Button();
            this.btnMainPart = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblMainPartWeight = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pnMainHead = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblMainHolderWeight = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblMainScaleNumber = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lblMainPartInfo = new System.Windows.Forms.Label();
            this.pnFrameLeft = new System.Windows.Forms.Panel();
            this.panel66 = new System.Windows.Forms.Panel();
            this.panel68 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel67 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMainPartTargetWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMainPartRaiseWeight = new MyControls.NTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtMainPartActualWeight = new MyControls.NTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSupplier = new MyControls.NTextBox();
            this.txtPartNumber = new MyControls.NTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProductionLine = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPaintType = new System.Windows.Forms.Label();
            this.spPortMain = new System.IO.Ports.SerialPort(this.components);
            this.spPortGuHua = new System.IO.Ports.SerialPort(this.components);
            this.spPortXiShi = new System.IO.Ports.SerialPort(this.components);
            this.lnkLblAccount = new System.Windows.Forms.LinkLabel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tsMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnScale.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnFrameRight.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel43.SuspendLayout();
            this.panel44.SuspendLayout();
            this.panel45.SuspendLayout();
            this.panel46.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel49.SuspendLayout();
            this.panel50.SuspendLayout();
            this.panel51.SuspendLayout();
            this.panel52.SuspendLayout();
            this.panel53.SuspendLayout();
            this.panel54.SuspendLayout();
            this.panel55.SuspendLayout();
            this.panel56.SuspendLayout();
            this.panel57.SuspendLayout();
            this.panel58.SuspendLayout();
            this.panel59.SuspendLayout();
            this.panel60.SuspendLayout();
            this.panel61.SuspendLayout();
            this.panel62.SuspendLayout();
            this.pbGuHua.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel36.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel40.SuspendLayout();
            this.pbMain.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel15.SuspendLayout();
            this.pnMainFoot.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.pnMainHead.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.pnFrameLeft.SuspendLayout();
            this.panel66.SuspendLayout();
            this.panel68.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChangePSW,
            this.tsbUserMainten,
            this.tsbProductionMainten,
            this.tsbBOMMainten,
            this.tsbOptionSettings,
            this.toolStripButton2,
            this.tsbAbout});
            this.tsMain.Location = new System.Drawing.Point(0, 25);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1162, 57);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbChangePSW
            // 
            this.tsbChangePSW.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbChangePSW.ForeColor = System.Drawing.Color.Blue;
            this.tsbChangePSW.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangePSW.Image")));
            this.tsbChangePSW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangePSW.Name = "tsbChangePSW";
            this.tsbChangePSW.Size = new System.Drawing.Size(128, 54);
            this.tsbChangePSW.Text = "修改密码";
            this.tsbChangePSW.Click += new System.EventHandler(this.tsbChangePSW_Click);
            // 
            // tsbUserMainten
            // 
            this.tsbUserMainten.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbUserMainten.ForeColor = System.Drawing.Color.Blue;
            this.tsbUserMainten.Image = ((System.Drawing.Image)(resources.GetObject("tsbUserMainten.Image")));
            this.tsbUserMainten.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUserMainten.Name = "tsbUserMainten";
            this.tsbUserMainten.Size = new System.Drawing.Size(133, 54);
            this.tsbUserMainten.Text = " 用户维护";
            this.tsbUserMainten.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbProductionMainten
            // 
            this.tsbProductionMainten.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbProductionMainten.ForeColor = System.Drawing.Color.Blue;
            this.tsbProductionMainten.Image = ((System.Drawing.Image)(resources.GetObject("tsbProductionMainten.Image")));
            this.tsbProductionMainten.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProductionMainten.Name = "tsbProductionMainten";
            this.tsbProductionMainten.Size = new System.Drawing.Size(128, 54);
            this.tsbProductionMainten.Text = "产线维护";
            this.tsbProductionMainten.Click += new System.EventHandler(this.tsbProductionMainten_Click);
            // 
            // tsbBOMMainten
            // 
            this.tsbBOMMainten.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbBOMMainten.ForeColor = System.Drawing.Color.Blue;
            this.tsbBOMMainten.Image = ((System.Drawing.Image)(resources.GetObject("tsbBOMMainten.Image")));
            this.tsbBOMMainten.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBOMMainten.Name = "tsbBOMMainten";
            this.tsbBOMMainten.Size = new System.Drawing.Size(128, 54);
            this.tsbBOMMainten.Text = "料号维护";
            this.tsbBOMMainten.Click += new System.EventHandler(this.tsbBOMMainten_Click);
            // 
            // tsbOptionSettings
            // 
            this.tsbOptionSettings.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbOptionSettings.ForeColor = System.Drawing.Color.Blue;
            this.tsbOptionSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsbOptionSettings.Image")));
            this.tsbOptionSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptionSettings.Name = "tsbOptionSettings";
            this.tsbOptionSettings.Size = new System.Drawing.Size(128, 54);
            this.tsbOptionSettings.Text = "参数设置";
            this.tsbOptionSettings.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.Blue;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(128, 54);
            this.toolStripButton2.Text = "数据分析";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbAbout
            // 
            this.tsbAbout.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsbAbout.ForeColor = System.Drawing.Color.Blue;
            this.tsbAbout.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbout.Image")));
            this.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbout.Name = "tsbAbout";
            this.tsbAbout.Size = new System.Drawing.Size(96, 54);
            this.tsbAbout.Text = "关于";
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smConfig,
            this.msDebug,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1162, 25);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // smConfig
            // 
            this.smConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msChangePSW,
            this.smUserMainten,
            this.msProductionSettings,
            this.msBOMMainten,
            this.msOilPaintType,
            this.msCustomer,
            this.toolStripMenuItem2,
            this.msSystemSettings,
            this.bOM上传ToolStripMenuItem});
            this.smConfig.Name = "smConfig";
            this.smConfig.Size = new System.Drawing.Size(68, 21);
            this.smConfig.Text = "基础设置";
            // 
            // msChangePSW
            // 
            this.msChangePSW.Image = ((System.Drawing.Image)(resources.GetObject("msChangePSW.Image")));
            this.msChangePSW.Name = "msChangePSW";
            this.msChangePSW.Size = new System.Drawing.Size(196, 22);
            this.msChangePSW.Text = "修改密码";
            this.msChangePSW.Click += new System.EventHandler(this.msChangePSW_Click);
            // 
            // smUserMainten
            // 
            this.smUserMainten.Image = ((System.Drawing.Image)(resources.GetObject("smUserMainten.Image")));
            this.smUserMainten.Name = "smUserMainten";
            this.smUserMainten.Size = new System.Drawing.Size(196, 22);
            this.smUserMainten.Text = "用户维护";
            this.smUserMainten.Click += new System.EventHandler(this.smUserMainten_Click);
            // 
            // msProductionSettings
            // 
            this.msProductionSettings.Image = ((System.Drawing.Image)(resources.GetObject("msProductionSettings.Image")));
            this.msProductionSettings.Name = "msProductionSettings";
            this.msProductionSettings.Size = new System.Drawing.Size(196, 22);
            this.msProductionSettings.Text = "产线维护";
            this.msProductionSettings.Click += new System.EventHandler(this.msProductionSettings_Click);
            // 
            // msBOMMainten
            // 
            this.msBOMMainten.Image = ((System.Drawing.Image)(resources.GetObject("msBOMMainten.Image")));
            this.msBOMMainten.Name = "msBOMMainten";
            this.msBOMMainten.Size = new System.Drawing.Size(196, 22);
            this.msBOMMainten.Text = "料号维护";
            this.msBOMMainten.Click += new System.EventHandler(this.msBOMMainten_Click);
            // 
            // msOilPaintType
            // 
            this.msOilPaintType.Image = ((System.Drawing.Image)(resources.GetObject("msOilPaintType.Image")));
            this.msOilPaintType.Name = "msOilPaintType";
            this.msOilPaintType.Size = new System.Drawing.Size(196, 22);
            this.msOilPaintType.Text = "工艺类型";
            this.msOilPaintType.Click += new System.EventHandler(this.msOilPaintType_Click);
            // 
            // msCustomer
            // 
            this.msCustomer.Image = ((System.Drawing.Image)(resources.GetObject("msCustomer.Image")));
            this.msCustomer.Name = "msCustomer";
            this.msCustomer.Size = new System.Drawing.Size(196, 22);
            this.msCustomer.Text = "客户维护";
            this.msCustomer.Click += new System.EventHandler(this.msCustomer_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.toolStripMenuItem2.Text = "________________________";
            // 
            // msSystemSettings
            // 
            this.msSystemSettings.Image = ((System.Drawing.Image)(resources.GetObject("msSystemSettings.Image")));
            this.msSystemSettings.Name = "msSystemSettings";
            this.msSystemSettings.Size = new System.Drawing.Size(196, 22);
            this.msSystemSettings.Text = "参数设置";
            this.msSystemSettings.Click += new System.EventHandler(this.msSystemSettings_Click);
            // 
            // bOM上传ToolStripMenuItem
            // 
            this.bOM上传ToolStripMenuItem.Name = "bOM上传ToolStripMenuItem";
            this.bOM上传ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.bOM上传ToolStripMenuItem.Text = "BOM上传";
            this.bOM上传ToolStripMenuItem.Click += new System.EventHandler(this.bOM上传ToolStripMenuItem_Click);
            // 
            // msDebug
            // 
            this.msDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPrint,
            this.msRS232,
            this.tsSpeedInput});
            this.msDebug.Name = "msDebug";
            this.msDebug.Size = new System.Drawing.Size(44, 21);
            this.msDebug.Text = "调试";
            // 
            // msPrint
            // 
            this.msPrint.Image = ((System.Drawing.Image)(resources.GetObject("msPrint.Image")));
            this.msPrint.Name = "msPrint";
            this.msPrint.Size = new System.Drawing.Size(124, 22);
            this.msPrint.Text = "打印测试";
            this.msPrint.Click += new System.EventHandler(this.msPrint_Click);
            // 
            // msRS232
            // 
            this.msRS232.Image = ((System.Drawing.Image)(resources.GetObject("msRS232.Image")));
            this.msRS232.Name = "msRS232";
            this.msRS232.Size = new System.Drawing.Size(124, 22);
            this.msRS232.Text = "串口调试";
            this.msRS232.Click += new System.EventHandler(this.msRS232_Click);
            // 
            // tsSpeedInput
            // 
            this.tsSpeedInput.Name = "tsSpeedInput";
            this.tsSpeedInput.Size = new System.Drawing.Size(124, 22);
            this.tsSpeedInput.Text = "流速输入";
            this.tsSpeedInput.Click += new System.EventHandler(this.tsSpeedInput_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msDataExport});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "系统数据";
            // 
            // msDataExport
            // 
            this.msDataExport.Image = ((System.Drawing.Image)(resources.GetObject("msDataExport.Image")));
            this.msDataExport.Name = "msDataExport";
            this.msDataExport.Size = new System.Drawing.Size(124, 22);
            this.msDataExport.Text = "数据查询";
            this.msDataExport.Click += new System.EventHandler(this.msDataExport_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem3.Text = "系统注册";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUserInfo,
            this.tsslUserType});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1162, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // tsslUserInfo
            // 
            this.tsslUserInfo.Name = "tsslUserInfo";
            this.tsslUserInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslUserType
            // 
            this.tsslUserType.Name = "tsslUserType";
            this.tsslUserType.Size = new System.Drawing.Size(0, 17);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1162, 629);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnScale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 629);
            this.panel1.TabIndex = 7;
            // 
            // pnScale
            // 
            this.pnScale.Controls.Add(this.panel6);
            this.pnScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnScale.Location = new System.Drawing.Point(0, 0);
            this.pnScale.Name = "pnScale";
            this.pnScale.Size = new System.Drawing.Size(1160, 627);
            this.pnScale.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnFrameRight);
            this.panel6.Controls.Add(this.pnFrameLeft);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1160, 627);
            this.panel6.TabIndex = 1;
            // 
            // pnFrameRight
            // 
            this.pnFrameRight.Controls.Add(this.panel20);
            this.pnFrameRight.Controls.Add(this.pbMain);
            this.pnFrameRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFrameRight.Location = new System.Drawing.Point(313, 0);
            this.pnFrameRight.Name = "pnFrameRight";
            this.pnFrameRight.Size = new System.Drawing.Size(847, 627);
            this.pnFrameRight.TabIndex = 1;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.panel22);
            this.panel20.Controls.Add(this.panel21);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(274, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(573, 627);
            this.panel20.TabIndex = 8;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.panel41);
            this.panel22.Controls.Add(this.pbGuHua);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(13, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(560, 627);
            this.panel22.TabIndex = 1;
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.panel43);
            this.panel41.Controls.Add(this.panel42);
            this.panel41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel41.Location = new System.Drawing.Point(274, 0);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(286, 627);
            this.panel41.TabIndex = 9;
            // 
            // panel43
            // 
            this.panel43.Controls.Add(this.panel44);
            this.panel43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel43.Location = new System.Drawing.Point(13, 0);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(273, 627);
            this.panel43.TabIndex = 2;
            // 
            // panel44
            // 
            this.panel44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel44.Controls.Add(this.panel45);
            this.panel44.Controls.Add(this.panel54);
            this.panel44.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel44.Location = new System.Drawing.Point(0, 0);
            this.panel44.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(274, 627);
            this.panel44.TabIndex = 9;
            // 
            // panel45
            // 
            this.panel45.BackColor = System.Drawing.Color.White;
            this.panel45.Controls.Add(this.panel46);
            this.panel45.Controls.Add(this.panel48);
            this.panel45.Controls.Add(this.panel51);
            this.panel45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel45.Location = new System.Drawing.Point(0, 126);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(272, 499);
            this.panel45.TabIndex = 1;
            // 
            // panel46
            // 
            this.panel46.Controls.Add(this.pbXiShiParts);
            this.panel46.Controls.Add(this.panel65);
            this.panel46.Controls.Add(this.panel47);
            this.panel46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel46.Location = new System.Drawing.Point(0, 38);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(272, 277);
            this.panel46.TabIndex = 2;
            // 
            // pbXiShiParts
            // 
            cBlendItems16.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            cBlendItems16.iPoint = new float[] {
        0F,
        1F};
            this.pbXiShiParts.BarColorBlend = cBlendItems16;
            this.pbXiShiParts.BarColorSolid = System.Drawing.Color.Lime;
            this.pbXiShiParts.BarColorSolidB = System.Drawing.Color.White;
            this.pbXiShiParts.BarLengthValue = ((short)(25));
            this.pbXiShiParts.BarPadding = new System.Windows.Forms.Padding(0);
            this.pbXiShiParts.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.pbXiShiParts.BarStyleHatch = System.Drawing.Drawing2D.HatchStyle.Percent70;
            this.pbXiShiParts.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pbXiShiParts.BarStyleTexture = null;
            this.pbXiShiParts.BorderWidth = ((short)(1));
            this.pbXiShiParts.Corners.All = ((short)(-1));
            this.pbXiShiParts.Corners.LowerLeft = ((short)(0));
            this.pbXiShiParts.Corners.LowerRight = ((short)(0));
            this.pbXiShiParts.Corners.UpperLeft = ((short)(10));
            this.pbXiShiParts.Corners.UpperRight = ((short)(10));
            this.pbXiShiParts.CylonInterval = ((short)(1));
            this.pbXiShiParts.CylonMove = 5F;
            this.pbXiShiParts.Dock = System.Windows.Forms.DockStyle.Left;
            cFocalPoints16.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints16.CenterPoint")));
            cFocalPoints16.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints16.FocusScales")));
            this.pbXiShiParts.FocalPoints = cFocalPoints16;
            this.pbXiShiParts.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pbXiShiParts.ForeColor = System.Drawing.Color.White;
            this.pbXiShiParts.Location = new System.Drawing.Point(86, 0);
            this.pbXiShiParts.Name = "pbXiShiParts";
            this.pbXiShiParts.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.pbXiShiParts.ShapeTextFont = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.pbXiShiParts.ShowDesignBorder = false;
            this.pbXiShiParts.Size = new System.Drawing.Size(110, 250);
            this.pbXiShiParts.TabIndex = 22;
            this.pbXiShiParts.TextFormat = " {0}%";
            this.pbXiShiParts.TextShadow = true;
            this.pbXiShiParts.TextShadowColor = System.Drawing.Color.DarkBlue;
            this.pbXiShiParts.TextShow = ProgBar.ProgBarPlus.eTextShow.FormatString;
            this.pbXiShiParts.Value = 0;
            // 
            // panel65
            // 
            this.panel65.BackColor = System.Drawing.Color.Transparent;
            this.panel65.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel65.Location = new System.Drawing.Point(0, 0);
            this.panel65.Name = "panel65";
            this.panel65.Size = new System.Drawing.Size(86, 250);
            this.panel65.TabIndex = 21;
            // 
            // panel47
            // 
            this.panel47.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel47.Location = new System.Drawing.Point(0, 250);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(272, 27);
            this.panel47.TabIndex = 1;
            // 
            // panel48
            // 
            this.panel48.Controls.Add(this.panel49);
            this.panel48.Controls.Add(this.panel50);
            this.panel48.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel48.Location = new System.Drawing.Point(0, 315);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(272, 184);
            this.panel48.TabIndex = 1;
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.btnStopXishi);
            this.panel49.Controls.Add(this.lblXiShiLot);
            this.panel49.Controls.Add(this.lblXiSHiPartNumber);
            this.panel49.Controls.Add(this.label37);
            this.panel49.Controls.Add(this.label38);
            this.panel49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel49.Location = new System.Drawing.Point(0, 52);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(272, 132);
            this.panel49.TabIndex = 1;
            // 
            // btnStopXishi
            // 
            this.btnStopXishi.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopXishi.ForeColor = System.Drawing.Color.Red;
            this.btnStopXishi.Location = new System.Drawing.Point(82, 73);
            this.btnStopXishi.Name = "btnStopXishi";
            this.btnStopXishi.Size = new System.Drawing.Size(105, 34);
            this.btnStopXishi.TabIndex = 49;
            this.btnStopXishi.Text = "终止";
            this.btnStopXishi.UseVisualStyleBackColor = true;
            this.btnStopXishi.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblXiShiLot
            // 
            this.lblXiShiLot.AutoSize = true;
            this.lblXiShiLot.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblXiShiLot.ForeColor = System.Drawing.Color.Black;
            this.lblXiShiLot.Location = new System.Drawing.Point(78, 42);
            this.lblXiShiLot.Name = "lblXiShiLot";
            this.lblXiShiLot.Size = new System.Drawing.Size(87, 19);
            this.lblXiShiLot.TabIndex = 48;
            this.lblXiShiLot.Text = "50001-0001";
            // 
            // lblXiSHiPartNumber
            // 
            this.lblXiSHiPartNumber.AutoSize = true;
            this.lblXiSHiPartNumber.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblXiSHiPartNumber.ForeColor = System.Drawing.Color.Black;
            this.lblXiSHiPartNumber.Location = new System.Drawing.Point(78, 19);
            this.lblXiSHiPartNumber.Name = "lblXiSHiPartNumber";
            this.lblXiSHiPartNumber.Size = new System.Drawing.Size(87, 19);
            this.lblXiSHiPartNumber.TabIndex = 47;
            this.lblXiSHiPartNumber.Text = "50001-0001";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(0, 20);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(64, 19);
            this.label37.TabIndex = 41;
            this.label37.Text = "原材料号:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(3, 43);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(63, 19);
            this.label38.TabIndex = 42;
            this.label38.Text = "   批次号:";
            // 
            // panel50
            // 
            this.panel50.Controls.Add(this.btnXiShiCard);
            this.panel50.Controls.Add(this.btnXiShi);
            this.panel50.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel50.Location = new System.Drawing.Point(0, 0);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(272, 52);
            this.panel50.TabIndex = 0;
            // 
            // btnXiShiCard
            // 
            this.btnXiShiCard.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnXiShiCard.Location = new System.Drawing.Point(139, 3);
            this.btnXiShiCard.Name = "btnXiShiCard";
            this.btnXiShiCard.Size = new System.Drawing.Size(126, 45);
            this.btnXiShiCard.TabIndex = 3;
            this.btnXiShiCard.Text = "打印标示卡";
            this.btnXiShiCard.UseVisualStyleBackColor = true;
            // 
            // btnXiShi
            // 
            this.btnXiShi.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXiShi.Location = new System.Drawing.Point(5, 3);
            this.btnXiShi.Name = "btnXiShi";
            this.btnXiShi.Size = new System.Drawing.Size(128, 45);
            this.btnXiShi.TabIndex = 2;
            this.btnXiShi.Text = "调漆开始";
            this.btnXiShi.UseVisualStyleBackColor = true;
            this.btnXiShi.Click += new System.EventHandler(this.btnXiShi_Click);
            // 
            // panel51
            // 
            this.panel51.Controls.Add(this.panel52);
            this.panel51.Controls.Add(this.panel53);
            this.panel51.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel51.Location = new System.Drawing.Point(0, 0);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(272, 38);
            this.panel51.TabIndex = 0;
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.lblXiShiPartWeight);
            this.panel52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel52.Location = new System.Drawing.Point(151, 0);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(121, 38);
            this.panel52.TabIndex = 2;
            // 
            // lblXiShiPartWeight
            // 
            this.lblXiShiPartWeight.BackColor = System.Drawing.Color.White;
            this.lblXiShiPartWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblXiShiPartWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXiShiPartWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblXiShiPartWeight.Location = new System.Drawing.Point(0, 0);
            this.lblXiShiPartWeight.Name = "lblXiShiPartWeight";
            this.lblXiShiPartWeight.Size = new System.Drawing.Size(121, 38);
            this.lblXiShiPartWeight.TabIndex = 44;
            this.lblXiShiPartWeight.Text = "50";
            this.lblXiShiPartWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel53
            // 
            this.panel53.Controls.Add(this.label41);
            this.panel53.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel53.Location = new System.Drawing.Point(0, 0);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(151, 38);
            this.panel53.TabIndex = 1;
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.White;
            this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label41.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label41.Location = new System.Drawing.Point(0, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(151, 38);
            this.label41.TabIndex = 0;
            this.label41.Text = "重量KG";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel54
            // 
            this.panel54.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel54.Controls.Add(this.panel55);
            this.panel54.Controls.Add(this.panel62);
            this.panel54.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel54.Location = new System.Drawing.Point(0, 0);
            this.panel54.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(272, 126);
            this.panel54.TabIndex = 0;
            // 
            // panel55
            // 
            this.panel55.Controls.Add(this.panel56);
            this.panel55.Controls.Add(this.panel59);
            this.panel55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel55.Location = new System.Drawing.Point(0, 57);
            this.panel55.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(272, 69);
            this.panel55.TabIndex = 3;
            // 
            // panel56
            // 
            this.panel56.Controls.Add(this.panel57);
            this.panel56.Controls.Add(this.panel58);
            this.panel56.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel56.Location = new System.Drawing.Point(129, 0);
            this.panel56.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel56.Name = "panel56";
            this.panel56.Size = new System.Drawing.Size(143, 69);
            this.panel56.TabIndex = 1;
            // 
            // panel57
            // 
            this.panel57.Controls.Add(this.lblXiShiHolderWeight);
            this.panel57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel57.Location = new System.Drawing.Point(0, 35);
            this.panel57.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel57.Name = "panel57";
            this.panel57.Size = new System.Drawing.Size(143, 34);
            this.panel57.TabIndex = 3;
            // 
            // lblXiShiHolderWeight
            // 
            this.lblXiShiHolderWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblXiShiHolderWeight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblXiShiHolderWeight.ForeColor = System.Drawing.Color.White;
            this.lblXiShiHolderWeight.Location = new System.Drawing.Point(0, 0);
            this.lblXiShiHolderWeight.Name = "lblXiShiHolderWeight";
            this.lblXiShiHolderWeight.Size = new System.Drawing.Size(143, 34);
            this.lblXiShiHolderWeight.TabIndex = 2;
            this.lblXiShiHolderWeight.Text = "2.9";
            this.lblXiShiHolderWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel58
            // 
            this.panel58.Controls.Add(this.label43);
            this.panel58.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel58.Location = new System.Drawing.Point(0, 0);
            this.panel58.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel58.Name = "panel58";
            this.panel58.Size = new System.Drawing.Size(143, 35);
            this.panel58.TabIndex = 2;
            // 
            // label43
            // 
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(0, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(143, 35);
            this.label43.TabIndex = 1;
            this.label43.Text = "空桶重量";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel59
            // 
            this.panel59.Controls.Add(this.panel60);
            this.panel59.Controls.Add(this.panel61);
            this.panel59.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel59.Location = new System.Drawing.Point(0, 0);
            this.panel59.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel59.Name = "panel59";
            this.panel59.Size = new System.Drawing.Size(155, 69);
            this.panel59.TabIndex = 0;
            // 
            // panel60
            // 
            this.panel60.Controls.Add(this.label44);
            this.panel60.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel60.Location = new System.Drawing.Point(0, 35);
            this.panel60.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel60.Name = "panel60";
            this.panel60.Size = new System.Drawing.Size(155, 34);
            this.panel60.TabIndex = 1;
            // 
            // label44
            // 
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(0, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(155, 34);
            this.label44.TabIndex = 1;
            this.label44.Text = "3  号";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.label45);
            this.panel61.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel61.Location = new System.Drawing.Point(0, 0);
            this.panel61.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(155, 35);
            this.panel61.TabIndex = 0;
            // 
            // label45
            // 
            this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label45.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(0, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(155, 35);
            this.label45.TabIndex = 0;
            this.label45.Text = "电子秤编号";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel62
            // 
            this.panel62.Controls.Add(this.lblXiShiPartInfo);
            this.panel62.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel62.Location = new System.Drawing.Point(0, 0);
            this.panel62.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel62.Name = "panel62";
            this.panel62.Size = new System.Drawing.Size(272, 57);
            this.panel62.TabIndex = 2;
            // 
            // lblXiShiPartInfo
            // 
            this.lblXiShiPartInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblXiShiPartInfo.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblXiShiPartInfo.ForeColor = System.Drawing.Color.White;
            this.lblXiShiPartInfo.Location = new System.Drawing.Point(0, 0);
            this.lblXiShiPartInfo.Name = "lblXiShiPartInfo";
            this.lblXiShiPartInfo.Size = new System.Drawing.Size(272, 57);
            this.lblXiShiPartInfo.TabIndex = 0;
            this.lblXiShiPartInfo.Text = "稀释剂";
            this.lblXiShiPartInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel42
            // 
            this.panel42.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel42.Location = new System.Drawing.Point(0, 0);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(13, 627);
            this.panel42.TabIndex = 1;
            // 
            // pbGuHua
            // 
            this.pbGuHua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGuHua.Controls.Add(this.panel23);
            this.pbGuHua.Controls.Add(this.panel32);
            this.pbGuHua.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbGuHua.Location = new System.Drawing.Point(0, 0);
            this.pbGuHua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbGuHua.Name = "pbGuHua";
            this.pbGuHua.Size = new System.Drawing.Size(274, 627);
            this.pbGuHua.TabIndex = 8;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Controls.Add(this.panel26);
            this.panel23.Controls.Add(this.panel29);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(0, 126);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(272, 499);
            this.panel23.TabIndex = 1;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.pbGuHuaParts);
            this.panel24.Controls.Add(this.panel64);
            this.panel24.Controls.Add(this.panel25);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(0, 38);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(272, 277);
            this.panel24.TabIndex = 2;
            // 
            // pbGuHuaParts
            // 
            cBlendItems17.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            cBlendItems17.iPoint = new float[] {
        0F,
        1F};
            this.pbGuHuaParts.BarColorBlend = cBlendItems17;
            this.pbGuHuaParts.BarColorSolid = System.Drawing.Color.Lime;
            this.pbGuHuaParts.BarColorSolidB = System.Drawing.Color.White;
            this.pbGuHuaParts.BarLengthValue = ((short)(25));
            this.pbGuHuaParts.BarPadding = new System.Windows.Forms.Padding(0);
            this.pbGuHuaParts.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.pbGuHuaParts.BarStyleHatch = System.Drawing.Drawing2D.HatchStyle.Percent70;
            this.pbGuHuaParts.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pbGuHuaParts.BarStyleTexture = null;
            this.pbGuHuaParts.BorderWidth = ((short)(1));
            this.pbGuHuaParts.Corners.All = ((short)(-1));
            this.pbGuHuaParts.Corners.LowerLeft = ((short)(0));
            this.pbGuHuaParts.Corners.LowerRight = ((short)(0));
            this.pbGuHuaParts.Corners.UpperLeft = ((short)(10));
            this.pbGuHuaParts.Corners.UpperRight = ((short)(10));
            this.pbGuHuaParts.CylonInterval = ((short)(1));
            this.pbGuHuaParts.CylonMove = 5F;
            this.pbGuHuaParts.Dock = System.Windows.Forms.DockStyle.Left;
            cFocalPoints17.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints17.CenterPoint")));
            cFocalPoints17.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints17.FocusScales")));
            this.pbGuHuaParts.FocalPoints = cFocalPoints17;
            this.pbGuHuaParts.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pbGuHuaParts.ForeColor = System.Drawing.Color.White;
            this.pbGuHuaParts.Location = new System.Drawing.Point(86, 0);
            this.pbGuHuaParts.Name = "pbGuHuaParts";
            this.pbGuHuaParts.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.pbGuHuaParts.ShapeTextFont = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.pbGuHuaParts.ShowDesignBorder = false;
            this.pbGuHuaParts.Size = new System.Drawing.Size(110, 250);
            this.pbGuHuaParts.TabIndex = 22;
            this.pbGuHuaParts.TextFormat = " {0}%";
            this.pbGuHuaParts.TextShadow = true;
            this.pbGuHuaParts.TextShadowColor = System.Drawing.Color.DarkBlue;
            this.pbGuHuaParts.TextShow = ProgBar.ProgBarPlus.eTextShow.FormatString;
            this.pbGuHuaParts.Value = 0;
            // 
            // panel64
            // 
            this.panel64.BackColor = System.Drawing.Color.Transparent;
            this.panel64.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel64.Location = new System.Drawing.Point(0, 0);
            this.panel64.Name = "panel64";
            this.panel64.Size = new System.Drawing.Size(86, 250);
            this.panel64.TabIndex = 21;
            // 
            // panel25
            // 
            this.panel25.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel25.Location = new System.Drawing.Point(0, 250);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(272, 27);
            this.panel25.TabIndex = 1;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.panel27);
            this.panel26.Controls.Add(this.panel28);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel26.Location = new System.Drawing.Point(0, 315);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(272, 184);
            this.panel26.TabIndex = 1;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.btnStopGuhua);
            this.panel27.Controls.Add(this.lblGuHuaLotNum);
            this.panel27.Controls.Add(this.lblGuHuaPartNumber);
            this.panel27.Controls.Add(this.label19);
            this.panel27.Controls.Add(this.label20);
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(0, 52);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(272, 132);
            this.panel27.TabIndex = 1;
            // 
            // btnStopGuhua
            // 
            this.btnStopGuhua.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopGuhua.ForeColor = System.Drawing.Color.Red;
            this.btnStopGuhua.Location = new System.Drawing.Point(84, 73);
            this.btnStopGuhua.Name = "btnStopGuhua";
            this.btnStopGuhua.Size = new System.Drawing.Size(105, 34);
            this.btnStopGuhua.TabIndex = 52;
            this.btnStopGuhua.Text = "终止";
            this.btnStopGuhua.UseVisualStyleBackColor = true;
            this.btnStopGuhua.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblGuHuaLotNum
            // 
            this.lblGuHuaLotNum.AutoSize = true;
            this.lblGuHuaLotNum.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGuHuaLotNum.ForeColor = System.Drawing.Color.Black;
            this.lblGuHuaLotNum.Location = new System.Drawing.Point(80, 42);
            this.lblGuHuaLotNum.Name = "lblGuHuaLotNum";
            this.lblGuHuaLotNum.Size = new System.Drawing.Size(87, 19);
            this.lblGuHuaLotNum.TabIndex = 51;
            this.lblGuHuaLotNum.Text = "50001-0001";
            // 
            // lblGuHuaPartNumber
            // 
            this.lblGuHuaPartNumber.AutoSize = true;
            this.lblGuHuaPartNumber.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGuHuaPartNumber.ForeColor = System.Drawing.Color.Black;
            this.lblGuHuaPartNumber.Location = new System.Drawing.Point(80, 19);
            this.lblGuHuaPartNumber.Name = "lblGuHuaPartNumber";
            this.lblGuHuaPartNumber.Size = new System.Drawing.Size(87, 19);
            this.lblGuHuaPartNumber.TabIndex = 50;
            this.lblGuHuaPartNumber.Text = "50001-0001";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(5, 19);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 19);
            this.label19.TabIndex = 47;
            this.label19.Text = "原材料号:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(8, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 19);
            this.label20.TabIndex = 48;
            this.label20.Text = "   批次号:";
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.btnGuHuaCard);
            this.panel28.Controls.Add(this.btnGuHua);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel28.Location = new System.Drawing.Point(0, 0);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(272, 52);
            this.panel28.TabIndex = 0;
            // 
            // btnGuHuaCard
            // 
            this.btnGuHuaCard.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGuHuaCard.Location = new System.Drawing.Point(141, 3);
            this.btnGuHuaCard.Name = "btnGuHuaCard";
            this.btnGuHuaCard.Size = new System.Drawing.Size(126, 45);
            this.btnGuHuaCard.TabIndex = 2;
            this.btnGuHuaCard.Text = "打印标示卡";
            this.btnGuHuaCard.UseVisualStyleBackColor = true;
            // 
            // btnGuHua
            // 
            this.btnGuHua.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuHua.Location = new System.Drawing.Point(5, 2);
            this.btnGuHua.Name = "btnGuHua";
            this.btnGuHua.Size = new System.Drawing.Size(130, 45);
            this.btnGuHua.TabIndex = 1;
            this.btnGuHua.Text = "开始";
            this.btnGuHua.UseVisualStyleBackColor = true;
            this.btnGuHua.Click += new System.EventHandler(this.btnGuHua_Click);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.panel30);
            this.panel29.Controls.Add(this.panel31);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel29.Location = new System.Drawing.Point(0, 0);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(272, 38);
            this.panel29.TabIndex = 0;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.lblGuHuaPartWeight);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel30.Location = new System.Drawing.Point(151, 0);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(121, 38);
            this.panel30.TabIndex = 2;
            // 
            // lblGuHuaPartWeight
            // 
            this.lblGuHuaPartWeight.BackColor = System.Drawing.Color.White;
            this.lblGuHuaPartWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGuHuaPartWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuHuaPartWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGuHuaPartWeight.Location = new System.Drawing.Point(0, 0);
            this.lblGuHuaPartWeight.Name = "lblGuHuaPartWeight";
            this.lblGuHuaPartWeight.Size = new System.Drawing.Size(121, 38);
            this.lblGuHuaPartWeight.TabIndex = 44;
            this.lblGuHuaPartWeight.Text = "50";
            this.lblGuHuaPartWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.label25);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel31.Location = new System.Drawing.Point(0, 0);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(151, 38);
            this.panel31.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(151, 38);
            this.label25.TabIndex = 0;
            this.label25.Text = "重量g";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel32.Controls.Add(this.panel33);
            this.panel32.Controls.Add(this.panel40);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel32.Location = new System.Drawing.Point(0, 0);
            this.panel32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(272, 126);
            this.panel32.TabIndex = 0;
            // 
            // panel33
            // 
            this.panel33.Controls.Add(this.panel34);
            this.panel33.Controls.Add(this.panel37);
            this.panel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel33.Location = new System.Drawing.Point(0, 57);
            this.panel33.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(272, 69);
            this.panel33.TabIndex = 3;
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.panel35);
            this.panel34.Controls.Add(this.panel36);
            this.panel34.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel34.Location = new System.Drawing.Point(129, 0);
            this.panel34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(143, 69);
            this.panel34.TabIndex = 1;
            // 
            // panel35
            // 
            this.panel35.Controls.Add(this.lblGuHuaHolderWeight);
            this.panel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel35.Location = new System.Drawing.Point(0, 35);
            this.panel35.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(143, 34);
            this.panel35.TabIndex = 3;
            // 
            // lblGuHuaHolderWeight
            // 
            this.lblGuHuaHolderWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGuHuaHolderWeight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGuHuaHolderWeight.ForeColor = System.Drawing.Color.White;
            this.lblGuHuaHolderWeight.Location = new System.Drawing.Point(0, 0);
            this.lblGuHuaHolderWeight.Name = "lblGuHuaHolderWeight";
            this.lblGuHuaHolderWeight.Size = new System.Drawing.Size(143, 34);
            this.lblGuHuaHolderWeight.TabIndex = 2;
            this.lblGuHuaHolderWeight.Text = "2.9";
            this.lblGuHuaHolderWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.label32);
            this.panel36.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel36.Location = new System.Drawing.Point(0, 0);
            this.panel36.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(143, 35);
            this.panel36.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(0, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(143, 35);
            this.label32.TabIndex = 1;
            this.label32.Text = "空桶重量";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.panel38);
            this.panel37.Controls.Add(this.panel39);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel37.Location = new System.Drawing.Point(0, 0);
            this.panel37.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(155, 69);
            this.panel37.TabIndex = 0;
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.label33);
            this.panel38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel38.Location = new System.Drawing.Point(0, 35);
            this.panel38.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(155, 34);
            this.panel38.TabIndex = 1;
            // 
            // label33
            // 
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(0, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(155, 34);
            this.label33.TabIndex = 1;
            this.label33.Text = "2  号";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.label34);
            this.panel39.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel39.Location = new System.Drawing.Point(0, 0);
            this.panel39.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(155, 35);
            this.panel39.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(0, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(155, 35);
            this.label34.TabIndex = 0;
            this.label34.Text = "电子秤编号";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.lblGuHuaPartInfo);
            this.panel40.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel40.Location = new System.Drawing.Point(0, 0);
            this.panel40.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(272, 57);
            this.panel40.TabIndex = 2;
            // 
            // lblGuHuaPartInfo
            // 
            this.lblGuHuaPartInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGuHuaPartInfo.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGuHuaPartInfo.ForeColor = System.Drawing.Color.White;
            this.lblGuHuaPartInfo.Location = new System.Drawing.Point(0, 0);
            this.lblGuHuaPartInfo.Name = "lblGuHuaPartInfo";
            this.lblGuHuaPartInfo.Size = new System.Drawing.Size(272, 57);
            this.lblGuHuaPartInfo.TabIndex = 0;
            this.lblGuHuaPartInfo.Text = "固化剂";
            this.lblGuHuaPartInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel21
            // 
            this.panel21.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(13, 627);
            this.panel21.TabIndex = 0;
            // 
            // pbMain
            // 
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Controls.Add(this.panel9);
            this.pbMain.Controls.Add(this.pnMainHead);
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbMain.Location = new System.Drawing.Point(0, 0);
            this.pbMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(274, 627);
            this.pbMain.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.panel15);
            this.panel9.Controls.Add(this.pnMainFoot);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 126);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(272, 499);
            this.panel9.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.pbMainParts);
            this.panel15.Controls.Add(this.panel63);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 38);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(272, 277);
            this.panel15.TabIndex = 2;
            // 
            // pbMainParts
            // 
            cBlendItems18.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            cBlendItems18.iPoint = new float[] {
        0F,
        1F};
            this.pbMainParts.BarColorBlend = cBlendItems18;
            this.pbMainParts.BarColorSolid = System.Drawing.Color.Lime;
            this.pbMainParts.BarColorSolidB = System.Drawing.Color.White;
            this.pbMainParts.BarLengthValue = ((short)(25));
            this.pbMainParts.BarPadding = new System.Windows.Forms.Padding(0);
            this.pbMainParts.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.pbMainParts.BarStyleHatch = System.Drawing.Drawing2D.HatchStyle.Percent70;
            this.pbMainParts.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pbMainParts.BarStyleTexture = null;
            this.pbMainParts.BorderWidth = ((short)(1));
            this.pbMainParts.Corners.All = ((short)(-1));
            this.pbMainParts.Corners.LowerLeft = ((short)(0));
            this.pbMainParts.Corners.LowerRight = ((short)(0));
            this.pbMainParts.Corners.UpperLeft = ((short)(10));
            this.pbMainParts.Corners.UpperRight = ((short)(10));
            this.pbMainParts.CylonInterval = ((short)(1));
            this.pbMainParts.CylonMove = 5F;
            this.pbMainParts.Dock = System.Windows.Forms.DockStyle.Left;
            cFocalPoints18.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints18.CenterPoint")));
            cFocalPoints18.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints18.FocusScales")));
            this.pbMainParts.FocalPoints = cFocalPoints18;
            this.pbMainParts.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pbMainParts.ForeColor = System.Drawing.Color.White;
            this.pbMainParts.Location = new System.Drawing.Point(86, 0);
            this.pbMainParts.Name = "pbMainParts";
            this.pbMainParts.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.pbMainParts.ShapeTextFont = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.pbMainParts.ShowDesignBorder = false;
            this.pbMainParts.Size = new System.Drawing.Size(110, 250);
            this.pbMainParts.TabIndex = 22;
            this.pbMainParts.TextFormat = " {0}%";
            this.pbMainParts.TextShadow = true;
            this.pbMainParts.TextShadowColor = System.Drawing.Color.DarkBlue;
            this.pbMainParts.TextShow = ProgBar.ProgBarPlus.eTextShow.FormatString;
            this.pbMainParts.Value = 0;
            // 
            // panel63
            // 
            this.panel63.BackColor = System.Drawing.Color.Transparent;
            this.panel63.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel63.Location = new System.Drawing.Point(0, 0);
            this.panel63.Name = "panel63";
            this.panel63.Size = new System.Drawing.Size(86, 250);
            this.panel63.TabIndex = 21;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(0, 250);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(272, 27);
            this.panel17.TabIndex = 0;
            // 
            // pnMainFoot
            // 
            this.pnMainFoot.Controls.Add(this.panel14);
            this.pnMainFoot.Controls.Add(this.panel13);
            this.pnMainFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnMainFoot.Location = new System.Drawing.Point(0, 315);
            this.pnMainFoot.Name = "pnMainFoot";
            this.pnMainFoot.Size = new System.Drawing.Size(272, 184);
            this.pnMainFoot.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnStopMain);
            this.panel14.Controls.Add(this.lblMainPartsLotNumber);
            this.panel14.Controls.Add(this.lblMainPartNumber);
            this.panel14.Controls.Add(this.label16);
            this.panel14.Controls.Add(this.label17);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 52);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(272, 132);
            this.panel14.TabIndex = 1;
            // 
            // btnStopMain
            // 
            this.btnStopMain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopMain.ForeColor = System.Drawing.Color.Red;
            this.btnStopMain.Location = new System.Drawing.Point(86, 73);
            this.btnStopMain.Name = "btnStopMain";
            this.btnStopMain.Size = new System.Drawing.Size(105, 34);
            this.btnStopMain.TabIndex = 46;
            this.btnStopMain.Text = "终止";
            this.btnStopMain.UseVisualStyleBackColor = true;
            this.btnStopMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMainPartsLotNumber
            // 
            this.lblMainPartsLotNumber.AutoSize = true;
            this.lblMainPartsLotNumber.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPartsLotNumber.ForeColor = System.Drawing.Color.Black;
            this.lblMainPartsLotNumber.Location = new System.Drawing.Point(79, 42);
            this.lblMainPartsLotNumber.Name = "lblMainPartsLotNumber";
            this.lblMainPartsLotNumber.Size = new System.Drawing.Size(87, 19);
            this.lblMainPartsLotNumber.TabIndex = 45;
            this.lblMainPartsLotNumber.Text = "50001-0001";
            // 
            // lblMainPartNumber
            // 
            this.lblMainPartNumber.AutoSize = true;
            this.lblMainPartNumber.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPartNumber.ForeColor = System.Drawing.Color.Black;
            this.lblMainPartNumber.Location = new System.Drawing.Point(79, 19);
            this.lblMainPartNumber.Name = "lblMainPartNumber";
            this.lblMainPartNumber.Size = new System.Drawing.Size(87, 19);
            this.lblMainPartNumber.TabIndex = 44;
            this.lblMainPartNumber.Text = "50001-0001";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(4, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 19);
            this.label16.TabIndex = 41;
            this.label16.Text = "原材料号:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(7, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 19);
            this.label17.TabIndex = 42;
            this.label17.Text = "   批次号:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btnMainCard);
            this.panel13.Controls.Add(this.btnMainPart);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(272, 52);
            this.panel13.TabIndex = 0;
            // 
            // btnMainCard
            // 
            this.btnMainCard.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMainCard.Location = new System.Drawing.Point(139, 2);
            this.btnMainCard.Name = "btnMainCard";
            this.btnMainCard.Size = new System.Drawing.Size(126, 45);
            this.btnMainCard.TabIndex = 1;
            this.btnMainCard.Text = "打印标示卡";
            this.btnMainCard.UseVisualStyleBackColor = true;
            this.btnMainCard.Click += new System.EventHandler(this.btnMainCard_Click);
            // 
            // btnMainPart
            // 
            this.btnMainPart.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPart.Location = new System.Drawing.Point(5, 2);
            this.btnMainPart.Name = "btnMainPart";
            this.btnMainPart.Size = new System.Drawing.Size(126, 45);
            this.btnMainPart.TabIndex = 0;
            this.btnMainPart.Text = "开始";
            this.btnMainPart.UseVisualStyleBackColor = true;
            this.btnMainPart.Click += new System.EventHandler(this.btnMainPart_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(272, 38);
            this.panel10.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lblMainPartWeight);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(151, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(121, 38);
            this.panel12.TabIndex = 2;
            // 
            // lblMainPartWeight
            // 
            this.lblMainPartWeight.BackColor = System.Drawing.Color.White;
            this.lblMainPartWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainPartWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPartWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMainPartWeight.Location = new System.Drawing.Point(0, 0);
            this.lblMainPartWeight.Name = "lblMainPartWeight";
            this.lblMainPartWeight.Size = new System.Drawing.Size(121, 38);
            this.lblMainPartWeight.TabIndex = 44;
            this.lblMainPartWeight.Text = "50";
            this.lblMainPartWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label11);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(151, 38);
            this.panel11.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 38);
            this.label11.TabIndex = 0;
            this.label11.Text = "重量KG";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMainHead
            // 
            this.pnMainHead.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnMainHead.Controls.Add(this.panel3);
            this.pnMainHead.Controls.Add(this.panel19);
            this.pnMainHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMainHead.Location = new System.Drawing.Point(0, 0);
            this.pnMainHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnMainHead.Name = "pnMainHead";
            this.pnMainHead.Size = new System.Drawing.Size(272, 126);
            this.pnMainHead.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 69);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(129, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(143, 69);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblMainHolderWeight);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 35);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(143, 34);
            this.panel7.TabIndex = 3;
            // 
            // lblMainHolderWeight
            // 
            this.lblMainHolderWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainHolderWeight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMainHolderWeight.ForeColor = System.Drawing.Color.White;
            this.lblMainHolderWeight.Location = new System.Drawing.Point(0, 0);
            this.lblMainHolderWeight.Name = "lblMainHolderWeight";
            this.lblMainHolderWeight.Size = new System.Drawing.Size(143, 34);
            this.lblMainHolderWeight.TabIndex = 2;
            this.lblMainHolderWeight.Text = "0.98";
            this.lblMainHolderWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(143, 35);
            this.panel8.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 35);
            this.label10.TabIndex = 1;
            this.label10.Text = "空桶重量";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel16);
            this.panel5.Controls.Add(this.panel18);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 69);
            this.panel5.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.lblMainScaleNumber);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(0, 35);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(155, 34);
            this.panel16.TabIndex = 1;
            // 
            // lblMainScaleNumber
            // 
            this.lblMainScaleNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainScaleNumber.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMainScaleNumber.ForeColor = System.Drawing.Color.White;
            this.lblMainScaleNumber.Location = new System.Drawing.Point(0, 0);
            this.lblMainScaleNumber.Name = "lblMainScaleNumber";
            this.lblMainScaleNumber.Size = new System.Drawing.Size(155, 34);
            this.lblMainScaleNumber.TabIndex = 1;
            this.lblMainScaleNumber.Text = "1  号";
            this.lblMainScaleNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.label14);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(155, 35);
            this.panel18.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 35);
            this.label14.TabIndex = 0;
            this.label14.Text = "电子秤编号";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.lblMainPartInfo);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(272, 57);
            this.panel19.TabIndex = 2;
            // 
            // lblMainPartInfo
            // 
            this.lblMainPartInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainPartInfo.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMainPartInfo.ForeColor = System.Drawing.Color.White;
            this.lblMainPartInfo.Location = new System.Drawing.Point(0, 0);
            this.lblMainPartInfo.Name = "lblMainPartInfo";
            this.lblMainPartInfo.Size = new System.Drawing.Size(272, 57);
            this.lblMainPartInfo.TabIndex = 0;
            this.lblMainPartInfo.Text = "原  油";
            this.lblMainPartInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnFrameLeft
            // 
            this.pnFrameLeft.Controls.Add(this.panel66);
            this.pnFrameLeft.Controls.Add(this.groupBox1);
            this.pnFrameLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFrameLeft.Location = new System.Drawing.Point(0, 0);
            this.pnFrameLeft.Name = "pnFrameLeft";
            this.pnFrameLeft.Size = new System.Drawing.Size(313, 627);
            this.pnFrameLeft.TabIndex = 0;
            // 
            // panel66
            // 
            this.panel66.Controls.Add(this.panel68);
            this.panel66.Controls.Add(this.panel67);
            this.panel66.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel66.Location = new System.Drawing.Point(0, 485);
            this.panel66.Name = "panel66";
            this.panel66.Size = new System.Drawing.Size(313, 142);
            this.panel66.TabIndex = 7;
            // 
            // panel68
            // 
            this.panel68.Controls.Add(this.pictureBox1);
            this.panel68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel68.Location = new System.Drawing.Point(0, 0);
            this.panel68.Name = "panel68";
            this.panel68.Size = new System.Drawing.Size(313, 116);
            this.panel68.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel67
            // 
            this.panel67.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel67.Location = new System.Drawing.Point(0, 116);
            this.panel67.Name = "panel67";
            this.panel67.Size = new System.Drawing.Size(313, 26);
            this.panel67.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSupplier);
            this.groupBox1.Controls.Add(this.txtPartNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.cmbShift);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbProductionLine);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPaintType);
            this.groupBox1.Location = new System.Drawing.Point(4, -1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(303, 529);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMainPartTargetWeight);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMainPartRaiseWeight);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.txtMainPartActualWeight);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(6, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 132);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "原油调配信息";
            // 
            // txtMainPartTargetWeight
            // 
            this.txtMainPartTargetWeight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainPartTargetWeight.Location = new System.Drawing.Point(102, 18);
            this.txtMainPartTargetWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMainPartTargetWeight.Name = "txtMainPartTargetWeight";
            this.txtMainPartTargetWeight.Size = new System.Drawing.Size(137, 29);
            this.txtMainPartTargetWeight.TabIndex = 34;
            this.txtMainPartTargetWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMainPartTargetWeight_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "计划配重";
            // 
            // txtMainPartRaiseWeight
            // 
            this.txtMainPartRaiseWeight.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMainPartRaiseWeight.DisableBackColor = System.Drawing.Color.Gainsboro;
            this.txtMainPartRaiseWeight.DisableForeColor = System.Drawing.SystemColors.Window;
            this.txtMainPartRaiseWeight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainPartRaiseWeight.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMainPartRaiseWeight.Location = new System.Drawing.Point(102, 93);
            this.txtMainPartRaiseWeight.Name = "txtMainPartRaiseWeight";
            this.txtMainPartRaiseWeight.ReadOnly = true;
            this.txtMainPartRaiseWeight.Size = new System.Drawing.Size(139, 29);
            this.txtMainPartRaiseWeight.TabIndex = 54;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(248, 23);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 19);
            this.label30.TabIndex = 47;
            this.label30.Text = "KG";
            // 
            // txtMainPartActualWeight
            // 
            this.txtMainPartActualWeight.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMainPartActualWeight.DisableBackColor = System.Drawing.Color.Gainsboro;
            this.txtMainPartActualWeight.DisableForeColor = System.Drawing.SystemColors.Window;
            this.txtMainPartActualWeight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainPartActualWeight.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMainPartActualWeight.Location = new System.Drawing.Point(102, 56);
            this.txtMainPartActualWeight.Name = "txtMainPartActualWeight";
            this.txtMainPartActualWeight.ReadOnly = true;
            this.txtMainPartActualWeight.Size = new System.Drawing.Size(139, 29);
            this.txtMainPartActualWeight.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "实际配重";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "差       重";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(248, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 19);
            this.label13.TabIndex = 49;
            this.label13.Text = "KG";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(248, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 19);
            this.label12.TabIndex = 48;
            this.label12.Text = "KG";
            // 
            // txtSupplier
            // 
            this.txtSupplier.DisableBackColor = System.Drawing.Color.White;
            this.txtSupplier.DisableForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSupplier.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSupplier.Location = new System.Drawing.Point(108, 163);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(173, 43);
            this.txtSupplier.TabIndex = 55;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.DisableBackColor = System.Drawing.Color.White;
            this.txtPartNumber.DisableForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPartNumber.Enabled = false;
            this.txtPartNumber.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPartNumber.Location = new System.Drawing.Point(106, 114);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(144, 43);
            this.txtPartNumber.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "机      种";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmit.Location = new System.Drawing.Point(45, 448);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(205, 69);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "开始搅拌";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbShift
            // 
            this.cmbShift.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "早班",
            "中班",
            "晚班"});
            this.cmbShift.Location = new System.Drawing.Point(108, 16);
            this.cmbShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(173, 43);
            this.cmbShift.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "班      次";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "产      线";
            // 
            // cmbProductionLine
            // 
            this.cmbProductionLine.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbProductionLine.FormattingEnabled = true;
            this.cmbProductionLine.Items.AddRange(new object[] {
            "早班",
            "中班",
            "晚班"});
            this.cmbProductionLine.Location = new System.Drawing.Point(107, 63);
            this.cmbProductionLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProductionLine.Name = "cmbProductionLine";
            this.cmbProductionLine.Size = new System.Drawing.Size(173, 43);
            this.cmbProductionLine.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.White;
            this.btnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.Color.Blue;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.Location = new System.Drawing.Point(248, 114);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(34, 40);
            this.btnQuery.TabIndex = 25;
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "厂      商";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "喷漆类型";
            // 
            // lblPaintType
            // 
            this.lblPaintType.BackColor = System.Drawing.Color.White;
            this.lblPaintType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaintType.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintType.ForeColor = System.Drawing.Color.Black;
            this.lblPaintType.Location = new System.Drawing.Point(107, 215);
            this.lblPaintType.Name = "lblPaintType";
            this.lblPaintType.Size = new System.Drawing.Size(175, 74);
            this.lblPaintType.TabIndex = 30;
            this.lblPaintType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spPortMain
            // 
            this.spPortMain.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spPortMain_DataReceived);
            // 
            // spPortGuHua
            // 
            this.spPortGuHua.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spPortGuHua_DataReceived);
            // 
            // spPortXiShi
            // 
            this.spPortXiShi.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spPortXiShi_DataReceived);
            // 
            // lnkLblAccount
            // 
            this.lnkLblAccount.AutoSize = true;
            this.lnkLblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lnkLblAccount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkLblAccount.Location = new System.Drawing.Point(1115, 42);
            this.lnkLblAccount.Name = "lnkLblAccount";
            this.lnkLblAccount.Size = new System.Drawing.Size(42, 21);
            this.lnkLblAccount.TabIndex = 5;
            this.lnkLblAccount.TabStop = true;
            this.lnkLblAccount.Text = "客户";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWelcome.Location = new System.Drawing.Point(1040, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(74, 21);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "欢迎您，";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 733);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lnkLblAccount);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "调漆工艺管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.Leave += new System.EventHandler(this.FrmMain_Leave);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnScale.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnFrameRight.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel41.ResumeLayout(false);
            this.panel43.ResumeLayout(false);
            this.panel44.ResumeLayout(false);
            this.panel45.ResumeLayout(false);
            this.panel46.ResumeLayout(false);
            this.panel48.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            this.panel49.PerformLayout();
            this.panel50.ResumeLayout(false);
            this.panel51.ResumeLayout(false);
            this.panel52.ResumeLayout(false);
            this.panel53.ResumeLayout(false);
            this.panel54.ResumeLayout(false);
            this.panel55.ResumeLayout(false);
            this.panel56.ResumeLayout(false);
            this.panel57.ResumeLayout(false);
            this.panel58.ResumeLayout(false);
            this.panel59.ResumeLayout(false);
            this.panel60.ResumeLayout(false);
            this.panel61.ResumeLayout(false);
            this.panel62.ResumeLayout(false);
            this.pbGuHua.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel33.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.panel35.ResumeLayout(false);
            this.panel36.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            this.panel38.ResumeLayout(false);
            this.panel39.ResumeLayout(false);
            this.panel40.ResumeLayout(false);
            this.pbMain.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.pnMainFoot.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.pnMainHead.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.pnFrameLeft.ResumeLayout(false);
            this.panel66.ResumeLayout(false);
            this.panel68.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbUserMainten;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbOptionSettings;
        private System.Windows.Forms.ToolStripButton tsbProductionMainten;
        private System.Windows.Forms.ToolStripButton tsbBOMMainten;
        private System.Windows.Forms.ToolStripButton tsbAbout;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem smConfig;
        private System.Windows.Forms.ToolStripMenuItem smUserMainten;
        private System.Windows.Forms.ToolStripMenuItem msProductionSettings;
        private System.Windows.Forms.ToolStripMenuItem msBOMMainten;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem msSystemSettings;
        private System.Windows.Forms.ToolStripMenuItem msDebug;
        private System.Windows.Forms.ToolStripMenuItem msPrint;
        private System.Windows.Forms.ToolStripMenuItem msRS232;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msDataExport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserType;
        private System.Windows.Forms.ToolStripButton tsbChangePSW;
        private System.Windows.Forms.ToolStripMenuItem msChangePSW;
        private System.Windows.Forms.ToolStripStatusLabel tsslUserInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnScale;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ToolStripMenuItem tsSpeedInput;
        private System.IO.Ports.SerialPort spPortMain;
        private System.IO.Ports.SerialPort spPortGuHua;
        private System.IO.Ports.SerialPort spPortXiShi;
        private System.Windows.Forms.Panel pnFrameLeft;
        private System.Windows.Forms.Panel pnFrameRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbProductionLine;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPaintType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMainPartTargetWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel pbMain;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel pnMainFoot;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblMainPartsLotNumber;
        private System.Windows.Forms.Label lblMainPartNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblMainPartWeight;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnMainHead;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblMainHolderWeight;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblMainScaleNumber;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label lblMainPartInfo;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Panel pbGuHua;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label lblGuHuaLotNum;
        private System.Windows.Forms.Label lblGuHuaPartNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label lblGuHuaPartWeight;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Label lblGuHuaHolderWeight;
        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel37;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Label lblGuHuaPartInfo;
        private System.Windows.Forms.Panel panel44;
        private System.Windows.Forms.Panel panel45;
        private System.Windows.Forms.Panel panel46;
        private System.Windows.Forms.Panel panel48;
        private System.Windows.Forms.Panel panel49;
        private System.Windows.Forms.Label lblXiShiLot;
        private System.Windows.Forms.Label lblXiSHiPartNumber;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel panel50;
        private System.Windows.Forms.Panel panel51;
        private System.Windows.Forms.Panel panel52;
        private System.Windows.Forms.Label lblXiShiPartWeight;
        private System.Windows.Forms.Panel panel53;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel54;
        private System.Windows.Forms.Panel panel55;
        private System.Windows.Forms.Panel panel56;
        private System.Windows.Forms.Panel panel57;
        private System.Windows.Forms.Label lblXiShiHolderWeight;
        private System.Windows.Forms.Panel panel58;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Panel panel59;
        private System.Windows.Forms.Panel panel60;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panel62;
        private System.Windows.Forms.Label lblXiShiPartInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel17;
        internal ProgBar.ProgBarPlus pbMainParts;
        private System.Windows.Forms.Panel panel63;
        internal ProgBar.ProgBarPlus pbGuHuaParts;
        private System.Windows.Forms.Panel panel64;
        internal ProgBar.ProgBarPlus pbXiShiParts;
        private System.Windows.Forms.Panel panel65;
        private MyControls.NTextBox txtMainPartRaiseWeight;
        private MyControls.NTextBox txtMainPartActualWeight;
        private MyControls.NTextBox txtPartNumber;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private MyControls.NTextBox txtSupplier;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnMainPart;
        private System.Windows.Forms.Button btnGuHua;
        private System.Windows.Forms.Button btnXiShi;
        private System.Windows.Forms.Panel panel66;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel68;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel67;
        private System.Windows.Forms.ToolStripMenuItem bOM上传ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msOilPaintType;
        private System.Windows.Forms.ToolStripMenuItem msCustomer;
        private System.Windows.Forms.LinkLabel lnkLblAccount;
        private System.Windows.Forms.Label lblWelcome;
        private Button btnStopXishi;
        private Button btnStopGuhua;
        private Button btnStopMain;
        private Button btnXiShiCard;
        private Button btnGuHuaCard;
        private Button btnMainCard;
    }
}

