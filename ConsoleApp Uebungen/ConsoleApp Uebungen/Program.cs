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

            Console.WriteLine("Your text is :");
            string userText = Console.ReadLine();
            int charLength = userText.Length;
            Console.WriteLine($"Text length: {charLength} characters");

            /* string replacedUserText = userText.Replace('U', 'u').Replace('G', 'g');
             Console.WriteLine($"Replaced text : {replacedUserText}");
            */
            Console.ReadLine(); 


        }
    }
}
