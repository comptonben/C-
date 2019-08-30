namespace classes
{
    public class ContractEmployee : Employee
    {

        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        public override int GetMonthlySalary()
        {
            return this.TotalHours * this.HourlyPay;
        }
    }
}
