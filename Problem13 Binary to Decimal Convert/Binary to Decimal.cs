using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13_Binary_to_Decimal_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.Write("Enter Number in Binary Format:");
            //    string binaryInput = Console.ReadLine();

            //    for (int i = 1; i < binaryInput.Length; i++)
            //    {


            //    }
            //    Console.WriteLine(Convert.ToInt32(binaryInput, 2));
            //}
            Console.Write("Enter Number in binary format: ");
            string binaryInput = Console.ReadLine();

            long dec = 0;

            for (int i = 0; i < binaryInput.Length; i++)
            {
                if (binaryInput[binaryInput.Length - i - 1] == '0')
                {
                    continue;
                }

                dec += (long)Math.Pow(2, i);
            }

            Console.WriteLine(dec);
        }
    }
}
