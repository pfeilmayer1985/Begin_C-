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
        public Hund(string name, string tierart, double alter, double groesse, double lebensdauer, double gewicht, bool fell, bool hungry, bool tirsty, bool makesomenoise)
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

        

    }
}
