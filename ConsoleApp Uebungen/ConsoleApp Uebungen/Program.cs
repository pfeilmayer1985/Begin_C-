using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uebungen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Your first decimal number : ");
            double numA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your second decimal number : ");
            double numB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"First number is {numA}, second number is {numB}. Sum : {numA + numB}");
            Console.ReadLine();





        }
    }
}
