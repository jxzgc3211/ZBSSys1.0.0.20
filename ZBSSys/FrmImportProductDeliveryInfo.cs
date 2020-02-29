using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using NPOI.HSSF.UserModel;

namespace ZBSSys
{
    public partial class FrmImportProductDeliveryInfo : Form
    {
        public FrmImportProductDeliveryInfo()
        {
            InitializeComponent();
        }

        private void bntOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel文件|*.xls";
            openFileDialog1.Title = "打开Excel文件";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePathName.Text = openFileDialog1.FileName;
            }
            else
            {
                return;
            }
        }

        private void btnImportData_Click(object sender, EventArgs e)
        {
            using (FileStream fsRead = File.OpenRead(@txtFilePathName.Text))
            {
                HSSFWorkbook workbook = new HSSFWorkbook(fsRead);
                HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(0);
                string insert_sql = "insert into product_deliveryinfo values(@contractNumber,@customerName,@deliveryDate,@carNumber,@pType,@pStandard, @pRollNumber, @pName, @pGrade, @pLength,@pEachBundle,@pNumber,@pWeight)";
                for (int r = 1; r <= sheet.LastRowNum; r++)
                {
                    SqlParameter[] ps = new SqlParameter[]
                    {
                        new SqlParameter("@contractNumber",SqlDbType.NVarChar,50),
                        new SqlParameter("@customerName",SqlDbType.NVarChar,50),
                        new SqlParameter("@deliveryDate",SqlDbType.DateTime),
                        new SqlParameter("@carNumber",SqlDbType.NVarChar,50),
                        new SqlParameter("@pType",SqlDbType.NVarChar,50),
                        new SqlParameter("@pStandard",SqlDbType.NVarChar,50),
                        new SqlParameter("@pRollNumber",SqlDbType.NVarChar,50),
                        new SqlParameter("@pName",SqlDbType.NVarChar,50),
                        new SqlParameter("@pGrade",SqlDbType.NVarChar,50),
                        new SqlParameter("@pLength",SqlDbType.Int),
                        new SqlParameter("@pEachBundle",SqlDbType.NVarChar,50),
                        new SqlParameter("@pNumber",SqlDbType.Int),
                        new SqlParameter("@pWeight",SqlDbType.Float)
                    };
                    HSSFRow currentRow = (HSSFRow)sheet.GetRow(r);
                    if (currentRow != null)
                    {
                        for (int c = 1; c < currentRow.LastCellNum; c++)
                        {
                            HSSFCell cell =(HSSFCell) currentRow.GetCell(c);
                            if (cell == null || cell.CellType == NPOI.SS.UserModel.CellType.Blank)
                            {
                                //表示单元格为空，需要向数据库插入DBNull.value
                                ps[c - 1].Value = DBNull.Value;

                            }
                            else if (cell.CellType == NPOI.SS.UserModel.CellType.Numeric)
                            {
                                //c=3 日期转化
                                if (c == 3)
                                {
                                    ps[c - 1].Value = DateTime.FromOADate(cell.NumericCellValue);
                                }
                                else if (c == 7 || c == 11)
                                {
                                    ps[c - 1].Value = cell.ToString();

                                }
                                else
                                {
                                    ps[c - 1].Value = cell.NumericCellValue;

                                }
                            }
                            else if (cell.CellType == NPOI.SS.UserModel.CellType.String)
                            {
                                ps[c - 1].Value = cell.ToString();
                            }
                        }
                        SqlHelper.ExecuteNonQuery(insert_sql, CommandType.Text, ps);
                    }
                }
            }
            MessageBox.Show("数据导入成功！");
        }

        private void FrmImportProductDeliveryInfo_Load(object sender, EventArgs e)
        {
            txtFilePathName.Enabled = false;
        }
    }
}
