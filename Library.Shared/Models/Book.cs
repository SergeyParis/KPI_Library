namespace Library.Shared
{
    public class Book : IBook
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public bool IsGivenUse { get; set; }
        public IAuthor Author { get; set; }
        public IClient Client { get; set; }
        public int MaxBooksForOneClient { get; set; } = -1;

        public Book(string isbn, IAuthor author) : this (isbn, false, author, null) { }
        public Book(string isbn, bool isGivenUse, IAuthor author) : this (isbn, isGivenUse, author, null) { }
        public Book(string isbn, bool isGivenUse, IAuthor author, IClient client)
        {
            ISBN = isbn;
            IsGivenUse = isGivenUse;
            Author = author;
            Client = client;
        }

        public void GiveInUse(IClient client)
        {
            if (client == null)
                return;
            if (MaxBooksForOneClient != -1 && MaxBooksForOneClient <= client.CountBooksNow)
                return;

            Client = client;
        }
        public void TakeFromUse()
        {
            if (Client == null)
                return;
            if (Client.CountBooksNow == 0)
                return;

            Client.CountBooksNow -= 1;
            Client = null;
        }
    }
}
