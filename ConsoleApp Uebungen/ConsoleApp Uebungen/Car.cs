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
        public int Ccm { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public string Color { get; set; }

        public Car(int typeId, int tyres, int ccm, string make, string model, string typeName, string color)
        {
            TypeId = typeId;
            Tyres = tyres;
            Ccm = ccm;
            Make = make;
            Model = model;
            TypeName = typeName;
            Color = color;
        }   
        public Car() 
        { }

        public void PrinCarInformation()
        {
            Console.WriteLine($"My car is a {Make} {Model}, {TypeName}, engine size {Ccm} cm2, colour {Color}, with {Tyres} tyres.");
        }
        public static Car AskUserForCar()

        {
            Car c = new Car();
            Console.Write("ID :");
            c.TypeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Make :");
            c.Make = Console.ReadLine();
            Console.Write("Model :");
            c.Model = Console.ReadLine();
            Console.Write("Type :");
            c.TypeName = Console.ReadLine();
            Console.Write("Color :");
            c.Color = Console.ReadLine();
            Console.Write("CCM :");
            c.Ccm = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wheels :");
            c.Tyres = Convert.ToInt32(Console.ReadLine());
            return c;
        }
    }
}
