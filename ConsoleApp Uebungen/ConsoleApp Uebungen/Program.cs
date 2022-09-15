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
            Console.WriteLine("How many entries do you want for your Array");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[arraySize];
            
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Enter number {i} of {arraySize} into Array :");
                int arrayEntry = Convert.ToInt32(Console.ReadLine());
                myArray[i]=arrayEntry;
            }
            Console.WriteLine();
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }

            int max = myArray.Max();
            int min = myArray.Min();
            double ave = Convert.ToDouble(myArray.Average());

            Console.WriteLine();

            Console.WriteLine($"The biggest number is : {max}");
            Console.WriteLine($"The smallest number is : {min}");
            Console.WriteLine($"The average is : {ave}");

            /*
            string nameArray = "Mona,Marie,Erwin,Marcello,Jonas,Philipp,Andreas,Lukas,Johannes,Leon,Robin,Niklas,Robert,Jan";
            Console.WriteLine($"The Team : {nameArray}");
            string[] mySplittedArray = nameArray.Split(',');
            Console.WriteLine("Letter to search for:");
            string letter = Console.ReadLine(); 


            foreach (string wort in mySplittedArray)
            {
                bool myOutput = wort.Contains(letter);
                if (myOutput.Equals(true))
                {
                    Console.WriteLine(wort);
                }
            }
            */

            /*
            Console.WriteLine("Your number : ");
            int myInput = Convert.ToInt32(Console.ReadLine());
            for (int i = myInput; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Console.WriteLine("Your number : ");
            int myInput = Convert.ToInt32(Console.ReadLine());
            int addierung = 0;

            for (int i = 0; i <= myInput; i++)
            {
                Console.WriteLine($"Current number : {i}");

                addierung = addierung + i;
                Console.WriteLine($"Sum : {addierung}");
            }
            */

            Console.ReadLine();





        }
    }
}
