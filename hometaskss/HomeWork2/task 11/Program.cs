using System;

namespace task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // 4 dene 5 reqemli eded verilib.
           // I ededin ustune III ededi gel.
           // II ededin usutune IV eeddi gel.
           // Sonra cavablari vur birbirine.
           // Alinan neticeden III ededin 3 % -ni cix.
           double a = 12345;
           double b = 12345;
           double c = 12345;
           double d = 12345;
           double e;
           double f;
           double g;

           double h;

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
            if (!(d >= 10000 && d < 100000))
            {
                Console.WriteLine("d 5 reqemli eded deyil");
            }

             h = (c * 3) / 100; 

             e = a + c;
             f = b + d;
             g = (e * f) - h;

            Console.WriteLine(g);
                







        }
    }
}
