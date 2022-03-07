using System;

namespace task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7 dene eded verilib.
            // Bunlardan 2 denesi 3 reqemlidir.
            // 2 denesi 4 reqemlidir.
            // 2 denesi 5 reqemlidir.
            // 1 denesi ise 6 reqemlidir.
            // 3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
            //Sonra neticenin axirina 7 reqemini artir.
            //Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            //Sonra alinan cavabin ustune gel 6 reqemli ededi.
            //Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            //Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
            //Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
            double a=123;
            double b=123;
            double c=1234;
            double d=1234;
            double e=12345;
            double f=12345;
            double g=123456;
            double sum;
            double vur;
            double sum2;
            double artir;
            double sum3;
            double sum4;
            double vur2;
            double cix;
            double sum5;
            double cix2;
            double sum6;
            double faiz1;
            double faiz2;
            double faiz3;
            double sum7;
            double sum8;


            if (!(a >= 100 && a < 1000))
            {
                Console.WriteLine("a 3 reqemli eded deyil");
            }

            if (!(b >= 100 && b < 1000))
            {
                Console.WriteLine("b 3 reqemli eded deyil");
            }


            if (!(c >= 1000 && c < 10000))
            {
                Console.WriteLine("c 4 reqemli eded deyil");

            }
            if (!(d >= 1000 && d < 10000))
            {
                Console.WriteLine("a 4 reqemli eded deyil");
            }

            if (!(e >= 10000 && e < 100000))
            {
                Console.WriteLine("b 5 reqemli eded deyil");
            }
            if (!(f >= 10000 && f < 100000))
            {
                Console.WriteLine("b 5 reqemli eded deyil");
            }
            if (!(g >= 100000 && g < 1000000))
            {
                Console.WriteLine("b 6 reqemli eded deyil");
            }



            sum = a + b;
            vur = c * d;
            


            sum2 = sum + vur;
            Console.WriteLine(sum2);
            //1523002
            artir=(sum2 * 1000000)+7;
            //Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
            sum3 = e * f;
            sum4 = sum3 + artir;
            //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
            vur2 = (a * b)* 10 + 1;
            cix = sum4 - vur2;
            //Sonra alinan cavabin ustune gel 6 reqemli ededi.
            sum5 = cix + g;
            //Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
            sum6 = a+b+c+d;
            cix2 = sum5-sum6;
            //Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
            faiz1 = (cix2 * 18) / 100;
            faiz2 = (cix2 * 3) / 100;
            faiz3 = (cix2 * 1) / 100;
            //Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
            sum7 = e + f;
            sum8 = cix2 + sum7;
            Console.WriteLine(sum8);









        }
    }
}
