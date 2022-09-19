using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Uebungen
{
    public class Dreieck
    {

        public int Seite1 { get; set; }
        public int Seite2 { get; set; }

        //Hypothenuse
        public int Seite3 { get; set; }

        public float Umfang()
        {
            return Seite1 + Seite2 + Seite3;
        }

        public float Flaeche()
        {

            return 2;

        }
    }
}
