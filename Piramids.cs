using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Piramids : Triagls
    {
        double height;

        public Piramids(){}
        public Piramids(double str1,double str2,double str3,double hei)
        {
            
        }
        
        public override double FindS()
        {
            base.FindS();
            return height;
        }
    }
}
