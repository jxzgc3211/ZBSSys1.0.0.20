using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBSSys
{
   public class ProductMechanicalStandard
    {
        //id, pStandard, pGrade, tType, pYsName, pYsMin, pYsMax, pRmMin, pRmMax, pAMin, pAMax, pD, pKvAvgMin, pKvAvgMax, pT
        public string PStandard { get; set; }
        public string PGrade { get; set; }
        public string TType { get; set; }
        public string PYsName { get; set; }
        public int PYsMin { get; set; }
        public int PYsMax { get; set; }
        public int PRmMin { get; set; }
        public int PRmMax { get; set; }
        public int PAMin { get; set; }
        public int PAMax { get; set; }
        public string PD { get; set; }
        public int PKvAvgMin { get; set; }
        public int PKvAvgMax { get; set; }
        public string PT { get; set; }
    }
}
