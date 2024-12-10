using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Piramids : Triagls
    {
        double Storona1;
        double Storona2;
        double Storona3;
        double height;

        public Piramids(){}
        public Piramids(double str1,double str2,double str3,double hei)
        {
            Storona1 = str1; Storona2 = str2; Storona3 = str3; height = hei;
        }
        
        public override double FindS()
        {
            Triagls.Storona1 = Storona1;
            Triagls.Storona2 = Storona2;
            Triagls.Storona3 = Storona3;
            double S = base.FindS();
            double sPir = 1.0/3.0 * S * height;
            return sPir;
        }
    }
}
