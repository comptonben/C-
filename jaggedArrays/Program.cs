using System;

namespace jaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jagged Arrays
            string[] employeeNames = new string[3];
            employeeNames[0] = "Mark";
            employeeNames[1] = "Matt";
            employeeNames[2] = "John";

            string[][] jaggedArray = new string[3][];

            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            jaggedArray[0][0] = "Bachelors";
            jaggedArray[0][1] = "Masters";
            jaggedArray[0][2] = "Doctorate";

            jaggedArray[1][0] = "Bachelors";

            jaggedArray[2][0] = "Bachelors";
            jaggedArray[2][1] = "Masters";

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(employeeNames[i]);
                Console.WriteLine("--------------");
                string[] innerArray = jaggedArray[i];
                for (int j = 0; j < innerArray.Length; j++)
                {
                    Console.WriteLine(innerArray[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
