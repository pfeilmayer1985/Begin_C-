using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uebungen
{
    public class Hund : Tierklasse
    {
        public Hund()
        {
        }

        public Hund(string name, string tierart, double alter, double groesse, double lebensdauer, double gewicht, bool fell, bool hungry, bool tirsty, string makesomenoise)
        {
            Name = name;
            Tierart = tierart;
            Alter = alter;
            Groesse = groesse;
            Lebensdauer = lebensdauer;
            Gewicht = gewicht;
            Fell = fell;
            Hungry = hungry;
            Thirsty = tirsty;
            MakeSomeNoise = makesomenoise;
        }

        public static Hund AskUserForaDog()

        {
            Hund inputDogFromUser = new Hund();
            Console.Write("Name :");
            inputDogFromUser.Name = Console.ReadLine();
            Console.WriteLine($"Tierart : {inputDogFromUser.GetType().Name}");
            inputDogFromUser.Tierart = inputDogFromUser.GetType().Name;
            Console.Write("Alter :");
            inputDogFromUser.Alter = Convert.ToDouble(Console.ReadLine());
            Console.Write("Groesse :");
            inputDogFromUser.Groesse = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lebesdauer :");
            inputDogFromUser.Lebensdauer = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gewicht :");
            inputDogFromUser.Gewicht = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fell y/n :");
            string fellread = Console.ReadLine();


            if (fellread == "y")
            {
                inputDogFromUser.Fell = true;
            }
            else
            {
                inputDogFromUser.Fell = false;
            }

            Console.Write("Hungry y/n :");
            string hungryread = Console.ReadLine();
            if (hungryread == "y")
            {
                inputDogFromUser.Hungry = true;
            }
            else
            {
                inputDogFromUser.Hungry = false;
            }

            Console.Write("Thirsty y/n :");
            string thirstyread = Console.ReadLine();
            if (thirstyread == "y")
            {
                inputDogFromUser.Thirsty = true;
            }
            else
            {
                inputDogFromUser.Thirsty = false;
            }

            Console.Write("How do I sound like? :");
            inputDogFromUser.MakeSomeNoise = Console.ReadLine();


            return inputDogFromUser;
        }


    }
}
