using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBSSys
{
    public class ZBSProductDeliveryInfo
    {
        //id, constractNumber, customerName, deliveryDate, carNumber, pType, pStandard, pRollNumber, pName, pGrade, tType, pLength, pBundle, pNumber, pWeight, bhYear, bhMonth, bhSerial
        public string ConstractNumber { get; set; }
        public string CustomerName { get; set; }
        public string DeliveryDate { get; set; }
        public string CarNumber { get; set; }
        public string PType { get; set; }
        public string PStandard { get; set; }
        public string PGrade { get; set; }
        public string PName { get; set; }
        public string TTYye { get; set; }
        public string PHotNumber { get; set; }
        public string PRollNumber { get; set; }
        public int PLength { get; set; }
        public int PBundle { get; set; }
        public int PNumber { get; set; }
        public double PWeight { get; set; }
        public int BHYear { get; set; }
        public int BHMonth { get; set; }
        public int BHSerial { get; set; }
    }
}
