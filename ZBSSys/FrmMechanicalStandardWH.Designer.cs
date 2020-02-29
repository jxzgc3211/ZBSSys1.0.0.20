namespace ZBSSys
{
    partial class FrmMechanicalStandardWH
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
            this.label2 = new System.Windows.Forms.Label();
            this.rdbTType1 = new System.Windows.Forms.RadioButton();
            this.rdbTType2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStandardList = new System.Windows.Forms.ComboBox();
            this.cmbGradeList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaxA = new System.Windows.Forms.TextBox();
            this.txtMinA = new System.Windows.Forms.TextBox();
            this.txtMaxRm = new System.Windows.Forms.TextBox();
            this.txtMinRm = new System.Windows.Forms.TextBox();
            this.txtMaxYS = new System.Windows.Forms.TextBox();
            this.txtMinYS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbReH = new System.Windows.Forms.RadioButton();
            this.rdbReL = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxKvAvg = new System.Windows.Forms.TextBox();
            this.lbPT = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinKvAvg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbLenWanR2 = new System.Windows.Forms.RadioButton();
            this.rdbLenWanR1 = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowMechanicalStandard = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品执行表标准：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "钢级信息：";
            // 
            // rdbTType1
            // 
            this.rdbTType1.AutoSize = true;
            this.rdbTType1.Location = new System.Drawing.Point(77, 33);
            this.rdbTType1.Name = "rdbTType1";
            this.rdbTType1.Size = new System.Drawing.Size(75, 19);
            this.rdbTType1.TabIndex = 2;
            this.rdbTType1.TabStop = true;
            this.rdbTType1.Text = "≤16mm";
            this.rdbTType1.UseVisualStyleBackColor = true;
            this.rdbTType1.CheckedChanged += new System.EventHandler(this.rdbTType1_CheckedChanged);
            // 
            // rdbTType2
            // 
            this.rdbTType2.AutoSize = true;
            this.rdbTType2.Location = new System.Drawing.Point(174, 33);
            this.rdbTType2.Name = "rdbTType2";
            this.rdbTType2.Size = new System.Drawing.Size(75, 19);
            this.rdbTType2.TabIndex = 3;
            this.rdbTType2.TabStop = true;
            this.rdbTType2.Text = "＞16mm";
            this.rdbTType2.UseVisualStyleBackColor = true;
            this.rdbTType2.CheckedChanged += new System.EventHandler(this.rdbTType2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "屈服强度标识：";
            // 
            // cmbStandardList
            // 
            this.cmbStandardList.FormattingEnabled = true;
            this.cmbStandardList.Location = new System.Drawing.Point(386, 22);
            this.cmbStandardList.Name = "cmbStandardList";
            this.cmbStandardList.Size = new System.Drawing.Size(221, 23);
            this.cmbStandardList.TabIndex = 8;
            this.cmbStandardList.SelectedIndexChanged += new System.EventHandler(this.cmbStandardList_SelectedIndexChanged);
            // 
            // cmbGradeList
            // 
            this.cmbGradeList.FormattingEnabled = true;
            this.cmbGradeList.Location = new System.Drawing.Point(386, 82);
            this.cmbGradeList.Name = "cmbGradeList";
            this.cmbGradeList.Size = new System.Drawing.Size(221, 23);
            this.cmbGradeList.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTType1);
            this.groupBox1.Controls.Add(this.rdbTType2);
            this.groupBox1.Location = new System.Drawing.Point(38, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "厚度类型";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaxA);
            this.groupBox2.Controls.Add(this.txtMinA);
            this.groupBox2.Controls.Add(this.txtMaxRm);
            this.groupBox2.Controls.Add(this.txtMinRm);
            this.groupBox2.Controls.Add(this.txtMaxYS);
            this.groupBox2.Controls.Add(this.txtMinYS);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdbReH);
            this.groupBox2.Controls.Add(this.rdbReL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(38, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 279);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "拉伸性能标准";
            // 
            // txtMaxA
            // 
            this.txtMaxA.Location = new System.Drawing.Point(196, 224);
            this.txtMaxA.Name = "txtMaxA";
            this.txtMaxA.Size = new System.Drawing.Size(76, 25);
            this.txtMaxA.TabIndex = 16;
            // 
            // txtMinA
            // 
            this.txtMinA.Location = new System.Drawing.Point(99, 224);
            this.txtMinA.Name = "txtMinA";
            this.txtMinA.Size = new System.Drawing.Size(76, 25);
            this.txtMinA.TabIndex = 15;
            // 
            // txtMaxRm
            // 
            this.txtMaxRm.Location = new System.Drawing.Point(196, 167);
            this.txtMaxRm.Name = "txtMaxRm";
            this.txtMaxRm.Size = new System.Drawing.Size(76, 25);
            this.txtMaxRm.TabIndex = 14;
            // 
            // txtMinRm
            // 
            this.txtMinRm.Location = new System.Drawing.Point(99, 167);
            this.txtMinRm.Name = "txtMinRm";
            this.txtMinRm.Size = new System.Drawing.Size(76, 25);
            this.txtMinRm.TabIndex = 13;
            // 
            // txtMaxYS
            // 
            this.txtMaxYS.Location = new System.Drawing.Point(196, 109);
            this.txtMaxYS.Name = "txtMaxYS";
            this.txtMaxYS.Size = new System.Drawing.Size(76, 25);
            this.txtMaxYS.TabIndex = 12;
            // 
            // txtMinYS
            // 
            this.txtMinYS.Location = new System.Drawing.Point(99, 109);
            this.txtMinYS.Name = "txtMinYS";
            this.txtMinYS.Size = new System.Drawing.Size(76, 25);
            this.txtMinYS.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "延伸率：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "抗拉强度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "屈服强度：";
            // 
            // rdbReH
            // 
            this.rdbReH.AutoSize = true;
            this.rdbReH.Location = new System.Drawing.Point(209, 34);
            this.rdbReH.Name = "rdbReH";
            this.rdbReH.Size = new System.Drawing.Size(52, 19);
            this.rdbReH.TabIndex = 1;
            this.rdbReH.TabStop = true;
            this.rdbReH.Text = "ReH";
            this.rdbReH.UseVisualStyleBackColor = true;
            // 
            // rdbReL
            // 
            this.rdbReL.AutoSize = true;
            this.rdbReL.Location = new System.Drawing.Point(124, 34);
            this.rdbReL.Name = "rdbReL";
            this.rdbReL.Size = new System.Drawing.Size(52, 19);
            this.rdbReL.TabIndex = 0;
            this.rdbReL.TabStop = true;
            this.rdbReL.Text = "ReL";
            this.rdbReL.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtMaxKvAvg);
            this.groupBox3.Controls.Add(this.lbPT);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtMinKvAvg);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(386, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 279);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "冲击性能";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Max";
            // 
            // txtMaxKvAvg
            // 
            this.txtMaxKvAvg.Location = new System.Drawing.Point(185, 109);
            this.txtMaxKvAvg.Name = "txtMaxKvAvg";
            this.txtMaxKvAvg.Size = new System.Drawing.Size(76, 25);
            this.txtMaxKvAvg.TabIndex = 21;
            // 
            // lbPT
            // 
            this.lbPT.FormattingEnabled = true;
            this.lbPT.ItemHeight = 15;
            this.lbPT.Location = new System.Drawing.Point(85, 167);
            this.lbPT.Name = "lbPT";
            this.lbPT.Size = new System.Drawing.Size(176, 94);
            this.lbPT.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "试验温度：";
            // 
            // txtMinKvAvg
            // 
            this.txtMinKvAvg.Location = new System.Drawing.Point(85, 109);
            this.txtMinKvAvg.Name = "txtMinKvAvg";
            this.txtMinKvAvg.Size = new System.Drawing.Size(76, 25);
            this.txtMinKvAvg.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "冲击均值：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(104, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Min";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbLenWanR2);
            this.groupBox4.Controls.Add(this.rdbLenWanR1);
            this.groupBox4.Location = new System.Drawing.Point(386, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 65);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "冷弯半径";
            // 
            // rdbLenWanR2
            // 
            this.rdbLenWanR2.AutoSize = true;
            this.rdbLenWanR2.Location = new System.Drawing.Point(150, 33);
            this.rdbLenWanR2.Name = "rdbLenWanR2";
            this.rdbLenWanR2.Size = new System.Drawing.Size(60, 19);
            this.rdbLenWanR2.TabIndex = 1;
            this.rdbLenWanR2.TabStop = true;
            this.rdbLenWanR2.Text = "D=3a";
            this.rdbLenWanR2.UseVisualStyleBackColor = true;
            // 
            // rdbLenWanR1
            // 
            this.rdbLenWanR1.AutoSize = true;
            this.rdbLenWanR1.Location = new System.Drawing.Point(58, 33);
            this.rdbLenWanR1.Name = "rdbLenWanR1";
            this.rdbLenWanR1.Size = new System.Drawing.Size(60, 19);
            this.rdbLenWanR1.TabIndex = 0;
            this.rdbLenWanR1.TabStop = true;
            this.rdbLenWanR1.Text = "D=2a";
            this.rdbLenWanR1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(710, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(206, 55);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "保存力学性能标准";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowMechanicalStandard
            // 
            this.btnShowMechanicalStandard.Location = new System.Drawing.Point(710, 247);
            this.btnShowMechanicalStandard.Name = "btnShowMechanicalStandard";
            this.btnShowMechanicalStandard.Size = new System.Drawing.Size(206, 55);
            this.btnShowMechanicalStandard.TabIndex = 16;
            this.btnShowMechanicalStandard.Text = "查看力学性能标准清单";
            this.btnShowMechanicalStandard.UseVisualStyleBackColor = true;
            this.btnShowMechanicalStandard.Click += new System.EventHandler(this.btnShowMechanicalStandard_Click);
            // 
            // FrmMechanicalStandardWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 561);
            this.Controls.Add(this.btnShowMechanicalStandard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbGradeList);
            this.Controls.Add(this.cmbStandardList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMechanicalStandardWH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加力学性能标准数据";
            this.Load += new System.EventHandler(this.FrmMechanicalStandardWH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbTType1;
        private System.Windows.Forms.RadioButton rdbTType2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStandardList;
        private System.Windows.Forms.ComboBox cmbGradeList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbReH;
        private System.Windows.Forms.RadioButton rdbReL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxA;
        private System.Windows.Forms.TextBox txtMinA;
        private System.Windows.Forms.TextBox txtMaxRm;
        private System.Windows.Forms.TextBox txtMinRm;
        private System.Windows.Forms.TextBox txtMaxYS;
        private System.Windows.Forms.TextBox txtMinYS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMinKvAvg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbPT;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbLenWanR2;
        private System.Windows.Forms.RadioButton rdbLenWanR1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxKvAvg;
        private System.Windows.Forms.Button btnShowMechanicalStandard;
    }
}