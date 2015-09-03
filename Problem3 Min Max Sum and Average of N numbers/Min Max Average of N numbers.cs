using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Min_Max_Sum_and_Average_of_N_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer n=");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter numbers for n:");
            int[] numberOfN = new int[n];

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                numberOfN[i] = numbers;
            }
            Console.WriteLine("Min= {0}", numberOfN.Min());
            Console.WriteLine("Max ={0}",numberOfN.Max());
            Console.WriteLine("Sum {0}",numberOfN.Sum());
            Console.WriteLine("Average:{0:F2}", numberOfN.Average());




        }
    }
}

