using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Licz ob1 = new Licz(1);

            //ob1.wartosc = 2;
            //Console.WriteLine("Wartosc: " + ob1.wartosc);

            Console.WriteLine("Zadanie 1");
            ob1.wypisz();
            Console.WriteLine("Dodaj: " + ob1.dodaj(12));
            Console.WriteLine("Dodaj: " + ob1.dodaj(2));
            Console.WriteLine("Dodaj: " + ob1.dodaj(3));
            Console.WriteLine("Dodaj: " + ob1.odejmij(5));

            Console.WriteLine("-------------");

            Console.WriteLine("Zadanie 2");
            int[] Liczby = { 1, 10, 7, 2, 20, 15, 18,4};
            int suma = 0;
            Sumator s1 = new Sumator(Liczby, suma);
            s1.wypiszLiczby();
            Console.WriteLine("Ilosc elementow: " + s1.IleElementów());
            Console.WriteLine("Suma: " + s1.Sum());
            Console.WriteLine("Suma wszystkich elementów, podzielonych przez 2: " + s1.podziel());
            Console.WriteLine("Indeksy: ");
            s1.wypiszZakres(0, 5);

            Console.WriteLine("-------------");

            Console.WriteLine("Zadanie 3");
            Data data = new Data(21, 4, 2021);
            Console.WriteLine("Dana data to: ");
            data.data_wypisanie();
        }

    }
}
