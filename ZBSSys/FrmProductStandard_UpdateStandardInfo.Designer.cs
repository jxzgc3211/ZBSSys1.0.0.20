﻿namespace ZBSSys
{
    partial class FrmProductStandard_UpdateStandardInfo
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
            this.lbXiTongID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPStandardNumber = new System.Windows.Forms.TextBox();
            this.txtPStandardName = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(189, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "系统流水号：";
            // 
            // lbXiTongID
            // 
            this.lbXiTongID.AutoSize = true;
            this.lbXiTongID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbXiTongID.Location = new System.Drawing.Point(350, 60);
            this.lbXiTongID.Name = "lbXiTongID";
            this.lbXiTongID.Size = new System.Drawing.Size(69, 20);
            this.lbXiTongID.TabIndex = 1;
            this.lbXiTongID.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(189, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "标准代号：";
            // 
            // txtPStandardNumber
            // 
            this.txtPStandardNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPStandardNumber.Location = new System.Drawing.Point(319, 114);
            this.txtPStandardNumber.Name = "txtPStandardNumber";
            this.txtPStandardNumber.Size = new System.Drawing.Size(204, 30);
            this.txtPStandardNumber.TabIndex = 3;
            // 
            // txtPStandardName
            // 
            this.txtPStandardName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPStandardName.Location = new System.Drawing.Point(319, 171);
            this.txtPStandardName.Name = "txtPStandardName";
            this.txtPStandardName.Size = new System.Drawing.Size(204, 30);
            this.txtPStandardName.TabIndex = 4;
            // 
            // txtPID
            // 
            this.txtPID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPID.Location = new System.Drawing.Point(319, 234);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(204, 30);
            this.txtPID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(189, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "标准名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(189, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "标准ID：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(270, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "确认修改标准信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmProductStandard_UpdateStandardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.txtPStandardName);
            this.Controls.Add(this.txtPStandardNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbXiTongID);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductStandard_UpdateStandardInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品执行标准信息修改";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbXiTongID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPStandardNumber;
        private System.Windows.Forms.TextBox txtPStandardName;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}