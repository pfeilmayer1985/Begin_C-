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

            Console.WriteLine("Your text : ");
            string myInput = Console.ReadLine();

            string adThirtyY = myInput.PadRight(30, 'y');
            Console.WriteLine(adThirtyY);   

            /* 
             string[] myInputArray = myInput.Split();
            
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(myInputArray[i].Replace('y');
            }
            */
            Console.ReadLine();





        }
    }
}
