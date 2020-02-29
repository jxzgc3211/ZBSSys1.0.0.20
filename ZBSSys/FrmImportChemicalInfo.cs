using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;


namespace ZBSSys
{
    public partial class FrmImportChemicalInfo : Form
    {
        public FrmImportChemicalInfo()
        {
            InitializeComponent();
        }

        //选择要导入的excel文件
        private void bntOpenFile_Click(object sender, EventArgs e)
        {
            //Excel文件|*.xls
            openFileDialog1.Filter = "Excel文件|*.xlsx";
            openFileDialog1.Title = "打开Excel文件";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePathName.Text = openFileDialog1.FileName;
                btnImportData.Enabled = true;
            }
            else
            {
                return;
            }
        }
        private Boolean IsRollNumberExist(string rollNumber)
        {
            Boolean flag;
            string sql = "select count(pRollNumber) from product_chemical where pRollNumber='" + rollNumber + "'";
            int tag = Convert.ToInt32(SqlHelper.ExecutScalar(sql));
            if (tag == 0)
            {
                flag = false;//表示不存在重复的rollNumber（轧制批号）
            }
            else
            {
                flag = true;//表示存在重复的rollNumber（轧制批号）
            }
            return flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ExcelTable = new DataTable();
            var ExcelConnectionString = SqlHelper.connStr;
            var Adp = new SqlDataAdapter("select * from product_chemical", ExcelConnectionString);
            var DataCopier = new SqlBulkCopy(ExcelConnectionString) { DestinationTableName = "product_chemical" };
            Adp.FillSchema(ExcelTable, SchemaType.Source);
            var wk = new XSSFWorkbook(File.OpenRead(txtFilePathName.Text));
            var st = wk.GetSheetAt(0);
            for (var RowIndex = 1; RowIndex <= st.LastRowNum; RowIndex++)
            {
                var TableNewRow = ExcelTable.NewRow();
                var TempRow = st.GetRow(RowIndex);
                try
                {
                    //判断数据的有效性
                    if (TempRow.Cells[1].CellType == NPOI.SS.UserModel.CellType.Numeric)
                    {
                        TableNewRow[1] = TempRow.Cells[1].NumericCellValue.ToString();
                    }
                    else if (TempRow.Cells[1].CellType == NPOI.SS.UserModel.CellType.String)
                    {
                        TableNewRow[1] = TempRow.Cells[1].StringCellValue;
                    }
                    else if (TempRow.Cells[1].CellType == NPOI.SS.UserModel.CellType.Blank || TempRow.Cells[1].CellType == NPOI.SS.UserModel.CellType.Unknown)
                    {
                        continue;
                    }

                    if (TempRow.Cells[2].CellType == NPOI.SS.UserModel.CellType.Numeric)
                    {
                        TableNewRow[2] = TempRow.Cells[2].NumericCellValue.ToString();
                        if (IsRollNumberExist(TableNewRow[2].ToString()))
                        {
                            continue;
                        }
                    }
                    else if (TempRow.Cells[2].CellType == NPOI.SS.UserModel.CellType.Blank || TempRow.Cells[2].CellType == NPOI.SS.UserModel.CellType.Unknown)
                    {
                        continue;
                    }
                    else if (TempRow.Cells[2].CellType == NPOI.SS.UserModel.CellType.String)
                    {
                        TableNewRow[2] = TempRow.Cells[2].StringCellValue;
                        if (IsRollNumberExist(TableNewRow[2].ToString()))
                        {
                            continue;
                        }
                    }
                    TableNewRow[3] = TempRow.Cells[3].StringCellValue;                    
                    TableNewRow[4] = TempRow.Cells[4].NumericCellValue;
                    TableNewRow[5] = TempRow.Cells[5].NumericCellValue;
                    TableNewRow[6] = TempRow.Cells[6].NumericCellValue;
                    TableNewRow[7] = TempRow.Cells[7].NumericCellValue;
                    TableNewRow[8] = TempRow.Cells[8].NumericCellValue;
                    TableNewRow[9] = TempRow.Cells[9].NumericCellValue;
                    TableNewRow[10] = TempRow.Cells[10].NumericCellValue;
                    TableNewRow[11] = TempRow.Cells[11].NumericCellValue;
                    TableNewRow[12] = TempRow.Cells[12].NumericCellValue;
                    TableNewRow[13] = TempRow.Cells[13].NumericCellValue;
                    TableNewRow[14] = TempRow.Cells[14].NumericCellValue;
                    TableNewRow[15] = TempRow.Cells[15].NumericCellValue;
                    TableNewRow[16] = TempRow.Cells[16].NumericCellValue;
                    TableNewRow[17] = TempRow.Cells[17].NumericCellValue;
                    TableNewRow[18] = TempRow.Cells[18].NumericCellValue;
                    ExcelTable.Rows.Add(TableNewRow);
                }
                catch (Exception ex)
                {
                    lbExInfo.Text = ex.Message + "  请检查数据的有效性！";
                }
            }
            DataCopier.WriteToServer(ExcelTable);
            MessageBox.Show("数据传输结束！");
            lbYuanshiCount.Text = st.LastRowNum.ToString();
            lbSucessCount.Text = ExcelTable.Rows.Count.ToString();
            lbFailCount.Text = (st.LastRowNum - ExcelTable.Rows.Count).ToString();
            if (!string.IsNullOrEmpty(lbFailCount.Text) && string.IsNullOrEmpty(lbExInfo.Text))
            {
                label5.Text = "重复数据：";
            }
        }
        private void FrmImportChemicalInfo_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePathName.Text))
            {
                btnImportData.Enabled = false;
            }
            txtFilePathName.Enabled = false;
        }
    }
}
