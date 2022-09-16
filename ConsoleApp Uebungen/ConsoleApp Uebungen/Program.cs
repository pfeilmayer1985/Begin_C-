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
            //METHODE - static void main - ist eine methode


            Console.WriteLine("We are using addition and multiplication from the new methodes.");

            int zahl1 = 125;
            int zahl2 = 25;

            Console.WriteLine($"Addition : {Add(zahl1, zahl2)}, Substraction : {SubstractN(zahl1, zahl2)}, Multiplication : {MultiplyM(zahl1, zahl2)}, Division : {DivideN(zahl1, zahl2)}.");
            Console.ReadLine();


            /*
             * List<string> names = ListNames();

             foreach (var name in names)
             {
                 Console.WriteLine(name);
             }
            */


        }

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

