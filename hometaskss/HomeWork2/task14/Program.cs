using System;

namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 dene 6 reqemli eded verilib.
            //Evvel hamisini topla .
            //Sonra I ve III ededi bir birine yapishdir ve bir eded al.
            //I neticeden II neticeni cix.
            //Alinan cavabin 10 % tap.
            //Neticenin uzerine V ve VI ededleri gel.
            //Yekunda alinan cavabin 11 % tap.
            double a=123456;
            double b=123456;
            double c=123456;
            double d=123456;
            double e=123456;
            double f=123456;
            double sum1;
            double sum2;
            double minus;
            double faiz;
            double sum3;
            double faiz2;
            if (!(a >= 100000 && a < 1000000))
            {
                Console.WriteLine("a 6 reqemli eded deyil");
            }

            if (!(b >= 100000 && b < 1000000))
            {
                Console.WriteLine("b 6 reqemli eded deyil");
            }


            if (!(c >= 100000 && c < 1000000))
            {
                Console.WriteLine("c 6 reqemli eded deyil");

            }
            if (!(d >= 100000 && d < 1000000))
            {
                Console.WriteLine("a 6 reqemli eded deyil");
            }

            if (!(e >= 100000 && e < 1000000))
            {
                Console.WriteLine("b 6 reqemli eded deyil");
            }


            if (!(f >= 100000 && f < 1000000))
            {
                Console.WriteLine("c 6 reqemli eded deyil");
            }

            sum1 = a + b + c + d + e + f;
            sum2 = a + c;
            minus = sum1 - sum2;


            faiz = (minus * 10) / 100;
            sum3 = faiz + e + f;

            faiz2 = (sum3 * 11) / 100;
            Console.WriteLine(faiz2);




        }
    }
}
