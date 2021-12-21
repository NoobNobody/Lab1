using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        class Data
        {
            public int day { get; private set; }
            public int month { get; private set; }
            public int year { get; private set; }

            public Data(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }

            public void Date()
            {

            }
            public void data_wypisanie()
            {
                Console.WriteLine(day + "-" + month + "-" + year);
            }
        }
