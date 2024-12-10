using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Triagls
    {
        public static double Storona1;
        public static double Storona2;
        public static double Storona3;
        public Triagls() { }
        public Triagls(double str1, double str2, double str3)
        {
            Storona1 = str1;
            Storona2 = str2;
            Storona3 = str3;
        }
        public void Proverka()
        {
            if (Storona1 + Storona2 > Storona3 && Storona2 + Storona3 > Storona1 && Storona1 + Storona3 > Storona2)
            {
                Console.WriteLine("Треугольник существует");
            }
            else 
            {
                Console.WriteLine("Треугольник не существует");
            }
        }
        public virtual double FindS()
        {
            double p = (Storona1 + Storona2 + Storona3) / 2;
            double S = Math.Sqrt(p * ((p - Storona1) * (p - Storona2) * (p - Storona3)));

            return S;
        }
    }
}
