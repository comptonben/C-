using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee()
            //{
            //    ID = 101,
            //    FirstName = "Emp",
            //    LastName = "Loyee"
            //};
            //Console.WriteLine(emp.GetFullName());

            // cannot create an instance of an abstract class

            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Ben",
                LastName = "Compton",
                AnnualSalary = 60000
            };
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("-------------------");

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Sara",
                LastName = "Song",
                HourlyPay = 200,
                TotalHours = 40
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
            Console.WriteLine("-------------------");
        }
    }
}
