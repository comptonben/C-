using System;

namespace classes
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public abstract int GetMonthlySalary();
    }
}
