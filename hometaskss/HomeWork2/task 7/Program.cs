using System;

namespace task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dene 5 reqemli eded verilib.
            // Bu ededleri toplayib.
            // Alinan cavabin evveline ve axirina 5 artir.
            // Neticenin 5 % tap

            double a = 99999;
            double b = 88888;
            double c;
            double d;
            if (!(a >= 10000 && a < 100000))
            {
                Console.WriteLine("a 5 reqemli deyil");
            }
            if (!(b >= 10000 && b < 100000))
            {
                Console.WriteLine("b 5 reqemli deyil");
            }

            c = a + b ;
            if (c >= 10000 && c < 100000)
            {
                d = (((c + 500000) * 10 + 5)*5)/100;

                 Console.WriteLine(d);

            }
            else
            {
                d = (((c + 5000000) * 10 + 5) * 5) / 100;
                Console.WriteLine(d);
            }
                

        }

    }
}
