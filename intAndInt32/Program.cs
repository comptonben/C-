using System;

namespace intAndInt32
{
    enum intTest: int
    {
        test = 1,
    }

    enum int32Test: Int32
    {
        test = 1,
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Int32 j = 10;

            Console.WriteLine("int i = {0}", i);
            Console.WriteLine("int32 j = {0}", j);
            Console.WriteLine("int i + int32 j = {0}", i+j);
        }
    }
}
