using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string entry = "Das is ein Text mit Woertern";
            //0: Das
            //1: ist
            //2: ein
            //3: Text
            string[] entries = entry.Split(' ');

            foreach(string wort in entries)
            {
                Console.WriteLine(wort);
            }

            Console.WriteLine("");

            for(int i = 0; i< entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
            }

            /*
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

             int i = 1;
             while (i <= 10)
             {
                 Console.WriteLine(i);
                 i++;
             }

             for(int i= 0; i<10; i++)
              {
              Console.WriteLine(i);
              }
              */

            Console.ReadLine();

        }
    }
}
