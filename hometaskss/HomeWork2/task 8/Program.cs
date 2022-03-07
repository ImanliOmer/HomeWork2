using System;

namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2 dene eded verilib.
            //I eded 4 reqemli II eded 7 reqemlidir.
            //I ededin 4%-ni tap.
            //Sonra II ededin 9% ni tap.
            //Sonra Cavalari toplayib 10 %ni tap.



            int a = 1234;
            int b = 1234567;
            int c;

           
            if (!(a >= 1000 && a < 10000))
                {
                Console.WriteLine(" a 4 reqemli deyil");
            }


            if (!(b >= 1000000 && b < 10000000))
            {
                Console.WriteLine(" b 7 reqemli deyil");
            }



            a = (a *4)/100;

            b = (b *9)/100;

            c = ((a + b)*10)/100;

            Console.WriteLine(c);








        }
    }
}
