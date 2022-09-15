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
            Console.WriteLine("Talk to me!");
            string entry = Console.ReadLine();

            string substring_entry = entry.Substring(3, 5);
            Console.WriteLine($"Old entry : {entry}; new entry : {substring_entry}");

            Console.ReadLine();

        }
    }
}
