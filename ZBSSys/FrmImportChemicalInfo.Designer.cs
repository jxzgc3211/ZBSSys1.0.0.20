namespace ZBSSys
{
    partial class FrmImportChemicalInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePathName = new System.Windows.Forms.TextBox();
            this.bntOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnImportData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbYuanshiCount = new System.Windows.Forms.Label();
            this.lbSucessCount = new System.Windows.Forms.Label();
            this.lbFailCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbExInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件路径：";
            // 
            // txtFilePathName
            // 
            this.txtFilePathName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFilePathName.Location = new System.Drawing.Point(138, 113);
            this.txtFilePathName.Name = "txtFilePathName";
            this.txtFilePathName.Size = new System.Drawing.Size(529, 30);
            this.txtFilePathName.TabIndex = 1;
            // 
            // bntOpenFile
            // 
            this.bntOpenFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bntOpenFile.Location = new System.Drawing.Point(682, 108);
            this.bntOpenFile.Name = "bntOpenFile";
            this.bntOpenFile.Size = new System.Drawing.Size(111, 37);
            this.bntOpenFile.TabIndex = 2;
            this.bntOpenFile.Text = "选择文件";
            this.bntOpenFile.UseVisualStyleBackColor = true;
            this.bntOpenFile.Click += new System.EventHandler(this.bntOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportData
            // 
            this.btnImportData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImportData.Location = new System.Drawing.Point(165, 222);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(488, 64);
            this.btnImportData.TabIndex = 3;
            this.btnImportData.Text = "开始导入化学成分数据";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(157, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "请使用2007版的固定excel文件格式进行导入";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "原始数据共计：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "添加成功数据：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "异常数据：";
            // 
            // lbYuanshiCount
            // 
            this.lbYuanshiCount.AutoSize = true;
            this.lbYuanshiCount.Location = new System.Drawing.Point(414, 325);
            this.lbYuanshiCount.Name = "lbYuanshiCount";
            this.lbYuanshiCount.Size = new System.Drawing.Size(0, 15);
            this.lbYuanshiCount.TabIndex = 9;
            // 
            // lbSucessCount
            // 
            this.lbSucessCount.AutoSize = true;
            this.lbSucessCount.Location = new System.Drawing.Point(414, 366);
            this.lbSucessCount.Name = "lbSucessCount";
            this.lbSucessCount.Size = new System.Drawing.Size(0, 15);
            this.lbSucessCount.TabIndex = 10;
            // 
            // lbFailCount
            // 
            this.lbFailCount.AutoSize = true;
            this.lbFailCount.Location = new System.Drawing.Point(414, 411);
            this.lbFailCount.Name = "lbFailCount";
            this.lbFailCount.Size = new System.Drawing.Size(0, 15);
            this.lbFailCount.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(495, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "条";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "条";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(495, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "条";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(277, 453);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "异常信息：";
            // 
            // lbExInfo
            // 
            this.lbExInfo.AutoSize = true;
            this.lbExInfo.Location = new System.Drawing.Point(414, 453);
            this.lbExInfo.Name = "lbExInfo";
            this.lbExInfo.Size = new System.Drawing.Size(0, 15);
            this.lbExInfo.TabIndex = 16;
            // 
            // FrmImportChemicalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 574);
            this.Controls.Add(this.lbExInfo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbFailCount);
            this.Controls.Add(this.lbSucessCount);
            this.Controls.Add(this.lbYuanshiCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.bntOpenFile);
            this.Controls.Add(this.txtFilePathName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmImportChemicalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入产品化学成分信息";
            this.Load += new System.EventHandler(this.FrmImportChemicalInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePathName;
        private System.Windows.Forms.Button bntOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbYuanshiCount;
        private System.Windows.Forms.Label lbSucessCount;
        private System.Windows.Forms.Label lbFailCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbExInfo;
    }
}