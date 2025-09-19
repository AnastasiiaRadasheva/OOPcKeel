using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_c_
{
    public class Kuulik : Loom
    {
        public override void TeeHääl()
        {
            Console.WriteLine($"{Nimi} ütleb: Auh!");
        }

        public override void Liigu()
        {
            Console.WriteLine($"{Nimi} jookseb.");
        }

        public override void TeeMidagi()
        {
            Console.WriteLine($"{Nimi} toob pulga.");
        }
    }
}