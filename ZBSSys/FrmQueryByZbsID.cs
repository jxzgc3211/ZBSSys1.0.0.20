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
using NPOI.HSSF.UserModel;

using System.IO;

namespace ZBSSys
{
    public partial class FrmQueryByZbsID : Form
    {
        public FrmQueryByZbsID()
        {
            InitializeComponent();

        }
        private void KongjianContentSetNull()
        {
            txtFHdate.Text = "";
            txtCarNumber.Text = "";
            lbTotalZhishu.Text = "";
            lbTotalWeight.Text = "";
        }

        private void btnQueryByZbsID_Click(object sender, EventArgs e)
        {
            //判断是否输入证书编号的信息
            if (!string.IsNullOrEmpty(txtZbsID.Text.Trim()))
            {
                string zbsId = txtZbsID.Text.Trim();
                if (zbsId.Length != 10)
                {
                    MessageBox.Show("您输入的证书编号格式不正确！");
                    //return;
                }
                else
                {
                    //拆分质保书ID号
                    int bhYear = Convert.ToInt32(zbsId.Substring(0, 4));
                    int bhMonth = Convert.ToInt32(zbsId.Substring(4, 2));
                    int bhSerial = Convert.ToInt32(zbsId.Substring(6, 4));
                    //判断这个编号在系统中是否存在
                    string sql_is_exist = "select count(*) from product_deliveryinfo where bhYear=@bhYear and bhMonth=@bhMonth and bhSerial=@bhSerial";
                    SqlParameter[] parm = new SqlParameter[]
                     {
                        new SqlParameter("bhYear",bhYear),
                        new SqlParameter("bhMonth",bhMonth),
                        new SqlParameter("bhSerial",bhSerial)
                     };
                    int tag = (int)SqlHelper.ExecutScalar(sql_is_exist, parm);
                    if (tag > 0)
                    {
                        //编号存在，有数据
                        string sql = "select * from product_deliveryinfo where bhYear=@bhYear and bhMonth=@bhMonth and bhSerial=@bhSerial";
                        SqlParameter[] parm1 = new SqlParameter[]
                        {
                            new SqlParameter("bhYear",bhYear),
                            new SqlParameter("bhMonth",bhMonth),
                            new SqlParameter("bhSerial",bhSerial)
                        };

                        DataTable dt = SqlHelper.ExecuteTable(sql, parm1);
                        txtFHdate.Text = Convert.ToDateTime(dt.Rows[0]["deliveryDate"]).ToShortDateString();
                        txtCarNumber.Text = dt.Rows[0]["carNumber"].ToString();
                        int totalZhishu = 0;
                        double totalWeight = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            totalZhishu += Convert.ToInt32(dr["pNumber"]);
                            totalWeight += Convert.ToDouble(dr["pWeight"]);
                        }
                        lbTotalZhishu.Text = totalZhishu.ToString();
                        lbTotalWeight.Text = totalWeight.ToString();

                        string sqlToExcel = "select mdIDCopy '捆包ID',contractNumber '合同号',customerName '客户',pstandard '执行标准',pEachBundle '小包号',pName '规格',pLength '长度',pNumber '支数',pWeight '重量' from product_deliveryinfo where bhYear=@bhYear and bhMonth=@bhMonth and bhSerial=@bhSerial";

                        SqlParameter[] parm2 = new SqlParameter[]
                        {
                            new SqlParameter("bhYear",bhYear),
                            new SqlParameter("bhMonth",bhMonth),
                            new SqlParameter("bhSerial",bhSerial)
                        };
                        SqlDataReader reader = SqlHelper.ExecuteReader(sqlToExcel, parm2);

                        //2、写入到excel文件中
                        //创建工作簿
                        HSSFWorkbook wkbook = new HSSFWorkbook();
                        //创建工作表对象
                        HSSFSheet sheet =(HSSFSheet)wkbook.CreateSheet(zbsId + "质保书中的产品明细");
                        //第一行的表头
                        HSSFRow head = (HSSFRow)sheet.CreateRow(0);
                        for (int col = 0; col < reader.FieldCount; col++)
                        {
                            head.CreateCell(col).SetCellValue(reader.GetName(col));
                        }
                        //创建第二行数据行
                        int rindex = 1;
                        while (reader.Read())
                        {
                            HSSFRow row = (HSSFRow)sheet.CreateRow(rindex);
                            rindex++;
                            int mdIDCopy = reader.GetInt32(0);
                            string contractNumber = reader.GetString(1);
                            string customerName = reader.GetString(2);
                            string pStandard = reader.GetString(3);
                            string pEachBundle = reader.GetString(4);
                            string pName = reader.GetString(5);
                            int pLength = reader.GetInt32(6);
                            int pNumber = reader.GetInt32(7);
                            double pWeight = reader.GetDouble(8);

                            row.CreateCell(0).SetCellValue(mdIDCopy);
                            row.CreateCell(1).SetCellValue(contractNumber);
                            row.CreateCell(2).SetCellValue(customerName);
                            row.CreateCell(3).SetCellValue(pStandard);
                            row.CreateCell(4).SetCellValue(pEachBundle);
                            row.CreateCell(5).SetCellValue(pName);
                            row.CreateCell(6).SetCellValue(pLength);
                            row.CreateCell(7).SetCellValue(pNumber);
                            row.CreateCell(8).SetCellValue(pWeight);

                        }

                        string filePath;
                        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                        {
                            filePath = folderBrowserDialog1.SelectedPath;
                            string fileName = zbsId + "质保书中的产品明细";
                            using (FileStream fsWrite = File.Create(filePath + fileName + ".xls"))
                            {
                                wkbook.Write(fsWrite);
                                MessageBox.Show("文件保存成功！");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("该证书编号不存在！");
                        KongjianContentSetNull();
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入10位证书编号！");
            }
        }
    }
}
