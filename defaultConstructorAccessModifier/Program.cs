using System;
using System.Reflection;

namespace defaultConstructorAccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Customer);
            ConstructorInfo nonPublicConstructorInfo = type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null,
                new Type[] { typeof(string) }, null);
            ConstructorInfo publicConstructorInfo = type.GetConstructor(new Type[] { typeof(int) });

            Console.WriteLine("Is Public: {0}", nonPublicConstructorInfo.IsPublic);
            Console.WriteLine("Is Private: {0}", nonPublicConstructorInfo.IsPrivate);
            Console.WriteLine("Is Protected: {0}", nonPublicConstructorInfo.IsFamily);

            Console.WriteLine("Is Public: {0}", publicConstructorInfo.IsPublic);
            Console.WriteLine("Is Private: {0}", publicConstructorInfo.IsPrivate);
            Console.WriteLine("Is Protected: {0}", publicConstructorInfo.IsFamily);
        }
    }

    class Customer
    {
        public Customer(int ID)
        {

        }

        //private Customer(string name)
        //{

        //}

        protected Customer(string name)
        {

        }
    }
}
