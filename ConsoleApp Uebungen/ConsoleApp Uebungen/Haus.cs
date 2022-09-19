using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uebungen
{
    internal class Haus
    {

        //these are properties / eigenschaften
        public double Laenge { get; set; }
        public double Breite { get; set; }
        public double Hoehe { get; set; }
        public string Dachart { get; set; }
        public string Putzfarbe { get; set; }
        public int AnzahlEtagen { get; set; }
        public int Preis { get; set; }
        public double Grundstuecklaenge { get; set; }
        public double Grundstueckbreite { get; set; }

        //constructor
        public Haus(double laenge, double breite, double hoehe, string dachart, string putzfarbe, int anzahletagen, int preis, double grundstucklenge, double grundstuckbreite)
        {
            Laenge = laenge;
            Breite = breite;
            Hoehe = hoehe;
            Dachart = dachart;
            Putzfarbe = putzfarbe;
            AnzahlEtagen = anzahletagen;
            Preis = preis;
            Grundstuecklaenge = grundstucklenge;
            Grundstueckbreite = grundstuckbreite;
        }


        // constructor gol
        private Haus() { }

        //metoda, adauga casa noua
        public static Haus AddNewHouse()
        {
            Haus newHouse = new Haus();
            Console.Write("Laenge : ");
            newHouse.Laenge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breite : ");
            newHouse.Breite = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hoehe : ");
            newHouse.Hoehe = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dachart : ");
            newHouse.Dachart = Console.ReadLine();
            Console.Write("Putzfarbe : ");
            newHouse.Putzfarbe = Console.ReadLine();
            Console.Write("Anzahl Etagen : ");
            newHouse.AnzahlEtagen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Preis : ");
            newHouse.Preis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grundstuecklaenge : ");
            newHouse.Grundstuecklaenge = Convert.ToDouble(Console.ReadLine());
            Console.Write("Grundstueckbreite : ");
            newHouse.Grundstueckbreite = Convert.ToDouble(Console.ReadLine());

            return newHouse;
        }

        //metoda, afiseaza suprafata casei, o calculeaza si o afiseaza
        public void PrintQM()
        {
            Console.WriteLine($"Your property has qm = {Grundstuecklaenge} * {Grundstueckbreite} = {Grundstuecklaenge * Grundstueckbreite} m2");
        }

        //metoda, afiseaza proprietatile casei ce au fost definite de utilizator si de constructorul de mai sus
        public void PrintHouseInformation()
        {
            Console.WriteLine($"Your house has Laenge = {Laenge} ; Breite =  {Breite} ; Dachart = {Dachart} ; Putzfarbe = {Putzfarbe} ; " +
                $"Anzahl Etagen = {AnzahlEtagen} ; Preis = {Preis} ; Grundstuecklaenge = {Grundstuecklaenge} ; Grundstueckbreite = {Grundstueckbreite}.");
        }

        //metoda calculeaza si afiseaza suprafata disponibila a casei cu toate etajele
        public void HausWohnFlaeche()
        {
            Console.WriteLine($"HausWohnFlaeche ist = {Laenge} * {Breite} * {AnzahlEtagen} = {Laenge * Breite * AnzahlEtagen}");
        }

        //metoda ce inlocuieste culoarea casei dupa un input de-al utilizatorului
        public void ChangeColor(string neueFarbe)
        {

            this.Putzfarbe = neueFarbe;

        }



    }
}
