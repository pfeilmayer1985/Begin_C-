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

            bool retry = false;

            do
            {
                Console.Write("Your first number is : ");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Your second number is : ");
                int numTwo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Your operator is : ");
                string yourOperator = Console.ReadLine();

                switch (yourOperator)
                {
                    case "+":
                        Console.WriteLine($"Your result is (+) : {numOne + numTwo}");
                        break;
                    case "-":
                        Console.WriteLine($"Your result is (-) : {numOne - numTwo}");
                        break;
                    case "*":
                        Console.WriteLine($"Your result is (*) : {numOne * numTwo}");
                        break;
                    case "/":
                        Console.WriteLine($"Your result is (/) : {numOne / numTwo}");
                        break;
                    case "%":
                        Console.WriteLine($"Your result is (%): {numOne % numTwo}");
                        break;
                    default:
                        Console.WriteLine("Unknown Operator!");
                        break;

                }
                Console.Write("Retry (y/n) : ");
                string retryOp = Console.ReadLine();

                if (retryOp == "y")
                {
                    retry = true;
                }
                else if (retryOp == "n")
                {
                    retry = false;
                }
                else
                {
                    Console.Write("Just go home, mate, you're drunk. Again !");
                    retry = false;
                }

            } while (retry == true);

            Console.ReadLine();


            /*
            
            string zahl = Console.ReadLine();
            //int zahl = Convert.ToInt32(Console.ReadLine());

            switch (zahl)
            {
                case "1":
                    //case 1:
                    Console.WriteLine("Die Zahl is 1");
                    break;
                case "2":
                    //case 2:
                    Console.WriteLine("Die Zahl is 2");
                    break;
                case "3":
                    //case 3:
                    Console.WriteLine("Die Zahl is 3");
                    break;
                default:
                    Console.WriteLine("Kein Fall tritt ein!");
                    break;
            }

            Console.ReadLine();

            */


            /*


            //For-Schleife: Aufgabe 5

            //count from 0 to 101
            for (int i = 1; i < 101; i++)
            {
                //check if modulo - division rest - is 0 when dividing through 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"FizzBuzz");
                }
                //check if modulo is 0 when dividing through 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"Fizz");
                }
                
                //check if modulo is 0 when dividing through 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"Buzz");
                }

                //if modulo is NOT 0 then the number is displayed instead of text
                else
                {
                    Console.WriteLine($"{i}");
                }

            }

            Console.ReadLine();


            */

            /*
            
            string[] namen = new string[13];
            string[] namen2 = new string[] {"Lukas", "Jonas", "Mona", "Marie",
                                            "Philipp", "Jan", "Erwin", "Leon",
                                            "Marcello", "Johannes", "Robin",
                                            "Andreas", "Robert"};

            for (int i = 0; i < namen2.Length; i++)
            {

                namen2[i] += " 222 ";
            }


            foreach (string trainee in namen2)
            {
                Console.WriteLine(trainee);
            }

            Console.ReadLine();

            */

            /*

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

            */

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

