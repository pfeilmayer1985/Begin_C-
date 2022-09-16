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


            // [   |   |   |   |   ]
            int[] zahlen = new int[5];

            // [ 26 | 8 | 12 | 3 | 6 ]
            int[] zahlen2 = new int[] { 26, 8, 12, 3, 6 };

            //fill the first "zahlen" Array
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write("A number for the Array :");
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            //output the content from "zahlen" Array

            Console.WriteLine("Your Array :");

            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write($"{zahlen[i]} |");
            }
            Console.ReadLine();

            /*
             Random r = new Random();

             int random_zahl = r.Next(0, 10);

             Console.WriteLine("Try your luck :");
             int luckyGuess = Convert.ToInt32(Console.ReadLine());
             bool state = false;

             do
             {
                 if (luckyGuess == random_zahl)
                 {
                     Console.WriteLine("You WIN !");
                     Console.ReadKey();
                     state = true;
                 }
                 else if (luckyGuess < random_zahl)
                 {
                     Console.WriteLine("You need a bigger number !");
                     Console.WriteLine("Try your luck again :");
                     luckyGuess = Convert.ToInt32(Console.ReadLine());
                 }
                 else
                 {
                     Console.WriteLine("You need a smaller number !");
                     Console.WriteLine("Try your luck again :");
                     luckyGuess = Convert.ToInt32(Console.ReadLine());
                 }

             } while (state == false);
            */
        }

    }
}

