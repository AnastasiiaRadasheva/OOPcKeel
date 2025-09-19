using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_c_
{
    public interface ITööline
    {
        double ArvutaPalk();
    }
    public class Pank
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                    saldo = value;
            }
        }
        public void LisaRaha(double summa)
        {
            if(summa> 0)
                saldo += summa;

        }
        public void Võtaraha(double summa)
        {
            if (summa > 0 && summa <= saldo)
                saldo -= summa;
            else
                Console.WriteLine("bebe1 pole raha. hahahaa");
        }
    }
}
