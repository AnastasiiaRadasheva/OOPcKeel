using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using System;

namespace OOP_c_
{
    internal class OOPstart
    {
        public static void Main()
        {
            //Inimene inimene1 = new Inimene();
            //inimene1.Nimi = "Mati";
            //inimene1.Vanus = 30;

            //inimene1.Tervita();
            //Console.WriteLine("Vanus: " + inimene1.Vanus);

            //Inimene inimene2 = new Inimene("Kati", 28);
            //inimene2.Tervita();
            //Console.WriteLine("Vanus: " + inimene2.Vanus);

            //Töötaja töötaja1 = new Töötaja();
            //töötaja1.Nimi = "Jaan";
            //töötaja1.Vanus = 40;
            //töötaja1.Ametikoht = "Insener";

            //töötaja1.Tervita();
            //töötaja1.Töötan();

            //Console.ReadLine();




            //tee ende põhiklass ja 2 alamklassi ning kasuta neid siin
            Console.WriteLine("Loo auto:");
            Auto auto = new Auto();
            auto.Sõida();

            Console.WriteLine("\nLoo jalgratas:");
            Jalgratas jalgratas = new Jalgratas();
            jalgratas.Sõida();

            Console.ReadLine();
        }
    }
}

