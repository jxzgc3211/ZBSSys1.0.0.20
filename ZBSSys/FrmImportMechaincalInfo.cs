using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.XSSF.UserModel;

namespace ZBSSys
{
    public partial class FrmImportMechaincalInfo : Form
    {
        public FrmImportMechaincalInfo()
        {
            InitializeComponent();
        }
        private void bntOpenFile_Click_1(object sender, EventArgs e)
        {
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
            string sql = "select count(pRollNumber) from product_mechanical where pRollNumber='" + rollNumber + "'";
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

        private void btnImportData_Click(object sender, EventArgs e)
        {
            var ExcelTable = new DataTable();
            var ExcelConnectionString = SqlHelper.connStr;
            var Adp = new SqlDataAdapter("select * from product_mechanical", ExcelConnectionString);
            var DataCopier = new SqlBulkCopy(ExcelConnectionString) { DestinationTableName = "product_mechanical" };
            Adp.FillSchema(ExcelTable, SchemaType.Source);
            var wk = new XSSFWorkbook(File.OpenRead(txtFilePathName.Text));
            var st = wk.GetSheetAt(0);
            for (var RowIndex = 1; RowIndex <= st.LastRowNum; RowIndex++)
            {
                var TableNewRow = ExcelTable.NewRow();
                var TempRow = st.GetRow(RowIndex);
                try
                {
                    TableNewRow[1] = TempRow.Cells[1].StringCellValue;
                    TableNewRow[2] = TempRow.Cells[2].StringCellValue;

                    //判断数据的有效性
                    if (TempRow.Cells[3].CellType == NPOI.SS.UserModel.CellType.Numeric)
                    {
                        TableNewRow[3] = TempRow.Cells[3].NumericCellValue.ToString();
                    }
                    else if (TempRow.Cells[1].CellType == NPOI.SS.UserModel.CellType.String)
                    {
                        TableNewRow[3] = TempRow.Cells[3].StringCellValue;
                    }
                    else if (TempRow.Cells[3].CellType == NPOI.SS.UserModel.CellType.Blank || TempRow.Cells[3].CellType == NPOI.SS.UserModel.CellType.Unknown)
                    {
                        continue;
                    }
                    //轧制批号
                    if (TempRow.Cells[4].CellType == NPOI.SS.UserModel.CellType.Numeric)
                    {
                        TableNewRow[4] = TempRow.Cells[4].NumericCellValue.ToString();
                        if (IsRollNumberExist(TableNewRow[4].ToString()))
                        {
                            continue;
                        }
                    }
                    else if (TempRow.Cells[4].CellType == NPOI.SS.UserModel.CellType.Blank || TempRow.Cells[4].CellType == NPOI.SS.UserModel.CellType.Unknown)
                    {
                        continue;
                    }
                    else if (TempRow.Cells[4].CellType == NPOI.SS.UserModel.CellType.String)
                    {
                        TableNewRow[4] = TempRow.Cells[4].StringCellValue;
                        if (IsRollNumberExist(TableNewRow[4].ToString()))
                        {
                            continue;
                        }
                    }                  
                    TableNewRow[5] = TempRow.Cells[5].NumericCellValue;
                    TableNewRow[6] = TempRow.Cells[6].NumericCellValue;
                    TableNewRow[7] = TempRow.Cells[7].NumericCellValue;
                    TableNewRow[8] = TempRow.Cells[8].StringCellValue;
                    TableNewRow[9] = TempRow.Cells[9].NumericCellValue;
                    TableNewRow[10] = TempRow.Cells[10].NumericCellValue;
                    TableNewRow[11] = TempRow.Cells[11].NumericCellValue;
                    TableNewRow[12] = TempRow.Cells[12].NumericCellValue;
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

        private void FrmImportMechaincalInfo_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePathName.Text))
            {
                btnImportData.Enabled = false;
            }
            
            txtFilePathName.Enabled = false;
            
        }

    }
}
