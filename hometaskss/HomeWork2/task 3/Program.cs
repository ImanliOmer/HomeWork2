using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.

            double a = 12345;
            double b;
            double c;
            if (!(a >= 10000 && a < 1000000))
            {
                Console.WriteLine("a 5 reqemlidir ");
            }

            b = (a * 18)/100 ;
            Console.WriteLine(b);


            c = (a * 3)/100;

            Console.WriteLine(c);


        }
    }
}
