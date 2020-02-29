namespace ZBSSys
{
    partial class FrmProductStandard
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
            this.txtPStandardNumber = new System.Windows.Forms.TextBox();
            this.txtPStandardName = new System.Windows.Forms.TextBox();
            this.addNewStandard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvStandards = new System.Windows.Forms.DataGridView();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandards)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "标准代号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "标准名称：";
            // 
            // txtPStandardNumber
            // 
            this.txtPStandardNumber.Location = new System.Drawing.Point(149, 157);
            this.txtPStandardNumber.Name = "txtPStandardNumber";
            this.txtPStandardNumber.Size = new System.Drawing.Size(221, 25);
            this.txtPStandardNumber.TabIndex = 2;
            // 
            // txtPStandardName
            // 
            this.txtPStandardName.Location = new System.Drawing.Point(149, 216);
            this.txtPStandardName.Name = "txtPStandardName";
            this.txtPStandardName.Size = new System.Drawing.Size(221, 25);
            this.txtPStandardName.TabIndex = 3;
            // 
            // addNewStandard
            // 
            this.addNewStandard.Location = new System.Drawing.Point(38, 345);
            this.addNewStandard.Name = "addNewStandard";
            this.addNewStandard.Size = new System.Drawing.Size(95, 33);
            this.addNewStandard.TabIndex = 4;
            this.addNewStandard.Text = "添加标准";
            this.addNewStandard.UseVisualStyleBackColor = true;
            this.addNewStandard.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "修改标准";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(356, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 33);
            this.button3.TabIndex = 6;
            this.button3.Text = "删除标准";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvStandards
            // 
            this.dgvStandards.AllowUserToAddRows = false;
            this.dgvStandards.AllowUserToDeleteRows = false;
            this.dgvStandards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStandards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SID,
            this.SNumber,
            this.SName,
            this.Column1});
            this.dgvStandards.Location = new System.Drawing.Point(498, 84);
            this.dgvStandards.Name = "dgvStandards";
            this.dgvStandards.ReadOnly = true;
            this.dgvStandards.RowHeadersWidth = 51;
            this.dgvStandards.RowTemplate.Height = 27;
            this.dgvStandards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStandards.Size = new System.Drawing.Size(662, 294);
            this.dgvStandards.TabIndex = 7;
            // 
            // SID
            // 
            this.SID.DataPropertyName = "id";
            this.SID.HeaderText = "系统流水号";
            this.SID.MinimumWidth = 6;
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            this.SID.Width = 125;
            // 
            // SNumber
            // 
            this.SNumber.DataPropertyName = "pStandardNumber";
            this.SNumber.HeaderText = "标准编号";
            this.SNumber.MinimumWidth = 6;
            this.SNumber.Name = "SNumber";
            this.SNumber.ReadOnly = true;
            this.SNumber.Width = 125;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "pStandardName";
            this.SName.HeaderText = "标准名称";
            this.SName.MinimumWidth = 6;
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "pId";
            this.Column1.HeaderText = "标准ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "系统中的标准清单";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "标准id号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "标准ID：";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(149, 269);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(221, 25);
            this.txtPID.TabIndex = 12;
            // 
            // FrmProductStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 576);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvStandards);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addNewStandard);
            this.Controls.Add(this.txtPStandardName);
            this.Controls.Add(this.txtPStandardNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductStandard";
            this.Text = "产品标准清单维护";
            this.Load += new System.EventHandler(this.FrmProductStandard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPStandardNumber;
        private System.Windows.Forms.TextBox txtPStandardName;
        private System.Windows.Forms.Button addNewStandard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvStandards;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}