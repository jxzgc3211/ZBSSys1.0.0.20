using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBSSys
{
    public partial class FrmMechanicalStandardQingDan : Form
    {
        public FrmMechanicalStandardQingDan()
        {
            InitializeComponent();
        }

        private void LoadMechanicalStandardList()
        {
            string sql = "select * from  product_mechanicalStandard";
            DataTable dt = SqlHelper.ExecuteTable(sql);
            dgvMechanicalList.DataSource = dt;
        }
        private void FrmMechanicalStandardQingDan_Load(object sender, EventArgs e)
        {
            LoadMechanicalStandardList();
        }

        public event ShowStudent ChuanId;
        private void 修改选中行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvMechanicalList.SelectedRows[0].Cells[0].Value);
            FrmMechanicalStandardWH_UpdateMechanicalStandard updateMecS = new FrmMechanicalStandardWH_UpdateMechanicalStandard();
            //传递id值到子窗口
            ChuanId += updateMecS.LoadStandardInfo;
            ChuanId(id);
            //刷新力学性能清单
            updateMecS.ReloadMecStandard += LoadMechanicalStandardList;
            DialogResult dr = updateMecS.ShowDialog();
        }

        private void 删除选中的标准ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvMechanicalList.SelectedRows[0].Cells[0].Value);
            string sql = "delete product_mechanicalStandard where id=" + id;
            //删除前弹出提示框
            if (MessageBox.Show("是否要删除该标准？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlHelper.ExecuteNonQuery(sql);
                LoadMechanicalStandardList();
            }
        }
    }
}
