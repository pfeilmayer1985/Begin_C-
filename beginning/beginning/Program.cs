﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie heißt du?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello World! I am {userName}");
            Console.ReadLine();
        }
    }
}
