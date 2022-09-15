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

            Console.WriteLine("Write me something nice : ");
            string myInput = Console.ReadLine();

            bool myOutput = myInput.Contains("abc");
            Console.WriteLine(myOutput);    

            Console.ReadLine();





        }
    }
}
