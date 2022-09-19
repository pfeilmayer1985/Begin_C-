using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uebungen
{
    public class Car
    {

        public int TypeId { get; set; }
        public int Tyres { get; set; }
        public int ccm { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public string Color { get; set; }

        public void PrinCarInformation()
        {
            Console.WriteLine($"My car is a {Make} {Model}, {TypeName}, engine size {ccm} cm2, colour {Color}, with {Tyres} tyres.");
        }

    }
}
