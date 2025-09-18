using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace OOP_c_
{
    public  abstract class Inimene
    {
        public string Nimi;
        public int Vanus;

        public Inimene()
        {
        }

        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public void Tervita()
        {
            Console.WriteLine("Tere! Mina olen " + Nimi);
        }
        public abstract void Mida_teeb()
        {
            Console.WriteLine();
        }
    }
}
