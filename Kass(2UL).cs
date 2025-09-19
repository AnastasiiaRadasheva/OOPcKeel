using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_c_
{
    public class Kass : Loom
    {
        public override void TeeHääl()
        {
            Console.WriteLine($"{Nimi} ütleb: Näu!");
        }

        public override void Liigu()
        {
            Console.WriteLine($"{Nimi} hiilib.");
        }

        public override void TeeMidagi()
        {
            Console.WriteLine($"{Nimi} kraabib diivanit.");
        }
    }
}