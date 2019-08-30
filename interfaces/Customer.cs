using System;

namespace interfaces
{
    class Customer : ICustomer
    {
        public void PrintCustomerName()
        {
            Console.WriteLine("Implementation for ICustomer Print()");
        }
    }

}
