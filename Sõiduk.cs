using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

namespace OOP_c_
{
    public class Sõiduk
    {
        public string Nimi;

        public Sõiduk()
        {
            Console.Write("Sisesta sõiduki nimi: ");
            Nimi = Console.ReadLine();
        }

        public Sõiduk(string nimi)
        {
            Nimi = nimi;
        }

        public virtual void Sõida()
        {
            Console.WriteLine($"{Nimi} liigub.");
        }
    }
}
