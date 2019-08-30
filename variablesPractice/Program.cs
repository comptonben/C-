using System;

namespace variablesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var number = 2;
                var count = 10;
                var totalPrice = 20.95f;
                var character = 'A';
                var firstName = "Ben";
                var isWorking = false;

                Console.WriteLine(number);
                Console.WriteLine(count);
                Console.WriteLine(totalPrice);
                Console.WriteLine(character);
                Console.WriteLine(firstName);
                Console.WriteLine(isWorking);

                Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
                Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            }


            {
                const float Pi = 3.14f;
                // Pi = 1; cannot do this
            }

            {
                byte b = 1;
                int k = b;
                Console.WriteLine(k);

                int m = 1000;
                byte n = (byte)m;
                Console.WriteLine(n);
            }

            {
                string s = "1";
                int i = Convert.ToInt32(s);
                int j = int.Parse(s);

                Console.WriteLine("{0} {1} {2}", s, i, j);

                try
                {
                    var number = "1234";
                    int m = Convert.ToInt32(number);
                    byte b = Convert.ToByte(number);
                    Console.WriteLine("{0} {1}", m, b);
                }
                catch (Exception)
                {
                    Console.WriteLine("The number could not be converted to a byte.");
                } 
            }

            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
        }
    }
}
