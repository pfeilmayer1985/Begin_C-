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

            Console.WriteLine($"Welcome to Vegas. You have {kapital}$ in your pocket.");
            Console.WriteLine("You are determined to lose your money by playing Roulette.");
            Console.WriteLine("");
            Console.WriteLine($"You bet {myBet}$ on PAIR numbers.");
            Console.WriteLine("");

            Random myRandomNumber = new Random();
            geworfeneZahl = myRandomNumber.Next(0, 37);
            anzahlDesSpiels++;
            Console.WriteLine($"Actual number of games played : {anzahlDesSpiels}.");
            Console.WriteLine($"The winning number is : {geworfeneZahl}.");
            Console.WriteLine("");

            if (geworfeneZahl % 2 == 0 && geworfeneZahl != 0)
            {
                kapitalDavor = kapital;
                gewinn = myBet * 2;
                kapitalDanach = kapitalDavor + gewinn;
                Console.WriteLine($"You just won {gewinn}$, and your new credit is {kapitalDanach}$.");

            }
            else if (geworfeneZahl == 0)
            {
                kapitalDavor = kapital;
                gewinn = myBet;
                kapitalDanach = kapitalDavor + gewinn;
                Console.WriteLine($"You just won {gewinn}$, and your new credit is {kapitalDanach}$.");
            }
            else
            {
                kapitalDavor = kapital;
                gewinn = myBet;
                kapitalDanach = kapitalDavor - gewinn;
                Console.WriteLine($"You just lost {gewinn}$, and your new credit is {kapitalDanach}$. Your wife will be proud !");
            }

            Console.ReadLine();






            /*

            // Aufgabe 2, Seite 5:

            List<int> myIntergerList = new List<int>() { 5, 3, 7 };

            string myOption = "";

            do
            {
                Console.Write("Enter a number : ");
                myIntergerList.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Clear();
                Console.Write("Enter another number (y/n) ? ");
                myOption = Console.ReadLine();
                Console.Clear();

            } while (myOption == "y");//option == false);

            //5.	Füge an Position 2 die Zahl 99 hinzu und gebe die Liste aus

            myIntergerList.Insert(1, 99);

            //6.	Füge die Zahlen 91, 92, 93 gleichzeitig hinzu und gebe die Liste aus

            myIntergerList.AddRange(new int[] { 91, 92, 93 });

            //7.	Entferne das Element an der 1. Stelle und gebe die Liste aus

            myIntergerList.RemoveAt(0);

            //8.	Entferne die Zahl 99 ohne zu wissen wo sie gerade steht und gebe die Liste aus

            myIntergerList.Remove(99);

            //9.	Lösche das Letzte Element der Liste und gebe die Liste aus

            int myCurrentListRage = myIntergerList.Count;
            myIntergerList.RemoveAt(myCurrentListRage - 1);


            Console.WriteLine("Your original list looks like : ");
            Console.Write(" [");

            for (int i = 0; i < myIntergerList.Count; i++)
            {
                Console.Write($" | {myIntergerList[i]} | ");

            }

            Console.Write("] ");

            //10. Schaue dir die Vorgeschlagenen Methoden von Listen an und probiere einige aus. (z.B. Sort, Reverse, )
            //10. Using SORT

            myIntergerList.Sort();

            Console.WriteLine("");
            Console.WriteLine("Your arranged list looks like : ");
            Console.Write(" [");

            for (int i = 0; i < myIntergerList.Count; i++)
            {
                Console.Write($" | {myIntergerList[i]} | ");

            }

            Console.Write("] ");

            //10. Schaue dir die Vorgeschlagenen Methoden von Listen an und probiere einige aus. (z.B. Sort, Reverse, )
            //10. Using REVERSE

            myIntergerList.Reverse();

            Console.WriteLine("");
            Console.WriteLine("Your reverse-arranged list looks like : ");
            Console.Write(" [");

            for (int i = 0; i < myIntergerList.Count; i++)
            {
                Console.Write($" | {myIntergerList[i]} | ");

            }

            Console.Write("] ");


            //11.Lösche alle Zahlen größer als 80 und gebe die Liste aus

            for (int i = 0; i < myIntergerList.Count; i++)
            {
                if (myIntergerList[i] > 80)
                {
                    myIntergerList.Remove(myIntergerList[i]);
                    i--;
                }

            }

            myIntergerList.Sort();
            Console.WriteLine("");
            Console.WriteLine("All your numbers over 80 are now gone : ");
            Console.Write(" [");

            for (int i = 0; i < myIntergerList.Count; i++)
            {
                Console.Write($" | {myIntergerList[i]} | ");

            }
            Console.Write("] ");

            Console.ReadLine();


            */


            /*
            Console.WriteLine("We are using addition and multiplication from the new methodes.");

            int zahl1 = 121;
            int zahl2 = 5;

            Console.WriteLine($"Addition : {Add(zahl1, zahl2)}, Substraction : {SubstractN(zahl1, zahl2)}, Multiplication : {MultiplyM(zahl1, zahl2)}, Division : {DivideN((double)zahl1, (double)zahl2)}.");
            Console.ReadLine();

            */
            /*
             * List<string> names = ListNames();

             foreach (var name in names)
             {
                 Console.WriteLine(name);
             }
            */


        }

        /*
        static int Add(int z1, int z2)
        {
            int summe = z1 + z2;
            return summe;
        }

        static int SubstractN(int z1, int z2)
        {
            int substraction = z1 - z2;
            return substraction;
        }

        static int MultiplyM(int z1, int z2)
        {
            int multiplication = z1 * z2;
            return multiplication;
        }

        static int DivideN(int z1, int z2)
        {
            int divisionN = z1 / z2;
            return divisionN;
        }

        static double DivideN(double z1, double z2)
        {
            double divisionN = z1 / z2;
            return divisionN;
        }

        */

        //static ruckgabetyp methodenname (parameter)
        /*  
        static List<string> ListNames()

        {
          List<string> name = new List<string>();
            name.Add("ABC");

            //Ruckgabevariable
            return name;


    }
        */

    }
}

