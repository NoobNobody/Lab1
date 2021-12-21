using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Licz
    {
        //i
        //public float wartosc;

        //c
        float wartosc;

        //b
        public Licz(float wartosc)
        {
            this.wartosc = wartosc;
        }

        //ii
        public float dodaj(float a)
        {
            return wartosc += a;
        }

        //iii
        public float odejmij(float a)
        {
            return wartosc -= a;
        }

        public void wypisz()
        {
            Console.WriteLine("Wartosc: " + wartosc);
        }

    }
}
