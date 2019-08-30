using System;
using System.Collections;

namespace diffTypeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // storing different types in the same array
            object[] array = new object[3];
            array[0] = 1;
            array[1] = "string";

            Customer c = new Customer();
            c.ID = 99;
            c.Name = "Ben";
            array[2] = c;

            foreach (object obj in array)
            {
                Console.WriteLine(obj);
            }

            // using System.Collections
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("string");
            arrayList.Add(c);

            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
    }
}
