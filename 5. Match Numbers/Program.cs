﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.Write("{0} ", m.Value);
            }
            Console.WriteLine();
        }
    }
}
