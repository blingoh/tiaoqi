namespace 调漆工艺管理系统
{
    partial class FrmScaleDebug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScaleDebug));
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
            this.btnMainPartStop = new System.Windows.Forms.Button();
            this.btnMainPartStart = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.spMain = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comScaleMain)).BeginInit();
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
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 182);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "端口";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 153);
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
            this.label8.Location = new System.Drawing.Point(28, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "波特率";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "数据位";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 91);
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
            // btnMainPartStop
            // 
            this.btnMainPartStop.BackColor = System.Drawing.Color.Transparent;
            this.btnMainPartStop.Image = ((System.Drawing.Image)(resources.GetObject("btnMainPartStop.Image")));
            this.btnMainPartStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMainPartStop.Location = new System.Drawing.Point(315, 74);
            this.btnMainPartStop.Name = "btnMainPartStop";
            this.btnMainPartStop.Size = new System.Drawing.Size(114, 45);
            this.btnMainPartStop.TabIndex = 15;
            this.btnMainPartStop.Text = "结束";
            this.btnMainPartStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainPartStop.UseVisualStyleBackColor = false;
            this.btnMainPartStop.Click += new System.EventHandler(this.btnMainPartStop_Click);
            // 
            // btnMainPartStart
            // 
            this.btnMainPartStart.BackColor = System.Drawing.Color.Transparent;
            this.btnMainPartStart.Image = ((System.Drawing.Image)(resources.GetObject("btnMainPartStart.Image")));
            this.btnMainPartStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMainPartStart.Location = new System.Drawing.Point(315, 11);
            this.btnMainPartStart.Name = "btnMainPartStart";
            this.btnMainPartStart.Size = new System.Drawing.Size(114, 45);
            this.btnMainPartStart.TabIndex = 14;
            this.btnMainPartStart.Text = "开始";
            this.btnMainPartStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainPartStart.UseVisualStyleBackColor = false;
            this.btnMainPartStart.Click += new System.EventHandler(this.btnMainPartStart_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 198);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(485, 213);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Black;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(287, 137);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(131, 55);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "23000";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnit
            // 
            this.lblUnit.BackColor = System.Drawing.Color.Black;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.White;
            this.lblUnit.Location = new System.Drawing.Point(424, 138);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(74, 55);
            this.lblUnit.TabIndex = 18;
            this.lblUnit.Text = "kg";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spMain
            // 
            this.spMain.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spMain_DataReceived);
            // 
            // FrmScaleDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 422);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnMainPartStop);
            this.Controls.Add(this.btnMainPartStart);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmScaleDebug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "电子秤调试";
            this.Load += new System.EventHandler(this.FrmScaleDebug_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comScaleMain)).EndInit();
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
        private System.Windows.Forms.Button btnMainPartStop;
        private System.Windows.Forms.Button btnMainPartStart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblUnit;
        private System.IO.Ports.SerialPort spMain;
    }
}