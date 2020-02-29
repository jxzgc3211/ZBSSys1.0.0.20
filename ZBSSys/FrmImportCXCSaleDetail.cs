using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBSSys
{
    public partial class FrmImportCXCSaleDetail : Form
    {
        public FrmImportCXCSaleDetail()
        {
            InitializeComponent();
        }

        private void FrmImportCXCSaleDetail_Load(object sender, EventArgs e)
        {
            //日期开始时间 yyyy-MM-dd 00:00:00
            DateTime dStart = dateTimePicker1.Value.Date.AddDays(-1);
            dateTimePicker1.Value = dStart;

            //日期结束时间 yyyy-MM-dd 23:59:59
            DateTime dEnd = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 23, 59, 59);
            dateTimePicker2.Value = dEnd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql="";
            string pName="";
            if (rdbAll.Checked)
            {
                sql = "insert into product_deliveryinfo(mdidcopy, contractnumber, customername, deliverydate, carnumber, ptype, pstandard, prollnumber, pname, pgrade, plength, peachbundle, pnumber, pweight) select mdid, ordno, cusname, sysdate, truno, varname, staname, rollingno, sizname, ostename, length,packnob,amount,weight from v_importsalelist where sysdate >= @beginDate and sysdate <= @endDate and ( mdid not in (select mdidcopy from product_deliveryinfo))";                
            }
            else
            {
                if (rdbDBJiaoGang.Checked)
                {
                    pName = rdbDBJiaoGang.Text;
                    
                }
                else if (rdbBDBJiaoGang.Checked)
                {
                    pName = rdbBDBJiaoGang.Text;
                }
                else if (rdbL.Checked)
                {
                    pName = rdbL.Text;
                }
                else if (rdbBP.Checked)
                {
                    pName = rdbBP.Text;
                }
                else if (rdbRFXG.Checked)
                {
                    pName = rdbRFXG.Text;
                }
                else if (rdbLW.Checked)
                {
                    pName = rdbLW.Text;
                }
                else if (rdbDCLD.Checked)
                {
                    pName = rdbDCLD.Text;
                }
                sql = "insert into product_deliveryinfo(mdidcopy, contractnumber, customername, deliverydate, carnumber, ptype, pstandard, prollnumber, pname, pgrade, plength, peachbundle, pnumber, pweight) select mdid, ordno, cusname, sysdate, truno, varname, staname, rollingno, sizname, ostename, length,packnob,amount,weight from v_importsalelist where sysdate >= @beginDate and sysdate <= @endDate and ( mdid not in (select mdidcopy from product_deliveryinfo)) and varName= '" + pName + "'";

                
            }
            SqlParameter[] ps = {
                        new SqlParameter("@beginDate", dateTimePicker1.Value),
                        new SqlParameter("@endDate", dateTimePicker2.Value)
                     };
            //SqlHelper.ExecuteTable(sql, ps);
            int count = SqlHelper.ExecuteNonQuery(sql, ps);
            if (count > 0)
            {
                lbCount.Text = count.ToString();
                MessageBox.Show("数据导入成功！");
            }
            else if (count == 0)
            {
                lbCount.Text = count.ToString();
                MessageBox.Show("该区间发货明细已经导入！");
            }
            else
            {
                MessageBox.Show("导入数据失败，请联系管理员处理！");
            }

            //为等边角钢增加厚度类型
            string UpdateTType = "UPDATE product_deliveryinfo set tType= (case when substring(pname,charindex('*',pname,6)+1,2)<=16 then '1' else '2' end) where pType='等边角钢'";
            SqlHelper.ExecuteNonQuery(UpdateTType);
        }
    }
}
