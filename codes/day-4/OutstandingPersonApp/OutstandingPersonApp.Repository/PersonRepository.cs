using OutstandingPersonApp.Entities;

namespace OutstandingPersonApp.Repository
{
    public static class PersonRepository
    {
        //public Person[] People { get; } = new Person[4];
        static readonly Person[] people;
        static PersonRepository()
        {
            people = new Person[4];
        }
        public static Person[] People => people;
    }
}
