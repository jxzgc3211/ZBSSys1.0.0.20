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
    public partial class FrmProductStandard_UpdateStandardInfo : Form
    {
        public FrmProductStandard_UpdateStandardInfo()
        {
            InitializeComponent();
        }
        public void ShowStandardInfo(int id)
        {
            string sql = "  select * from product_standardinfo where id=" + id;
            DataTable dt = SqlHelper.ExecuteTable(sql);
            lbXiTongID.Text = id.ToString();
            txtPStandardNumber.Text = dt.Rows[0]["pStandardNumber"].ToString();
            txtPStandardName.Text = dt.Rows[0]["pStandardName"].ToString();
            txtPID.Text = dt.Rows[0]["pId"].ToString();
        }

        //添加一个事件，用于通知主界面
        public event FreshForm FreshStandardList;
        private void button1_Click(object sender, EventArgs e)
        {
            //修改             
            string sql = "update product_standardinfo set pStandardNumber=@pStandardNumber,pStandardName=@pStandardName,pId=@pId where id=" + Convert.ToInt32(lbXiTongID.Text);
            SqlParameter[] ps = new SqlParameter[]
            {
               new SqlParameter("@pStandardNumber",txtPStandardNumber.Text),
               new SqlParameter("@pStandardName",txtPStandardName.Text),
               new SqlParameter("@pId",Convert.ToInt32(txtPID.Text))
             };
            int result = SqlHelper.ExecuteNonQuery(sql, ps);
            if (result > 0)
            {
                //发布消息
                FreshStandardList() ;
                this.Close();
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }
    }
}
