using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Promblem_6_Nfactorial_Divided_by_K_factorial
{
    class Program
    {   //N!/K!
        static void Main(string[] args)
        {
             Console.Write("Enter N=");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K=");
            int K = int.Parse(Console.ReadLine());
            int factorialK=1;
            int factorialN = 1;
            
            for (int i = 1; i <= N; i++ )
            {
                factorialN *= i;
            }
            for (int i = 1; i <= K; i++)
            {
                factorialK *= i;
                
               
                
            }
          //  Console.WriteLine("{0} {1}",factorialN,factorialK);
            int divisionFactorials = factorialN / factorialK;
            Console.WriteLine(divisionFactorials);
        }
    }
}