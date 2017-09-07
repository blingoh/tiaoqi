namespace 调漆工艺管理系统
{
    partial class FrmOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOption));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.badrateScaleMain = new System.Windows.Forms.ComboBox();
            this.stopbitScaleMain = new System.Windows.Forms.ComboBox();
            this.comScaleMain = new System.Windows.Forms.NumericUpDown();
            this.databitScaleMain = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.parityScaleMain = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.g1 = new System.Windows.Forms.TabControl();
            this.tpScaleMain = new System.Windows.Forms.TabPage();
            this.tpGuhua = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.badrateScaleGuHua = new System.Windows.Forms.ComboBox();
            this.stopbitScaleGuHua = new System.Windows.Forms.ComboBox();
            this.comScaleGuHua = new System.Windows.Forms.NumericUpDown();
            this.databitScaleGuHua = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.parityScaleGuHua = new System.Windows.Forms.ComboBox();
            this.tpScaleXiShiQi = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.badrateScaleXiShi = new System.Windows.Forms.ComboBox();
            this.stopbitScaleXiShi = new System.Windows.Forms.ComboBox();
            this.comScaleXiShi = new System.Windows.Forms.NumericUpDown();
            this.databitScaleXiShi = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.parityScaleXiShi = new System.Windows.Forms.ComboBox();
            this.tpTiaoQi = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbScaleHolderWeight = new System.Windows.Forms.CheckBox();
            this.txtGuHuaRange = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tpPrinter = new System.Windows.Forms.TabPage();
            this.btnLoadAntiFake = new System.Windows.Forms.Button();
            this.txtLabelTemplate = new System.Windows.Forms.TextBox();
            this.txtPrinterName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpDB = new System.Windows.Forms.TabPage();
            this.txtDBPSW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDBUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comScaleMain)).BeginInit();
            this.g1.SuspendLayout();
            this.tpScaleMain.SuspendLayout();
            this.tpGuhua.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comScaleGuHua)).BeginInit();
            this.tpScaleXiShiQi.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comScaleXiShi)).BeginInit();
            this.tpTiaoQi.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tpPrinter.SuspendLayout();
            this.tpDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.badrateScaleMain);
            this.groupBox3.Controls.Add(this.stopbitScaleMain);
            this.groupBox3.Controls.Add(this.comScaleMain);
            this.groupBox3.Controls.Add(this.databitScaleMain);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.parityScaleMain);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(24, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 182);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "端口";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "停止位";
            // 
            // badrateScaleMain
            // 
            this.badrateScaleMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.badrateScaleMain.FormattingEnabled = true;
            this.badrateScaleMain.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.badrateScaleMain.Location = new System.Drawing.Point(104, 53);
            this.badrateScaleMain.Name = "badrateScaleMain";
            this.badrateScaleMain.Size = new System.Drawing.Size(129, 20);
            this.badrateScaleMain.TabIndex = 0;
            // 
            // stopbitScaleMain
            // 
            this.stopbitScaleMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbitScaleMain.FormattingEnabled = true;
            this.stopbitScaleMain.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopbitScaleMain.Location = new System.Drawing.Point(104, 149);
            this.stopbitScaleMain.Name = "stopbitScaleMain";
            this.stopbitScaleMain.Size = new System.Drawing.Size(129, 20);
            this.stopbitScaleMain.TabIndex = 8;
            // 
            // comScaleMain
            // 
            this.comScaleMain.Location = new System.Drawing.Point(104, 22);
            this.comScaleMain.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.comScaleMain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.comScaleMain.Name = "comScaleMain";
            this.comScaleMain.Size = new System.Drawing.Size(129, 21);
            this.comScaleMain.TabIndex = 1;
            this.comScaleMain.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // databitScaleMain
            // 
            this.databitScaleMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databitScaleMain.FormattingEnabled = true;
            this.databitScaleMain.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.databitScaleMain.Location = new System.Drawing.Point(104, 118);
            this.databitScaleMain.Name = "databitScaleMain";
            this.databitScaleMain.Size = new System.Drawing.Size(129, 20);
            this.databitScaleMain.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "波特率";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "数据位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "校验位";
            // 
            // parityScaleMain
            // 
            this.parityScaleMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityScaleMain.FormattingEnabled = true;
            this.parityScaleMain.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityScaleMain.Location = new System.Drawing.Point(104, 85);
            this.parityScaleMain.Name = "parityScaleMain";
            this.parityScaleMain.Size = new System.Drawing.Size(129, 20);
            this.parityScaleMain.TabIndex = 5;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.ForeColor = System.Drawing.Color.Blue;
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(12, 288);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(98, 31);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "确定";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(141, 288);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 31);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.ForeColor = System.Drawing.Color.Blue;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(263, 288);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 31);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "保存";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // g1
            // 
            this.g1.Controls.Add(this.tpScaleMain);
            this.g1.Controls.Add(this.tpGuhua);
            this.g1.Controls.Add(this.tpScaleXiShiQi);
            this.g1.Controls.Add(this.tpTiaoQi);
            this.g1.Controls.Add(this.tpPrinter);
            this.g1.Controls.Add(this.tpDB);
            this.g1.Location = new System.Drawing.Point(12, 7);
            this.g1.Name = "g1";
            this.g1.SelectedIndex = 0;
            this.g1.Size = new System.Drawing.Size(366, 264);
            this.g1.TabIndex = 16;
            // 
            // tpScaleMain
            // 
            this.tpScaleMain.Controls.Add(this.groupBox3);
            this.tpScaleMain.Location = new System.Drawing.Point(4, 22);
            this.tpScaleMain.Name = "tpScaleMain";
            this.tpScaleMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpScaleMain.Size = new System.Drawing.Size(358, 238);
            this.tpScaleMain.TabIndex = 0;
            this.tpScaleMain.Text = "基础漆电子称";
            this.tpScaleMain.UseVisualStyleBackColor = true;
            // 
            // tpGuhua
            // 
            this.tpGuhua.Controls.Add(this.groupBox1);
            this.tpGuhua.Location = new System.Drawing.Point(4, 22);
            this.tpGuhua.Name = "tpGuhua";
            this.tpGuhua.Size = new System.Drawing.Size(358, 238);
            this.tpGuhua.TabIndex = 4;
            this.tpGuhua.Text = "固化漆电子秤";
            this.tpGuhua.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.badrateScaleGuHua);
            this.groupBox1.Controls.Add(this.stopbitScaleGuHua);
            this.groupBox1.Controls.Add(this.comScaleGuHua);
            this.groupBox1.Controls.Add(this.databitScaleGuHua);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.parityScaleGuHua);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 182);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "Stop Bits:";
            // 
            // badrateScaleGuHua
            // 
            this.badrateScaleGuHua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.badrateScaleGuHua.FormattingEnabled = true;
            this.badrateScaleGuHua.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.badrateScaleGuHua.Location = new System.Drawing.Point(104, 53);
            this.badrateScaleGuHua.Name = "badrateScaleGuHua";
            this.badrateScaleGuHua.Size = new System.Drawing.Size(129, 20);
            this.badrateScaleGuHua.TabIndex = 0;
            // 
            // stopbitScaleGuHua
            // 
            this.stopbitScaleGuHua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbitScaleGuHua.FormattingEnabled = true;
            this.stopbitScaleGuHua.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopbitScaleGuHua.Location = new System.Drawing.Point(104, 149);
            this.stopbitScaleGuHua.Name = "stopbitScaleGuHua";
            this.stopbitScaleGuHua.Size = new System.Drawing.Size(129, 20);
            this.stopbitScaleGuHua.TabIndex = 8;
            // 
            // comScaleGuHua
            // 
            this.comScaleGuHua.Location = new System.Drawing.Point(104, 22);
            this.comScaleGuHua.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.comScaleGuHua.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.comScaleGuHua.Name = "comScaleGuHua";
            this.comScaleGuHua.Size = new System.Drawing.Size(129, 21);
            this.comScaleGuHua.TabIndex = 1;
            this.comScaleGuHua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // databitScaleGuHua
            // 
            this.databitScaleGuHua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databitScaleGuHua.FormattingEnabled = true;
            this.databitScaleGuHua.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.databitScaleGuHua.Location = new System.Drawing.Point(104, 118);
            this.databitScaleGuHua.Name = "databitScaleGuHua";
            this.databitScaleGuHua.Size = new System.Drawing.Size(129, 20);
            this.databitScaleGuHua.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "Baud Rate:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "Data Bits:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "Parity:";
            // 
            // parityScaleGuHua
            // 
            this.parityScaleGuHua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityScaleGuHua.FormattingEnabled = true;
            this.parityScaleGuHua.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityScaleGuHua.Location = new System.Drawing.Point(104, 85);
            this.parityScaleGuHua.Name = "parityScaleGuHua";
            this.parityScaleGuHua.Size = new System.Drawing.Size(129, 20);
            this.parityScaleGuHua.TabIndex = 5;
            // 
            // tpScaleXiShiQi
            // 
            this.tpScaleXiShiQi.Controls.Add(this.groupBox2);
            this.tpScaleXiShiQi.Location = new System.Drawing.Point(4, 22);
            this.tpScaleXiShiQi.Name = "tpScaleXiShiQi";
            this.tpScaleXiShiQi.Size = new System.Drawing.Size(358, 238);
            this.tpScaleXiShiQi.TabIndex = 5;
            this.tpScaleXiShiQi.Text = "稀释剂电子秤";
            this.tpScaleXiShiQi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.badrateScaleXiShi);
            this.groupBox2.Controls.Add(this.stopbitScaleXiShi);
            this.groupBox2.Controls.Add(this.comScaleXiShi);
            this.groupBox2.Controls.Add(this.databitScaleXiShi);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.parityScaleXiShi);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(25, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 182);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口设置";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "Port Number:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "Stop Bits:";
            // 
            // badrateScaleXiShi
            // 
            this.badrateScaleXiShi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.badrateScaleXiShi.FormattingEnabled = true;
            this.badrateScaleXiShi.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.badrateScaleXiShi.Location = new System.Drawing.Point(104, 53);
            this.badrateScaleXiShi.Name = "badrateScaleXiShi";
            this.badrateScaleXiShi.Size = new System.Drawing.Size(129, 20);
            this.badrateScaleXiShi.TabIndex = 0;
            // 
            // stopbitScaleXiShi
            // 
            this.stopbitScaleXiShi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbitScaleXiShi.FormattingEnabled = true;
            this.stopbitScaleXiShi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopbitScaleXiShi.Location = new System.Drawing.Point(104, 149);
            this.stopbitScaleXiShi.Name = "stopbitScaleXiShi";
            this.stopbitScaleXiShi.Size = new System.Drawing.Size(129, 20);
            this.stopbitScaleXiShi.TabIndex = 8;
            // 
            // comScaleXiShi
            // 
            this.comScaleXiShi.Location = new System.Drawing.Point(104, 22);
            this.comScaleXiShi.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.comScaleXiShi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.comScaleXiShi.Name = "comScaleXiShi";
            this.comScaleXiShi.Size = new System.Drawing.Size(129, 21);
            this.comScaleXiShi.TabIndex = 1;
            this.comScaleXiShi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // databitScaleXiShi
            // 
            this.databitScaleXiShi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databitScaleXiShi.FormattingEnabled = true;
            this.databitScaleXiShi.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.databitScaleXiShi.Location = new System.Drawing.Point(104, 118);
            this.databitScaleXiShi.Name = "databitScaleXiShi";
            this.databitScaleXiShi.Size = new System.Drawing.Size(129, 20);
            this.databitScaleXiShi.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "Baud Rate:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 6;
            this.label18.Text = "Data Bits:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 92);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "Parity:";
            // 
            // parityScaleXiShi
            // 
            this.parityScaleXiShi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityScaleXiShi.FormattingEnabled = true;
            this.parityScaleXiShi.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityScaleXiShi.Location = new System.Drawing.Point(104, 85);
            this.parityScaleXiShi.Name = "parityScaleXiShi";
            this.parityScaleXiShi.Size = new System.Drawing.Size(129, 20);
            this.parityScaleXiShi.TabIndex = 5;
            // 
            // tpTiaoQi
            // 
            this.tpTiaoQi.Controls.Add(this.groupBox4);
            this.tpTiaoQi.Location = new System.Drawing.Point(4, 22);
            this.tpTiaoQi.Name = "tpTiaoQi";
            this.tpTiaoQi.Size = new System.Drawing.Size(358, 238);
            this.tpTiaoQi.TabIndex = 6;
            this.tpTiaoQi.Text = "调漆参数";
            this.tpTiaoQi.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbScaleHolderWeight);
            this.groupBox4.Controls.Add(this.txtGuHuaRange);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(16, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 210);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // cbScaleHolderWeight
            // 
            this.cbScaleHolderWeight.AutoSize = true;
            this.cbScaleHolderWeight.ForeColor = System.Drawing.Color.Blue;
            this.cbScaleHolderWeight.Location = new System.Drawing.Point(20, 55);
            this.cbScaleHolderWeight.Name = "cbScaleHolderWeight";
            this.cbScaleHolderWeight.Size = new System.Drawing.Size(132, 16);
            this.cbScaleHolderWeight.TabIndex = 10;
            this.cbScaleHolderWeight.Text = "自动计算容器的重量";
            this.cbScaleHolderWeight.UseVisualStyleBackColor = true;
            // 
            // txtGuHuaRange
            // 
            this.txtGuHuaRange.Location = new System.Drawing.Point(105, 18);
            this.txtGuHuaRange.Name = "txtGuHuaRange";
            this.txtGuHuaRange.Size = new System.Drawing.Size(90, 21);
            this.txtGuHuaRange.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(17, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 12);
            this.label20.TabIndex = 8;
            this.label20.Text = "固化剂偏差比:";
            // 
            // tpPrinter
            // 
            this.tpPrinter.Controls.Add(this.btnLoadAntiFake);
            this.tpPrinter.Controls.Add(this.txtLabelTemplate);
            this.tpPrinter.Controls.Add(this.txtPrinterName);
            this.tpPrinter.Controls.Add(this.label2);
            this.tpPrinter.Location = new System.Drawing.Point(4, 22);
            this.tpPrinter.Name = "tpPrinter";
            this.tpPrinter.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrinter.Size = new System.Drawing.Size(358, 238);
            this.tpPrinter.TabIndex = 1;
            this.tpPrinter.Text = "打印机";
            this.tpPrinter.UseVisualStyleBackColor = true;
            // 
            // btnLoadAntiFake
            // 
            this.btnLoadAntiFake.BackColor = System.Drawing.Color.White;
            this.btnLoadAntiFake.ForeColor = System.Drawing.Color.Blue;
            this.btnLoadAntiFake.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadAntiFake.Image")));
            this.btnLoadAntiFake.Location = new System.Drawing.Point(6, 51);
            this.btnLoadAntiFake.Name = "btnLoadAntiFake";
            this.btnLoadAntiFake.Size = new System.Drawing.Size(68, 58);
            this.btnLoadAntiFake.TabIndex = 10;
            this.btnLoadAntiFake.Text = "标签模板";
            this.btnLoadAntiFake.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadAntiFake.UseVisualStyleBackColor = false;
            this.btnLoadAntiFake.Click += new System.EventHandler(this.btnLoadAntiFake_Click);
            // 
            // txtLabelTemplate
            // 
            this.txtLabelTemplate.Location = new System.Drawing.Point(76, 53);
            this.txtLabelTemplate.Multiline = true;
            this.txtLabelTemplate.Name = "txtLabelTemplate";
            this.txtLabelTemplate.Size = new System.Drawing.Size(263, 57);
            this.txtLabelTemplate.TabIndex = 9;
            // 
            // txtPrinterName
            // 
            this.txtPrinterName.Location = new System.Drawing.Point(76, 17);
            this.txtPrinterName.Name = "txtPrinterName";
            this.txtPrinterName.Size = new System.Drawing.Size(263, 21);
            this.txtPrinterName.TabIndex = 7;
            this.txtPrinterName.Text = "192.168.2.175";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "打印机:";
            // 
            // tpDB
            // 
            this.tpDB.Controls.Add(this.txtDBPSW);
            this.tpDB.Controls.Add(this.label5);
            this.tpDB.Controls.Add(this.txtDBUserID);
            this.tpDB.Controls.Add(this.label4);
            this.tpDB.Controls.Add(this.txtServerName);
            this.tpDB.Controls.Add(this.label3);
            this.tpDB.Location = new System.Drawing.Point(4, 22);
            this.tpDB.Name = "tpDB";
            this.tpDB.Size = new System.Drawing.Size(358, 238);
            this.tpDB.TabIndex = 3;
            this.tpDB.Text = "数据库";
            this.tpDB.UseVisualStyleBackColor = true;
            // 
            // txtDBPSW
            // 
            this.txtDBPSW.Location = new System.Drawing.Point(82, 66);
            this.txtDBPSW.Name = "txtDBPSW";
            this.txtDBPSW.PasswordChar = '*';
            this.txtDBPSW.Size = new System.Drawing.Size(131, 21);
            this.txtDBPSW.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(20, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "密码:";
            // 
            // txtDBUserID
            // 
            this.txtDBUserID.Location = new System.Drawing.Point(82, 42);
            this.txtDBUserID.Name = "txtDBUserID";
            this.txtDBUserID.Size = new System.Drawing.Size(131, 21);
            this.txtDBUserID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(20, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "用户名:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(82, 18);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(193, 21);
            this.txtServerName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "服务器:";
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 330);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "参数设置";
            this.Load += new System.EventHandler(this.FrmOption_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comScaleMain)).EndInit();
            this.g1.ResumeLayout(false);
            this.tpScaleMain.ResumeLayout(false);
            this.tpGuhua.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comScaleGuHua)).EndInit();
            this.tpScaleXiShiQi.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comScaleXiShi)).EndInit();
            this.tpTiaoQi.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tpPrinter.ResumeLayout(false);
            this.tpPrinter.PerformLayout();
            this.tpDB.ResumeLayout(false);
            this.tpDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox badrateScaleMain;
        private System.Windows.Forms.ComboBox stopbitScaleMain;
        private System.Windows.Forms.NumericUpDown comScaleMain;
        private System.Windows.Forms.ComboBox databitScaleMain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox parityScaleMain;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl g1;
        private System.Windows.Forms.TabPage tpScaleMain;
        private System.Windows.Forms.TabPage tpPrinter;
        private System.Windows.Forms.TextBox txtPrinterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLabelTemplate;
        private System.Windows.Forms.Button btnLoadAntiFake;
        private System.Windows.Forms.TabPage tpDB;
        private System.Windows.Forms.TextBox txtDBPSW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDBUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpGuhua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox badrateScaleGuHua;
        private System.Windows.Forms.ComboBox stopbitScaleGuHua;
        private System.Windows.Forms.NumericUpDown comScaleGuHua;
        private System.Windows.Forms.ComboBox databitScaleGuHua;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox parityScaleGuHua;
        private System.Windows.Forms.TabPage tpScaleXiShiQi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox badrateScaleXiShi;
        private System.Windows.Forms.ComboBox stopbitScaleXiShi;
        private System.Windows.Forms.NumericUpDown comScaleXiShi;
        private System.Windows.Forms.ComboBox databitScaleXiShi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox parityScaleXiShi;
        private System.Windows.Forms.TabPage tpTiaoQi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtGuHuaRange;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cbScaleHolderWeight;
    }
}