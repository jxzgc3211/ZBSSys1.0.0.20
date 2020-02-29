namespace ZBSSys
{
    partial class FrmImportMechaincalInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbExInfo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbFailCount = new System.Windows.Forms.Label();
            this.lbSucessCount = new System.Windows.Forms.Label();
            this.lbYuanshiCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImportData
            // 
            this.btnImportData.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnImportData.Location = new System.Drawing.Point(162, 139);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(488, 64);
            this.btnImportData.TabIndex = 7;
            this.btnImportData.Text = "开始导入力学性能数据";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // bntOpenFile
            // 
            this.bntOpenFile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bntOpenFile.Location = new System.Drawing.Point(677, 80);
            this.bntOpenFile.Name = "bntOpenFile";
            this.bntOpenFile.Size = new System.Drawing.Size(111, 37);
            this.bntOpenFile.TabIndex = 6;
            this.bntOpenFile.Text = "选择文件";
            this.bntOpenFile.UseVisualStyleBackColor = true;
            this.bntOpenFile.Click += new System.EventHandler(this.bntOpenFile_Click_1);
            // 
            // txtFilePathName
            // 
            this.txtFilePathName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFilePathName.Location = new System.Drawing.Point(133, 85);
            this.txtFilePathName.Name = "txtFilePathName";
            this.txtFilePathName.Size = new System.Drawing.Size(529, 30);
            this.txtFilePathName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "文件路径：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(158, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "请使用2007版的固定excel文件格式进行导入";
            // 
            // lbExInfo
            // 
            this.lbExInfo.AutoSize = true;
            this.lbExInfo.Location = new System.Drawing.Point(423, 352);
            this.lbExInfo.Name = "lbExInfo";
            this.lbExInfo.Size = new System.Drawing.Size(0, 15);
            this.lbExInfo.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(286, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "异常信息：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(504, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "条";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(504, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "条";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "条";
            // 
            // lbFailCount
            // 
            this.lbFailCount.AutoSize = true;
            this.lbFailCount.Location = new System.Drawing.Point(423, 310);
            this.lbFailCount.Name = "lbFailCount";
            this.lbFailCount.Size = new System.Drawing.Size(0, 15);
            this.lbFailCount.TabIndex = 22;
            // 
            // lbSucessCount
            // 
            this.lbSucessCount.AutoSize = true;
            this.lbSucessCount.Location = new System.Drawing.Point(423, 265);
            this.lbSucessCount.Name = "lbSucessCount";
            this.lbSucessCount.Size = new System.Drawing.Size(0, 15);
            this.lbSucessCount.TabIndex = 21;
            // 
            // lbYuanshiCount
            // 
            this.lbYuanshiCount.AutoSize = true;
            this.lbYuanshiCount.Location = new System.Drawing.Point(423, 224);
            this.lbYuanshiCount.Name = "lbYuanshiCount";
            this.lbYuanshiCount.Size = new System.Drawing.Size(0, 15);
            this.lbYuanshiCount.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "异常数据：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "添加成功数据：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "原始数据共计：";
            // 
            // FrmImportMechaincalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FrmImportMechaincalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入力学性能数据";
            this.Load += new System.EventHandler(this.FrmImportMechaincalInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Button bntOpenFile;
        private System.Windows.Forms.TextBox txtFilePathName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbExInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbFailCount;
        private System.Windows.Forms.Label lbSucessCount;
        private System.Windows.Forms.Label lbYuanshiCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}