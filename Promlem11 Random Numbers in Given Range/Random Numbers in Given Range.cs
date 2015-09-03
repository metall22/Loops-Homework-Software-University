using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promlem11_Random_Numbers_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Min=");
            int min=int.Parse(Console.ReadLine());
            Console.Write("Max");
            int max=int.Parse(Console.ReadLine());

            if(min>max)
            {
                Console.WriteLine("Invalie input");
                return;
            }
             Random random=new Random();
            for (int i = 0; i < n; i++)
			{
			 int randomNumber=random.Next(min,max+1 );
                Console.WriteLine(randomNumber);
			}
            
		  Console.WriteLine();
	

        }
    }
}

