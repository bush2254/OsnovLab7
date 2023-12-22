using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1;
            for (double i = 1; i <= 10; i++)
            {
                double p = 1;
                for (double j = 1; j <=5; j++)
                {
                    p*=(Abs(Sin(i)*Cos(j)))/(i+j);
                }
                S *= p;
            }
            Console.WriteLine(S);
        }
    }
}