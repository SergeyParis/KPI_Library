namespace Library.Shared.Models
{
    public class Client : IClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountBooksNow { get; set; }

        public Client(string name): this (name, 0) { }
        public Client(string name, int countBooksNow)
        {
            Name = name;
            CountBooksNow = countBooksNow;
        }
    }
}
