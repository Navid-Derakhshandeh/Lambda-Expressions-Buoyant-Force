using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions_Buoyant_Force
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Volume : ");
            double V = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Density : ");
            double D = Double.Parse(Console.ReadLine());
            double G = 9.81;
            Func<double, double, double, double> F = (double D, double V, double G) => ((D * Math.Pow(10, -3)) * V * G);
            Console.WriteLine("Buoyant-Force equal by : {0} N", F(D, V, G));
        }
    }
}
