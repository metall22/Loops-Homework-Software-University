﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9_Matrix_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            if (n > 1 && n < 20)
            {
                for (int i = 0; i < n; i++)
                {

                    for (int j = i + 1; j <= n + i; j++)
                    {
                        Console.Write(j+ " ");

                    }
                    Console.WriteLine();
                }}
                else
                {
                    Console.WriteLine("Error");
                }
                
            }
        }
    }

