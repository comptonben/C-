using System;

namespace abstractClassConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CorporateCustomer CC = new CorporateCustomer();
            SavingsCustomer SC = new SavingsCustomer();

            Console.WriteLine(CC.ID);
            Console.WriteLine(SC.ID);
        }
    }

    public abstract class Customer
    {
        public Customer()
        {
            this._id = Guid.NewGuid();
            Print();
        }

        private Guid _id;

        public Guid ID
        {
            get
            {
                return this._id;
            }
        }

        public abstract void Print();
    }

    public class CorporateCustomer : Customer
    {
        public CorporateCustomer()
        {

        }

        public override void Print()
        {
            Console.WriteLine("Corporate Customer class Print() method invoked.");
        }
    }

    public class SavingsCustomer : Customer
    {
        public SavingsCustomer()
        {

        }

        public override void Print()
        {
            Console.WriteLine("Savings Customer class Print() method invoked.");
        }
    }
}
