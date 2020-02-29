namespace ZBSSys
{
    partial class FrmQueryByZbsID
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
            this.txtZbsID = new System.Windows.Forms.TextBox();
            this.btnQueryByZbsID = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFHdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCarNumber = new System.Windows.Forms.TextBox();
            this.lbTotalZhishu = new System.Windows.Forms.Label();
            this.lbTotalWeight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(331, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "证书编号：";
            // 
            // txtZbsID
            // 
            this.txtZbsID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZbsID.Location = new System.Drawing.Point(442, 68);
            this.txtZbsID.Name = "txtZbsID";
            this.txtZbsID.Size = new System.Drawing.Size(194, 30);
            this.txtZbsID.TabIndex = 1;
            // 
            // btnQueryByZbsID
            // 
            this.btnQueryByZbsID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQueryByZbsID.Location = new System.Drawing.Point(668, 64);
            this.btnQueryByZbsID.Name = "btnQueryByZbsID";
            this.btnQueryByZbsID.Size = new System.Drawing.Size(187, 34);
            this.btnQueryByZbsID.TabIndex = 2;
            this.btnQueryByZbsID.Text = "查询并导出数据";
            this.btnQueryByZbsID.UseVisualStyleBackColor = true;
            this.btnQueryByZbsID.Click += new System.EventHandler(this.btnQueryByZbsID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(331, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "发货日期：";
            // 
            // txtFHdate
            // 
            this.txtFHdate.Enabled = false;
            this.txtFHdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFHdate.Location = new System.Drawing.Point(442, 125);
            this.txtFHdate.Name = "txtFHdate";
            this.txtFHdate.Size = new System.Drawing.Size(127, 30);
            this.txtFHdate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(331, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "装载车号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(331, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "发货支数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(331, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "发货吨位：";
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.Enabled = false;
            this.txtCarNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCarNumber.Location = new System.Drawing.Point(443, 177);
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(126, 30);
            this.txtCarNumber.TabIndex = 9;
            // 
            // lbTotalZhishu
            // 
            this.lbTotalZhishu.AutoSize = true;
            this.lbTotalZhishu.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotalZhishu.Location = new System.Drawing.Point(457, 232);
            this.lbTotalZhishu.Name = "lbTotalZhishu";
            this.lbTotalZhishu.Size = new System.Drawing.Size(19, 20);
            this.lbTotalZhishu.TabIndex = 10;
            this.lbTotalZhishu.Text = "0";
            // 
            // lbTotalWeight
            // 
            this.lbTotalWeight.AutoSize = true;
            this.lbTotalWeight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotalWeight.Location = new System.Drawing.Point(457, 286);
            this.lbTotalWeight.Name = "lbTotalWeight";
            this.lbTotalWeight.Size = new System.Drawing.Size(19, 20);
            this.lbTotalWeight.TabIndex = 11;
            this.lbTotalWeight.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(540, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "支";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(540, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "吨";
            // 
            // FrmQueryByZbsID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 549);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTotalWeight);
            this.Controls.Add(this.lbTotalZhishu);
            this.Controls.Add(this.txtCarNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFHdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQueryByZbsID);
            this.Controls.Add(this.txtZbsID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmQueryByZbsID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "根据质保书编号查询信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZbsID;
        private System.Windows.Forms.Button btnQueryByZbsID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFHdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCarNumber;
        private System.Windows.Forms.Label lbTotalZhishu;
        private System.Windows.Forms.Label lbTotalWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}