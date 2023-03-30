namespace OutstandingPersonApp.Entities
{
    public class Professor : Person
    {
        public Professor(string name, int booksPublished) : base(name)
        {
            BooksPublished = booksPublished;
        }

        public int BooksPublished { get; set; }

        public override bool IsOutstanding()
        {
            return BooksPublished >= 5;
        }
        public string Print()
        {
            return $"{Name}, {BooksPublished}";
        }
    }
}
