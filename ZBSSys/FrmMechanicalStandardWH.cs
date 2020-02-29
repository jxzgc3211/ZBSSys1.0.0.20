using System;
using System.Collections;
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
    public partial class FrmMechanicalStandardWH : Form
    {
        public FrmMechanicalStandardWH()
        {
            InitializeComponent();
        }

        private void FrmMechanicalStandardWH_Load(object sender, EventArgs e)
        {
            string sql = " select pStandardNumber, pId from product_standardinfo";

            DataTable dt = SqlHelper.ExecuteTable(sql);
            List<ProductStandardInfo> psi = new List<ProductStandardInfo>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                psi.Add(new ProductStandardInfo
                {
                    pStandardNumber = dt.Rows[i]["pStandardNumber"].ToString(),
                    pId = Convert.ToInt32(dt.Rows[i]["pId"])
                });
            }

            cmbStandardList.DisplayMember = "pStandardNumber";
            cmbStandardList.ValueMember = "pId";
            cmbStandardList.DataSource = dt;

            string sqlWenDu = "select * from product_shiyanwendu";
            dt = SqlHelper.ExecuteTable(sqlWenDu);
            ArrayList al = new ArrayList();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                al.Add(dt.Rows[i]["pT"].ToString());
            }
            lbPT.DisplayMember = "pT";
            lbPT.ValueMember = "pT";
            lbPT.DataSource = al;


            //初始化文本框内容为0
            //txtMinYS.Text = "0";
            //txtMaxYS.Text = "0";
            //txtMinRm.Text = "0";
            //txtMaxRm.Text = "0";
            //txtMinA.Text = "0";
            //txtMaxA.Text = "0";
            //txtMinKvAvg.Text = "0";
            //txtMaxKvAvg.Text = "0";

        }

        private void cmbStandardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int standardId = Convert.ToInt32(cmbStandardList.SelectedValue);
            //MessageBox.Show(standardId.ToString());
            string sql = " select GradeName from product_gradeList where StandardID=" + standardId;

            DataTable dt = SqlHelper.ExecuteTable(sql);
            List<GradeAndStandard> gas = new List<GradeAndStandard>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gas.Add(new GradeAndStandard
                {
                    GradeName = dt.Rows[i]["GradeName"].ToString()
                });
            }
            cmbGradeList.DisplayMember = "GradeName";
            cmbGradeList.ValueMember = "GradeName";
            cmbGradeList.DataSource = dt;
        }

        private void rdbTType1_CheckedChanged(object sender, EventArgs e)
        {
            rdbLenWanR1.Checked = rdbTType1.Checked;
        }

        private void rdbTType2_CheckedChanged(object sender, EventArgs e)
        {
            rdbLenWanR2.Checked = rdbTType2.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string standardName = SqlHelper.ExecutScalar("select pstandardnumber from product_standardinfo where pid=" + Convert.ToInt32(cmbStandardList.SelectedValue)).ToString();
            string gradeName = cmbGradeList.SelectedValue.ToString();
            int tType = 1;
            if (rdbTType1.Checked)
            {
                tType = 1;

            }
            else if (rdbTType2.Checked)
            {
                tType = 2;

            }
            string ysName = "ReL";
            if (rdbReL.Checked)
            {
                ysName = "ReL";
            }
            else if (rdbReH.Checked)
            {
                ysName = "ReH";
            }

            int pYsMin = 0;
            if (!string.IsNullOrEmpty(txtMinYS.Text.Trim()))
            {
                pYsMin = Convert.ToInt32(txtMinYS.Text.Trim());
            }
            int pYsMax = 0;
            if (!string.IsNullOrEmpty(txtMaxYS.Text.Trim()))
            {
                pYsMax = Convert.ToInt32(txtMaxYS.Text.Trim());
            }
            int pRmMin = 0;
            if (!string.IsNullOrEmpty(txtMinRm.Text.Trim()))
            {
                pRmMin = Convert.ToInt32(txtMinRm.Text.Trim());
            }
            int pRmMax = 0;
            if (!string.IsNullOrEmpty(txtMaxRm.Text.Trim()))
            {
                pRmMax = Convert.ToInt32(txtMaxRm.Text.Trim());
            }
            int pAMin = 0;
            if (!string.IsNullOrEmpty(txtMinA.Text.Trim()))
            {
                pAMin = Convert.ToInt32(txtMinA.Text.Trim());
            }
            int pAMax = 0;
            if (!string.IsNullOrEmpty(txtMaxA.Text.Trim()))
            {
                pAMax = Convert.ToInt32(txtMaxA.Text.Trim());
            }

            string pD = "D=2a";
            if (rdbLenWanR1.Checked)
            {
                pD = "D=2a";
            }
            else if (rdbLenWanR2.Checked)
            {
                pD = "D=3a";
            }
            int pKvAvgMin = 0;
            if (!string.IsNullOrEmpty(txtMinKvAvg.Text.Trim()))
            {
                pKvAvgMin = Convert.ToInt32(txtMinKvAvg.Text.Trim());
            }
            int pKvAvgMax = 0;
            if (!string.IsNullOrEmpty(txtMaxKvAvg.Text.Trim()))
            {
                pKvAvgMax = Convert.ToInt32(txtMaxKvAvg.Text.Trim());
            }
            string pT = lbPT.SelectedValue.ToString();

            string sql = "insert into product_mechanicalStandard values(@standardName,@gradeName,@tType,@ysName,@pYsMin,@pYsMax,@pRmMin,@pRmMax,@pAMin,@pAMax,@pD,@pKvAvgMin,@pKvAvgMax,@pT)";
            SqlParameter[] ps =
            {
                new SqlParameter("@standardName",standardName),
                new SqlParameter("@gradeName",gradeName),
                new SqlParameter("@tType",tType),
                new SqlParameter("@ysName",ysName),
                new SqlParameter("@pYsMin",pYsMin),
                new SqlParameter("@pYsMax",pYsMax),
                new SqlParameter("@pRmMin",pRmMin),
                new SqlParameter("@pRmMax",pRmMax),
                new SqlParameter("@pAMin",pAMin),
                new SqlParameter("@pAMax",pAMax),
                new SqlParameter("@pD",pD),
                new SqlParameter("@pKvAvgMin",pKvAvgMin),
                new SqlParameter("@pKvAvgMax",pKvAvgMax),
                new SqlParameter("@pT",pT)
            };
            if (!string.IsNullOrEmpty(txtMinYS.Text.Trim()) && !string.IsNullOrEmpty(txtMinRm.Text.Trim()) &&!string.IsNullOrEmpty(txtMaxRm.Text.Trim()))
            {
                //当关键指标不为空，则执行插入数据的操作
                SqlHelper.ExecuteNonQuery(sql, ps);
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("力学性能指标尚未录入！");
            }
        }
        private void btnShowMechanicalStandard_Click(object sender, EventArgs e)
        {
            FrmMechanicalStandardQingDan frmMechanicalStandardQingDan = new FrmMechanicalStandardQingDan();
            DialogResult dr = frmMechanicalStandardQingDan.ShowDialog();
        }
    }
}
