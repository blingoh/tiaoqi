namespace 调漆工艺管理系统
{
    partial class FrmTaskQuery
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgTaskRecord = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExportSumary = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProductionLine = new System.Windows.Forms.ComboBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.txtMainPartNumber = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbCheckBox = new System.Windows.Forms.GroupBox();
            this.plCheckBox = new System.Windows.Forms.Panel();
            this.biaozhunPercent = new System.Windows.Forms.CheckBox();
            this.actualPercent = new System.Windows.Forms.CheckBox();
            this.btnNoSelectAll = new System.Windows.Forms.Button();
            this.cbXiShiHolderWeight = new System.Windows.Forms.CheckBox();
            this.cbGuHuaHolderWeight = new System.Windows.Forms.CheckBox();
            this.cbMainHolderWeight = new System.Windows.Forms.CheckBox();
            this.cbCustomer = new System.Windows.Forms.CheckBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.cbSpeedResult = new System.Windows.Forms.CheckBox();
            this.cbDelayTime = new System.Windows.Forms.CheckBox();
            this.cbXiShiActualRate = new System.Windows.Forms.CheckBox();
            this.cbXiShiSPECL = new System.Windows.Forms.CheckBox();
            this.cbXiShiSPECU = new System.Windows.Forms.CheckBox();
            this.cbGuHuaActualRate = new System.Windows.Forms.CheckBox();
            this.cbGuHuaDefinePercent = new System.Windows.Forms.CheckBox();
            this.cbXiShiWeight = new System.Windows.Forms.CheckBox();
            this.cbXiShiLot = new System.Windows.Forms.CheckBox();
            this.cbXiShiPartNumber = new System.Windows.Forms.CheckBox();
            this.cbXiShiVendor = new System.Windows.Forms.CheckBox();
            this.cbGuHuaWeight = new System.Windows.Forms.CheckBox();
            this.cbGuHuaLot = new System.Windows.Forms.CheckBox();
            this.cbGuHuaPartNumber = new System.Windows.Forms.CheckBox();
            this.cbGuHuaVendor = new System.Windows.Forms.CheckBox();
            this.cbMainPartWeight = new System.Windows.Forms.CheckBox();
            this.cbMainPartLot = new System.Windows.Forms.CheckBox();
            this.cbMainPartNumber = new System.Windows.Forms.CheckBox();
            this.cbMainVendor = new System.Windows.Forms.CheckBox();
            this.cbSupplier = new System.Windows.Forms.CheckBox();
            this.cbPartNumber = new System.Windows.Forms.CheckBox();
            this.cbShift = new System.Windows.Forms.CheckBox();
            this.cbLine = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskRecord)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbCheckBox.SuspendLayout();
            this.plCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 444);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgTaskRecord);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 266);
            this.panel3.TabIndex = 1;
            // 
            // dgTaskRecord
            // 
            this.dgTaskRecord.AllowUserToAddRows = false;
            this.dgTaskRecord.AllowUserToDeleteRows = false;
            this.dgTaskRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaskRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTaskRecord.Location = new System.Drawing.Point(0, 0);
            this.dgTaskRecord.Name = "dgTaskRecord";
            this.dgTaskRecord.ReadOnly = true;
            this.dgTaskRecord.Size = new System.Drawing.Size(1042, 266);
            this.dgTaskRecord.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 178);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 178);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtEnd);
            this.tabPage1.Controls.Add(this.dtStart);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnExportSumary);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmbStatus);
            this.tabPage1.Controls.Add(this.cmbShift);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSupplier);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbProductionLine);
            this.tabPage1.Controls.Add(this.txtPartNumber);
            this.tabPage1.Controls.Add(this.txtMainPartNumber);
            this.tabPage1.Controls.Add(this.btnExport);
            this.tabPage1.Controls.Add(this.btnQuery);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbOperator);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "yyyy-MM-dd";
            this.dtEnd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(703, 97);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(147, 33);
            this.dtEnd.TabIndex = 55;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "yyyy-MM-dd";
            this.dtStart.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(703, 49);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(147, 33);
            this.dtStart.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(613, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "结束时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(613, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "开始时间";
            // 
            // btnExportSumary
            // 
            this.btnExportSumary.ForeColor = System.Drawing.Color.Blue;
            this.btnExportSumary.Location = new System.Drawing.Point(893, 112);
            this.btnExportSumary.Name = "btnExportSumary";
            this.btnExportSumary.Size = new System.Drawing.Size(118, 37);
            this.btnExportSumary.TabIndex = 51;
            this.btnExportSumary.Text = "导出汇总";
            this.btnExportSumary.UseVisualStyleBackColor = true;
            this.btnExportSumary.Click += new System.EventHandler(this.btnExportSumary_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(613, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "状        态";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "完成",
            "未完成"});
            this.cmbStatus.Location = new System.Drawing.Point(702, 8);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(149, 28);
            this.cmbStatus.TabIndex = 49;
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "",
            "早班",
            "中班",
            "晚班"});
            this.cmbShift.Location = new System.Drawing.Point(109, 9);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(149, 28);
            this.cmbShift.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(15, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "机        种";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "班        次";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(416, 91);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(149, 26);
            this.txtSupplier.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "产        线";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(308, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "厂       商";
            // 
            // cmbProductionLine
            // 
            this.cmbProductionLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductionLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductionLine.FormattingEnabled = true;
            this.cmbProductionLine.Items.AddRange(new object[] {
            "早班",
            "中班",
            "晚班"});
            this.cmbProductionLine.Location = new System.Drawing.Point(109, 48);
            this.cmbProductionLine.Name = "cmbProductionLine";
            this.cmbProductionLine.Size = new System.Drawing.Size(149, 28);
            this.cmbProductionLine.TabIndex = 44;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNumber.Location = new System.Drawing.Point(109, 90);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(149, 26);
            this.txtPartNumber.TabIndex = 45;
            // 
            // txtMainPartNumber
            // 
            this.txtMainPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainPartNumber.Location = new System.Drawing.Point(416, 10);
            this.txtMainPartNumber.Name = "txtMainPartNumber";
            this.txtMainPartNumber.Size = new System.Drawing.Size(149, 26);
            this.txtMainPartNumber.TabIndex = 35;
            // 
            // btnExport
            // 
            this.btnExport.ForeColor = System.Drawing.Color.Blue;
            this.btnExport.Location = new System.Drawing.Point(893, 62);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(118, 37);
            this.btnExport.TabIndex = 38;
            this.btnExport.Text = "导出明细";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.ForeColor = System.Drawing.Color.Blue;
            this.btnQuery.Location = new System.Drawing.Point(893, 10);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(118, 37);
            this.btnQuery.TabIndex = 37;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(312, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "作业员";
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "早班",
            "中班",
            "晚班"});
            this.cmbOperator.Location = new System.Drawing.Point(416, 49);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(149, 28);
            this.cmbOperator.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(312, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "主剂料号";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbCheckBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 152);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "选项设定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbCheckBox
            // 
            this.gbCheckBox.Controls.Add(this.plCheckBox);
            this.gbCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCheckBox.Location = new System.Drawing.Point(3, 3);
            this.gbCheckBox.Name = "gbCheckBox";
            this.gbCheckBox.Size = new System.Drawing.Size(1028, 146);
            this.gbCheckBox.TabIndex = 0;
            this.gbCheckBox.TabStop = false;
            // 
            // plCheckBox
            // 
            this.plCheckBox.Controls.Add(this.biaozhunPercent);
            this.plCheckBox.Controls.Add(this.actualPercent);
            this.plCheckBox.Controls.Add(this.btnNoSelectAll);
            this.plCheckBox.Controls.Add(this.cbXiShiHolderWeight);
            this.plCheckBox.Controls.Add(this.cbGuHuaHolderWeight);
            this.plCheckBox.Controls.Add(this.cbMainHolderWeight);
            this.plCheckBox.Controls.Add(this.cbCustomer);
            this.plCheckBox.Controls.Add(this.btnSelectAll);
            this.plCheckBox.Controls.Add(this.cbSpeedResult);
            this.plCheckBox.Controls.Add(this.cbDelayTime);
            this.plCheckBox.Controls.Add(this.cbXiShiActualRate);
            this.plCheckBox.Controls.Add(this.cbXiShiSPECL);
            this.plCheckBox.Controls.Add(this.cbXiShiSPECU);
            this.plCheckBox.Controls.Add(this.cbGuHuaActualRate);
            this.plCheckBox.Controls.Add(this.cbGuHuaDefinePercent);
            this.plCheckBox.Controls.Add(this.cbXiShiWeight);
            this.plCheckBox.Controls.Add(this.cbXiShiLot);
            this.plCheckBox.Controls.Add(this.cbXiShiPartNumber);
            this.plCheckBox.Controls.Add(this.cbXiShiVendor);
            this.plCheckBox.Controls.Add(this.cbGuHuaWeight);
            this.plCheckBox.Controls.Add(this.cbGuHuaLot);
            this.plCheckBox.Controls.Add(this.cbGuHuaPartNumber);
            this.plCheckBox.Controls.Add(this.cbGuHuaVendor);
            this.plCheckBox.Controls.Add(this.cbMainPartWeight);
            this.plCheckBox.Controls.Add(this.cbMainPartLot);
            this.plCheckBox.Controls.Add(this.cbMainPartNumber);
            this.plCheckBox.Controls.Add(this.cbMainVendor);
            this.plCheckBox.Controls.Add(this.cbSupplier);
            this.plCheckBox.Controls.Add(this.cbPartNumber);
            this.plCheckBox.Controls.Add(this.cbShift);
            this.plCheckBox.Controls.Add(this.cbLine);
            this.plCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plCheckBox.Location = new System.Drawing.Point(3, 17);
            this.plCheckBox.Name = "plCheckBox";
            this.plCheckBox.Size = new System.Drawing.Size(1022, 126);
            this.plCheckBox.TabIndex = 0;
            // 
            // biaozhunPercent
            // 
            this.biaozhunPercent.AutoSize = true;
            this.biaozhunPercent.ForeColor = System.Drawing.Color.Blue;
            this.biaozhunPercent.Location = new System.Drawing.Point(142, 52);
            this.biaozhunPercent.Name = "biaozhunPercent";
            this.biaozhunPercent.Size = new System.Drawing.Size(120, 16);
            this.biaozhunPercent.TabIndex = 56;
            this.biaozhunPercent.Text = "标准比例(固：稀)";
            this.biaozhunPercent.UseVisualStyleBackColor = true;
            // 
            // actualPercent
            // 
            this.actualPercent.AutoSize = true;
            this.actualPercent.ForeColor = System.Drawing.Color.Blue;
            this.actualPercent.Location = new System.Drawing.Point(142, 31);
            this.actualPercent.Name = "actualPercent";
            this.actualPercent.Size = new System.Drawing.Size(120, 16);
            this.actualPercent.TabIndex = 55;
            this.actualPercent.Text = "实际比例(固：稀)";
            this.actualPercent.UseVisualStyleBackColor = true;
            this.actualPercent.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnNoSelectAll
            // 
            this.btnNoSelectAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNoSelectAll.Location = new System.Drawing.Point(899, 75);
            this.btnNoSelectAll.Name = "btnNoSelectAll";
            this.btnNoSelectAll.Size = new System.Drawing.Size(69, 35);
            this.btnNoSelectAll.TabIndex = 54;
            this.btnNoSelectAll.Text = "全不选";
            this.btnNoSelectAll.UseVisualStyleBackColor = true;
            this.btnNoSelectAll.Click += new System.EventHandler(this.btnNoSelectAll_Click);
            // 
            // cbXiShiHolderWeight
            // 
            this.cbXiShiHolderWeight.ForeColor = System.Drawing.Color.Blue;
            this.cbXiShiHolderWeight.Location = new System.Drawing.Point(540, 32);
            this.cbXiShiHolderWeight.Name = "cbXiShiHolderWeight";
            this.cbXiShiHolderWeight.Size = new System.Drawing.Size(113, 16);
            this.cbXiShiHolderWeight.TabIndex = 53;
            this.cbXiShiHolderWeight.Text = "稀释剂容器重量";
            this.cbXiShiHolderWeight.UseVisualStyleBackColor = true;
            // 
            // cbGuHuaHolderWeight
            // 
            this.cbGuHuaHolderWeight.ForeColor = System.Drawing.Color.Blue;
            this.cbGuHuaHolderWeight.Location = new System.Drawing.Point(390, 32);
            this.cbGuHuaHolderWeight.Name = "cbGuHuaHolderWeight";
            this.cbGuHuaHolderWeight.Size = new System.Drawing.Size(113, 16);
            this.cbGuHuaHolderWeight.TabIndex = 52;
            this.cbGuHuaHolderWeight.Text = "固化剂容器重量";
            this.cbGuHuaHolderWeight.UseVisualStyleBackColor = true;
            // 
            // cbMainHolderWeight
            // 
            this.cbMainHolderWeight.ForeColor = System.Drawing.Color.Blue;
            this.cbMainHolderWeight.Location = new System.Drawing.Point(262, 32);
            this.cbMainHolderWeight.Name = "cbMainHolderWeight";
            this.cbMainHolderWeight.Size = new System.Drawing.Size(102, 16);
            this.cbMainHolderWeight.TabIndex = 51;
            this.cbMainHolderWeight.Text = "主剂容器重量";
            this.cbMainHolderWeight.UseVisualStyleBackColor = true;
            // 
            // cbCustomer
            // 
            this.cbCustomer.ForeColor = System.Drawing.Color.Blue;
            this.cbCustomer.Location = new System.Drawing.Point(19, 97);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(90, 16);
            this.cbCustomer.TabIndex = 50;
            this.cbCustomer.Text = "客户";
            this.cbCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelectAll.Location = new System.Drawing.Point(899, 14);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(69, 35);
            this.btnSelectAll.TabIndex = 49;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // cbSpeedResult
            // 
            this.cbSpeedResult.ForeColor = System.Drawing.Color.Blue;
            this.cbSpeedResult.Location = new System.Drawing.Point(688, 76);
            this.cbSpeedResult.Name = "cbSpeedResult";
            this.cbSpeedResult.Size = new System.Drawing.Size(136, 16);
            this.cbSpeedResult.TabIndex = 47;
            this.cbSpeedResult.Text = "流速";
            this.cbSpeedResult.UseVisualStyleBackColor = true;
            // 
            // cbDelayTime
            // 
            this.cbDelayTime.ForeColor = System.Drawing.Color.Blue;
            this.cbDelayTime.Location = new System.Drawing.Point(688, 55);
            this.cbDelayTime.Name = "cbDelayTime";
            this.cbDelayTime.Size = new System.Drawing.Size(136, 16);
            this.cbDelayTime.TabIndex = 46;
            this.cbDelayTime.Text = "搅拌时间";
            this.cbDelayTime.UseVisualStyleBackColor = true;
            // 
            // cbXiShiActualRate
            // 
            this.cbXiShiActualRate.ForeColor = System.Drawing.Color.Blue;
            this.cbXiShiActualRate.Location = new System.Drawing.Point(688, 32);
            this.cbXiShiActualRate.Name = "cbXiShiActualRate";
            this.cbXiShiActualRate.Size = new System.Drawing.Size(136, 17);
            this.cbXiShiActualRate.TabIndex = 45;
            this.cbXiShiActualRate.Text = "稀释剂实际添加比例";
            this.cbXiShiActualRate.UseVisualStyleBackColor = true;
            // 
            // cbXiShiSPECL
            // 
            this.cbXiShiSPECL.ForeColor = System.Drawing.Color.Blue;
            this.cbXiShiSPECL.Location = new System.Drawing.Point(540, 97);
            this.cbXiShiSPECL.Name = "cbXiShiSPECL";
            this.cbXiShiSPECL.Size = new System.Drawing.Size(136, 16);
            this.cbXiShiSPECL.TabIndex = 44;
            this.cbXiShiSPECL.Text = "稀释剂设定比例下限";
            this.cbXiShiSPECL.UseVisualStyleBackColor = true;
            // 
            // cbXiShiSPECU
            // 
            this.cbXiShiSPECU.ForeColor = System.Drawing.Color.Blue;
            this.cbXiShiSPECU.Location = new System.Drawing.Point(540, 76);
            this.cbXiShiSPECU.Name = "cbXiShiSPECU";
            this.cbXiShiSPECU.Size = new System.Drawing.Size(136, 16);
            this.cbXiShiSPECU.TabIndex = 43;
            this.cbXiShiSPECU.Text = "稀释剂设定比例上限";
            this.cbXiShiSPECU.UseVisualStyleBackColor = true;
            // 
            // cbGuHuaActualRate
            // 
            this.cbGuHuaActualRate.ForeColor = System.Drawing.Color.Blue;
            this.cbGuHuaActualRate.Location = new System.Drawing.Point(390, 75);
            this.cbGuHuaActualRate.Name = "cbGuHuaActualRate";
            this.cbGuHuaActualRate.Size = new System.Drawing.Size(136, 16);
            this.cbGuHuaActualRate.TabIndex = 42;
            this.cbGuHuaActualRate.Text = "固化剂实际添加比例";
            this.cbGuHuaActualRate.UseVisualStyleBackColor = true;
            // 
            // cbGuHuaDefinePercent
            // 
            this.cbGuHuaDefinePercent.ForeColor = System.Drawing.Color.Blue;
            this.cbGuHuaDefinePercent.Location = new System.Drawing.Point(390, 54);
            this.cbGuHuaDefinePercent.Name = "cbGuHuaDefinePercent";
            this.cbGuHuaDefinePercent.Size = new System.Drawing.Size(136, 17);
            this.cbGuHuaDefinePercent.TabIndex = 41;
            this.cbGuHuaDefinePercent.Text = "固化剂设定添加比例";
            this.cbGuHuaDefinePercent.UseVisualStyleBackColor = true;
            // 
            // cbXiShiWeight
            // 
            this.cbXiShiWeight.ForeColor = System.Drawing.Color.Blue;
            this.cbXiShiWeight.Location = new System.Drawing.Point(688, 11);
            this.cbXiShiWeight.Name = "cbXiShiWeight";
            this.cbXiShiWeight.Size = new System.Drawing.Size(90, 16);
            this.cbXiShiWeight.TabIndex = 40;
            this.cbXiShiWeight.Text = "稀释剂重量";
            this.cbXiShiWeight.UseVisualStyleBackColor = true;
            // 
            // cbXiShiLot
            // 
            this.cbXiShiLot.ForeColor = System.Drawing.Color.Blue;
            this.cbXiShiLot.Location = new System.Drawing.Point(540, 53);
            this.cbXiShiLot.Name = "cbXiShiLot";
            this.cbXiShiLot.Size = new System.Drawing.Size(90, 16);
            this.cbXiShiLot.TabIndex = 39;
            this.cbXiShiLot.Text = "稀释剂批次号";
            this.cbXiShiLot.UseVisualStyleBackColor = true;
            // 
            // cbXiShiPartNumber
            // 
            this.cbXiShiPartNumber.ForeColor = System.Drawing.Color.Blue;
            this.cbXiShiPartNumber.Location = new System.Drawing.Point(540, 11);
            this.cbXiShiPartNumber.Name = "cbXiShiPartNumber";
            this.cbXiShiPartNumber.Size = new System.Drawing.Size(90, 16);
            this.cbXiShiPartNumber.TabIndex = 38;
            this.cbXiShiPartNumber.Text = "稀释剂料号";
            this.cbXiShiPartNumber.UseVisualStyleBackColor = true;
            // 
            // cbXiShiVendor
            // 
            this.cbXiShiVendor.ForeColor = System.Drawing.Color.Blue;
            this.cbXiShiVendor.Location = new System.Drawing.Point(390, 96);
            this.cbXiShiVendor.Name = "cbXiShiVendor";
            this.cbXiShiVendor.Size = new System.Drawing.Size(113, 17);
            this.cbXiShiVendor.TabIndex = 37;
            this.cbXiShiVendor.Text = "稀释剂生产厂商";
            this.cbXiShiVendor.UseVisualStyleBackColor = true;
            // 
            // cbGuHuaWeight
            // 
            this.cbGuHuaWeight.ForeColor = System.Drawing.Color.Blue;
            this.cbGuHuaWeight.Location = new System.Drawing.Point(390, 11);
            this.cbGuHuaWeight.Name = "cbGuHuaWeight";
            this.cbGuHuaWeight.Size = new System.Drawing.Size(136, 16);
            this.cbGuHuaWeight.TabIndex = 40;
            this.cbGuHuaWeight.Text = "固化剂重量(kg)";
            this.cbGuHuaWeight.UseVisualStyleBackColor = true;
            // 
            // cbGuHuaLot
            // 
            this.cbGuHuaLot.ForeColor = System.Drawing.Color.Blue;
            this.cbGuHuaLot.Location = new System.Drawing.Point(262, 96);
            this.cbGuHuaLot.Name = "cbGuHuaLot";
            this.cbGuHuaLot.Size = new System.Drawing.Size(90, 16);
            this.cbGuHuaLot.TabIndex = 35;
            this.cbGuHuaLot.Text = "固化剂批次号";
            this.cbGuHuaLot.UseVisualStyleBackColor = true;
            // 
            // cbGuHuaPartNumber
            // 
            this.cbGuHuaPartNumber.ForeColor = System.Drawing.Color.Blue;
            this.cbGuHuaPartNumber.Location = new System.Drawing.Point(262, 75);
            this.cbGuHuaPartNumber.Name = "cbGuHuaPartNumber";
            this.cbGuHuaPartNumber.Size = new System.Drawing.Size(90, 16);
            this.cbGuHuaPartNumber.TabIndex = 34;
            this.cbGuHuaPartNumber.Text = "固化剂料号";
            this.cbGuHuaPartNumber.UseVisualStyleBackColor = true;
            // 
            // cbGuHuaVendor
            // 
            this.cbGuHuaVendor.ForeColor = System.Drawing.Color.Blue;
            this.cbGuHuaVendor.Location = new System.Drawing.Point(262, 54);
            this.cbGuHuaVendor.Name = "cbGuHuaVendor";
            this.cbGuHuaVendor.Size = new System.Drawing.Size(113, 17);
            this.cbGuHuaVendor.TabIndex = 33;
            this.cbGuHuaVendor.Text = "固化剂生产厂商";
            this.cbGuHuaVendor.UseVisualStyleBackColor = true;
            // 
            // cbMainPartWeight
            // 
            this.cbMainPartWeight.ForeColor = System.Drawing.Color.Blue;
            this.cbMainPartWeight.Location = new System.Drawing.Point(262, 11);
            this.cbMainPartWeight.Name = "cbMainPartWeight";
            this.cbMainPartWeight.Size = new System.Drawing.Size(90, 16);
            this.cbMainPartWeight.TabIndex = 32;
            this.cbMainPartWeight.Text = "主剂重量";
            this.cbMainPartWeight.UseVisualStyleBackColor = true;
            // 
            // cbMainPartLot
            // 
            this.cbMainPartLot.ForeColor = System.Drawing.Color.Blue;
            this.cbMainPartLot.Location = new System.Drawing.Point(142, 96);
            this.cbMainPartLot.Name = "cbMainPartLot";
            this.cbMainPartLot.Size = new System.Drawing.Size(90, 16);
            this.cbMainPartLot.TabIndex = 31;
            this.cbMainPartLot.Text = "主剂批次号";
            this.cbMainPartLot.UseVisualStyleBackColor = true;
            // 
            // cbMainPartNumber
            // 
            this.cbMainPartNumber.ForeColor = System.Drawing.Color.Blue;
            this.cbMainPartNumber.Location = new System.Drawing.Point(142, 75);
            this.cbMainPartNumber.Name = "cbMainPartNumber";
            this.cbMainPartNumber.Size = new System.Drawing.Size(90, 16);
            this.cbMainPartNumber.TabIndex = 30;
            this.cbMainPartNumber.Text = "主剂料号";
            this.cbMainPartNumber.UseVisualStyleBackColor = true;
            // 
            // cbMainVendor
            // 
            this.cbMainVendor.ForeColor = System.Drawing.Color.Blue;
            this.cbMainVendor.Location = new System.Drawing.Point(142, 12);
            this.cbMainVendor.Name = "cbMainVendor";
            this.cbMainVendor.Size = new System.Drawing.Size(102, 17);
            this.cbMainVendor.TabIndex = 29;
            this.cbMainVendor.Text = "主剂生产厂商";
            this.cbMainVendor.UseVisualStyleBackColor = true;
            // 
            // cbSupplier
            // 
            this.cbSupplier.ForeColor = System.Drawing.Color.Blue;
            this.cbSupplier.Location = new System.Drawing.Point(19, 76);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(90, 16);
            this.cbSupplier.TabIndex = 28;
            this.cbSupplier.Text = "厂商";
            this.cbSupplier.UseVisualStyleBackColor = true;
            // 
            // cbPartNumber
            // 
            this.cbPartNumber.ForeColor = System.Drawing.Color.Blue;
            this.cbPartNumber.Location = new System.Drawing.Point(19, 54);
            this.cbPartNumber.Name = "cbPartNumber";
            this.cbPartNumber.Size = new System.Drawing.Size(90, 16);
            this.cbPartNumber.TabIndex = 27;
            this.cbPartNumber.Text = "机种";
            this.cbPartNumber.UseVisualStyleBackColor = true;
            // 
            // cbShift
            // 
            this.cbShift.ForeColor = System.Drawing.Color.Blue;
            this.cbShift.Location = new System.Drawing.Point(19, 33);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(90, 16);
            this.cbShift.TabIndex = 26;
            this.cbShift.Text = "班次";
            this.cbShift.UseVisualStyleBackColor = true;
            // 
            // cbLine
            // 
            this.cbLine.ForeColor = System.Drawing.Color.Blue;
            this.cbLine.Location = new System.Drawing.Point(19, 12);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(90, 17);
            this.cbLine.TabIndex = 25;
            this.cbLine.Text = "产线";
            this.cbLine.UseVisualStyleBackColor = true;
            // 
            // FrmTaskQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 444);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTaskQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "调漆记录查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTaskQuery_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaskRecord)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gbCheckBox.ResumeLayout(false);
            this.plCheckBox.ResumeLayout(false);
            this.plCheckBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgTaskRecord;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMainPartNumber;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProductionLine;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbCheckBox;
        private System.Windows.Forms.Panel plCheckBox;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.CheckBox cbSpeedResult;
        private System.Windows.Forms.CheckBox cbDelayTime;
        private System.Windows.Forms.CheckBox cbXiShiActualRate;
        private System.Windows.Forms.CheckBox cbXiShiSPECL;
        private System.Windows.Forms.CheckBox cbXiShiSPECU;
        private System.Windows.Forms.CheckBox cbGuHuaActualRate;
        private System.Windows.Forms.CheckBox cbGuHuaDefinePercent;
        private System.Windows.Forms.CheckBox cbXiShiWeight;
        private System.Windows.Forms.CheckBox cbXiShiLot;
        private System.Windows.Forms.CheckBox cbXiShiPartNumber;
        private System.Windows.Forms.CheckBox cbXiShiVendor;
        private System.Windows.Forms.CheckBox cbGuHuaWeight;
        private System.Windows.Forms.CheckBox cbGuHuaLot;
        private System.Windows.Forms.CheckBox cbGuHuaPartNumber;
        private System.Windows.Forms.CheckBox cbGuHuaVendor;
        private System.Windows.Forms.CheckBox cbMainPartWeight;
        private System.Windows.Forms.CheckBox cbMainPartLot;
        private System.Windows.Forms.CheckBox cbMainPartNumber;
        private System.Windows.Forms.CheckBox cbMainVendor;
        private System.Windows.Forms.CheckBox cbSupplier;
        private System.Windows.Forms.CheckBox cbPartNumber;
        private System.Windows.Forms.CheckBox cbShift;
        private System.Windows.Forms.CheckBox cbLine;
        private System.Windows.Forms.CheckBox cbXiShiHolderWeight;
        private System.Windows.Forms.CheckBox cbGuHuaHolderWeight;
        private System.Windows.Forms.CheckBox cbMainHolderWeight;
        private System.Windows.Forms.CheckBox cbCustomer;
        private System.Windows.Forms.Button btnNoSelectAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnExportSumary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.CheckBox biaozhunPercent;
        private System.Windows.Forms.CheckBox actualPercent;
    }
}