using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uebungen
{
    public class Katze : Tierklasse
    {
        public Katze()
        {
        }

        public Katze(string name, string tierart, double alter, double groesse, double lebensdauer, double gewicht, bool fell, bool hungry, bool tirsty, string makesomenoise)
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

        public static Katze AskUserForaCat()

        {
            Katze inputCatFromUser = new Katze();
            Console.Write("Name :");
            inputCatFromUser.Name = Console.ReadLine();
            Console.WriteLine($"Tierart : {inputCatFromUser.GetType().Name}");
            inputCatFromUser.Tierart = inputCatFromUser.GetType().Name;
            Console.Write("Alter :");
            inputCatFromUser.Alter = Convert.ToDouble(Console.ReadLine());
            Console.Write("Groesse :");
            inputCatFromUser.Groesse = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lebesdauer :");
            inputCatFromUser.Lebensdauer = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gewicht :");
            inputCatFromUser.Gewicht = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fell y/n :");
            string fellread = Console.ReadLine();
            if (fellread == "y")
            {
                inputCatFromUser.Fell = true;
            }
            else 
            {
                inputCatFromUser.Fell = false;
            }

            Console.Write("Hungry y/n :");
            string hungryread = Console.ReadLine();
            if (hungryread == "y")
            {
                inputCatFromUser.Hungry = true;
            }
            else
            {
                inputCatFromUser.Hungry = false;
            }

            Console.Write("Thirsty y/n :");
            string thirstyread = Console.ReadLine();
            if (thirstyread == "y")
            {
                inputCatFromUser.Thirsty = true;
            }
            else
            {
                inputCatFromUser.Thirsty = false;
            }

            Console.Write("How do I sound like? :");
            inputCatFromUser.MakeSomeNoise = Console.ReadLine();

            return inputCatFromUser;
        }


    }
}
