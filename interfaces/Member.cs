using System;

namespace interfaces
{
    class Member : Customer, IMember
    {
        public void PrintMembershipLength()
        {
            Console.WriteLine("2 years.");
        }
    }

}
