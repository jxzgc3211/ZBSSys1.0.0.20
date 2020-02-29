using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZBSSys
{
    public partial class FrmProductStandard : Form
    {
        public FrmProductStandard()
        {
            InitializeComponent();
        }
        public void SetLableID()
        {
            label5.Text = "";
        }
        private void ListStandard()
        {
            string sql = "select * from product_standardinfo";
            DataTable dt = SqlHelper.ExecuteTable(sql);
            dgvStandards.DataSource = dt;
            dgvStandards.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvStandards.AutoGenerateColumns = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into product_standardinfo values(@pstandardNumber,@pstandardName,@pId)";
            SqlParameter[] ps =
               {
                new SqlParameter("@pstandardNumber",txtPStandardNumber.Text),
                new SqlParameter("@pstandardName",txtPStandardName.Text),
                new SqlParameter("@pId",txtPID.Text)
            };
            if (!string.IsNullOrEmpty(txtPStandardName.Text.Trim()) || !string.IsNullOrEmpty(txtPStandardNumber.Text.Trim()))
            {
                int tag = SqlHelper.ExecuteNonQuery(sql, ps);
                if (tag > 0)
                {
                    MessageBox.Show("标准添加成功！");
                    txtPStandardNumber.Text = "";
                    txtPStandardName.Text = "";
                    txtPID.Text = "";
                    ListStandard();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            else
            {
                MessageBox.Show("标准编号或标准名称不能为空！");
            }

        }

        private void FrmProductStandard_Load(object sender, EventArgs e)
        {
            ListStandard();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string id = dgvStandards.SelectedRows[0].Cells[0].Value.ToString();

            string sql = "delete from product_standardinfo where id=" + id;
            if (MessageBox.Show("是否要删除该标准？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlHelper.ExecuteNonQuery(sql);
                ListStandard();
            }
        }
        //注册事件
        public event ShowStudent ChuanID;
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvStandards.SelectedRows[0].Cells[0].Value);
            FrmProductStandard_UpdateStandardInfo frmProductStandard_UpdateStandardInfo = new FrmProductStandard_UpdateStandardInfo();
            ChuanID+= frmProductStandard_UpdateStandardInfo.ShowStandardInfo;
            ChuanID(id);
            frmProductStandard_UpdateStandardInfo.Show();
            //加载ListStandard标准方法
            frmProductStandard_UpdateStandardInfo.FreshStandardList += ListStandard;
        }
    }
}
