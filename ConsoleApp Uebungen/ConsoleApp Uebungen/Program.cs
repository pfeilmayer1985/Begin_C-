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
            Console.WriteLine("Your number : ");
            int myInput = Convert.ToInt32(Console.ReadLine());
            for (int i = myInput; i >= 0; i--)
            {
                Console.WriteLine(i);
            }


            /*
            Console.WriteLine("Your number : ");
            int myInput = Convert.ToInt32(Console.ReadLine());
            int addierung = 0;

            for (int i = 0; i <= myInput; i++)
            {
                Console.WriteLine($"Current number : {i}");
                
                addierung = addierung + i;
                Console.WriteLine($"Sum : {addierung}");
            }
            */

            Console.ReadLine();





        }
    }
}
