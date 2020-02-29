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
using System.Collections;
using System.Data.OleDb;
using NPOI.HSSF.UserModel;
using System.IO;
/// <summary>
/// 2019-12-27,准备开始弄excel文件导入
/// 2019-1-3,读取excel文件导入到数据库已经实现，
/// </summary>

namespace ZBSSys
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private DataTable LoadListByCarName(string carName)
        {
            // 第二版查询 查询处理后的发货明细表product_deliveryinfo_zbs
            string sql = "select * from zbs_deliveryinfo where carnumber = @carName and(deliverydate between @beginDate and @endDate)";
            SqlParameter[] ps1 = {
                new SqlParameter("@beginDate", dtpStart.Value),
                new SqlParameter("@endDate", dtpEnd.Value),
                new SqlParameter("@carName", carName)
            };
            return SqlHelper.ExecuteTable(sql, ps1);
        }

        private DataTable ListMingxi(string carNumber)
        {
            string sql = "select * from product_deliveryinfo where carnumber = @carName and(deliverydate between @beginDate and @endDate)";
            SqlParameter[] ps1 = {
                new SqlParameter("@beginDate", dtpStart.Value),
                new SqlParameter("@endDate", dtpEnd.Value),
                new SqlParameter("@carName", carNumber)
            };
            return SqlHelper.ExecuteTable(sql, ps1);
        }

        private void SelectDetailByDeliveryDate(object sender, EventArgs e)
        {
            string sql = "select distinct carNumber from product_deliveryinfo where deliveryDate BETWEEN @beginDate and @endDate and ptype='" + rdbDBJG.Text + "'";

            SqlParameter[] ps = {
                new SqlParameter("@beginDate", dtpStart.Value),
                new SqlParameter("@endDate", dtpEnd.Value)
            };
            listCarNumber.DataSource = SqlHelper.ExecuteTable(sql, ps);
            listCarNumber.DisplayMember = "carNumber";
            listCarNumber.ValueMember = "carNumber";
            label5.Text = listCarNumber.Items.Count.ToString();
        }

        private void listCarNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string carNumber = listCarNumber.SelectedValue.ToString();
            DataTable dtTotalInfo = LoadListByCarName(carNumber);
            dgvShowInfo.DataSource = dtTotalInfo;
            dgvShowInfo.AutoGenerateColumns = false;
            dgvShowInfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //填充数据网格
            // LoadListByCarName(carNumber);

            //DataTable dtMingXI=ListMingxi(carNumber);
            //补充当前发货车辆的装载信息
            int jianshu = 0;
            int zhishu = 0;
            double zhongliang = 0;
            for (int i = 0; i < dtTotalInfo.Rows.Count; i++)
            {
                jianshu += Convert.ToInt32(dtTotalInfo.Rows[i][12]);
                zhishu += Convert.ToInt32(dtTotalInfo.Rows[i][13]);
                zhongliang += Convert.ToDouble(dtTotalInfo.Rows[i][14]);
            }
            lbJianshu.Text = jianshu.ToString();
            lbZhishi.Text = zhishu.ToString();
            lbZhongliang.Text = zhongliang.ToString();

            DataTable dt = ListMingxi(carNumber);

            //  使用键值对的方式，保存每一行的mdId和拼接的质保书规则
            Hashtable rowGZ = new Hashtable();
            foreach (DataRow item in dt.Rows)
            {
                int mdId = Convert.ToInt32(item[1]);
                //合同号、执行标准、钢级、厚度类型
                string rowGZtext = item[2] + "," + item[7] + "," + item[10] + "," + item[15];
                rowGZ.Add(mdId, rowGZtext);
            }
            //质保书规则
            //保存质保书的清单及质保书编号信息,去掉重复的行规则
            HashSet<string> zbsGZ = new HashSet<string>();
            foreach (var value in rowGZ.Values)
            {
                zbsGZ.Add(value.ToString());
            }
            //定义行规则
            string hangGZ;
            //获得当月质保书中序列号最大的值是什么
            string sql = "select ISNULL(max(bhSerial),0) from product_deliveryinfo where bhYear =@year and bhMonth =@month";
            //制作当前质保书的其他的 年  月
            DateTime dtime = DateTime.Now;
            int year = dtime.Year;
            int month = dtime.Month;
            SqlParameter[] ps =
            {
                new SqlParameter("@year",year),
                new SqlParameter("@month",month)
            };
            int maxSerial = Convert.ToInt32(SqlHelper.ExecutScalar(sql, ps));
            //根据质保书的份数，来生成质保书的编号,生成动态质保书的序列号
            List<int> serialNumber = new List<int>();
            if (maxSerial == 0)
            {
                for (int i = 0; i < zbsGZ.Count; i++)
                {
                    serialNumber.Add(i + 1);
                }
            }
            else
            {
                int tag = maxSerial + 1;
                for (int i = 0; i < zbsGZ.Count; i++)
                {
                    serialNumber.Add(tag + i);
                }
            }
            //遍历插入质保书的年 、月 、 序号
            foreach (int key in rowGZ.Keys)
            {
                hangGZ = rowGZ[key].ToString();
                for (int i = 0; i < zbsGZ.Count; i++)
                {
                    //使用行规则去比对合并后的质保书规则
                    if (hangGZ.Equals(zbsGZ.ElementAt(i)))
                    {
                        string sql1 = "update product_deliveryinfo set bhYear = @year,bhMonth =@month,bhSerial=" + serialNumber[i] + " where mdIDCopy =" + key;
                        SqlParameter[] ps1 =
                        {
                            new SqlParameter("@year",year),
                            new SqlParameter("@month",month)
                        };
                        //根据mdId查询这件钢bhSerial的值是否为0，如果为0就插入序号，不为0表示已经存在序号，则不执行插入
                        int temp = Convert.ToInt32(SqlHelper.ExecutScalar("SELECT ISNULL(bhSerial, 0) from product_deliveryinfo where mdIDCopy = " + key));
                        if (temp == 0)
                        {
                            SqlHelper.ExecuteNonQuery(sql1, ps1);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            //按照序号，将数据合并到zbs_deliveryinfo表中，-----质保书的发货数据准备完毕
            for (int i = 0; i < serialNumber.Count; i++)
            {
                string insert_sql_zbs_deliveryinfo = "insert into zbs_deliveryinfo select contractnumber, customername, deliverydate, carNumber, ptype, pstandard, prollnumber, pname, pgrade, ttype, plength, count(peachbundle) jianshu, sum(pnumber) zhishu, sum(pweight) zhongliang,bhYear,bhMonth,bhSerial from product_deliveryinfo where bhYear = " + year + " and bhMonth = " + month + " and bhserial = " + serialNumber[i] + "  group by contractnumber, customername,deliverydate,carNumber,ptype, pstandard, pname,ttype, pgrade, prollnumber, plength,bhYear,bhMonth,bhserial";
                SqlHelper.ExecuteNonQuery(insert_sql_zbs_deliveryinfo);
            }
            listCarNumber.Enabled = true;
        }
        private void LoadZHSBHByCarNumber(string carNumber)
        {
            string sql_select_serial = "select distinct bhYear,bhMonth,bhSerial from zbs_deliveryinfo where carNumber = '" + carNumber + "' and deliverydate >= '" + dtpStart.Value + "' and deliverydate<= '" + dtpEnd.Value + "'";
            DataTable dt_year_month_serial = SqlHelper.ExecuteTable(sql_select_serial);
            List<string> zbsBH = new List<string>();
            for (int i = 0; i < dt_year_month_serial.Rows.Count; i++)
            {
                int bhYear = Convert.ToInt32(dt_year_month_serial.Rows[i][0].ToString());
                int bhMonth = Convert.ToInt32(dt_year_month_serial.Rows[i][1].ToString());
                int bhSerial = Convert.ToInt32(dt_year_month_serial.Rows[i][2]);
                zbsBH.Add(bhYear + bhMonth.ToString("00") + bhSerial.ToString("0000"));
            }
            listZBSBH.DataSource = zbsBH;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //日期开始时间 yyyy-MM-dd 00:00:00
            DateTime dStart = dtpStart.Value.Date.AddDays(-1);
            dtpStart.Value = dStart;

            //日期结束时间 yyyy-MM-dd 23:59:59
            DateTime dEnd = new DateTime(dtpEnd.Value.Year, dtpEnd.Value.Month, dtpEnd.Value.Day, 23, 59, 59);

            this.dtpEnd.Value = dEnd;
        }

        //Action Action;
        private void 产品标准维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductStandard fps = new FrmProductStandard();
            fps.SetLableID();
            DialogResult dr = fps.ShowDialog();
            //Action += fps.SetLableID();
        }
        private void 产品钢级维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGradeWH gradeWH = new FrmGradeWH();
            DialogResult dr = gradeWH.ShowDialog();
        }

        private void 化学成分标准维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChemicalStandardWH frmChemicalStandardWH = new FrmChemicalStandardWH();
            DialogResult dr = frmChemicalStandardWH.ShowDialog();
        }


        private void 导入产品力学性能明细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportMechaincalInfo frmImportMechaincalInfo = new FrmImportMechaincalInfo();
            DialogResult dr = frmImportMechaincalInfo.ShowDialog();
        }

        private void 力学性能标准维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMechanicalStandardWH frmMechanicalStandardWH = new FrmMechanicalStandardWH();
            DialogResult dr = frmMechanicalStandardWH.ShowDialog();
        }

        private void 导入产品化学成分明细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportChemicalInfo frmImportChemicalInfo = new FrmImportChemicalInfo();
            DialogResult dr = frmImportChemicalInfo.ShowDialog();
        }

        private void 导入发货明细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportProductDeliveryInfo frmImportProductDeliveryInfo = new FrmImportProductDeliveryInfo();
            DialogResult dr = frmImportProductDeliveryInfo.ShowDialog();
        }

        public event ImportInfo information;
        private void btnSelectZBS_Click(object sender, EventArgs e)
        {
            if (listZBSBH.SelectedItem != null)
            {
                string zbsBH = listZBSBH.SelectedItem.ToString();
                FrmZBS frmZBS = new FrmZBS();
                //为a-事件添加方法
                information += frmZBS.ShowZBSBH;
                //调用a-事件
                information(zbsBH);//a-事件  发布显示内容的消息，调用studentInfo中的ShowStudentInfo方法
                frmZBS.Show();
            }
            else
            {
                MessageBox.Show("暂未选中质保书编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 导入产销存发货数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportCXCSaleDetail frmImportCXCSaleDetail = new FrmImportCXCSaleDetail();
            DialogResult dr = frmImportCXCSaleDetail.ShowDialog();
        }

        private void listCarNumber_MouseClick(object sender, MouseEventArgs e)
        {
            if (listCarNumber.Items.Count > 0)
            {
                string carNumber = listCarNumber.SelectedValue.ToString();
                LoadZHSBHByCarNumber(carNumber);
            }
        }
        private void 查询质保书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueryByZbsID frmQueryByZbsID = new FrmQueryByZbsID();
            DialogResult dr = frmQueryByZbsID.ShowDialog();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
