namespace PayrollApp.Entities
{
    public class Employee
    {
        private static long IdGenerator;
        static Employee()
        {
            IdGenerator = 10000;
        }

        public Employee(string name, decimal basicPayment, decimal daPayment, decimal hraPayment)
        {
            Id = IdGenerator++;
            Name = name;
            BasicPayment = basicPayment;
            DaPayment = daPayment;
            HraPayment = hraPayment;
        }

        public long Id { get; private set; }
        public string Name { get; set; }
        public decimal BasicPayment { get; set; }
        public decimal DaPayment { get; set; }
        public decimal HraPayment { get; set; }
        public decimal TotalSalary { get; protected set; }

        public virtual void CalculateSalary()
        {
            TotalSalary = BasicPayment + DaPayment + HraPayment;
        }
    }
}
