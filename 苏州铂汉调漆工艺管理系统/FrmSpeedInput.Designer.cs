namespace 调漆工艺管理系统
{
    partial class FrmSpeedInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpeedInput));
            this.label1 = new System.Windows.Forms.Label();
            this.pbTimeInfo = new System.Windows.Forms.PictureBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "请在充分搅拌后输入流速测量值:";
            // 
            // pbTimeInfo
            // 
            this.pbTimeInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbTimeInfo.Image")));
            this.pbTimeInfo.Location = new System.Drawing.Point(383, 30);
            this.pbTimeInfo.Name = "pbTimeInfo";
            this.pbTimeInfo.Size = new System.Drawing.Size(168, 158);
            this.pbTimeInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTimeInfo.TabIndex = 1;
            this.pbTimeInfo.TabStop = false;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeed.Location = new System.Drawing.Point(31, 141);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(192, 47);
            this.txtSpeed.TabIndex = 2;
            this.txtSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSpeed_KeyDown);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Red;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(414, 86);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(113, 54);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "0";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(191, 216);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(186, 58);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmSpeedInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 297);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.pbTimeInfo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSpeedInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "流速输入";
            this.Load += new System.EventHandler(this.FrmSpeedInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTimeInfo;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSubmit;
    }
}