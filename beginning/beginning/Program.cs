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
            Console.WriteLine("Gib mir ein Wort!");
            string entry = Console.ReadLine();

            string replacedEntry = entry.Replace("U", "G").Replace("u", "g");

            Console.WriteLine($"Der alte Text is : {entry}");
            Console.WriteLine($"Der neue Text is : {replacedEntry}");
            

            Console.ReadLine();

        }
    }
}
