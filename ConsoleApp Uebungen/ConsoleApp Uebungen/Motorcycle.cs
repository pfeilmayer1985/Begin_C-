using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uebungen
{
    public class Motorcycle : Vehicle
    {

        public Motorcycle(string make, string model, string typeName, string color, int tyres, int ccm, int typeId)
        {
            Make = make;
            Model = model;
            TypeName = typeName;
            Color = color;
            Tyres = tyres;
            Ccm = ccm;
            TypeId = typeId;

        }


    }
}
