﻿using System;
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


            // Aufgabe 2, Seite 5:

            List<int> myIntergerList = new List<int>() { 5, 3, 7 };
            bool option = false;
            string myOption = "";
            do
            {
                Console.Write("Enter a number : ");
                myIntergerList.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Clear();
                Console.Write("Enter another number (y/n) ? ");
                myOption = Console.ReadLine();
                Console.Clear();

                //if (myOption == "y")
                //{
                //    option = false;
                //}
                //else if (myOption == "n")
                //{
                //    option = true;
                //}
                //else if (myOption == "")
                //{
                //    option = true;
                //}
                //else
                //{
                //    option = true;
                //    Console.Clear();
                //    Console.WriteLine("Go home mate, your are drunk !");
                //}

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
            myIntergerList.RemoveAt(myCurrentListRage-1);

                        
            Console.WriteLine("Your original list looks like : ");
            Console.Write(" [");

            for (int i = 0; i < myIntergerList.Count; i++)
            {
                Console.Write($" | {myIntergerList[i]} | ");

            }

            Console.Write("] ");

            //10.	Schaue dir die Vorgeschlagenen Methoden von Listen an und probiere einige aus. (z.B. Sort, Reverse, )

            myIntergerList.Sort();

            Console.WriteLine("");
            Console.WriteLine("Your arranged list looks like : ");
            Console.Write(" [");

            for (int i = 0; i < myIntergerList.Count; i++)
            {
                Console.Write($" | {myIntergerList[i]} | ");

            }

            Console.Write("] ");

            myIntergerList.Reverse();

            Console.WriteLine("");
            Console.WriteLine("Your reverse-arranged list looks like : ");
            Console.Write(" [");

            for (int i = 0; i < myIntergerList.Count; i++)
            {
                Console.Write($" | {myIntergerList[i]} | ");

            }

            Console.Write("] ");


            Console.ReadLine();


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

