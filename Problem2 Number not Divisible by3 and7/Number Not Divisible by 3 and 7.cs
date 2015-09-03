using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Number_not_Divisible_by3_and7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer number:");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(" "+i + "");
                }
            }
            Console.WriteLine();

        }

    }
}