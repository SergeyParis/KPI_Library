using System.Data.Entity;
using Library.Shared;
using Library.Core.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace Library.Core
{
    public static class BookManager
    {
        private static LibraryContext _context;

        static BookManager()
        {
            _context = new LibraryContext();
        }

        // TODO: REMOVE!!!
        public static void DROP_DB() => _context.Database.Delete();
        //

        public static IEnumerable<IBook> GetAllBooks() => _context.Authors.Include().ToArray();

        public static void AddBook(IBook book, IAuthor author)
        {
            if (book == null)
                return;

            _context.Books.Add(new BookWrap(book));
            _context.Authors.Add(new AuthorWrap(author));

            _context.SaveChanges();
        }

        public static void GiveBookInUse(int bookId, int clientId)
        {
            var book = _context.Books.Find(bookId);
            var client = _context.Clients.Find(clientId);

            client.GiveInUse(book);
            _context.SaveChanges();
        }
    }
}
