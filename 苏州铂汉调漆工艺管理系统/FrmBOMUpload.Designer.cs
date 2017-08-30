namespace 调漆工艺管理系统
{
    partial class FrmBOMUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBOMUpload));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.tabControlBOM = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgBOMInfo = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbErrorMessage = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlBOM.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBOMInfo)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnBrowseFile);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 123);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabControlBOM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 323);
            this.panel2.TabIndex = 1;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(90, 24);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(446, 78);
            this.txtFileName.TabIndex = 1;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowseFile.ForeColor = System.Drawing.Color.Blue;
            this.btnBrowseFile.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseFile.Image")));
            this.btnBrowseFile.Location = new System.Drawing.Point(16, 24);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(68, 78);
            this.btnBrowseFile.TabIndex = 11;
            this.btnBrowseFile.Text = "BOM模板";
            this.btnBrowseFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBrowseFile.UseVisualStyleBackColor = false;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(575, 72);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(149, 30);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "数据上传";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(575, 24);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(149, 30);
            this.btnVerify.TabIndex = 13;
            this.btnVerify.Text = "数据导入";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // tabControlBOM
            // 
            this.tabControlBOM.Controls.Add(this.tabPage3);
            this.tabControlBOM.Controls.Add(this.tabPage1);
            this.tabControlBOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlBOM.Location = new System.Drawing.Point(0, 0);
            this.tabControlBOM.Name = "tabControlBOM";
            this.tabControlBOM.SelectedIndex = 0;
            this.tabControlBOM.Size = new System.Drawing.Size(820, 321);
            this.tabControlBOM.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgBOMInfo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(812, 295);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BOM信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgBOMInfo
            // 
            this.dgBOMInfo.AllowUserToAddRows = false;
            this.dgBOMInfo.AllowUserToDeleteRows = false;
            this.dgBOMInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBOMInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBOMInfo.Location = new System.Drawing.Point(3, 3);
            this.dgBOMInfo.Name = "dgBOMInfo";
            this.dgBOMInfo.ReadOnly = true;
            this.dgBOMInfo.Size = new System.Drawing.Size(806, 289);
            this.dgBOMInfo.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbErrorMessage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(812, 295);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "错误信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtbErrorMessage
            // 
            this.rtbErrorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbErrorMessage.Location = new System.Drawing.Point(0, 0);
            this.rtbErrorMessage.Name = "rtbErrorMessage";
            this.rtbErrorMessage.Size = new System.Drawing.Size(812, 295);
            this.rtbErrorMessage.TabIndex = 0;
            this.rtbErrorMessage.Text = "";
            // 
            // FrmBOMUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmBOMUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOM上传";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControlBOM.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBOMInfo)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TabControl tabControlBOM;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgBOMInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtbErrorMessage;
    }
}