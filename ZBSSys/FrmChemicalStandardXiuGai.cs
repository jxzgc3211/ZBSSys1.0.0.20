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
    public partial class FrmChemicalStandardXiuGai : Form
    {

        public FrmChemicalStandardXiuGai()
        {
            InitializeComponent();

        }
        public void LoadBaseInfo(ProductStandardInfo psi, ProductChemicalStandard pcs)
        {
            lbStandarNumber.Text = psi.pStandardNumber;
            lbStandardId.Text = psi.pId.ToString();
            lbpGrade.Text = pcs.pGrade;
            lbChemailID.Text = pcs.pChemicalId.ToString();
            txtCMax.Text = pcs.pCMax.ToString();
            txtCMin.Text = pcs.pCMin.ToString();
            txtSiMax.Text = pcs.pSiMax.ToString();
            txtSiMin.Text = pcs.pSiMin.ToString();
            txtMnMax.Text = pcs.pMnMax.ToString();
            txtMnMin.Text = pcs.pMnMin.ToString();
            txtPMax.Text = pcs.pPMax.ToString();
            txtPMin.Text = pcs.pPMin.ToString();
            txtSMax.Text = pcs.pSMax.ToString();
            txtSMin.Text = pcs.pSMin.ToString();
            txtNbMax.Text = pcs.pNbMax.ToString();
            txtNbMin.Text = pcs.pNbMin.ToString();
            txtVMax.Text = pcs.pVMax.ToString();
            txtVMin.Text = pcs.pVMin.ToString();
            txtTiMax.Text = pcs.pTiMax.ToString();
            txtTiMin.Text = pcs.pTiMin.ToString();
            txtCrMax.Text = pcs.pCrMax.ToString();
            txtCrMin.Text = pcs.pCrMin.ToString();
            txtNiMax.Text = pcs.pNiMax.ToString();
            txtNiMin.Text = pcs.pNiMin.ToString();
            txtCuMax.Text = pcs.pCuMax.ToString();
            txtCuMin.Text = pcs.pCuMin.ToString();
            txtAltMax.Text = pcs.pAltMax.ToString();
            txtAltMin.Text = pcs.pAltMin.ToString();
            txtMoMax.Text = pcs.pMoMax.ToString();
            txtMoMin.Text = pcs.pMoMin.ToString();
            txtNMax.Text = pcs.pNMax.ToString();
            txtNMin.Text = pcs.pNMin.ToString();
            txtCeq1Max.Text = pcs.pCeq1Max.ToString();
            txtCeq1Min.Text = pcs.pCeq1Min.ToString();
            txtCeq2Max.Text = pcs.pCeq2Max.ToString();
            txtCeq2Min.Text = pcs.pCeq2Min.ToString();

        }

        private void FrmChemicalStandardXiuGai_Load(object sender, EventArgs e)
        {

        }
        public event FreshForm FreashList;
        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update product_chemicalStandardNew set pCMax=@cMax,pCMin=@cMin,pSiMax=@SiMax,pSiMin=@SiMin,pMnMax=@MnMax,pMnMin=@MnMin,pPMax=@PMax,pPmin=@PMin,pSMax=@SMax,pSMin=@SMin,pNbMax=@NbMax,pNbMin=@NbMin,pVMax=@VMax,pVMin=@VMin,pTiMax=@TiMax,pTiMin=@TiMin,pCrMax=@CrMax,pCrMin=@CrMin,pNiMax=@NiMax,pNiMin=@NiMin,pCuMax=@CuMax,pCuMin=@CuMin,pAltMax=@AltMax,pAltMin=@AltMin,pMoMax=@MoMax,pMoMin=@MoMin,pNMax=@NMax,pNMin=@NMin,pCeq1Max=@Ceq1Max,pCeq1Min=@Ceq1Min,pCeq2Max=@Ceq2Max,pCeq2Min=@Ceq2Min where id=" + Convert.ToInt32(lbChemailID.Text);

            SqlParameter[] ps =
            {
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

            int tag = SqlHelper.ExecuteNonQuery(sql, ps);
            if (tag > 0)
            {
                MessageBox.Show("化学成分修改成功！");
                FreashList();
                this.Close();
            }
            else
            {
                MessageBox.Show("化学成分修改失败，请检查有无空白！");
            }
        }
    }
}
