namespace PayrollApp.Entities
{
    public class HumanResource : Employee
    {
        public HumanResource(string name, decimal basicPayment, decimal daPayment, decimal hraPayment, decimal gratuityPayment) : base(name, basicPayment, daPayment, hraPayment)
        {
            GratuityPayment = gratuityPayment;
        }

        public decimal GratuityPayment { get; set; }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            TotalSalary += GratuityPayment;
        }
    }
}
