﻿using System;

namespace detyra7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to decimal is {1}.",
                hexa, Convert.ToInt32(hexa, 16));
        }
    }
}