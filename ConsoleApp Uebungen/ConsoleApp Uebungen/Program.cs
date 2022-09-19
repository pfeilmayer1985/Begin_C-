using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_Uebungen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Tierklasse> tierklasses = new List<Tierklasse>();
            tierklasses.Add(new Hund("Maya", "Dog", 1.5, 65, 14, 50, true, true, false, "Woof Woof"));
            tierklasses.Add(new Katze("Mr Miau", "Cat", 2, 23, 10, 11, true, false, false, "Miiau Miau"));
            
            //Console.WriteLine("Want to add a dog or a cat ? y/n")

            tierklasses.Add(Katze.AskUserForaCat());
            tierklasses.Add(Hund.AskUserForaDog());

            foreach (Tierklasse tier in tierklasses)
            {
                tier.GiveDescription();
                tier.Essen();
                tier.Trinken();

            }



            Console.ReadLine();

            /*
            Dreieck dreieckD = new Dreieck(2, 4, 10);

            dreieckD.Seite1 = 2;
            dreieckD.Seite2 = 4;
            dreieckD.Seite3 = 10;

            float dreiecksFlaeche = dreieckD.Flaeche();
            float dreiecksUmfang = dreieckD.Umfang();

            //  Console.WriteLine($"Mein {dreieckD.GetType().Name} hat eine Flaeche von {dreiecksFlaeche} und Umfang von {dreiecksUmfang}");

            Circle circleC = new Circle(5);
            //circleC.Radius = 5;
            float kreisFlaeche = circleC.Flaeche();
            float kreisUmfang = circleC.Umfang();

            //  Console.WriteLine($"Mein {circleC.GetType().Name} hat eine Flaeche von {kreisFlaeche} und Umfang von {kreisUmfang}");

            Rechteck rechteckRe = new Rechteck(10, 20);
            //rechteckRe.Seite1 = 10;
            //rechteckRe.Seite2 = 20;

            float rechtecksFlaeche = rechteckRe.Flaeche();
            float rechtecksUmfang = rechteckRe.Umfang();

            //  Console.WriteLine($"Mein {rechteckRe.GetType().Name} hat eine Flaeche von {rechtecksFlaeche} und Umfang von {rechtecksUmfang}");

            List<IGeometry> geometries = new List<IGeometry>();
            geometries.Add(dreieckD);
            geometries.Add(circleC);
            geometries.Add(rechteckRe);

            foreach (IGeometry g in geometries)
            {
                Console.WriteLine($"Mein {g.GetType().Name} hat eine Flaeche von {g.Flaeche()} und Umfang von {g.Umfang()}");

            }

            */

            /* 
             List<Vehicle> fahrzeuge = new List<Vehicle>();
            fahrzeuge.Add(new Motorcycle("BMW", "GSXR 650", "650", "Blue", 2, 649, 321354350));
            fahrzeuge.Add(new Car("Ford", "Focus", "Mk3 1.5 TDcI", "Silver", 4, 1497, 321354351));

            foreach (Vehicle v in fahrzeuge)
            {
                v.Starten();
                v.Beschleunigen();
                v.Beschleunigen();
                v.Bremsen();
                v.Starten();
                v.Bremsen();
                v.Bremsen();
            }
            */






            /*

            Console.WriteLine("Make a new house !");
            
            List<Haus> buildNewHouse = new List<Haus>();

            buildNewHouse.Add(Haus.AddNewHouse());
            Console.WriteLine();
            buildNewHouse[0].PrintQM();
            Console.WriteLine();
            buildNewHouse[0].HausWohnFlaeche();
            Console.WriteLine();
            buildNewHouse[0].PrintHouseInformation();
            Console.WriteLine();
            Console.WriteLine("Change the color of your house. Set the new color:");
            buildNewHouse[0].ChangeColor(Console.ReadLine());
            Console.WriteLine();
            buildNewHouse[0].PrintHouseInformation();

            



            Console.ReadLine();

            */

            // Car c1 = new Car(13494, 4, 1998, "Ford", "Mondeo", "2.0 TDcI Titanium X", "Black");


            /*
                        Car c1 = new Car();
                        c1.TypeId = 13494;
                        c1.Make = "Ford";
                        c1.Model = "Mondeo";
                        c1.TypeName = "2.0 TDcI Titanium X";
                        c1.Ccm = 1998;
                        c1.Color = "Black";
                        c1.Tyres = 4;
            */

            //c1.PrinCarInformation();

            /*
            Car c2 = new Car(149557, 4, 1497, "Dacia", "Duster", "1.5 DcI 4x4", "Black");


            List<Car> carsList = new List<Car>();
            carsList.Add(c1);
            carsList.Add(c2);

            Console.Write("How many cars do you want to save ?");
            int numOfCars = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < numOfCars; i++)
            {
                carsList.Add(Car.AskUserForCar());
            }

            Console.Clear();

            foreach (Car car in carsList)
            {
                car.PrinCarInformation();
            }
            
            */



        }



    }
}

