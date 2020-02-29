using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBSSys
{
    public delegate void FreshForm();
    public delegate void ImportInfo(string info);
    public delegate void ShowStudent(int i);
    public delegate void ChuanObejce1(object o);
    public delegate void ChuanObejce2(ProductStandardInfo psi, ProductChemicalStandard pcs);
}
