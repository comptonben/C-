using System;
using System.Linq;

namespace reverseCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "one two three four five";

            string resultString = string.Join(" ", inputString.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine(resultString);
        }
    }
}
