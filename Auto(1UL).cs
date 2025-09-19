using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_c_
{
    public class Auto : Sõiduk
    {
        public Auto() : base() { }

        public Auto(string nimi) : base(nimi) { }
        public override void Sõida()
        {
            Console.WriteLine($"{Nimi} sõidab autoga.");
        }
    }
}
