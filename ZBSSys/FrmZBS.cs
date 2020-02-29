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
    public partial class FrmZBS : Form
    {
        public FrmZBS()
        {
            InitializeComponent();
            this.printDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Document = this.printDocument1;
            this.pageSetupDialog1.Document = this.printDocument1;
            this.pageSetupDialog1.PageSettings.Landscape = true;
        }
        private void FrmZBS_Load(object sender, EventArgs e)
        {
            string zbsBH = txtZBSBH.Text;
            string year = zbsBH.Substring(0, 4);
            string month = zbsBH.Substring(4, 2);
            string serial = zbsBH.Substring(6, 4);

            int bhYear = Convert.ToInt32(year);
            int bhMonth = Convert.ToInt32(month);
            int bhSerial = Convert.ToInt32(serial);
            string sql = "select zd.constractNumber,zd.customerName,zd.deliverydate,zd.carNumber,zd.pType,zd.pGrade,zd.pStandard,zd.pName,zd.tType,pc.pHotNumber,zd.pRollNumber,zd.pLength,zd.pBundle,zd.pNumber,zd.pWeight,bhYear,bhMonth,bhSerial,pc.pC,pc.pMn,pc.pP,pc.pS,pc.pSi,pc.pNi,pc.pCr,pc.pCu,pc.pMo,pc.pAlt,pc.pV,pc.pCeq,pm.pYs,pm.pRm,pm.pA,pm.pD,pm.pKv1,pm.pkv2,pm.pkv3,pm.pKvAvg from zbs_deliveryinfo zd " +
                "left JOIN product_chemical pc on zd.prollnumber = pc.prollnumber " +
                "left JOIN product_mechanical pm on zd.prollnumber = pm.prollnumber " +
                "where zd.bhYear = @bhYear and zd.bhMonth =@bhMonth and zd.bhSerial = @bhSerial ";

            SqlParameter[] ps =
            {
                new SqlParameter("@bhYear",bhYear),
                new SqlParameter("@bhMonth",bhMonth),
                new SqlParameter("@bhSerial",bhSerial)
            };
            DataTable dt = SqlHelper.ExecuteTable(sql, ps);

            //dataGridView1.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //把发货数据保持到  ZBSProductDeliveryInfo   list中
                try
                {
                    zBSProductDeliveryInfos.Add(new ZBSProductDeliveryInfo
                    {
                        ConstractNumber = dt.Rows[i]["constractNumber"].ToString(),
                        CustomerName = dt.Rows[i]["customerName"].ToString(),
                        DeliveryDate = dt.Rows[i]["deliverydate"].ToString(),
                        CarNumber = dt.Rows[i]["carNumber"].ToString(),
                        PType = dt.Rows[i]["pType"].ToString(),
                        PStandard = dt.Rows[i]["pStandard"].ToString(),
                        PGrade = dt.Rows[i]["pGrade"].ToString(),
                        PName = dt.Rows[i]["pName"].ToString(),
                        TTYye = dt.Rows[i]["tType"].ToString(),
                        PHotNumber = dt.Rows[i]["pHotNumber"].ToString(),
                        PRollNumber = dt.Rows[i]["pRollNumber"].ToString(),
                        PLength = Convert.ToInt32(dt.Rows[i]["pLength"]),
                        PBundle = Convert.ToInt32(dt.Rows[i]["pBundle"]),
                        PNumber = Convert.ToInt32(dt.Rows[i]["pNumber"]),
                        PWeight = Convert.ToDouble(dt.Rows[i]["pWeight"]),
                        BHYear = Convert.ToInt32(dt.Rows[i]["bhYear"]),
                        BHMonth = Convert.ToInt32(dt.Rows[i]["bhMonth"]),
                        BHSerial = Convert.ToInt32(dt.Rows[i]["bhSerial"])
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("力学性能未导入！" + ex.Message);
                }

                //把化学成分数据保存至productChemicals   list中
                try
                {
                    productChemicals.Add(new ProductChemical
                    {
                        PHotNumber = dt.Rows[i]["pHotNumber"].ToString(),
                        PRollNumber = dt.Rows[i]["pRollNumber"].ToString(),
                        PGradeName = dt.Rows[i]["pGrade"].ToString(),
                        PC = Convert.ToDouble(dt.Rows[i]["pC"]),
                        PMn = Convert.ToDouble(dt.Rows[i]["pMn"]),
                        PP = Convert.ToDouble(dt.Rows[i]["pP"]),
                        PS = Convert.ToDouble(dt.Rows[i]["pS"]),
                        PSi = Convert.ToDouble(dt.Rows[i]["pSi"]),
                        PNi = Convert.ToDouble(dt.Rows[i]["pNi"]),
                        PCr = Convert.ToDouble(dt.Rows[i]["pCr"]),
                        PCu = Convert.ToDouble(dt.Rows[i]["pCu"]),
                        //(条件)  ？ (满足条件的值) ：(不满足条件的值)
                        PMo = dt.Rows[i]["pMo"] == DBNull.Value ? 0.0 : Convert.ToDouble(dt.Rows[i]["pMo"]),
                        //判断Alt的含量
                        PAlt = dt.Rows[i]["pAlt"] == DBNull.Value ? 0.0 : Convert.ToDouble(dt.Rows[i]["pAlt"]),
                        PV = dt.Rows[i]["pV"] == DBNull.Value ? 0.0 : Convert.ToDouble(dt.Rows[i]["pV"]),
                        PCeq = Convert.ToDouble(dt.Rows[i]["pCeq"])
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("集合数量：" + productChemicals.Count.ToString());
                    MessageBox.Show("化学成分信息未找到或该批次化学成分明细未导入！" + ex.Message);
                }

                try
                {
                    //把力学性能数据保存到productMechanicals list中
                    productMechanicals.Add(new ProductMechanical
                    {
                        PName = dt.Rows[i]["pName"].ToString(),
                        PRollNumber = dt.Rows[i]["pRollNumber"].ToString(),
                        PYs = Convert.ToInt32(dt.Rows[i]["pYs"]),
                        PRm = Convert.ToInt32(dt.Rows[i]["pRm"]),
                        PA = Convert.ToInt32(dt.Rows[i]["pA"]),
                        PD = dt.Rows[i]["pD"].ToString(),
                        PKv1 = Convert.ToInt32(dt.Rows[i]["pKv1"]),
                        PKv2 = Convert.ToInt32(dt.Rows[i]["pKv2"]),
                        PKv3 = Convert.ToInt32(dt.Rows[i]["pKv3"]),
                        PKvAvg = Convert.ToInt32(dt.Rows[i]["pKvAvg"])
                    });
                }
                catch (Exception ex)
                {

                    MessageBox.Show("力学性能信息未找到或该批次力学性能未导入！" + ex.Message);
                }
            }
            txtContractNumber.Text = zBSProductDeliveryInfos[0].ConstractNumber;
            txtCustomerName.Text = zBSProductDeliveryInfos[0].CustomerName;
            txtJSTJ.Text = zBSProductDeliveryInfos[0].PStandard;
            txtPType.Text = zBSProductDeliveryInfos[0].PType;
            txtStandard.Text = zBSProductDeliveryInfos[0].PStandard;
            txtGrade.Text = zBSProductDeliveryInfos[0].PGrade;
            txtDateTime.Text = DateTime.Parse(zBSProductDeliveryInfos[0].DeliveryDate).ToLongDateString();
            txtCarNumber.Text = zBSProductDeliveryInfos[0].CarNumber;

            //查询产品执行标准的id
            string sql2 = "select pid from product_standardinfo where pStandardNumber=@pStandardNumber";
            string standardId = SqlHelper.ExecutScalar(sql2, new SqlParameter("@pStandardNumber", txtStandard.Text)).ToString();
            //根据执行标准ID号和钢级，读取化学成分标准 保存到对象中
            string sqlchemicalStandard = "select * from product_chemicalStandardNew where pStandardid=@bzid and pGrade=@grade";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@bzid",standardId),
                new SqlParameter("@grade",txtGrade.Text)
            };
            DataTable dataTable = SqlHelper.ExecuteTable(sqlchemicalStandard, sqlParameters);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //2020-1-12
                //保存化学成分标准信息到对象中 productChemicalStandards
                productChemicalStandards.Add(new ProductChemicalStandard
                {
                    pCMax = Convert.ToDouble(dataTable.Rows[i]["pCMax"]),
                    pCMin = Convert.ToDouble(dataTable.Rows[i]["pCMin"]),
                    pSiMax = Convert.ToDouble(dataTable.Rows[i]["pSiMax"]),
                    pSiMin = Convert.ToDouble(dataTable.Rows[i]["pSiMin"]),
                    pMnMax = Convert.ToDouble(dataTable.Rows[i]["pMnMax"]),
                    pMnMin = Convert.ToDouble(dataTable.Rows[i]["pMnMin"]),
                    pPMax = Convert.ToDouble(dataTable.Rows[i]["pPMax"]),
                    pPMin = Convert.ToDouble(dataTable.Rows[i]["pPmin"]),
                    pSMax = Convert.ToDouble(dataTable.Rows[i]["pSMax"]),
                    pSMin = Convert.ToDouble(dataTable.Rows[i]["pSMin"]),
                    pNbMax = Convert.ToDouble(dataTable.Rows[i]["pNbMax"]),
                    pNbMin = Convert.ToDouble(dataTable.Rows[i]["pNbMin"]),
                    pVMax = Convert.ToDouble(dataTable.Rows[i]["pVMax"]),
                    pVMin = Convert.ToDouble(dataTable.Rows[i]["pVMin"]),
                    pTiMax = Convert.ToDouble(dataTable.Rows[i]["pTiMax"]),
                    pTiMin = Convert.ToDouble(dataTable.Rows[i]["pTiMin"]),
                    pCrMax = Convert.ToDouble(dataTable.Rows[i]["pCrMax"]),
                    pCrMin = Convert.ToDouble(dataTable.Rows[i]["pCrMin"]),
                    pNiMax = Convert.ToDouble(dataTable.Rows[i]["pNiMax"]),
                    pNiMin = Convert.ToDouble(dataTable.Rows[i]["pNiMin"]),
                    pCuMax = Convert.ToDouble(dataTable.Rows[i]["pCuMax"]),
                    pCuMin = Convert.ToDouble(dataTable.Rows[i]["pCuMin"]),
                    pAltMax = Convert.ToDouble(dataTable.Rows[i]["pAltMax"]),
                    pAltMin = Convert.ToDouble(dataTable.Rows[i]["pAltMin"]),
                    pMoMax = Convert.ToDouble(dataTable.Rows[i]["pMoMax"]),
                    pMoMin = Convert.ToDouble(dataTable.Rows[i]["pMoMin"]),
                    pNMax = Convert.ToDouble(dataTable.Rows[i]["pNMax"]),
                    pNMin = Convert.ToDouble(dataTable.Rows[i]["pNMin"]),
                    pCeq1Max = Convert.ToDouble(dataTable.Rows[i]["pCeq1Max"]),
                    pCeq1Min = Convert.ToDouble(dataTable.Rows[i]["pCeq1Min"]),
                    pCeq2Max = Convert.ToDouble(dataTable.Rows[i]["pCeq2Max"]),
                    pCeq2Min = Convert.ToDouble(dataTable.Rows[i]["pCeq2Min"])
                });
            }
            //读取力学性能标准保存到对象中   执行标准名/钢级名称/厚度类型
            string standardname = zBSProductDeliveryInfos[0].PStandard;
            string gradeName = zBSProductDeliveryInfos[0].PGrade;
            string ttype = zBSProductDeliveryInfos[0].TTYye;
            string sqlMechanStandard = "select * from product_mechanicalStandard where pStandard=@standardname and pGrade=@gradeName and tType=@ttype";
            SqlParameter[] sqlParameters1 = {
            new SqlParameter("@standardname",standardname),
            new SqlParameter("@gradeName",gradeName),
            new SqlParameter("@ttype",ttype),
            };
            DataTable dataTable1 = SqlHelper.ExecuteTable(sqlMechanStandard, sqlParameters1);
            for (int i = 0; i < dataTable1.Rows.Count; i++)
            {
                //id, pStandard, pGrade, tType, pYsName, pYsMin, pYsMax, pRmMin, pRmMax, pAMin, pAMax, pD, pKvAvgMin, pKvAvgMax, pT
                productMechanicalStandards.Add(
                    new ProductMechanicalStandard
                    {
                        PStandard = dataTable1.Rows[i]["pStandard"].ToString(),
                        PGrade = dataTable1.Rows[i]["pGrade"].ToString(),
                        TType = dataTable1.Rows[i]["tType"].ToString(),
                        PYsName = dataTable1.Rows[i]["pYsName"].ToString(),
                        PYsMin = Convert.ToInt32(dataTable1.Rows[i]["pYsMin"]),
                        PYsMax = Convert.ToInt32(dataTable1.Rows[i]["pYsMax"]),
                        PRmMin = Convert.ToInt32(dataTable1.Rows[i]["pRmMin"]),
                        PRmMax = Convert.ToInt32(dataTable1.Rows[i]["pRmMax"]),
                        PAMax = Convert.ToInt32(dataTable1.Rows[i]["pAMax"]),
                        PAMin = Convert.ToInt32(dataTable1.Rows[i]["pAMin"]),
                        PD = dataTable1.Rows[i]["pD"].ToString(),
                        PKvAvgMin = Convert.ToInt32(dataTable1.Rows[i]["pKvAvgMin"]),
                        PKvAvgMax = Convert.ToInt32(dataTable1.Rows[i]["pKvAvgMax"]),
                        PT = dataTable1.Rows[i]["pT"].ToString()
                    });
            }
            txtJLBH.Text = "JL390219/A";           
            txtJHZT.Text = "热轧";
            //绑定发货数据
            dgvProductInfo.AutoGenerateColumns = false;
            dgvProductInfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvProductInfo.DataSource = dt;
            //绑定化学成分数据
            dgvChemicalInfo.AutoGenerateColumns = false;
            dgvChemicalInfo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvChemicalInfo.DataSource = dt;
            //绑定力学性能数据
            dgvMechanical.AutoGenerateColumns = false;
            dgvMechanical.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvMechanical.DataSource = dt;
        }
        private void print_Click(object sender, EventArgs e)
        {
            if (this.printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void printView_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void printSet_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
        }
        //保存产品发货信息
        List<ZBSProductDeliveryInfo> zBSProductDeliveryInfos = new List<ZBSProductDeliveryInfo>();
        //保存产品化学成分信息
        List<ProductChemical> productChemicals = new List<ProductChemical>();
        //保存产品力学性能信息
        List<ProductMechanical> productMechanicals = new List<ProductMechanical>();
        //保存化学成分标准信息
        List<ProductChemicalStandard> productChemicalStandards = new List<ProductChemicalStandard>();
        //保存力学性能标准信息
        List<ProductMechanicalStandard> productMechanicalStandards = new List<ProductMechanicalStandard>();

        //发货信息分页打印的数据准备
        private int currentPageIndex = 0;//当前页，默认为第一页
        private int rowCount = 0;//总记录条数
        private int pageCount = 0;//总页数

        //化学成分信息分页打印的数据准备
        private int currentPageIndexChengfen = 0;//当前页，默认为第一页
        private int rowCountChengfen = 0;//总记录条数
        private int pageCountChengfen = 0;//总页数


        //力学性能信息分页打印的数据准备
        private int currentPageIndexXingNeng = 0;//当前页，默认为第一页
        private int rowCountXingNeng = 0;//总记录条数
        private int pageCountXingNeng = 0;//总页数
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Millimeter;//距离单位为mm
            //双击printDocument控件，这才是真正开始干活的，在这里面写你想要打印信息
            Font font = new Font("Tahoma", 8, FontStyle.Regular);//设置画笔
            Font font1 = new Font("Tahoma", 18, FontStyle.Regular);//设置公司名称画笔
            Font font2 = new Font("Tahoma", 16, FontStyle.Regular);//设置公司En名称画笔
            Brush bru = Brushes.Black;
            Pen pen = new Pen(bru);
            pen.Width = 0.5f;
            //设置各边距
            //int nLeft = this.pageSetupDialog1.PageSettings.Margins.Left;
            //int nTop = this.pageSetupDialog1.PageSettings.Margins.Top;
            //int nRight = this.pageSetupDialog1.PageSettings.Margins.Right;
            //int nBottom = this.pageSetupDialog1.PageSettings.Margins.Bottom;
            //int nWidth = this.pageSetupDialog1.PageSettings.PaperSize.Width - nRight - nLeft;
            //int nHeight = this.pageSetupDialog1.PageSettings.PaperSize.Height - nTop - nBottom;
            //打印各边距
            //e.Graphics.DrawLine(pen, nLeft, nTop, nLeft, nTop + nHeight);
            //e.Graphics.DrawLine(pen, nLeft + nWidth, nTop, nLeft + nWidth, nTop + nHeight);
            //e.Graphics.DrawLine(pen, nLeft, nTop, nLeft + nWidth, nTop);
            //e.Graphics.DrawLine(pen, nLeft, nTop + nHeight, nLeft + nWidth, nTop + nHeight);
            //logo位置
            int logoleft = 20; int logotop = 15;
            //公司名称位置
            int companyNameleft = 80; int companyNametop = 15;
            //公司英文名称位置
            int companyNameEnleft = 45; int companyNameEntop = 23;
            //禁止复印框的位置
            int warningKuangleft = 255; int warningKuangtop = 20;
            //禁止复印框的尺寸
            int kuangWidth = 30; int kuangHeight = 12;
            //禁止复印内容的位置
            int warningContentleft = 257; int warningContenttop = 22;
            //禁止复印英文内容的位置
            int warningContentEnleft = 259; int warningContentEntop = 26;
            //“质量证明书”的位置
            int zlzmsleft = 110; int zlzmstop = 30;
            //“质量证明书英文内容”的位置
            int zlzmsEnleft = 95; int zlzmsEntop = 38;
            //证书编号
            int lbzsbhleft = 240; int lbzsbhtop = 48;
            int txtzsbhleft = 254; int txtzsbhtop = 48;
            //记录编号
            int lbjlbhleft = 240; int lbjlbhtop = 53;
            int txtjlbhleft = 254; int txtjlbhtop = 53;
            //交货状态
            int lbjhztleft = 240; int lbjhzttop = 58;
            int lbjhztEnleft = 240; int lbjhztEntop = 62;
            int txtjhztleft = 254; int txtjhzttop = 58;
            //“订货单位”的位置
            int lbdhdwleft = 10; int lbdhdwtop = 52;
            int lbdhdwEnleft = 10; int lbdhdwEntop = 57;
            int txtdhdwleft = 28; int txtdhdwtop = 52;
            //“合同号”的位置
            int lbhthleft = 90; int lbhthtop = 52;
            int lbhthEnleft = 90; int lbhthEntop = 57;
            int txththleft = 105; int txththtop = 52;
            //“技术条件”的位置
            int lbjstjleft = 175; int lbjstjtop = 52;
            int lbjstjEnleft = 175; int lbjstjEntop = 57;
            int txtjstjleft = 195; int txtjstjtop = 52;
            //“品种名称”的位置
            int lbpzmcleft = 10; int lbpzmctop = 65;
            int lbpzmcEnleft = 10; int lbpzncEntop = 70;
            int txtpzmcleft = 28; int txtpzmctop = 65;
            //“产品标准”的位置
            int lbcpbzleft = 90; int lbcpbztop = 65;
            int lbcpbzEnleft = 90; int lbcpbzEntop = 70;
            int txtcpbzleft = 110; int txtcpbztop = 65;
            //“产品钢级”的位置
            int lbgradeleft = 175; int lbgradetop = 65;
            int lbgradeEnleft = 175; int lbgradeEntop = 70;
            int txtgradeleft = 185; int txtgradetop = 65;
            //“日期”的位置
            int lbdatetimeleft = 240; int lbdatetimetop = 66;
            int lbdatetimeEnleft = 240; int lbdatetimeEntop = 70;
            int txtdatetimeleft = 250; int txtdatetimetop = 66;

            string warningContent = "本质保书复印无效";
            string warningContentEn = "Invalid after copy";
            //********************************
            //打印质保书内容
            //********************************
            //1、通用信息
            //公司logo
            g.DrawImage(picJXLogo.Image, logoleft, logotop);
            //公司名称
            g.DrawString(lbCompanyName.Text, font1, bru, companyNameleft, companyNametop);
            //公司名称En
            g.DrawString(lblbCompanyNameEn.Text, font2, bru, companyNameEnleft, companyNameEntop);
            //质量证明书
            g.DrawString(lbZLZMS.Text, font1, bru, zlzmsleft, zlzmstop);
            //质量证明书En
            g.DrawString(lbZLZMSEn.Text, font1, bru, zlzmsEnleft, zlzmsEntop);
            //禁止复印的提示框
            g.DrawRectangle(pen, warningKuangleft, warningKuangtop, kuangWidth, kuangHeight);
            g.DrawString(warningContent, font, bru, warningContentleft, warningContenttop);
            g.DrawString(warningContentEn, font, bru, warningContentEnleft, warningContentEntop);
            //证书编号
            g.DrawString(lbZBSBH.Text, font, bru, lbzsbhleft, lbzsbhtop);
            g.DrawString(txtZBSBH.Text, font, bru, txtzsbhleft, txtzsbhtop);
            //记录编号
            g.DrawString(lbJLBH.Text, font, bru, lbjlbhleft, lbjlbhtop);
            g.DrawString(txtJLBH.Text, font, bru, txtjlbhleft, txtjlbhtop);
            //交货状态
            g.DrawString(lbJHZT.Text, font, bru, lbjhztleft, lbjhzttop);
            g.DrawString(lbJHZTEn.Text, font, bru, lbjhztEnleft, lbjhztEntop);
            g.DrawString(txtJHZT.Text, font, bru, txtjhztleft, txtjhzttop);
            //日期
            g.DrawString(lbDate.Text, font, bru, lbdatetimeleft, lbdatetimetop);
            g.DrawString(lbDateEn.Text, font, bru, lbdatetimeEnleft, lbdatetimeEntop);
            g.DrawString(txtDateTime.Text, font, bru, txtdatetimeleft, txtdatetimetop);
            //订货单位
            g.DrawString(lbCustomerName.Text, font, bru, lbdhdwleft, lbdhdwtop);
            g.DrawString(lbCustomerNameEn.Text, font, bru, lbdhdwEnleft, lbdhdwEntop);
            g.DrawString(txtCustomerName.Text, font, bru, txtdhdwleft, txtdhdwtop);
            //合同号
            g.DrawString(lbContractNumber.Text, font, bru, lbhthleft, lbhthtop);
            g.DrawString(lbContractNumberEn.Text, font, bru, lbhthEnleft, lbhthEntop);
            g.DrawString(txtContractNumber.Text, font, bru, txththleft, txththtop);
            //技术条件
            g.DrawString(lbJSTJ.Text, font, bru, lbjstjleft, lbjstjtop);
            g.DrawString(lbJSTJEn.Text, font, bru, lbjstjEnleft, lbjstjEntop);
            g.DrawString(txtJSTJ.Text, font, bru, txtjstjleft, txtjstjtop);
            //品种名称
            g.DrawString(lbPType.Text, font, bru, lbpzmcleft, lbpzmctop);
            g.DrawString(lbPTypeEn.Text, font, bru, lbpzmcEnleft, lbpzncEntop);
            g.DrawString(txtPType.Text, font, bru, txtpzmcleft, txtpzmctop);
            //执行标准
            g.DrawString(lbStandard.Text, font, bru, lbcpbzleft, lbcpbztop);
            g.DrawString(lbStandardEn.Text, font, bru, lbcpbzEnleft, lbcpbzEntop);
            g.DrawString(txtStandard.Text, font, bru, txtcpbzleft, txtcpbztop);
            //钢级
            g.DrawString(lbGrade.Text, font, bru, lbgradeleft, lbgradetop);
            g.DrawString(lbGradeEn.Text, font, bru, lbgradeEnleft, lbgradeEntop);
            g.DrawString(txtGrade.Text, font, bru, txtgradeleft, txtgradetop);

            //2、表格抬头信息
            int dataKuangLeft = 8; int dataKuangTop = 75;
            int dataKuangWeight = 277; int dataKuangHeight = 125;
            //数据框
            g.DrawRectangle(pen, dataKuangLeft, dataKuangTop, dataKuangWeight, dataKuangHeight);
            //横线坐标
            //1-6行为固定表头内容         

            Point rLine2x = new Point(114, 85); Point rLine2y = new Point(208, 85);
            Point rLine3x = new Point(242, 90); Point rLine3y = new Point(285, 90);
            Point rLine4x = new Point(114, 95); Point rLine4y = new Point(285, 95);
            Point rLine5x = new Point(114, 100); Point rLine5y = new Point(285, 100);
            Point rLine6x = new Point(8, 105); Point rLine6y = new Point(285, 105);

            Point rLine7x = new Point(8, 110); Point rLine7y = new Point(285, 110);
            Point rLine8x = new Point(8, 115); Point rLine8y = new Point(285, 115);
            Point rLine9x = new Point(8, 120); Point rLine9y = new Point(285, 120);
            Point rLine10x = new Point(8, 125); Point rLine10y = new Point(285, 125);
            Point rLine11x = new Point(8, 130); Point rLine11y = new Point(285, 130);
            Point rLine12x = new Point(8, 135); Point rLine12y = new Point(285, 135);
            Point rLine13x = new Point(8, 140); Point rLine13y = new Point(285, 140);
            Point rLine14x = new Point(8, 145); Point rLine14y = new Point(285, 145);
            Point rLine15x = new Point(8, 150); Point rLine15y = new Point(285, 150);
            Point rLine16x = new Point(8, 155); Point rLine16y = new Point(285, 155);
            Point rLine17x = new Point(8, 160); Point rLine17y = new Point(208, 160);

            //发货员下面的一条横线
            Point rLine18x = new Point(208, 170); Point rLine18y = new Point(285, 170);
            //公司地址下面的下划线
            Point rLine19x = new Point(210, 191); Point rLine19y = new Point(265, 191);
            Point rLine20x = new Point(210, 196); Point rLine20y = new Point(265, 196);

            //画出2-20的横线
            g.DrawLine(pen, rLine2x, rLine2y);
            g.DrawLine(pen, rLine3x, rLine3y);
            g.DrawLine(pen, rLine4x, rLine4y);
            g.DrawLine(pen, rLine5x, rLine5y);
            g.DrawLine(pen, rLine6x, rLine6y);
            g.DrawLine(pen, rLine7x, rLine7y);
            g.DrawLine(pen, rLine8x, rLine8y);
            g.DrawLine(pen, rLine9x, rLine9y);
            g.DrawLine(pen, rLine10x, rLine10y);
            g.DrawLine(pen, rLine11x, rLine11y);
            g.DrawLine(pen, rLine12x, rLine12y);
            g.DrawLine(pen, rLine13x, rLine13y);
            g.DrawLine(pen, rLine14x, rLine14y);
            g.DrawLine(pen, rLine15x, rLine15y);
            g.DrawLine(pen, rLine16x, rLine16y);
            g.DrawLine(pen, rLine17x, rLine17y);
            g.DrawLine(pen, rLine18x, rLine18y);
            g.DrawLine(pen, rLine19x, rLine19y);
            g.DrawLine(pen, rLine20x, rLine20y);
            //竖线坐标
            Point cLine1x = new Point(30, 75); Point cLine1y = new Point(30, 155);
            Point cLine2x = new Point(46, 75); Point cLine2y = new Point(46, 155);
            Point cLine3x = new Point(64, 75); Point cLine3y = new Point(64, 155);
            Point cLine4x = new Point(77, 75); Point cLine4y = new Point(77, 160);

            Point cLine5x = new Point(90, 75); Point cLine5y = new Point(90, 200);
            Point cLine6x = new Point(102, 75); Point cLine6y = new Point(102, 160);

            Point cLine7x = new Point(114, 75); Point cLine7y = new Point(114, 160);
            Point cLine8x = new Point(124, 85); Point cLine8y = new Point(124, 105);//半条线
            Point cLine9x = new Point(131, 85); Point cLine9y = new Point(131, 155);
            Point cLine10x = new Point(138, 85); Point cLine10y = new Point(138, 155);
            Point cLine11x = new Point(145, 85); Point cLine11y = new Point(145, 155);
            Point cLine12x = new Point(152, 85); Point cLine12y = new Point(152, 155);
            Point cLine13x = new Point(159, 85); Point cLine13y = new Point(159, 155);
            Point cLine14x = new Point(166, 85); Point cLine14y = new Point(166, 155);
            Point cLine15x = new Point(173, 85); Point cLine15y = new Point(173, 155);
            Point cLine16x = new Point(180, 85); Point cLine16y = new Point(180, 155);
            Point cLine17x = new Point(187, 85); Point cLine17y = new Point(187, 155);
            Point cLine18x = new Point(194, 85); Point cLine18y = new Point(194, 155);
            Point cLine19x = new Point(201, 85); Point cLine19y = new Point(201, 155);
            Point cLine20x = new Point(208, 75); Point cLine20y = new Point(208, 200);
            Point cLine21x = new Point(217, 75); Point cLine21y = new Point(217, 155);
            Point cLine22x = new Point(226, 75); Point cLine22y = new Point(226, 155);
            Point cLine23x = new Point(233, 75); Point cLine23y = new Point(233, 155);
            Point cLine24x = new Point(242, 75); Point cLine24y = new Point(242, 155);

            //冲击功1/2/3 
            Point cLine25xs = new Point(252, 90); Point cLine25ys = new Point(252, 95);
            Point cLine26xs = new Point(264, 90); Point cLine26ys = new Point(264, 95);
            Point cLine27xs = new Point(276, 90); Point cLine27ys = new Point(276, 95);
            //冲击功具体数据值的竖线
            Point cLine25xx = new Point(252, 105); Point cLine25yx = new Point(252, 155);
            Point cLine26xx = new Point(264, 105); Point cLine26yx = new Point(264, 155);
            Point cLine27xx = new Point(276, 105); Point cLine27yx = new Point(276, 155);

            //划出竖线27条
            g.DrawLine(pen, cLine1x, cLine1y);
            g.DrawLine(pen, cLine2x, cLine2y);
            g.DrawLine(pen, cLine3x, cLine3y);
            g.DrawLine(pen, cLine4x, cLine4y);
            g.DrawLine(pen, cLine5x, cLine5y);
            g.DrawLine(pen, cLine6x, cLine6y);
            g.DrawLine(pen, cLine7x, cLine7y);
            g.DrawLine(pen, cLine8x, cLine8y);
            g.DrawLine(pen, cLine9x, cLine9y);
            g.DrawLine(pen, cLine10x, cLine10y);
            g.DrawLine(pen, cLine11x, cLine11y);
            g.DrawLine(pen, cLine12x, cLine12y);
            g.DrawLine(pen, cLine13x, cLine13y);
            g.DrawLine(pen, cLine14x, cLine14y);
            g.DrawLine(pen, cLine15x, cLine15y);
            g.DrawLine(pen, cLine16x, cLine16y);
            g.DrawLine(pen, cLine17x, cLine17y);
            g.DrawLine(pen, cLine18x, cLine18y);
            g.DrawLine(pen, cLine19x, cLine19y);
            g.DrawLine(pen, cLine20x, cLine20y);
            g.DrawLine(pen, cLine21x, cLine21y);
            g.DrawLine(pen, cLine22x, cLine22y);
            g.DrawLine(pen, cLine23x, cLine23y);
            g.DrawLine(pen, cLine24x, cLine24y);

            //g.DrawLine(pen, cLine25x, cLine25y);
            //g.DrawLine(pen, cLine26x, cLine26y);
            //g.DrawLine(pen, cLine27x, cLine27y);
            g.DrawLine(pen, cLine25xs, cLine25ys);
            g.DrawLine(pen, cLine26xs, cLine26ys);
            g.DrawLine(pen, cLine27xs, cLine27ys);
            g.DrawLine(pen, cLine25xx, cLine25yx);
            g.DrawLine(pen, cLine26xx, cLine26yx);
            g.DrawLine(pen, cLine27xx, cLine27yx);
            //填充表头固定内容
            //发货信息表头CN
            int row3Y = 85;
            string guige = "规格"; int guigex = 15;
            string hotnumber = "冶炼炉号"; int hotnumberx = 31;
            string rollnumber = "轧制批号"; int rollnumberx = 48;
            string lenght = "长度"; int lenghtx = 66;
            string jianshu = "件数"; int jianshux = 79;
            string numbers = "支数"; int numbersx = 92;
            string weight = "重量"; int weightx = 104;
            g.DrawString(guige, font, bru, guigex, row3Y);
            g.DrawString(hotnumber, font, bru, hotnumberx, row3Y);
            g.DrawString(rollnumber, font, bru, rollnumberx, row3Y);
            g.DrawString(lenght, font, bru, lenghtx, row3Y);
            g.DrawString(jianshu, font, bru, jianshux, row3Y);
            g.DrawString(numbers, font, bru, numbersx, row3Y);
            g.DrawString(weight, font, bru, weightx, row3Y);
            //发货信息表头EN
            int row4Y = 92;
            string guigeEn = "Dimensions"; int guigeEnx = 11;
            string hotnumberEn = "Batch No"; int hotnumberEnx = 32;
            string rollnumberEn = "Roll No"; int rollnumberEnx = 49;
            string lenghtEn = "Length"; int lenghtEnx = 65;
            string jianshuEn = "Bundles"; int jianshuEnx = 78;
            string numbersEn = "Pieces"; int numbersEnx = 91;
            string weightEn = "WGT"; int weightEnx = 104;

            int row5Y = 98;
            string mm = "(mm)"; int mmx = 67;
            string mt = "(MT)"; int mtx = 104;
            g.DrawString(mm, font, bru, mmx, row5Y);
            g.DrawString(mt, font, bru, mtx, row5Y);

            g.DrawString(guigeEn, font, bru, guigeEnx, row4Y);
            g.DrawString(hotnumberEn, font, bru, hotnumberEnx, row4Y);
            g.DrawString(rollnumberEn, font, bru, rollnumberEnx, row4Y);
            g.DrawString(lenghtEn, font, bru, lenghtEnx, row4Y);
            g.DrawString(jianshuEn, font, bru, jianshuEnx, row4Y);
            g.DrawString(numbersEn, font, bru, numbersEnx, row4Y);
            g.DrawString(weightEn, font, bru, weightEnx, row4Y);

            //化学成分表头
            string hxcf = "化学成分(%)"; int hxcfx = 142; int hxcfy = 77;
            string hxcfEn = "Chemical compositions"; int hxcfEnx = 135; int hxcfEny = 80;
            g.DrawString(hxcf, font, bru, hxcfx, hxcfy);
            g.DrawString(hxcfEn, font, bru, hxcfEnx, hxcfEny);

            int yuansuY = 85;

            int yuansuValueY = 91;

            int yuansuValueDwY = 89;//指数位置
            //起始位置243
            string c = "C"; int cx = 127;
            string cvalue = "x10"; int cvaluex = 124;
            string cvaluedw = "2"; int cvaluedwx = 128;
            g.DrawString(c, font, bru, cx, yuansuY);
            g.DrawString(cvalue, font, bru, cvaluex, yuansuValueY);
            g.DrawString(cvaluedw, font, bru, cvaluedwx, yuansuValueDwY);

            string mn = "Mn"; int mnx = 132;
            string mnvalue = "x10"; int mnvaluex = 131;
            string mnvaluedw = "2"; int mnvaluedwx = 135;
            g.DrawString(mn, font, bru, mnx, yuansuY);
            g.DrawString(mnvalue, font, bru, mnvaluex, yuansuValueY);
            g.DrawString(mnvaluedw, font, bru, mnvaluedwx, yuansuValueDwY);

            string p = "P"; int px = 140;
            string pvalue = "x10"; int pvaluex = 138;
            string pvaluedw = "3"; int pvaluedwx = 142;
            g.DrawString(p, font, bru, px, yuansuY);
            g.DrawString(pvalue, font, bru, pvaluex, yuansuValueY);
            g.DrawString(pvaluedw, font, bru, pvaluedwx, yuansuValueDwY);

            string s = "S"; int sx = 147;
            string svalue = "x10"; int svaluex = 145;
            string svaluedw = "3"; int svaluedwx = 149;
            g.DrawString(s, font, bru, sx, yuansuY);
            g.DrawString(svalue, font, bru, svaluex, yuansuValueY);
            g.DrawString(svaluedw, font, bru, svaluedwx, yuansuValueDwY);

            string si = "Si"; int six = 153;
            string sivalue = "x10"; int sivaluex = 152;
            string sivaluedw = "2"; int sivaluedwx = 156;
            g.DrawString(si, font, bru, six, yuansuY);
            g.DrawString(sivalue, font, bru, sivaluex, yuansuValueY);
            g.DrawString(sivaluedw, font, bru, sivaluedwx, yuansuValueDwY);

            string ni = "Ni"; int nix = 160;
            string nivalue = "x10"; int nivaluex = 159;
            string nivaluedw = "3"; int nivaluedwx = 163;
            g.DrawString(ni, font, bru, nix, yuansuY);
            g.DrawString(nivalue, font, bru, nivaluex, yuansuValueY);
            g.DrawString(nivaluedw, font, bru, nivaluedwx, yuansuValueDwY);

            string cr = "Cr"; int crx = 167;
            string crvalue = "x10"; int crvaluex = 166;
            string crvaluedw = "3"; int crvaluedwx = 170;
            g.DrawString(cr, font, bru, crx, yuansuY);
            g.DrawString(crvalue, font, bru, crvaluex, yuansuValueY);
            g.DrawString(crvaluedw, font, bru, crvaluedwx, yuansuValueDwY);

            string cu = "Cu"; int cux = 174;
            string cuvalue = "x10"; int cuvaluex = 173;
            string cuvaluedw = "3"; int cuvaluedwx = 177;
            g.DrawString(cu, font, bru, cux, yuansuY);
            g.DrawString(cuvalue, font, bru, cuvaluex, yuansuValueY);
            g.DrawString(cuvaluedw, font, bru, cuvaluedwx, yuansuValueDwY);

            string mo = "Mo"; int mox = 181;
            string movalue = "x10"; int movaluex = 180;
            string movaluedw = "3"; int movaluedwx = 184;
            g.DrawString(mo, font, bru, mox, yuansuY);
            g.DrawString(movalue, font, bru, movaluex, yuansuValueY);
            g.DrawString(movaluedw, font, bru, movaluedwx, yuansuValueDwY);

            string alt = "Alt"; int altx = 188;
            string altvalue = "x10"; int altvaluex = 187;
            string altvalueddw = "3"; int altvaluedwx = 191;
            g.DrawString(alt, font, bru, altx, yuansuY);
            g.DrawString(altvalue, font, bru, altvaluex, yuansuValueY);
            g.DrawString(altvalueddw, font, bru, altvaluedwx, yuansuValueDwY);

            string v = "V"; int vx = 195;
            string vvalue = "x10"; int vvaluex = 194;
            string vvaluedw = "3"; int vvaluedwx = 198;
            g.DrawString(v, font, bru, vx, yuansuY);
            g.DrawString(vvalue, font, bru, vvaluex, yuansuValueY);
            g.DrawString(vvaluedw, font, bru, vvaluedwx, yuansuValueDwY);

            string ceq = "Ceq"; int ceqx = 202;
            string ceqvalue = "x10"; int ceqvaluex = 201;
            string ceqvaluedwd = "2"; int ceqvaluedwx = 205;
            g.DrawString(ceq, font, bru, ceqx, yuansuY);
            g.DrawString(ceqvalue, font, bru, ceqvaluex, yuansuValueY);
            g.DrawString(ceqvaluedwd, font, bru, ceqvaluedwx, yuansuValueDwY);


            string max = "Max"; int maxx = 116; int maxy = 96;
            string min = "Min"; int minx = 116; int miny = 101;
            g.DrawString(max, font, bru, maxx, maxy);
            g.DrawString(min, font, bru, minx, miny);

            //屈服强度的表头
            string qufu = "屈服"; int qufux = 209; int qufuy = 77;
            string qiangdu = "强度"; int qiangdux = 209; int qiangduy = 81;
            //动态的Rel   ReH
            string ysName = productMechanicalStandards[0].PYsName; int ysNamex = 209; int ysNamey = 86;

            //string reh = "ReH"; int rehx = 208; int rehy = 86;
            string qfdw = "(Mpa)"; int qfdwx = 208; int qfdwy = 91;
            g.DrawString(qufu, font, bru, qufux, qufuy);
            g.DrawString(qiangdu, font, bru, qiangdux, qiangduy);
            g.DrawString(ysName, font, bru, ysNamex, ysNamey);
            g.DrawString(qfdw, font, bru, qfdwx, qfdwy);
            //抗拉强度的表头
            string kangla = "抗拉"; int kanglax = 218; int kanglay = 77;
            string qiangdu1 = "强度"; int qiangdu1x = 218; int qiangdu1y = 81;
            string rm = "Rm"; int rmx = 218; int rmy = 86;
            string kangladanwei = "(Mpa)"; int kangladanweix = 217; int kangladanweiy = 91;
            g.DrawString(kangla, font, bru, kanglax, kanglay);
            g.DrawString(qiangdu1, font, bru, qiangdu1x, qiangdu1y);
            g.DrawString(rm, font, bru, rmx, rmy);
            g.DrawString(kangladanwei, font, bru, kangladanweix, kangladanweiy);
            //延伸率的表头
            string yan = "延"; int yanx = 227; int yany = 77;
            string shen = "伸"; int shenx = 227; int sheny = 81;
            string lv = "率"; int lvx = 227; int lvy = 86;
            string ysldanwei = "A(%)"; int ysldanweix = 226; int ysldanweiy = 91;
            g.DrawString(yan, font, bru, yanx, yany);
            g.DrawString(shen, font, bru, shenx, sheny);
            g.DrawString(lv, font, bru, lvx, lvy);
            g.DrawString(ysldanwei, font, bru, ysldanweix, ysldanweiy);
            //冷弯的表头
            string lengwan = "冷弯"; int lengwanx = 234; int lengwany = 77;
            string bt = "BT"; int btx = 235; int bty = 83;
            g.DrawString(lengwan, font, bru, lengwanx, lengwany);
            g.DrawString(bt, font, bru, btx, bty);
            //冲击功的表头
            string vxingCn = "V型冲击功(J,          )"; int vxingCnx = 250; int vxingCny = 77;
            string vxingEn = "Impact value V-Notch"; int vxingEnx = 248; int vxingEny = 82;
            g.DrawString(vxingCn, font, bru, vxingCnx, vxingCny);
            g.DrawString(vxingEn, font, bru, vxingEnx, vxingEny);

            string one = "1"; int onex = 246; int oney = 90;
            string two = "2"; int twox = 257; int twoy = 90;
            string three = "3"; int threex = 269; int threey = 90;
            string avg = "AVG"; int avgx = 278; int avgy = 90;
            g.DrawString(one, font, bru, onex, oney);
            g.DrawString(two, font, bru, twox, twoy);
            g.DrawString(three, font, bru, threex, threey);
            g.DrawString(avg, font, bru, avgx, avgy);
            //3、表格数据
            //发货数据
            int y = 106;
            int zongjianshu = 0;
            int zongzhishu = 0;
            double zongzhongliang = 0;

            //分页显示发货数据
            rowCount = zBSProductDeliveryInfos.Count;
            int pageMaxCount = 10;

            //页码信息的位置
            int yemaX = 270;
            int yemaY = 48;
            //给发货信息的pageCount赋值（需要几页质保书）
            if (rowCount % pageMaxCount == 0)
            {
                pageCount = rowCount / pageMaxCount;
            }
            else
            {
                pageCount = (rowCount / pageMaxCount) + 1;
            }
            //单页无法显示完的情况
            if (rowCount > pageMaxCount)
            {
                //两种情况：需要2页、需要3页
                if (rowCount > pageMaxCount && rowCount <= 20)
                {
                    //需要2页可以打印完
                    if (currentPageIndex == 0)   //当为第一页时
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            string dimensions = zBSProductDeliveryInfos[i].PName;
                            g.DrawString(dimensions, font, bru, 8, y);
                            string hotNumber = zBSProductDeliveryInfos[i].PHotNumber;
                            g.DrawString(hotNumber, font, bru, 30, y);
                            string rollNumber = zBSProductDeliveryInfos[i].PRollNumber;
                            g.DrawString(rollNumber, font, bru, 46, y);
                            int length = zBSProductDeliveryInfos[i].PLength;
                            g.DrawString(length.ToString(), font, bru, 66, y);
                            int bundles = zBSProductDeliveryInfos[i].PBundle;
                            zongjianshu += bundles;
                            g.DrawString(bundles.ToString(), font, bru, 81, y);
                            int number = zBSProductDeliveryInfos[i].PNumber;
                            zongzhishu += number;
                            g.DrawString(number.ToString(), font, bru, 94, y);
                            double weights = zBSProductDeliveryInfos[i].PWeight;
                            zongzhongliang += weights;
                            g.DrawString(weights.ToString(), font, bru, 104, y);
                            y += 5;
                        }
                        //显示页码（第1页 共2页）
                        //当前页码
                        string currentPageNumber = (currentPageIndex + 1).ToString();
                        //总页码 pageCount 
                        string pageInfo = "第" + currentPageNumber + "页/共" + pageCount + "页";
                        g.DrawString(pageInfo, font, bru, yemaX, yemaY);
                    }
                    else if (currentPageIndex == 1)   //当为第二页时
                    {
                        for (int i = 10; i < zBSProductDeliveryInfos.Count; i++)
                        {
                            string dimensions = zBSProductDeliveryInfos[i].PName;
                            g.DrawString(dimensions, font, bru, 8, y);
                            string hotNumber = zBSProductDeliveryInfos[i].PHotNumber;
                            g.DrawString(hotNumber, font, bru, 30, y);
                            string rollNumber = zBSProductDeliveryInfos[i].PRollNumber;
                            g.DrawString(rollNumber, font, bru, 46, y);
                            int length = zBSProductDeliveryInfos[i].PLength;
                            g.DrawString(length.ToString(), font, bru, 66, y);
                            int bundles = zBSProductDeliveryInfos[i].PBundle;
                            zongjianshu += bundles;
                            g.DrawString(bundles.ToString(), font, bru, 81, y);
                            int number = zBSProductDeliveryInfos[i].PNumber;
                            zongzhishu += number;
                            g.DrawString(number.ToString(), font, bru, 94, y);
                            double weights = zBSProductDeliveryInfos[i].PWeight;
                            zongzhongliang += weights;
                            g.DrawString(weights.ToString(), font, bru, 104, y);
                            y += 5;
                        }
                        //显示页码（第1页 共2页）
                        //当前页码
                        string currentPageNumber = (currentPageIndex + 1).ToString();
                        //总页码 pageCount 
                        string pageInfo = "第" + currentPageNumber + "页/共" + pageCount + "页";
                        g.DrawString(pageInfo, font, bru, yemaX, yemaY);
                    }
                }
                else if (rowCount > 20 && rowCount <= 30)
                {
                    //需要3页可以打印完
                    if (currentPageIndex == 0)   //当为第一页时
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            string dimensions = zBSProductDeliveryInfos[i].PName;
                            g.DrawString(dimensions, font, bru, 8, y);
                            string hotNumber = zBSProductDeliveryInfos[i].PHotNumber;
                            g.DrawString(hotNumber, font, bru, 30, y);
                            string rollNumber = zBSProductDeliveryInfos[i].PRollNumber;
                            g.DrawString(rollNumber, font, bru, 46, y);
                            int length = zBSProductDeliveryInfos[i].PLength;
                            g.DrawString(length.ToString(), font, bru, 66, y);
                            int bundles = zBSProductDeliveryInfos[i].PBundle;
                            zongjianshu += bundles;
                            g.DrawString(bundles.ToString(), font, bru, 81, y);
                            int number = zBSProductDeliveryInfos[i].PNumber;
                            zongzhishu += number;
                            g.DrawString(number.ToString(), font, bru, 94, y);
                            double weights = zBSProductDeliveryInfos[i].PWeight;
                            zongzhongliang += weights;
                            g.DrawString(weights.ToString(), font, bru, 104, y);
                            y += 5;
                        }
                        //显示页码（第1页 共2页）
                        //当前页码
                        string currentPageNumber = (currentPageIndex + 1).ToString();
                        //总页码 pageCount 
                        string pageInfo = "第" + currentPageNumber + "页/共" + pageCount + "页";
                        g.DrawString(pageInfo, font, bru, yemaX, yemaY);

                    }
                    else if (currentPageIndex == 1)   //当为第二页时
                    {
                        for (int i = 10; i < 20; i++)
                        {
                            string dimensions = zBSProductDeliveryInfos[i].PName;
                            g.DrawString(dimensions, font, bru, 8, y);
                            string hotNumber = zBSProductDeliveryInfos[i].PHotNumber;
                            g.DrawString(hotNumber, font, bru, 30, y);
                            string rollNumber = zBSProductDeliveryInfos[i].PRollNumber;
                            g.DrawString(rollNumber, font, bru, 46, y);
                            int length = zBSProductDeliveryInfos[i].PLength;
                            g.DrawString(length.ToString(), font, bru, 66, y);
                            int bundles = zBSProductDeliveryInfos[i].PBundle;
                            zongjianshu += bundles;
                            g.DrawString(bundles.ToString(), font, bru, 81, y);
                            int number = zBSProductDeliveryInfos[i].PNumber;
                            zongzhishu += number;
                            g.DrawString(number.ToString(), font, bru, 94, y);
                            double weights = zBSProductDeliveryInfos[i].PWeight;
                            zongzhongliang += weights;
                            g.DrawString(weights.ToString(), font, bru, 104, y);
                            y += 5;
                        }
                        //显示页码（第1页 共2页）
                        //当前页码
                        string currentPageNumber = (currentPageIndex + 1).ToString();
                        //总页码 pageCount 
                        string pageInfo = "第" + currentPageNumber + "页/共" + pageCount + "页";
                        g.DrawString(pageInfo, font, bru, yemaX, yemaY);

                    }
                    else if (currentPageIndex == 2)//当为第三页时
                    {
                        for (int i = 20; i < zBSProductDeliveryInfos.Count; i++)
                        {
                            string dimensions = zBSProductDeliveryInfos[i].PName;
                            g.DrawString(dimensions, font, bru, 8, y);
                            string hotNumber = zBSProductDeliveryInfos[i].PHotNumber;
                            g.DrawString(hotNumber, font, bru, 30, y);
                            string rollNumber = zBSProductDeliveryInfos[i].PRollNumber;
                            g.DrawString(rollNumber, font, bru, 46, y);
                            int length = zBSProductDeliveryInfos[i].PLength;
                            g.DrawString(length.ToString(), font, bru, 66, y);
                            int bundles = zBSProductDeliveryInfos[i].PBundle;
                            zongjianshu += bundles;
                            g.DrawString(bundles.ToString(), font, bru, 81, y);
                            int number = zBSProductDeliveryInfos[i].PNumber;
                            zongzhishu += number;
                            g.DrawString(number.ToString(), font, bru, 94, y);
                            double weights = zBSProductDeliveryInfos[i].PWeight;
                            zongzhongliang += weights;
                            g.DrawString(weights.ToString(), font, bru, 104, y);
                            y += 5;
                        }
                        //显示页码（第1页 共2页）
                        //当前页码
                        string currentPageNumber = (currentPageIndex + 1).ToString();
                        //总页码 pageCount 
                        string pageInfo = "第" + currentPageNumber + "页/共" + pageCount + "页";
                        g.DrawString(pageInfo, font, bru, yemaX, yemaY);

                    }
                }
                currentPageIndex++;      //加新页  
                if (currentPageIndex < pageCount)
                {
                    e.HasMorePages = true;  //如果小于定义页 那么增加新的页数
                }
                else
                {
                    e.HasMorePages = false; //停止增加新的页数
                    currentPageIndex = 0;
                }
            }
            else
            {
                //单页可以显示完
                for (int i = 0; i < zBSProductDeliveryInfos.Count; i++)
                {
                    string dimensions = zBSProductDeliveryInfos[i].PName;
                    g.DrawString(dimensions, font, bru, 8, y);
                    string hotNumber = zBSProductDeliveryInfos[i].PHotNumber;
                    g.DrawString(hotNumber, font, bru, 30, y);
                    string rollNumber = zBSProductDeliveryInfos[i].PRollNumber;
                    g.DrawString(rollNumber, font, bru, 46, y);
                    int length = zBSProductDeliveryInfos[i].PLength;
                    g.DrawString(length.ToString(), font, bru, 66, y);
                    int bundles = zBSProductDeliveryInfos[i].PBundle;
                    zongjianshu += bundles;
                    g.DrawString(bundles.ToString(), font, bru, 81, y);
                    int number = zBSProductDeliveryInfos[i].PNumber;
                    zongzhishu += number;
                    g.DrawString(number.ToString(), font, bru, 94, y);
                    double weights = zBSProductDeliveryInfos[i].PWeight;
                    zongzhongliang += weights;
                    g.DrawString(weights.ToString(), font, bru, 104, y);
                    y += 5;
                }
                //单页可以显示完就不加页码
                //string currentPageNumber = (currentPageIndex + 1).ToString();
                //总页码 pageCount 
                //string pageInfo = "第" + currentPageNumber + "页/共" + pageCount + "页";
                //g.DrawString(pageInfo, font, bru, yemaX, yemaY);
            }
            //合计信息
            int suminfoY = 156;
            string total = "合计(Total):"; int totalx = 30;
            g.DrawString(total, font, bru, totalx, suminfoY);
            g.DrawString(zongjianshu.ToString(), font, bru, 81, suminfoY);
            g.DrawString(zongzhishu.ToString(), font, bru, 93, suminfoY);
            g.DrawString(zongzhongliang.ToString(), font, bru, 104, suminfoY);

            //写入化学成分标准信息
            int chemicalStandardMaxY = 96;
            //化学成分标准的Max值
            for (int i = 0; i < productChemicalStandards.Count; i++)
            {
                string pCMax = (productChemicalStandards[i].pCMax * 100).ToString();
                string pSiMax = (productChemicalStandards[i].pSiMax * 100).ToString();
                string pMnMax = (productChemicalStandards[i].pMnMax * 100).ToString();
                string pPMax = (productChemicalStandards[i].pPMax * 1000).ToString();
                string pSMax = (productChemicalStandards[i].pSMax * 1000).ToString();
                string pVMax = (productChemicalStandards[i].pVMax * 1000).ToString();
                string pCrMax = (productChemicalStandards[i].pCrMax * 1000).ToString();
                string pNiMax = (productChemicalStandards[i].pNiMax * 1000).ToString();
                string pCuMax = (productChemicalStandards[i].pCuMax * 1000).ToString();
                string pAltMax = (productChemicalStandards[i].pAltMax * 1000).ToString();
                string pMoMax = (productChemicalStandards[i].pMoMax * 1000).ToString();
                string pCeq1Max = (productChemicalStandards[i].pCeq1Max * 100).ToString();

                if (!pCMax.Equals("0"))
                {
                    g.DrawString(pCMax, font, bru, 125, chemicalStandardMaxY);
                }

                if (!pMnMax.Equals("0"))
                {
                    g.DrawString(pMnMax, font, bru, 132, chemicalStandardMaxY);
                }
                if (!pPMax.Equals("0"))
                {
                    g.DrawString(pPMax, font, bru, 139, chemicalStandardMaxY);
                }
                if (!pSMax.Equals("0"))
                {
                    g.DrawString(pSMax, font, bru, 146, chemicalStandardMaxY);
                }
                if (!pSiMax.Equals("0"))
                {
                    g.DrawString(pSiMax, font, bru, 153, chemicalStandardMaxY);
                }
                if (!pNiMax.Equals("0"))
                {
                    g.DrawString(pNiMax, font, bru, 160, chemicalStandardMaxY);
                }
                if (!pCrMax.Equals("0"))
                {
                    g.DrawString(pCrMax, font, bru, 167, chemicalStandardMaxY);
                }
                if (!pCuMax.Equals("0"))
                {
                    g.DrawString(pCuMax, font, bru, 174, chemicalStandardMaxY);
                }
                if (!pMoMax.Equals("0"))
                {
                    g.DrawString(pMoMax, font, bru, 181, chemicalStandardMaxY);
                }
                if (!pAltMax.Equals("0"))
                {
                    g.DrawString(pAltMax, font, bru, 189, chemicalStandardMaxY);
                }
                if (!pVMax.Equals("0"))
                {
                    g.DrawString(pVMax, font, bru, 195, chemicalStandardMaxY);
                }
                if (!pCeq1Max.Equals("0"))
                {
                    g.DrawString(pCeq1Max, font, bru, 203, chemicalStandardMaxY);
                }
                chemicalStandardMaxY += 5;
            }
            int chemicalStandardMinY = 101;
            //化学成分标准的Min值
            for (int i = 0; i < productChemicalStandards.Count; i++)
            {
                string pCMin = (productChemicalStandards[i].pCMin * 100).ToString();
                string pSiMin = (productChemicalStandards[i].pSiMin * 100).ToString();
                string pMnMin = (productChemicalStandards[i].pMnMin * 1000).ToString();
                string pPMin = (productChemicalStandards[i].pPMin * 1000).ToString();
                string pSMin = (productChemicalStandards[i].pSMin * 1000).ToString();
                string pVMin = (productChemicalStandards[i].pVMin * 1000).ToString();
                string pCrMin = (productChemicalStandards[i].pCrMin * 1000).ToString();
                string pNiMin = (productChemicalStandards[i].pNiMin * 1000).ToString();
                string pCuMin = (productChemicalStandards[i].pCuMin * 1000).ToString();
                string pAltMin = (productChemicalStandards[i].pAltMin * 1000).ToString();
                string pMoMin = (productChemicalStandards[i].pMoMin * 1000).ToString();
                string pCeq1Min = (productChemicalStandards[i].pCeq1Min * 100).ToString();

                if (!pCMin.Equals("0"))
                {
                    g.DrawString(pCMin, font, bru, 125, chemicalStandardMinY);
                }

                if (!pMnMin.Equals("0"))
                {
                    g.DrawString(pMnMin, font, bru, 132, chemicalStandardMinY);
                }
                if (!pPMin.Equals("0"))
                {
                    g.DrawString(pPMin, font, bru, 139, chemicalStandardMinY);
                }
                if (!pSMin.Equals("0"))
                {
                    g.DrawString(pSMin, font, bru, 146, chemicalStandardMinY);
                }
                if (!pSiMin.Equals("0"))
                {
                    g.DrawString(pSiMin, font, bru, 153, chemicalStandardMinY);
                }
                if (!pNiMin.Equals("0"))
                {
                    g.DrawString(pNiMin, font, bru, 160, chemicalStandardMinY);
                }
                if (!pCrMin.Equals("0"))
                {
                    g.DrawString(pCrMin, font, bru, 167, chemicalStandardMinY);
                }
                if (!pCuMin.Equals("0"))
                {
                    g.DrawString(pCuMin, font, bru, 174, chemicalStandardMinY);
                }
                if (!pMoMin.Equals("0"))
                {
                    g.DrawString(pMoMin, font, bru, 181, chemicalStandardMinY);
                }
                if (!pAltMin.Equals("0"))
                {
                    g.DrawString(pAltMin, font, bru, 189, chemicalStandardMinY);
                }
                if (!pVMin.Equals("0"))
                {
                    g.DrawString(pVMin, font, bru, 196, chemicalStandardMinY);
                }
                if (!pCeq1Min.Equals("0"))
                {
                    g.DrawString(pCeq1Min, font, bru, 203, chemicalStandardMinY);
                }
                chemicalStandardMinY += 5;
            }
            //写入力学性能标准
            //2020-2-12修改显示效果
            int mechanicalStandardMaxY = 96;
            string rmMax = productMechanicalStandards[0].PRmMax.ToString();
            //写入试验温度的标准：0℃/20℃
            string shiyanwendu = productMechanicalStandards[0].PT;
            g.DrawString(rmMax, font, bru, 218, mechanicalStandardMaxY);
            g.DrawString(shiyanwendu, font, bru, 270, 77);
            int mechanicalStandardMinY = 101;

            string ysMin = productMechanicalStandards[0].PYsMin.ToString();
            string rmMin = productMechanicalStandards[0].PRmMin.ToString();
            string aMin = productMechanicalStandards[0].PAMin.ToString();
            string chongjiJunzhiMin = productMechanicalStandards[0].PKvAvgMin.ToString();
            //冷弯半径
            string lwbanjin = productMechanicalStandards[0].PD; int lwbanjinx = 233; int lwbanjiny = 88;
            g.DrawString(lwbanjin, font, bru, lwbanjinx, lwbanjiny);

            g.DrawString(ysMin, font, bru, 209, mechanicalStandardMinY);
            g.DrawString(rmMin, font, bru, 218, mechanicalStandardMinY);
            g.DrawString(aMin, font, bru, 227, mechanicalStandardMinY);
            g.DrawString(chongjiJunzhiMin, font, bru, 260, mechanicalStandardMinY);

            //化学成分信息，需要处理分页
            int chemicalY = 106;
            rowCountChengfen = productChemicals.Count;
            int pageMaxCountChengfen = 10;
            //给pageCountChengfen赋值
            if (rowCountChengfen % pageMaxCountChengfen == 0)
            {
                pageCountChengfen = rowCountChengfen / pageMaxCountChengfen;
            }
            else
            {
                pageCountChengfen = (rowCountChengfen / pageMaxCountChengfen) + 1;
            }

            if (rowCountChengfen > pageMaxCountChengfen)
            {
                //单页无法显示完的情况
                if (rowCountChengfen > 10 && rowCountChengfen <= 20)
                {
                    //需要2页显示质保书
                    if (currentPageIndexChengfen == 0)//当为第一页时
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            double pcFlag = productChemicals[0].PC;
                            if (pcFlag < 5)
                            {
                                //化学成分数据为原始小数数据，未翻倍，需要进行翻倍处理
                                string pc = Convert.ToInt32(productChemicals[i].PC * 100).ToString();
                                string pmn = Convert.ToInt32(productChemicals[i].PMn * 100).ToString();
                                string pp = Convert.ToInt32(productChemicals[i].PP * 1000).ToString();
                                string ps = Convert.ToInt32(productChemicals[i].PS * 1000).ToString();
                                string psi = Convert.ToInt32(productChemicals[i].PSi * 100).ToString();
                                string pni = Convert.ToInt32(productChemicals[i].PNi * 1000).ToString();
                                string pcr = Convert.ToInt32(productChemicals[i].PCr * 1000).ToString();
                                string pcu = Convert.ToInt32(productChemicals[i].PCu * 1000).ToString();
                                //处理化学成分Mo显示效果，如果为0则显示“/”
                                string pmo = "";
                                if (Convert.ToInt32(productChemicals[i].PMo * 1000) == 0)
                                {
                                    pmo = "/";
                                }
                                else
                                {
                                    pmo = Convert.ToInt32(productChemicals[i].PMo * 1000).ToString();
                                }
                                //处理化学成分Alt显示效果，如果为0则显示“/”
                                string palt = "";
                                if (Convert.ToInt32(productChemicals[i].PAlt * 1000) == 0)
                                {
                                    palt = "/";
                                }
                                else
                                {
                                    palt = Convert.ToInt32(productChemicals[i].PAlt * 1000).ToString();
                                }
                                //处理化学成分V显示效果，如果为0则显示“/”
                                string pv = "";
                                if (Convert.ToInt32(productChemicals[i].PV * 1000) == 0)
                                {
                                    pv = "/";
                                }
                                else
                                {
                                    pv = Convert.ToInt32(productChemicals[i].PV * 1000).ToString();
                                }
                                string pceq = Convert.ToInt32(productChemicals[i].PCeq * 100).ToString();

                                g.DrawString(pc, font, bru, 125, chemicalY);
                                g.DrawString(pmn, font, bru, 132, chemicalY);
                                g.DrawString(pp, font, bru, 139, chemicalY);
                                g.DrawString(ps, font, bru, 146, chemicalY);
                                g.DrawString(psi, font, bru, 153, chemicalY);
                                g.DrawString(pni, font, bru, 160, chemicalY);
                                g.DrawString(pcr, font, bru, 167, chemicalY);
                                g.DrawString(pcu, font, bru, 174, chemicalY);
                                g.DrawString(pmo, font, bru, 181, chemicalY);
                                g.DrawString(palt, font, bru, 189, chemicalY);
                                g.DrawString(pv, font, bru, 196, chemicalY);
                                g.DrawString(pceq, font, bru, 203, chemicalY);
                                chemicalY += 5;
                            }
                            else
                            {
                                //原始数据已经翻倍，不需要再处理。
                                string pc = Convert.ToInt32(productChemicals[i].PC).ToString();
                                string pmn = Convert.ToInt32(productChemicals[i].PMn).ToString();
                                string pp = Convert.ToInt32(productChemicals[i].PP).ToString();
                                string ps = Convert.ToInt32(productChemicals[i].PS).ToString();
                                string psi = Convert.ToInt32(productChemicals[i].PSi).ToString();
                                string pni = Convert.ToInt32(productChemicals[i].PNi).ToString();
                                string pcr = Convert.ToInt32(productChemicals[i].PCr).ToString();
                                string pcu = Convert.ToInt32(productChemicals[i].PCu).ToString();
                                string pmo = "";
                                if (Convert.ToInt32(productChemicals[i].PMo) == 0)
                                {
                                    pmo = "/";
                                }
                                else
                                {
                                    pmo = Convert.ToInt32(productChemicals[i].PMo).ToString();
                                }
                                //处理化学成分Alt显示效果，如果为0则显示“/”
                                string palt = "";
                                if (Convert.ToInt32(productChemicals[i].PAlt) == 0)
                                {
                                    palt = "/";
                                }
                                else
                                {
                                    palt = Convert.ToInt32(productChemicals[i].PAlt).ToString();
                                }
                                //处理化学成分V显示效果，如果为0则显示“/”
                                string pv = "";
                                if (Convert.ToInt32(productChemicals[i].PV) == 0)
                                {
                                    pv = "/";
                                }
                                else
                                {
                                    pv = Convert.ToInt32(productChemicals[i].PV).ToString();
                                }
                                string pceq = Convert.ToInt32(productChemicals[i].PCeq).ToString();

                                g.DrawString(pc, font, bru, 125, chemicalY);
                                g.DrawString(pmn, font, bru, 132, chemicalY);
                                g.DrawString(pp, font, bru, 139, chemicalY);
                                g.DrawString(ps, font, bru, 146, chemicalY);
                                g.DrawString(psi, font, bru, 153, chemicalY);
                                g.DrawString(pni, font, bru, 160, chemicalY);
                                g.DrawString(pcr, font, bru, 167, chemicalY);
                                g.DrawString(pcu, font, bru, 174, chemicalY);
                                g.DrawString(pmo, font, bru, 181, chemicalY);
                                g.DrawString(palt, font, bru, 189, chemicalY);
                                g.DrawString(pv, font, bru, 196, chemicalY);
                                g.DrawString(pceq, font, bru, 203, chemicalY);
                                chemicalY += 5;
                            }
                        }
                    }
                    else if (currentPageIndexChengfen == 1)//当为第二页时
                    {
                        for (int i = 10; i < productChemicals.Count; i++)
                        {
                            double pcFlag = productChemicals[0].PC;
                            if (pcFlag < 5)
                            {
                                //化学成分数据为原始小数数据，未翻倍，需要进行翻倍处理
                                string pc = Convert.ToInt32(productChemicals[i].PC * 100).ToString();
                                string pmn = Convert.ToInt32(productChemicals[i].PMn * 100).ToString();
                                string pp = Convert.ToInt32(productChemicals[i].PP * 1000).ToString();
                                string ps = Convert.ToInt32(productChemicals[i].PS * 1000).ToString();
                                string psi = Convert.ToInt32(productChemicals[i].PSi * 100).ToString();
                                string pni = Convert.ToInt32(productChemicals[i].PNi * 1000).ToString();
                                string pcr = Convert.ToInt32(productChemicals[i].PCr * 1000).ToString();
                                string pcu = Convert.ToInt32(productChemicals[i].PCu * 1000).ToString();
                                string pmo = "";
                                if (Convert.ToInt32(productChemicals[i].PMo * 1000) == 0)
                                {
                                    pmo = "/";
                                }
                                else
                                {
                                    pmo = Convert.ToInt32(productChemicals[i].PMo * 1000).ToString();
                                }
                                //处理化学成分Alt显示效果，如果为0则显示“/”
                                string palt = "";
                                if (Convert.ToInt32(productChemicals[i].PAlt * 1000) == 0)
                                {
                                    palt = "/";
                                }
                                else
                                {
                                    palt = Convert.ToInt32(productChemicals[i].PAlt * 1000).ToString();
                                }
                                //处理化学成分V显示效果，如果为0则显示“/”
                                string pv = "";
                                if (Convert.ToInt32(productChemicals[i].PV * 1000) == 0)
                                {
                                    pv = "/";
                                }
                                else
                                {
                                    pv = Convert.ToInt32(productChemicals[i].PV * 1000).ToString();
                                }
                                string pceq = Convert.ToInt32(productChemicals[i].PCeq * 100).ToString();

                                g.DrawString(pc, font, bru, 125, chemicalY);
                                g.DrawString(pmn, font, bru, 132, chemicalY);
                                g.DrawString(pp, font, bru, 139, chemicalY);
                                g.DrawString(ps, font, bru, 146, chemicalY);
                                g.DrawString(psi, font, bru, 153, chemicalY);
                                g.DrawString(pni, font, bru, 160, chemicalY);
                                g.DrawString(pcr, font, bru, 167, chemicalY);
                                g.DrawString(pcu, font, bru, 174, chemicalY);
                                g.DrawString(pmo, font, bru, 181, chemicalY);
                                g.DrawString(palt, font, bru, 189, chemicalY);
                                g.DrawString(pv, font, bru, 196, chemicalY);
                                g.DrawString(pceq, font, bru, 203, chemicalY);
                                chemicalY += 5;
                            }
                            else
                            {
                                //原始数据已经翻倍，不需要再处理。
                                string pc = Convert.ToInt32(productChemicals[i].PC).ToString();
                                string pmn = Convert.ToInt32(productChemicals[i].PMn).ToString();
                                string pp = Convert.ToInt32(productChemicals[i].PP).ToString();
                                string ps = Convert.ToInt32(productChemicals[i].PS).ToString();
                                string psi = Convert.ToInt32(productChemicals[i].PSi).ToString();
                                string pni = Convert.ToInt32(productChemicals[i].PNi).ToString();
                                string pcr = Convert.ToInt32(productChemicals[i].PCr).ToString();
                                string pcu = Convert.ToInt32(productChemicals[i].PCu).ToString();
                                string pmo = "";
                                if (Convert.ToInt32(productChemicals[i].PMo) == 0)
                                {
                                    pmo = "/";
                                }
                                else
                                {
                                    pmo = Convert.ToInt32(productChemicals[i].PMo).ToString();
                                }
                                //处理化学成分Alt显示效果，如果为0则显示“/”
                                string palt = "";
                                if (Convert.ToInt32(productChemicals[i].PAlt) == 0)
                                {
                                    palt = "/";
                                }
                                else
                                {
                                    palt = Convert.ToInt32(productChemicals[i].PAlt).ToString();
                                }
                                //处理化学成分V显示效果，如果为0则显示“/”
                                string pv = "";
                                if (Convert.ToInt32(productChemicals[i].PV) == 0)
                                {
                                    pv = "/";
                                }
                                else
                                {
                                    pv = Convert.ToInt32(productChemicals[i].PV).ToString();
                                }
                                string pceq = Convert.ToInt32(productChemicals[i].PCeq).ToString();

                                g.DrawString(pc, font, bru, 125, chemicalY);
                                g.DrawString(pmn, font, bru, 132, chemicalY);
                                g.DrawString(pp, font, bru, 139, chemicalY);
                                g.DrawString(ps, font, bru, 146, chemicalY);
                                g.DrawString(psi, font, bru, 153, chemicalY);
                                g.DrawString(pni, font, bru, 160, chemicalY);
                                g.DrawString(pcr, font, bru, 167, chemicalY);
                                g.DrawString(pcu, font, bru, 174, chemicalY);
                                g.DrawString(pmo, font, bru, 181, chemicalY);
                                g.DrawString(palt, font, bru, 189, chemicalY);
                                g.DrawString(pv, font, bru, 196, chemicalY);
                                g.DrawString(pceq, font, bru, 203, chemicalY);
                                chemicalY += 5;
                            }
                        }
                    }
                }
                else if (rowCountChengfen > 20 && rowCountChengfen <= 30)
                {
                    //需要三张纸
                    if (currentPageIndexChengfen == 0)//当为第一页时
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            double pcFlag = productChemicals[0].PC;
                            if (pcFlag < 5)
                            {
                                //化学成分数据为原始小数数据，未翻倍，需要进行翻倍处理
                                string pc = Convert.ToInt32(productChemicals[i].PC * 100).ToString();
                                string pmn = Convert.ToInt32(productChemicals[i].PMn * 100).ToString();
                                string pp = Convert.ToInt32(productChemicals[i].PP * 1000).ToString();
                                string ps = Convert.ToInt32(productChemicals[i].PS * 1000).ToString();
                                string psi = Convert.ToInt32(productChemicals[i].PSi * 100).ToString();
                                string pni = Convert.ToInt32(productChemicals[i].PNi * 1000).ToString();
                                string pcr = Convert.ToInt32(productChemicals[i].PCr * 1000).ToString();
                                string pcu = Convert.ToInt32(productChemicals[i].PCu * 1000).ToString();
                                //处理化学成分Mo显示效果，如果为0则显示“/”
                                string pmo = "";
                                if (Convert.ToInt32(productChemicals[i].PMo * 1000) == 0)
                                {
                                    pmo = "/";
                                }
                                else
                                {
                                    pmo = Convert.ToInt32(productChemicals[i].PMo * 1000).ToString();
                                }
                                //处理化学成分Alt显示效果，如果为0则显示“/”
                                string palt = "";
                                if (Convert.ToInt32(productChemicals[i].PAlt * 1000) == 0)
                                {
                                    palt = "/";
                                }
                                else
                                {
                                    palt = Convert.ToInt32(productChemicals[i].PAlt * 1000).ToString();
                                }
                                //处理化学成分V显示效果，如果为0则显示“/”
                                string pv = "";
                                if (Convert.ToInt32(productChemicals[i].PV * 1000) == 0)
                                {
                                    pv = "/";
                                }
                                else
                                {
                                    pv = Convert.ToInt32(productChemicals[i].PV * 1000).ToString();
                                }
                                string pceq = Convert.ToInt32(productChemicals[i].PCeq * 100).ToString();

                                g.DrawString(pc, font, bru, 125, chemicalY);
                                g.DrawString(pmn, font, bru, 132, chemicalY);
                                g.DrawString(pp, font, bru, 139, chemicalY);
                                g.DrawString(ps, font, bru, 146, chemicalY);
                                g.DrawString(psi, font, bru, 153, chemicalY);
                                g.DrawString(pni, font, bru, 160, chemicalY);
                                g.DrawString(pcr, font, bru, 167, chemicalY);
                                g.DrawString(pcu, font, bru, 174, chemicalY);
                                g.DrawString(pmo, font, bru, 181, chemicalY);
                                g.DrawString(palt, font, bru, 189, chemicalY);
                                g.DrawString(pv, font, bru, 196, chemicalY);
                                g.DrawString(pceq, font, bru, 203, chemicalY);
                                chemicalY += 5;
                            }
                            else
                            {
                                //原始数据已经翻倍，不需要再处理。
                                string pc = Convert.ToInt32(productChemicals[i].PC).ToString();
                                string pmn = Convert.ToInt32(productChemicals[i].PMn).ToString();
                                string pp = Convert.ToInt32(productChemicals[i].PP).ToString();
                                string ps = Convert.ToInt32(productChemicals[i].PS).ToString();
                                string psi = Convert.ToInt32(productChemicals[i].PSi).ToString();
                                string pni = Convert.ToInt32(productChemicals[i].PNi).ToString();
                                string pcr = Convert.ToInt32(productChemicals[i].PCr).ToString();
                                string pcu = Convert.ToInt32(productChemicals[i].PCu).ToString();
                                string pmo = "";
                                if (Convert.ToInt32(productChemicals[i].PMo) == 0)
                                {
                                    pmo = "/";
                                }
                                else
                                {
                                    pmo = Convert.ToInt32(productChemicals[i].PMo).ToString();
                                }
                                //处理化学成分Alt显示效果，如果为0则显示“/”
                                string palt = "";
                                if (Convert.ToInt32(productChemicals[i].PAlt) == 0)
                                {
                                    palt = "/";
                                }
                                else
                                {
                                    palt = Convert.ToInt32(productChemicals[i].PAlt).ToString();
                                }
                                //处理化学成分V显示效果，如果为0则显示“/”
                                string pv = "";
                                if (Convert.ToInt32(productChemicals[i].PV) == 0)
                                {
                                    pv = "/";
                                }
                                else
                                {
                                    pv = Convert.ToInt32(productChemicals[i].PV).ToString();
                                }
                                string pceq = Convert.ToInt32(productChemicals[i].PCeq).ToString();

                                g.DrawString(pc, font, bru, 125, chemicalY);
                                g.DrawString(pmn, font, bru, 132, chemicalY);
                                g.DrawString(pp, font, bru, 139, chemicalY);
                                g.DrawString(ps, font, bru, 146, chemicalY);
                                g.DrawString(psi, font, bru, 153, chemicalY);
                                g.DrawString(pni, font, bru, 160, chemicalY);
                                g.DrawString(pcr, font, bru, 167, chemicalY);
                                g.DrawString(pcu, font, bru, 174, chemicalY);
                                g.DrawString(pmo, font, bru, 181, chemicalY);
                                g.DrawString(palt, font, bru, 189, chemicalY);
                                g.DrawString(pv, font, bru, 196, chemicalY);
                                g.DrawString(pceq, font, bru, 203, chemicalY);
                                chemicalY += 5;
                            }
                        }
                    }
                    else if (currentPageIndexChengfen == 1)//当为第二页时
                    {
                        for (int i = 10; i < 20; i++)
                        {
                            double pcFlag = productChemicals[0].PC;
                            if (pcFlag < 5)
                            {
                                //化学成分数据为原始小数数据，未翻倍，需要进行翻倍处理
                                string pc = Convert.ToInt32(productChemicals[i].PC * 100).ToString();
                                string pmn = Convert.ToInt32(productChemicals[i].PMn * 100).ToString();
                                string pp = Convert.ToInt32(productChemicals[i].PP * 1000).ToString();
                                string ps = Convert.ToInt32(productChemicals[i].PS * 1000).ToString();
                                string psi = Convert.ToInt32(productChemicals[i].PSi * 100).ToString();
                                string pni = Convert.ToInt32(productChemicals[i].PNi * 1000).ToString();
                                string pcr = Convert.ToInt32(productChemicals[i].PCr * 1000).ToString();
                                string pcu = Convert.ToInt32(productChemicals[i].PCu * 1000).ToString();
                                string pmo = "";
                                if (Convert.ToInt32(productChemicals[i].PMo * 1000) == 0)
                                {
                                    pmo = "/";
                                }
                                else
                                {
                                    pmo = Convert.ToInt32(productChemicals[i].PMo * 1000).ToString();
                                }
                                //处理化学成分Alt显示效果，如果为0则显示“/”
                                string palt = "";
                                if (Convert.ToInt32(productChemicals[i].PAlt * 1000) == 0)
                                {
                                    palt = "/";
                                }
                                else
                                {
                                    palt = Convert.ToInt32(productChemicals[i].PAlt * 1000).ToString();
                                }
                                //处理化学成分V显示效果，如果为0则显示“/”
                                string pv = "";
                                if (Convert.ToInt32(productChemicals[i].PV * 1000) == 0)
                                {
                                    pv = "/";
                                }
                                else
                                {
                                    pv = Convert.ToInt32(productChemicals[i].PV * 1000).ToString();
                                }
                                string pceq = Convert.ToInt32(productChemicals[i].PCeq * 100).ToString();

                                g.DrawString(pc, font, bru, 125, chemicalY);
                                g.DrawString(pmn, font, bru, 132, chemicalY);
                                g.DrawString(pp, font, bru, 139, chemicalY);
                                g.DrawString(ps, font, bru, 146, chemicalY);
                                g.DrawString(psi, font, bru, 153, chemicalY);
                                g.DrawString(pni, font, bru, 160, chemicalY);
                                g.DrawString(pcr, font, bru, 167, chemicalY);
                                g.DrawString(pcu, font, bru, 174, chemicalY);
                                g.DrawString(pmo, font, bru, 181, chemicalY);
                                g.DrawString(palt, font, bru, 189, chemicalY);
                                g.DrawString(pv, font, bru, 196, chemicalY);
                                g.DrawString(pceq, font, bru, 203, chemicalY);
                                chemicalY += 5;
                            }
                            else
                            {
                                //原始数据已经翻倍，不需要再处理。
                                string pc = Convert.ToInt32(productChemicals[i].PC).ToString();
                                string pmn = Convert.ToInt32(productChemicals[i].PMn).ToString();
                                string pp = Convert.ToInt32(productChemicals[i].PP).ToString();
                                string ps = Convert.ToInt32(productChemicals[i].PS).ToString();
                                string psi = Convert.ToInt32(productChemicals[i].PSi).ToString();
                                string pni = Convert.ToInt32(productChemicals[i].PNi).ToString();
                                string pcr = Convert.ToInt32(productChemicals[i].PCr).ToString();
                                string pcu = Convert.ToInt32(productChemicals[i].PCu).ToString();
                                string pmo = "";
                                if (Convert.ToInt32(productChemicals[i].PMo) == 0)
                                {
                                    pmo = "/";
                                }
                                else
                                {
                                    pmo = Convert.ToInt32(productChemicals[i].PMo).ToString();
                                }
                                //处理化学成分Alt显示效果，如果为0则显示“/”
                                string palt = "";
                                if (Convert.ToInt32(productChemicals[i].PAlt) == 0)
                                {
                                    palt = "/";
                                }
                                else
                                {
                                    palt = Convert.ToInt32(productChemicals[i].PAlt).ToString();
                                }
                                //处理化学成分V显示效果，如果为0则显示“/”
                                string pv = "";
                                if (Convert.ToInt32(productChemicals[i].PV) == 0)
                                {
                                    pv = "/";
                                }
                                else
                                {
                                    pv = Convert.ToInt32(productChemicals[i].PV).ToString();
                                }
                                string pceq = Convert.ToInt32(productChemicals[i].PCeq).ToString();

                                g.DrawString(pc, font, bru, 125, chemicalY);
                                g.DrawString(pmn, font, bru, 132, chemicalY);
                                g.DrawString(pp, font, bru, 139, chemicalY);
                                g.DrawString(ps, font, bru, 146, chemicalY);
                                g.DrawString(psi, font, bru, 153, chemicalY);
                                g.DrawString(pni, font, bru, 160, chemicalY);
                                g.DrawString(pcr, font, bru, 167, chemicalY);
                                g.DrawString(pcu, font, bru, 174, chemicalY);
                                g.DrawString(pmo, font, bru, 181, chemicalY);
                                g.DrawString(palt, font, bru, 189, chemicalY);
                                g.DrawString(pv, font, bru, 196, chemicalY);
                                g.DrawString(pceq, font, bru, 203, chemicalY);
                                chemicalY += 5;
                            }
                        }
                    }
                    else if (currentPageIndexChengfen == 2)//第三页
                    {
                        for (int i = 20; i < productChemicals.Count; i++)
                        {
                            double pcFlag = productChemicals[0].PC;
                            if (pcFlag < 5)
                            {
                                //化学成分数据为原始小数数据，未翻倍，需要进行翻倍处理
                                string pc = Convert.ToInt32(productChemicals[i].PC * 100).ToString();
                                string pmn = Convert.ToInt32(productChemicals[i].PMn * 100).ToString();
                                string pp = Convert.ToInt32(productChemicals[i].PP * 1000).ToString();
                                string ps = Convert.ToInt32(productChemicals[i].PS * 1000).ToString();
                                string psi = Convert.ToInt32(productChemicals[i].PSi * 100).ToString();
                                string pni = Convert.ToInt32(productChemicals[i].PNi * 1000).ToString();
                                string pcr = Convert.ToInt32(productChemicals[i].PCr * 1000).ToString();
                                string pcu = Convert.ToInt32(productChemicals[i].PCu * 1000).ToString();
                                string pmo = "";
                                if (Convert.ToInt32(productChemicals[i].PMo * 1000) == 0)
                                {
                                    pmo = "/";
                                }
                                else
                                {
                                    pmo = Convert.ToInt32(productChemicals[i].PMo * 1000).ToString();
                                }
                                //处理化学成分Alt显示效果，如果为0则显示“/”
                                string palt = "";
                                if (Convert.ToInt32(productChemicals[i].PAlt * 1000) == 0)
                                {
                                    palt = "/";
                                }
                                else
                                {
                                    palt = Convert.ToInt32(productChemicals[i].PAlt * 1000).ToString();
                                }
                                //处理化学成分V显示效果，如果为0则显示“/”
                                string pv = "";
                                if (Convert.ToInt32(productChemicals[i].PV * 1000) == 0)
                                {
                                    pv = "/";
                                }
                                else
                                {
                                    pv = Convert.ToInt32(productChemicals[i].PV * 1000).ToString();
                                }
                                string pceq = Convert.ToInt32(productChemicals[i].PCeq * 100).ToString();

                                g.DrawString(pc, font, bru, 125, chemicalY);
                                g.DrawString(pmn, font, bru, 132, chemicalY);
                                g.DrawString(pp, font, bru, 139, chemicalY);
                                g.DrawString(ps, font, bru, 146, chemicalY);
                                g.DrawString(psi, font, bru, 153, chemicalY);
                                g.DrawString(pni, font, bru, 160, chemicalY);
                                g.DrawString(pcr, font, bru, 167, chemicalY);
                                g.DrawString(pcu, font, bru, 174, chemicalY);
                                g.DrawString(pmo, font, bru, 181, chemicalY);
                                g.DrawString(palt, font, bru, 189, chemicalY);
                                g.DrawString(pv, font, bru, 196, chemicalY);
                                g.DrawString(pceq, font, bru, 203, chemicalY);
                                chemicalY += 5;
                            }
                            else
                            {
                                //原始数据已经翻倍，不需要再处理。
                                string pc = Convert.ToInt32(productChemicals[i].PC).ToString();
                                string pmn = Convert.ToInt32(productChemicals[i].PMn).ToString();
                                string pp = Convert.ToInt32(productChemicals[i].PP).ToString();
                                string ps = Convert.ToInt32(productChemicals[i].PS).ToString();
                                string psi = Convert.ToInt32(productChemicals[i].PSi).ToString();
                                string pni = Convert.ToInt32(productChemicals[i].PNi).ToString();
                                string pcr = Convert.ToInt32(productChemicals[i].PCr).ToString();
                                string pcu = Convert.ToInt32(productChemicals[i].PCu).ToString();
                                string pmo = "";
                                if (Convert.ToInt32(productChemicals[i].PMo) == 0)
                                {
                                    pmo = "/";
                                }
                                else
                                {
                                    pmo = Convert.ToInt32(productChemicals[i].PMo).ToString();
                                }
                                //处理化学成分Alt显示效果，如果为0则显示“/”
                                string palt = "";
                                if (Convert.ToInt32(productChemicals[i].PAlt) == 0)
                                {
                                    palt = "/";
                                }
                                else
                                {
                                    palt = Convert.ToInt32(productChemicals[i].PAlt).ToString();
                                }
                                //处理化学成分V显示效果，如果为0则显示“/”
                                string pv = "";
                                if (Convert.ToInt32(productChemicals[i].PV) == 0)
                                {
                                    pv = "/";
                                }
                                else
                                {
                                    pv = Convert.ToInt32(productChemicals[i].PV).ToString();
                                }
                                string pceq = Convert.ToInt32(productChemicals[i].PCeq).ToString();

                                g.DrawString(pc, font, bru, 125, chemicalY);
                                g.DrawString(pmn, font, bru, 132, chemicalY);
                                g.DrawString(pp, font, bru, 139, chemicalY);
                                g.DrawString(ps, font, bru, 146, chemicalY);
                                g.DrawString(psi, font, bru, 153, chemicalY);
                                g.DrawString(pni, font, bru, 160, chemicalY);
                                g.DrawString(pcr, font, bru, 167, chemicalY);
                                g.DrawString(pcu, font, bru, 174, chemicalY);
                                g.DrawString(pmo, font, bru, 181, chemicalY);
                                g.DrawString(palt, font, bru, 189, chemicalY);
                                g.DrawString(pv, font, bru, 196, chemicalY);
                                g.DrawString(pceq, font, bru, 203, chemicalY);
                                chemicalY += 5;
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("该份质保书需要四张纸，联系管理员调整！");
                }
                currentPageIndexChengfen++;      //加新页  
                if (currentPageIndexChengfen < pageCountChengfen)
                {
                    e.HasMorePages = true;  //如果小于定义页 那么增加新的页数
                }
                else
                {
                    e.HasMorePages = false; //停止增加新的页数
                    currentPageIndexChengfen = 0;
                }

            }
            else
            {
                for (int i = 0; i < productChemicals.Count; i++)
                {
                    double pcFlag = productChemicals[0].PC;
                    if (pcFlag < 5)
                    {
                        //化学成分数据为原始小数数据，未翻倍，需要进行翻倍处理
                        string pc = Convert.ToInt32(productChemicals[i].PC * 100).ToString();
                        string pmn = Convert.ToInt32(productChemicals[i].PMn * 100).ToString();
                        string pp = Convert.ToInt32(productChemicals[i].PP * 1000).ToString();
                        string ps = Convert.ToInt32(productChemicals[i].PS * 1000).ToString();
                        string psi = Convert.ToInt32(productChemicals[i].PSi * 100).ToString();
                        string pni = Convert.ToInt32(productChemicals[i].PNi * 1000).ToString();
                        string pcr = Convert.ToInt32(productChemicals[i].PCr * 1000).ToString();
                        string pcu = Convert.ToInt32(productChemicals[i].PCu * 1000).ToString();
                        string pmo = "";
                        if (Convert.ToInt32(productChemicals[i].PMo * 1000) == 0)
                        {
                            pmo = "/";
                        }
                        else
                        {
                            pmo = Convert.ToInt32(productChemicals[i].PMo * 1000).ToString();
                        }
                        //处理化学成分Alt显示效果，如果为0则显示“/”
                        string palt = "";
                        if (Convert.ToInt32(productChemicals[i].PAlt * 1000) == 0)
                        {
                            palt = "/";
                        }
                        else
                        {
                            palt = Convert.ToInt32(productChemicals[i].PAlt * 1000).ToString();
                        }
                        //处理化学成分V显示效果，如果为0则显示“/”
                        string pv = "";
                        if (Convert.ToInt32(productChemicals[i].PV * 1000) == 0)
                        {
                            pv = "/";
                        }
                        else
                        {
                            pv = Convert.ToInt32(productChemicals[i].PV * 1000).ToString();
                        }
                        string pceq = Convert.ToInt32(productChemicals[i].PCeq * 100).ToString();

                        g.DrawString(pc, font, bru, 125, chemicalY);
                        g.DrawString(pmn, font, bru, 132, chemicalY);
                        g.DrawString(pp, font, bru, 139, chemicalY);
                        g.DrawString(ps, font, bru, 146, chemicalY);
                        g.DrawString(psi, font, bru, 153, chemicalY);
                        g.DrawString(pni, font, bru, 160, chemicalY);
                        g.DrawString(pcr, font, bru, 167, chemicalY);
                        g.DrawString(pcu, font, bru, 174, chemicalY);
                        g.DrawString(pmo, font, bru, 181, chemicalY);
                        g.DrawString(palt, font, bru, 189, chemicalY);
                        g.DrawString(pv, font, bru, 196, chemicalY);
                        g.DrawString(pceq, font, bru, 203, chemicalY);
                        chemicalY += 5;
                    }
                    else
                    {
                        //原始数据已经翻倍，不需要再处理。
                        string pc = Convert.ToInt32(productChemicals[i].PC).ToString();
                        string pmn = Convert.ToInt32(productChemicals[i].PMn).ToString();
                        string pp = Convert.ToInt32(productChemicals[i].PP).ToString();
                        string ps = Convert.ToInt32(productChemicals[i].PS).ToString();
                        string psi = Convert.ToInt32(productChemicals[i].PSi).ToString();
                        string pni = Convert.ToInt32(productChemicals[i].PNi).ToString();
                        string pcr = Convert.ToInt32(productChemicals[i].PCr).ToString();
                        string pcu = Convert.ToInt32(productChemicals[i].PCu).ToString();
                        string pmo = "";
                        if (Convert.ToInt32(productChemicals[i].PMo) == 0)
                        {
                            pmo = "/";
                        }
                        else
                        {
                            pmo = Convert.ToInt32(productChemicals[i].PMo).ToString();
                        }
                        //处理化学成分Alt显示效果，如果为0则显示“/”
                        string palt = "";
                        if (Convert.ToInt32(productChemicals[i].PAlt) == 0)
                        {
                            palt = "/";
                        }
                        else
                        {
                            palt = Convert.ToInt32(productChemicals[i].PAlt).ToString();
                        }
                        //处理化学成分V显示效果，如果为0则显示“/”
                        string pv = "";
                        if (Convert.ToInt32(productChemicals[i].PV) == 0)
                        {
                            pv = "/";
                        }
                        else
                        {
                            pv = Convert.ToInt32(productChemicals[i].PV).ToString();
                        }
                        string pceq = Convert.ToInt32(productChemicals[i].PCeq).ToString();
                        g.DrawString(pc, font, bru, 125, chemicalY);
                        g.DrawString(pmn, font, bru, 132, chemicalY);
                        g.DrawString(pp, font, bru, 139, chemicalY);
                        g.DrawString(ps, font, bru, 146, chemicalY);
                        g.DrawString(psi, font, bru, 153, chemicalY);
                        g.DrawString(pni, font, bru, 160, chemicalY);
                        g.DrawString(pcr, font, bru, 167, chemicalY);
                        g.DrawString(pcu, font, bru, 174, chemicalY);
                        g.DrawString(pmo, font, bru, 181, chemicalY);
                        g.DrawString(palt, font, bru, 189, chemicalY);
                        g.DrawString(pv, font, bru, 196, chemicalY);
                        g.DrawString(pceq, font, bru, 203, chemicalY);
                        chemicalY += 5;
                    }

                }
            }
            //力学性能数据  需要分页处理  
            int mechanicalY = 106;
            rowCountXingNeng = productMechanicals.Count;
            int pageMaxCountXingNeng = 10;

            //给pageCountXingNeng赋值
            if (rowCountXingNeng % pageMaxCountXingNeng == 0)
            {
                pageCountXingNeng = rowCountXingNeng / pageMaxCountXingNeng;
            }
            else
            {
                pageCountXingNeng = (rowCountXingNeng / pageMaxCountXingNeng) + 1;
            }

            if (rowCountXingNeng > pageMaxCountXingNeng)
            {
                //单页无法显示完的情况


                if (rowCountXingNeng > 10 && rowCountXingNeng <= 20)
                {
                    //需要2页
                    if (currentPageIndexXingNeng == 0)   //当为第一页时
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            int qufuqiangdu = Convert.ToInt32(productMechanicals[i].PYs);
                            int kanglaqiangdu = Convert.ToInt32(productMechanicals[i].PRm);
                            int yanshenglv = Convert.ToInt32(productMechanicals[i].PA);
                            string lw = productMechanicals[i].PD;
                            int chongji1 = Convert.ToInt32(productMechanicals[i].PKv1);
                            int chongji2 = Convert.ToInt32(productMechanicals[i].PKv2);
                            int chongji3 = Convert.ToInt32(productMechanicals[i].PKv3);
                            int chongjiAvg = Convert.ToInt32(productMechanicals[i].PKvAvg);

                            g.DrawString(qufuqiangdu.ToString(), font, bru, 210, mechanicalY);
                            g.DrawString(kanglaqiangdu.ToString(), font, bru, 219, mechanicalY);
                            g.DrawString(yanshenglv.ToString(), font, bru, 227, mechanicalY);
                            g.DrawString(lw, font, bru, 233, mechanicalY);
                            g.DrawString(chongji1.ToString(), font, bru, 245, mechanicalY);
                            g.DrawString(chongji2.ToString(), font, bru, 256, mechanicalY);
                            g.DrawString(chongji3.ToString(), font, bru, 268, mechanicalY);
                            g.DrawString(chongjiAvg.ToString(), font, bru, 278, mechanicalY);
                            mechanicalY += 5;
                        }
                    }
                    else if (currentPageIndexXingNeng == 1)   //当为第二页时
                    {
                        for (int i = 10; i < productMechanicals.Count; i++)
                        {
                            int qufuqiangdu = Convert.ToInt32(productMechanicals[i].PYs);
                            int kanglaqiangdu = Convert.ToInt32(productMechanicals[i].PRm);
                            int yanshenglv = Convert.ToInt32(productMechanicals[i].PA);
                            string lw = productMechanicals[i].PD;
                            int chongji1 = Convert.ToInt32(productMechanicals[i].PKv1);
                            int chongji2 = Convert.ToInt32(productMechanicals[i].PKv2);
                            int chongji3 = Convert.ToInt32(productMechanicals[i].PKv3);
                            int chongjiAvg = Convert.ToInt32(productMechanicals[i].PKvAvg);

                            g.DrawString(qufuqiangdu.ToString(), font, bru, 210, mechanicalY);
                            g.DrawString(kanglaqiangdu.ToString(), font, bru, 219, mechanicalY);
                            g.DrawString(yanshenglv.ToString(), font, bru, 227, mechanicalY);
                            g.DrawString(lw, font, bru, 233, mechanicalY);
                            g.DrawString(chongji1.ToString(), font, bru, 245, mechanicalY);
                            g.DrawString(chongji2.ToString(), font, bru, 256, mechanicalY);
                            g.DrawString(chongji3.ToString(), font, bru, 268, mechanicalY);
                            g.DrawString(chongjiAvg.ToString(), font, bru, 278, mechanicalY);
                            mechanicalY += 5;
                        }
                    }
                }
                else if (rowCountXingNeng > 20 && rowCountXingNeng <= 30)
                {
                    //需要3页
                    if (currentPageIndexXingNeng == 0)   //当为第一页时
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            int qufuqiangdu = Convert.ToInt32(productMechanicals[i].PYs);
                            int kanglaqiangdu = Convert.ToInt32(productMechanicals[i].PRm);
                            int yanshenglv = Convert.ToInt32(productMechanicals[i].PA);
                            string lw = productMechanicals[i].PD;
                            int chongji1 = Convert.ToInt32(productMechanicals[i].PKv1);
                            int chongji2 = Convert.ToInt32(productMechanicals[i].PKv2);
                            int chongji3 = Convert.ToInt32(productMechanicals[i].PKv3);
                            int chongjiAvg = Convert.ToInt32(productMechanicals[i].PKvAvg);

                            g.DrawString(qufuqiangdu.ToString(), font, bru, 210, mechanicalY);
                            g.DrawString(kanglaqiangdu.ToString(), font, bru, 219, mechanicalY);
                            g.DrawString(yanshenglv.ToString(), font, bru, 227, mechanicalY);
                            g.DrawString(lw, font, bru, 233, mechanicalY);
                            g.DrawString(chongji1.ToString(), font, bru, 245, mechanicalY);
                            g.DrawString(chongji2.ToString(), font, bru, 256, mechanicalY);
                            g.DrawString(chongji3.ToString(), font, bru, 268, mechanicalY);
                            g.DrawString(chongjiAvg.ToString(), font, bru, 278, mechanicalY);
                            mechanicalY += 5;
                        }
                    }
                    else if (currentPageIndexXingNeng == 1)   //当为第二页时
                    {
                        for (int i = 10; i < 20; i++)
                        {
                            int qufuqiangdu = Convert.ToInt32(productMechanicals[i].PYs);
                            int kanglaqiangdu = Convert.ToInt32(productMechanicals[i].PRm);
                            int yanshenglv = Convert.ToInt32(productMechanicals[i].PA);
                            string lw = productMechanicals[i].PD;
                            int chongji1 = Convert.ToInt32(productMechanicals[i].PKv1);
                            int chongji2 = Convert.ToInt32(productMechanicals[i].PKv2);
                            int chongji3 = Convert.ToInt32(productMechanicals[i].PKv3);
                            int chongjiAvg = Convert.ToInt32(productMechanicals[i].PKvAvg);

                            g.DrawString(qufuqiangdu.ToString(), font, bru, 210, mechanicalY);
                            g.DrawString(kanglaqiangdu.ToString(), font, bru, 219, mechanicalY);
                            g.DrawString(yanshenglv.ToString(), font, bru, 227, mechanicalY);
                            g.DrawString(lw, font, bru, 233, mechanicalY);
                            g.DrawString(chongji1.ToString(), font, bru, 245, mechanicalY);
                            g.DrawString(chongji2.ToString(), font, bru, 256, mechanicalY);
                            g.DrawString(chongji3.ToString(), font, bru, 268, mechanicalY);
                            g.DrawString(chongjiAvg.ToString(), font, bru, 278, mechanicalY);
                            mechanicalY += 5;
                        }
                    }
                    else if (currentPageIndexXingNeng == 2) //当为第三页的时候
                    {
                        for (int i = 20; i < productMechanicals.Count; i++)
                        {
                            int qufuqiangdu = Convert.ToInt32(productMechanicals[i].PYs);
                            int kanglaqiangdu = Convert.ToInt32(productMechanicals[i].PRm);
                            int yanshenglv = Convert.ToInt32(productMechanicals[i].PA);
                            string lw = productMechanicals[i].PD;
                            int chongji1 = Convert.ToInt32(productMechanicals[i].PKv1);
                            int chongji2 = Convert.ToInt32(productMechanicals[i].PKv2);
                            int chongji3 = Convert.ToInt32(productMechanicals[i].PKv3);
                            int chongjiAvg = Convert.ToInt32(productMechanicals[i].PKvAvg);

                            g.DrawString(qufuqiangdu.ToString(), font, bru, 210, mechanicalY);
                            g.DrawString(kanglaqiangdu.ToString(), font, bru, 219, mechanicalY);
                            g.DrawString(yanshenglv.ToString(), font, bru, 227, mechanicalY);
                            g.DrawString(lw, font, bru, 233, mechanicalY);
                            g.DrawString(chongji1.ToString(), font, bru, 245, mechanicalY);
                            g.DrawString(chongji2.ToString(), font, bru, 256, mechanicalY);
                            g.DrawString(chongji3.ToString(), font, bru, 268, mechanicalY);
                            g.DrawString(chongjiAvg.ToString(), font, bru, 278, mechanicalY);
                            mechanicalY += 5;
                        }
                    }
                }
                currentPageIndexXingNeng++;      //加新页  
                if (currentPageIndexXingNeng < pageCountXingNeng)
                {
                    e.HasMorePages = true;  //如果小于定义页 那么增加新的页数
                }
                else
                {
                    e.HasMorePages = false; //停止增加新的页数
                    currentPageIndexXingNeng = 0;
                }
            }
            else
            {
                //单页可以显示完
                for (int i = 0; i < productMechanicals.Count; i++)
                {
                    int qufuqiangdu = Convert.ToInt32(productMechanicals[i].PYs);
                    int kanglaqiangdu = Convert.ToInt32(productMechanicals[i].PRm);
                    int yanshenglv = Convert.ToInt32(productMechanicals[i].PA);
                    string lw = productMechanicals[i].PD;
                    int chongji1 = Convert.ToInt32(productMechanicals[i].PKv1);
                    int chongji2 = Convert.ToInt32(productMechanicals[i].PKv2);
                    int chongji3 = Convert.ToInt32(productMechanicals[i].PKv3);
                    int chongjiAvg = Convert.ToInt32(productMechanicals[i].PKvAvg);

                    g.DrawString(qufuqiangdu.ToString(), font, bru, 210, mechanicalY);
                    g.DrawString(kanglaqiangdu.ToString(), font, bru, 219, mechanicalY);
                    g.DrawString(yanshenglv.ToString(), font, bru, 227, mechanicalY);
                    g.DrawString(lw, font, bru, 233, mechanicalY);
                    g.DrawString(chongji1.ToString(), font, bru, 245, mechanicalY);
                    g.DrawString(chongji2.ToString(), font, bru, 256, mechanicalY);
                    g.DrawString(chongji3.ToString(), font, bru, 268, mechanicalY);
                    g.DrawString(chongjiAvg.ToString(), font, bru, 278, mechanicalY);
                    mechanicalY += 5;
                }
            }

            //Ceq公式信息
            int ceqGSx = 117;
            int ceqGSY = 156;
            string ceqGS = "注：碳当量Ceq(%)=C+Mn/6+Si/24+Ni/40+Cr/5+Mo/4+V/14";
            g.DrawString(ceqGS, font, bru, ceqGSx, ceqGSY);
            //4、试验员信息
            int renyuanX = 10;
            string shiyanyuan = "试验员:白文峰"; int shiyanyuany = 165;
            string shiyanyuanEn = "Test by:Bai Wenfeng"; int shiyanyuanEny = 171;
            g.DrawString(shiyanyuan, font, bru, renyuanX, shiyanyuany);
            g.DrawString(shiyanyuanEn, font, bru, renyuanX, shiyanyuanEny);

            string zlkezhang = "质量科长:"; int zlkezhangy = 180;
            string zlkezhangEn = "Chief of check:How Zhenwei"; int zlkezhangEny = 186;
            g.DrawString(zlkezhang, font, bru, renyuanX, zlkezhangy);
            g.DrawString(zlkezhangEn, font, bru, renyuanX, zlkezhangEny);
            //5、证明材料信息
            int beizhuX = 90;
            string bz1 = "证明此材料系氧气转炉 / 电炉方法制造，经热轧加工，并检验合格，符合"; int bz1y = 164;
            string bz2 = "产品执行标准和技术条件的要求。"; int bz2y = 169;
            string bz3 = "This is to Certifu that steel is made by the oxygen furnace and produced by the heat-roll."; int bz3y = 174;
            string bz4 = "The above-mentioned has been inspected and tested and found to be in compliance with"; int bz4y = 179;
            string bz5 = "the implementation of product standards and specification"; int bz5y = 184;

            g.DrawString(bz1, font, bru, beizhuX, bz1y);
            g.DrawString(bz2, font, bru, beizhuX, bz2y);
            g.DrawString(bz3, font, bru, beizhuX, bz3y);
            g.DrawString(bz4, font, bru, beizhuX, bz4y);
            g.DrawString(bz5, font, bru, beizhuX, bz5y);

            //6、发货员信息
            int fahuoyuanX = 210;
            string fahuoyuan = "发货员：李玉华  张润班"; int fahuoyuany = 158;
            string fahuoyuanEn = "Consignor:Li Yuhua  ZhangRunban"; int fahuoyuanEny = 163;
            g.DrawString(fahuoyuan, font, bru, fahuoyuanX, fahuoyuany);
            g.DrawString(fahuoyuanEn, font, bru, fahuoyuanX, fahuoyuanEny);
            //7、公司地址
            int addressX = 210;
            string addressCn = "公司地址：江苏省宿迁市宿豫区江山大道89号"; int addressCny = 172;
            string addressEn1 = "Address:No.89JiangshanRoad,SuyuDistrict,Suqian"; int addressEn1y = 177;
            string addressEn2 = "Jiangsu province"; int addressEn2y = 182;
            string chaxuntele = "质保书查询热线：+89 527 84453907"; int chaxunteley = 187;
            string chaxunemail = "电子邮箱：hzwfeng@yahoo.com.cn"; int chaxunemaily = 192;
            g.DrawString(addressCn, font, bru, addressX, addressCny);
            g.DrawString(addressEn1, font, bru, addressX, addressEn1y);
            g.DrawString(addressEn2, font, bru, addressX, addressEn2y);
            g.DrawString(chaxuntele, font, bru, addressX, chaxunteley);
            g.DrawString(chaxunemail, font, bru, addressX, chaxunemaily);
        }
        public void ShowZBSBH(string zbsBH)
        {
            txtZBSBH.Text = zbsBH;
        }

    }
}
