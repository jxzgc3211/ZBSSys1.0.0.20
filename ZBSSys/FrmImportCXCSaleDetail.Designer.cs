namespace ZBSSys
{
    partial class FrmImportCXCSaleDetail
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDBJiaoGang = new System.Windows.Forms.RadioButton();
            this.rdbBDBJiaoGang = new System.Windows.Forms.RadioButton();
            this.rdbL = new System.Windows.Forms.RadioButton();
            this.rdbBP = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbDCLD = new System.Windows.Forms.RadioButton();
            this.rdbLW = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbRFXG = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(303, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择发货的时间区间";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(470, 79);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "至";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "导入发货数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRFXG);
            this.groupBox1.Controls.Add(this.rdbLW);
            this.groupBox1.Controls.Add(this.rdbDCLD);
            this.groupBox1.Controls.Add(this.rdbAll);
            this.groupBox1.Controls.Add(this.rdbBP);
            this.groupBox1.Controls.Add(this.rdbL);
            this.groupBox1.Controls.Add(this.rdbBDBJiaoGang);
            this.groupBox1.Controls.Add(this.rdbDBJiaoGang);
            this.groupBox1.Location = new System.Drawing.Point(86, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 241);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择导入的发货产品类型";
            // 
            // rdbDBJiaoGang
            // 
            this.rdbDBJiaoGang.AutoSize = true;
            this.rdbDBJiaoGang.Checked = true;
            this.rdbDBJiaoGang.Location = new System.Drawing.Point(32, 34);
            this.rdbDBJiaoGang.Name = "rdbDBJiaoGang";
            this.rdbDBJiaoGang.Size = new System.Drawing.Size(71, 16);
            this.rdbDBJiaoGang.TabIndex = 0;
            this.rdbDBJiaoGang.TabStop = true;
            this.rdbDBJiaoGang.Text = "等边角钢";
            this.rdbDBJiaoGang.UseVisualStyleBackColor = true;
            // 
            // rdbBDBJiaoGang
            // 
            this.rdbBDBJiaoGang.AutoSize = true;
            this.rdbBDBJiaoGang.Location = new System.Drawing.Point(32, 59);
            this.rdbBDBJiaoGang.Name = "rdbBDBJiaoGang";
            this.rdbBDBJiaoGang.Size = new System.Drawing.Size(83, 16);
            this.rdbBDBJiaoGang.TabIndex = 1;
            this.rdbBDBJiaoGang.Text = "不等边角钢";
            this.rdbBDBJiaoGang.UseVisualStyleBackColor = true;
            // 
            // rdbL
            // 
            this.rdbL.AutoSize = true;
            this.rdbL.Location = new System.Drawing.Point(32, 84);
            this.rdbL.Name = "rdbL";
            this.rdbL.Size = new System.Drawing.Size(119, 16);
            this.rdbL.TabIndex = 2;
            this.rdbL.Text = "不等边不等厚角钢";
            this.rdbL.UseVisualStyleBackColor = true;
            // 
            // rdbBP
            // 
            this.rdbBP.AutoSize = true;
            this.rdbBP.Location = new System.Drawing.Point(32, 109);
            this.rdbBP.Name = "rdbBP";
            this.rdbBP.Size = new System.Drawing.Size(59, 16);
            this.rdbBP.TabIndex = 3;
            this.rdbBP.Text = "球扁钢";
            this.rdbBP.UseVisualStyleBackColor = true;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(32, 198);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(95, 16);
            this.rdbAll.TabIndex = 4;
            this.rdbAll.Text = "全部发货产品";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbDCLD
            // 
            this.rdbDCLD.AutoSize = true;
            this.rdbDCLD.Location = new System.Drawing.Point(32, 176);
            this.rdbDCLD.Name = "rdbDCLD";
            this.rdbDCLD.Size = new System.Drawing.Size(83, 16);
            this.rdbDCLD.TabIndex = 5;
            this.rdbDCLD.Text = "单齿履带钢";
            this.rdbDCLD.UseVisualStyleBackColor = true;
            // 
            // rdbLW
            // 
            this.rdbLW.AutoSize = true;
            this.rdbLW.Location = new System.Drawing.Point(32, 154);
            this.rdbLW.Name = "rdbLW";
            this.rdbLW.Size = new System.Drawing.Size(59, 16);
            this.rdbLW.TabIndex = 6;
            this.rdbLW.Text = "轮辋钢";
            this.rdbLW.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "日期：";
            // 
            // rdbRFXG
            // 
            this.rdbRFXG.AutoSize = true;
            this.rdbRFXG.Location = new System.Drawing.Point(32, 132);
            this.rdbRFXG.Name = "rdbRFXG";
            this.rdbRFXG.Size = new System.Drawing.Size(71, 16);
            this.rdbRFXG.TabIndex = 7;
            this.rdbRFXG.TabStop = true;
            this.rdbRFXG.Text = "人防型钢";
            this.rdbRFXG.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "本次导入：";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(442, 366);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 12);
            this.lbCount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "条数据。";
            // 
            // FrmImportCXCSaleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "FrmImportCXCSaleDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入产销存系统中的发货数据";
            this.Load += new System.EventHandler(this.FrmImportCXCSaleDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbLW;
        private System.Windows.Forms.RadioButton rdbDCLD;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbBP;
        private System.Windows.Forms.RadioButton rdbL;
        private System.Windows.Forms.RadioButton rdbBDBJiaoGang;
        private System.Windows.Forms.RadioButton rdbDBJiaoGang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbRFXG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label6;
    }
}