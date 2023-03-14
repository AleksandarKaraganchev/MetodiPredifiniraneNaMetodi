using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoGolqmaOtDveStoinosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter data type: ");
            string type = Console.ReadLine();
            if (type == "int")
            {
                Console.Write("Enter first number: ");
                int firstn = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int sedcondn = int.Parse(Console.ReadLine());
                int max = GetMax(firstn, sedcondn);
                Console.WriteLine($"The bigger number is {max}");
            }
            else if (type == "char")
            {
                Console.Write("Enter first symbol: ");
                char a = char.Parse(Console.ReadLine());
                Console.Write("Enter second symbol: ");
                char b = char.Parse(Console.ReadLine());
                int max = GetMax(a, b);
                Console.WriteLine($"The bigger symbol is: {(char) max}");
            }
            else if (type == "string")
            {
                Console.Write($"Enter the first string: ");
                string a = Console.ReadLine();
                Console.Write($"Enter the second string: ");
                string b = Console.ReadLine();
                string max = GetMax(a, b);
                Console.WriteLine($"The bigger string is: {max}");
            }
            Console.WriteLine();
        }
        private static int GetMax(int firstn, int secondn)
        {
            int result = 0;
            if (firstn > secondn)
            {
                result = firstn;
                return result;
            }
            else
            {
                result = secondn;
                return result;
            }
        }
            
        
        private static int GetMax(char a, char b)
        {
            int result = 0;
            if ((int)a > (int) b)
            {
                result = a;
                return result;
            }
            else
            {
                result = b;
                return result;
            }
        }
        private static string GetMax(string a, string b)
        {
            string result = "";
            if (a.CompareTo(b) >= 0)
            {
                result = a;
                return result;
            }
            else
            {
                result = b;
                return result;
            }
        }
    }
}
