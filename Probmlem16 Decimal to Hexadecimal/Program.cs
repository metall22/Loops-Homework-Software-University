﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Probmlem16_Decimal_to_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your decimal number: ");
            long dec = long.Parse(Console.ReadLine());

            string hexaStr = dec.ToString("X");

            long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

            Console.WriteLine(hexaStr);
        }
    }
}