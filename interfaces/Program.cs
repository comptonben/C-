using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.PrintCustomerName();
            Console.WriteLine("----------");

            Member M1 = new Member();
            M1.PrintCustomerName();
            M1.PrintMembershipLength();
            Console.WriteLine("----------");

            /* 
             * Why would you use interfaces?
             * 
             * An interface does not contain any implementation, only declarations. So what is the benefit of using an interface?
             * 
             * Why would you define an interface, have a class implement that interface and then access the class through the
             * interface instead of just using the class directly?
             * 
             * Advantages:
             *      Interfaces allow us to develop loosely coulpled systems.
             *      Interfaces are very useful for Dependency Injection.
             *      Interfaces make unit testing and mocking easier.
             */
        }
    }
}
