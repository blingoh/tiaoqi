namespace 调漆工艺管理系统
{
    partial class FrmPrinter
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYuanYouPartNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuHuaPartNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXiShiPartNumber = new System.Windows.Forms.TextBox();
            this.txtSpaintSpeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValidHours = new System.Windows.Forms.TextBox();
            this.tipForDate = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(88, 244);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(190, 52);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "测试";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(130, 30);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(148, 21);
            this.txtLine.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "线别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "原油料号";
            // 
            // txtYuanYouPartNumber
            // 
            this.txtYuanYouPartNumber.Location = new System.Drawing.Point(130, 84);
            this.txtYuanYouPartNumber.Name = "txtYuanYouPartNumber";
            this.txtYuanYouPartNumber.Size = new System.Drawing.Size(148, 21);
            this.txtYuanYouPartNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "固化剂料号";
            // 
            // txtGuHuaPartNumber
            // 
            this.txtGuHuaPartNumber.Location = new System.Drawing.Point(130, 111);
            this.txtGuHuaPartNumber.Name = "txtGuHuaPartNumber";
            this.txtGuHuaPartNumber.Size = new System.Drawing.Size(148, 21);
            this.txtGuHuaPartNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "稀释剂料号";
            // 
            // txtXiShiPartNumber
            // 
            this.txtXiShiPartNumber.Location = new System.Drawing.Point(130, 138);
            this.txtXiShiPartNumber.Name = "txtXiShiPartNumber";
            this.txtXiShiPartNumber.Size = new System.Drawing.Size(148, 21);
            this.txtXiShiPartNumber.TabIndex = 7;
            // 
            // txtSpaintSpeed
            // 
            this.txtSpaintSpeed.Location = new System.Drawing.Point(130, 165);
            this.txtSpaintSpeed.Name = "txtSpaintSpeed";
            this.txtSpaintSpeed.Size = new System.Drawing.Size(148, 21);
            this.txtSpaintSpeed.TabIndex = 9;
            this.tipForDate.SetToolTip(this.txtSpaintSpeed, "一个表示时间的秒数");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "油漆秒数(秒)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "打印最后一次调漆记录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "机种";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(130, 57);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(148, 21);
            this.txtPartNumber.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "有效时间(小时)";
            // 
            // txtValidHours
            // 
            this.txtValidHours.Location = new System.Drawing.Point(130, 192);
            this.txtValidHours.Name = "txtValidHours";
            this.txtValidHours.Size = new System.Drawing.Size(148, 21);
            this.txtValidHours.TabIndex = 14;
            this.tipForDate.SetToolTip(this.txtValidHours, "输入有效时间（单位：小时）");
            // 
            // FrmPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 406);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValidHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSpaintSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtXiShiPartNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGuHuaPartNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYuanYouPartNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.btnPrint);
            this.MaximizeBox = false;
            this.Name = "FrmPrinter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印测试";
            this.Load += new System.EventHandler(this.FrmPrinter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYuanYouPartNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGuHuaPartNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXiShiPartNumber;
        private System.Windows.Forms.TextBox txtSpaintSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValidHours;
        private System.Windows.Forms.ToolTip tipForDate;
    }
}