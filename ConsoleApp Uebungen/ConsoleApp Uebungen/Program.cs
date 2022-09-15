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





        }


    }
}

