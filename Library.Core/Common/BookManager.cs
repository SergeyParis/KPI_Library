using Library.Shared;
using Library.Core.EntityFramework;

namespace Library.Core
{
    public static class BookManager
    {
        private static LibraryContext _context;

        static BookManager()
        {
            _context = new LibraryContext();
        }

        public static void AddBook(IBook book)
        {
            if (book == null)
                return;

            _context.Books.Add(new BookWrap(book));
        }

        public static void GiveBookInUse(int bookId, int clientId)
        {
            var book = _context.Books.Find(bookId);
            var client = _context.Clients.Find(clientId);

            book.GiveInUse(client);
        }
    }
}
