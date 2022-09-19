using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uebungen
{
    public class Car : Vehicle
    {

        //constructor pentru masina care defineste caracteristicile ce sunt necesare pentru "masina"
        //poate fi folosit in aplicatia principala pentru a adauga masina, sterge, etc
        public Car(string make, string model, string typeName, string color, int tyres, int ccm, int typeId)
        {
            Make = make;
            Model = model;
            TypeName = typeName;
            Color = color;
            Tyres = tyres;
            Ccm = ccm;
            TypeId = typeId;

        }

        //metoda pentru a tipari continutul masinilor. poate fi chemata/rulata din aplicatia principala
        public void PrinCarInformation()
        {
            Console.WriteLine($"My car is a {Make} {Model}, {TypeName}, engine size {Ccm} cm2, colour {Color}, with {Tyres} tyres.");
        }

        //constructor gol pentru a-l putea umple cu datele de la utilizator. va fi folosit in metoda AskUserForCar(). poate fi private sau public
        //e private pentru ca e folosita doar in aceasta clasa
        private Car()
        { }

        public static Car AskUserForCar()

        {
            Car inputFromUser = new Car();
            Console.Write("ID :");
            inputFromUser.TypeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Make :");
            inputFromUser.Make = Console.ReadLine();
            Console.Write("Model :");
            inputFromUser.Model = Console.ReadLine();
            Console.Write("Type :");
            inputFromUser.TypeName = Console.ReadLine();
            Console.Write("Color :");
            inputFromUser.Color = Console.ReadLine();
            Console.Write("CCM :");
            inputFromUser.Ccm = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wheels :");
            inputFromUser.Tyres = Convert.ToInt32(Console.ReadLine());
            return inputFromUser;
        }
    }
}
