using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzchertavaneNaZapulnenKvadrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintHeader(number);
            PrintMiddle(number);
            PrintMiddle(number); 
            PrintFooter(number);
        }

        static void PrintFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddle(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}

