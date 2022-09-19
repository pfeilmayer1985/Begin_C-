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

            Car c1 = new Car();
            c1.TypeId = 13494;
            c1.Make = "Ford";
            c1.Model = "Mondeo";
            c1.TypeName = "2.0 TDcI Titanium X";
            c1.ccm = 1998;
            c1.Color = "Black";
            c1.Tyres = 4;


            //c1.PrinCarInformation();

            Car c2 = new Car();
            c2.TypeId = 149557;
            c2.Make = "Dacia";
            c2.Model = "Duster";
            c2.TypeName = "1.5 DcI 4x4";
            c2.ccm = 1497;
            c2.Color = "Black";
            c2.Tyres = 4;

            //c2.PrinCarInformation();

            List<Car> carsList = new List<Car>() { c1, c2 };
            foreach (Car car in carsList)
            {
                car.PrinCarInformation();
            }

            Console.ReadLine();


        }



    }
}

