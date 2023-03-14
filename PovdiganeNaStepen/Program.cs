using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovdiganeNaStepen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPowers(n, pow));
        }
        static double RaiseToPowers(double n, int pow)
        {
            return Math.Pow(n, pow);
        }
    }
}

