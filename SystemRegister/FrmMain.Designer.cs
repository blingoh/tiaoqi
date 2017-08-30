namespace SystemRegister
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
            this.lblRegisterCode = new System.Windows.Forms.Label();
            this.btnGeneration = new System.Windows.Forms.Button();
            this.txtPCCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegisterCode
            // 
            this.lblRegisterCode.AutoSize = true;
            this.lblRegisterCode.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterCode.ForeColor = System.Drawing.Color.Lime;
            this.lblRegisterCode.Location = new System.Drawing.Point(81, 173);
            this.lblRegisterCode.Name = "lblRegisterCode";
            this.lblRegisterCode.Size = new System.Drawing.Size(380, 42);
            this.lblRegisterCode.TabIndex = 0;
            this.lblRegisterCode.Text = "1111-1111-1111-1111";
            // 
            // btnGeneration
            // 
            this.btnGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneration.Location = new System.Drawing.Point(175, 234);
            this.btnGeneration.Name = "btnGeneration";
            this.btnGeneration.Size = new System.Drawing.Size(176, 44);
            this.btnGeneration.TabIndex = 1;
            this.btnGeneration.Text = "生成注册码";
            this.btnGeneration.UseVisualStyleBackColor = true;
            this.btnGeneration.Click += new System.EventHandler(this.btnGeneration_Click);
            // 
            // txtPCCode
            // 
            this.txtPCCode.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCCode.Location = new System.Drawing.Point(88, 66);
            this.txtPCCode.Name = "txtPCCode";
            this.txtPCCode.Size = new System.Drawing.Size(149, 43);
            this.txtPCCode.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(82, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 35);
            this.label7.TabIndex = 20;
            this.label7.Text = "机器码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(82, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "序列号：";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPCCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGeneration);
            this.Controls.Add(this.lblRegisterCode);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "注册码生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisterCode;
        private System.Windows.Forms.Button btnGeneration;
        private System.Windows.Forms.TextBox txtPCCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}

