namespace ZBSSys
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnSelectDeliveryinfo = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listCarNumber = new System.Windows.Forms.ListBox();
            this.dgvShowInfo = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pStandard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRollNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weights = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.导入产销存发货数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入产品化学成分明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入产品力学性能明细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品标准维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品钢级维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.化学成分标准维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.力学性能标准维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询质保书信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.listZBSBH = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectZBS = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbDBJG = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbJianshu = new System.Windows.Forms.Label();
            this.lbZhishi = new System.Windows.Forms.Label();
            this.lbZhongliang = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectDeliveryinfo
            // 
            this.btnSelectDeliveryinfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectDeliveryinfo.Location = new System.Drawing.Point(917, 47);
            this.btnSelectDeliveryinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectDeliveryinfo.Name = "btnSelectDeliveryinfo";
            this.btnSelectDeliveryinfo.Size = new System.Drawing.Size(275, 59);
            this.btnSelectDeliveryinfo.TabIndex = 0;
            this.btnSelectDeliveryinfo.Text = "按时间段查询发货信息";
            this.btnSelectDeliveryinfo.UseVisualStyleBackColor = true;
            this.btnSelectDeliveryinfo.Click += new System.EventHandler(this.SelectDetailByDeliveryDate);
            // 
            // dtpStart
            // 
            this.dtpStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(332, 63);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(213, 25);
            this.dtpStart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(159, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "筛选发货周期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "-------";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(652, 63);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(225, 25);
            this.dtpEnd.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listCarNumber);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(55, 107);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(184, 232);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "装车列表";
            // 
            // listCarNumber
            // 
            this.listCarNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCarNumber.FormattingEnabled = true;
            this.listCarNumber.ItemHeight = 18;
            this.listCarNumber.Location = new System.Drawing.Point(3, 23);
            this.listCarNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listCarNumber.Name = "listCarNumber";
            this.listCarNumber.Size = new System.Drawing.Size(178, 207);
            this.listCarNumber.TabIndex = 0;
            this.listCarNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listCarNumber_MouseClick);
            this.listCarNumber.SelectedIndexChanged += new System.EventHandler(this.listCarNumber_SelectedIndexChanged);
            // 
            // dgvShowInfo
            // 
            this.dgvShowInfo.AllowUserToAddRows = false;
            this.dgvShowInfo.AllowUserToDeleteRows = false;
            this.dgvShowInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.contractNumber,
            this.customerName,
            this.carNumber,
            this.deliveryDate,
            this.pType,
            this.pStandard,
            this.pName,
            this.ttype,
            this.pGrade,
            this.pRollNumber,
            this.pLength,
            this.packages,
            this.numbers,
            this.weights});
            this.dgvShowInfo.Location = new System.Drawing.Point(12, 358);
            this.dgvShowInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowInfo.Name = "dgvShowInfo";
            this.dgvShowInfo.ReadOnly = true;
            this.dgvShowInfo.RowHeadersWidth = 51;
            this.dgvShowInfo.RowTemplate.Height = 27;
            this.dgvShowInfo.Size = new System.Drawing.Size(1448, 552);
            this.dgvShowInfo.TabIndex = 10;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "序号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // contractNumber
            // 
            this.contractNumber.DataPropertyName = "constractNumber";
            this.contractNumber.HeaderText = "合同编号";
            this.contractNumber.MinimumWidth = 6;
            this.contractNumber.Name = "contractNumber";
            this.contractNumber.ReadOnly = true;
            this.contractNumber.Width = 118;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "客户名称";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 119;
            // 
            // carNumber
            // 
            this.carNumber.DataPropertyName = "carNumber";
            this.carNumber.HeaderText = "车号";
            this.carNumber.MinimumWidth = 6;
            this.carNumber.Name = "carNumber";
            this.carNumber.ReadOnly = true;
            this.carNumber.Width = 118;
            // 
            // deliveryDate
            // 
            this.deliveryDate.DataPropertyName = "deliveryDate";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.deliveryDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.deliveryDate.HeaderText = "发货日期";
            this.deliveryDate.MinimumWidth = 6;
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.ReadOnly = true;
            this.deliveryDate.Width = 119;
            // 
            // pType
            // 
            this.pType.DataPropertyName = "pType";
            this.pType.HeaderText = "品种";
            this.pType.MinimumWidth = 6;
            this.pType.Name = "pType";
            this.pType.ReadOnly = true;
            this.pType.Width = 125;
            // 
            // pStandard
            // 
            this.pStandard.DataPropertyName = "pStandard";
            this.pStandard.HeaderText = "执行标准";
            this.pStandard.MinimumWidth = 6;
            this.pStandard.Name = "pStandard";
            this.pStandard.ReadOnly = true;
            this.pStandard.Width = 118;
            // 
            // pName
            // 
            this.pName.DataPropertyName = "pName";
            this.pName.HeaderText = "产品规格";
            this.pName.MinimumWidth = 6;
            this.pName.Name = "pName";
            this.pName.ReadOnly = true;
            this.pName.Width = 118;
            // 
            // ttype
            // 
            this.ttype.DataPropertyName = "tType";
            this.ttype.HeaderText = "厚度类型";
            this.ttype.MinimumWidth = 6;
            this.ttype.Name = "ttype";
            this.ttype.ReadOnly = true;
            this.ttype.Width = 125;
            // 
            // pGrade
            // 
            this.pGrade.DataPropertyName = "pGrade";
            this.pGrade.HeaderText = "钢级";
            this.pGrade.MinimumWidth = 6;
            this.pGrade.Name = "pGrade";
            this.pGrade.ReadOnly = true;
            this.pGrade.Width = 119;
            // 
            // pRollNumber
            // 
            this.pRollNumber.DataPropertyName = "pRollNumber";
            this.pRollNumber.HeaderText = "轧制批号";
            this.pRollNumber.MinimumWidth = 6;
            this.pRollNumber.Name = "pRollNumber";
            this.pRollNumber.ReadOnly = true;
            this.pRollNumber.Width = 118;
            // 
            // pLength
            // 
            this.pLength.DataPropertyName = "pLength";
            this.pLength.HeaderText = "长度";
            this.pLength.MinimumWidth = 6;
            this.pLength.Name = "pLength";
            this.pLength.ReadOnly = true;
            this.pLength.Width = 119;
            // 
            // packages
            // 
            this.packages.DataPropertyName = "pBundle";
            this.packages.HeaderText = "发货件数";
            this.packages.MinimumWidth = 6;
            this.packages.Name = "packages";
            this.packages.ReadOnly = true;
            this.packages.Width = 118;
            // 
            // numbers
            // 
            this.numbers.DataPropertyName = "pNumber";
            this.numbers.HeaderText = "发货支数";
            this.numbers.MinimumWidth = 6;
            this.numbers.Name = "numbers";
            this.numbers.ReadOnly = true;
            this.numbers.Width = 119;
            // 
            // weights
            // 
            this.weights.DataPropertyName = "pWeight";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.weights.DefaultCellStyle = dataGridViewCellStyle2;
            this.weights.HeaderText = "发货吨位";
            this.weights.MinimumWidth = 6;
            this.weights.Name = "weights";
            this.weights.ReadOnly = true;
            this.weights.Width = 118;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入产销存发货数据ToolStripMenuItem,
            this.导入产品化学成分明细ToolStripMenuItem,
            this.导入产品力学性能明细ToolStripMenuItem,
            this.产品标准维护ToolStripMenuItem,
            this.产品钢级维护ToolStripMenuItem,
            this.化学成分标准维护ToolStripMenuItem,
            this.力学性能标准维护ToolStripMenuItem,
            this.查询质保书信息ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1493, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导入产销存发货数据ToolStripMenuItem
            // 
            this.导入产销存发货数据ToolStripMenuItem.Name = "导入产销存发货数据ToolStripMenuItem";
            this.导入产销存发货数据ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.导入产销存发货数据ToolStripMenuItem.Text = "导入产销存发货数据";
            this.导入产销存发货数据ToolStripMenuItem.Click += new System.EventHandler(this.导入产销存发货数据ToolStripMenuItem_Click);
            // 
            // 导入产品化学成分明细ToolStripMenuItem
            // 
            this.导入产品化学成分明细ToolStripMenuItem.Name = "导入产品化学成分明细ToolStripMenuItem";
            this.导入产品化学成分明细ToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.导入产品化学成分明细ToolStripMenuItem.Text = "导入产品化学成分明细";
            this.导入产品化学成分明细ToolStripMenuItem.Click += new System.EventHandler(this.导入产品化学成分明细ToolStripMenuItem_Click);
            // 
            // 导入产品力学性能明细ToolStripMenuItem
            // 
            this.导入产品力学性能明细ToolStripMenuItem.Name = "导入产品力学性能明细ToolStripMenuItem";
            this.导入产品力学性能明细ToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.导入产品力学性能明细ToolStripMenuItem.Text = "导入产品力学性能明细";
            this.导入产品力学性能明细ToolStripMenuItem.Click += new System.EventHandler(this.导入产品力学性能明细ToolStripMenuItem_Click);
            // 
            // 产品标准维护ToolStripMenuItem
            // 
            this.产品标准维护ToolStripMenuItem.Name = "产品标准维护ToolStripMenuItem";
            this.产品标准维护ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.产品标准维护ToolStripMenuItem.Text = "产品标准维护";
            this.产品标准维护ToolStripMenuItem.Click += new System.EventHandler(this.产品标准维护ToolStripMenuItem_Click);
            // 
            // 产品钢级维护ToolStripMenuItem
            // 
            this.产品钢级维护ToolStripMenuItem.Name = "产品钢级维护ToolStripMenuItem";
            this.产品钢级维护ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.产品钢级维护ToolStripMenuItem.Text = "产品钢级维护";
            this.产品钢级维护ToolStripMenuItem.Click += new System.EventHandler(this.产品钢级维护ToolStripMenuItem_Click);
            // 
            // 化学成分标准维护ToolStripMenuItem
            // 
            this.化学成分标准维护ToolStripMenuItem.Name = "化学成分标准维护ToolStripMenuItem";
            this.化学成分标准维护ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.化学成分标准维护ToolStripMenuItem.Text = "化学成分标准维护";
            this.化学成分标准维护ToolStripMenuItem.Click += new System.EventHandler(this.化学成分标准维护ToolStripMenuItem_Click);
            // 
            // 力学性能标准维护ToolStripMenuItem
            // 
            this.力学性能标准维护ToolStripMenuItem.Name = "力学性能标准维护ToolStripMenuItem";
            this.力学性能标准维护ToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.力学性能标准维护ToolStripMenuItem.Text = "力学性能标准维护";
            this.力学性能标准维护ToolStripMenuItem.Click += new System.EventHandler(this.力学性能标准维护ToolStripMenuItem_Click);
            // 
            // 查询质保书信息ToolStripMenuItem
            // 
            this.查询质保书信息ToolStripMenuItem.Name = "查询质保书信息ToolStripMenuItem";
            this.查询质保书信息ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.查询质保书信息ToolStripMenuItem.Text = "查询质保书信息";
            this.查询质保书信息ToolStripMenuItem.Click += new System.EventHandler(this.查询质保书信息ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(686, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "质保书编号列表";
            // 
            // listZBSBH
            // 
            this.listZBSBH.FormattingEnabled = true;
            this.listZBSBH.ItemHeight = 15;
            this.listZBSBH.Location = new System.Drawing.Point(690, 143);
            this.listZBSBH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listZBSBH.Name = "listZBSBH";
            this.listZBSBH.Size = new System.Drawing.Size(187, 199);
            this.listZBSBH.TabIndex = 18;
            // 
            // btnSelectZBS
            // 
            this.btnSelectZBS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectZBS.Location = new System.Drawing.Point(917, 201);
            this.btnSelectZBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectZBS.Name = "btnSelectZBS";
            this.btnSelectZBS.Size = new System.Drawing.Size(275, 61);
            this.btnSelectZBS.TabIndex = 19;
            this.btnSelectZBS.Text = "预览选中的质保书";
            this.btnSelectZBS.UseVisualStyleBackColor = true;
            this.btnSelectZBS.Click += new System.EventHandler(this.btnSelectZBS_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "当日已发：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "辆车";
            // 
            // rdbDBJG
            // 
            this.rdbDBJG.AutoSize = true;
            this.rdbDBJG.Checked = true;
            this.rdbDBJG.Location = new System.Drawing.Point(1264, 66);
            this.rdbDBJG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbDBJG.Name = "rdbDBJG";
            this.rdbDBJG.Size = new System.Drawing.Size(88, 19);
            this.rdbDBJG.TabIndex = 24;
            this.rdbDBJG.TabStop = true;
            this.rdbDBJG.Text = "等边角钢";
            this.rdbDBJG.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "当前车辆装载信息";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "产品件数：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "产品支数：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "产品吨位：";
            // 
            // lbJianshu
            // 
            this.lbJianshu.AutoSize = true;
            this.lbJianshu.Location = new System.Drawing.Point(432, 176);
            this.lbJianshu.Name = "lbJianshu";
            this.lbJianshu.Size = new System.Drawing.Size(15, 15);
            this.lbJianshu.TabIndex = 29;
            this.lbJianshu.Text = "0";
            // 
            // lbZhishi
            // 
            this.lbZhishi.AutoSize = true;
            this.lbZhishi.Location = new System.Drawing.Point(432, 213);
            this.lbZhishi.Name = "lbZhishi";
            this.lbZhishi.Size = new System.Drawing.Size(15, 15);
            this.lbZhishi.TabIndex = 30;
            this.lbZhishi.Text = "0";
            // 
            // lbZhongliang
            // 
            this.lbZhongliang.AutoSize = true;
            this.lbZhongliang.Location = new System.Drawing.Point(432, 250);
            this.lbZhongliang.Name = "lbZhongliang";
            this.lbZhongliang.Size = new System.Drawing.Size(15, 15);
            this.lbZhongliang.TabIndex = 31;
            this.lbZhongliang.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(492, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "吨";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(492, 213);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "支";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(492, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 15);
            this.label16.TabIndex = 32;
            this.label16.Text = "件";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 952);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbZhongliang);
            this.Controls.Add(this.lbZhishi);
            this.Controls.Add(this.lbJianshu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdbDBJG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSelectZBS);
            this.Controls.Add(this.listZBSBH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvShowInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnSelectDeliveryinfo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "电力角钢质保书管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectDeliveryinfo;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listCarNumber;
        private System.Windows.Forms.DataGridView dgvShowInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 产品标准维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品钢级维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 化学成分标准维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 力学性能标准维护ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem 导入产品化学成分明细ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入产品力学性能明细ToolStripMenuItem;
        private System.Windows.Forms.ListBox listZBSBH;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectZBS;
        private System.Windows.Forms.ToolStripMenuItem 导入产销存发货数据ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbDBJG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbJianshu;
        private System.Windows.Forms.Label lbZhishi;
        private System.Windows.Forms.Label lbZhongliang;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem 查询质保书信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pType;
        private System.Windows.Forms.DataGridViewTextBoxColumn pStandard;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn pGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRollNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn packages;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn weights;
    }
}

