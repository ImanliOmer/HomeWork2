using System;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;
            int a = 123;
            int b;
            int c;


            if(!(a>=100 && a < 1000))
            {
                Console.WriteLine("eded 3 reqemli deyil");
            }

            b = a * 10 + 7;

            c = (b * 7) / 100;

            Console.WriteLine(c);

           


        
        
        }
    }
}
