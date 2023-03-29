namespace PayrollApp.Entities
{
    public class Developer : Employee
    {
        public Developer(string name, decimal basicPayment, decimal daPayment, decimal hraPayment, decimal incenivePayment) : base(name, basicPayment, daPayment, hraPayment)
        {
            IncenivePayment = incenivePayment;
        }

        public decimal IncenivePayment { get; set; }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            TotalSalary += IncenivePayment;
        }
    }
}
