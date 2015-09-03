using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12_Randomise_the_NUmbers_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());

            Random randomN = new Random();

            for (int i = 1; i <= n; i++)
            {
                int randomNumber = randomN.Next(i+1);
                Console.WriteLine(randomNumber);
                
            }
        }
    }
}
