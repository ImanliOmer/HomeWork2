using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // 4 reqemli eded verilib. Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333= 73338
            int a = 1234;
            int sum;
     
            if (!( a >=1000 && a <10000) )
            {
                Console.WriteLine("eded 4 reqemli deyil");
            }
            sum = (a + 70000) * 10 + 8; ;

            Console.WriteLine(a);

            
        }
    }
}
