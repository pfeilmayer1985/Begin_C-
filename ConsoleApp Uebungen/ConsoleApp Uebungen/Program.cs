﻿using System;
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
            //For-Schleife: Aufgabe 5


            for (int i = 0; i < 101; i++)
            {


                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine($"Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine($"Buzz");
                }

                else
                {
                    Console.WriteLine($"{i}");
                }


            }


            Console.ReadLine();


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

