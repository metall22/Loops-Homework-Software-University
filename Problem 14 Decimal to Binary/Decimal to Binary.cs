using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14_Decimal_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your decimal number: ");
        long dec = long.Parse(Console.ReadLine());
 
        long rest;
        string binary = string.Empty;
 
        while (dec > 0)
        {
            rest = dec % 2;
            dec /= 2;
            binary = rest.ToString() + binary;
        }
 
        Console.WriteLine(binary);
                
        }
            }
        }
    

