using System;
using System.IO;

namespace recursion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double factorial = Factorial(num);
            Console.WriteLine("Factorial of {0} = {1}", num.ToString(), factorial.ToString());
            Console.WriteLine();

            Console.Write("Please enter a path: ");
            string path = Console.ReadLine();
            FindFiles(path);
        }

        // non-recursive version
        //public static double Factorial(int num)
        //{
        //    if (num == 0)
        //        return 1;

        //    double factorial = 1;

        //    for (int i = num; i >=1; i--)
        //    {
        //        factorial = factorial * i;
        //    }

        //    return factorial;
        //}

        // recursive version
        public static double Factorial(int num)
        {
            if (num == 0)
                return 1;

            return num * Factorial(num - 1);
        }

        private static void FindFiles(string path)
        {
            foreach (string fileName in Directory.GetFiles(path))
            {
                Console.WriteLine(fileName);
            }

            foreach (string directory in Directory.GetDirectories(path))
            {
                FindFiles(directory);
            }
        }
    }
}
