using System;

namespace task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 dene eded verilib.
            // Bunlardan 3 denesi 5 reqemli.
            // 2 denesi ise 3 reqemlidir.
            // 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
            // Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla.
            // Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.

            double a = 12345;
            double b = 12345;
            double c = 12345;
            double d = 123;
            double e = 123;
            double a1;
            double b1;
            double c1;
            double d1;
            double e1;
            double faiz1;
            double faiz2;
                
            //
            double hasil;
            double cem;
            double sum;




            if (!(a >= 10000 && a < 100000))
            {
                Console.WriteLine("a 5 reqemli eded deyil");
            }
            if (!(b >= 10000 && b < 100000))
            {
                Console.WriteLine("b 5 reqemli eded deyil");
            }
            if (!(c >= 10000 && c < 100000))
            {
                Console.WriteLine("c 5 reqemli eded deyil");
            }
            if (!(d >= 100 && d < 1000))
            {
                Console.WriteLine("a 3 reqemli edetdir");
            }
            if (!(e >= 100 && e < 1000))
            {
                Console.WriteLine("a 3 reqemli edetdir");
            }

            a1 = (a * 5) / 100;
            b1 = (b * 5) / 100;
            c1 = (c * 5) / 100;

            hasil = a1 * b1 * c1;


            d1 = (d * 5) / 100;
            e1 = (e * 5) / 100;
            cem = d1 + e1;



            faiz1 = (hasil * 10) / 100;
            faiz2 = (cem * 10) / 100;

            sum = faiz1 + faiz2;
            Console.WriteLine(sum);










        }
    }
}
