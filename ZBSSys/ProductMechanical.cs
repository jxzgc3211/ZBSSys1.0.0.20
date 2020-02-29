using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBSSys
{
   public  class ProductMechanical
    {
        //id, pName, pGrade, pHotNumber, pRollNumber, pYs, pRm, pA, pD, pKv1, pKv2, pKv3, pKvAvg
        public string PName { get; set; }
        public string PGrade { get; set; }
        public string PHotNumber { get; set; }
        public string PRollNumber { get; set; }
        public int PYs { get; set; }
        public int PRm { get; set; }
        public int PA { get; set; }
        public string PD { get; set; }
        public int PKv1 { get; set; }
        public int PKv2 { get; set; }
        public int PKv3 { get; set; }
        public int PKvAvg { get; set; }
    }
}
