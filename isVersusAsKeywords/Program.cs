using System;

namespace isVersusAsKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                ID = 101,
                Name = "Ben"
            };

            PermanentEmployee pemp = new PermanentEmployee
            {
                ID = 102,
                Name = "Ben"
            };

            ContractEmployee cemp = new ContractEmployee
            {
                ID = 103,
                Name = "Ben"
            };

            if (emp is Employee)
                Console.WriteLine("{0} is Employee", emp.Name);
            else
                Console.WriteLine("{0} is not Employee", emp.Name);

            if (emp is PermanentEmployee)
                Console.WriteLine("{0} is PermanentEmployee", emp.Name);
            else
                Console.WriteLine("{0} is not PermanentEmployee", emp.Name);

            if (emp is ContractEmployee)
                Console.WriteLine("{0} is ContractEmployee", emp.Name);
            else
                Console.WriteLine("{0} is not ContractEmployee", emp.Name);

            PermanentEmployee permanentEmp = emp as PermanentEmployee;
            if (permanentEmp == null)
                Console.WriteLine("permanentEmployee is NULL");
            else
                Console.WriteLine("permanentEmployee is not NULL");

            ContractEmployee contractEmp = emp as ContractEmployee;
            if (contractEmp == null)
                Console.WriteLine("contractEmployee is NULL");
            else
                Console.WriteLine("contractEmployee is not NULL");

            Employee newEmp = pemp as Employee;
            if (newEmp == null)
                Console.WriteLine("newEmp is NULL");
            else
                Console.WriteLine("newEmp is not NULL");

            Employee newerEmp = cemp as Employee;
            if (newerEmp == null)
                Console.WriteLine("newerEmp is NULL");
            else
                Console.WriteLine("newerEmp is not NULL");

            try
            {
                PermanentEmployee permEmp = (PermanentEmployee)emp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(value: ex.Message);
            }
        }

        class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        class PermanentEmployee : Employee
        {
            public int AnnualSalary { get; set; }
        }

        class ContractEmployee : Employee
        {
            public int HourlySalary { get; set; }
        }
    }
}
