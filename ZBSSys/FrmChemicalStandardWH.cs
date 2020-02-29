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
    public partial class FrmChemicalStandardWH : Form
    {
        public FrmChemicalStandardWH()
        {
            InitializeComponent();
        }
        //填充产品执行标准信息
        private void FrmChemicalStandardWH_Load(object sender, EventArgs e)
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
        }
        //填充产品钢级信息
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
        //添加化学成分标准
        private void button1_Click(object sender, EventArgs e)
        {
            //获得标准id
            int standardId = Convert.ToInt32(cmbStandardList.SelectedValue);
            string gradeName = cmbGradeList.SelectedValue.ToString();
            //MessageBox.Show(gradeName);
            //16个化学元素，32个文本框
            string sql = "insert into product_chemicalStandardNew values (@standardId,@grade,@cMax,@cMin,@SiMax,@SiMin,@MnMax,@MnMin,@PMax,@PMin,@SMax,@SMin,@NbMax,@NbMin,@VMax,@VMin,@TiMax,@TiMin,@CrMax,@CrMin,@NiMax,@NiMin,@CuMax,@CuMin,@AltMax,@AltMin,@MoMax,@MoMin,@NMax,@NMin,@Ceq1Max,@Ceq1Min,@Ceq2Max,@Ceq2Min)";

            if (string.IsNullOrEmpty(txtCMin.Text))
            {
                txtCMin.Text = "0";
            }

            if (string.IsNullOrEmpty(txtSiMin.Text))
            {
                txtSiMin.Text = "0";
            }

            if (string.IsNullOrEmpty(txtMnMin.Text))
            {
                txtMnMin.Text = "0";
            }

            if (string.IsNullOrEmpty(txtPMin.Text))
            {
                txtPMin.Text = "0";
            }

            if (string.IsNullOrEmpty(txtSMin.Text))
            {
                txtSMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtNbMax.Text))
            {
                txtNbMax.Text = "0";
            }
            if (string.IsNullOrEmpty(txtNbMin.Text))
            {
                txtNbMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtVMax.Text))
            {
                txtVMax.Text = "0";
            }
            if (string.IsNullOrEmpty(txtVMin.Text))
            {
                txtVMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTiMax.Text))
            {
                txtTiMax.Text = "0";
            }
            if (string.IsNullOrEmpty(txtTiMin.Text))
            {
                txtTiMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCrMax.Text))
            {
                txtCrMax.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCrMin.Text))
            {
                txtCrMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtNiMax.Text))
            {
                txtNiMax.Text = "0";
            }
            if (string.IsNullOrEmpty(txtNiMin.Text))
            {
                txtNiMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCuMax.Text))
            {
                txtCuMax.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCuMin.Text))
            {
                txtCuMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtAltMax.Text))
            {
                txtAltMax.Text = "0";
            }
            if (string.IsNullOrEmpty(txtAltMin.Text))
            {
                txtAltMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtMoMax.Text))
            {
                txtMoMax.Text = "0";
            }
            if (string.IsNullOrEmpty(txtMoMin.Text))
            {
                txtMoMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtNMax.Text))
            {
                txtNMax.Text = "0";
            }
            if (string.IsNullOrEmpty(txtNMin.Text))
            {
                txtNMin.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCeq1Max.Text))
            {
                txtCeq1Max.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCeq1Min.Text))
            {
                txtCeq1Min.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCeq2Max.Text))
            {
                txtCeq2Max.Text = "0";
            }
            if (string.IsNullOrEmpty(txtCeq2Min.Text))
            {
                txtCeq2Min.Text = "0";
            }

            SqlParameter[] ps =
            {
                new SqlParameter("@standardId",standardId),
                new SqlParameter("@grade",gradeName),
                new SqlParameter("@cMax",txtCMax.Text),
                new SqlParameter("@cMin",txtCMin.Text),
                new SqlParameter("@SiMax",txtSiMax.Text),
                new SqlParameter("@SiMin",txtSiMin.Text),
                new SqlParameter("@MnMax",txtMnMax.Text),
                new SqlParameter("@MnMin",txtMnMin.Text),
                new SqlParameter("@PMax",txtPMax.Text),
                new SqlParameter("@PMin",txtPMin.Text),
                new SqlParameter("@SMax",txtSMax.Text),
                new SqlParameter("@SMin",txtSMin.Text),
                new SqlParameter("@NbMax",txtNbMax.Text),
                new SqlParameter("@NbMin",txtNbMin.Text),
                new SqlParameter("@VMax",txtVMax.Text),
                new SqlParameter("@VMin",txtVMin.Text),
                new SqlParameter("@TiMax",txtTiMax.Text),
                new SqlParameter("@TiMin",txtTiMin.Text),
                new SqlParameter("@CrMax",txtCrMax.Text),
                new SqlParameter("@CrMin",txtCrMin.Text),
                new SqlParameter("@NiMax",txtNiMax.Text),
                new SqlParameter("@NiMin",txtNiMin.Text),
                new SqlParameter("@CuMax",txtCuMax.Text),
                new SqlParameter("@CuMin",txtCuMin.Text),
                new SqlParameter("@AltMax",txtAltMax.Text),
                new SqlParameter("@AltMin",txtAltMin.Text),
                new SqlParameter("@MoMax",txtMoMax.Text),
                new SqlParameter("@MoMin",txtMoMin.Text),
                new SqlParameter("@NMax",txtNMax.Text),
                new SqlParameter("@NMin",txtNMin.Text),
                new SqlParameter("@Ceq1Max",txtCeq1Max.Text),
                new SqlParameter("@Ceq1Min",txtCeq1Min.Text),
                new SqlParameter("@Ceq2Max",txtCeq2Max.Text),
                new SqlParameter("@Ceq2Min",txtCeq2Min.Text)
            };
            //如果C元素为空，则不执行插入程序
            if (!string.IsNullOrEmpty(txtCMax.Text))
            {
                int tag = SqlHelper.ExecuteNonQuery(sql, ps);
                if (tag > 0)
                {
                    MessageBox.Show("化学成分录入成功！");
                }
                else
                {
                    MessageBox.Show("化学成分录入失败！");
                }
            }
            else
            {
                MessageBox.Show("请录入5大元素的化学成分信息！");
            }

        }

        private void btnShowChemicalStandardList_Click(object sender, EventArgs e)
        {
            FrmChemicalStandardWH_UpdateList frmChemicalStaList = new FrmChemicalStandardWH_UpdateList();
            DialogResult dr = frmChemicalStaList.ShowDialog();
        }
    }
}
