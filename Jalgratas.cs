using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_c_
{
    public class Jalgratas : Sõiduk
    {
        public Jalgratas() : base() { }

        public Jalgratas(string nimi) : base(nimi) { }

        public override void Sõida()
        {
            Console.WriteLine($"{Nimi} sõidab jalgrattaga.");
        }
    }
}
