using System;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 reqemli eded verilib. Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.

            int a = 1234;
            int b;
            int sum;
            if (!(a >= 1000 && a < 100000))
            {
                Console.WriteLine("4 reqemli eded deyil");
            }
            b = (a + 40000)*100 + 44 ;

            sum = (b * 44) / 100;

            Console.WriteLine(sum);



        }
    }
}
