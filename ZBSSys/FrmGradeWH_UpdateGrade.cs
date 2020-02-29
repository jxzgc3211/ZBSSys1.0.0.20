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
    public partial class FrmGradeWH_UpdateGrade : Form
    {
        public FrmGradeWH_UpdateGrade()
        {
            InitializeComponent();
        }

        private void FrmGradeWH_UpdateGrade_Load(object sender, EventArgs e)
        {

        }
        //添加一个事件，用于通知主界面
        public event FreshForm FreshForm1;

        public void ShowGradeInfo(int id)
        {
            string sql = "select * from product_gradelist where id=" + id;
            DataTable dt = SqlHelper.ExecuteTable(sql);
            label2.Text = id.ToString();
            txtGradeName.Text = dt.Rows[0]["gradename"].ToString();
            txtStandardID.Text = dt.Rows[0]["standardId"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //修改             
            string sql = "update product_gradelist set gradename=@gradeName where id=" + Convert.ToInt32(label2.Text);
            SqlParameter ps = new SqlParameter("@gradeName", txtGradeName.Text);
            int result = SqlHelper.ExecuteNonQuery(sql, ps);
            if (result > 0)
            {
                //发布消息
                FreshForm1();
                this.Close();
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }
    }
}

