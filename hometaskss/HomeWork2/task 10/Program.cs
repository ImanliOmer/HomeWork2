using System;

namespace task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 dene 4 reqemli eded verilib.
            //I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
            //Neticeleri bir birinden cix.
            //Alinan cavabin ustune III ededin 7 % faizini gel
            double a = 1234;
            double b = 1234;
            double c = 1234;
            double d;
            double e;
            double a1;
            double b1;
            double c1;
                

            if (!(a >= 1000 && a < 10000))
            {
                Console.WriteLine("a 4 reqemli eded deyil");
            }
            if (!(b >= 1000 && b < 10000))
            {
                Console.WriteLine("b 4 reqemli eded deyil");
            }
            if (!(c >= 1000 && c < 10000))
            {
                Console.WriteLine("c 4 reqemli eded deyil");

            }
            e = (c * 7) / 100;

            a1 = (a * 1) / 100;
            b1 = (b * 2) / 100;
            c1 = (c * 3) / 100;

            d = (a1 - b1 - c1) + e;


            Console.WriteLine(d);

        }
    }
}
