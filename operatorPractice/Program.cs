using System;

namespace operatorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // postfix increment
                int a = 1;
                int b = a++;
                // a = 2, b = 1
            }
            {
                // prefix increment
                int a = 1;
                int b = ++a;
                // a, b = 2
            }
            {
                var a = 10;
                var b = 3;

                Console.WriteLine((float)a/(float)b);
            }
        }
    }
}
