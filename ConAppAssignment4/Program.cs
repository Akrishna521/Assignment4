﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                double number = double.Parse(input);
                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("The number is even.");
                    }
                    else
                    {
                        Console.WriteLine("The number is odd.");
                    }
                }
                else if (number < 0)
                {
                    Console.WriteLine("The number is negative.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }
        }
    }
}

  

