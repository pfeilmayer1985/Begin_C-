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
            Console.WriteLine("Wie gross bist du (in m) ?");
            //double height = Convert.ToDouble(Console.ReadLine());
            //decimal height = Convert.ToDecimal(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            int multiplicator = 3;
            Console.WriteLine($"Du bist {height*multiplicator}m groß.");
            Console.ReadLine();
        }
    }
}
