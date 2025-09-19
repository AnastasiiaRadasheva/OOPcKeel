using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace OOP_c_
{
    public class Töötaja : Inimene
    {
        public string Ametikoht = "Keevitaja";

        public double Tuunitasu = 15.50;
        public int Tuunid {  get; set; }


        public void Töötan()
        {
            Console.WriteLine($"{Nimi} töötab ametikohal {Ametikoht}.");
        }
        public override void Mida_teeb()
        {

            Console.WriteLine();
        }
        public double ArvutaPalk()
        {
            return Tuunitasu * Tuunid;
        }
    }
}
