using System;

namespace task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 4 dene 6 reqemli eded verilib.
           // Ededlerin hamisinin 10 faizini tap ve topla.
           // Sonra hamisinin 15 faizini tap ve topla.
           // Sonra yekunda alinanlar iki cavabi vur biri birine.
           // Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.
           double a = 123456;
           double b = 123456;
           double c = 123456;
           double d = 123456;
           double a1;
           double b1;
           double c1;
           double d1;
           double a2;
           double b2;
           double c2;
           double d2;
           double sum1;
           double sum2;
           double hasil;

            if (!(a >= 100000 && a < 1000000))
            {
                Console.WriteLine("a 6 reqemli eded deyil");
            }

            if (!(a >= 100000 && a < 1000000))
            {
                Console.WriteLine("b 6 reqemli eded deyil");
            }

            if (!(a >= 100000 && a < 1000000))
            {
                Console.WriteLine("c 6 reqemli eded deyil");
            }

            if (!(a >= 100000 && a < 1000000))
            {
                Console.WriteLine("d 6 reqemli eded deyil");
            }

            a1 = (a * 10) / 100;
            b1= (b * 10) / 100;
            c1 = (c * 10) / 100;
            d1 = (d * 10) / 100;

            sum1 = a1 + b1 + c1 + d1;
            Console.WriteLine(sum1);


            a2 = (a * 15) / 100;
            b2 = (b * 15) / 100;
            c2 = (c * 15) / 100;
            d2 = (d * 15) / 100;

            sum2 = a2 + b2 + c2 + d2;
            Console.WriteLine(sum2);

            hasil = sum1 * sum2;
            Console.WriteLine(hasil);


            hasil =  (hasil * 10) / 100;
            Console.WriteLine($"10 FAIZ {hasil}");
            hasil = (hasil * 11) / 100;
            Console.WriteLine($"11 FAIZ {hasil}");











        }
        

    }
}
