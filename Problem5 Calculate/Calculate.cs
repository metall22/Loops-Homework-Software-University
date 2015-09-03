using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_Calculate
{
    class Program
    {       //1+1!/X+2!/X2+...+N!/Xn
        static void Main(string[] args)
        {
            Console.Write("Enter n=");
            double n = int.Parse(Console.ReadLine());
            Console.Write("Enter x=");
            double x = int.Parse(Console.ReadLine());
            double factorial = 1;
            double sum = 1;
            double sumX = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sumX *= x;
                sum = sum + factorial / sumX;
            }
            Console.WriteLine("{0:F5}",sum);
        }
    }
}
