namespace ZBSSys
{
    partial class FrmMechanicalStandardQingDan
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
            this.dgvMechanicalList = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.修改选中行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选中的标准ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMechanicalList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMechanicalList
            // 
            this.dgvMechanicalList.AllowUserToAddRows = false;
            this.dgvMechanicalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMechanicalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMechanicalList.Location = new System.Drawing.Point(0, 28);
            this.dgvMechanicalList.Name = "dgvMechanicalList";
            this.dgvMechanicalList.ReadOnly = true;
            this.dgvMechanicalList.RowHeadersWidth = 51;
            this.dgvMechanicalList.RowTemplate.Height = 27;
            this.dgvMechanicalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMechanicalList.Size = new System.Drawing.Size(1131, 478);
            this.dgvMechanicalList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改选中行ToolStripMenuItem,
            this.删除选中的标准ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 修改选中行ToolStripMenuItem
            // 
            this.修改选中行ToolStripMenuItem.Name = "修改选中行ToolStripMenuItem";
            this.修改选中行ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.修改选中行ToolStripMenuItem.Text = "修改选中的标准";
            this.修改选中行ToolStripMenuItem.Click += new System.EventHandler(this.修改选中行ToolStripMenuItem_Click);
            // 
            // 删除选中的标准ToolStripMenuItem
            // 
            this.删除选中的标准ToolStripMenuItem.Name = "删除选中的标准ToolStripMenuItem";
            this.删除选中的标准ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.删除选中的标准ToolStripMenuItem.Text = "删除选中的标准";
            this.删除选中的标准ToolStripMenuItem.Click += new System.EventHandler(this.删除选中的标准ToolStripMenuItem_Click);
            // 
            // FrmMechanicalStandardQingDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 506);
            this.Controls.Add(this.dgvMechanicalList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMechanicalStandardQingDan";
            this.Text = "产品力学性能标准管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMechanicalStandardQingDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMechanicalList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMechanicalList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改选中行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除选中的标准ToolStripMenuItem;
    }
}