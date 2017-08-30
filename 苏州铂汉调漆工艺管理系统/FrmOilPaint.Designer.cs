namespace 调漆工艺管理系统
{
    partial class FrmOilPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOilPaint));
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPaintType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAppend = new System.Windows.Forms.Button();
            this.dgPaintType = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaintType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(183, 69);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "删除";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtPaintType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAppend);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtPaintType
            // 
            this.txtPaintType.Location = new System.Drawing.Point(88, 29);
            this.txtPaintType.Name = "txtPaintType";
            this.txtPaintType.Size = new System.Drawing.Size(149, 20);
            this.txtPaintType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(24, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "油漆类型：";
            // 
            // btnAppend
            // 
            this.btnAppend.ForeColor = System.Drawing.Color.Blue;
            this.btnAppend.Image = ((System.Drawing.Image)(resources.GetObject("btnAppend.Image")));
            this.btnAppend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppend.Location = new System.Drawing.Point(27, 69);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(90, 27);
            this.btnAppend.TabIndex = 11;
            this.btnAppend.Text = "增加";
            this.btnAppend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // dgPaintType
            // 
            this.dgPaintType.AllowUserToAddRows = false;
            this.dgPaintType.AllowUserToDeleteRows = false;
            this.dgPaintType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaintType.Location = new System.Drawing.Point(12, 128);
            this.dgPaintType.Name = "dgPaintType";
            this.dgPaintType.ReadOnly = true;
            this.dgPaintType.Size = new System.Drawing.Size(409, 275);
            this.dgPaintType.TabIndex = 13;
            this.dgPaintType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUserInfo_CellClick);
            // 
            // FrmOilPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgPaintType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOilPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "喷漆类型维护";
            this.Load += new System.EventHandler(this.FrmOilPaint_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaintType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPaintType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.DataGridView dgPaintType;
    }
}