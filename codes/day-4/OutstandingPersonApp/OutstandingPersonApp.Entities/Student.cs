namespace OutstandingPersonApp.Entities
{
    public class Student : Person
    {
        public Student(string name, int marks) : base(name)
        {
            Marks = marks;
        }

        public int Marks { get; set; }
        public override bool IsOutstanding()
        {
            //return Marks >= 85 ? true : false;
            return Marks >= 85;
        }
        public string Show()
        {
            return $"{Name}, {Marks}";
        }
    }
}
