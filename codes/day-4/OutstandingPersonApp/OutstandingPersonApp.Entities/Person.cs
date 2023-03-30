namespace OutstandingPersonApp.Entities
{
    public abstract class Person
    {
        static int IdGenerator = 100;
        public Person()
        {
        }

        public Person(string name)
        {
            Name = name;
            Id = IdGenerator++;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public abstract bool IsOutstanding();
    }
}
