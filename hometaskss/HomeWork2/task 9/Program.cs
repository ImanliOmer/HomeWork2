using System;

namespace task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 6 reqemli eded verilib.
            // Her birinin 10 faizini tapib neticeleri topla.
            // Alinan cavabin 10% tap.



            double a = 123456;
            double b = 123456;
            double c = 123456;
            double a1;
            double b1;
            double c1;
            double d;

           if(!( a >= 100000 && a < 1000000)) 
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

            a1 = (a * 10) / 100;
            b1 = (b * 10) / 100;
            c1 = (c * 10) / 100;

            d = ((a1 + b1 + c1)*10)/100;
            Console.WriteLine(d);










        }
    }
}
