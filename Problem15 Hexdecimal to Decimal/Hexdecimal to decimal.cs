using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Problem15_Hexdecimal_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexdecimal: ");
            string hexa = Console.ReadLine();

            long dec = long.Parse(hexa, NumberStyles.HexNumber);
            Console.WriteLine(dec);
        }
    }
}
