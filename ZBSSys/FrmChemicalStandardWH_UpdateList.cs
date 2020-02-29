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
    public partial class FrmChemicalStandardWH_UpdateList : Form
    {
        public FrmChemicalStandardWH_UpdateList()
        {
            InitializeComponent();
        }

        private void LoadChemicalStandardList()
        {
            string sql = "select psi.pStandardNumber '标准名称',pcs.* from product_chemicalStandardNew pcs join product_standardinfo psi on psi.pId = pcs.pStandardid";
            DataTable dt = SqlHelper.ExecuteTable(sql);
            dgvChemicalStandardList.DataSource = dt;
            dgvChemicalStandardList.AutoGenerateColumns = false;
            dgvChemicalStandardList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void FrmChemicalStandardWH_UpdateList_Load(object sender, EventArgs e)
        {
            LoadChemicalStandardList();
        }
        public event ChuanObejce2 StandardAndChemical;
        //public event ChuanObejce1 SAC;
        private void 修改选中的化学成分标准信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //封装  化学成分标准对象
            ProductChemicalStandard pcs = new ProductChemicalStandard();
            int pChemicalId = Convert.ToInt32(dgvChemicalStandardList.SelectedRows[0].Cells[1].Value);
            int pStandardid = Convert.ToInt32(dgvChemicalStandardList.SelectedRows[0].Cells[2].Value);
            string pGrade = dgvChemicalStandardList.SelectedRows[0].Cells[3].Value.ToString();
            double pCMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[4].Value);
            double pCMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[5].Value);
            double pSiMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[6].Value);
            double pSiMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[7].Value);
            double pMnMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[8].Value);
            double pMnMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[9].Value);
            double pPMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[10].Value);
            double pPMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[11].Value);
            double pSMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[12].Value);
            double pSMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[13].Value);
            double pNbMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[14].Value);
            double pNbMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[15].Value);
            double pVMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[16].Value);
            double pVMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[17].Value);
            double pTiMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[18].Value);
            double pTiMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[19].Value);
            double pCrMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[20].Value);
            double pCrMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[21].Value);
            double pNiMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[22].Value);
            double pNiMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[23].Value);
            double pCuMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[24].Value);
            double pCuMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[25].Value);
            double pAltMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[26].Value);
            double pAltMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[27].Value);
            double pMoMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[28].Value);
            double pMoMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[29].Value);
            double pNMax = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[30].Value);
            double pNMin = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[31].Value);
            double pCeq1Max = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[32].Value);
            double pCeq1Min = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[33].Value);
            double pCeq2Max = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[34].Value);
            double pCeq2Min = Convert.ToDouble(dgvChemicalStandardList.SelectedRows[0].Cells[35].Value);

            pcs.pChemicalId = pChemicalId;
            pcs.pStandardid = pStandardid;
            pcs.pGrade = pGrade;
            pcs.pCMax = pCMax;
            pcs.pCMin = pCMin;
            pcs.pSiMax = pSiMax;
            pcs.pSiMin = pSiMin;
            pcs.pMnMax = pMnMax;
            pcs.pMnMin = pMnMin;
            pcs.pPMax = pPMax;
            pcs.pPMin = pPMin;
            pcs.pSMax = pSMax;
            pcs.pSMin = pSMin;
            pcs.pNbMax = pNbMax;
            pcs.pNbMin = pNbMin;
            pcs.pVMax = pVMax;
            pcs.pVMin = pVMin;
            pcs.pTiMax = pTiMax;
            pcs.pTiMin = pTiMin;
            pcs.pCrMax = pCrMax;
            pcs.pCrMin = pCrMin;
            pcs.pNiMax = pNiMax;
            pcs.pNiMin = pNiMin;
            pcs.pCuMax = pCuMax;
            pcs.pCuMin = pCuMin;
            pcs.pAltMax = pAltMax;
            pcs.pAltMin = pAltMin;
            pcs.pMoMax = pMoMax;
            pcs.pMoMin = pMoMin;
            pcs.pNMax = pNMax;
            pcs.pNMin = pNMin;
            pcs.pCeq1Max = pCeq1Max;
            pcs.pCeq1Min = pCeq1Min;
            pcs.pCeq2Max = pCeq2Max;
            pcs.pCeq2Min = pCeq2Min;


            //封装  执行标准对象
            ProductStandardInfo psi = new ProductStandardInfo();
            int id = Convert.ToInt32(SqlHelper.ExecutScalar(" select id from product_standardinfo where pId=" + pStandardid));
            string pStandardNumber = dgvChemicalStandardList.SelectedRows[0].Cells[0].Value.ToString();
            string pStandardName = SqlHelper.ExecutScalar("select pStandardName from product_standardinfo where pId=" + pStandardid).ToString();
            int pId = pStandardid;

            psi.id = id;
            psi.pStandardNumber = pStandardNumber;
            psi.pStandardName = pStandardName;
            psi.pId = pId;

            FrmChemicalStandardXiuGai fcsxiugai = new FrmChemicalStandardXiuGai();
            StandardAndChemical += fcsxiugai.LoadBaseInfo;
            StandardAndChemical(psi, pcs);
            //刷新列表清单
            fcsxiugai.FreashList += LoadChemicalStandardList;
            DialogResult dr = fcsxiugai.ShowDialog();
        }

        private void 删除选中的化学成分标准信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pChemicalId = Convert.ToInt32(dgvChemicalStandardList.SelectedRows[0].Cells[1].Value);

            string sql = "delete from product_chemicalStandardNew where id=" + pChemicalId;
            if (MessageBox.Show("是否要删除该标准？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlHelper.ExecuteNonQuery(sql);
                LoadChemicalStandardList();
            }
        }
    }
}
