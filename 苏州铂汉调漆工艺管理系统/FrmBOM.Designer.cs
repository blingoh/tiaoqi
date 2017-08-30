namespace 调漆工艺管理系统
{
    partial class FrmBOM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBOM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOilName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtValidHours = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPaintSpeedL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWangBuMuShu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtXiShiLowPercent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtXiShiUpPercent = new System.Windows.Forms.TextBox();
            this.txtPaintSpeedU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuHuaPercent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPaintType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.tpMainParts = new System.Windows.Forms.TabPage();
            this.btnRemoveXiShiPart = new System.Windows.Forms.Button();
            this.btnAppendXiShiPart = new System.Windows.Forms.Button();
            this.txtXiShiPart = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemoveGuHuaPart = new System.Windows.Forms.Button();
            this.btnAppendGuHuaPart = new System.Windows.Forms.Button();
            this.txtGuHuaPart = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoveMainPart = new System.Windows.Forms.Button();
            this.btnAppendMainPart = new System.Windows.Forms.Button();
            this.txtMainPart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbXiShi = new System.Windows.Forms.ListBox();
            this.lbGuHua = new System.Windows.Forms.ListBox();
            this.lbMain = new System.Windows.Forms.ListBox();
            this.dgBOMinfo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tpMainParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBOMinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOilName);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtValidHours);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtPaintSpeedL);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtWangBuMuShu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtXiShiLowPercent);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtXiShiUpPercent);
            this.groupBox1.Controls.Add(this.txtPaintSpeedU);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtGuHuaPercent);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbPaintType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSupplier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPartNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtOilName
            // 
            this.txtOilName.Location = new System.Drawing.Point(639, 154);
            this.txtOilName.Name = "txtOilName";
            this.txtOilName.Size = new System.Drawing.Size(149, 21);
            this.txtOilName.TabIndex = 33;
            this.txtOilName.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(524, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 32;
            this.label15.Text = "油漆名：";
            this.label15.Visible = false;
            // 
            // txtValidHours
            // 
            this.txtValidHours.Location = new System.Drawing.Point(639, 106);
            this.txtValidHours.Name = "txtValidHours";
            this.txtValidHours.Size = new System.Drawing.Size(149, 21);
            this.txtValidHours.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(524, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 19);
            this.label14.TabIndex = 30;
            this.label14.Text = "有效时间：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(17, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 19);
            this.label13.TabIndex = 29;
            this.label13.Text = "客       户:";
            // 
            // txtPaintSpeedL
            // 
            this.txtPaintSpeedL.Location = new System.Drawing.Point(364, 60);
            this.txtPaintSpeedL.Name = "txtPaintSpeedL";
            this.txtPaintSpeedL.Size = new System.Drawing.Size(149, 21);
            this.txtPaintSpeedL.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(249, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "油漆粘度(下限) ：       ";
            // 
            // txtWangBuMuShu
            // 
            this.txtWangBuMuShu.Location = new System.Drawing.Point(364, 150);
            this.txtWangBuMuShu.Name = "txtWangBuMuShu";
            this.txtWangBuMuShu.Size = new System.Drawing.Size(149, 21);
            this.txtWangBuMuShu.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(249, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "网布目数：       ";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.White;
            this.btnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.ForeColor = System.Drawing.Color.Blue;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.Location = new System.Drawing.Point(221, 18);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(31, 21);
            this.btnQuery.TabIndex = 24;
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnAppend);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(794, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 198);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Blue;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(18, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 25);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppend.ForeColor = System.Drawing.Color.Blue;
            this.btnAppend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppend.Location = new System.Drawing.Point(18, 11);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(106, 25);
            this.btnAppend.TabIndex = 14;
            this.btnAppend.Text = "增加";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Blue;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(18, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 25);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(18, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 25);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(18, 79);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 25);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtXiShiLowPercent
            // 
            this.txtXiShiLowPercent.Location = new System.Drawing.Point(639, 61);
            this.txtXiShiLowPercent.Name = "txtXiShiLowPercent";
            this.txtXiShiLowPercent.Size = new System.Drawing.Size(149, 21);
            this.txtXiShiLowPercent.TabIndex = 19;
            this.txtXiShiLowPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXiShiLowPercent_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(524, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "稀释剂比例(下限)：";
            // 
            // txtXiShiUpPercent
            // 
            this.txtXiShiUpPercent.Location = new System.Drawing.Point(639, 20);
            this.txtXiShiUpPercent.Name = "txtXiShiUpPercent";
            this.txtXiShiUpPercent.Size = new System.Drawing.Size(149, 21);
            this.txtXiShiUpPercent.TabIndex = 17;
            this.txtXiShiUpPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXiShiUpPercent_KeyDown);
            // 
            // txtPaintSpeedU
            // 
            this.txtPaintSpeedU.Location = new System.Drawing.Point(364, 18);
            this.txtPaintSpeedU.Name = "txtPaintSpeedU";
            this.txtPaintSpeedU.Size = new System.Drawing.Size(149, 21);
            this.txtPaintSpeedU.TabIndex = 21;
            this.txtPaintSpeedU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaintSpeed_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(524, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "稀释剂比例(上限)：";
            // 
            // txtGuHuaPercent
            // 
            this.txtGuHuaPercent.Location = new System.Drawing.Point(364, 106);
            this.txtGuHuaPercent.Name = "txtGuHuaPercent";
            this.txtGuHuaPercent.Size = new System.Drawing.Size(149, 21);
            this.txtGuHuaPercent.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(249, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "油漆粘度(上限) ：       ";
            // 
            // cmbPaintType
            // 
            this.cmbPaintType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaintType.FormattingEnabled = true;
            this.cmbPaintType.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.cmbPaintType.Location = new System.Drawing.Point(89, 154);
            this.cmbPaintType.Name = "cmbPaintType";
            this.cmbPaintType.Size = new System.Drawing.Size(149, 20);
            this.cmbPaintType.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(249, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "固化剂比例：        ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "喷漆类型：";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(89, 109);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(149, 21);
            this.txtSupplier.TabIndex = 11;
            this.txtSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "厂        商：";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(89, 61);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(149, 21);
            this.txtPartNumber.TabIndex = 9;
            this.txtPartNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartNumber_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "机种品名：";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.cmbCustomer.Location = new System.Drawing.Point(89, 18);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(135, 20);
            this.cmbCustomer.TabIndex = 7;
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tpMain);
            this.tbMain.Controls.Add(this.tpMainParts);
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(967, 243);
            this.tbMain.TabIndex = 1;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.groupBox1);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(959, 217);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "主信息";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // tpMainParts
            // 
            this.tpMainParts.Controls.Add(this.btnRemoveXiShiPart);
            this.tpMainParts.Controls.Add(this.btnAppendXiShiPart);
            this.tpMainParts.Controls.Add(this.txtXiShiPart);
            this.tpMainParts.Controls.Add(this.label11);
            this.tpMainParts.Controls.Add(this.btnRemoveGuHuaPart);
            this.tpMainParts.Controls.Add(this.btnAppendGuHuaPart);
            this.tpMainParts.Controls.Add(this.txtGuHuaPart);
            this.tpMainParts.Controls.Add(this.label10);
            this.tpMainParts.Controls.Add(this.btnRemoveMainPart);
            this.tpMainParts.Controls.Add(this.btnAppendMainPart);
            this.tpMainParts.Controls.Add(this.txtMainPart);
            this.tpMainParts.Controls.Add(this.label9);
            this.tpMainParts.Controls.Add(this.lbXiShi);
            this.tpMainParts.Controls.Add(this.lbGuHua);
            this.tpMainParts.Controls.Add(this.lbMain);
            this.tpMainParts.Location = new System.Drawing.Point(4, 22);
            this.tpMainParts.Name = "tpMainParts";
            this.tpMainParts.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainParts.Size = new System.Drawing.Size(959, 217);
            this.tpMainParts.TabIndex = 1;
            this.tpMainParts.Text = "物料清单";
            this.tpMainParts.UseVisualStyleBackColor = true;
            // 
            // btnRemoveXiShiPart
            // 
            this.btnRemoveXiShiPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemoveXiShiPart.Location = new System.Drawing.Point(647, 6);
            this.btnRemoveXiShiPart.Name = "btnRemoveXiShiPart";
            this.btnRemoveXiShiPart.Size = new System.Drawing.Size(44, 30);
            this.btnRemoveXiShiPart.TabIndex = 9;
            this.btnRemoveXiShiPart.Text = "删除";
            this.btnRemoveXiShiPart.UseVisualStyleBackColor = false;
            this.btnRemoveXiShiPart.Click += new System.EventHandler(this.btnRemoveXiShiPart_Click);
            // 
            // btnAppendXiShiPart
            // 
            this.btnAppendXiShiPart.Location = new System.Drawing.Point(576, 6);
            this.btnAppendXiShiPart.Name = "btnAppendXiShiPart";
            this.btnAppendXiShiPart.Size = new System.Drawing.Size(51, 30);
            this.btnAppendXiShiPart.TabIndex = 8;
            this.btnAppendXiShiPart.Text = "增加";
            this.btnAppendXiShiPart.UseVisualStyleBackColor = true;
            this.btnAppendXiShiPart.Click += new System.EventHandler(this.btnAppendXiShiPart_Click);
            // 
            // txtXiShiPart
            // 
            this.txtXiShiPart.Location = new System.Drawing.Point(508, 37);
            this.txtXiShiPart.Name = "txtXiShiPart";
            this.txtXiShiPart.Size = new System.Drawing.Size(185, 21);
            this.txtXiShiPart.TabIndex = 15;
            this.txtXiShiPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtXiShiPart_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(507, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "稀释剂料号：";
            // 
            // btnRemoveGuHuaPart
            // 
            this.btnRemoveGuHuaPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemoveGuHuaPart.Location = new System.Drawing.Point(396, 6);
            this.btnRemoveGuHuaPart.Name = "btnRemoveGuHuaPart";
            this.btnRemoveGuHuaPart.Size = new System.Drawing.Size(42, 29);
            this.btnRemoveGuHuaPart.TabIndex = 7;
            this.btnRemoveGuHuaPart.Text = "删除";
            this.btnRemoveGuHuaPart.UseVisualStyleBackColor = false;
            this.btnRemoveGuHuaPart.Click += new System.EventHandler(this.btnRemoveGuHuaPart_Click);
            // 
            // btnAppendGuHuaPart
            // 
            this.btnAppendGuHuaPart.Location = new System.Drawing.Point(327, 6);
            this.btnAppendGuHuaPart.Name = "btnAppendGuHuaPart";
            this.btnAppendGuHuaPart.Size = new System.Drawing.Size(48, 30);
            this.btnAppendGuHuaPart.TabIndex = 6;
            this.btnAppendGuHuaPart.Text = "增加";
            this.btnAppendGuHuaPart.UseVisualStyleBackColor = true;
            this.btnAppendGuHuaPart.Click += new System.EventHandler(this.btnAppendGuHuaPart_Click);
            // 
            // txtGuHuaPart
            // 
            this.txtGuHuaPart.Location = new System.Drawing.Point(259, 37);
            this.txtGuHuaPart.Name = "txtGuHuaPart";
            this.txtGuHuaPart.Size = new System.Drawing.Size(179, 21);
            this.txtGuHuaPart.TabIndex = 13;
            this.txtGuHuaPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGuHuaPart_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(258, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "固化剂料号：";
            // 
            // btnRemoveMainPart
            // 
            this.btnRemoveMainPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRemoveMainPart.Location = new System.Drawing.Point(155, 6);
            this.btnRemoveMainPart.Name = "btnRemoveMainPart";
            this.btnRemoveMainPart.Size = new System.Drawing.Size(45, 31);
            this.btnRemoveMainPart.TabIndex = 5;
            this.btnRemoveMainPart.Text = "删除";
            this.btnRemoveMainPart.UseVisualStyleBackColor = false;
            this.btnRemoveMainPart.Click += new System.EventHandler(this.btnRemoveMainPart_Click);
            // 
            // btnAppendMainPart
            // 
            this.btnAppendMainPart.Location = new System.Drawing.Point(81, 6);
            this.btnAppendMainPart.Name = "btnAppendMainPart";
            this.btnAppendMainPart.Size = new System.Drawing.Size(48, 30);
            this.btnAppendMainPart.TabIndex = 4;
            this.btnAppendMainPart.Text = "增加";
            this.btnAppendMainPart.UseVisualStyleBackColor = true;
            this.btnAppendMainPart.Click += new System.EventHandler(this.btnAppendMainPart_Click);
            // 
            // txtMainPart
            // 
            this.txtMainPart.Location = new System.Drawing.Point(11, 37);
            this.txtMainPart.Name = "txtMainPart";
            this.txtMainPart.Size = new System.Drawing.Size(189, 21);
            this.txtMainPart.TabIndex = 11;
            this.txtMainPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMainPart_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(10, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "主剂料号：";
            // 
            // lbXiShi
            // 
            this.lbXiShi.FormattingEnabled = true;
            this.lbXiShi.ItemHeight = 12;
            this.lbXiShi.Location = new System.Drawing.Point(508, 61);
            this.lbXiShi.Name = "lbXiShi";
            this.lbXiShi.Size = new System.Drawing.Size(185, 124);
            this.lbXiShi.TabIndex = 2;
            this.lbXiShi.SelectedIndexChanged += new System.EventHandler(this.lbXiShi_SelectedIndexChanged);
            // 
            // lbGuHua
            // 
            this.lbGuHua.FormattingEnabled = true;
            this.lbGuHua.ItemHeight = 12;
            this.lbGuHua.Location = new System.Drawing.Point(259, 61);
            this.lbGuHua.Name = "lbGuHua";
            this.lbGuHua.Size = new System.Drawing.Size(181, 124);
            this.lbGuHua.TabIndex = 1;
            this.lbGuHua.SelectedIndexChanged += new System.EventHandler(this.lbGuHua_SelectedIndexChanged);
            // 
            // lbMain
            // 
            this.lbMain.FormattingEnabled = true;
            this.lbMain.ItemHeight = 12;
            this.lbMain.Location = new System.Drawing.Point(11, 61);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(189, 124);
            this.lbMain.TabIndex = 0;
            this.lbMain.SelectedIndexChanged += new System.EventHandler(this.lbMain_SelectedIndexChanged);
            // 
            // dgBOMinfo
            // 
            this.dgBOMinfo.AllowUserToAddRows = false;
            this.dgBOMinfo.AllowUserToDeleteRows = false;
            this.dgBOMinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBOMinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBOMinfo.Location = new System.Drawing.Point(0, 243);
            this.dgBOMinfo.Name = "dgBOMinfo";
            this.dgBOMinfo.ReadOnly = true;
            this.dgBOMinfo.Size = new System.Drawing.Size(967, 243);
            this.dgBOMinfo.TabIndex = 12;
            this.dgBOMinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBOMinfo_CellClick);
            // 
            // FrmBOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 486);
            this.Controls.Add(this.dgBOMinfo);
            this.Controls.Add(this.tbMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBOM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BOM信息维护";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBOM_FormClosing);
            this.Load += new System.EventHandler(this.FrmBOM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tbMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tpMainParts.ResumeLayout(false);
            this.tpMainParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBOMinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPaintType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXiShiLowPercent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtXiShiUpPercent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGuHuaPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaintSpeedU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.TabPage tpMainParts;
        private System.Windows.Forms.TextBox txtXiShiPart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGuHuaPart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMainPart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbXiShi;
        private System.Windows.Forms.ListBox lbGuHua;
        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.Button btnRemoveXiShiPart;
        private System.Windows.Forms.Button btnAppendXiShiPart;
        private System.Windows.Forms.Button btnRemoveGuHuaPart;
        private System.Windows.Forms.Button btnAppendGuHuaPart;
        private System.Windows.Forms.Button btnRemoveMainPart;
        private System.Windows.Forms.Button btnAppendMainPart;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.DataGridView dgBOMinfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtPaintSpeedL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWangBuMuShu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValidHours;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOilName;
        private System.Windows.Forms.Label label15;
    }
}