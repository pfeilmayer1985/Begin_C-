using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uebungen
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public string Color { get; set; }
        public int Tyres { get; set; }
        public int Ccm { get; set; }
        public int TypeId { get; set; }
        public bool MotorLauft { get; private set; }
        //public bool Bremsen { get; set; }
        public int Geschwindigkeit { get; private set; }

        public void Starten()
        {
            if (MotorLauft == true)
            {
                Console.WriteLine("Motor lauft schon, kann ihn nicht starten!");

            }
            else
            {
                MotorLauft = true;
                Console.WriteLine("Motor wird gestartet!... WRRRRRUUMMMMMMM");
            }


        }

        public void Beschleunigen()
        {
            Geschwindigkeit += 10;
        }

        public void Bremsen()
        {
            if (Geschwindigkeit <= 0)
            {
                Console.WriteLine($"{this.GetType().Name} steht bereits!");
            }
            else
            {
                Geschwindigkeit -= 10;
                Console.WriteLine($"{this.GetType().Name} wird gebremst!");
            }
        }


    }


}
