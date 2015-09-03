using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K=");
            int k = int.Parse(Console.ReadLine());

            if (n > 1 && k > 1 && n < 100 && k < 100)
            {
                BigInteger factorialN = 1;
                BigInteger factorialK = 1;
                BigInteger factorialNk = 1;
                BigInteger result = 0;

                for (int i = 1; i <= n; i++)
                {
                    factorialN *= i;
                }
                for (int j = 1; j <= k; j++)
                {
                    factorialNk *= j;
                }
                for (int z = 1; z <= n - k; z++)
                {
                    factorialNk *= z;
                }
                result = factorialN / (factorialK * factorialNk);
                Console.WriteLine(result);
            }
        }
    }
}