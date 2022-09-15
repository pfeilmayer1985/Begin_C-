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

            Console.WriteLine("Your text with many spaces for and after please : ");
            string myInput = Console.ReadLine();

            Console.WriteLine($"Your text initial text is : ={myInput}=");
            string myAlteredInput = myInput.Trim(' ');

            Console.WriteLine($"Your cleaned up text is : ={myAlteredInput}=");

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
