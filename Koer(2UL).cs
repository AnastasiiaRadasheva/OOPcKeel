using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_c_
{
    public class Koer : Loom
    {
        public override void TeeHääl()
        {
            Console.WriteLine($"{Nimi} ütleb: Röh!");
        }

        public override void Liigu()
        {
            Console.WriteLine($"{Nimi} tammub poris.");
        }

        public override void TeeMidagi()
        {
            Console.WriteLine($"{Nimi} otsib trühvleid.");
        }
    }
}
