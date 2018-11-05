namespace Library.Shared.Models
{
    public class Client : IClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountBooksNow { get; set; }
    }
}
