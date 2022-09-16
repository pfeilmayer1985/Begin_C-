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


            // Aufgabe 2, Seite 5:

            List<int> myIntergerList = new List<int>();
            myIntergerList.Add(5);
            myIntergerList.Add(3);
            myIntergerList.Add(7);

            for (int i = 0; i < myIntergerList.Count; i++)
            {
                Console.WriteLine(myIntergerList[i]);

            }
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

