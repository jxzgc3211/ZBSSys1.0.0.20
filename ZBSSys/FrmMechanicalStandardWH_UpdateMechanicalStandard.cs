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
    public partial class FrmMechanicalStandardWH_UpdateMechanicalStandard : Form
    {
        public FrmMechanicalStandardWH_UpdateMechanicalStandard()
        {
            InitializeComponent();
        }

        private void FrmMechanicalStandardWH_UpdateMechanicalStandard_Load(object sender, EventArgs e)
        {

        }
        public void LoadStandardInfo(int id)
        {
            lbXuhao.Text = id.ToString();
            string sql = "select * from product_mechanicalStandard where id=@Id";
            SqlParameter param = new SqlParameter("@Id", id);
            SqlDataReader reader = SqlHelper.ExecuteReader(sql, param);
            while (reader.Read())
            {
                lbStandardNumber.Text = reader["pStandard"].ToString();
                lbGrade.Text = reader["pGrade"].ToString();
                lbTtype.Text = reader["tType"].ToString();
                lbYsType.Text = reader["pYsName"].ToString();
                txtYsMin.Text = reader["pYsMin"].ToString();
                txtYsMax.Text = Convert.ToInt32(reader["pYsMax"]).ToString();
                txtRmMin.Text = Convert.ToInt32(reader["pRmMin"]).ToString();
                txtRmMax.Text = Convert.ToInt32(reader["pRmMax"]).ToString();
                txtAMin.Text = Convert.ToInt32(reader["pAMin"]).ToString();
                txtAMax.Text = Convert.ToInt32(reader["pAMax"]).ToString();
                if (reader["pD"].ToString().Equals("D=2a"))
                {
                    rdb2a.Checked = true;
                }
                else if (reader["pD"].ToString().Equals("D=3a"))
                {
                    rdb3a.Checked = true;
                }
                txtKvgMin.Text = Convert.ToInt32(reader["pKvAvgMin"]).ToString();
                txtKvgMax.Text = Convert.ToInt32(reader["pKvAvgMax"]).ToString();
                txtPt.Text = reader["pT"].ToString();
            }
        }
        public event FreshForm ReloadMecStandard;
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update product_mechanicalStandard set pYsMin=@pYsMin,pYsMax=@pYsMax,pRmMin=@pRmMin,pRmMax=@pRmMax,pAMin=@pAMin,pAMax=@pAMax,pD=@pD,pKvAvgMin=@pKvAvgMin,pKvAvgMax=@pKvAvgMax,pT=@pT where id=" + Convert.ToInt32(lbXuhao.Text);
            string lengwan = "";
            if (rdb2a.Checked)
            {
                lengwan = rdb2a.Text;
            }
            else if (rdb3a.Checked)
            {
                lengwan = rdb3a.Text;
            }
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@pYsMin",Convert.ToInt32(txtYsMin.Text)),
                new SqlParameter("@pYsMax",Convert.ToInt32(txtYsMax.Text)),
                new SqlParameter("@pRmMin",Convert.ToInt32(txtRmMin.Text)),
                new SqlParameter("@pRmMax",Convert.ToInt32(txtRmMax.Text)),
                new SqlParameter("@pAMin",Convert.ToInt32(txtAMin.Text)),
                new SqlParameter("@pAMax",Convert.ToInt32(txtAMax.Text)),
                new SqlParameter("@pD",lengwan),
                new SqlParameter("@pKvAvgMin", Convert.ToInt32(txtKvgMin.Text)),
                new SqlParameter("@pKvAvgMax", Convert.ToInt32(txtKvgMax.Text)),
                new SqlParameter("@pT",txtPt.Text)
            };
            if (string.IsNullOrEmpty(txtYsMin.Text)) {
                txtYsMin.Text = "0";
            }

            if (string.IsNullOrEmpty(txtYsMax.Text))
            {
                txtYsMax.Text = "0";
            }

            if (string.IsNullOrEmpty(txtRmMin.Text))
            {
                txtRmMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtRmMax.Text))
            {
                txtRmMax.Text = "0";
            }

            if (string.IsNullOrEmpty(txtAMin.Text))
            {
                txtAMin.Text = "0";
            }


            if (string.IsNullOrEmpty(txtAMax.Text) || txtAMax.Text.Equals(""))
            {
                txtAMax.Text = "0";
            }

            if (string.IsNullOrEmpty(txtKvgMin.Text))
            {
                txtKvgMin.Text = "0";
            }

            if (string.IsNullOrEmpty(txtKvgMax.Text))
            {
                txtKvgMax.Text = "0";
            }
            int tag= SqlHelper.ExecuteNonQuery(sql, param);
            if (tag > 0)
            {
                ReloadMecStandard();
                MessageBox.Show("力学性能标准指标修改成功！");
                this.Close();
            }  
        }
    }
}
