namespace ZBSSys
{
    partial class FrmImportProductDeliveryInfo
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
            this.btnImportData = new System.Windows.Forms.Button();
            this.bntOpenFile = new System.Windows.Forms.Button();
            this.txtFilePathName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(138, 221);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(488, 64);
            this.btnImportData.TabIndex = 11;
            this.btnImportData.Text = "开始导入产品发货明细";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // bntOpenFile
            // 
            this.bntOpenFile.Location = new System.Drawing.Point(673, 76);
            this.bntOpenFile.Name = "bntOpenFile";
            this.bntOpenFile.Size = new System.Drawing.Size(111, 37);
            this.bntOpenFile.TabIndex = 10;
            this.bntOpenFile.Text = "选择文件";
            this.bntOpenFile.UseVisualStyleBackColor = true;
            this.bntOpenFile.Click += new System.EventHandler(this.bntOpenFile_Click);
            // 
            // txtFilePathName
            // 
            this.txtFilePathName.Location = new System.Drawing.Point(138, 84);
            this.txtFilePathName.Name = "txtFilePathName";
            this.txtFilePathName.Size = new System.Drawing.Size(529, 25);
            this.txtFilePathName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "文件路径：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmImportProductDeliveryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.bntOpenFile);
            this.Controls.Add(this.txtFilePathName);
            this.Controls.Add(this.label1);
            this.Name = "FrmImportProductDeliveryInfo";
            this.Text = "FrmImportProductDeliveryInfo";
            this.Load += new System.EventHandler(this.FrmImportProductDeliveryInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Button bntOpenFile;
        private System.Windows.Forms.TextBox txtFilePathName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}