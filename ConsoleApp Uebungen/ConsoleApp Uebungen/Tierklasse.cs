using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uebungen
{
    public abstract class Tierklasse
    {
        public string Name { get; set; }
        public string Tierart { get; set; }
        public double Alter { get; set; }
        public double Groesse { get; set; }
        public double Lebensdauer { get; set; }
        public double Gewicht { get; set; }
        public bool Fell { get; set; }
        public bool Hungry { get;  set; }
        public bool Thirsty { get;  set; }
        public bool MakeSomeNoise { get;  set; }



        //public Tierklasse(string name, string tierart, double alter, double groesse, double lebensdauer, double gewicht, bool fell, bool hungry, bool thirsty, bool makesomenoise)
        //{
        //    Name = name;
        //    Tierart = tierart;
        //    Alter = alter;
        //    Groesse = groesse;
        //    Lebensdauer = lebensdauer;
        //    Gewicht = gewicht;
        //    Fell = fell;
        //    Hungry = hungry;
        //    Thirsty = thirsty;
        //    MakeSomeNoise = makesomenoise;
        //}

        public void GiveDescription()
        {
            Console.WriteLine($"I am {Name}, I am a {GetType().Name}, I am {Alter} years old, {Groesse} cm tall, expected to live {Lebensdauer} years and my weight is {Gewicht} Kg.");
        }


        public void Essen()
        {
            if (Hungry == true)
            {
                Console.WriteLine("I am hungry!");

            }
            else
            {
                Hungry = true;
                Console.WriteLine("I am not hungry, I had breakfast.");
            }
        }

        public void Trinken()
        {
            if (Thirsty == true)
            {
                Console.WriteLine("I am thirsty!");

            }
            else
            {
                Thirsty = true;
                Console.WriteLine("I am not thirsty, I just had a Coke.");
            }
        }

        public void Sounds()
        {
            if (MakeSomeNoise == true)
            {
                Console.WriteLine("Wroooor Miau Ham");

            }
            else
            {
                MakeSomeNoise = true;
                Console.WriteLine("*dead silent*");
            }
        }

    }
}
