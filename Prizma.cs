using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Prizma : Triagls
    {
        private double Storona1;
        private double Storona2;
        private double Storona3;
        private double heightPrizm;
        public Prizma() { }
        public Prizma(double storona1, double storona2, double storona3, double heightPrizm)
        {
            Storona1 = storona1;
            Storona2 = storona2;
            Storona3 = storona3;
            this.heightPrizm = heightPrizm;
        }
        public override double FindS()
        {
            Triagls.Storona1 = Storona1;
            Triagls.Storona2 = Storona2;
            Triagls.Storona3 = Storona3;
            double S = base.FindS();
            double sPrizm = S * heightPrizm;
            return sPrizm;
        }
    }
}
