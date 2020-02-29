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
    public partial class FrmGradeWH : Form
    {
        public FrmGradeWH()
        {
            InitializeComponent();
        }

        private void FrmGradeWH_Load(object sender, EventArgs e)
        {
            string sql = "select pstandardNumber,pid from product_standardinfo";
            DataTable dt = SqlHelper.ExecuteTable(sql);
            List<GradeAndStandard> gs = new List<GradeAndStandard>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gs.Add(new GradeAndStandard
                {
                    GradeName = dt.Rows[i]["pstandardNumber"].ToString(),
                    StandardId = Convert.ToInt32(dt.Rows[i]["pid"])

                    //dt.Rows[0][0]
                });
            }
            cmbStandardList.DisplayMember = "pstandardNumber";
            cmbStandardList.ValueMember = "pid";
            cmbStandardList.DataSource = dt;
        }
        private void ListStandardInfo()
        {
            int standardId = Convert.ToInt32(cmbStandardList.SelectedValue);
            //MessageBox.Show(standardId.ToString());
            string sql = "select * from product_gradelist where standardid = " + standardId;
            DataTable dt = SqlHelper.ExecuteTable(sql);
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// 读取系统已经录入的标准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbStandardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListStandardInfo();
        }
        /// <summary>
        /// 添加新钢级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddGrade_Click(object sender, EventArgs e)
        {

            string gradeName = txtGradeName.Text;
            int standardId = Convert.ToInt32(cmbStandardList.SelectedValue);
            if (!string.IsNullOrEmpty(gradeName))
            {
                string sql = "insert into product_gradelist values(@gradeName,@standardId)";
                SqlParameter[] ps =
                {
                new SqlParameter("@gradeName",gradeName),
                new SqlParameter("@standardId",standardId)
                 };
                int tag = SqlHelper.ExecuteNonQuery(sql, ps);
                if (tag > 0)
                {
                    txtGradeName.Text = "";
                    MessageBox.Show("新钢级添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListStandardInfo();
                }
                else
                {
                    MessageBox.Show("添加钢级失败！");
                }
            }
        }
        /// <summary>
        /// 删除钢级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelGrade_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            string sql = "delete from product_gradelist where id=" + id;
            int tag = SqlHelper.ExecuteNonQuery(sql);
            if (tag > 0)
            {
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ListStandardInfo();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }
        /// <summary>
        /// 修改钢级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //a-事件
        public event ShowStudent updateGradeList;
        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            
            FrmGradeWH_UpdateGrade updateGrade = new FrmGradeWH_UpdateGrade();
            
            updateGrade.FreshForm1 += ListStandardInfo;

            updateGradeList += updateGrade.ShowGradeInfo;
            //调用a-事件
            updateGradeList(id);//a-事件  发布显示内容的消息，调用studentInfo中的ShowStudentInfo方法
            updateGrade.Show();
        }
    }
}
