using System;

namespace equals
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = ".NET Interview questions";
            object o1 = new string(".NET Interview questions".ToCharArray());

            // *string data type always does content comparisons*
            Console.WriteLine(o == o1);         // compares references not contents
            Console.WriteLine(o.Equals(o1));    // compares contents not references
        }
    }
}
