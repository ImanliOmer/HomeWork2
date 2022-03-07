using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 reqemli eded verilib. Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333= 333333;

            int a = 333;
            int sum;

            if (!(a>=100 && a<1000))
            {
                Console.WriteLine("a 3 reqemli edetdir");
            }
            sum = a * 1000+ a;
            Console.WriteLine(sum);







 
        }
    }
}
