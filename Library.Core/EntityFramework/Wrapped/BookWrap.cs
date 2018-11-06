using Library.Shared;
using System;

namespace Library.Core.EntityFramework
{
    public class BookWrap : IBook
    {
        private Action<IClient> GiveInUseFunc;
        private Action TakeFromUseFunc;

        public int Id { get; set; }
        public int ISBN { get; set; }
        public bool IsGivenUse { get; set; }
        public IAuthor Author { get; set; }
        public IClient Client { get; set; }
        public int MaxBooksForOneClient { get; set; } = -1;
        
        public BookWrap() { }
        public BookWrap(IBook book)
        {
            Id = book.Id;
            ISBN = book.ISBN;
            IsGivenUse = book.IsGivenUse;
            Author = book.Author;
            Client = book.Client;
        }

        public void GiveInUse(IClient client) => GiveInUseFunc?.Invoke(client);
        public void TakeFromUse() => TakeFromUseFunc?.Invoke();
    }
}
