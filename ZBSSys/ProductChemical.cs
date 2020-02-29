using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2020-2-29,修改：设置化学成分值的时候，加上一个0.000000001的数字，实现取整后的四舍五入
 * 
 */
namespace ZBSSys
{
    public class ProductChemical
    {
        //id, pHotNumber, pRollNumber, pGradeName, pC, pSi, pMn, pP, pS, pNb, pV, pTi, pCr, pNi, pCu, pAlt, pMo, pN, pCeq
        public string PHotNumber { get; set; }
        public string PRollNumber { get; set; }
        public string PGradeName { get; set; }
       
        private double pC;
        private double pSi;
        private double pMn;
        private double pP;
        private double pS;
        private double pNb;
        private double pV;
        private double pTi;
        private double pCr;
        private double pNi;
        private double pCu;
        private double pAlt;
        private double pMo;
        private double pN;
        private double pCeq;

        public double PC { get => pC; set => pC = value + 0.000000001; }
        public double PSi { get => pSi; set => pSi = value + 0.000000001; }
        public double PMn { get => pMn; set => pMn = value + 0.000000001; }
        public double PP { get => pP; set => pP = value + 0.000000001; }
        public double PS { get => pS; set => pS = value + 0.000000001; }
        public double PNb { get => pNb; set => pNb = value + 0.000000001; }
        public double PV { get => pV; set => pV = value + 0.000000001; }
        public double PTi { get => pTi; set => pTi = value + 0.000000001; }
        public double PCr { get => pCr; set => pCr = value + 0.000000001; }
        public double PNi { get => pNi; set => pNi = value + 0.000000001; }
        public double PCu { get => pCu; set => pCu = value + 0.000000001; }
        public double PAlt { get => pAlt; set => pAlt = value + 0.000000001; }
        public double PMo { get => pMo; set => pMo = value + 0.000000001; }
        public double PN { get => pN; set => pN = value + 0.000000001; }
        public double PCeq { get => pCeq; set => pCeq = value + 0.000000001; }

    }
}
