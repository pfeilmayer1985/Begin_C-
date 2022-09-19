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
            Car c1 = new Car(13494, 4, 1998, "Ford", "Mondeo", "2.0 TDcI Titanium X", "Black");


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

            Car c2 = new Car(149557, 4, 1497, "Dacia", "Duster", "1.5 DcI 4x4", "Black");


            List<Car> carsList = new List<Car>();
            carsList.Add(c1);
            carsList.Add(c2);

            Console.Write("How many mars do you want to save ?");
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

            Console.ReadLine();


        }



    }
}

