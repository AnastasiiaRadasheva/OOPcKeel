using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_c_
{
    public class Õpilane : Inimene
    {
        public string Rühm_klass;
        public string Kool;
        public override void Mida_teeb()
        {
            Console.WriteLine($"{Nimi} õpib koolis.");
        }
    }
}
