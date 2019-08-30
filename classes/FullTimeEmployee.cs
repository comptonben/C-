namespace classes
{
    public class FullTimeEmployee : Employee
    {
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
