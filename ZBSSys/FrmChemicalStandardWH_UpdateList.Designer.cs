namespace ZBSSys
{
    partial class FrmChemicalStandardWH_UpdateList
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.修改选中的化学成分标准信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选中的化学成分标准信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvChemicalStandardList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChemicalStandardList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改选中的化学成分标准信息ToolStripMenuItem,
            this.删除选中的化学成分标准信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 修改选中的化学成分标准信息ToolStripMenuItem
            // 
            this.修改选中的化学成分标准信息ToolStripMenuItem.Name = "修改选中的化学成分标准信息ToolStripMenuItem";
            this.修改选中的化学成分标准信息ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.修改选中的化学成分标准信息ToolStripMenuItem.Text = "修改选中的化学成分标准信息";
            this.修改选中的化学成分标准信息ToolStripMenuItem.Click += new System.EventHandler(this.修改选中的化学成分标准信息ToolStripMenuItem_Click);
            // 
            // 删除选中的化学成分标准信息ToolStripMenuItem
            // 
            this.删除选中的化学成分标准信息ToolStripMenuItem.Name = "删除选中的化学成分标准信息ToolStripMenuItem";
            this.删除选中的化学成分标准信息ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.删除选中的化学成分标准信息ToolStripMenuItem.Text = "删除选中的化学成分标准信息";
            this.删除选中的化学成分标准信息ToolStripMenuItem.Click += new System.EventHandler(this.删除选中的化学成分标准信息ToolStripMenuItem_Click);
            // 
            // dgvChemicalStandardList
            // 
            this.dgvChemicalStandardList.AllowUserToAddRows = false;
            this.dgvChemicalStandardList.AllowUserToDeleteRows = false;
            this.dgvChemicalStandardList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChemicalStandardList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChemicalStandardList.Location = new System.Drawing.Point(0, 28);
            this.dgvChemicalStandardList.Name = "dgvChemicalStandardList";
            this.dgvChemicalStandardList.ReadOnly = true;
            this.dgvChemicalStandardList.RowHeadersWidth = 51;
            this.dgvChemicalStandardList.RowTemplate.Height = 27;
            this.dgvChemicalStandardList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChemicalStandardList.Size = new System.Drawing.Size(884, 464);
            this.dgvChemicalStandardList.TabIndex = 1;
            // 
            // FrmChemicalStandardWH_UpdateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 492);
            this.Controls.Add(this.dgvChemicalStandardList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmChemicalStandardWH_UpdateList";
            this.Text = "化学成分标准清单维护";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmChemicalStandardWH_UpdateList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChemicalStandardList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvChemicalStandardList;
        private System.Windows.Forms.ToolStripMenuItem 修改选中的化学成分标准信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除选中的化学成分标准信息ToolStripMenuItem;
    }
}