using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_c_
{
    public abstract class Loom
    {
        public string Nimi { get; set; }

        // Abstraktne meetod
        public abstract void TeeHääl();
        public abstract void Liigu();
        public abstract void TeeMidagi();


        // Tavaline meetod
        public void Söö()
        {
            Console.WriteLine($"{Nimi} sööb.");
        }
    }
}
