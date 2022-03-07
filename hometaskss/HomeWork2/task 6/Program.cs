using System;

namespace task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 reqemli eded verilib. Bu ededin evvel 20%-ni , sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap.

            double a = 1234;
            double b;
            double c;
            double d;

            if (!(a >= 1000 && a < 10000))
            {
                Console.WriteLine("4 reqemli deyil");
            }

            b = (a * 20) / 100;

            c = (b * 10) / 100;

            d = c * c;
            Console.WriteLine(d);
        }
    }
}
