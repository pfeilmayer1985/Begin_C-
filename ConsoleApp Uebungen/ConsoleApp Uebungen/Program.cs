using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_Uebungen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int kapital = 10000;
            int anzahlDesSpiels = 0;
            int geworfeneZahl = 0;
            int kapitalDavor = 0;
            int kapitalDanach = 0;
            int myBet = 10;
            int gewinn = 0;
            int verluss = 10;
            bool winGame = false;

            Random myRandomNumber = new Random();

            while (kapital > 0)
            {
                //Console.Clear();
                Console.WriteLine($"Welcome to Vegas. You have {kapital}$ in your pocket.");
                Console.WriteLine("You are determined to lose your money by playing Roulette.");
                Console.WriteLine("");
                Console.WriteLine($"You bet {myBet}$ on PAIR numbers.");
                Console.WriteLine("");

                kapital = kapital - myBet;
                geworfeneZahl = myRandomNumber.Next(0, 37);
                anzahlDesSpiels++;
                Console.WriteLine($"Actual number of games played : {anzahlDesSpiels}.");
                Console.WriteLine($"The winning number is : {geworfeneZahl}.");
                Console.WriteLine("");

                if (geworfeneZahl % 2 == 0 && geworfeneZahl != 0)
                {
                    gewinn = myBet * 2;
                    kapital = kapital + gewinn;
                    winGame = true;
                    Console.WriteLine($"You just won {gewinn}$, and your new credit is {kapital}$.");
                }
                else if (geworfeneZahl == 0)
                {
                    Console.WriteLine($"Try again. Your new credit is {kapital}$.");
                    
                }
                else
                {
                    winGame = false;
                    Console.WriteLine($"You just lost {myBet}$, and your new credit is {kapital}$. Your wife will be proud !");
                }

                if (kapital > 10000 && winGame == true)
                {
                    myBet = 10;
                }
                else if (kapital > 10000 && winGame == false)
                {
                    myBet = myBet * 2;
                }
                else if (kapital < 10000 )
                {
                    int gesamtVerlust = 10000 - kapital;
                    myBet = gesamtVerlust * 2;
                }
                
                if (kapital < myBet)
                {
                    myBet = kapital;
                }
                if (myBet > 1000)
                {
                    myBet = 1000;
                }

                Console.ReadLine();

            }

            Console.ReadLine();


        }

    

    }
}

