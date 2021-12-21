using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sumator
    {
        //i
        public int[] Liczby;
        private float sum = 0;
        int wartosc = 0;

        public Sumator(int[] liczby, float sum)
        {
            Liczby = liczby;
            this.sum = sum;
        }

        //b
        //private float[] Liczby; 

        //c
        public int IleElementów()
        {
            return Liczby.Length;
        }

        //ii
        public int Sum()
        {
            for(int i = 0; i<Liczby.Length; i++)
            {
                wartosc += Liczby[i];
            }
            return wartosc;
        }

        //iii
        public int podziel()
        {
            int sum = 0;
            for(int i = 0; i < Liczby.Length; i++)
            {
                if (Liczby[i] % 2 == 0)
                    sum += Liczby[i];
            }
            return sum;
        }

        //d
        public void wypiszLiczby()
        {
            Console.WriteLine("Liczby w tablicy wypisane po kolei: ");
            for(int i = 0; i < Liczby.Length; i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }

        //e
        public void wypiszZakres(int lowIndex, int highIndex)
        {
            for (int i = Math.Max(0, lowIndex); i <= Math.Min(highIndex, Liczby.Length); i++)
            {
                Console.WriteLine(Liczby[i]);
            }
        }

    }
}
