namespace 调漆工艺管理系统
{
    partial class FrmMainPartInputSecondSolution
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
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNumCodeRule = new System.Windows.Forms.Button();
            this.btnMainCodeRule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartNumber.Location = new System.Drawing.Point(35, 130);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(342, 30);
            this.txtPartNumber.TabIndex = 41;
            this.txtPartNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPartNumber_KeyDown);
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotNumber.Location = new System.Drawing.Point(35, 187);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(342, 30);
            this.txtLotNumber.TabIndex = 42;
            this.txtLotNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLotNumber_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(32, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 21);
            this.label11.TabIndex = 39;
            this.label11.Text = "批次号:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(31, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 21);
            this.label10.TabIndex = 38;
            this.label10.Text = "原材料号:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNumCodeRule);
            this.groupBox1.Controls.Add(this.btnMainCodeRule);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBarCode);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtPartNumber);
            this.groupBox1.Controls.Add(this.txtLotNumber);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 298);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原油";
            // 
            // btnNumCodeRule
            // 
            this.btnNumCodeRule.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumCodeRule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNumCodeRule.Location = new System.Drawing.Point(384, 187);
            this.btnNumCodeRule.Name = "btnNumCodeRule";
            this.btnNumCodeRule.Size = new System.Drawing.Size(43, 30);
            this.btnNumCodeRule.TabIndex = 49;
            this.btnNumCodeRule.Text = "编码";
            this.btnNumCodeRule.UseVisualStyleBackColor = true;
            this.btnNumCodeRule.Click += new System.EventHandler(this.OnMainNumCodeRuleClicked);
            // 
            // btnMainCodeRule
            // 
            this.btnMainCodeRule.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainCodeRule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMainCodeRule.Location = new System.Drawing.Point(384, 130);
            this.btnMainCodeRule.Name = "btnMainCodeRule";
            this.btnMainCodeRule.Size = new System.Drawing.Size(43, 30);
            this.btnMainCodeRule.TabIndex = 48;
            this.btnMainCodeRule.Text = "编码";
            this.btnMainCodeRule.UseVisualStyleBackColor = true;
            this.btnMainCodeRule.Click += new System.EventHandler(this.OnMainCodeRuleClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "扫码:";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(35, 73);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(392, 30);
            this.txtBarCode.TabIndex = 40;
            this.txtBarCode.TextChanged += new System.EventHandler(this.OnBarCodeContentChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubmit.Location = new System.Drawing.Point(120, 243);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(174, 39);
            this.btnSubmit.TabIndex = 44;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmMainPartInputSecondSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 329);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmMainPartInputSecondSolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "扫描输入原油配料信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.TextBox txtLotNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnMainCodeRule;
        private System.Windows.Forms.Button btnNumCodeRule;
    }
}